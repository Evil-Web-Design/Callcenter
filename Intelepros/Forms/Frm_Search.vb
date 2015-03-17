Public Class Frm_Search

  Private Sub Frm_Search_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    'e.Cancel = True
    'Me.Hide()
  End Sub

  Private Sub Frm_Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim regKey As New RegEdit(AppName)
    'FillLocations(lst_SearchLocation, CC.LocationList)
    'FillStatus(lst_SearchStatus, CC.Status)
    'FillStaff(cbo_EmpSearch, CC.StaffList)
    'FillStaff(cbo_EmpAction, CC.StaffList)
    DrawSearch()
    cbo_EmpAction.SelectedIndex = 0
    cbo_DateMethod.SelectedIndex = 0
    regKey.GetSavedFormLocation(Me)
    regKey.Close()

  End Sub
  Private Sub Frm_SignIn_Move(sender As Object, e As EventArgs) Handles MyBase.Move, MyBase.Resize
    Dim regKey As New RegEdit(AppName)
    regKey.SetSavedFormLocation(Me)
    regKey.Close()
  End Sub
  Private Sub cmd_Search_Click(sender As Object, e As EventArgs) Handles cmd_Search.Click
    'ActionClick(0)
    RunSearch()
  End Sub

  Sub RunSearch()
    Dim DoSearch As Boolean = False
    With CC.SearchCry
      .StatusID = GetSelected(lst_SearchStatus)
      .LocationID = GetSelected(lst_SearchLocation)
      '.DeptID = GetSelected(lst_SearchDept)

      .DateStart = DateSearchStart.Value.ToString("MM/dd/yyyy")
      .DateEnd = DateSearchEnd.Value.ToString("MM/dd/yyyy")

      .SearchString = txt_Search.Text
      If Not IsNothing(cbo_DateMethod.SelectedItem) Then
        Dim Value As Integer = CInt(CType(cbo_DateMethod.SelectedItem, ValueDescriptionPair).Value)
        .DateAction = CType(Value, enum_DateAction)
      End If
      If Not IsNothing(cbo_EmpAction.SelectedItem) Then
        Dim Value As Integer = CInt(CType(cbo_EmpAction.SelectedItem, ValueDescriptionPair).Value)
        .EmpAction = CType(Value, enum_EmpAction)
      End If
      If Not IsNothing(cbo_EmpSearch.SelectedItem) Then
        .EmployeeID = CInt(CType(cbo_EmpSearch.SelectedItem, ValueDescriptionPair).Value)
      End If

      DoSearch = .UseDates Or .UseEmployee Or .UseString
    End With
    If DoSearch Then
      OpenResults()
    Else
      MsgBox("Select at least one Search option to Search.", MsgBoxStyle.Exclamation, "Not Enough Options")
    End If
  End Sub

#Region ""
  Function GetSelected(ItemList As ListBox) As Integer()
    Dim Items As Integer(), Index As Integer : Erase Items
    log("GetSelected from " & ItemList.Name)
    For Each item As ValueDescriptionPair In ItemList.SelectedItems
      If IsNothing(Items) Then Index = 0 Else Index = Items.Length
      ReDim Preserve Items(Index)
      Items(Index) = item.Value
      log(item.Description & " = " & item.Value)
    Next
    Return Items
  End Function

  Sub DrawSearch(Optional Initfields As Boolean = True)
    If Initfields Then
      cbo_DateMethod.Items.Clear()
      cbo_DateMethod.Items.AddRange(New ValueDescriptionPair() {New ValueDescriptionPair(1, "Booking Date"),
                                                                New ValueDescriptionPair(1, "Appointment Date")})
      cbo_DateMethod.SelectedIndex = 0
      cbo_EmpAction.Items.AddRange(New ValueDescriptionPair() {New ValueDescriptionPair(1, "Booked By"),
                                                               New ValueDescriptionPair(2, "Confirmed By")})
      cbo_EmpAction.SelectedIndex = 0
      FillStatus(lst_SearchStatus, CC.Status)
      FillLocations(lst_SearchLocation, CC.LocationList)
      'FillDept(lst_SearchDept, CC.Dept)
      FillStaff(cbo_EmpSearch, CC.StaffList, default_Int, "Select Employee")
    End If
    With CC.SearchCry

      .UseDates = CheckByDate.Checked
      DateSearchStart.Enabled = .UseDates 'and cbo_DateMethod.sel
      DateSearchEnd.Enabled = .UseDates
      cbo_DateMethod.Enabled = .UseDates

      .UseString = CheckBySearch.Checked
      txt_Search.Enabled = .UseString

      .UseEmployee = CheckByEmp.Checked
      cbo_EmpAction.Enabled = .UseEmployee
      cbo_EmpSearch.Enabled = .UseEmployee

      log("UseDates:" & .UseDates & " UseString:" & .UseString & " UseEmployee:" & .UseEmployee)
      If .UseDates Then tbl_Date.BackColor = Color.FromArgb(200, 255, 200) Else tbl_Date.BackColor = System.Drawing.SystemColors.ButtonFace
      If .UseString Then tbl_String.BackColor = Color.FromArgb(200, 255, 200) Else tbl_String.BackColor = System.Drawing.SystemColors.ButtonFace
      If .UseEmployee Then tbl_Staff.BackColor = Color.FromArgb(200, 255, 200) Else tbl_Staff.BackColor = System.Drawing.SystemColors.ButtonFace
        Application.DoEvents()
    End With
  End Sub


#End Region
#Region "Events"
  Private Sub CheckByDate_CheckedChanged(sender As Object, e As EventArgs) Handles CheckByDate.CheckedChanged
    DrawSearch(False)
  End Sub
  Private Sub CheckBySearch_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBySearch.CheckedChanged
    DrawSearch(False)
  End Sub
  Private Sub CheckByEmp_CheckedChanged(sender As Object, e As EventArgs) Handles CheckByEmp.CheckedChanged
    DrawSearch(False)
  End Sub
#End Region
  ' Public Keyboard As New Microsoft.VisualBasic.Devices.Keyboard
  Private Sub txt_Claim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Search.KeyPress
    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
      RunSearch()
    End If
  End Sub
  Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
  End Sub

  Private Sub lst_SearchStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_SearchStatus.SelectedIndexChanged

  End Sub
End Class