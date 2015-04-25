Imports System.Windows.Forms
Imports UniBase
Public Class Frm_Results
  Dim ColumnVis As ViewColumns
  Private Sub Frm_Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim TempControlsActive = ControlsActive : ControlsActive = False
    mnu_Export.Visible = CC.CurStaff.Rights.PublishBookings
    Me.Top = 0
    Me.Left = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 10
    Me.Height = Screen.PrimaryScreen.WorkingArea.Height
    MainLayoutPanel.Dock = DockStyle.Fill
    cmd_CollapseResults.Tag = False
    Dim regKey As New RegEdit(AppName)
    regKey.GetSavedFormLocation(Me)
    regKey.Close()
    ColumnVis = New ViewColumns
    With ColumnVis
      mnu_ContactName.Checked = True : .ContactName = True
      mnu_Location.Checked = True : .Location = True
      mnu_Status.Checked = True : .Status = True
      mnu_Appt.Checked = True : .Appt = True
      mnu_Booked.Checked = True : .Booked = True
    End With
    ControlsActive = TempControlsActive
  End Sub
  Private Sub Frm_SignIn_Move(sender As Object, e As EventArgs) Handles MyBase.Move, MyBase.Resize
    If ControlsActive Then
      Dim regKey As New RegEdit(AppName)
      regKey.SetSavedFormLocation(Me)
      regKey.Close()
    End If
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
  'Private UserClicked As ClickedItem
  Private Sub mnu_ContactName_Click(sender As Object, e As EventArgs) Handles mnu_ContactName.Click,
                                                                            mnu_Booker.Click, mnu_Booked.Click,
                                                                            mnu_Confirmer.Click, mnu_Conf.Click,
                                                                            mnu_Location.Click, mnu_Status.Click, mnu_Appt.Click
    If ControlsActive Then
      Dim mnu As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
      If Not IsNothing(mnu) Then
        mnu.Checked = Not mnu.Checked
        Select Case mnu.Name
          Case "mnu_ContactName" : ColumnVis.ContactName = mnu.Checked
          Case "mnu_Booker" : ColumnVis.Booker = mnu.Checked
          Case "mnu_Booked" : ColumnVis.Booked = mnu.Checked
          Case "mnu_Confirmer" : ColumnVis.Confirmer = mnu.Checked
          Case "mnu_Conf" : ColumnVis.Conf = mnu.Checked
          Case "mnu_Location" : ColumnVis.Location = mnu.Checked
          Case "mnu_Status" : ColumnVis.Status = mnu.Checked
          Case "mnu_Appt" : ColumnVis.Appt = mnu.Checked
        End Select
      End If
      FillSearch(Grid_Results, CC.SearchResult, ColumnVis)
    End If
  End Sub

  Sub UpdateDisplay()
    'FillSearch(Grid_Results, CC.SearchResult)
    fillSearchStat(lst_Counts, CC.SearchResult)
    FillSearch(Grid_Results, CC.SearchResult, ColumnVis)
    'FillViewResultsColums(mnu_View, ColumnVis)
  End Sub
  Private Sub ResultsCellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Results.CellContentClick
  End Sub
  'Sub UpdateUserClicked(e As DataGridViewCellMouseEventArgs)
  '  With UserClicked
  '    .Row = e.RowIndex
  '    .Col = e.ColumnIndex
  '    .Button = e.Button
  '    .X = e.Location.X
  '    .Y = e.Location.Y
  '    'log(.Row)
  '    If .Row > default_Int Then

  '    End If
  '  End With
  'End Sub
  Sub DisplaySearch()
    FormProgress.ShowProgress(1, "Search Records", 3)
    CC.SearchRecords()
    FormProgress.ShowProgress(2)
    ResultWindow.Show()
    UpdateDisplay()
    If Not IsNothing(CC.SearchResult) Then
      lbl_RecordsReturned.Text = CC.SearchResult.Length & " Records returned."
    Else
      lbl_RecordsReturned.Text = "No Records returned."
    End If
    FormProgress.Hide()
  End Sub

  Private Sub Grid_Results_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Grid_Results.CellMouseClick
  End Sub
  Private Sub ResultsCellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Grid_Results.CellMouseDown
  End Sub
  Private Sub ResultsCellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Grid_Results.CellMouseUp
    'UpdateUserClicked(e)
    'UpdateUserClicked(e)
    If Not IsNothing(Grid_Results.CurrentRow) Then
      Grid_Results.Tag = Grid_Results.CurrentRow.Index
      'log("Grid_Results:" & Grid_Results.Tag)

      Dim ContactID As Integer = default_Int
      Dim BookingID As Integer = default_Int
      If Grid_Results.Columns.Contains("Phone") Then
        Dim Contact As Result = CType(Grid_Results.CurrentRow.Cells("Phone").Value, Result)
        ContactID = Contact.ContactID
        BookingID = Contact.BookingID
      End If

      log("Clicked BookingID:" & BookingID & " ContactID:" & ContactID)


      'vvvvvvvvvvvvv

      'Dim ContactID As Integer = InputVar(Info.Value, default_Int)
      'Dim BookingID As Integer = InputVar(Info.Description, default_Int)
      If ContactID > default_Int And e.RowIndex > default_Int Then
        OpenRecord(ContactID, BookingID)
      End If

      '^^^^^^^^^^^^^^^^





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

  Private Sub ResultsMouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Grid_Results.MouseUp


  End Sub



  Private Sub cmd_CollapseResults_Click(sender As Object, e As EventArgs)



  End Sub




  Private Sub NameToolStripMenuItem_Click(sender As Object, e As EventArgs)
    Dim Item As System.Windows.Forms.ToolStripMenuItem
    Item = New System.Windows.Forms.ToolStripMenuItem()
    Item.Name = "NameToolStripMenuItem"
    Item.Size = New System.Drawing.Size(152, 22)
    Item.Text = "Name"

    Me.mnu_View.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Item})
  End Sub


  Private Sub cmd_CollapseResults_Click_1(sender As Object, e As EventArgs) Handles cmd_CollapseResults.Click
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


  Private Sub mnu_Export_Click(sender As Object, e As EventArgs)
    ExportSearch(CC.SearchResult)
  End Sub

  Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
    DisplaySearch()
  End Sub

  Private Sub cmd_NewSearch_Click(sender As Object, e As EventArgs) Handles cmd_NewSearch.Click
    OpenSearch()
  End Sub


End Class