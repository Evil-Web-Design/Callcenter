Imports System.Windows.Forms
Imports Microsoft.Win32
Imports System.Threading
Imports System.Deployment.Application
Imports System.Text.RegularExpressions
Imports UniBase
Imports UniBase.Class_CallCenter
Imports UniBase.Class_CDO
'Imports System.Data.SqlClient
Imports System.Text
Public Enum EnumFieldType
  Contact
  Booking
End Enum
Public Structure TypeFormField
  Dim ControlName As String
  Dim FieldName As String
  Dim NewValue As String
  Dim OldValue As String
  Dim FieldMessage As String
  Dim FieldType As EnumFieldType
End Structure
Public Enum enum_EmpAction
  Booked = 1
  Confirmed = 2
End Enum
Public Enum enum_DateAction
  BookedOn = 1
  AppointmentOn = 2
End Enum
Public Enum enum_AccessLevel
  Restricted = 0
  Admin = 1
  Accounting = 2
  Manager = 3
  Confirmer = 4
  OP = 5
End Enum

Module Mod_Main
  Public WithEvents FormMain As Frm_Main
  Public WithEvents FormProgress As Frm_Progress
  Public WithEvents ResultWindow As Frm_Results
  Public WithEvents SearchWindow As Frm_Search
  Public WithEvents Record As Frm_Record
  Public WithEvents OpRecord As Frm_OpRecord
  Public WithEvents NewRecord As Frm_NewRecord
  Public WithEvents CDO As New Class_CDO
  Public WithEvents History As Frm_History
  Public WithEvents Settings As frm_Settings
  Public WithEvents Employees As Frm_Employees
  Public WithEvents FormLog As Frm_Log

  Public loggedIn As Boolean = False
  Public UserSelectedindex As Integer
  Public Debugmode As Boolean = False
  Public LookForUpdates As Boolean = False

  Public Const AppName As String = "CallCenter"
  Public WithEvents CC As New Class_CallCenter

  ' Public MDIStyle As Boolean = True
  'Public MultiRecord As Boolean = True

  Public ControlsActive As Boolean = True
  Public Updateing As Boolean = False
  Public Const default_Int As Integer = -1

  Sub main()
    YesterdayDateTime = Now.AddDays(-1).ToString("MM/dd/yyyy") & " 9:00:00 am"
    FormProgress = New Frm_Progress

    'Dim ini As New iniFile("c:\CallCenter.ini")


    Dim TempCon As New ConnString
    Dim regKey As New RegEdit(AppName)
    Debugmode = InputVar(regKey.GetAppValue("debug", False), False)
    'MDIStyle = InputVar(regKey.GetAppValue("MDIStyle", True), True)
    'MultiRecord = InputVar(regKey.GetAppValue("MultiRecord", True), True)
    Dim DBID As Integer = InputVar(regKey.GetAppValue("DBID", 0), 0)
    Dim DBMAXID As Integer = InputVar(regKey.GetAppValue("DBMAXID", DBID), DBID)
    'regKey.SetAppValue("DBMAXID", DBMAXID)
    Dim AskDB As Boolean = InputVar(regKey.GetAppValue("AskDB", False), False)
    Dim LogVisable As Boolean = InputVar(regKey.GetAppValue("StartLogOpen", False), False)
    If LogVisable Then
      regKey.SetAppValue("StartLogOpen", False)
      OpenLog()
    End If
    'If Not TempCon.DataSource = "" And DBID = 0 Then ' Upgrade to new data source storage
    '  DBID = 1
    '  regKey.reinit() 'clear
    '  regKey.SetAppValue("DBID", DBID)
    '  regKey.SetAppValue("debug", Debugmode)
    '  regKey.SetAppValue("MDIStyle", MDIStyle)
    '  regKey.SetAppValue("MultiRecord", MultiRecord)
    '  regKey.SetDatabase(DBID, TempCon.DataSource, TempCon.Database, TempCon.UserName, TempCon.UserPassword)

    'Else
    TempCon = regKey.GetDatabase(DBID, New ConnString With {.DataSource = "intelepros.com",
                                                              .Database = "Callcenter",
                                                              .UserName = "app",
                                                              .UserPassword = "ou812app"})
    'End If
    regKey.SetAppValue("AppName", Application.ProductName & " V" & Application.ProductVersion)
    SetConntoString(TempCon)
    ReDim Connection(0) : Connection(0) = TempCon

    LookForUpdates = InputVar(regKey.GetAppValue("LookForUpdates", "true").ToString, False)
    If LookForUpdates Then InstallUpdateSyncWithInfo()



    'With CDO
    '  .ServerAddr = regKey.GetValue("ServerAddr", "secure.emailsrvr.com").ToString
    '  .ServerUser = regKey.GetValue("ServerUser", "welcome@contactpros.org").ToString
    '  .ServerPass = regKey.GetValue("ServerPass", "Harley58").ToString
    '  .FromAddr = New MessageAddrs With {.EmailAddr = regKey.GetValue("FromEmail", "welcome@contactpros.org").ToString,
    '                                     .UserName = regKey.GetValue("FromName", "Welcome").ToString,
    '                                     .EmailReplyTo = regKey.GetValue("ReplyTo", "welcome@contactpros.org").ToString,
    '                                     .NotificationTo = regKey.GetValue("NotificationTo", "welcome@contactpros.org").ToString}

    'End With

    If AskDB Then
      regKey.SetAppValue("AskDB", False)
      OpenSettings()
    Else
      InitTables()
    End If
    'FormProgress.ShowMessage(AppName)
    regKey.Close()
    InitSystem()
  End Sub
  Public AppRunning As Boolean = True
  Public DatabaceConnected As Boolean = False
  Private Sub KeepAlive()
    Do While AppRunning
      Application.DoEvents()
    Loop
  End Sub
  Public Sub InitSystem()
    Dim regKey As New RegEdit(AppName)
Start:
    If Not IsNothing(FormMain) Then FormMain.Hide()
    loggedIn = False
    'FormMain.Hide()
    If DatabaceConnected Then
      If Not IsNothing(CC.StaffList) Then
        Dim SignIn As New Frm_SignIn
        SignIn.ShowDialog()
        If loggedIn Then
          If Not IsNothing(SignIn) Then SignIn.Dispose()
          'init Record Forms
          If CC.CurStaff.Rights.SimpleUI Then
            OpenNewRecord()
            'OpRecord = New Frm_OpRecord
            'OpRecord.Show()
          Else
            If IsNothing(FormMain) Then
              'FormMain.Dispose()
              FormMain = New Frm_Main
            End If
            FormMain.Show()
            If Not CC.CurStaff.Rights.MultiRecordUI Then Record = New Frm_Record 'Init the ONE Record
          End If
        Else
          AppRunning = False
        End If
      Else
        MessageBox.Show("No Users in Database!")
        AppRunning = False
      End If
    Else
      Dim Answer As MsgBoxResult = MsgBox("Can Not Connect To Database!" & vbCrLf & "Do you want to Retry Connection?", MsgBoxStyle.RetryCancel, "Retry Connection?")
      If Answer = MsgBoxResult.Retry Then
        OpenSettings()
        GoTo Start
      Else
        regKey.SetAppValue("AskDB", True)
        AppRunning = False
      End If
    End If
    regKey.Close()
    KeepAlive()
  End Sub
  Public Function InitTables() As Boolean
    FormProgress.ShowProgress(1, "Loading Server List", 10)
    If CC.LoadServerList() Then
      FormProgress.ShowProgress(2)
      DB_CallCenter = CC.getdatabaseIndex("CallCenter")
      FormProgress.ShowProgress(3)
      DB_Recordings = CC.getdatabaseIndex("Recordings")
      FormProgress.ShowProgress(4, "Loading Staff List")
      CC.initStaff()

      FormProgress.ShowProgress(5, "Loading Staff Rights")
      CC.initRights()

      FormProgress.ShowProgress(6, "Loading Security settings")
      CC.initAccessLevel()

      FormProgress.ShowProgress(7, "Loading Locations List")
      CC.initLocations()

      FormProgress.ShowProgress(8, "Loading Status List")
      CC.initStatus()

      'FormProgress.ShowProgress(8, "Loading Dept List")
      'CC.initDept()

      FormProgress.ShowProgress(9, "Loading Gift List")
      CC.initGifts()

      FormProgress.ShowProgress(10, "Loading Settings")
      'CC.initIncome()
      'CC.initMarital()

      FormProgress.Hide()
      DatabaceConnected = True
    Else
      FormProgress.Hide()
      DatabaceConnected = False
      'MessageBox.Show("Can Not Connect To Database!")
    End If
    Return DatabaceConnected
  End Function



  Sub MsgEvent(Message As String) Handles CC.MsgEvent
    log(Message)
  End Sub

  Public Sub InstallUpdateSyncWithInfo()

    Dim info As UpdateCheckInfo = Nothing

    If (ApplicationDeployment.IsNetworkDeployed) Then
      Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

      Try
        info = AD.CheckForDetailedUpdate()
      Catch dde As DeploymentDownloadException
        MessageBox.Show("The new version of the " & AppName & " application cannot be downloaded at this time. " + ControlChars.Lf & ControlChars.Lf & "Please check your network connection, or try again later. Error: " + dde.Message)
        Return
      Catch ioe As InvalidOperationException
        MessageBox.Show(AppName & " cannot be updated. It is likely not a ClickOnce application. Error: " & ioe.Message)
        Return
      End Try

      If (info.UpdateAvailable) Then
        Dim doUpdate As Boolean = True

        If (Not info.IsUpdateRequired) Then
          Dim dr As DialogResult = MessageBox.Show("An update is available. Would you like to update the " & AppName & " application now?", "Update Available", MessageBoxButtons.OKCancel)
          If (Not System.Windows.Forms.DialogResult.OK = dr) Then
            doUpdate = False
          End If
        Else
          ' Display a message that the app MUST reboot. Display the minimum required version.
          MessageBox.Show(AppName & " has detected a mandatory update from your current " & _
              "version to version " & info.MinimumRequiredVersion.ToString() & _
              ". The " & AppName & " application will now install the update and restart.", _
              "Update Available", MessageBoxButtons.OK, _
              MessageBoxIcon.Information)
        End If

        If (doUpdate) Then
          Try
            Updateing = True
            AD.Update()
            'MessageBox.Show("The application has been upgraded, and will now restart.")
            Application.Restart()
          Catch dde As DeploymentDownloadException
            MessageBox.Show("Cannot install the latest version of the " & AppName & " application. " & ControlChars.Lf & ControlChars.Lf & "Please check your network connection, or try again later.")
            Return
          End Try
        End If
      End If
    End If
  End Sub
  Public Function FindWindow(FormName As String, Optional Tag As Integer = default_Int) As Form
    For Each f As Form In Application.OpenForms
      If f.Name = FormName Then
        If Not IsNothing(f.Tag) Then
          If Tag > default_Int Then
            If f.Tag.Equals(Tag) Then
              Return f
            End If
          Else
            Return f
          End If
        End If
      End If
    Next f
    Return Nothing
  End Function
  Private Function CreateRecordQuestion(ByRef DataRecord As Type_ContactRecord, Optional Question As String = "", Optional Heading As String = "") As Boolean
    Dim ReturnVal As Boolean = False
    If Heading = "" Then Heading = "Create New Contact?"
    If Question = "" Then Question = "I could not find " & FormatPhoneNumber(DataRecord.Contact.Telephone) & ". " & vbCrLf & " Should I create a new Record?"
    Dim responce As MsgBoxResult = MsgBox(Question, MsgBoxStyle.OkCancel, Heading)
    If responce = MsgBoxResult.Ok Then
      CC.CreateContact(DataRecord)
      ReturnVal = True
    End If
    Return ReturnVal
  End Function
  Sub OpenRecord()
    Dim TempRecord As New Class_CallCenter.Type_ContactRecord
    With TempRecord
      .Contact.Telephone = ""
    End With
    OpenRecord(TempRecord)
  End Sub
  Sub OpenRecord(TempRecord As Class_CallCenter.Type_ContactRecord)
    CloseNewRecordTools()


    If CC.CurStaff.Rights.SimpleUI Then
      If IsNothing(OpRecord) Then OpRecord = New Frm_OpRecord
      OpRecord.LoadRecord(TempRecord)
    Else
      If CC.CurStaff.Rights.MultiRecordUI = True Then

        Dim frm As Form = FindWindow("Frm_Record", TempRecord.Contact.ID)
        If Not IsNothing(frm) Then
          frm.BringToFront()
        Else
          Record = New Frm_Record
          'Record.MdiParent = FormMain
          Record.Show()
          Record.LoadRecord(TempRecord)
        End If

        'Dim found As Boolean = FormMain.FindChild(TempRecord.Contact.ID)
        'If Not found Then
        'End If
      Else
        Record.LoadRecord(TempRecord)
      End If
    End If
  End Sub

  ''' <summary>
  ''' I hope this is core...
  ''' </summary>
  ''' <param name="ContactID"></param>
  ''' <param name="BookingID"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
  Public Function OpenRecord(ContactID As Integer, Optional BookingID As Integer = default_Int) As Boolean
    Dim RecordExists As Boolean = False
    Dim DataRecord As New Class_CallCenter.Type_ContactRecord
    FormProgress.ShowMessage("Loading Contact.")
    RecordExists = CC.FindRecord(DataRecord, ContactID)
    If RecordExists Then
      FormProgress.ShowMessage("Loading Bookings.")
      Call CC.LoadContactBookings(DataRecord, BookingID)
      OpenRecord(DataRecord)
    End If
    FormProgress.Hide()
    Return RecordExists
  End Function
  Public Function OpenRecord(RecordPhone As String, Optional ClaimNumber As String = "") As Boolean
    Dim RecordExists As Boolean = False
    Dim ClaimUsed As Boolean = False
    Dim ClaimFoumd As Boolean = False
    Dim DoOpenRecord As Boolean = False

    Dim DataRecord As New Class_CallCenter.Type_ContactRecord
    Dim ClaimRecord As New Class_CallCenter.Type_ContactRecord
    FormProgress.ShowMessage("Searching For Telephone.")
    '--------------------------------------------------------
    DataRecord.Contact.Telephone = RecordPhone
    RecordExists = CC.FindRecord(DataRecord)
    If RecordExists Then
      FormProgress.ShowMessage("Found Contact. Loading Bookings.")
      Call CC.LoadContactBookings(DataRecord)
      With DataRecord
        If ClaimNumber.Length > 4 And Not IsNothing(.Booking) Then
          For Each Booking As Class_CallCenter.Type_ContactBooking In DataRecord.Booking
            If Booking.Booking.ClaimNumber = ClaimNumber Then
              ClaimUsed = True
              DataRecord.BookingIndex = Booking.Index
            End If
          Next
        End If
      End With
    End If
    '--------------------------------------------------------
    If ClaimNumber.Length > 0 And ClaimUsed = False Then
      FormProgress.ShowMessage("Searching For ClaimNumber.")
      ClaimFoumd = CC.FindClaim(ClaimRecord, ClaimNumber)
      If ClaimFoumd Then
        If ClaimRecord.Contact.Telephone.Length = 0 Then
          ClaimRecord.Contact.Telephone = RecordPhone
        End If
      End If
    End If
    '--------------------------------------------------------
    FormProgress.Hide()
    'RecordExists ClaimUsed ClaimFoumd
    Dim responce As MsgBoxResult = MsgBoxResult.Abort
    Dim TempRecord As New Class_CallCenter.Type_ContactRecord
    If RecordExists Then
      If ClaimNumber.Length > 0 And Not ClaimUsed Then
        If ClaimFoumd Then
          With ClaimRecord.Promo
            NewBooking(DataRecord, .ClaimNumber, .Location.Name, .Location.ID)
          End With
          DoOpenRecord = True
        Else
          DoOpenRecord = CreateRecordQuestion(TempRecord, "I could not find ClaimNumber:" & ClaimNumber & _
                    ". " & vbCrLf & "However I did find a record with the Telephone number " & FormatPhoneNumber(RecordPhone) & _
                    ". " & vbCrLf & "Do you want to open it?", "Claim Number Not Found.")
         End If
      Else
        DoOpenRecord = True
      End If
      TempRecord = DataRecord
    Else
      If ClaimFoumd Then
        CC.CreateContact(ClaimRecord)
        With ClaimRecord.Promo
          NewBooking(ClaimRecord, .ClaimNumber, .Location.Name, .Location.ID)
        End With
        TempRecord = ClaimRecord
        DoOpenRecord = True
      Else
        TempRecord.Contact.Telephone = RecordPhone
        If ClaimNumber.Length > 0 Then
          DoOpenRecord = CreateRecordQuestion(TempRecord, "I could not find ClaimNumber:" & ClaimNumber & _
                      ". " & vbCrLf & "Would you like to open Telephone:" & FormatPhoneNumber(RecordPhone) & " anyway?", "Claim Number Not Found.")
        Else
          DoOpenRecord = CreateRecordQuestion(TempRecord)
        End If
      End If

    End If
    If DoOpenRecord Then
      OpenRecord(TempRecord)
    End If
    Return DoOpenRecord

  End Function
  Public Sub NewBooking(ByRef DataRecord As Type_ContactRecord,
                         Optional PromoClaimNumber As String = Nothing,
                         Optional PromoLocationName As String = Nothing,
                         Optional PromoLocationID As Integer = default_Int)
    Dim index As Integer = 0
    If Not IsNothing(DataRecord.Booking) Then index = DataRecord.Booking.Length
    ReDim Preserve DataRecord.Booking(index)
    DataRecord.Booking(index).Index = index
    With DataRecord.Booking(index).Booking
      .ContactID = DataRecord.Contact.ID
      .ClaimNumber = InputVar(PromoClaimNumber, "")
      .Appt = New Date
      .Booked = Now
      .Conf = YesterdayDateTime
      .ConfirmerID = default_Int
      .Location.Name = InputVar(PromoLocationName, "New Booking")
      .LocationID = InputVar(PromoLocationID, default_Int)
      .StatusID = 0
      .BookerID = CC.CurStaff.ID
    End With
    DataRecord.BookingIndex = index
  End Sub
  '=============================================================================
  Public Sub CloseNewRecordTools()
    If Not IsNothing(SearchWindow) Then SearchWindow.Dispose()
    If Not IsNothing(NewRecord) Then NewRecord.Dispose()

    If Not IsNothing(Settings) Then Settings.Dispose()
    If Not IsNothing(Employees) Then Employees.Dispose()
  End Sub
  Public Sub OpenSearch()
    CloseNewRecordTools()
    SearchWindow = New Frm_Search
    SearchWindow.Show()
  End Sub
  Public Sub OpenNewRecord()
    CloseNewRecordTools()
    NewRecord = New Frm_NewRecord
    NewRecord.Show()
  End Sub
  Public Sub OpenSettings()
    CloseNewRecordTools()
    If Not IsNothing(FormMain) Then FormMain.Hide()
    Settings = New frm_Settings
    Settings.Show()
    If Not DatabaceConnected Then InitTables()
  End Sub
  Public Sub OpenEmployees()
    CloseNewRecordTools()
    Employees = New Frm_Employees
    Employees.Show()
  End Sub
  Public Sub OpenLog()
    If Not IsNothing(FormLog) Then FormLog.Dispose()
    FormLog = New Frm_Log
    FormLog.Show()
  End Sub
  Public Sub OpenHistory(ByRef Record As Type_ContactRecord, Bookingindex As Integer)

    CC.LoadBookingHistory(Record, Bookingindex)
    If Not IsNothing(History) Then History.Dispose()
    History = New Frm_History
    History.Show()
    FillBookingHistory(History.Grid_Results, Record, Bookingindex)

  End Sub

  Public Sub OpenResults()
    FormProgress.ShowProgress(1, "Search Records", 3)

    CC.SearchRecords()
    FormProgress.ShowProgress(2)
    If Not IsNothing(ResultWindow) Then ResultWindow.Dispose()
    ResultWindow = New Frm_Results
    ResultWindow.Show()
    FillSearch(ResultWindow.Grid_Results, CC.SearchResult)
    FormProgress.Hide()
  End Sub


#Region ""
  Public Sub ClearDataRecord(ByRef DataRecord As Type_ContactRecord)
    With DataRecord
      .Booking = Nothing
      .BookingIndex = default_Int
      With .Contact
        .ID = default_Int
      End With
      With .Promo
        .ID = default_Int
      End With
    End With
  End Sub

  Sub UpdateContact(ByRef DataRecord As Type_ContactRecord, ThisForm As Form, FormField As TypeFormField)
    With DataRecord.Contact
      FormField.FieldMessage = ""
      Dim obj As Object = getControlFromName(ThisForm, FormField.ControlName)
      Select Case FormField.ControlName
        Case "tel_Phone"
          Dim ctlTel As ctl_Phone = CType(obj, ctl_Phone)
          If ctlTel.IsValid Then
            FormField.OldValue = .Telephone : .Telephone = FormField.NewValue : FormField.FieldName = "Telephone"
          Else
            FormField.FieldMessage = "Invalid Phone Number"
          End If
        Case "tel_AltPhone"
          Dim ctlTel As ctl_Phone = CType(obj, ctl_Phone)
          If ctlTel.IsValid Or FormField.NewValue.Length = 0 Then
            FormField.OldValue = .AltPhone : .AltPhone = FormField.NewValue : FormField.FieldName = "AltPhone"
          Else
            FormField.FieldMessage = "Invalid Alt Phone Number"
          End If
        Case "txt_PFirst" : FormField.OldValue = .PF_Name : .PF_Name = FormField.NewValue : FormField.FieldName = "PF_Name"
        Case "txt_PLast" : FormField.OldValue = .PL_Name : .PL_Name = FormField.NewValue : FormField.FieldName = "PL_Name"
        Case "txt_SFirst" : FormField.OldValue = .SF_Name : .SF_Name = FormField.NewValue : FormField.FieldName = "SF_Name"
        Case "txt_SLast" : FormField.OldValue = .SL_Name : .SL_Name = FormField.NewValue : FormField.FieldName = "SL_Name"
        Case "txt_Email" : FormField.OldValue = .Email : .Email = FormField.NewValue : FormField.FieldName = "Email"
        Case "txt_Address" : FormField.OldValue = .Address1 : .Address1 = FormField.NewValue : FormField.FieldName = "Address1"
        Case "txt_AddressExtra" : FormField.OldValue = .Address2 : .Address2 = FormField.NewValue : FormField.FieldName = "Address2"
        Case "txt_City" : FormField.OldValue = .City : .City = FormField.NewValue : FormField.FieldName = "City"
        Case "txt_State" : FormField.OldValue = .ST : .ST = FormField.NewValue : FormField.FieldName = "ST"
        Case "txt_Zip" : FormField.OldValue = .Zip : .Zip = FormField.NewValue : FormField.FieldName = "Zip"
        Case "txt_Notes" : FormField.OldValue = .Notes : .Notes = FormField.NewValue : FormField.FieldName = "Notes"
        Case Else
      End Select
    End With
    FormField.FieldType = EnumFieldType.Contact
    SaveField(DataRecord, ThisForm, FormField)
  End Sub
  Sub UpdateBooking(ByRef DataRecord As Type_ContactRecord, ThisForm As Form, FormField As TypeFormField)
    With DataRecord.Booking(DataRecord.BookingIndex).Booking
      FormField.FieldMessage = ""
      Select Case FormField.ControlName
        Case "txt_ClaimNumber"
          If FormField.NewValue.Length > 0 Then
            .ClaimNumberValid = CC.FindClaim(FormField.NewValue)
          Else
            .ClaimNumberValid = True
          End If
          If .ClaimNumberValid Then
            FormField.OldValue = .ClaimNumber : .ClaimNumber = FormField.NewValue : FormField.FieldName = "ClaimNumber"
            'txt_ClaimNumber.BackColor = Color.FromArgb(255, 192, 255, 192)
          Else
            FormField.FieldMessage = "Invalid Claim Number"
          End If
        Case "cbo_Location"
          Dim ProjIndex As Integer = CC.GetLocationlistIndex(FormField.NewValue)
          If ProjIndex > default_Int Then
            FormField.OldValue = .LocationID : .LocationID = FormField.NewValue : FormField.FieldName = "LocationID"
            .Location.Name = CC.LocationList(ProjIndex).Name
          End If
        Case "cbo_Status"
          Dim StatIndex As Integer = CC.GetStatuslistIndex(FormField.NewValue)
          If StatIndex > default_Int Then
            FormField.OldValue = .StatusID : .StatusID = FormField.NewValue : FormField.FieldName = "StatusID" ': .Status = CC.StatusList(ProjIndex)
          End If
        Case "cbo_Booker" : FormField.OldValue = .BookerID : .BookerID = FormField.NewValue : FormField.FieldName = "BookerID"
        Case "cbo_Confirmer" : FormField.OldValue = .ConfirmerID : .ConfirmerID = FormField.NewValue : FormField.FieldName = "ConfirmerID"
        Case "cbo_Gift1" : FormField.OldValue = .Gift1_ID : .Gift1_ID = FormField.NewValue : FormField.FieldName = "Gift1"
        Case "cbo_Gift2" : FormField.OldValue = .Gift2_ID : .Gift2_ID = FormField.NewValue : FormField.FieldName = "Gift2"
        Case "cbo_Gift3" : FormField.OldValue = .Gift3_ID : .Gift3_ID = FormField.NewValue : FormField.FieldName = "Gift3"
        Case "date_Appt" : FormField.OldValue = .Appt : .Appt = FormField.NewValue : FormField.FieldName = "Appt"
        Case "Ctl_Appt"
          If .Appt = New Date Then FormField.OldValue = "" Else FormField.OldValue = .Appt
          .Appt = FormField.NewValue : FormField.FieldName = "Appt"
        Case "date_Booked" : FormField.OldValue = .Booked : .Booked = FormField.NewValue : FormField.FieldName = "Booked"
        Case "date_Conf" : FormField.OldValue = .Conf : .Conf = FormField.NewValue : FormField.FieldName = "Confirmed"
        Case "txt_BookNotes" : FormField.OldValue = .Notes : .Notes = FormField.NewValue : FormField.FieldName = "Notes"
        Case Else
      End Select
      If DataRecord.Booking(DataRecord.BookingIndex).Exists Then
        FormField.FieldType = EnumFieldType.Booking
        SaveField(DataRecord, ThisForm, FormField)
      Else
        If CC.CreateBooking(DataRecord.Booking(DataRecord.BookingIndex)) Then DataRecord.Booking(DataRecord.BookingIndex).Exists = True
      End If
    End With
  End Sub

  Sub SaveField(ByRef DataRecord As Type_ContactRecord, ThisForm As Form, FormField As TypeFormField)
    Dim TempControlsActive = ControlsActive : ControlsActive = False
    Dim OkToWrite As Boolean = (FormField.OldValue <> FormField.NewValue) And (FormField.FieldMessage.Length = 0)

    If OkToWrite Then
      Field_Status(ThisForm, "Saving " & FormField.FieldName)
      Console.Write(FormField.FieldName & " " & FormField.OldValue & " To ->" & FormField.NewValue & vbCrLf)
      If WriteUpdate(DataRecord, FormField) Then
        Field_Status(ThisForm, FormField.FieldName & " Saved.")
        colorField(ThisForm, FormField, Color.FromArgb(200, 255, 200))
      Else
        Field_Status(ThisForm, "Error saving: " & FormField.FieldName)
        colorField(ThisForm, FormField, Color.FromArgb(255, 128, 128)).focus()
      End If
    Else
      If FormField.FieldMessage.Length > 0 Then
        Field_Status(ThisForm, FormField.FieldMessage)
        colorField(ThisForm, FormField, Color.FromArgb(255, 255, 128)).focus()

      Else
        Field_Status(ThisForm, "No change to: " & FormField.FieldName & ".")
        colorField(ThisForm, FormField, Color.FromArgb(255, 255, 255))
      End If
    End If
    ControlsActive = TempControlsActive
  End Sub
  Function WriteUpdate(ByRef DataRecord As Type_ContactRecord, FormField As TypeFormField)
    Dim result As Boolean = False
    Select Case FormField.FieldType
      Case EnumFieldType.Contact
        result = CC.UpdateContactField(DataRecord, FormField.FieldName, FormField.NewValue)
      Case EnumFieldType.Booking
        result = CC.UpdateContactBooking(DataRecord.Booking(DataRecord.BookingIndex), FormField.FieldName, FormField.NewValue, FormField.OldValue)
    End Select

    Return result
  End Function

  Function colorField(ThisForm As Form, FormField As TypeFormField, NewColor As Color) As Object
    Dim Obj As Object = getControlFromName(ThisForm, FormField.ControlName)
    Try
      Select Case FormField.ControlName.Substring(0, 3)
        Case "tel"
          Dim txt As ctl_Phone = CType(Obj, ctl_Phone)
          txt.BackColor = NewColor
        Case "txt"
          Dim txt As TextBox = CType(Obj, TextBox)
          txt.BackColor = NewColor
        Case "cbo"
          Dim txt As ComboBox = CType(Obj, ComboBox)
          txt.BackColor = NewColor
        Case "dat"
          Dim txt As DateTimePicker = CType(Obj, DateTimePicker)
          txt.BackColor = NewColor
      End Select
    Catch ex As Exception
      log(ex.ToString)
    End Try
    Return Obj
  End Function
  Public Sub Field_Status(ThisForm As Form, Optional Message As String = "Done")
    Dim Obj As Object = getControlFromName(ThisForm, "lbl_Status")
    If Not IsNothing(Obj) Then
      Obj.Text = Message
    End If
    Application.DoEvents()
  End Sub


  Public Function OkToClose() As Boolean
    If CC.CurStaff.Rights.SimpleUI Then
      Return OktoExit()
    Else
      If CC.CurStaff.Rights.MultiRecordUI Then
        Return True
      Else
        Return OktoExit()
      End If
    End If
  End Function
  Public Function OktoExit() As Boolean
    Dim QResult As Boolean = False
    Dim responce As MsgBoxResult = MsgBox("Are you sure you want to exit the program?", MsgBoxStyle.OkCancel, "This Will Exit Program")
    If responce = MsgBoxResult.Ok Then QResult = True
    AppRunning = Not QResult
    Return QResult
  End Function
#End Region



  Public Function Get_Control_Location(ByVal control As Control, offset As Point) As Point
    If InStr(control.Name, "Frm_") > 0 Then
      Return offset 'control.Location
    End If
    Return control.Location + Get_Control_Location(control.Parent, offset)
  End Function

  Public Function FindLocation(sender As Object) As Point
    Dim Pnt As New Point With {.X = sender.Location.X, .Y = sender.Location.Y}
    Do While Not (TypeOf sender Is Form Or sender Is Nothing)
      sender = sender.Parent
      log(TypeName(sender) & " " & sender.Location.X & "-" & sender.Location.Y)
      If TypeName(sender) = "Frame" Then
        Pnt.X = Pnt.X + sender.Location.X + (sender.Width - sender.InsideWidth)
        Pnt.Y = Pnt.Y + sender.Location.Y + (sender.Height - sender.InsideHeight)
      Else
        Pnt.X = Pnt.X + sender.Location.X
        Pnt.Y = Pnt.Y + sender.Location.Y
      End If
    Loop
    Return Pnt
  End Function
  Public Sub SetParent(ByVal sender As System.Object,
                       ByVal Parent As System.Object)
    sender.Parent = Parent
    sender.Location = New Point With {.X = 0, .Y = 0}
    sender.BackColor = Color.Transparent
  End Sub

  Public Sub SetParent(ByVal sender As System.Object,
                         ByVal Parent As System.Object,
                         ByVal Point As Point)
    SetParent(sender, Parent)
    sender.Location = Point
    sender.BackColor = Color.Transparent
  End Sub
  Public Sub LabelDropShado(ByVal sender As Label,
                      Optional ByVal Offx As Integer = 3, Optional ByVal Offy As Integer = 3)
    Dim Parent As New Label With {.Visible = True,
                                  .AutoSize = sender.AutoSize,
                                  .TextAlign = sender.TextAlign,
                                  .Size = sender.Size,
                                  .Location = sender.Location,
                                  .Text = sender.Text,
                                  .ForeColor = Color.Black,
                                  .Font = sender.Font,
                                  .BackColor = Color.Transparent}

    'Parent.Text = "Test"
    SetParent(Parent, sender.Parent)
    Parent.Location = sender.Location
    SetParent(sender, Parent)

    sender.Location = New Drawing.Point(Offx, Offy)
    sender.BackColor = Color.Transparent
    Application.DoEvents()
  End Sub
  Public Sub UpdateShado(ByVal sender As Label)
    Dim Parent As Label = sender.Parent
    Parent.Text = sender.Text
  End Sub
  Public Sub SetParent(ByVal sender As System.Object,
                       ByVal Parent As System.Object,
                       ByVal BackColor As Color)
    SetParent(sender, Parent)
    sender.Location = New Point With {.X = 0, .Y = 0}
    BackColor = BackColor
  End Sub
  Public Sub SetParent(ByVal sender As System.Object,
                       ByVal Parent As System.Object,
                       ByVal BackColor As Color,
                       ByVal Point As Point)
    SetParent(sender, Parent)
    sender.Location = Point
    sender.BackColor = BackColor
  End Sub





  Public Sub log(Message As String)
    If Not IsNothing(FormLog) Then FormLog.Logit(Message)
  End Sub




End Module
Module ContactManagement


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
      log(ex.Message)
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
      .DataSource = DBKey.GetValue("DataSource", Conn.DataSource)
      .Database = DBKey.GetValue("Database", Conn.Database)
      .UserName = DBKey.GetValue("UserName", Conn.UserName)
      .UserPassword = DBKey.GetValue("UserPassword", Conn.UserPassword)
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
      log(ex.Message)
    End Try


  End Sub
  Public Structure Type_FormPos
    Dim X As Integer
    Dim Y As Integer
    Dim Width As Integer
    Dim Height As Integer
  End Structure
  Public Enum Enum_FormPos
    Size
    Location
    Both
  End Enum
  Public Sub GetSavedFormLocation(ByRef Frm As Form, Optional Mode As Enum_FormPos = Enum_FormPos.Both)
    Dim FormKey As RegistryKey, FormPos As Type_FormPos
    AppKey.CreateSubKey(Frm.Name)
    FormKey = AppKey.OpenSubKey(Frm.Name, True)

    With FormPos
      .X = FormKey.GetValue("X", Frm.Location.X)
      .Y = FormKey.GetValue("Y", Frm.Location.Y)
      .Width = FormKey.GetValue("Width", Frm.Size.Width)
      .Height = FormKey.GetValue("Height", Frm.Size.Height)
      If Mode = Enum_FormPos.Both Or Mode = Enum_FormPos.Location Then Frm.Location = New Point(.X, .Y)
      If Mode = Enum_FormPos.Both Or Mode = Enum_FormPos.Size Then Frm.Size = New Size(.Width, .Height)
    End With
  End Sub
  Public Function SetSavedFormLocation(ByVal Frm As Form) As Boolean
    Dim RetVar As Boolean = True
    If Frm.Visible Then
      Try
        Dim FormKey As RegistryKey 'FormKey
        AppKey.CreateSubKey(Frm.Name)
        FormKey = Registry.CurrentUser.OpenSubKey("Software\" & P_AppKey & "\" & Frm.Name, True)

        FormKey.SetValue("X", Frm.Location.X)
        FormKey.SetValue("Y", Frm.Location.Y)
        FormKey.SetValue("Width", Frm.Size.Width)
        FormKey.SetValue("Height", Frm.Size.Height)
      Catch ex As ArgumentException
        log(ex.Message)
        RetVar = False
      End Try
    End If
    Return RetVar
  End Function


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

Public Module FillControls
#Region "Fill Functions"
  Public Sub FillLocationScripts(Combo As ComboBox, Script() As Type_LocationScript, LocationID As Integer, Optional PartID As Integer = default_Int, Optional DisplaySelectRequest As Boolean = True)
    Combo.DataSource = Nothing
    Combo.Items.Clear()
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = default_Int, CurrentItem As Integer = 1



    If DisplaySelectRequest Then
      VDP_Array.Add(New ValueDescriptionPair(default_Int, "Select Script"))
      selectedIndex = 0
    End If
    If Not IsNothing(Script) Then
      For Each item In Script
        VDP_Array.Add(New ValueDescriptionPair(item.ID, item.Name))
        If item.ID = PartID Then selectedIndex = CurrentItem
        CurrentItem += 1

        'Combo.Items.Add(item.Name)
      Next
    End If

    With Combo
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      .SelectedIndex = selectedIndex
    End With
  End Sub
  Public Function addone(ByRef Array() As String) As Integer
    Dim newindex As Integer = 0
    If IsNothing(Array) Then
      ReDim Array(0)
    Else
      newindex = Array.Length
      ReDim Preserve Array(newindex)
    End If
    Return newindex
  End Function
  Public Function ExistsInStringArray(ByRef Array() As Object, SearchString As String) As Boolean
    Dim Found As Boolean = False
    If Not IsNothing(Array) Then
      For Each item In Array
        If item = SearchString Then Found = True
      Next
    End If
    Return Found
  End Function
  Public Sub FillSearch(thisGrid As DataGridView, SearchResult() As Type_SearchResult, Optional UniqueContactsOnly As Boolean = False, Optional SelectedTelephone As String = "")
    'thisGrid.DataSource = Nothing
    thisGrid.Rows.Clear()
    Dim NewIndex As Integer = 0, Selected As Integer = default_Int
    Dim contactNum() As String : Erase contactNum
    If Not IsNothing(SearchResult) Then
      For Each Item As Type_SearchResult In SearchResult
        Dim UniqueItem As Boolean = False
        If Not ExistsInStringArray(contactNum, Item.Contact.Telephone) And UniqueContactsOnly Then
          Dim contactIndex As Integer = addone(contactNum) : contactNum(contactIndex) = Item.Contact.Telephone
          UniqueItem = True
        End If


        If Not UniqueContactsOnly Or UniqueItem Then

          NewIndex = thisGrid.Rows.Add()
          'Application.DoEvents()
          thisGrid.Rows(NewIndex).Tag = New ValueDescriptionPair(Item.Contact.ID, Item.Booking.ID)


          thisGrid.Rows.Item(NewIndex).Cells(0).Value = Item.Contact.Telephone
          thisGrid.Rows.Item(NewIndex).Cells(1).Value = Item.Contact.PF_Name & " " & Item.Contact.PL_Name
          If UniqueContactsOnly Then
            thisGrid.Rows.Item(NewIndex).Cells(2).Value = "-"
            thisGrid.Rows.Item(NewIndex).Cells(3).Value = "-"
          Else
            thisGrid.Rows.Item(NewIndex).Cells(2).Value = Item.Booking.Location.Name
            thisGrid.Rows.Item(NewIndex).Cells(3).Value = Item.Booking.Status

          End If

          If SelectedTelephone = Item.Contact.Telephone Then Selected = NewIndex
        End If
      Next
    End If
    'thisGrid.Rows(0).Selected = False
    If Selected > default_Int Then thisGrid.Rows(Selected).Selected = True Else thisGrid.ClearSelection()
    Application.DoEvents()
  End Sub
  Public Sub FillRights(Combo As ComboBox, RightsList() As Type_AccessRights, Optional Find As Object = default_Int,
                     Optional SelectText As String = "Select Rights")
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = 0, CurrentItem As Integer = 1
    VDP_Array.Add(New ValueDescriptionPair(-1, SelectText))
    If Not IsNothing(RightsList) Then
      For Each item As Type_AccessRights In RightsList
        With item
          VDP_Array.Add(New ValueDescriptionPair(.ID, .Name))
          If .Name = Find.ToString Then
            selectedIndex = CurrentItem
          ElseIf .ID = InputVar(Find, default_Int) Then
            selectedIndex = CurrentItem
          End If
          CurrentItem += 1
        End With
      Next
    End If
    With Combo
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      .SelectedIndex = selectedIndex
    End With
  End Sub
  Public Sub FillSites(Combo As ComboBox, SiteList() As Type_Site, Optional Find As Object = default_Int,
                   Optional SelectText As String = "Select Rights")
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = 0, CurrentItem As Integer = 1
    VDP_Array.Add(New ValueDescriptionPair(-1, SelectText))
    For loopvar As Integer = 0 To SiteList.Length - 1
      With SiteList(loopvar)
        VDP_Array.Add(New ValueDescriptionPair(.ID, .Name))
        If .Name = Find.ToString Then
          selectedIndex = CurrentItem
        ElseIf .ID = InputVar(Find, default_Int) Then
          selectedIndex = CurrentItem
        End If
        CurrentItem += 1
      End With
    Next
    With Combo
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      .SelectedIndex = selectedIndex
    End With
  End Sub
  Public Sub FillAccessLevel(List As ListBox, AccessLevel As Type_AccessLevel(), AccessLevelID As Integer)
    List.DataSource = Nothing
    List.Items.Clear()
    Dim VDP_Array As New ArrayList
    If Not IsNothing(AccessLevel) Then
      For Each item As Type_AccessLevel In AccessLevel
        If AccessLevelID = item.ID Then
          VDP_Array.Add(New ValueDescriptionPair(item.ID, item.Name))
        End If
      Next
    End If
    With List
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      .SelectedIndex = default_Int
    End With
  End Sub
  Sub FillConns(Combo As ComboBox, TempCon() As ConnString, Optional Find As Object = default_Int,
                  Optional SelectText As String = "Select Server")
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = 0, CurrentItem As Integer = 1
    VDP_Array.Add(New ValueDescriptionPair(-1, SelectText))
    For loopvar As Integer = 0 To TempCon.Length - 1
      With TempCon(loopvar)
        VDP_Array.Add(New ValueDescriptionPair(loopvar, .DataSource))
        If .DataSource = Find.ToString Then
          selectedIndex = CurrentItem
        ElseIf loopvar = InputVar(Find, default_Int) Then
          selectedIndex = CurrentItem
        End If
        CurrentItem += 1
      End With
    Next
    With Combo
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      .SelectedIndex = selectedIndex
    End With

  End Sub

  Public Sub FillStaff(Combo As ComboBox, StaffList() As Type_Staff, Optional Find As Object = default_Int,
                       Optional SelectText As String = "Select Your Name", Optional ByVal ActiveOnly As Boolean = True)
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = 0, CurrentItem As Integer = 1
    VDP_Array.Add(New ValueDescriptionPair(-1, SelectText))
    For loopvar As Integer = 0 To StaffList.Length - 1
      With StaffList(loopvar)
        If .Active = True Or Not ActiveOnly Then
          VDP_Array.Add(New ValueDescriptionPair(.ID, .OpName))
          If .OpName = Find.ToString Then
            selectedIndex = CurrentItem
          ElseIf .ID = InputVar(Find, default_Int) Then
            selectedIndex = CurrentItem
          End If
          CurrentItem += 1
        End If
      End With
    Next
    With Combo
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      .SelectedIndex = selectedIndex
    End With
  End Sub
  Public Sub FillStaff(List As ListBox, StaffList() As Type_Staff, Optional SelectedStaffID As Integer = default_Int,
                       Optional ByVal ActiveOnly As Boolean = True)
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = default_Int, CurrentItem As Integer = 0
    For loopvar As Integer = 0 To StaffList.Length - 1
      With StaffList(loopvar)
        If .Active = True Or Not ActiveOnly Then
          VDP_Array.Add(New ValueDescriptionPair(.ID, .OpName))
          If SelectedStaffID = .ID Then selectedIndex = CurrentItem
          CurrentItem += 1
        End If
      End With
    Next
    With List
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      .SelectedIndex = selectedIndex
    End With
  End Sub
  Public Sub FillLocations(List As ListBox, LocationList() As Type_Location, Optional LocationID As Integer = default_Int)
    List.DataSource = Nothing
    List.Items.Clear()
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = default_Int, CurrentItem As Integer = 1
    'VDP_Array.Add(New ValueDescriptionPair(default_Int, "Select Location"))
    If Not IsNothing(LocationList) Then
      For Each item In LocationList
        VDP_Array.Add(New ValueDescriptionPair(item.ID, item.Name))
        If item.ID = LocationID Then selectedIndex = CurrentItem
        CurrentItem += 1

        'Combo.Items.Add(item.Name)
      Next
    End If
    With List
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      .SelectedIndex = selectedIndex
    End With
  End Sub
  Public Sub FillClipList(List As ListBox)
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = default_Int
    Dim heading As Type = GetType(Type_SearchResult), index As Integer = 0
    For Each p As System.Reflection.FieldInfo In heading.GetFields()

      VDP_Array.Add(New ValueDescriptionPair(CleanCSVString(p.Name), CleanCSVString(p.FieldType.Name) & "-" & CleanCSVString(p.Name)))
      index += 1
    Next
    With List
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      .SelectedIndex = selectedIndex
    End With
  End Sub
  Public Sub FillLocations(Combo As ComboBox, LocationList() As Type_Location, Optional LocationID As Integer = default_Int,
                          Optional DisplaySelectRequest As Boolean = True)
    Combo.DataSource = Nothing
    Combo.Items.Clear()
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = default_Int, CurrentItem As Integer = 1
    If DisplaySelectRequest Then
      VDP_Array.Add(New ValueDescriptionPair(default_Int, "Select Location"))
      selectedIndex = 0
    End If
    If Not IsNothing(LocationList) Then
      For Each item In LocationList

        If item.Enabled Then
          VDP_Array.Add(New ValueDescriptionPair(item.ID, item.Name))
          If item.ID = LocationID Then selectedIndex = CurrentItem
          CurrentItem += 1
        Else
          If item.ID = LocationID Then
            VDP_Array.Add(New ValueDescriptionPair(item.ID, item.Name))
            selectedIndex = CurrentItem
            CurrentItem += 1
          End If
        End If


        'Combo.Items.Add(item.Name)
      Next
    End If
    With Combo
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      .SelectedIndex = selectedIndex
    End With
  End Sub
  Public Sub FillSimple(List As ListBox, SimpleList() As Type_Simple, Optional LocationID As Integer = default_Int)
    List.DataSource = Nothing
    List.Items.Clear()
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = default_Int, CurrentItem As Integer = 1
    'VDP_Array.Add(New ValueDescriptionPair(default_Int, "Select Location"))
    If Not IsNothing(SimpleList) Then
      For Each item In SimpleList
        VDP_Array.Add(New ValueDescriptionPair(item.ID, item.Name))
        If item.ID = LocationID Then selectedIndex = CurrentItem
        CurrentItem += 1

        'Combo.Items.Add(item.Name)
      Next
    End If
    With List
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      .SelectedIndex = selectedIndex
    End With
  End Sub
  Public Sub FillSimple(Combo As ComboBox, SimpleList() As Type_Simple, Optional selectedID As Integer = default_Int, Optional DisplaySelectRequest As Boolean = True)
    Combo.DataSource = Nothing
    Combo.Items.Clear()
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = default_Int, CurrentItem As Integer = 1
    If DisplaySelectRequest Then
      VDP_Array.Add(New ValueDescriptionPair(default_Int, "Select"))
      selectedIndex = 0
    End If
    If Not IsNothing(SimpleList) Then
      For Each item In SimpleList
        VDP_Array.Add(New ValueDescriptionPair(item.ID, item.Name))
        If item.ID = selectedID Then selectedIndex = CurrentItem
        CurrentItem += 1
      Next
    End If
    With Combo
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      .SelectedIndex = selectedIndex
    End With
  End Sub
  'Public Sub FillLocationStatus(Combo As ComboBox, Status As Type_Status, Optional LocationID As Integer = default_Int, Optional StatusID As Integer = default_Int)
  '  Dim Index As Integer = GetLocationlistIndex(LocationID)


  '  Combo.DataSource = Nothing
  '  Combo.Items.Clear()
  '  Dim VDP_Array As New ArrayList, selectedIndex As Integer = default_Int, CurrentItem As Integer = 1
  '  VDP_Array.Add(New ValueDescriptionPair(default_Int, "Select Status"))
  '  With LocationList(Index)
  '    If Not IsNothing(.Status) Then
  '      For Each item In .Status
  '        VDP_Array.Add(New ValueDescriptionPair(item.ID, item.Name))
  '        If item.ID = StatusID Then selectedIndex = CurrentItem
  '        CurrentItem += 1

  '        'Combo.Items.Add(item.Name)
  '      Next
  '    End If
  '  End With
  '  With Combo
  '    .DisplayMember = "Description"
  '    .ValueMember = "Value"
  '    .DataSource = VDP_Array
  '    .SelectedIndex = selectedIndex
  '  End With
  'End Sub
  'Public Sub FillBookings(thisGrid As DataGridView, Booking() As Type_ContactBooking, Optional BookingID As Integer = -1)
  '  'thisGrid.DataSource = Nothing
  '  thisGrid.Rows.Clear()
  '  Dim NewIndex As Integer = 0
  '  thisGrid.Tag = default_Int
  '  If Not IsNothing(Booking) Then
  '    For Each BookItem As Type_ContactBooking In Booking
  '      NewIndex = thisGrid.Rows.Add()
  '      'Application.DoEvents()

  '      thisGrid.Rows(NewIndex).Tag = BookItem.Index
  '      thisGrid.Rows.Item(NewIndex).Cells(0).Value = BookItem.Location.ClaimPrefex
  '      thisGrid.Rows.Item(NewIndex).Cells(1).Value = BookItem.Status
  '      thisGrid.Rows.Item(NewIndex).Cells(2).Value = BookItem.Booking.Appt
  '      If BookingID = BookItem.Booking.ID Then thisGrid.Tag = NewIndex
  '    Next
  '  End If
  '  'thisGrid.Rows(0).Selected = False
  '  If thisGrid.Tag > default_Int Then thisGrid.Rows(thisGrid.Tag).Selected = True Else thisGrid.ClearSelection()
  '  Application.DoEvents()
  'End Sub
  'Public Sub FillBookings(ThisList As ListBox, Record As Type_ContactRecord, BookingID As Integer)
  '  ThisList.DataSource = Nothing
  '  ThisList.Items.Clear()
  '  Dim VDP_Array As New ArrayList, selectedIndex As Integer = -1, CurrentItem As Integer = 1

  '  VDP_Array.Add(New ValueDescriptionPair(-2, "Create New Booking"))


  '  If Record.Promo.Location.ID > 0 Then
  '    VDP_Array.Add(New ValueDescriptionPair(default_Int, "Add From Promo (" & Record.Promo.Location.ClaimPrefex & ")"))
  '    'ThisList.Items.Add("Promo")
  '  End If
  '  If Not IsNothing(Record.Booking) Then
  '    For Each BookItem As Type_ContactBooking In Record.Booking
  '      VDP_Array.Add(New ValueDescriptionPair(BookItem.Booking.ID, BookItem.Location.Name & "" & BookItem.Status))
  '      'ThisList.Items.Add(BookItem.Location)
  '    Next
  '  End If
  '  With ThisList
  '    .DisplayMember = "Description"
  '    .ValueMember = "Value"
  '    .DataSource = VDP_Array
  '    .SelectedIndex = selectedIndex
  '  End With
  '  Application.DoEvents()
  'End Sub
  Public Sub FillStatus(List As ListBox, Status() As Type_Status, Optional StatusID As Integer = default_Int)
    List.DataSource = Nothing
    List.Items.Clear()
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = default_Int, CurrentItem As Integer = 1
    'VDP_Array.Add(New ValueDescriptionPair(default_Int, "Select Status"))
    If Not IsNothing(Status) Then
      For Each item In Status
        VDP_Array.Add(New ValueDescriptionPair(item.ID, item.Name))
        If item.ID = StatusID Then selectedIndex = CurrentItem
        CurrentItem += 1

        'Combo.Items.Add(item.Name)
      Next
    End If
    With List
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      'If selectedIndex > default_Int Then
      .SelectedIndex = selectedIndex ' Else .SelectedIndex = 0
    End With
  End Sub
  Public Sub FillStatus(Combo As ComboBox, Status() As Type_Status, Optional StatusID As Integer = default_Int)
    Combo.DataSource = Nothing
    Combo.Items.Clear()
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = default_Int, CurrentItem As Integer = 1
    VDP_Array.Add(New ValueDescriptionPair(default_Int, "Select Status"))
    selectedIndex = 0
    If Not IsNothing(Status) Then
      For Each item In Status
        VDP_Array.Add(New ValueDescriptionPair(item.ID, item.Name))
        If item.ID = StatusID Then selectedIndex = CurrentItem
        CurrentItem += 1

        'Combo.Items.Add(item.Name)
      Next
    End If
    With Combo
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      .SelectedIndex = selectedIndex
    End With
  End Sub
  '    Ctl_Appt.Add(Now)
  Public Sub FillDate(ByRef Combo As ctl_MasterCal, ShowTimes() As Type_ShowTimes, Optional ThisDate As Date = default_DateTime)
    If Not IsNothing(ShowTimes) Then
      For Each item In ShowTimes
        Combo.Add(item.Showtime)
      Next
    Else
      Combo.Clear()
    End If
  End Sub


  Public Function FillHours(Grid As DataGridView, Hours() As type_Hours) As Boolean
    Dim NewIndex As Integer = 0
    Grid.Rows.Clear()

    If Not IsNothing(CC.Hours) Then
      For Each item As type_Hours In Hours

        NewIndex = Grid.Rows.Add()
        Grid.Rows.Item(NewIndex).Cells(0).Tag = item.ID
        Grid.Rows.Item(NewIndex).Cells(0).Value = item.StartTime.ToString("dddd") & "-" & Ordinal(item.StartTime.ToString("dd"))

        Grid.Rows.Item(NewIndex).Cells(1).Tag = item.ID
        Grid.Rows.Item(NewIndex).Cells(1).Value = item.StartTime.ToString("hh:mm tt")

        Grid.Rows.Item(NewIndex).Cells(2).Tag = item.ID
        Dim Tempstr As String = ""
        If Not item.EndTime = default_Date Then Tempstr = item.EndTime.ToString("hh:mm tt")
        Grid.Rows.Item(NewIndex).Cells(2).Value = Tempstr


      Next
    End If



    Return False
  End Function
  Public Sub FillDept(Combo As ComboBox, Dept() As Type_Dept, Optional DeptID As Integer = default_Int)
    Combo.DataSource = Nothing
    Combo.Items.Clear()
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = default_Int, CurrentItem As Integer = 1
    VDP_Array.Add(New ValueDescriptionPair(default_Int, "Select Dept"))
    If Not IsNothing(Dept) Then
      For Each item In Dept
        VDP_Array.Add(New ValueDescriptionPair(item.ID, item.Name))
        If item.ID = DeptID Then selectedIndex = CurrentItem
        CurrentItem += 1

        'Combo.Items.Add(item.Name)
      Next
    End If
    With Combo
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      .SelectedIndex = selectedIndex
    End With
  End Sub
  Public Sub FillDept(List As ListBox, Dept() As Type_Dept, Optional DeptID As Integer = default_Int)
    List.DataSource = Nothing
    List.Items.Clear()
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = default_Int, CurrentItem As Integer = 1
    'VDP_Array.Add(New ValueDescriptionPair(default_Int, "Select Status"))
    If Not IsNothing(Dept) Then
      For Each item In Dept
        VDP_Array.Add(New ValueDescriptionPair(item.ID, item.Name))
        If item.ID = DeptID Then selectedIndex = CurrentItem
        CurrentItem += 1

        'Combo.Items.Add(item.Name)
      Next
    End If
    With List
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      'If selectedIndex > default_Int Then
      .SelectedIndex = selectedIndex ' Else .SelectedIndex = 0
    End With
  End Sub

  Public Sub FillGift(Combo As ComboBox, Gift() As Type_Gift, Optional GiftID As Integer = default_Int,
                       Optional SelectText As String = "Select Gift", Optional ByVal EnabledOnly As Boolean = True)
    Combo.DataSource = Nothing
    Combo.Items.Clear()
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = default_Int, CurrentItem As Integer = 1
    VDP_Array.Add(New ValueDescriptionPair(default_Int, SelectText))
    selectedIndex = 0
    If Not IsNothing(Gift) Then
      For Each item In Gift

        If item.Enabled Or Not EnabledOnly Then 'Or item.ID = GiftID
          VDP_Array.Add(New ValueDescriptionPair(item.ID, item.Name))
          If item.ID = GiftID Then selectedIndex = CurrentItem
          CurrentItem += 1
        Else
          If item.ID = GiftID Then
            VDP_Array.Add(New ValueDescriptionPair(item.ID, item.Name))
            selectedIndex = CurrentItem
            CurrentItem += 1
          End If

        End If

        'Combo.Items.Add(item.Name)
      Next
    End If
    With Combo
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      .SelectedIndex = selectedIndex
    End With
  End Sub

  Public Sub FillBookingHistory(thisGrid As DataGridView, Record As Type_ContactRecord, BookingIndex As Integer)
    'thisGrid.DataSource = Nothing
    thisGrid.Rows.Clear()
    Dim NewIndex As Integer = 0, Selected As Integer = default_Int
    If Not IsNothing(Record.Booking) And BookingIndex > default_Int Then
      With Record.Booking(BookingIndex)
        If Not IsNothing(.Hist) Then
          For Each Hist As Type_BookingHist In .Hist
            NewIndex = thisGrid.Rows.Add()
            'Application.DoEvents()
            thisGrid.Rows(NewIndex).Tag = Hist.Index
            thisGrid.Rows.Item(NewIndex).Cells(0).Value = Hist.Employee
            thisGrid.Rows.Item(NewIndex).Cells(1).Value = Hist.Field
            thisGrid.Rows.Item(NewIndex).Cells(2).Value = Hist.OldValStr
            thisGrid.Rows.Item(NewIndex).Cells(3).Value = Hist.NewValStr
            thisGrid.Rows.Item(NewIndex).Cells(4).Value = Hist.ActionTime
            'If BookingID = BookItem.ID Then Selected = NewIndex
          Next
        End If
      End With
    End If
    'thisGrid.Rows(0).Selected = False
    If Selected > default_Int Then thisGrid.Rows(Selected).Selected = True Else thisGrid.ClearSelection()
    Application.DoEvents()
  End Sub
#End Region
End Module
Public Module Functions
#Region "Export CSV"
  Public Sub ExportCSVFile(FileString As String)
    Dim saveFileDialog As New SaveFileDialog()
    saveFileDialog.Filter = "Comma-separated value files (*.csv)|*.csv|All files (*.*)|*.*"
    saveFileDialog.FilterIndex = 1
    saveFileDialog.RestoreDirectory = True
    If saveFileDialog.ShowDialog() = DialogResult.OK Then
      If saveFileDialog.FileName <> "" Then System.IO.File.WriteAllText(saveFileDialog.FileName, FileString)
    End If
  End Sub
  Public Sub ExportSearch(SearchResult() As Type_SearchResult)
    If Not IsNothing(SearchResult) Then
      Dim csv As New StringBuilder(0)

      Dim heading As Type = GetType(Type_SearchResult), index As Integer = 0
      For Each p As System.Reflection.FieldInfo In heading.GetFields()
        If index > 0 Then csv.Append(",")
        csv.Append(CleanCSVString(p.Name))
        index += 1
      Next
      csv.Append(Environment.NewLine)
      For Each item As Type_SearchResult In SearchResult
        Dim csvRow As New StringBuilder()

        Dim RowInfo As Type = item.GetType : index = 0
        For Each Field As System.Reflection.FieldInfo In RowInfo.GetFields()
          If index > 0 Then csvRow.Append(",")
          csvRow.Append(CleanCSVString(Field.GetValue(item)))
          index += 1
        Next


        csv.AppendLine(csvRow.ToString())
      Next


      ExportCSVFile(csv.ToString)
    End If
  End Sub
#End Region
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
  ''' <summary>
  ''' Format Like (***) ***-****
  ''' </summary>
  ''' <param name="str"></param>
  ''' <returns></returns>
  ''' <remarks></remarks>
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
  Function getControlFromName(ByRef containerObj As Object, _
                         ByVal name As String) As Control
    Dim retCtl As Control = Nothing, found As Boolean = True
    Try
      For Each tempCtrl As Control In containerObj.Controls
        If tempCtrl.Name.ToUpper.Trim = name.ToUpper.Trim Then
          retCtl = tempCtrl
        Else
          retCtl = getControlFromName(tempCtrl, name)
        End If
        If Not IsNothing(retCtl) Then Exit For
      Next tempCtrl
    Catch ex As Exception
      found = False
    End Try
    'log("getControlFromName:" & name & " - Found:" & found.ToString)
    Return retCtl
  End Function
End Module
