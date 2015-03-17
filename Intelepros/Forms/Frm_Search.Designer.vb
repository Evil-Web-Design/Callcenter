<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Search
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.GroupBox9 = New System.Windows.Forms.GroupBox()
    Me.tbl_Staff = New System.Windows.Forms.TableLayoutPanel()
    Me.cbo_EmpSearch = New System.Windows.Forms.ComboBox()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.cbo_EmpAction = New System.Windows.Forms.ComboBox()
    Me.CheckByEmp = New System.Windows.Forms.CheckBox()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.GroupBox8 = New System.Windows.Forms.GroupBox()
    Me.tbl_String = New System.Windows.Forms.TableLayoutPanel()
    Me.txt_Search = New System.Windows.Forms.TextBox()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.CheckBySearch = New System.Windows.Forms.CheckBox()
    Me.grp_Date = New System.Windows.Forms.GroupBox()
    Me.tbl_Date = New System.Windows.Forms.TableLayoutPanel()
    Me.DateSearchEnd = New System.Windows.Forms.DateTimePicker()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.DateSearchStart = New System.Windows.Forms.DateTimePicker()
    Me.CheckByDate = New System.Windows.Forms.CheckBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.cbo_DateMethod = New System.Windows.Forms.ComboBox()
    Me.cmd_Search = New System.Windows.Forms.Button()
    Me.GroupBox4 = New System.Windows.Forms.GroupBox()
    Me.lst_SearchStatus = New System.Windows.Forms.ListBox()
    Me.GroupBox3 = New System.Windows.Forms.GroupBox()
    Me.lst_SearchLocation = New System.Windows.Forms.ListBox()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.GroupBox9.SuspendLayout()
    Me.tbl_Staff.SuspendLayout()
    Me.GroupBox8.SuspendLayout()
    Me.tbl_String.SuspendLayout()
    Me.grp_Date.SuspendLayout()
    Me.tbl_Date.SuspendLayout()
    Me.GroupBox4.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control
    Me.TableLayoutPanel3.ColumnCount = 2
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.39806!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.60194!))
    Me.TableLayoutPanel3.Controls.Add(Me.GroupBox2, 1, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.GroupBox4, 0, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.GroupBox3, 0, 1)
    Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 3
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(452, 358)
    Me.TableLayoutPanel3.TabIndex = 5
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.GroupBox9)
    Me.GroupBox2.Controls.Add(Me.GroupBox8)
    Me.GroupBox2.Controls.Add(Me.grp_Date)
    Me.GroupBox2.Controls.Add(Me.cmd_Search)
    Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox2.Location = New System.Drawing.Point(244, 3)
    Me.GroupBox2.Name = "GroupBox2"
    Me.TableLayoutPanel3.SetRowSpan(Me.GroupBox2, 3)
    Me.GroupBox2.Size = New System.Drawing.Size(205, 352)
    Me.GroupBox2.TabIndex = 5
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Search Options"
    '
    'GroupBox9
    '
    Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
    Me.GroupBox9.Controls.Add(Me.tbl_Staff)
    Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBox9.Location = New System.Drawing.Point(3, 199)
    Me.GroupBox9.Name = "GroupBox9"
    Me.GroupBox9.Padding = New System.Windows.Forms.Padding(6, 0, 6, 6)
    Me.GroupBox9.Size = New System.Drawing.Size(199, 106)
    Me.GroupBox9.TabIndex = 7
    Me.GroupBox9.TabStop = False
    '
    'tbl_Staff
    '
    Me.tbl_Staff.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.tbl_Staff.ColumnCount = 2
    Me.tbl_Staff.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.17278!))
    Me.tbl_Staff.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.82722!))
    Me.tbl_Staff.Controls.Add(Me.cbo_EmpSearch, 1, 2)
    Me.tbl_Staff.Controls.Add(Me.Label15, 0, 1)
    Me.tbl_Staff.Controls.Add(Me.cbo_EmpAction, 1, 1)
    Me.tbl_Staff.Controls.Add(Me.CheckByEmp, 0, 0)
    Me.tbl_Staff.Controls.Add(Me.Label14, 0, 2)
    Me.tbl_Staff.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tbl_Staff.Location = New System.Drawing.Point(6, 13)
    Me.tbl_Staff.Name = "tbl_Staff"
    Me.tbl_Staff.Padding = New System.Windows.Forms.Padding(3)
    Me.tbl_Staff.RowCount = 3
    Me.tbl_Staff.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
    Me.tbl_Staff.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
    Me.tbl_Staff.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.tbl_Staff.Size = New System.Drawing.Size(187, 87)
    Me.tbl_Staff.TabIndex = 13
    '
    'cbo_EmpSearch
    '
    Me.cbo_EmpSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbo_EmpSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_EmpSearch.FormattingEnabled = True
    Me.cbo_EmpSearch.Location = New System.Drawing.Point(73, 58)
    Me.cbo_EmpSearch.Name = "cbo_EmpSearch"
    Me.cbo_EmpSearch.Size = New System.Drawing.Size(108, 21)
    Me.cbo_EmpSearch.TabIndex = 11
    '
    'Label15
    '
    Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label15.Location = New System.Drawing.Point(6, 33)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(61, 13)
    Me.Label15.TabIndex = 6
    Me.Label15.Text = "Action"
    Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'cbo_EmpAction
    '
    Me.cbo_EmpAction.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbo_EmpAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_EmpAction.FormattingEnabled = True
    Me.cbo_EmpAction.Location = New System.Drawing.Point(73, 29)
    Me.cbo_EmpAction.Name = "cbo_EmpAction"
    Me.cbo_EmpAction.Size = New System.Drawing.Size(108, 21)
    Me.cbo_EmpAction.TabIndex = 10
    '
    'CheckByEmp
    '
    Me.CheckByEmp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.tbl_Staff.SetColumnSpan(Me.CheckByEmp, 2)
    Me.CheckByEmp.Location = New System.Drawing.Point(6, 6)
    Me.CheckByEmp.Name = "CheckByEmp"
    Me.CheckByEmp.Size = New System.Drawing.Size(175, 17)
    Me.CheckByEmp.TabIndex = 9
    Me.CheckByEmp.Text = "By Employee"
    Me.CheckByEmp.UseVisualStyleBackColor = True
    '
    'Label14
    '
    Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label14.Location = New System.Drawing.Point(6, 60)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(61, 18)
    Me.Label14.TabIndex = 1
    Me.Label14.Text = "Search For"
    Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'GroupBox8
    '
    Me.GroupBox8.Controls.Add(Me.tbl_String)
    Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBox8.Location = New System.Drawing.Point(3, 121)
    Me.GroupBox8.Name = "GroupBox8"
    Me.GroupBox8.Padding = New System.Windows.Forms.Padding(6, 0, 6, 6)
    Me.GroupBox8.Size = New System.Drawing.Size(199, 78)
    Me.GroupBox8.TabIndex = 6
    Me.GroupBox8.TabStop = False
    '
    'tbl_String
    '
    Me.tbl_String.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.tbl_String.ColumnCount = 2
    Me.tbl_String.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.17278!))
    Me.tbl_String.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.82722!))
    Me.tbl_String.Controls.Add(Me.txt_Search, 1, 1)
    Me.tbl_String.Controls.Add(Me.Label13, 0, 1)
    Me.tbl_String.Controls.Add(Me.CheckBySearch, 0, 0)
    Me.tbl_String.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tbl_String.Location = New System.Drawing.Point(6, 13)
    Me.tbl_String.Name = "tbl_String"
    Me.tbl_String.RowCount = 2
    Me.tbl_String.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.tbl_String.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.tbl_String.Size = New System.Drawing.Size(187, 59)
    Me.tbl_String.TabIndex = 13
    '
    'txt_Search
    '
    Me.txt_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_Search.Location = New System.Drawing.Point(72, 34)
    Me.txt_Search.Name = "txt_Search"
    Me.txt_Search.Size = New System.Drawing.Size(112, 20)
    Me.txt_Search.TabIndex = 8
    '
    'Label13
    '
    Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label13.Location = New System.Drawing.Point(3, 37)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(63, 14)
    Me.Label13.TabIndex = 1
    Me.Label13.Text = "Search For"
    Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'CheckBySearch
    '
    Me.CheckBySearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.tbl_String.SetColumnSpan(Me.CheckBySearch, 2)
    Me.CheckBySearch.Location = New System.Drawing.Point(3, 3)
    Me.CheckBySearch.Name = "CheckBySearch"
    Me.CheckBySearch.Size = New System.Drawing.Size(181, 23)
    Me.CheckBySearch.TabIndex = 7
    Me.CheckBySearch.Text = "By Search String"
    Me.CheckBySearch.UseVisualStyleBackColor = True
    '
    'grp_Date
    '
    Me.grp_Date.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.grp_Date.Controls.Add(Me.tbl_Date)
    Me.grp_Date.Dock = System.Windows.Forms.DockStyle.Top
    Me.grp_Date.Location = New System.Drawing.Point(3, 16)
    Me.grp_Date.Name = "grp_Date"
    Me.grp_Date.Padding = New System.Windows.Forms.Padding(6, 0, 6, 6)
    Me.grp_Date.Size = New System.Drawing.Size(199, 105)
    Me.grp_Date.TabIndex = 5
    Me.grp_Date.TabStop = False
    '
    'tbl_Date
    '
    Me.tbl_Date.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.tbl_Date.ColumnCount = 2
    Me.tbl_Date.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.17278!))
    Me.tbl_Date.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.82722!))
    Me.tbl_Date.Controls.Add(Me.DateSearchEnd, 1, 2)
    Me.tbl_Date.Controls.Add(Me.Label12, 0, 2)
    Me.tbl_Date.Controls.Add(Me.DateSearchStart, 1, 1)
    Me.tbl_Date.Controls.Add(Me.CheckByDate, 0, 0)
    Me.tbl_Date.Controls.Add(Me.Label10, 0, 1)
    Me.tbl_Date.Controls.Add(Me.cbo_DateMethod, 1, 0)
    Me.tbl_Date.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tbl_Date.Location = New System.Drawing.Point(6, 13)
    Me.tbl_Date.Name = "tbl_Date"
    Me.tbl_Date.RowCount = 3
    Me.tbl_Date.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
    Me.tbl_Date.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
    Me.tbl_Date.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
    Me.tbl_Date.Size = New System.Drawing.Size(187, 86)
    Me.tbl_Date.TabIndex = 13
    '
    'DateSearchEnd
    '
    Me.DateSearchEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.DateSearchEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.DateSearchEnd.Location = New System.Drawing.Point(72, 60)
    Me.DateSearchEnd.Name = "DateSearchEnd"
    Me.DateSearchEnd.Size = New System.Drawing.Size(112, 20)
    Me.DateSearchEnd.TabIndex = 6
    '
    'Label12
    '
    Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label12.Location = New System.Drawing.Point(3, 64)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(63, 11)
    Me.Label12.TabIndex = 6
    Me.Label12.Text = "End Date"
    Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'DateSearchStart
    '
    Me.DateSearchStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.DateSearchStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.DateSearchStart.Location = New System.Drawing.Point(72, 31)
    Me.DateSearchStart.Name = "DateSearchStart"
    Me.DateSearchStart.Size = New System.Drawing.Size(112, 20)
    Me.DateSearchStart.TabIndex = 5
    '
    'CheckByDate
    '
    Me.CheckByDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.CheckByDate.Location = New System.Drawing.Point(3, 3)
    Me.CheckByDate.Name = "CheckByDate"
    Me.CheckByDate.Size = New System.Drawing.Size(63, 21)
    Me.CheckByDate.TabIndex = 3
    Me.CheckByDate.Text = "ByDate"
    Me.CheckByDate.UseVisualStyleBackColor = True
    '
    'Label10
    '
    Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label10.Location = New System.Drawing.Point(3, 34)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(63, 14)
    Me.Label10.TabIndex = 5
    Me.Label10.Text = "Start Date"
    Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'cbo_DateMethod
    '
    Me.cbo_DateMethod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbo_DateMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_DateMethod.FormattingEnabled = True
    Me.cbo_DateMethod.Location = New System.Drawing.Point(72, 3)
    Me.cbo_DateMethod.Name = "cbo_DateMethod"
    Me.cbo_DateMethod.Size = New System.Drawing.Size(112, 21)
    Me.cbo_DateMethod.TabIndex = 4
    '
    'cmd_Search
    '
    Me.cmd_Search.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.cmd_Search.Location = New System.Drawing.Point(3, 308)
    Me.cmd_Search.Name = "cmd_Search"
    Me.cmd_Search.Size = New System.Drawing.Size(199, 41)
    Me.cmd_Search.TabIndex = 12
    Me.cmd_Search.Text = "Search"
    Me.cmd_Search.UseVisualStyleBackColor = True
    '
    'GroupBox4
    '
    Me.GroupBox4.Controls.Add(Me.lst_SearchStatus)
    Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
    Me.GroupBox4.Name = "GroupBox4"
    Me.GroupBox4.Size = New System.Drawing.Size(235, 172)
    Me.GroupBox4.TabIndex = 3
    Me.GroupBox4.TabStop = False
    Me.GroupBox4.Text = "Status"
    '
    'lst_SearchStatus
    '
    Me.lst_SearchStatus.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lst_SearchStatus.FormattingEnabled = True
    Me.lst_SearchStatus.Location = New System.Drawing.Point(3, 16)
    Me.lst_SearchStatus.Name = "lst_SearchStatus"
    Me.lst_SearchStatus.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
    Me.lst_SearchStatus.Size = New System.Drawing.Size(229, 153)
    Me.lst_SearchStatus.TabIndex = 1
    '
    'GroupBox3
    '
    Me.GroupBox3.Controls.Add(Me.lst_SearchLocation)
    Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox3.Location = New System.Drawing.Point(3, 181)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Size = New System.Drawing.Size(235, 172)
    Me.GroupBox3.TabIndex = 2
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "Locations"
    '
    'lst_SearchLocation
    '
    Me.lst_SearchLocation.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lst_SearchLocation.FormattingEnabled = True
    Me.lst_SearchLocation.Location = New System.Drawing.Point(3, 16)
    Me.lst_SearchLocation.Name = "lst_SearchLocation"
    Me.lst_SearchLocation.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
    Me.lst_SearchLocation.Size = New System.Drawing.Size(229, 153)
    Me.lst_SearchLocation.TabIndex = 2
    '
    'Frm_Search
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(452, 358)
    Me.Controls.Add(Me.TableLayoutPanel3)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
    Me.MaximumSize = New System.Drawing.Size(805, 596)
    Me.MinimumSize = New System.Drawing.Size(468, 392)
    Me.Name = "Frm_Search"
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Search"
    Me.TopMost = True
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox9.ResumeLayout(False)
    Me.tbl_Staff.ResumeLayout(False)
    Me.GroupBox8.ResumeLayout(False)
    Me.tbl_String.ResumeLayout(False)
    Me.tbl_String.PerformLayout()
    Me.grp_Date.ResumeLayout(False)
    Me.tbl_Date.ResumeLayout(False)
    Me.GroupBox4.ResumeLayout(False)
    Me.GroupBox3.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
  Friend WithEvents tbl_Staff As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents cbo_EmpSearch As System.Windows.Forms.ComboBox
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents cbo_EmpAction As System.Windows.Forms.ComboBox
  Friend WithEvents CheckByEmp As System.Windows.Forms.CheckBox
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
  Friend WithEvents tbl_String As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents txt_Search As System.Windows.Forms.TextBox
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents CheckBySearch As System.Windows.Forms.CheckBox
  Friend WithEvents grp_Date As System.Windows.Forms.GroupBox
  Friend WithEvents tbl_Date As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents DateSearchEnd As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents DateSearchStart As System.Windows.Forms.DateTimePicker
  Friend WithEvents CheckByDate As System.Windows.Forms.CheckBox
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents cbo_DateMethod As System.Windows.Forms.ComboBox
  Friend WithEvents cmd_Search As System.Windows.Forms.Button
  Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
  Friend WithEvents lst_SearchStatus As System.Windows.Forms.ListBox
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents lst_SearchLocation As System.Windows.Forms.ListBox
End Class
