Imports UniBase
Public Class Frm_Log

  Private Sub Frm_Log_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    e.Cancel = False
    Me.Hide()

  End Sub

  Private Sub Frm_Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim TempControlsActive = ControlsActive : ControlsActive = False
    Dim regKey As New RegEdit(AppName)
    regKey.GetSavedFormLocation(Me)

    Dim StartLogOpen As Boolean = InputVar(regKey.GetAppValue("StartLogOpen", False), False)

    mnu_ToggleAutoLaunch.Checked = StartLogOpen
    regKey.Close()
    ControlsActive = TempControlsActive
  End Sub
  Private Sub Frm_SignIn_Move(sender As Object, e As EventArgs) Handles MyBase.Move, MyBase.Resize
    If ControlsActive Then
      Dim regKey As New RegEdit(AppName)
      regKey.SetSavedFormLocation(Me)
      regKey.Close()
    End If
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
  Dim selectedString As String = ""
  Public WithEvents TextBox As New Frm_TextEdit
  Private Sub List_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles List.MouseDoubleClick
    If ControlsActive Then
      TextBox = New Frm_TextEdit
      TextBox.txt.Text = selectedString
      TextBox.Show()
    End If
  End Sub

  Private Sub List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List.SelectedIndexChanged
    If ControlsActive Then
      selectedString = DirectCast(sender, System.Windows.Forms.ListBox).Text
    End If
  End Sub
End Class