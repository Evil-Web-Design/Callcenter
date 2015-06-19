Public Class Frm_TextEdit

  Private Sub Frm_TextEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim TempControlsActive = ControlsActive : ControlsActive = False
    Dim regKey As New RegEdit(AppName)
    regKey.GetSavedFormLocation(Me, RegEdit.Enum_FormPos.Both)
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
End Class