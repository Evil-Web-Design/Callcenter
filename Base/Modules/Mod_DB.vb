Imports UniBase
Public Module Mod_DB
  Public Structure ConnString
    Dim DataSource As String  '=MAINSERVER3
    Dim Database As String  '=predictive
    Dim UserName As String  '=sa
    Dim UserPassword As String  '=ou812sql

    Dim Provider As String
    Dim Enabled As Boolean
    Dim OptionalDatabase As String
    Dim connectionString As String
  End Structure
  Public Connection() As ConnString
  Public DB_CallCenter As Integer
  Public DB_Recordings As Integer
  Enum DB
    CallCenter
    Recordings
  End Enum
  Public Event MsgEvent(Messagetext As String)

  Public Sub SetConntoString(ByRef Conn As ConnString)
    Dim Database As String = Conn.Database
    With Conn
      If Not IsNothing(.OptionalDatabase) Then
        If .OptionalDatabase.Length > 0 Then
          Database = .OptionalDatabase
        End If
      End If
    End With
    Conn.connectionString = "Data Source=" & Conn.DataSource & ";" & _
            "Initial Catalog=" & Database & ";" & _
            "Persist Security Info=True;" & _
            "User ID=" & Conn.UserName & ";" & _
            "Password=" & Conn.UserPassword & ";"
  End Sub

  Public Function CleanCSVString(input As String) As String
    Dim output As String = """" & input.Replace("""", """""").Replace(vbCr & vbLf, " ").Replace(vbCr, " ").Replace(vbLf, "") & """"
    Return output
  End Function
  Public Function UpdateDataTable(ByVal SQL_Statement As String, ByVal DataRow As System.Data.DataRow, ByVal ConnString As String) As Data.DataTable
    'HttpContext.Current.Response.Write(SQL_Statement & "<BR>")
    '======================================================================
    ' UpdateDataTable()
    '   Retrieve, Update, Insert Into a disconnected datatable from the database
    '______________________________________________________________________
    Dim dtb As New System.Data.DataTable
    Dim conn As New System.Data.SqlClient.SqlConnection()
    Dim adt As New System.Data.SqlClient.SqlDataAdapter()
    Dim bolCompleted As Boolean = False
    Dim bolFailed As Boolean = False
    conn.ConnectionString = ConnString
    Do While Not bolCompleted
      Try
        RaiseEvent MsgEvent("UpdateDataTable: " & SQL_Statement)

        adt.SelectCommand = New Data.SqlClient.SqlCommand(SQL_Statement, conn)
        If dtb.Rows.Count > 0 Then
          For Each rsRow As System.Data.DataRow In dtb.Rows
            rsRow = DataRow
          Next
        Else
          Dim rsRow As System.Data.DataRow
          rsRow = DataRow
          dtb.Rows.Add(rsRow)
          DataRow = dtb.NewRow()
        End If

        adt.Fill(dtb)
        bolCompleted = True
      Catch
        If Not bolFailed Then
          'DataLog("CIPLib.vb RetrieveDataTable(): " & Err.Number & ", " & Err.Source & ", " & Err.Description & ", " & SQL_Statement)
        End If
        If Err.Number = 1205 Then
          '-- 1205 is an SQL Deadlock victim error message. --
          bolFailed = True
          Err.Clear()
        End If
      Finally
        conn.Close()
        conn = Nothing
        bolCompleted = True
      End Try
    Loop
    Return dtb
  End Function
#Region "Region AddSet"
  Public Function AddSet(ByRef BaseValue As String, _
              ByVal ChangedValue As String, _
              ByVal ColumnName As String, _
              ByVal CurrentString As String) As String
    Dim ReturnString As String = ""
    If BaseValue <> ChangedValue Then
      If Len(CurrentString) > 0 Then ReturnString = ","
      BaseValue = ChangedValue
      ReturnString &= ColumnName & " = '" & ChangedValue & "'"
    End If
    Return ReturnString
  End Function
  Public Function AddSet(ByVal BaseValue As Integer, _
              ByVal ChangedValue As Integer, _
              ByVal ColumnName As String, _
              ByVal CurrentString As String) As String
    Dim ReturnString As String = ""
    If BaseValue <> ChangedValue Then
      If Len(CurrentString) > 0 Then ReturnString = ","
      BaseValue = ChangedValue
      ReturnString &= ColumnName & " = " & ChangedValue.ToString
    End If
    Return ReturnString
  End Function
  Public Function AddSet(ByVal BaseValue As Boolean, _
              ByVal ChangedValue As Boolean, _
              ByVal ColumnName As String, _
              ByVal CurrentString As String) As String
    Dim ReturnString As String = ""
    If BaseValue <> ChangedValue Then
      If Len(CurrentString) > 0 Then ReturnString = ","
      BaseValue = ChangedValue
      ReturnString &= ColumnName & " = " & ChangedValue.ToString
    End If
    Return ReturnString
  End Function
  Public Function AddWhere(ByRef SQLWhere As String, ByVal Newitem As String, _
          Optional ByVal delemeter As String = "OR") As String
    If Len(Newitem) > 0 Then

      If Len(SQLWhere) > 0 Then SQLWhere &= " " & delemeter & " "
      SQLWhere &= Newitem
    End If
    Return SQLWhere
  End Function

#End Region


  Public Function BuildDelemiter(ByVal IDarray() As String) As String
    Dim WhereCl As String = ""
    WhereCl &= IDarray(0)
    For Loopvar As Integer = 1 To UBound(IDarray)
      If Len(IDarray(Loopvar)) > 0 Then WhereCl &= "," & IDarray(Loopvar)
    Next
    Return WhereCl
  End Function

  Public Function BuildDelemiter(ByVal Field As String, ByVal IDarray() As Integer, Optional ByVal Delemiter As String = "OR") As String
    Dim WhereCl As String = ""
    If Not IsNothing(IDarray) Then
      WhereCl &= Field & "=" & IDarray(0).ToString
      For Loopvar As Integer = 1 To UBound(IDarray)
        If Len(IDarray(Loopvar)) > 0 Then WhereCl &= " " & Delemiter & " " & Field & "=" & IDarray(Loopvar).ToString
      Next
      WhereCl = "(" & WhereCl & ")"
    End If
    Return WhereCl
  End Function

  Public Function BuildDelemiter(ByVal Field As String, ByVal IDarray() As String, Optional ByVal Delemiter As String = "OR") As String
    Dim WhereCl As String = ""
    If Not IsNothing(IDarray) Then
      WhereCl &= Field & "=" & IDarray(0)
      For Loopvar As Integer = 1 To UBound(IDarray)
        If Len(IDarray(Loopvar)) > 0 Then WhereCl &= " " & Delemiter & " " & Field & "=" & IDarray(Loopvar)
      Next
      WhereCl = "(" & WhereCl & ")"
    End If
    Return WhereCl
  End Function
  Public Function BuildWhere(ByVal WhereCl As String, ByVal IDs As String, ByVal Column As String, _
                     Optional ByVal WhereDelemiter As String = "AND", Optional ByVal Delemiter As String = "OR") As String
    Dim IDarray() As String
    If Len(IDs) > 0 Then
      If WhereCl.Length > 0 Then
        WhereCl &= " " & WhereDelemiter
      Else
        WhereCl &= " WHERE"
      End If
      If CBool(InStr(IDs, ",")) Then
        IDarray = Split(IDs, ",")
        WhereCl &= " ((" & Column & " = " & IDarray(0) & ")"
        For Loopvar As Integer = 1 To UBound(IDarray)
          If Len(IDarray(Loopvar)) > 0 Then WhereCl &= " " & Delemiter & " (" & Column & " = " & IDarray(Loopvar) & ")"
        Next
        WhereCl &= ")"
      Else
        WhereCl &= " (" & Column & " = " & IDs & ")"
      End If
    End If
    Return WhereCl
  End Function
End Module
Public Module VarManagement
#Region "Region InputVar"
  Public Function InputVar(ByVal Value As Object, ByVal DefaultValue As Object) As Object
    If Value Is Nothing OrElse IsDBNull(Value) OrElse Value Is "" Then
      Return DefaultValue
    Else
      Return Value
    End If
  End Function
  Public Function InputVar(ByVal Value As Object, ByVal DefaultValue As String, Optional ByVal TreatEmptyAsNothing As Boolean = False) As String
    If Value Is Nothing OrElse IsDBNull(Value) Then
      Return DefaultValue
    Else
      If TreatEmptyAsNothing And Len(Value) = 0 Then
        Return DefaultValue
      Else
        Return CStr(Value)
      End If
    End If
  End Function
  Public Function InputVar(ByVal Value As Object, ByVal DefaultValue As Double) As Double
    If Value Is Nothing OrElse IsDBNull(Value) OrElse Value Is "" Then
      Return DefaultValue
    Else
      Return CDbl(Value)
    End If
  End Function
  Public Function InputVar(ByVal Value As Object, ByVal DefaultValue As Integer) As Integer
    If Value Is Nothing OrElse IsDBNull(Value) OrElse Value Is "" Then
      Return DefaultValue
    Else
      If Integer.TryParse(Value.ToString, Nothing) Then
        Return CInt(Value)
      Else
        Return DefaultValue
      End If
    End If
  End Function
  Public Function InputVar(ByVal Value As Boolean, ByVal DefaultValue As Integer) As Integer
    If Value = True Then
      Return 1
    Else
      Return 0
    End If
  End Function

  Public Function InputVar(ByVal Value As Object, ByVal DefaultValue As Long) As Long
    If Value Is Nothing OrElse IsDBNull(Value) OrElse Value Is "" Then
      Return DefaultValue
    Else
      Return CLng(Value)
    End If
  End Function
  Public Function InputVar(ByVal Value As Object, ByVal DefaultValue As Decimal) As Decimal
    If Value Is Nothing OrElse IsDBNull(Value) OrElse Value Is "" Then
      Return DefaultValue
    Else
      Return CDec(Value)
    End If
  End Function
  Public Function InputVar(ByVal Value As Object, ByVal DefaultValue As Boolean) As Boolean
    If Value Is Nothing OrElse IsDBNull(Value) OrElse Value Is "" Then
      Return DefaultValue
    Else
      Return CBool(Value)
    End If
  End Function
  Public Function InputVar(ByVal Value As Object, ByVal DefaultValue As DateTime, Optional ByVal nullable As Boolean = False) As DateTime 'needs convert to date.parse
    If Value Is Nothing OrElse IsDBNull(Value) OrElse Value Is "" Then
      If nullable Then
        Return Nothing
      Else
        Return DefaultValue
      End If
    Else
      If CDate(Value) = New Date Then
        Return DefaultValue
      Else
        Dim outValue As DateTime = CDate(Value)
        Return outValue
      End If
    End If
  End Function
  'Public Function InputVar(ByVal Value As Object, ByVal DefaultValue As Date, Optional ByVal nullable As Boolean = False) As Date 'needs convert to date.parse
  '  If Value Is Nothing OrElse IsDBNull(Value) OrElse Value Is "" Then
  '    If nullable Then
  '      Return Nothing
  '    Else
  '      Return DefaultValue
  '    End If
  '  Else
  '    Return CDate(Value)
  '  End If
  'End Function
#End Region
#Region "Region OutputVar"
  ''' <summary>
  ''' String Represents text as a series of Unicode characters.
  ''' </summary>
  ''' <param name="Table"></param>
  ''' <param name="PKID"></param>
  ''' <param name="Field"></param>
  ''' <param name="NewValue"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Function OutputVar(ByVal Table As String, ByVal PKID As Long, ByVal Field As String, ByVal NewValue As String) As Boolean
    Dim Success As Boolean, Sqlstr As String
    Dim DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Sqlstr = "UPDATE " & Table & " SET " & Field & " = '" & NewValue & "' WHERE (ID = " & PKID.ToString & ")"
    Success = DBManager.RunSQL(Sqlstr)
    DBManager.CloseConnection()
    Return Success
  End Function
  ''' <summary>
  ''' Boolean Represents a (True/False) value.
  ''' </summary>
  ''' <param name="Table"></param>
  ''' <param name="PKID"></param>
  ''' <param name="Field"></param>
  ''' <param name="NewValue"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Function OutputVar(ByVal Table As String, ByVal PKID As Long, ByVal Field As String, ByVal NewValue As Boolean) As Boolean
    Dim Success As Boolean, Sqlstr As String, Bitval As Integer = CInt(NewValue)
    Dim DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Sqlstr = "UPDATE " & Table & " SET " & Field & " = " & Bitval.ToString & " WHERE (ID = " & PKID.ToString & ")"
    Success = DBManager.RunSQL(Sqlstr)
    DBManager.CloseConnection()
    Return Success
  End Function
  ''' <summary>
  ''' Integer Represents a 32-bit signed integer.
  ''' </summary>
  ''' <param name="Table"></param>
  ''' <param name="PKID"></param>
  ''' <param name="Field"></param>
  ''' <param name="NewValue"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Function OutputVar(ByVal Table As String, ByVal PKID As Long, ByVal Field As String, ByVal NewValue As Integer) As Boolean
    Dim Success As Boolean, Sqlstr As String
    Dim DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Sqlstr = "UPDATE " & Table & " SET " & Field & " = " & NewValue.ToString & " WHERE (ID = " & PKID.ToString & ")"
    Success = DBManager.RunSQL(Sqlstr)
    DBManager.CloseConnection()
    Return Success
  End Function
  ''' <summary>
  ''' Date Represents an instant in time, typically expressed as a date and time of day.
  ''' </summary>
  ''' <param name="Table"></param>
  ''' <param name="PKID"></param>
  ''' <param name="Field"></param>
  ''' <param name="NewValue"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Function OutputVar(ByVal Table As String, ByVal PKID As Long, ByVal Field As String, ByVal NewValue As Date) As Boolean
    Dim Success As Boolean, Sqlstr As String '1900-01-02
    'Dim ParsedDate As String = NewValue.Parse (
    Dim DateStr As String = NewValue.Year.ToString & "-" & NewValue.Month.ToString & "-" & NewValue.Day.ToString
    Dim TimeStr As String = NewValue.Hour.ToString & ":" & NewValue.Minute.ToString & ":" & NewValue.Second.ToString
    Dim DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Sqlstr = "UPDATE " & Table & " SET " & _
      Field & " = CONVERT(DATETIME, '" & DateStr & " " & TimeStr & "', 102) " & _
      "WHERE (ID = " & PKID.ToString & ")"
    Success = DBManager.RunSQL(Sqlstr)
    DBManager.CloseConnection()
    Return Success
  End Function
#End Region
End Module
