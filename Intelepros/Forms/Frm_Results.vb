Imports System.Windows.Forms
Imports UniBase
Public Class Frm_Results

  Private Sub Frm_Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    mnu_Export.Visible = CC.CurStaff.Rights.PublishBookings
    'Me.Top = 100
    'Me.Left = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 10
    cmd_CollapseResults.Tag = False
    Dim regKey As New RegEdit(AppName)
    regKey.GetSavedFormLocation(Me)
    regKey.Close()
  End Sub
  Private Sub Frm_SignIn_Move(sender As Object, e As EventArgs) Handles MyBase.Move, MyBase.Resize
    Dim regKey As New RegEdit(AppName)
    regKey.SetSavedFormLocation(Me)
    regKey.Close()
  End Sub
  Structure ClickedItem
    Dim Index As Integer
    Dim Col As Integer
    Dim Row As Integer
    Dim X As Integer
    Dim Y As Integer
    Dim Button As MouseButtons
    Dim DoubleClicked As Boolean
    Dim Painting As Boolean
  End Structure
  Private UserClicked As ClickedItem

  Private Sub ResultsCellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Results.CellContentClick
  End Sub
  Sub UpdateUserClicked(e As DataGridViewCellMouseEventArgs)
    With UserClicked
      .Row = e.RowIndex
      .Col = e.ColumnIndex
      .Button = e.Button
      .X = e.Location.X
      .Y = e.Location.Y
      log(.Row)
      If .Row > default_Int Then

      End If
    End With
  End Sub
  Private Sub ResultsCellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Grid_Results.CellMouseDown
    UpdateUserClicked(e)
  End Sub
  Private Sub ResultsCellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Grid_Results.CellMouseUp
    UpdateUserClicked(e)
  End Sub

  Private Sub ResultsMouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Grid_Results.MouseUp

    If Not IsNothing(Grid_Results.CurrentRow) Then
      Grid_Results.Tag = Grid_Results.CurrentRow.Index
      log("Grid_Results:" & Grid_Results.Tag)
      Dim Info As ValueDescriptionPair = CType(Grid_Results.CurrentRow.Tag, ValueDescriptionPair)
      Dim ContactID As Integer = InputVar(Info.Value, default_Int)
      Dim BookingID As Integer = InputVar(Info.Description, default_Int)
      If UserClicked.Row > default_Int Then
        OpenRecord(ContactID, BookingID)
      End If

      'Dim info As String = InputVar(Grid_Results.CurrentRow.Tag, "")
      'If info.Length > 0 Then
      ' With CC.SearchResult(Index)
      'FormMain.logText("Telephone:" & Telephone)
      'FormMain.takeFocus()

      'OpenRecord(info)



      'FormMain.ActionClick(Frm_Main.EnumActionID.Record)
      'End With
      'Else
      'FormMain.logText("NONE")
      'End If
    End If
  End Sub

  Private Sub mnu_Export_Click(sender As Object, e As EventArgs) Handles mnu_Export.Click
    'ExportSearch(CC.SearchResult)
  End Sub

  Private Sub cmd_CollapseResults_Click(sender As Object, e As EventArgs) Handles cmd_CollapseResults.Click
    'cmd_CollapseResults.Image = 
    cmd_CollapseResults.Tag = Not (InputVar(cmd_CollapseResults.Tag, False))
    If cmd_CollapseResults.Tag = False Then
      Me.Width = 426
      Me.Left = Me.Left - 306
    Else
      Me.Width = 120
      Me.Left = Me.Left + 306
    End If


  End Sub

  Private Sub cmd_Unique_Click(sender As Object, e As EventArgs) Handles cmd_Unique.Click
    cmd_Unique.Tag = Not (InputVar(cmd_Unique.Tag, False))

    FillSearch(Grid_Results, CC.SearchResult, cmd_Unique.Tag)
    If cmd_Unique.Tag Then
      cmd_Unique.Text = "All Contacts"
    Else
      cmd_Unique.Text = "Unique Contacts"
    End If
  End Sub

  Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

  End Sub
End Class