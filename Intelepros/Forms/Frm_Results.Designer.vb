<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Results
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
    Me.Grid_Results = New System.Windows.Forms.DataGridView()
    Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
    Me.lbl_RecordsReturned = New System.Windows.Forms.ToolStripStatusLabel()
    Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
    Me.MainLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
    Me.lst_Counts = New System.Windows.Forms.ListBox()
    Me.mnu_ToolStrip = New System.Windows.Forms.ToolStrip()
    Me.mnu_View = New System.Windows.Forms.ToolStripDropDownButton()
    Me.mnu_ContactName = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnu_Booker = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_Booked = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnu_Confirmer = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_Conf = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnu_Location = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_Status = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_Appt = New System.Windows.Forms.ToolStripMenuItem()
    Me.cmd_CollapseResults = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
    Me.cmd_NewSearch = New System.Windows.Forms.ToolStripButton()
    Me.mnu_Export = New System.Windows.Forms.ToolStripButton()
    Me.mnu_Admin = New System.Windows.Forms.ToolStripMenuItem()
    CType(Me.Grid_Results, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.StatusStrip1.SuspendLayout()
    Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
    Me.ToolStripContainer1.ContentPanel.SuspendLayout()
    Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
    Me.ToolStripContainer1.SuspendLayout()
    Me.MainLayoutPanel.SuspendLayout()
    Me.mnu_ToolStrip.SuspendLayout()
    Me.SuspendLayout()
    '
    'Grid_Results
    '
    Me.Grid_Results.AllowUserToAddRows = False
    Me.Grid_Results.AllowUserToDeleteRows = False
    Me.Grid_Results.AllowUserToOrderColumns = True
    Me.Grid_Results.AllowUserToResizeRows = False
    Me.Grid_Results.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Grid_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.Grid_Results.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.Grid_Results.Location = New System.Drawing.Point(3, 82)
    Me.Grid_Results.MultiSelect = False
    Me.Grid_Results.Name = "Grid_Results"
    Me.Grid_Results.ReadOnly = True
    Me.Grid_Results.RowHeadersVisible = False
    Me.Grid_Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.Grid_Results.Size = New System.Drawing.Size(167, 86)
    Me.Grid_Results.TabIndex = 0
    '
    'StatusStrip1
    '
    Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
    Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_RecordsReturned})
    Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
    Me.StatusStrip1.Name = "StatusStrip1"
    Me.StatusStrip1.Size = New System.Drawing.Size(271, 22)
    Me.StatusStrip1.TabIndex = 3
    Me.StatusStrip1.Text = "StatusStrip1"
    '
    'lbl_RecordsReturned
    '
    Me.lbl_RecordsReturned.Name = "lbl_RecordsReturned"
    Me.lbl_RecordsReturned.Size = New System.Drawing.Size(100, 17)
    Me.lbl_RecordsReturned.Text = "Records Returned"
    '
    'ToolStripContainer1
    '
    '
    'ToolStripContainer1.BottomToolStripPanel
    '
    Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.StatusStrip1)
    '
    'ToolStripContainer1.ContentPanel
    '
    Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.MainLayoutPanel)
    Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(271, 215)
    Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ToolStripContainer1.LeftToolStripPanelVisible = False
    Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStripContainer1.Name = "ToolStripContainer1"
    Me.ToolStripContainer1.RightToolStripPanelVisible = False
    Me.ToolStripContainer1.Size = New System.Drawing.Size(271, 262)
    Me.ToolStripContainer1.TabIndex = 4
    Me.ToolStripContainer1.Text = "ToolStripContainer1"
    '
    'ToolStripContainer1.TopToolStripPanel
    '
    Me.ToolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.SystemColors.ButtonShadow
    Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.mnu_ToolStrip)
    Me.ToolStripContainer1.TopToolStripPanel.Margin = New System.Windows.Forms.Padding(3)
    Me.ToolStripContainer1.TopToolStripPanel.Padding = New System.Windows.Forms.Padding(3)
    '
    'MainLayoutPanel
    '
    Me.MainLayoutPanel.ColumnCount = 1
    Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.MainLayoutPanel.Controls.Add(Me.Grid_Results, 0, 1)
    Me.MainLayoutPanel.Controls.Add(Me.lst_Counts, 0, 0)
    Me.MainLayoutPanel.Location = New System.Drawing.Point(3, 6)
    Me.MainLayoutPanel.Name = "MainLayoutPanel"
    Me.MainLayoutPanel.RowCount = 2
    Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
    Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.MainLayoutPanel.Size = New System.Drawing.Size(173, 171)
    Me.MainLayoutPanel.TabIndex = 1
    '
    'lst_Counts
    '
    Me.lst_Counts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lst_Counts.FormattingEnabled = True
    Me.lst_Counts.IntegralHeight = False
    Me.lst_Counts.Location = New System.Drawing.Point(3, 3)
    Me.lst_Counts.MultiColumn = True
    Me.lst_Counts.Name = "lst_Counts"
    Me.lst_Counts.ScrollAlwaysVisible = True
    Me.lst_Counts.Size = New System.Drawing.Size(167, 73)
    Me.lst_Counts.TabIndex = 1
    '
    'mnu_ToolStrip
    '
    Me.mnu_ToolStrip.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.mnu_ToolStrip.Dock = System.Windows.Forms.DockStyle.None
    Me.mnu_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.mnu_ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_View, Me.cmd_CollapseResults, Me.ToolStripButton1, Me.cmd_NewSearch})
    Me.mnu_ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
    Me.mnu_ToolStrip.Location = New System.Drawing.Point(0, 0)
    Me.mnu_ToolStrip.Name = "mnu_ToolStrip"
    Me.mnu_ToolStrip.Padding = New System.Windows.Forms.Padding(0)
    Me.mnu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
    Me.mnu_ToolStrip.Size = New System.Drawing.Size(271, 25)
    Me.mnu_ToolStrip.Stretch = True
    Me.mnu_ToolStrip.TabIndex = 2
    Me.mnu_ToolStrip.Text = "ToolStrip1"
    '
    'mnu_View
    '
    Me.mnu_View.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.mnu_View.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_ContactName, Me.ToolStripSeparator4, Me.mnu_Booker, Me.mnu_Booked, Me.ToolStripSeparator2, Me.mnu_Confirmer, Me.mnu_Conf, Me.ToolStripSeparator3, Me.mnu_Location, Me.mnu_Status, Me.mnu_Appt})
    Me.mnu_View.Image = Global.Intelepros.My.Resources.Resources.tick
    Me.mnu_View.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.mnu_View.Name = "mnu_View"
    Me.mnu_View.Size = New System.Drawing.Size(61, 22)
    Me.mnu_View.Text = "View"
    '
    'mnu_ContactName
    '
    Me.mnu_ContactName.Name = "mnu_ContactName"
    Me.mnu_ContactName.Size = New System.Drawing.Size(152, 22)
    Me.mnu_ContactName.Text = "ContactName"
    '
    'ToolStripSeparator4
    '
    Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
    Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
    '
    'mnu_Booker
    '
    Me.mnu_Booker.Name = "mnu_Booker"
    Me.mnu_Booker.Size = New System.Drawing.Size(152, 22)
    Me.mnu_Booker.Text = "Booker"
    '
    'mnu_Booked
    '
    Me.mnu_Booked.Name = "mnu_Booked"
    Me.mnu_Booked.Size = New System.Drawing.Size(152, 22)
    Me.mnu_Booked.Text = "Booked"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
    '
    'mnu_Confirmer
    '
    Me.mnu_Confirmer.Name = "mnu_Confirmer"
    Me.mnu_Confirmer.Size = New System.Drawing.Size(152, 22)
    Me.mnu_Confirmer.Text = "Confirmer"
    '
    'mnu_Conf
    '
    Me.mnu_Conf.Name = "mnu_Conf"
    Me.mnu_Conf.Size = New System.Drawing.Size(152, 22)
    Me.mnu_Conf.Text = "Conf"
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
    '
    'mnu_Location
    '
    Me.mnu_Location.Name = "mnu_Location"
    Me.mnu_Location.Size = New System.Drawing.Size(152, 22)
    Me.mnu_Location.Text = "Location"
    '
    'mnu_Status
    '
    Me.mnu_Status.Name = "mnu_Status"
    Me.mnu_Status.Size = New System.Drawing.Size(152, 22)
    Me.mnu_Status.Text = "Status"
    '
    'mnu_Appt
    '
    Me.mnu_Appt.Name = "mnu_Appt"
    Me.mnu_Appt.Size = New System.Drawing.Size(152, 22)
    Me.mnu_Appt.Text = "Appt Date"
    '
    'cmd_CollapseResults
    '
    Me.cmd_CollapseResults.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.cmd_CollapseResults.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.cmd_CollapseResults.Image = Global.Intelepros.My.Resources.Resources.application
    Me.cmd_CollapseResults.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.cmd_CollapseResults.Name = "cmd_CollapseResults"
    Me.cmd_CollapseResults.Size = New System.Drawing.Size(23, 22)
    Me.cmd_CollapseResults.Text = "ToolStripButton1"
    Me.cmd_CollapseResults.Visible = False
    '
    'ToolStripButton1
    '
    Me.ToolStripButton1.Image = Global.Intelepros.My.Resources.Resources.arrow_refresh
    Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripButton1.Name = "ToolStripButton1"
    Me.ToolStripButton1.Size = New System.Drawing.Size(66, 22)
    Me.ToolStripButton1.Text = "Refresh"
    '
    'cmd_NewSearch
    '
    Me.cmd_NewSearch.Image = Global.Intelepros.My.Resources.Resources.magnifier
    Me.cmd_NewSearch.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.cmd_NewSearch.Name = "cmd_NewSearch"
    Me.cmd_NewSearch.Size = New System.Drawing.Size(89, 22)
    Me.cmd_NewSearch.Text = "New Search"
    '
    'mnu_Export
    '
    Me.mnu_Export.Image = Global.Intelepros.My.Resources.Resources.page_excel
    Me.mnu_Export.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.mnu_Export.Name = "mnu_Export"
    Me.mnu_Export.Size = New System.Drawing.Size(60, 20)
    Me.mnu_Export.Text = "Export"
    '
    'mnu_Admin
    '
    Me.mnu_Admin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Export})
    Me.mnu_Admin.Image = Global.Intelepros.My.Resources.Resources.key
    Me.mnu_Admin.Name = "mnu_Admin"
    Me.mnu_Admin.Size = New System.Drawing.Size(28, 25)
    Me.mnu_Admin.Visible = False
    '
    'Frm_Results
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(271, 262)
    Me.Controls.Add(Me.ToolStripContainer1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
    Me.Name = "Frm_Results"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
    Me.Text = "Search Results"
    Me.TransparencyKey = System.Drawing.Color.Lime
    CType(Me.Grid_Results, System.ComponentModel.ISupportInitialize).EndInit()
    Me.StatusStrip1.ResumeLayout(False)
    Me.StatusStrip1.PerformLayout()
    Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
    Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
    Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
    Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
    Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
    Me.ToolStripContainer1.ResumeLayout(False)
    Me.ToolStripContainer1.PerformLayout()
    Me.MainLayoutPanel.ResumeLayout(False)
    Me.mnu_ToolStrip.ResumeLayout(False)
    Me.mnu_ToolStrip.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Grid_Results As System.Windows.Forms.DataGridView
  Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
  Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
  Friend WithEvents MainLayoutPanel As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents mnu_ToolStrip As System.Windows.Forms.ToolStrip
  Friend WithEvents mnu_View As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents cmd_CollapseResults As System.Windows.Forms.ToolStripButton
  Friend WithEvents lbl_RecordsReturned As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
  Friend WithEvents mnu_Export As System.Windows.Forms.ToolStripButton
  Friend WithEvents mnu_Admin As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cmd_NewSearch As System.Windows.Forms.ToolStripButton
  Friend WithEvents lst_Counts As System.Windows.Forms.ListBox
  Friend WithEvents mnu_ContactName As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_Booker As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_Booked As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_Confirmer As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_Conf As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_Location As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_Status As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_Appt As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
End Class
