Imports UniBase
Imports UniBase.Class_CallCenter

Public Class Frm_History

  Private Sub Frm_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim regKey As New RegEdit(AppName)
    regKey.GetSavedFormLocation(Me)
    regKey.Close()
  End Sub
  Private Sub Frm_SignIn_Move(sender As Object, e As EventArgs) Handles MyBase.Move, MyBase.Resize
    If ControlsActive Then
      Dim regKey As New RegEdit(AppName)
      regKey.SetSavedFormLocation(Me)
      regKey.Close()
    End If
  End Sub
  Public Sub ShowHistory(Booking As Type_ContactBooking)
    History.Show()
    FillBookingHistory(Grid_Results, Booking)
  End Sub
  Private Sub Grid_Bookings_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Results.CellContentClick
    'Beep()
  End Sub
  Private Sub Grid_Bookings_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Results.CellClick
    'Beep()
  End Sub
  Private Sub gridd_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Grid_Results.MouseUp
    If Not IsNothing(Grid_Results.Tag) Then
      Grid_Results.Tag = Grid_Results.CurrentRow.Index
      Dim Telephone As String = InputVar(Grid_Results.CurrentRow.Tag, "")
      If Telephone.Length > 0 Then
        ' With CC.SearchResult(Index)
        'FormMain.logText("Telephone:" & Telephone)
        'FormMain.takeFocus()





        'FormMain.ActionClick(Frm_Main.EnumActionID.Record)
        'End With
      Else
        'FormMain.logText("NONE")
      End If
    End If
  End Sub

End Class