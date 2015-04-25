Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Public Class DataManager
  Public Event MsgEvent(Messagetext As String)
  Private ReadOnly _ConnectionString As String
  Private ReadOnly _conn As SqlConnection
  Public Sub New(ByVal strConnectionString As String)
    _ConnectionString = strConnectionString
    _conn = New SqlConnection(_ConnectionString)
    OpenConnection()
  End Sub
  Public Sub OpenConnection()
    On Error GoTo ErrorHandler
    If _conn.State = ConnectionState.Closed Then _conn.Open()
    Exit Sub
ErrorHandler:
    RaiseEvent MsgEvent("DataManager.InitConnection() ConnectionString " & _ConnectionString & " - Error Number:" & Err.Number & " Error Description:" & Err.Description & " Error Source:" & Err.Source)
  End Sub
  Public Sub CloseConnection()
    If _conn.State = ConnectionState.Open Then _conn.Close()
  End Sub
  Public Sub AddParameter(ByRef Parameter() As SqlClient.SqlParameter, ByRef ParameterName As String, ByVal ParameterType As SqlDbType, ByVal Value As Object, _
                            Optional ByVal DefaultValue As Object = Nothing, Optional ByVal Direction As System.Data.ParameterDirection = ParameterDirection.Input)
    Dim NewLenght = 0
    If IsNothing(Parameter) Then
      ReDim Parameter(0)
    Else
      NewLenght = Parameter.Length
      ReDim Preserve Parameter(NewLenght)
    End If
    Parameter(NewLenght) = New SqlClient.SqlParameter(ParameterName, ParameterType)
    If IsNothing(Value) Then Value = DefaultValue
    Parameter(NewLenght).Value = Value
  End Sub
#Region "Dataset Functions"
  Public Function GetDataSetFromSQL(ByVal strQuery As String, ByVal parameters() As SqlParameter) As DataSet

    Dim ds As DataSet = New DataSet()
    RaiseEvent MsgEvent("GetDataSetFromSQL: " & strQuery)
    Dim da As SqlDataAdapter = New SqlDataAdapter(strQuery, _conn)
    If Not IsNothing(parameters) Then
      For Each parm As SqlParameter In parameters
        da.SelectCommand.Parameters.Add(parm)
      Next
    End If
    da.Fill(ds)
    Return ds
  End Function
  Public Function GetDataSetFromSP(ByVal strStoredProcedureName As String, ByVal parameters() As SqlParameter) As DataSet

    Dim ds As DataSet = New DataSet()
    Dim dc As SqlCommand = New SqlCommand(strStoredProcedureName, _conn)
    RaiseEvent MsgEvent("GetDataSetFromSP: " & strStoredProcedureName)
    dc.CommandType = CommandType.StoredProcedure
    Dim da As SqlDataAdapter = New SqlDataAdapter(dc)
    If Not IsNothing(parameters) Then
      For Each parm As SqlParameter In parameters
        dc.Parameters.Add(parm)
      Next
    End If
    da.Fill(ds)
    Return ds
  End Function
#End Region
  Public Function RunSQL(ByVal sql As String) As Boolean
    Dim bolCompleted As Boolean = False
    Dim myCommand As SqlCommand = New SqlCommand(sql, _conn)
    Try
      RaiseEvent MsgEvent("RunSQL: " & sql)
      myCommand.ExecuteNonQuery()
      bolCompleted = True
    Catch ex As Exception
      RaiseEvent MsgEvent("RunSQL: " & ex.Message)
      bolCompleted = False
    End Try
    myCommand.Dispose()
    Return bolCompleted
  End Function
#Region "DataReader"
  Public Function GetSQL(ByVal QueryText As String) As SqlDataReader

    Dim tempDataReader As SqlDataReader
    Try
      Dim SQLCmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(QueryText, _conn)
      SQLCmd.CommandType = CommandType.Text
      RaiseEvent MsgEvent("GetSQL: " & QueryText)
      tempDataReader = SQLCmd.ExecuteReader()
      SQLCmd.Dispose()
    Catch ex As Exception
      'RaiseEvent MsgEvent("GetDataReaderFromQuery() : " & ex.Message, QueryText, Event_Enum.ErrorEvent)
      RaiseEvent MsgEvent("GetSQL: " & ex.Message)
      tempDataReader = Nothing
    End Try
    Return tempDataReader

    '    On Error GoTo ErrorHandler
    '    Dim SQLCmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(QueryText, _conn)
    '    SQLCmd.CommandType = CommandType.Text
    '    Return SQLCmd.ExecuteReader()    ' <--------------------------------------------------------------- This method does not handle a Timeout Error.
    '    Exit Function
    'ErrorHandler:
    '    EventLog(0, "GetDataReaderFromQuery()", QueryText, Event_Enum.ErrorEvent)
  End Function
  Public Function GetDataReaderFromSP(ByVal strStoredProcedureName As String, _
                                      ByVal parameters() As SqlParameter) As SqlDataReader

    Dim FlatParams As String = "strStoredProcedureName:'" & strStoredProcedureName & "'"
    Dim tempDataReader As SqlDataReader
    Try
      Dim SQLCmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(strStoredProcedureName, _conn)
      RaiseEvent MsgEvent("StoredProcedure: " & strStoredProcedureName)
      SQLCmd.CommandType = CommandType.StoredProcedure
      If Not IsNothing(parameters) Then
        For Each parm As SqlParameter In parameters
          SQLCmd.Parameters.Add(parm)
          FlatParams &= "," & InputVar(parm.ParameterName, "Missing Param") & ":'" & InputVar(parm.Value, "") & "'"
        Next
      End If
      tempDataReader = SQLCmd.ExecuteReader()
    Catch ex As Exception
      'Dim RequestInput As New System.Web.Script.Serialization.JavaScriptSerializer(), SerializedReq As New System.Text.StringBuilder : RequestInput.Serialize(FlatParams, SerializedReq)
      FlatParams &= ",ExceptionMessage:" & ex.Message ' Err.Description
      RaiseEvent MsgEvent("Error: " & ex.Message)
      'EventLog(0, "GetDataReaderFromSP()", FlatParams.ToString, Event_Enum.ErrorEvent)
      tempDataReader = Nothing
    End Try
    Return tempDataReader
    '    On Error GoTo ErrorHandler
    '    Dim SQLCmd As New SqlClient.SqlCommand(strStoredProcedureName, _conn)
    '    SQLCmd.CommandType = CommandType.StoredProcedure
    '    If Not IsNothing(parameters) Then
    '      For Each parm As SqlParameter In parameters
    '        SQLCmd.Parameters.Add(parm)
    '      Next
    '    End If
    '    Return SQLCmd.ExecuteReader()    ' <--------------------------------------------------------------- This method does not handle a Timeout Error.
    '    Exit Function
    'ErrorHandler:
    '    'Resume Next
    '    Dim FlatParams As String = "Parameter List not available at this time."
    '    Dim RequestInput As New System.Web.Script.Serialization.JavaScriptSerializer(), SerializedReq As New System.Text.StringBuilder : RequestInput.Serialize(parameters, SerializedReq)
    '    EventLog(0, "GetDataReaderFromSP()", SerializedReq.ToString, Event_Enum.ErrorEvent)
  End Function
#End Region
  ''' <summary>
  ''' Executes a query which modifies the database.
  ''' </summary>
  ''' <param name="SQL_Statement">String SQL statement to execute.</param>
  Function ModifyDatabase(ByVal SQL_Statement As String) As Boolean

    Dim myCommand As New Data.SqlClient.SqlCommand(SQL_Statement, _conn)


    Dim bolCompleted As Boolean = False
    Dim bolFailed As Boolean = False

    Do While Not bolCompleted

      Try
        RaiseEvent MsgEvent("ModifyDatabase: " & SQL_Statement)
        myCommand.Connection.Open()
        myCommand.ExecuteNonQuery()
        bolCompleted = True
      Catch
        bolFailed = True
        RaiseEvent MsgEvent("ERROR: " & Err.Description)


        If Err.Number = 1205 Then
          '-- 1205 is an SQL Deadlock victim error message. --
          Err.Clear()
        End If
      Finally
        bolCompleted = True
      End Try
    Loop
    myCommand.Dispose()
    Return Not bolFailed
  End Function

  Public Function CleanupSqlField(ByVal Value As String) As String
    Dim ReturnValue As String = Value
    ReturnValue = Replace(ReturnValue, "'", "''")
    ReturnValue = Replace(ReturnValue, """", """")
    ReturnValue = Replace(ReturnValue, "\", "\\")
    Return ReturnValue
  End Function
  ' Retrieve a disconnected datatable from the database.
  Public Function RetrieveDataTable(ByVal SQL_Statement As String) As DataTable
    'HttpContext.Current.Response.Write(SQL_Statement & "<BR>")
    '======================================================================
    ' RetrieveDataTable()
    '   Retrieve a disconnected datatable from the database
    '______________________________________________________________________
    Dim dtb As New DataTable
    Dim adt As New SqlDataAdapter()
    Dim strErrorMSG As String = ""
    Dim bolCompleted As Boolean = False
    Dim bolFailed As Boolean = False

    Do While Not bolCompleted
      strErrorMSG = ""
      Try
        RaiseEvent MsgEvent("RetrieveDataTable: " & SQL_Statement)
        adt.SelectCommand = New SqlCommand(SQL_Statement, _conn)
        adt.Fill(dtb)
        bolCompleted = True
      Catch
        If Not bolFailed Then
          strErrorMSG = "RetrieveDataTable(): " & Err.Number & ", " & Err.Source & ", " & Err.Description & ", " & SQL_Statement
          'EventLog.WriteEvent("",)'  MsgBox(strErrorMSG)
        End If
        If Err.Number = 1205 Then
          '-- 1205 is an SQL Deadlock victim error message. --
          bolFailed = True
          Err.Clear()
        End If
      Finally

        bolCompleted = True
      End Try
    Loop
    Return dtb
  End Function



  Function Default_ToNULL(Value As Integer, Optional DefaultInt As Integer = default_Int) As String
    If Value = DefaultInt Then
      Return "NULL"
    Else
      Return Value.ToString
    End If
  End Function
  Function Default_ToNULL(Value As String, Optional DefaultStr As String = "") As String
    If Value = DefaultStr Then
      Return "'NULL'"
    Else
      Return "'" & Value & "'"
    End If
  End Function
  Function Default_ToNULL(Value As Object, Optional DefaultStr As String = "") As String
    Dim number As Integer, Defaultnumber As Integer
    Dim result As Boolean = Int32.TryParse(Value.ToString, number)
    Dim Defaultresult As Boolean = Int32.TryParse(DefaultStr, Defaultnumber)
    If result Then
      Return Default_ToNULL(number, Defaultnumber)
    Else
      Return Default_ToNULL(Value.ToString, DefaultStr)
    End If
  End Function
End Class