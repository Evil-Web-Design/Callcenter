'Imports System.Windows.Forms
Imports UniBase
Public Class Frm_Record
  Private DataRecord As Class_CallCenter.Type_ContactRecord

  Private Sub Frm_Record_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
    Beep()
  End Sub
  ' Private ControlsActive As Boolean = False

  Private Sub Frm_Record_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
    lbl_Status.Text = "Frm_Record_HelpButtonClicked"
  End Sub

  Private Sub Frm_Record_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
    lbl_Status.Text = "Frm_Record_HelpRequested"

  End Sub



  Private Sub mnu_Contact_ButtonClick(sender As Object, e As EventArgs) Handles mnu_Contact.ButtonClick
    Dim RecordLoaded As Boolean = DataRecord.Contact.ID > default_Int
    If Not RecordLoaded Then OpenNewRecord()
    ViewTab(Tabs.Contact)
  End Sub
  Private Sub mnu_Booking_ButtonClick(sender As Object, e As EventArgs) Handles mnu_Booking.ButtonClick
    Dim HasBooking As Boolean = Not IsNothing(DataRecord.Booking)
    If Not HasBooking Then
      NewBooking(DataRecord)
      FillBooking()
    End If
    ViewTab(Tabs.Location)
  End Sub

  Private Sub cbo_NavLocation_Click(sender As Object, e As EventArgs)
  End Sub
  Private Sub cbo_NavLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_NavLocation.SelectedIndexChanged
    If ControlsActive Then
      Dim Obj_Combo As ToolStripComboBox = CType(sender, ToolStripComboBox)
      Dim Obj_Value As Integer = CInt(CType(Obj_Combo.SelectedItem, ValueDescriptionPair).Value)
      DataRecord.BookingIndex = Obj_Value
      Console.Write("cbo_NavLocation_SelectedIndexChanged " & Obj_Value & vbCrLf)
      FillBooking()
      ViewTab(Tabs.Location)
      FocusIt.Select()

    End If
  End Sub
  Private Sub cmd_NavBack_Click(sender As Object, e As EventArgs) Handles cmd_NavBack.Click
    DataRecord.BookingIndex -= 1
    FillBooking()
    ViewTab(Tabs.Location)
  End Sub
  Private Sub cmd_NavNext_Click(sender As Object, e As EventArgs) Handles cmd_NavNext.Click
    DataRecord.BookingIndex += 1
    FillBooking()
    ViewTab(Tabs.Location)
  End Sub



  Private Sub cmd_History_Click(sender As Object, e As EventArgs) Handles cmd_History.Click
    If Not IsNothing(DataRecord.Booking) Then
      OpenHistory(DataRecord, DataRecord.BookingIndex)
    End If
  End Sub
  Private AllGifts As Boolean = False
  Private Sub cmd_ShowAllGifts_Click(sender As Object, e As EventArgs) Handles cmd_ShowAllGifts.Click
    cmd_ShowAllGifts.Checked = Not cmd_ShowAllGifts.Checked
    AllGifts = cmd_ShowAllGifts.Checked
    FillGifts(DataRecord.BookingIndex)
  End Sub

  Private Sub cmd_NewBooking_Click(sender As Object, e As EventArgs) Handles cmd_NewBooking.Click
    NewBooking(DataRecord)
    FillBooking()
    ViewTab(Tabs.Location)
  End Sub
  Private Sub mnu_Search_Click(sender As Object, e As EventArgs) Handles mnu_Search.Click
    OpenSearch()
  End Sub
  Private Sub mnu_NewRecord_Click(sender As Object, e As EventArgs) Handles mnu_NewRecord.Click, cmd_NextCall.Click
    OpenNewRecord()
    NextCall()
  End Sub
  Private Sub cmd_Close_Click(sender As Object, e As EventArgs) Handles cmd_Close.Click
    NextCall()
  End Sub

  Private Enum Tabs
    None
    Contact
    Location
  End Enum
  Private Sub ViewTab(DisplayTab As Tabs)

    Dim RecordLoaded As Boolean = DataRecord.Contact.ID > default_Int
    Dim HasBookings As Boolean = Not IsNothing(DataRecord.Booking)

    Select Case DisplayTab
      Case Tabs.Contact
        mnu_Contact.BackColor = Color.FromArgb(255, 255, 255, 192)
        mnu_Booking.BackColor = mnu_ToolStrip.BackColor
      Case Tabs.Location
        mnu_Contact.BackColor = mnu_ToolStrip.BackColor
        mnu_Booking.BackColor = Color.FromArgb(255, 255, 255, 192)
      Case Tabs.None
        mnu_Contact.BackColor = mnu_ToolStrip.BackColor
        mnu_Booking.BackColor = mnu_ToolStrip.BackColor
    End Select


    With CC.CurStaff.Rights
      Table_Contact.Visible = RecordLoaded And DisplayTab = Tabs.Contact
      Table_Booking.Visible = HasBookings And DisplayTab = Tabs.Location

      mnu_Contact.Visible = True 'Not .MultiRecordUI
      mnu_Search.Visible = .SearchBookings

      mnu_Booking.Visible = RecordLoaded
      cmd_History.Visible = HasBookings
      cmd_NewBooking.Visible = RecordLoaded And .EditBookings
      cmd_ShowAllGifts.Enabled = RecordLoaded
      cmd_NavNext.Visible = RecordLoaded
      cmd_NavBack.Visible = RecordLoaded
      cbo_NavLocation.Visible = RecordLoaded
      mnu_Separator.Visible = RecordLoaded
    End With
    Application.DoEvents()
  End Sub
  Public Sub LoadRecord(Record As Class_CallCenter.Type_ContactRecord)
    ControlsActive = False
    'ViewTab(Tabs.None)
    DataRecord = Record

    With Record
      tel_Phone.Value = .Contact.Telephone
      tel_AltPhone.Value = .Contact.AltPhone
      txt_PFirst.Text = .Contact.PF_Name
      txt_PLast.Text = .Contact.PL_Name
      txt_SFirst.Text = .Contact.SF_Name
      txt_SLast.Text = .Contact.SL_Name
      txt_Email.Text = .Contact.Email

      txt_Address.Text = .Contact.Address1
      txt_AddressExtra.Text = .Contact.Address2
      txt_City.Text = .Contact.City
      txt_State.Text = .Contact.ST
      txt_Zip.Text = .Contact.Zip
      txt_Notes.Text = .Contact.Notes

      Me.Text = FormatPhoneNumber(.Contact.Telephone) & " " & .Contact.PL_Name & ", " & .Contact.PF_Name
      Me.Tag = .Contact.ID

      FillBooking()
    End With
    ViewTab(Tabs.Contact)

    Me.Show()
    tel_Phone.Focus()

    ControlsActive = True
    Application.DoEvents()
  End Sub

  Private WithEvents lbl_ClaimNumber As New Label With {
    .Anchor = AnchorStyles.Left Or AnchorStyles.Right, .TextAlign = ContentAlignment.MiddleLeft}
  Private WithEvents txt_ClaimNumber As New TextBox With {.Name = "txt_ClaimNumber",
    .Anchor = AnchorStyles.Left Or AnchorStyles.Right}

  Private Sub FillBooking()
    Dim TempControlsActive = ControlsActive : ControlsActive = False

    With DataRecord
      If Not IsNothing(.Booking) Then





        With .Booking(DataRecord.BookingIndex).Booking
          FillLocations(cbo_Location, CC.LocationList, .LocationID)
          CC.GetLocationStatus(.LocationID, .StatusID)
          CC.initShowTimes(.LocationID)
          FillStatus(cbo_Status, CC.Status, .StatusID)
          FillStaff(cbo_Booker, CC.StaffList, .BookerID, "Select Bookers's Name")
          FillStaff(cbo_Confirmer, CC.StaffList, .ConfirmerID, "Select Confirmer's Name")
          If .LocationID > default_Int Then
            FillDate(Ctl_Appt, CC.LocationList(CC.GetLocationlistIndex(.LocationID)).ShowTimes)
          Else
            FillDate(Ctl_Appt, Nothing)

          End If
          'date_Appt.Value = InputVar(.Appt, date_Appt.MinDate)
          'Ctl_Appt.Value = InputVar(.Appt, New Date)

          date_Booked.Value = InputVar(.Booked, date_Booked.MinDate)
          date_Conf.Value = InputVar(.Conf, date_Conf.MinDate)
          lbl_ClaimNumber.Text = .ClaimNumber
          txt_ClaimNumber.Text = .ClaimNumber
          If .ClaimNumber.Length > 0 And .ClaimNumberValid Then
            Table_Booking.Controls.Remove(txt_ClaimNumber)
            Table_Booking.Controls.Add(lbl_ClaimNumber, 1, 0)
          Else
            Table_Booking.Controls.Remove(lbl_ClaimNumber)
            Table_Booking.Controls.Add(txt_ClaimNumber, 1, 0)
          End If
          Console.Write("Ctl_Appt.Value:" & .Appt & vbCrLf)

          Ctl_Appt.Value = InputVar(.Appt, New Date)

          FillGifts(DataRecord.BookingIndex)

          txt_BookNotes.Text = .Notes
          Dim HasLocation As Boolean = .LocationID > default_Int
          Dim HasAppt As Boolean = .Appt <> New Date
          Dim HasStat As Boolean = .StatusID > default_Int
          Dim HasConf As Boolean = .ConfirmerID > default_Int

          With CC.CurStaff.Rights
            cbo_Location.Enabled = .EditBookings
            Ctl_Appt.Enabled = HasLocation And .EditBookings
            cbo_Status.Enabled = HasLocation And .EditBookings

            cbo_Booker.Enabled = HasLocation And HasStat And .EditBookings And .EditBookings
            date_Booked.Enabled = HasLocation And HasStat And .ChangeBookDate And .EditBookings

            cbo_Confirmer.Enabled = HasLocation And HasStat And .EditBookings
            date_Conf.Enabled = HasLocation And HasStat And HasConf And .EditBookings



            cbo_Gift1.Enabled = HasLocation And HasStat And .EditBookings
            cbo_Gift2.Enabled = HasLocation And HasStat And .EditBookings
            cbo_Gift3.Enabled = HasLocation And HasStat And .EditBookings

            txt_BookNotes.Enabled = HasLocation And .EditBookings
          End With
        End With

        cbo_NavLocation.Items.Clear()
        Dim selectedIndex As Integer = default_Int, CurrentItem As Integer = 0

        For Each item As UniBase.Class_CallCenter.Type_ContactBooking In .Booking
          cbo_NavLocation.Items.Add(New ValueDescriptionPair(item.Index, item.Booking.Location.Name))
          If DataRecord.BookingIndex = item.Index Then selectedIndex = CurrentItem
          CurrentItem += 1
        Next
        cbo_NavLocation.SelectedIndex = selectedIndex


        cbo_NavLocation.SelectedIndex = DataRecord.BookingIndex
        cbo_NavLocation.Enabled = (.Booking.Length > 1)
        cmd_NavBack.Enabled = (DataRecord.BookingIndex <> 0)
        cmd_NavNext.Enabled = (DataRecord.BookingIndex <> (.Booking.Length - 1))
        'tbl_Booking.Visible = True
      Else
        cbo_NavLocation.Enabled = False
        cmd_NavBack.Enabled = False
        cmd_NavNext.Enabled = False
        'tbl_Booking.Visible = True
      End If
    End With
    ControlsActive = TempControlsActive
  End Sub
  Private Sub FillGifts(BookingIndex As Integer)
    Dim TempControlsActive = ControlsActive : ControlsActive = False
    With DataRecord.Booking(BookingIndex).Booking
      FillGift(cbo_Gift1, CC.GiftList, .Gift1_ID, "Select Gift One", Not AllGifts)
      FillGift(cbo_Gift2, CC.GiftList, .Gift2_ID, "Select Gift Two", Not AllGifts)
      FillGift(cbo_Gift3, CC.GiftList, .Gift3_ID, "Select Gift Three", Not AllGifts)
    End With
    ControlsActive = TempControlsActive
  End Sub
  Private Sub Field_HelpRequest(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles tel_Phone.HelpRequested, tel_AltPhone.HelpRequested,
    txt_PFirst.HelpRequested, txt_PLast.HelpRequested, txt_SFirst.HelpRequested, txt_SLast.HelpRequested, txt_Email.HelpRequested,
    txt_Address.HelpRequested, txt_AddressExtra.HelpRequested, txt_City.HelpRequested, txt_State.HelpRequested, txt_Zip.HelpRequested,
     date_Booked.HelpRequested, date_Conf.HelpRequested,
    cbo_Location.HelpRequested, cbo_Status.HelpRequested,
      cbo_Booker.HelpRequested, cbo_Confirmer.HelpRequested,
      cbo_Gift1.HelpRequested, cbo_Gift2.HelpRequested, cbo_Gift3.HelpRequested
    If ControlsActive Then
      Dim Mesasage As String = ""
      Select Case sender.name
        Case "cbo_NavLocation" : Mesasage = "Booking Navigation. Use this to see all bookings linked to this contact."
        Case "Ctl_Phone" : Mesasage = "Enter Primary Phone number here. Valid input characters are 0-9"
        Case "Ctl_AltPhone" : Mesasage = "Enter A second Phone number here. Valid input characters are 0-9"
        Case "txt_PFirst" : Mesasage = "Enter Primary First name here."
        Case "txt_PLast" : Mesasage = "Enter Primary Last name here."
        Case "txt_SFirst" : Mesasage = "Enter Secondary First name here."
        Case "txt_SLast" : Mesasage = "Enter Secondary Last name here."
        Case "txt_Email" : Mesasage = "Enter Primary Email here."
        Case "txt_Address" : Mesasage = "Enter Primary Address here."
        Case "txt_AddressExtra" : Mesasage = "Enter Primary Address Extra here."
        Case "txt_City" : Mesasage = "Enter Primary City here."
        Case "txt_State" : Mesasage = "Enter Primary State initial here."
        Case "txt_Zip" : Mesasage = "Enter Primary Zip here."

        Case "Date_Appt" : Mesasage = "Enter the Date and time for appointment arrival here."
        Case "Date_Booked" : Mesasage = "Enter the Date and time that this appointment booking was Booked here."
        Case "Date_Conf" : Mesasage = "Enter the Date and time that this appointment booking was Confirmed here."

        Case "cbo_Location" : Mesasage = "Select Location for this booking here."
        Case "cbo_Status" : Mesasage = "Select Status for this booking here."

        Case "cbo_Booker" : Mesasage = "Select The Staff member that booked this appointment booking here."
        Case "cbo_Confirmer" : Mesasage = "Select The Staff member that confirmed this appointment booking here."

        Case "cbo_Gift1" : Mesasage = "Select Gift one here."
        Case "cbo_Gift2" : Mesasage = "Select Gift two here."
        Case "cbo_Gift3" : Mesasage = "Select Gift three here."

        Case Else : Mesasage = "No help available for this field."
      End Select
      Help.ShowPopup(Me, Mesasage, hlpevent.MousePos)
    End If
  End Sub






#Region "Form Control Events"
  Private Sub Frm_Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    FocusIt.Location = New Drawing.Point(-FocusIt.Size.Width, -FocusIt.Size.Height)
    'ClearDataRecord()
    Table_Booking.Dock = DockStyle.Fill
    Table_Contact.Dock = DockStyle.Fill
    'ViewTab(Tabs.None)
    'Table_MainLayoutPanel.Location = New Point(0, 0)
    'Table_MainLayoutPanel.Width = Split.Width - 10
    'Table_MainLayoutPanel.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right

    'TableBookLayout.Location = New Point(0, 0)
    'TableBookLayout.Width = Split.Width - 10
    'TableBookLayout.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
    Dim regKey As New RegEdit(AppName)

    Dim frm As Form = FindWindow("Frm_Record")
    If IsNothing(frm) Then
      regKey.GetSavedFormLocation(Me, RegEdit.Enum_FormPos.Both)
    Else
      regKey.GetSavedFormLocation(Me, RegEdit.Enum_FormPos.Size)
    End If

    regKey.Close()

    'AddHandler Date_Appt.DropDown, AddressOf Field_DropDown

  End Sub
  Private Sub Frm_Record_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    If Not OkToClose() Then
      NextCall()
      e.Cancel = True
    End If
  End Sub
  Sub NextCall()
    Dim RecordLoaded As Boolean = DataRecord.Contact.ID > default_Int
    If RecordLoaded Then ClearDataRecord(DataRecord)
    ViewTab(Tabs.None)
    Me.Hide()
    ' OpenNewRecord()
  End Sub
  Private Sub Frm_SignIn_Move(sender As Object, e As EventArgs) Handles MyBase.Move, MyBase.Resize
    Dim regKey As New RegEdit(AppName)
    regKey.SetSavedFormLocation(Me)
    regKey.Close()
  End Sub
  Private Sub Field_TextChanged(sender As Object, e As EventArgs) Handles tel_Phone.TextChanged, tel_AltPhone.TextChanged,
    txt_PFirst.TextChanged, txt_PLast.TextChanged, txt_SFirst.TextChanged, txt_SLast.TextChanged, txt_Email.TextChanged,
    txt_Address.TextChanged, txt_AddressExtra.TextChanged, txt_City.TextChanged, txt_State.TextChanged, txt_Zip.TextChanged,
     date_Booked.ValueChanged, date_Conf.ValueChanged, txt_BookNotes.TextChanged, txt_Notes.TextChanged
  End Sub
  Public Keyboard As New Microsoft.VisualBasic.Devices.Keyboard
  Private Sub Field_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tel_Phone.KeyPress, tel_AltPhone.KeyPress,
    txt_PFirst.KeyPress, txt_PLast.KeyPress, txt_SFirst.KeyPress, txt_SLast.KeyPress, txt_Email.KeyPress,
    txt_Address.KeyPress, txt_AddressExtra.KeyPress, txt_City.KeyPress, txt_State.KeyPress, txt_Zip.KeyPress,
     date_Booked.KeyPress, date_Conf.KeyPress
    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
      Keyboard.SendKeys("{tab}")
      'ctl_Phone.Focus()
    End If
  End Sub
  Private Sub Phone_LostFocus(sender As Object, e As EventArgs) Handles tel_Phone.LostFocus, tel_AltPhone.LostFocus
    If ControlsActive Then
      Dim Obj_Phone As ctl_Phone = CType(sender, ctl_Phone)
      Dim FormField As New TypeFormField With {.ControlName = Obj_Phone.Name,
                                               .NewValue = Obj_Phone.Value,
                                               .FieldName = "NA"}
      UpdateContact(DataRecord, Me, FormField)
    End If
  End Sub
  Private Sub Field_LostFocus(sender As Object, e As EventArgs) Handles txt_PFirst.LostFocus, txt_PLast.LostFocus,
    txt_SFirst.LostFocus, txt_SLast.LostFocus, txt_Email.LostFocus,
    txt_Address.LostFocus, txt_AddressExtra.LostFocus, txt_City.LostFocus, txt_State.LostFocus, txt_Zip.LostFocus,
    txt_Notes.LostFocus
    If ControlsActive Then
      Dim Obj_Field As TextBox = CType(sender, TextBox)
      Dim FormField As New TypeFormField With {.ControlName = Obj_Field.Name,
                                         .NewValue = Obj_Field.Text,
                                         .FieldName = "NA"}
      UpdateContact(DataRecord, Me, FormField)
    End If
  End Sub
  Private Sub cbo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Location.SelectedIndexChanged, cbo_Status.SelectedIndexChanged,
      cbo_Booker.SelectedIndexChanged, cbo_Confirmer.SelectedIndexChanged,
      cbo_Gift1.SelectedIndexChanged, cbo_Gift2.SelectedIndexChanged, cbo_Gift3.SelectedIndexChanged
    If ControlsActive Then
      Dim Obj_Combo As ComboBox = CType(sender, ComboBox)
      Dim Obj_Value As Integer = CInt(CType(Obj_Combo.SelectedItem, ValueDescriptionPair).Value)
      Dim FormField As New TypeFormField With {.ControlName = Obj_Combo.Name,
                                         .NewValue = Obj_Value,
                                         .FieldName = "NA"}
      UpdateBooking(DataRecord, Me, FormField)
      FillBooking()
      FocusIt.TabIndex = Obj_Combo.TabIndex
      FocusIt.Select()
    End If
  End Sub
  Private Sub Ctl_Appt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ctl_Appt.SelectedIndexChanged
    If ControlsActive Then
      Dim Obj_Date As ctl_MasterCal = CType(sender, ctl_MasterCal)
      If Not Obj_Date.Value = New Date And Obj_Date.IsValid Then
        Dim FormField As New TypeFormField With {.ControlName = Obj_Date.Name,
                                     .NewValue = Obj_Date.Value,
                                     .FieldName = "NA"}
        UpdateBooking(DataRecord, Me, FormField)
      End If
    End If
  End Sub
  Private Sub Date_ValueChanged(sender As Object, e As EventArgs) Handles date_Booked.LostFocus, date_Conf.LostFocus
    If ControlsActive Then
      Dim Obj_Date As DateTimePicker = CType(sender, DateTimePicker)
      Dim FormField As New TypeFormField With {.ControlName = Obj_Date.Name,
                                   .NewValue = Obj_Date.Value,
                                   .FieldName = "NA"}
      UpdateBooking(DataRecord, Me, FormField)
      FillBooking()
    End If
  End Sub
  Private Sub BookingField_LostFocus(sender As Object, e As EventArgs) Handles txt_ClaimNumber.LostFocus, txt_BookNotes.LostFocus
    If ControlsActive Then
      Dim Obj_Field As TextBox = CType(sender, TextBox)
      Dim FormField As New TypeFormField With {.ControlName = Obj_Field.Name,
                                         .NewValue = Obj_Field.Text,
                                         .FieldName = "NA"}
      UpdateBooking(DataRecord, Me, FormField)
      FillBooking()
    End If

  End Sub
  Private Sub cmd_Save_ButtonClick(sender As Object, e As EventArgs) Handles cmd_Save.Click
    Field_Status(Me, "Saved.")
    FocusIt.Select()
  End Sub
#End Region


End Class