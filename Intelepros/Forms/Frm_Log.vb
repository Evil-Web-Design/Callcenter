Imports UniBase
Public Class Frm_Log

  Private Sub Frm_Log_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    e.Cancel = False
    Me.Hide()

  End Sub

  Private Sub Frm_Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim regKey As New RegEdit(AppName)
    regKey.GetSavedFormLocation(Me)

    Dim StartLogOpen As Boolean = InputVar(regKey.GetAppValue("StartLogOpen", False), False)

    mnu_ToggleAutoLaunch.Checked = StartLogOpen
    regKey.Close()
  End Sub
  Private Sub Frm_SignIn_Move(sender As Object, e As EventArgs) Handles MyBase.Move, MyBase.Resize
    Dim regKey As New RegEdit(AppName)
    regKey.SetSavedFormLocation(Me)
    regKey.Close()
  End Sub
  Public Sub Logit(StringEntry As String)
    Dim index As Integer = List.Items.Add(StringEntry)
    List.SelectedIndex = index
  End Sub

  Private Sub mnu_ToggleAutoLaunch_Click(sender As Object, e As EventArgs) Handles mnu_ToggleAutoLaunch.Click
    mnu_ToggleAutoLaunch.Checked = Not mnu_ToggleAutoLaunch.Checked
    Dim regKey As New RegEdit(AppName)
    regKey.SetAppValue("StartLogOpen", mnu_ToggleAutoLaunch.Checked)
  End Sub
End Class