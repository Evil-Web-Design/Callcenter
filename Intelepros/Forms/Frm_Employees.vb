Imports UniBase
Public Class Frm_Employees

  Private Sub lst_Employees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Employees.SelectedIndexChanged
    If ControlsActive Then
      Dim StaffID As Integer = InputVar(CType(lst_Employees.SelectedItem, ValueDescriptionPair).Value, default_Int)
      Dim index As Integer = CC.GetStafflistIndex(StaffID)
      DrawEditEmployee(index)
    End If
  End Sub
  Private Sub Field_TextChanged(sender As Object, e As EventArgs) Handles txt_E_First.TextChanged
  End Sub


  Private Sub Phone_LostFocus(sender As Object, e As EventArgs) Handles Ctl_Phone.LostFocus, Ctl_AltPhone.LostFocus
    If ControlsActive Then
      Dim Obj_Phone As ctl_Phone = CType(sender, ctl_Phone)
      Dim FormField As New TypeFormField With {.ControlName = Obj_Phone.Name,
                                               .NewValue = Obj_Phone.Value,
                                               .FieldName = "NA"}
      UpdateContact(FormField)
    End If
  End Sub
  Private Sub Field_LostFocus(sender As Object, e As EventArgs) Handles txt_E_First.LostFocus, txt_E_Last.LostFocus,
    txt_E_SS.LostFocus, txt_E_Add1.LostFocus, txt_E_Add2.LostFocus, txt_E_City.LostFocus,
    txt_E_State.LostFocus, txt_E_Zip.LostFocus, txt_E_Econtact.LostFocus, txt_E_Password.LostFocus

    Dim Obj_Field As TextBox = CType(sender, TextBox)
    If ControlsActive Then

      Dim FormField As New TypeFormField With {.ControlName = Obj_Field.Name,
                                              .NewValue = Obj_Field.Text,
                                              .FieldName = "NA"}
      UpdateContact(FormField)
    End If
  End Sub
  Sub UpdateContact(FormField As TypeFormField)
    Dim StaffID As Integer = InputVar(CType(lst_Employees.SelectedItem, ValueDescriptionPair).Value, default_Int)
    Dim index As Integer = CC.GetStafflistIndex(StaffID)
    If index > default_Int Then
      With CC.StaffList(index)
        Select Case FormField.ControlName
          Case "Ctl_Phone" : FormField.OldValue = .Phone : .Phone = FormField.NewValue : FormField.FieldName = "Phone"
          Case "Ctl_AltPhone" : FormField.OldValue = .EContactPhone : .EContactPhone = FormField.NewValue : FormField.FieldName = "EContactPhone"

          Case "txt_E_First"
            FormField.OldValue = .FirstName : .FirstName = FormField.NewValue : FormField.FieldName = "FirstName"
            UpdateStaffList(index)
          Case "txt_E_Last"
            FormField.OldValue = .LastName : .LastName = FormField.NewValue : FormField.FieldName = "LastName"
          Case "txt_E_SS" : FormField.OldValue = .ss : .ss = FormField.NewValue : FormField.FieldName = "ss"
          Case "txt_E_Add1" : FormField.OldValue = .Address1 : .Address1 = FormField.NewValue : FormField.FieldName = "Address1"
          Case "txt_E_Add2" : FormField.OldValue = .Address2 : .Address2 = FormField.NewValue : FormField.FieldName = "Address2"
          Case "txt_E_City" : FormField.OldValue = .City : .City = FormField.NewValue : FormField.FieldName = "City"
          Case "txt_E_State" : FormField.OldValue = .State : .State = FormField.NewValue : FormField.FieldName = "State"
          Case "txt_E_Zip" : FormField.OldValue = .Zip : .Zip = FormField.NewValue : FormField.FieldName = "Zip"
          Case "txt_E_EContact" : FormField.OldValue = .EContact : .EContact = FormField.NewValue : FormField.FieldName = "EContact"
          Case "txt_E_Password" : FormField.OldValue = .Password : .Password = FormField.NewValue : FormField.FieldName = "Password"
        End Select
      End With
      Dim OkToWrite As Boolean = (FormField.OldValue <> FormField.NewValue)
      If OkToWrite Then
        'Field_Status("Saving " & FormField.FieldName)
        If CC.UpdateStaffField(CC.StaffList(index), FormField.FieldName, FormField.NewValue) Then

        End If
      End If
    End If
  End Sub
  Private Sub cmd_NewStaff_Click(sender As Object, e As EventArgs) Handles cmd_NewStaff.Click
    Dim Result As MsgBoxResult = MsgBox("This will create a new user, Are you sure?", MsgBoxStyle.OkCancel, "Create a new user?")
    If Result = MsgBoxResult.Ok Then
      If CC.CreateStaff("New", "User") Then
        Dim NewID As Integer = CC.GetStaffID("New", "User")
        DrawEmployeeInfo(NewID)
      Else
        MsgBox("Error Creating User", MsgBoxStyle.Critical, "Error")
      End If
    End If
  End Sub



  Private Sub UpdateStaffList(index As Integer)
    With CC.StaffList(index)
      .OpName = .FirstName & " " & .LastName
      FillStaff(lst_Employees, CC.StaffList, .ID, False)
    End With
  End Sub
  Sub ClearControls(Parent As Control, NamePart As String)
    For Each ctrl As Control In Parent.Controls
      If ctrl.HasChildren Then ClearControls(ctrl, NamePart)
      If InStr(ctrl.Name, NamePart) > 0 Then
        If (ctrl.GetType() Is GetType(TextBox)) Then
          Dim Box As TextBox = CType(ctrl, TextBox) : Box.Text = "" : ctrl.BackColor = Color.White
        ElseIf (ctrl.GetType() Is GetType(ComboBox)) Then
          Dim Box As ComboBox = CType(ctrl, ComboBox) : Box.SelectedIndex = default_Int : ctrl.BackColor = Color.White
        ElseIf (ctrl.GetType() Is GetType(CheckBox)) Then
          Dim Box As CheckBox = CType(ctrl, CheckBox) : Box.Checked = False : ctrl.BackColor = Color.White
        ElseIf (ctrl.GetType() Is GetType(ListBox)) Then
          Dim Box As ListBox = CType(ctrl, ListBox) : Box.DataSource = Nothing : Box.Items.Clear() : ctrl.BackColor = Color.White
        End If
      End If
    Next
  End Sub
  Private Sub DrawEmployeeInfo(Optional SelectedStaffID As Integer = default_Int)
    Dim TempEvents As Boolean = ControlsActive : ControlsActive = False
    CC.initStaff(False)
    CC.initRights()
    CC.initSite()
    FillStaff(lst_Employees, CC.StaffList, SelectedStaffID, False)
    Dim index As Integer = CC.GetStafflistIndex(SelectedStaffID)
    DrawEditEmployee(index)
    ControlsActive = TempEvents
  End Sub
  Private Sub DrawEditEmployee(EmployeeIndex As Integer)
    Dim TempEvents As Boolean = ControlsActive : ControlsActive = False
    Dim Enabled As Boolean = Not IsNothing(lst_Employees.SelectedItem)




    'ClearControls(Tab_Payroll, "_E_")



    grp_Employee.Enabled = Enabled
    grp_Emergency.Enabled = Enabled
    grp_E_Settings.Enabled = Enabled

    If Enabled Then
      If EmployeeIndex > default_Int Then
        With CC.StaffList(EmployeeIndex)
          txt_E_First.Text = .FirstName
          txt_E_Last.Text = .LastName
          txt_E_SS.Text = .ss
          'txt_E_Phone.Text = .Phone
          txt_E_Add1.Text = .Address1
          txt_E_Add2.Text = .Address2
          txt_E_City.Text = .City
          txt_E_State.Text = .State
          txt_E_Zip.Text = .Zip
          txt_E_Econtact.Text = .EContact
          'txt_E_Phone.Text = .EContactPhone
          txt_E_Password.Text = .Password
          Check_E_Enabled.Checked = .Active
          Dim OutStr As String = "No" : If .Active Then OutStr = "Yes"
          Check_E_Enabled.Text = OutStr

          FillRights(cbo_E_Access, CC.RightsList, CInt(.AccessLevel))
          'FillSites(cbo_E_Site, CC.SiteList, .SiteID)
          FillAccessLevel(lst_E_Rights, CC.AccessLevel, CInt(.AccessLevel))
        End With
      End If
    End If
    ControlsActive = TempEvents
  End Sub

  Private Sub Frm_Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    Dim regKey As New RegEdit(AppName)
    regKey.GetSavedFormLocation(Me)
    regKey.Close()

    ControlsActive = False
    FillStaff(lst_Employees, CC.StaffList, default_Int, False)
    DrawEditEmployee(default_Int)
    Me.Show()
    ControlsActive = True
  End Sub
  Private Sub Frm_SignIn_Move(sender As Object, e As EventArgs) Handles MyBase.Move, MyBase.Resize
    If ControlsActive Then
      Dim regKey As New RegEdit(AppName)
      regKey.SetSavedFormLocation(Me)
      regKey.Close()
    End If
  End Sub

  Private Sub cbo_E_Access_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_E_Access.SelectedIndexChanged
    Dim Box As ComboBox = CType(sender, ComboBox)
    If ControlsActive Then
      Dim StaffID As Integer = InputVar(CType(lst_Employees.SelectedItem, ValueDescriptionPair).Value, default_Int)
      Dim index As Integer = CC.GetStafflistIndex(StaffID)
      If index > default_Int Then
        With CC.StaffList(index)
          If Not IsNothing(cbo_E_Access.SelectedItem) Then
            Dim Pair As ValueDescriptionPair = CType(cbo_E_Access.SelectedItem, ValueDescriptionPair)
            If CC.UpdateStaffField(CC.StaffList(index), Box.Tag, CInt(Pair.Value)) Then
              .AccessLevel = Pair.Value
              .AccessLevelName = Pair.Description
              Box.BackColor = Color.White
              FillAccessLevel(lst_E_Rights, CC.AccessLevel, CInt(.AccessLevel))
            Else
              Box.BackColor = Color.Red
            End If

          End If
        End With
      End If
    End If
  End Sub


End Class