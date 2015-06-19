Imports UniBase
Imports UniBase.Class_Main

Public Class Frm_Locations
  WithEvents popup As Popup
  WithEvents MasterDates As New ctl_DateTime
  Private LocationID As Integer = default_Int, StatusID As Integer = default_Int

  Private Sub Frm_Locations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim TempControlsActive = ControlsActive : ControlsActive = False
    FocusIt.Location = New Drawing.Point(-FocusIt.Size.Width, -FocusIt.Size.Height)
    tbl_LocationSettings.Dock = DockStyle.Fill
    tbl_PromoSettings.Dock = DockStyle.Fill
    tbl_ContentEdit.Dock = DockStyle.Fill
    tbl_StatusEdit.Dock = DockStyle.Fill
    tbl_Calendar.Dock = DockStyle.Fill

    'AvailStartDate.Value = Now
    'AvailEndDate.Value = Now.Add(New TimeSpan(30, 0, 0, 0))
    FillLocations(cbo_Location, CC.LocationList, default_Int, True, True)
    Me.Size = Me.MinimumSize

    Dim regKey As New RegEdit(AppName)
    regKey.GetSavedFormLocation(Me, RegEdit.Enum_FormPos.Location)
    regKey.Close()
    ControlsActive = TempControlsActive
    Drawpage(Pages.Location)
  End Sub
  Private Sub Frm_SignIn_Move(sender As Object, e As EventArgs) Handles MyBase.Move, MyBase.Resize
    If ControlsActive Then
      Dim regKey As New RegEdit(AppName)
      regKey.SetSavedFormLocation(Me)
      regKey.Close()
    End If
  End Sub
  Private Sub cmd_OpenDate_Click(sender As Object, e As EventArgs) Handles cmd_EditOpenDates.Click
    popup = New Popup(MasterDates, cmd_EditOpenDates)
    MasterDates.SelectedDate = Now
    With popup
      .HorizontalPlacement = Intelepros.Popup.ePlacement.Bottom
      .Show()
      MasterDates.Update()
    End With
  End Sub
  Private Sub MasterDates_AddDate(NewDate As Date) Handles MasterDates.AddDate
    If ControlsActive Then
      If Not NewDate = default_DateTime Then
        If CreateLocationDate(LocationID, NewDate, 10, 10) Then
          fillLocationDates(True)
        Else
          MasterDates.RemoveAvailDate(NewDate)
        End If
      Else
        MasterDates.RemoveAvailDate(NewDate)
      End If
      FocusIt.Select()
    End If
  End Sub
  Private Sub MasterDates_DeleteDate(RemoveDate As Date) Handles MasterDates.DeleteDate
    If ControlsActive Then
      If Not RemoveDate = default_DateTime Then
        If DeleteLocationDate(LocationID, RemoveDate) Then
          'CC.RemoveLocationShowTimeArray(LocationID, RemoveDate)
          fillLocationDates(True)
        Else
          MasterDates.AddAvailDate(RemoveDate)
        End If
      End If
      FocusIt.Select()
    End If
  End Sub

  Function CreateLocationDate(LocationID As Integer, Showtime As Date, Wave As Integer, RealWave As Integer) As Boolean
    Dim Success As Boolean, Sqlstr As String

    Sqlstr = "INSERT INTO dbo.tbl_Location_Calendar (LocationID, Showtime, Wave, RealWave) " & _
      "VALUES  (" & LocationID & ", CONVERT(DATETIME, '" & Showtime.ToString("yyyy-MM-dd hh:mm:00 tt") & "', 102), " & Wave & ", " & RealWave & ")"
    Success = CC.RunSQL(Sqlstr) '2015-01-01 22:10:00
    Return Success
  End Function
  Function DeleteLocationDate(LocationID As Integer, Showtime As Date) As Boolean
    Dim Success As Boolean, Sqlstr As String

    Sqlstr = "DELETE FROM dbo.tbl_Location_Calendar " & _
      "Where  (LocationID=" & LocationID & " " & _
      "and Showtime=CONVERT(DATETIME, '" & Showtime.ToString("yyyy-MM-dd hh:mm:00 tt") & "', 102) )"
    Success = CC.RunSQL(Sqlstr) '2015-01-01 22:10:00
    Return Success
  End Function

  Private Sub MasterDates_Cancel() Handles MasterDates.Close
    HidePopup()
  End Sub
  Sub HidePopup()
    If Not IsNothing(popup) Then
      popup.Hide()
    End If
  End Sub


  Sub fillLocationDates(Optional Refresh As Boolean = False)
    Dim TempControlsActive = ControlsActive : ControlsActive = False
    If Not IsNothing(popup) Then popup.Dispose()
    If LocationID > default_Int Then
      CC.initShowTimes(LocationID, Refresh)
      Dim Index As Integer = CC.GetLocationlistIndex(LocationID)
      'Cal
      'AvailStartDate.Enabled = True
      'AvailEndDate.Enabled = True
      cmd_EditOpenDates.Enabled = True
      FillDate(MasterDates, CC.LocationList(Index).ShowTimes)
      FillAvailDatesGrid(Grid_Results, CC.LocationList(Index).ShowTimes)
      MasterDates.DisplayMode = ctl_DateTime.Mode.Edit
      MasterDates.Update()
    Else
      'Cal
      'AvailStartDate.Enabled = False
      'AvailEndDate.Enabled = False
      cmd_EditOpenDates.Enabled = False
      FillDate(MasterDates, Nothing)
      Grid_Results.Rows.Clear()

    End If
    ControlsActive = TempControlsActive
  End Sub
  Sub fillLocation(Optional Refresh As Boolean = False)
    Dim TempControlsActive = ControlsActive : ControlsActive = False
    Dim LocEnabled As Boolean = (LocationID > default_Int)
    Dim EnabledStat As Boolean = False
    If StatusID = default_Int Then StatusID = 0
    CC.initStatus(Refresh)
    If LocationID > default_Int Then
      Dim Index As Integer = CC.GetLocationlistIndex(LocationID)


      FillContent(cbo_Confirm, CC.Content, CC.LocationList(Index).confirmContentID)


      CC.initStatus(LocationID, StatusID, Refresh)
      EnabledStat = Not IsNothing(CC.LocationList(Index).Status)
      'Stat
      cbo_NewStatus.Enabled = True
      FillStatus(cbo_NewStatus, CC.Status, StatusID, CC.LocationList(Index).Status, False, EnabledStat, False)
      If EnabledStat Then
        FillStatus(cbo_Status, CC.Status, StatusID, CC.LocationList(Index).Status, True, False, True)
        FillStatus(lst_StatusBranch, CC.Status, StatusID, CC.LocationList(Index).Status)
      Else
        FillStatus(cbo_Status, Nothing)
        lst_StatusBranch.DataSource = Nothing
        lst_StatusBranch.Items.Clear()
      End If
    Else
      'Stat
      cbo_Confirm.DataSource = Nothing
      cbo_Confirm.Items.Clear()
      cbo_Confirm.Enabled = False

      cbo_NewStatus.Enabled = False
    End If
    'StatBranch
    SelectedStatusID = default_Int
    cbo_Status.Enabled = EnabledStat
    lst_StatusBranch.Enabled = EnabledStat
    ck_AlwaysVis.Checked = False
    ck_AlwaysVis.Enabled = False
    cmd_DeleteLocStatus.Enabled = False


    Dim LocationVis As Boolean = (LocationID > 0)

    tbl_Calendar.Visible = LocationVis
    tbl_StatusEdit.Visible = Not LocationVis
    tbl_Location.Visible = LocationVis
    If LocationVis Then
      tbl_MainLoc.RowStyles(1).Height = 80
      fillLocationDates(Refresh)
    Else
      tbl_MainLoc.RowStyles(1).Height = 1
    End If
    'Gen
    txt_Location.Enabled = LocEnabled
    cbo_City.Enabled = LocEnabled
    ck_LocEnabled.Enabled = LocEnabled

    ControlsActive = TempControlsActive
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
    Dim Value As String
  End Structure
  Private UserClicked As ClickedItem
  Sub UpdateUserClicked(e As DataGridViewCell)
    If e.RowIndex > default_Int Then
      With UserClicked
        .Row = e.RowIndex
        .Col = e.ColumnIndex
        .Button = 0
        .X = 0
        .Y = 0
        .Value = Grid_Results.Rows(.Row).Cells(.Col).Value
        log("Col:" & .Col & " Row:" & .Row)
      End With
    End If

  End Sub
  Sub UpdateUserClicked(e As DataGridViewCellMouseEventArgs)
    If e.RowIndex > default_Int Then
      With UserClicked
        .Row = e.RowIndex
        .Col = e.ColumnIndex

        .Button = e.Button
        .X = e.Location.X
        .Y = e.Location.Y
        .Value = Grid_Results.Rows(.Row).Cells(.Col).Value
      End With
      log("Col:" & UserClicked.Col & " Row:" & UserClicked.Row)
    End If
  End Sub


  Private Sub Grid_Results_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Grid_Results.CellMouseClick
    log("CurrentCellAddress:" & Grid_Results.CurrentCellAddress.ToString)
    UpdateUserClicked(e)
    If Grid_Results IsNot Nothing Then
      Dim point1 As Point = Grid_Results.CurrentCellAddress
      If point1.X = e.ColumnIndex And _
          point1.Y = e.RowIndex And _
            e.Button = MouseButtons.Left Then
        'Not Grid_Results.EditMode = DataGridViewEditMode.EditProgrammatically 


        Select Case e.ColumnIndex
          Case 0
            popup = New Popup(MasterDates, Grid_Results)
            With popup
              .HorizontalPlacement = Intelepros.Popup.ePlacement.Left
              .Show()
              MasterDates.SelectedDate = CDate(UserClicked.Value)
            End With
          Case 1
            'Grid_Results.BeginEdit(True)
          Case 2
            'Grid_Results.BeginEdit(True)
        End Select


      End If
    End If
  End Sub
  Private Sub Grid_Results_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Results.CellContentClick
  End Sub
  Private Sub ResultsCellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Grid_Results.CellMouseDown
    'UpdateUserClicked(e)
    'log("A")
    'Application.DoEvents()
  End Sub
  Private Sub ResultsCellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Grid_Results.CellMouseUp
    'UpdateUserClicked(e)
    ''log("B")
    ''Application.DoEvents()






    'If Not IsNothing(Grid_Results.CurrentRow) Then
    '  Grid_Results.Tag = Grid_Results.CurrentRow.Index
    '  Dim Info As ValueDescriptionPair = CType(Grid_Results.CurrentRow.Tag, ValueDescriptionPair)
    '  Dim ContactID As Integer = InputVar(Info.Value, default_Int)
    '  'Dim BookingID As Integer = InputVar(Info.Description, "")
    '  If UserClicked.Row > default_Int Then
    '    ' Grid_Results.EditMode = DataGridViewEditMode.EditProgrammatically
    '    Select Case UserClicked.Col
    '      Case 0

    '      Case 1
    '        'Grid_Results.CommitEdit(DataGridViewDataErrorContexts.Commit)
    '        'Grid_Results.EndEdit(DataGridViewDataErrorContexts.Commit)
    '        Grid_Results.CancelEdit()
    '        If Not Grid_Results.IsCurrentCellInEditMode Then
    '          Grid_Results.BeginEdit(True)
    '        End If
    '      Case 2
    '        Grid_Results.CancelEdit()
    '        If Not Grid_Results.IsCurrentCellInEditMode Then
    '          Grid_Results.BeginEdit(True)
    '        End If
    '    End Select

    '  End If

    'End If

  End Sub
  Private Sub ResultsMouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Grid_Results.MouseUp

    'log("C")



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

  End Sub

  Private Sub Grid_Results_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Results.CellEndEdit
    log("CellEndEdit")
  End Sub
  Private Sub DataGridView1_EditingControlShowing(sender As Object, _
                  e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Grid_Results.EditingControlShowing
    UpdateUserClicked(Me.Grid_Results.CurrentCell)
    Select Case UserClicked.Col
      Case 1, 2
        Dim Combo As ComboBox
        Combo = CType(e.Control, ComboBox)
        RemoveHandler Combo.Enter, New EventHandler(AddressOf ctl_Enter)
        AddHandler Combo.Enter, New EventHandler(AddressOf ctl_Enter)
        RemoveHandler Combo.SelectedIndexChanged, New EventHandler(AddressOf Combo_SelectedIndexChange)
        AddHandler Combo.SelectedIndexChanged, New EventHandler(AddressOf Combo_SelectedIndexChange)
    End Select
    'End If
  End Sub
  Private Sub ctl_Enter(sender As Object, e As EventArgs)
    TryCast(sender, ComboBox).DroppedDown = True
  End Sub

  Private Sub Combo_SelectedIndexChange(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Dim SelectedItem As String = DirectCast(sender, ComboBox).SelectedItem
    With UserClicked
      If SelectedItem <> -1 Then
        'Grid_Results.Rows(.Row).Cells(.Col).Value = InputVar(SelectedItem, 0)

        'Grid_Results.Item(.Col, .Row).Value = InputVar(SelectedItem, 0)
        'Grid_Results.CommitEdit(DataGridViewDataErrorContexts.Commit)
        'Grid_Results.EndEdit(DataGridViewDataErrorContexts.Commit)

        'If Not Grid_Results.CommitEdit(DataGridViewDataErrorContexts.Commit) Then
        'Beep()
        'End If
        FocusIt.Select()
        Application.DoEvents()
        'MessageBox.Show(SelectedItem)
        'Else
        ' Grid_Results.Rows(.Row).Cells(.Col).Value = 0
      End If
    End With
  End Sub


  Public Function ComboBoxColumn(HeaderText As String, ComboName As String, _
      Optional Min As Integer = 0, Optional Max As Integer = 100, Optional Interval As Integer = 1) As DataGridViewComboBoxColumn
    Dim cmb As New DataGridViewComboBoxColumn()
    cmb.HeaderText = HeaderText
    cmb.Name = ComboName
    cmb.Width = 60
    cmb.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
    cmb.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
    cmb.ReadOnly = False
    cmb.MaxDropDownItems = 10
    For loopvar As Integer = Min To Max Step Interval
      cmb.Items.Add(loopvar)
    Next
    Return cmb
  End Function

  Sub hh(thisGrid As DataGridView, Col As Integer)
    With thisGrid
      If .Rows.Count = 0 Then Exit Sub
      Dim i As Integer = thisGrid.CurrentRow.Index

      Dim gridComboBox As New DataGridViewComboBoxCell
      For loopvar As Integer = 1 To 100
        gridComboBox.Items.Add(loopvar)
      Next
      .Item(Col, i) = gridComboBox
    End With
  End Sub

  Public Sub FillAvailDatesGrid(thisGrid As DataGridView, ShowTimes() As Type_ShowTimes)
    Dim TempControlsActive = ControlsActive : ControlsActive = False
    'thisGrid.DataSource = Nothing
    thisGrid.Rows.Clear()
    'thisGrid.Columns.Item(1).CellType = (ComboBoxColumn("Wave", "cbo_Wave"))
    If Not thisGrid.Columns.Contains("txt_Date") Then thisGrid.Columns.Add("txt_Date", "Date Header")
    If Not thisGrid.Columns.Contains("cbo_Wave") Then thisGrid.Columns.Add(ComboBoxColumn("Wave", "cbo_Wave"))
    If Not thisGrid.Columns.Contains("cbo_RealWave") Then thisGrid.Columns.Add(ComboBoxColumn("Real Wave", "cbo_RealWave"))

    thisGrid.Columns(0).Name = "txt_Date"
    thisGrid.Columns(1).Name = "cbo_Wave"
    thisGrid.Columns(2).Name = "cbo_RealWave"

    thisGrid.Columns(0).Width = 170
    thisGrid.Columns(1).Width = 60
    thisGrid.Columns(2).Width = 60

    thisGrid.Columns(0).ReadOnly = False
    thisGrid.Columns(1).ReadOnly = False
    thisGrid.Columns(2).ReadOnly = False

    Dim NewIndex As Integer = 0, Selected As Integer = default_Int

    If Not IsNothing(ShowTimes) Then

      For Each Item As Type_ShowTimes In ShowTimes

        NewIndex = thisGrid.Rows.Add()
        thisGrid.Rows(NewIndex).Tag = New ValueDescriptionPair(Item.ID, Item.Showtime)

        thisGrid.Rows.Item(NewIndex).Cells(0).Value = Item.Showtime

        thisGrid.Rows.Item(NewIndex).Cells(1).Value = Item.Wave
        thisGrid.Rows.Item(NewIndex).Cells(2).Value = Item.RealWave
        'If SelectedTelephone = Item.Contact.Telephone Then Selected = NewIndex

      Next
      thisGrid.Enabled = True
    End If
    'thisGrid.Rows(0).Selected = False
    If Selected > default_Int Then thisGrid.Rows(Selected).Selected = True Else thisGrid.ClearSelection()
    Application.DoEvents()
    ControlsActive = TempControlsActive
  End Sub
  Private Sub cbo_NavLocation_Click(sender As Object, e As EventArgs)
  End Sub
  Private Sub cbo_Location_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Location.SelectedIndexChanged
    If ControlsActive Then
      Dim Obj_Combo As ComboBox = CType(sender, ComboBox)
      If Not IsNothing(Obj_Combo.SelectedItem) Then
        Dim Obj_Value As Integer = CInt(CType(Obj_Combo.SelectedItem, ValueDescriptionPair).Value)
        Dim FormField As New TypeFormField With {.ControlName = Obj_Combo.Name,
                                            .NewValue = Obj_Value,
                                            .FieldName = "NA"}
        LocationID = FormField.NewValue
        StatusID = default_Int
        Drawpage(Pages.Location)
        'FocusIt.TabIndex = Obj_Combo.TabIndex
        FocusIt.Select()
      End If
    End If
  End Sub
  Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Status.SelectedIndexChanged
    If ControlsActive Then
      Dim Obj_Combo As ComboBox = CType(sender, ComboBox)
      Dim Obj_Value As Integer = CInt(CType(Obj_Combo.SelectedItem, ValueDescriptionPair).Value)
      Dim FormField As New TypeFormField With {.ControlName = Obj_Combo.Name,
                                          .NewValue = Obj_Value,
                                          .FieldName = "NA"}
      StatusID = FormField.NewValue
      fillLocation()
      FocusIt.TabIndex = Obj_Combo.TabIndex
      FocusIt.Select()
    End If

  End Sub

  Private Sub lst_StatusBranch_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lst_StatusBranch.MouseDoubleClick
    If ControlsActive Then
      Dim Obj_ListBox As ListBox = CType(sender, ListBox)
      Dim Obj_Value As Integer = CInt(CType(Obj_ListBox.SelectedItem, ValueDescriptionPair).Value)
      Dim FormField As New TypeFormField With {.ControlName = Obj_ListBox.Name,
                                          .NewValue = Obj_Value,
                                          .FieldName = "NA"}
      StatusID = FormField.NewValue
      fillLocation()
      FocusIt.TabIndex = Obj_ListBox.TabIndex
      FocusIt.Select()
    End If
  End Sub
  Dim SelectedStatusID As Integer = default_Int
  Private Sub lst_StatusBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_StatusBranch.SelectedIndexChanged
    If ControlsActive Then
      ControlsActive = False
      Dim Obj_ListBox As ListBox = CType(sender, ListBox)
      Dim Obj_Value As Integer = CInt(CType(Obj_ListBox.SelectedItem, ValueDescriptionPair).Value)
      Dim FormField As New TypeFormField With {.ControlName = Obj_ListBox.Name,
                                          .NewValue = Obj_Value,
                                          .FieldName = "NA"}
      SelectedStatusID = FormField.NewValue
      ck_AlwaysVis.Checked = CC.GetLocationStatus(LocationID, SelectedStatusID).AlwaysVis
      ck_AlwaysVis.Enabled = SelectedStatusID > default_Int
      cmd_DeleteLocStatus.Enabled = SelectedStatusID > default_Int
      ControlsActive = True
    End If
  End Sub
  Private Sub cbo_NewStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_NewStatus.SelectedIndexChanged
    If ControlsActive Then
      Dim Obj_Combo As ComboBox = CType(sender, ComboBox)
      Dim Obj_Value As Integer = CInt(CType(Obj_Combo.SelectedItem, ValueDescriptionPair).Value)
      If Obj_Value > default_Int Then
        CreateLocationStatus(LocationID, StatusID, Obj_Value, ck_AlwaysVis.Checked)
        fillLocation(True)
        FocusIt.TabIndex = Obj_Combo.TabIndex
        FocusIt.Select()
      End If
    End If

  End Sub

  Private Sub cmd_DeleteLocStatus_Click(sender As Object, e As EventArgs) Handles cmd_DeleteLocStatus.Click
    If ControlsActive Then
      If SelectedStatusID > default_Int Then
        Dim LIndex As Integer = CC.GetLocationlistIndex(LocationID)
        Dim SIndex As Integer = CC.GetLocationStatusIndex(LocationID, SelectedStatusID)
        With CC.LocationList(LIndex).Status(SIndex)
          If DeleteLocationStatus(LocationID, .CurrentID, .AllowedID) Then
            CC.RemoveLocationStatusArray(LocationID, SelectedStatusID)
          End If
        End With
        fillLocation(True)
      End If
    End If
  End Sub
  Private Sub ck_AlwaysVis_CheckedChanged(sender As Object, e As EventArgs) Handles ck_AlwaysVis.CheckedChanged
    If ControlsActive Then
      Dim ck_Box As CheckBox = CType(sender, CheckBox)
      If SelectedStatusID > default_Int Then
        Dim LIndex As Integer = CC.GetLocationlistIndex(LocationID)
        Dim SIndex As Integer = CC.GetLocationStatusIndex(LocationID, SelectedStatusID)
        With CC.LocationList(LIndex).Status(SIndex)
          If ck_Box.Checked Then
            If UpdateLocationStatus(LocationID, 0, .AllowedID, True) Then
              .AlwaysVis = ck_Box.Checked
              .CurrentID = 0
            End If
          Else
            If UpdateLocationStatus(LocationID, StatusID, .AllowedID, False) Then
              .AlwaysVis = ck_Box.Checked
              .CurrentID = StatusID
            End If
          End If
        End With
      End If
    End If
  End Sub





  Function CreateLocationStatus(LocationID As Integer, CurrentID As Integer, AllowedID As Integer, AlwaysVis As Boolean) As Boolean

    Dim Success As Boolean, Sqlstr As String

    Sqlstr = "INSERT INTO tbl_Location_Status " & _
      "(LocationID, CurrentID, AllowedID, AlwaysVis) " & _
      "VALUES (" & LocationID & ", " & CurrentID & ", " & AllowedID & ", " & InputVar(AlwaysVis, 0) & ")"

    Success = CC.RunSQL(Sqlstr)

    Return Success
  End Function
  Function DeleteLocationStatus(LocationID As Integer, CurrentID As Integer, AllowedID As Integer) As Boolean

    Dim Success As Boolean, Sqlstr As String

    Sqlstr = "DELETE FROM tbl_Location_Status " & _
      "where (LocationID=" & LocationID & " and CurrentID=" & CurrentID & " and AllowedID=" & AllowedID & ");"

    Success = CC.RunSQL(Sqlstr)

    Return Success
  End Function
  Function UpdateLocationStatus(LocationID As Integer, CurrentID As Integer, AllowedID As Integer, AlwaysVis As Boolean) As Boolean

    Dim Success As Boolean, Sqlstr As String

    Sqlstr = "UPDATE tbl_Location_Status SET AlwaysVis=" & InputVar(AlwaysVis, 0) & " " & _
      "where (LocationID=" & LocationID & " and CurrentID=" & CurrentID & " and AllowedID=" & AllowedID & ");"

    Success = CC.RunSQL(Sqlstr)

    Return Success
  End Function
  Private Enum Pages
    Location
    Promo
    Content
  End Enum
  Private Sub mnu_Location_ButtonClick(sender As Object, e As EventArgs) Handles mnu_Location.ButtonClick
    Drawpage(Pages.Location)
  End Sub
  Private Sub mnu_Promo_ButtonClick(sender As Object, e As EventArgs)
    Drawpage(Pages.Promo)
  End Sub
  Private Sub mnu_Content_Click(sender As Object, e As EventArgs) Handles mnu_Content.Click
    Drawpage(Pages.Content)
  End Sub
  Private Sub Drawpage(Page As Pages)
    tbl_LocationSettings.Visible = (Page = Pages.Location)
    tbl_PromoSettings.Visible = (Page = Pages.Promo)
    tbl_ContentEdit.Visible = (Page = Pages.Content)
    Select Case Page
      Case Pages.Location
        fillLocation(True)
      Case Pages.Promo
        Drawpromo()
      Case Pages.Content
        DrawContent()
    End Select
  End Sub


  'Private Sub frmMain_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Static first_run As Boolean = True
  '  If first_run Then
  '    first_run = False
  '    Exit Sub
  '  End If

  '  Dim m As Point = Windows.Forms.Cursor.Position
  '  Dim bb As Rectangle
  '  Dim bs As Rectangle

  '  If GetKeyState(Keys.LButton) Then
  '    If main_tool_strip.Visible Then
  '      For Each tool_menu_button As ToolStripItem In main_tool_strip.Items
  '        bb = tool_menu_button.Bounds
  '        bb.Y += main_menu.Height
  '        bs = Me.RectangleToScreen(bb)
  '        If bs.Contains(m) Then  tool_menu_button.PerformClick()
  '      Next
  '    End If

  '    For Each menu_item As ToolStripMenuItem In main_menu.Items
  '      bb = menu_item.Bounds
  '      bs = Me.RectangleToScreen(bb)

  '      If bs.Contains(m) Then
  '        If TypeOf (menu_item) Is ToolStripDropDownItem Then
  '          Dim t As ToolStripDropDownItem
  '          t = menu_item
  '          t.ShowDropDown()
  '        Else
  '          menu_item.PerformClick()
  '        End If

  '      End If

  '    Next

  '  End If
  'End Sub

  Private Sub AvailStartDate_ValueChanged(sender As Object, e As EventArgs)

  End Sub

  Private Sub Label6_Click(sender As Object, e As EventArgs)

  End Sub

  Private Sub Grid_Results_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Grid_Results.DataError
    'For Each item As DataGridViewRow In Grid_Results.Rows
    '  Dim Row As String = ""
    '  For Each cel As DataGridViewCell In item.Cells
    '    Row = Row & " (" & cel.Value & ") "
    '  Next
    '  log(Row)
    'Next








    log(e.Exception.ToString)

    log("Error happened " & e.Context.ToString())
    If (e.Context = DataGridViewDataErrorContexts.Commit) Then
      log("Commit error")
    End If
    If (e.Context = DataGridViewDataErrorContexts.CurrentCellChange) Then
      log("Cell change")
    End If
    If (e.Context = DataGridViewDataErrorContexts.Parsing) Then
      log("parsing error")
    End If
    If (e.Context = DataGridViewDataErrorContexts.LeaveControl) Then
      log("leave control error")
    End If

    'If (TypeOf (e.Exception) Is ConstraintException) Then
    '  Dim view As DataGridView = CType(sender, DataGridView)
    '  view.Rows(e.RowIndex).ErrorText = "an error"
    '  view.Rows(e.RowIndex).Cells(e.ColumnIndex).ErrorText = "an error"

    'End If
    e.ThrowException = False
  End Sub


  Private Sub EditCitysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCitysToolStripMenuItem.Click

  End Sub

  Private Sub mnu_AddNewLocation_Click(sender As Object, e As EventArgs) Handles mnu_AddNewLocation.Click

  End Sub



  Private Sub Field_HelpRequest(ByVal sender As Object,
                                ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles cbo_Location.HelpRequested,
    txt_Location.HelpRequested,
    cbo_City.HelpRequested,
    ck_LocEnabled.HelpRequested,
    cbo_Status.HelpRequested,
    lst_StatusBranch.HelpRequested,
    ck_AlwaysVis.HelpRequested,
    cmd_DeleteLocStatus.HelpRequested,
    cbo_NewStatus.HelpRequested,
    cmd_EditOpenDates.HelpRequested,
    Grid_Results.HelpRequested
    If ControlsActive Then
      Dim Mesasage As String = ""
      Select Case sender.name
        Case "cbo_Location" : Mesasage = "Choose the Location you want to work with. Choose 'Default to edit Global Status settings'"
        Case "txt_Location" : Mesasage = "Set the Display Name selected Location."
        Case "cbo_City" : Mesasage = "Set the City for selected Location."
        Case "ck_LocEnabled" : Mesasage = "Set weather the selected Location is enabled."
        Case "cbo_Status" : Mesasage = "Select A Status to work with for the Selected Location."
        Case "lst_StatusBranch" : Mesasage = "Available Status Options for the selected Location and Status. You must add Options to this list to move forward from the selected Status"
        Case "ck_AlwaysVis" : Mesasage = "The Selected branch options will be visible no matter what the current status is."
        Case "cmd_DeleteLocStatus" : Mesasage = "Remove the selected branch."
        Case "cbo_NewStatus" : Mesasage = "Add a branch to the list."
        Case "cmd_EditOpenDates" : Mesasage = "Add new or edit existing show dates and times."
        Case "Grid_Results" : Mesasage = "Edit Show Dates, Times and wave limits here. (Wave limits Editable Soon)"


        Case Else : Mesasage = "No help available for this field."
      End Select
      Help.ShowPopup(Me, Mesasage, hlpevent.MousePos)
    End If
  End Sub


  Private Sub WhatsThisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhatsThisToolStripMenuItem.Click
    Dim myItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
    Dim cms As ContextMenuStrip = CType(myItem.Owner, ContextMenuStrip)


    Me.Cursor = New Cursor(Cursor.Current.Handle)
    'Cursor.Position = New Point(Cursor.Position.X - 50, Cursor.Position.Y - 50)
    'Cursor.Clip = New Rectangle(Me.Location, Me.Size)

    'Field_HelpRequest(cms.SourceControl, New HelpEventArgs(cms.SourceControl.Location + Me.Location))
    Field_HelpRequest(cms.SourceControl, New HelpEventArgs(Cursor.Position))

  End Sub
  Private Sub ReportAnIssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportAnIssueToolStripMenuItem.Click
    Dim myItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
    Dim cms As ContextMenuStrip = CType(myItem.Owner, ContextMenuStrip)



  End Sub

  Private Sub mnu_Promo_Click(sender As Object, e As EventArgs) Handles mnu_Promo.Click

  End Sub



  Private Sub mnu_RTF_Save_Click(sender As Object, e As EventArgs) Handles mnu_RTF_Save.Click
    Dim Obj_Value As Integer = CInt(CType(cbo_ContentFiles.SelectedItem, ValueDescriptionPair).Value)
    Dim Index As Integer = CC.GetContentlistIndex(Obj_Value)
    Dim DocumentText As String = RichTextBox.Rtf
    If CC.RunSQL("UPDATE dbo.tbl_Content SET Value = N'" & CC.cleanForSQL(DocumentText) & "' WHERE ID=" & CC.Content(Index).ID, DB.CallCenter) Then
      CC.Content(Index).Value = DocumentText
    End If
  End Sub
  Private Sub mnu_ImportRTF_Click(sender As Object, e As EventArgs) Handles mnu_ImportFile.Click
    OpenRTF()
  End Sub
  Private Sub DeleteCurrentFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteCurrentFileToolStripMenuItem.Click
    Dim Obj_Value As Integer = CInt(CType(cbo_ContentFiles.SelectedItem, ValueDescriptionPair).Value)
    Dim Index As Integer = CC.GetContentlistIndex(Obj_Value)
    If CC.RunSQL("DELETE FROM dbo.tbl_Content WHERE ID = " & CC.Content(Index).ID, DB.CallCenter) Then
      'System.Array.Clear(CC.Content, Index, 1)
      RemoveItem(CC.Content, Index)
      DrawContent()
    End If

  End Sub
  Sub RemoveItem(ByRef Items As Type_Content(), DelIndex As Integer)
    If Not IsNothing(Items) Then
      If Items.Length > 1 Then
        For Item = DelIndex To Items.Length - 2
          Items(Item) = Items(Item + 1)
        Next
        ReDim Preserve Items(Items.Length - 2)
      Else
        Erase Items
      End If
    End If
  End Sub
  Private Sub OpenRTF()
    Dim FD As New OpenFileDialog()
    FD.Filter = "Rich Text Format|*.rtf|htm Files|*.htm|html Files|*.html"
    FD.Title = "Select a File to import"
    If FD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
      Dim NewContent As New Type_Content
      Dim FileName = FD.FileName.Substring(FD.FileName.LastIndexOf("\") + 1)
      Dim extension = FileName.Substring(FileName.LastIndexOf("."))
      NewContent.Name = FileName.Substring(0, FileName.LastIndexOf("."))
      NewContent.Value = FileIO.FileSystem.ReadAllText(FD.FileName)
      Select Case extension.ToLower
        Case ".htm"
          MsgBox("htm files have not been coded yet, Sorry", MsgBoxStyle.Information, "Not Coded Yet")
        Case ".html"
          MsgBox("html files have not been coded yet, Sorry", MsgBoxStyle.Information, "Not Coded Yet")
        Case ".rtf"
          Dim Newindex As Integer = 0
          If CC.CreateContent(NewContent) Then
            If Not IsNothing(CC.Content) Then Newindex = CC.Content.Length
            ReDim Preserve CC.Content(Newindex)
            CC.Content(Newindex) = NewContent
            DrawContent(CC.Content(Newindex).ID)
          End If
        Case Else
          MsgBox("Not sure how you got here but this is a invalid File Type.", MsgBoxStyle.Critical, "Invalid File Type")
      End Select
    End If
  End Sub

  Private Sub cbo_ContentFiles_Click(sender As Object, e As EventArgs) Handles cbo_ContentFiles.Click
  End Sub
  Private Sub cbo_ContentFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_ContentFiles.SelectedIndexChanged
    If ControlsActive Then
      Dim Obj_Combo As ToolStripComboBox = CType(sender, ToolStripComboBox)
      If Not IsNothing(Obj_Combo.SelectedItem) Then
        Dim Obj_Value As Integer = CInt(CType(Obj_Combo.SelectedItem, ValueDescriptionPair).Value)
        Dim Index As Integer = CC.GetContentlistIndex(Obj_Value)
        If Index > default_Int Then
          RichTextBox.Rtf = CC.Content(Index).Value
        Else
          RichTextBox.Text = ""
        End If
      End If
    End If
  End Sub
  Sub Drawpromo(Optional ThisID As Integer = default_Int)
  End Sub
  Sub DrawContent(Optional ThisID As Integer = default_Int)
    If Not IsNothing(CC.Content) Then ThisID = CC.Content(0).ID
    FillContent(cbo_ContentFiles, CC.Content, ThisID)
    FillClipList(lst_Clip)
    RichTextBox.Enabled = ThisID <> default_Int
    lst_Clip.Enabled = ThisID <> default_Int
    mnu_RTF_DeleteMenu.Enabled = ThisID <> default_Int
    mnu_RTF_Save.Enabled = ThisID <> default_Int
    If ThisID = default_Int Then RichTextBox.Text = ""
  End Sub

  Private Sub lst_Clip_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lst_Clip.MouseDoubleClick
    If ControlsActive Then

    End If
  End Sub
  Private Sub lst_Clip_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Clip.SelectedIndexChanged
    If ControlsActive Then

    End If
  End Sub
End Class