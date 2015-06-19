Imports UniBase
Imports UniBase.Class_Main

Public Class Frm_OpRecord
  WithEvents popup As Popup
  WithEvents MasterDates As New ctl_DateTime
  Private DataRecord As Type_ContactRecord




#Region "Form Control Events"

  Private Sub Frm_Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim TempControlsActive = ControlsActive : ControlsActive = False
    FocusIt.Location = New Drawing.Point(-FocusIt.Size.Width, -FocusIt.Size.Height)
    Me.Size = Me.MinimumSize
    'ClearDataRecord()
    Table_Contact.Dock = DockStyle.Fill
    'ViewTab(Tabs.None)
    'Table_MainLayoutPanel.Location = New Point(0, 0)
    'Table_MainLayoutPanel.Width = Split.Width - 10
    'Table_MainLayoutPanel.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right

    'TableBookLayout.Location = New Point(0, 0)
    'TableBookLayout.Width = Split.Width - 10
    'TableBookLayout.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
    Dim regKey As New RegEdit(AppName)

    'Dim frm As Form = FindWindow("Frm_OpRecord")
    'If IsNothing(frm) Then
    regKey.GetSavedFormLocation(Me, RegEdit.Enum_FormPos.Both)
    'Else
    'regKey.GetSavedFormLocation(Me, RegEdit.Enum_FormPos.Size)
    'End If

    regKey.Close()

    'AddHandler Date_Appt.DropDown, AddressOf Field_DropDown
    ControlsActive = TempControlsActive
  End Sub
  Private Sub Frm_Record_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    Dim BookingOK As Boolean = OkToLeaveBooking(Me, DataRecord)
    If Not BookingOK Then
      e.Cancel = True
    Else
      'If Not OkToClose() Then
      NextCall()
      e.Cancel = True
      'End If
    End If
    FocusIt.Focus()
    Application.DoEvents()
  End Sub
  Sub NextCall()
    Dim RecordLoaded As Boolean = DataRecord.Contact.ID > default_Int
    If RecordLoaded Then ClearDataRecord(DataRecord)
    Me.Hide()
    OpenNewRecord()
  End Sub

  Private Sub Frm_SignIn_Move(sender As Object, e As EventArgs) Handles MyBase.Resize, MyBase.Move
    If ControlsActive Then
      Dim regKey As New RegEdit(AppName)
      regKey.SetSavedFormLocation(Me)
      regKey.Close()
    End If
  End Sub
  Private Sub Field_TextChanged(sender As Object, e As EventArgs) Handles tel_Phone.TextChanged, tel_AltPhone.TextChanged,
  txt_PFirst.TextChanged, txt_PLast.TextChanged, txt_SFirst.TextChanged, txt_SLast.TextChanged, txt_Email.TextChanged,
   txt_BookNotes.TextChanged
  End Sub
  Public Keyboard As New Microsoft.VisualBasic.Devices.Keyboard
  Private Sub Field_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tel_Phone.KeyPress, tel_AltPhone.KeyPress,
     txt_PFirst.KeyPress, txt_PLast.KeyPress, txt_SFirst.KeyPress, txt_SLast.KeyPress, txt_Email.KeyPress
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
    txt_SFirst.LostFocus, txt_SLast.LostFocus, txt_Email.LostFocus
    If ControlsActive Then
      Dim Obj_Field As TextBox = CType(sender, TextBox)
      Dim FormField As New TypeFormField With {.ControlName = Obj_Field.Name,
                                         .NewValue = Obj_Field.Text,
                                         .FieldName = "NA"}
      UpdateContact(DataRecord, Me, FormField)
    End If
  End Sub
  Private Sub cbo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Location.SelectedIndexChanged, cbo_Status.SelectedIndexChanged,
      cbo_Gift1.SelectedIndexChanged, cbo_Gift2.SelectedIndexChanged
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
  Private Sub MasterCal_SelectedIndexChanged(sender As Object, e As EventArgs)
    If ControlsActive Then
      Dim Obj_Date As ctl_MasterCal = CType(sender, ctl_MasterCal)
      If Not Obj_Date.Value = New Date And Obj_Date.IsValid Then
        Dim FormField As New TypeFormField With {.ControlName = Obj_Date.Name,
                                     .NewValue = Obj_Date.Value,
                                     .FieldName = "NA"}
        UpdateBooking(DataRecord, Me, FormField)
        FillBooking()
      End If
      FocusIt.TabIndex = Obj_Date.TabIndex
      FocusIt.Select()
    End If
  End Sub
  Private Sub Date_ValueChanged(sender As Object, e As EventArgs)
    If ControlsActive Then
      Dim Obj_Date As DateTimePicker = CType(sender, DateTimePicker)
      Dim FormField As New TypeFormField With {.ControlName = Obj_Date.Name,
                                   .NewValue = Obj_Date.Value,
                                   .FieldName = "NA"}
      UpdateBooking(DataRecord, Me, FormField)
      FillBooking()
    End If
  End Sub
  Private Sub BookingField_LostFocus(sender As Object, e As EventArgs) Handles txt_BookNotes.LostFocus
    If ControlsActive Then
      Dim Obj_Field As TextBox = CType(sender, TextBox)
      Dim FormField As New TypeFormField With {.ControlName = Obj_Field.Name,
                                         .NewValue = Obj_Field.Text,
                                         .FieldName = "NA"}
      UpdateBooking(DataRecord, Me, FormField)
      FillBooking()
    End If

  End Sub


  Private Sub FillBooking(Optional Refresh As Boolean = False)

    Dim TempControlsActive = ControlsActive : ControlsActive = False
    If IsNothing(DataRecord.Booking) Then CC.InitNewBooking(DataRecord, CC.CurStaff.ID, False)
    With DataRecord
      Dim CanEdit As Boolean = True
      If Not IsNothing(.Booking) Then
        With .Booking(DataRecord.BookingIndex).Booking
          Dim Statusindex = CC.GetStatuslistIndex(.StatusID)
          FillLocations(cbo_Location, CC.LocationList, .Location.ID)
          CC.initShowTimes(.Location.ID, Refresh)




          CC.initStatus(Refresh)
          If .Location.ID > default_Int Then
            CC.initStatusSP(.Location.ID, Refresh)
            FillDate(MasterDates, CC.LocationList(CC.GetLocationlistIndex(.Location.ID)).ShowTimes)
            Dim Index As Integer = CC.GetLocationlistIndex(.Location.ID)
            FillStatus(cbo_Status, CC.Status, .StatusID, CC.LocationList(Index).Status)
          Else
            FillDate(MasterDates, Nothing)
            FillStatus(cbo_Status, CC.Status, .StatusID)
          End If

          If .Appt = default_DateTime Then
            MasterDates.SelectedDate = Now
            txt_Appt.Text = "No Appt Date - Click Here to Set->"
          Else
            Dim Dstr As String = "On " & .Appt.ToString("dddd, MMMM ") & _
              .Appt.Day.DisplayWithSuffix & "," & .Appt.ToString("yyyy")
            Dim Tstr As String = " at " & .Appt.ToString("hh:mm tt")
            txt_Appt.Text = Dstr & Tstr
            MasterDates.SelectedDate = .Appt
          End If
          popup = New Popup(MasterDates, cmd_ApptDate)

          FillGifts(DataRecord.BookingIndex)

          txt_BookNotes.Text = .Notes
          Dim HasLocation As Boolean = .Location.ID > default_Int
          Dim HasAppt As Boolean = .Appt <> New Date
          Dim HasStat As Boolean = .StatusID > default_Int
          Dim HasConf As Boolean = .ConfirmerID > default_Int

          If Statusindex > default_Int Then
            CanEdit = Not CC.Status(Statusindex).LockBooking
          End If

          With CC.CurStaff.Rights
            'If .EditLockedBooking Then CanEdit = True

            cbo_Location.Enabled = .EditBookings And CanEdit

            txt_Appt.Enabled = HasLocation And .EditBookings
            cmd_ApptDate.Enabled = HasLocation And .EditBookings And CanEdit


            cbo_Gift1.Enabled = HasLocation And .EditBookings And CanEdit
            cbo_Gift2.Enabled = HasLocation And .EditBookings And CanEdit

            cbo_Status.Enabled = HasLocation And .EditBookings And CanEdit

            txt_BookNotes.Enabled = HasLocation And .EditBookings And CanEdit
          End With


        End With
        Dim LockedText As String = ""
        cmd_NewBooking.Visible = Not CanEdit
        If CanEdit Then
          Table_Contact.RowStyles(5).Height = 1
        Else
          Table_Contact.RowStyles(5).Height = 50
          LockedText = "(Closed) - "
          If CC.isNewBookingNeeded(DataRecord) Then
            cmd_NewBooking.Text = "This Booking is Closed.  " & vbCrLf & "Click here to create a new booking."
          Else
            cmd_NewBooking.Text = "This Booking is Closed.  " & vbCrLf & "Click here to edit the active booking."
          End If
        End If
        Me.Text = LockedText & FormatPhoneNumber(.Contact.Telephone) & " " & .Contact.PL_Name & ", " & .Contact.PF_Name
        'Table_Contact.row()


        'cbo_NavLocation.Items.Clear()
        'Dim selectedIndex As Integer = default_Int, CurrentItem As Integer = 0

        'For Each item As UniBase.Class_CallCenter.Type_ContactBooking In .Booking
        '  cbo_NavLocation.Items.Add(New ValueDescriptionPair(item.Index, item.Booking.Location.Name))
        '  If DataRecord.BookingIndex = item.Index Then selectedIndex = CurrentItem
        '  CurrentItem += 1
        'Next
        'cbo_NavLocation.SelectedIndex = selectedIndex


        'cbo_NavLocation.SelectedIndex = DataRecord.BookingIndex
        'cbo_NavLocation.Enabled = (.Booking.Length > 1)
        'cmd_NavBack.Enabled = (DataRecord.BookingIndex <> 0)
        'cmd_NavNext.Enabled = (DataRecord.BookingIndex <> (.Booking.Length - 1))
        'tbl_Booking.Visible = True
      Else
        'cbo_NavLocation.Enabled = False
        ' cmd_NavBack.Enabled = False
        'cmd_NavNext.Enabled = False
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
    End With
    ControlsActive = TempControlsActive
  End Sub
  Private Sub cmd_Save_ButtonClick(sender As Object, e As EventArgs) Handles cmd_Save.Click
    Field_Status(Me, "Saved.")
    FocusIt.Select()
  End Sub

#End Region
  Private AllGifts As Boolean = False
  'Private Sub cmd_ShowAllGifts_Click(sender As Object, e As EventArgs) Handles cmd_ShowAllGifts.Click
  '  cmd_ShowAllGifts.Checked = Not cmd_ShowAllGifts.Checked
  '  AllGifts = cmd_ShowAllGifts.Checked
  '  FillGifts(DataRecord.BookingIndex)
  'End Sub
  Private Sub mnu_NewRecord_Click(sender As Object, e As EventArgs) Handles cmd_NextCall.Click
    Dim BookingOK As Boolean = OkToLeaveBooking(Me, DataRecord)
    If Not BookingOK Then
      'e.Cancel = True
    Else
      'If OkToClose() Then
      NextCall()
      'e.Cancel = True
      'End If
    End If
    FocusIt.Focus()
    Application.DoEvents()
  End Sub



  Public Sub LoadRecord(Record As Type_ContactRecord)
    ControlsActive = False
    'ViewTab(Tabs.None)
    DataRecord = Record

    Me.Show()
    With Record
      tel_Phone.Value = .Contact.Telephone
      tel_AltPhone.Value = .Contact.AltPhone
      txt_PFirst.Text = .Contact.PF_Name
      txt_PLast.Text = .Contact.PL_Name
      txt_SFirst.Text = .Contact.SF_Name
      txt_SLast.Text = .Contact.SL_Name
      txt_Email.Text = .Contact.Email

      Me.Tag = .Contact.ID

      SetControlsBG(Me, System.Drawing.SystemColors.Window)
      FillBooking(True)
    End With

    tel_Phone.Focus()
    ControlsActive = True
    Application.DoEvents()
  End Sub

  Private Sub cmd_ApptDate_Click(sender As Object, e As EventArgs) Handles cmd_ApptDate.Click
    If Not IsNothing(popup) Then
      With popup
        .HorizontalPlacement = Intelepros.Popup.ePlacement.Top
        .Show()
        MasterDates.Update()
      End With
    End If
  End Sub

  Private Sub MasterDates_SetDate(NewDate As Date) Handles MasterDates.SetDate
    If ControlsActive Then
      HidePopup()
      If Not NewDate = default_DateTime Then
        Dim FormField As New TypeFormField With {.ControlName = txt_Appt.Name,
                                     .NewValue = NewDate.ToString("MM/dd/yyyy HH:mm:00"),
                                     .FieldName = "NA"}
        UpdateBooking(DataRecord, Me, FormField)
        FillBooking()
      Else
        txt_Appt.BackColor = Color.Red
      End If
      'FocusIt.TabIndex = Obj_Date.TabIndex
      FocusIt.Select()
    End If
  End Sub
  Private Sub MasterDates_Cancel() Handles MasterDates.Cancel
    HidePopup()
  End Sub
  Sub HidePopup()
    If Not IsNothing(popup) Then
      popup.Hide()
    End If
  End Sub

  Private Sub cmd_NewBooking_Click(sender As Object, e As EventArgs) Handles cmd_NewBooking.Click

    CC.InitNewBooking(DataRecord, CC.CurStaff.ID, True)
    SetControlsBG(Me, System.Drawing.SystemColors.Window)
    FillBooking()


  End Sub
End Class