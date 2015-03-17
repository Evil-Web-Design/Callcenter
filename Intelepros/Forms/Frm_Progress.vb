Public Class Frm_Progress

  Private Sub Frm_Progress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.Show()
    Application.DoEvents()
    ProgressBar.Hide()
    LabelDropShado(lbl_MessageMask)
  End Sub
  Public Sub ShowProgress(value As Integer, Optional Caption As String = "", Optional Max As Integer = default_Int)
    Me.Show()
    ProgressBar.Show()
    If Max > default_Int Then ProgressBar.Maximum = Max
    If value > 0 And value <= ProgressBar.Maximum Then ProgressBar.Value = value
    DrawCaption(Caption)
  End Sub
  Public Sub ShowMessage(Caption As String)
    Me.Show()
    ProgressBar.Hide()
    DrawCaption(Caption)
  End Sub
  Sub DrawCaption(Caption As String)
    If Caption.Length > 0 Then
      lbl_MessageMask.Text = Caption
      UpdateShado(lbl_MessageMask)
    End If
    Application.DoEvents()
  End Sub
End Class