Imports System.Windows.Forms
Imports System.Collections
Imports Microsoft.Win32


Public Class Frm_SignIn
  Private StaffID As Integer

  Private Sub cbo_Staff_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles cbo_Staff.KeyPress
    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
      Txt_Password.Focus()
    End If
  End Sub
  Private Sub cbo_Staff_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_Staff.SelectedIndexChanged
    StaffID = CInt(CType(cbo_Staff.SelectedItem, ValueDescriptionPair).Value)
    Txt_Password.Clear()
    'MsgBox("Value Selected = " & SelectedIndex, MsgBoxStyle.Information)
  End Sub
  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Call login()
  End Sub
  Private Sub Txt_Password_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Txt_Password.KeyPress
    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
      Call login()
    End If
  End Sub

  Private Sub login()
    If StaffID > default_Int Then
      Dim SelectedIndex As Integer = CC.GetStafflistIndex(StaffID)
      If SelectedIndex > default_Int Then
        If CC.StaffList(SelectedIndex).Password = Txt_Password.Text Or Debugmode Then
          Dim regKey As New RegEdit(AppName)
          'regKey = Registry.CurrentUser.OpenSubKey("Software\Payroll", True)
          regKey.SetAppValue("LastUser", CC.StaffList(SelectedIndex).OpName)
          regKey.Close()
          loggedIn = True
          CC.CurStaff = CC.StaffList(SelectedIndex)
          Me.Dispose()
        Else
          Txt_Password.Clear()
          Txt_Password.Focus()
          lbl_MessageMask.Text = "Incorrect password!"
          UpdateShado(lbl_MessageMask)
          'MsgBox("Incorrect Password!", MsgBoxStyle.Critical, "Password!")
        End If
      End If
    Else
      cbo_Staff.Focus()
      lbl_MessageMask.Text = "Select Your Name First!"
      UpdateShado(lbl_MessageMask)
      'MsgBox("Select Your Name First!", MsgBoxStyle.Critical, "No Name Selected!")
    End If

  End Sub

 

  Private Sub Frm_SignIn_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

  End Sub
  Private Sub Frm_SignIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim TempControlsActive = ControlsActive : ControlsActive = False
    Dim regKey As New RegEdit(AppName)
    Dim LastUser As String = ""
    LastUser = regKey.GetAppValue("LastUser", "").ToString


    FillStaff(cbo_Staff, CC.StaffList, LastUser)
    Me.Text = BrandName & " - v" & GetVersion()
    'Dim VDP_Array As New ArrayList, selectedIndex As Integer = 0, CurrentItem As Integer = 1
    'VDP_Array.Add(New ValueDescriptionPair(-1, "Select Your Name"))
    'For loopvar As Integer = 0 To StaffList.Length - 1
    '  With StaffList(loopvar)
    '    If .Active = True And (.AccessLevel = enum_AccessLevel.Manager Or
    '                           .AccessLevel = enum_AccessLevel.ADV_Manager Or
    '                           .AccessLevel = enum_AccessLevel.Admin Or
    '                           .AccessLevel = enum_AccessLevel.Accounting) Then
    '      VDP_Array.Add(New ValueDescriptionPair(loopvar, .OpName))
    '      If .OpName = LastUser Then selectedIndex = CurrentItem
    '      CurrentItem += 1
    '    End If
    '  End With

    'Next
    'With cbo_Staff
    '  .DisplayMember = "Description"
    '  .ValueMember = "Value"lst_E_Rights
    '  .DataSource = VDP_Array
    '  .SelectedIndex = selectedIndex
    'End With
    Me.Show()

    'regKey.GetSavedFormLocation(Me)
    regKey.Close()
    'lbl_MessageMask.Location = 
    LabelDropShado(lbl_MessageMask)
    'SetParent(Label1, Me, Label1.Location)
    'SetParent(Label2, Me, Label2.Location)
    If StaffID > 0 Then
      lbl_MessageMask.Text = "Enter your password"
      UpdateShado(lbl_MessageMask)
      Txt_Password.Focus()
    Else
      lbl_MessageMask.Text = "Select your name"
      UpdateShado(lbl_MessageMask)
      cbo_Staff.Focus()
    End If
    ControlsActive = TempControlsActive
  End Sub


  Private Sub Frm_SignIn_Move(sender As Object, e As EventArgs) Handles MyBase.Move, MyBase.Resize
    If ControlsActive Then
      Dim regKey As New RegEdit(AppName)
      regKey.SetSavedFormLocation(Me)
      regKey.Close()
    End If
  End Sub
End Class