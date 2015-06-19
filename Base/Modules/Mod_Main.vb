
Imports Microsoft.Win32
Imports System.Threading
Imports System.Text.RegularExpressions
'Imports System.Web.UI

Public Module Functions
  Public Const default_Int As Integer = -1
  Public Const default_Date As Date = #1/1/1900#
  Public Const default_DateTime As Date = #1/1/1900 9:00:00 AM#
  Public Enum EnumFieldType
    Contact
    Booking
  End Enum
  Public Enum EnumMessageType
    Status
    Confirm
  End Enum
  Public Structure TypeFormField
    Dim ControlName As String
    Dim FieldName As String
    Dim NewValue As String
    Dim OldValue As String
    Dim FieldMessage As String
    Dim MessageType As EnumMessageType
    Dim FieldType As EnumFieldType
    Dim OkToWrite As Boolean
  End Structure
  'Public YesterdayDateTime As Date
  ' ''' <summary>
  ' ''' USE THIS FOR ADDING JS
  ' ''' </summary>
  ' ''' <param name="ScriptURL"></param>
  ' ''' <param name="ScriptName"></param>
  ' ''' <param name="ClientScriptMan"></param>
  ' ''' <param name="ClientScriptType"></param>
  ' ''' <remarks></remarks>
  'Public Sub AddJSfile(ByVal ScriptURL As String, _
  'ByVal ScriptName As String, _
  'ByVal ClientScriptMan As ClientScriptManager, _
  'ByVal ClientScriptType As Type)
  '  ' Check to see if the include script is already registered.
  '  If (Not ClientScriptMan.IsClientScriptIncludeRegistered(ClientScriptType, ScriptName)) Then
  '    ClientScriptMan.RegisterClientScriptInclude(ClientScriptType, ScriptName, ScriptURL)
  '  End If
  'End Sub
  Function IsDataless(ByVal value As Object) As Boolean
    If IsNothing(value) Then Return True
    If IsDBNull(value) Then Return True
    If Not Len(Trim(CStr(value))) > 0 Then Return True
    Return False
  End Function
  Function IsDigits(ByRef str As String) As Boolean
    If IsDataless(str) Then Return False
    If Regex.IsMatch(str, "^\d+$") Then
      Return True
    Else
      Return False
    End If
  End Function
  Function IsEmail(ByRef str As String) As Boolean
    If IsDataless(str) Then Return False
    If Regex.IsMatch(str, "^[\w\+\'\.-]+@[\w\'\.-]+\.[a-zA-Z0-9]{2,}$") Then
      Return True
    Else
      Return False
    End If
  End Function
  Function IsPhoneNumber(ByRef str As String) As Boolean
    If IsDataless(str) Then Return False
    str = Replace(Replace(Replace(Replace(Replace(str, " ", ""), "(", ""), ")", ""), ".", ""), "-", "")
    '"\(?\d{3}\W?\s?\d{3}\W?\d{4}" <- Best
    '"[0-9]{10}|[(]{1}[0-9]{0,3}[) -]{0,3}?[0-9]{3}[ -]{0,4}?[0-9]{4}" <- new
    '"^(((\(\d{3}\)( )?)|(\d{3}( |\-)))\d{3}\-\d{4})$" <-Works for 123-123-1234
    '"^(?=(\(\d{3}\)\s)|\d{3}[-])\(?([0-9]{3})\)?\s*[ -]?\s*([0-9]{3})\s*[ -]?\s*([0-9]{4})((\sext|\sx)\s*\.?:?\s([0-9]+))?$" <-Strict
    If Regex.IsMatch(str, "\(?\d{3}\W?\s?\d{3}\W?\d{4}") Then
      Return True
    Else
      Return False
    End If
  End Function
  Function IsPostalCode(ByRef str As String) As Boolean
    If IsDataless(str) Then Return False
    If Regex.IsMatch(str, "^[a-z]\d[a-z][ .-]?\d[a-z]\d$", RegexOptions.IgnoreCase) Then
      Return True
    Else
      Return False
    End If
  End Function
  Function IsZipCode(ByRef str As String) As Boolean
    If IsDataless(str) Then Return False
    If Regex.IsMatch(str, "^(\d{5})[ .-]?(\d{4})?$") Then
      Return True
    Else
      Return False
    End If
  End Function

  Function ExtractAlphaNumeric(ByVal str As String) As String
    If IsDataless(str) Then Return ""
    Return Regex.Replace(str, "[^a-zA-Z0-9]", "")
  End Function
  Function ExtractNumbers(ByVal str As String) As String
    If IsDataless(str) Then Return ""
    Return Regex.Replace(str, "\D", "")
  End Function
  Function ExtractWordChars(ByVal str As String) As String
    If IsDataless(str) Then Return ""
    Return Regex.Replace(str, "\W", "")
  End Function

  Function FormatPhoneNumber(ByVal str As String) As String
    If IsDataless(str) Then Return ""
    Return Regex.Replace(str, "^(?:1?[ .-]?)\(?([1-9]\d{2})\)?[ .-]?\s?(\d{3})[ .-]?(\d{4})$", "($1) $2-$3")
  End Function
  Function FormatPostalCode(ByVal str As String) As String
    If IsDataless(str) Then Return ""
    Return UCase(Regex.Replace(str, "^([a-z]\d[a-z])[ .-]?(\d[a-z]\d)$", "$1 $2", RegexOptions.IgnoreCase))
  End Function
  Function FormatSSN(ByVal str As String) As String
    If IsDataless(str) Then Return ""
    Return Regex.Replace(str, "^(\d{3})[ -]?(\d{2})[ -]?(\d{4})$", "$1-$2-$3")
  End Function
  Function FormatZipCode(ByVal str As String) As String
    If IsDataless(str) Then Return ""
    Return Regex.Replace(str, "^(\d{5})[ .-]?(\d{4})$", "$1-$2")
  End Function

End Module
Public Class ValueDescriptionPair
  Public m_Value As Object
  Public m_Description As String
  Public ReadOnly Property Value() As Object
    Get
      Return m_Value
    End Get
  End Property
  Public ReadOnly Property Description() As String
    Get
      Return m_Description
    End Get
  End Property
  Public Sub New(ByVal NewValue As Object, ByVal NewDescription As String)
    m_Value = NewValue
    m_Description = NewDescription
  End Sub
  Public Overrides Function ToString() As String
    Return Description
  End Function
End Class
Public Class RegEdit
  Dim AppKey As RegistryKey
  Dim SoftKey As RegistryKey
  Dim strFilename As String
  Private P_AppKey As String
  Public Sub New(ByVal AppKey As String)
    P_AppKey = AppKey
    init(AppKey)
  End Sub

  Event MsgEvent(p1 As String)

  Private Sub init(App_Key As String)
    SoftKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", True)
    SoftKey.CreateSubKey(App_Key)
    AppKey = Registry.CurrentUser.OpenSubKey("Software\" & App_Key, True)
  End Sub

  Public Function SetDatabase(index As Integer, DataSource As String, Database As String, UserName As String, UserPassword As String) As Boolean
    Dim RetVar As Boolean = True
    Try
      Dim DBKey As RegistryKey
      AppKey.CreateSubKey("Database" & index.ToString)
      DBKey = Registry.CurrentUser.OpenSubKey("Software\" & P_AppKey & "\Database" & index.ToString, True)
      DBKey.SetValue("DataSource", DataSource)
      DBKey.SetValue("Database", Database)
      DBKey.SetValue("UserName", UserName)
      DBKey.SetValue("UserPassword", UserPassword)
    Catch ex As ArgumentException
      RaiseEvent MsgEvent(ex.Message)
      RetVar = False
    End Try
    Return RetVar
  End Function

  Public Function GetDatabase(index As Integer, Optional Conn As ConnString = Nothing) As ConnString

    Dim DBKey As RegistryKey
    Dim RetVar As New ConnString

    AppKey.CreateSubKey("Database" & index.ToString)
    DBKey = AppKey.OpenSubKey("Database" & index.ToString, True)
    With RetVar
      .OptionalDatabase = ""
      .DataSource = DBKey.GetValue("DataSource", Conn.DataSource).ToString
      .Database = DBKey.GetValue("Database", Conn.Database).ToString
      .UserName = DBKey.GetValue("UserName", Conn.UserName).ToString
      .UserPassword = DBKey.GetValue("UserPassword", Conn.UserPassword).ToString
      SetDatabase(index, .DataSource, .Database, .UserName, .UserPassword)
    End With
    DBKey.Close()
    Return RetVar
  End Function
  Public Function GetAppValue(Name As String, DefaultValue As Object, Optional ByVal WriteDefaultValue As Boolean = True) As Object
    Dim This As Object
    This = AppKey.GetValue(Name, Nothing)
    If IsNothing(This) Then
      If WriteDefaultValue Then SetAppValue(Name, DefaultValue)
      Return DefaultValue
    Else
      Return This
    End If
  End Function
  Public Sub SetAppValue(Name As String, Value As Object)
    AppKey.SetValue(Name, Value)
  End Sub
  Public Sub DeleteSubKeyTree(App_Key As String)
    SoftKey.DeleteSubKeyTree(App_Key)
  End Sub
  Public Sub reinit()
    DeleteSubKeyTree(P_AppKey)
    init(P_AppKey)
  End Sub
  Public Sub DeleteValue(Name As String)
    Try
      AppKey.DeleteValue(Name, True)
    Catch ex As ArgumentException
      RaiseEvent MsgEvent(ex.Message)
    End Try


  End Sub


  Public Sub Close()
    AppKey.Close()
    SoftKey.Close()
  End Sub
End Class
Public Class iniFile
  Private Declare Ansi Function GetPrivateProfileString _
 Lib "kernel32.dll" Alias "GetPrivateProfileStringA" _
 (ByVal lpApplicationName As String, _
 ByVal lpKeyName As String, ByVal lpDefault As String, _
 ByVal lpReturnedString As System.Text.StringBuilder, _
 ByVal nSize As Integer, ByVal lpFileName As String) _
 As Integer
  Private Declare Ansi Function WritePrivateProfileString _
    Lib "kernel32.dll" Alias "WritePrivateProfileStringA" _
    (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpString As String, _
    ByVal lpFileName As String) As Integer
  Private Declare Ansi Function GetPrivateProfileInt _
    Lib "kernel32.dll" Alias "GetPrivateProfileIntA" _
    (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal nDefault As Integer, _
    ByVal lpFileName As String) As Integer
  Private Declare Ansi Function FlushPrivateProfileString _
    Lib "kernel32.dll" Alias "WritePrivateProfileStringA" _
    (ByVal lpApplicationName As Integer, _
    ByVal lpKeyName As Integer, ByVal lpString As Integer, _
    ByVal lpFileName As String) As Integer
  Dim strFilename As String

  ' Constructor, accepting a filename
  Public Sub New(ByVal Filename As String)
    strFilename = Filename
  End Sub

  ' Read-only filename property
  ReadOnly Property FileName() As String
    Get
      Return strFilename
    End Get
  End Property

  Public Function GetString(ByVal Section As String, ByVal Key As String, ByVal [Default] As String, Optional ByVal WriteMissing As Boolean = True) As String
    ' Returns a string from your INI file
    Dim intCharCount As Integer
    Dim objResult As New System.Text.StringBuilder(1024)
    intCharCount = GetPrivateProfileString(Section, Key, "", objResult, objResult.Capacity, strFilename)
    If intCharCount > 0 Then
      Return Left(objResult.ToString, intCharCount)
    Else
      If WriteMissing Then
        WriteString(Section, Key, [Default])
        Return [Default]
      Else
        Return Nothing
      End If
    End If
  End Function

  Public Function GetInteger(ByVal Section As String, _
    ByVal Key As String, ByVal [Default] As Integer) As Integer
    ' Returns an integer from your INI file
    Return GetPrivateProfileInt(Section, Key, _
       [Default], strFilename)
  End Function

  Public Function GetBoolean(ByVal Section As String, _
    ByVal Key As String, ByVal [Default] As Boolean) As Boolean
    ' Returns a Boolean from your INI file
    Return (GetPrivateProfileInt(Section, Key, _
       CInt([Default]), strFilename) = 1)
  End Function

  Public Sub WriteString(ByVal Section As String, _
    ByVal Key As String, ByVal Value As String) ' Writes a string to your INI file
    Dim Result As Integer
    Result = WritePrivateProfileString(Section, Key, Value, strFilename)
    Flush()
  End Sub

  Public Sub WriteInteger(ByVal Section As String, _
    ByVal Key As String, ByVal Value As Integer)
    ' Writes an integer to your INI file
    WriteString(Section, Key, CStr(Value))
    Flush()
  End Sub

  Public Sub WriteBoolean(ByVal Section As String, ByVal Key As String, ByVal Value As Boolean)
    ' Writes a boolean to your INI file
    Dim Sendval As String = "0"
    If Value Then Sendval = "1"
    WriteString(Section, Key, Sendval)
    Flush()
  End Sub

  Private Sub Flush()
    ' Stores all the cached changes to your INI file
    Dim Result As Integer
    Result = FlushPrivateProfileString(0, 0, 0, strFilename)
  End Sub
End Class