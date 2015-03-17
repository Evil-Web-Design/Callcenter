Imports UniBase
Public Class Frm_NewRecord
  Public Keyboard As New Microsoft.VisualBasic.Devices.Keyboard

  Private Sub Frm_NewRecord_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

  End Sub

  Private Sub Frm_Record_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    If Not OkToClose() Then
      e.Cancel = True
    End If
  End Sub

  Private Sub Frm_NewRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ctl_Phone.Font = New Font("MS Sans Serif", 14, FontStyle.Bold, GraphicsUnit.Point, Nothing)
    'Me.TopMost = CC.CurStaff.Rights.MultiRecordUI
    Me.Show()
    LabelDropShado(bl_Claim)
    LabelDropShado(lbl_Phone)
    txt_Claim.Focus()
  End Sub
  Private Sub cmd_Search_Click(sender As Object, e As EventArgs) Handles cmd_Search.Click
    openSearchRecord()
  End Sub
  Private Sub ctl_Phone_TextChanged(sender As Object, e As EventArgs) Handles ctl_Phone.TextChanged
  End Sub
  Private Sub txt_Claim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Claim.KeyPress, ctl_Phone.KeyPress
    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
      Keyboard.SendKeys("{tab}")
      'ctl_Phone.Focus()
    End If
  End Sub
  Private Sub ctl_Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ctl_Phone.KeyPress
    If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
      openSearchRecord()
    End If
  End Sub
  Private Sub openSearchRecord()
    Dim Claim As String = InputVar(txt_Claim.Text, "")
    Dim Phone As String = InputVar(ctl_Phone.Value, "")

    If Not ctl_Phone.IsValid Then
      lbl_Phone.Text = "Phone Must be 10 Digit!"
      UpdateShado(lbl_Phone)
      ctl_Phone.BackColor = Color.LightYellow
    Else
      If OpenRecord(Phone, Claim) Then
        Me.Dispose()
      End If
    End If
  End Sub


End Class