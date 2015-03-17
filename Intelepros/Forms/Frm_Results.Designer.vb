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
    Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.cmd_CollapseResults = New System.Windows.Forms.ToolStripButton()
    Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
    Me.mnu_Export = New System.Windows.Forms.ToolStripButton()
    Me.cmd_Unique = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
    CType(Me.Grid_Results, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip1.SuspendLayout()
    Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
    Me.ToolStripContainer1.ContentPanel.SuspendLayout()
    Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
    Me.ToolStripContainer1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Grid_Results
    '
    Me.Grid_Results.AllowUserToAddRows = False
    Me.Grid_Results.AllowUserToDeleteRows = False
    Me.Grid_Results.AllowUserToResizeColumns = False
    Me.Grid_Results.AllowUserToResizeRows = False
    Me.Grid_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.Grid_Results.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
    Me.Grid_Results.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Grid_Results.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.Grid_Results.Location = New System.Drawing.Point(0, 0)
    Me.Grid_Results.MultiSelect = False
    Me.Grid_Results.Name = "Grid_Results"
    Me.Grid_Results.ReadOnly = True
    Me.Grid_Results.RowHeadersVisible = False
    Me.Grid_Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.Grid_Results.Size = New System.Drawing.Size(414, 369)
    Me.Grid_Results.TabIndex = 0
    '
    'Column1
    '
    Me.Column1.HeaderText = "Phone"
    Me.Column1.Name = "Column1"
    Me.Column1.ReadOnly = True
    '
    'Column2
    '
    Me.Column2.HeaderText = "Name"
    Me.Column2.Name = "Column2"
    Me.Column2.ReadOnly = True
    '
    'Column3
    '
    Me.Column3.HeaderText = "Location"
    Me.Column3.Name = "Column3"
    Me.Column3.ReadOnly = True
    '
    'Column4
    '
    Me.Column4.HeaderText = "Status"
    Me.Column4.Name = "Column4"
    Me.Column4.ReadOnly = True
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmd_CollapseResults, Me.mnu_Export, Me.cmd_Unique})
    Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(210, 25)
    Me.ToolStrip1.TabIndex = 1
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'cmd_CollapseResults
    '
    Me.cmd_CollapseResults.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.cmd_CollapseResults.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.cmd_CollapseResults.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.cmd_CollapseResults.Name = "cmd_CollapseResults"
    Me.cmd_CollapseResults.Size = New System.Drawing.Size(23, 22)
    Me.cmd_CollapseResults.Text = "ToolStripButton1"
    '
    'StatusStrip1
    '
    Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
    Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
    Me.StatusStrip1.Name = "StatusStrip1"
    Me.StatusStrip1.Size = New System.Drawing.Size(414, 22)
    Me.StatusStrip1.TabIndex = 3
    Me.StatusStrip1.Text = "StatusStrip1"
    '
    'mnu_Export
    '
    Me.mnu_Export.Image = Global.Intelepros.My.Resources.Resources.page_excel
    Me.mnu_Export.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.mnu_Export.Name = "mnu_Export"
    Me.mnu_Export.Size = New System.Drawing.Size(60, 22)
    Me.mnu_Export.Text = "Export"
    '
    'cmd_Unique
    '
    Me.cmd_Unique.Image = Global.Intelepros.My.Resources.Resources.telephone
    Me.cmd_Unique.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.cmd_Unique.Name = "cmd_Unique"
    Me.cmd_Unique.Size = New System.Drawing.Size(115, 22)
    Me.cmd_Unique.Tag = "False"
    Me.cmd_Unique.Text = "Unique Contacts"
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
    Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Grid_Results)
    Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(414, 369)
    Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ToolStripContainer1.LeftToolStripPanelVisible = False
    Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStripContainer1.Name = "ToolStripContainer1"
    Me.ToolStripContainer1.RightToolStripPanelVisible = False
    Me.ToolStripContainer1.Size = New System.Drawing.Size(414, 416)
    Me.ToolStripContainer1.TabIndex = 4
    Me.ToolStripContainer1.Text = "ToolStripContainer1"
    '
    'ToolStripContainer1.TopToolStripPanel
    '
    Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
    '
    'Frm_Results
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(414, 416)
    Me.Controls.Add(Me.ToolStripContainer1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
    Me.MaximumSize = New System.Drawing.Size(430, 1600)
    Me.Name = "Frm_Results"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
    Me.Text = "Search Results"
    Me.TopMost = True
    Me.TransparencyKey = System.Drawing.Color.Lime
    CType(Me.Grid_Results, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
    Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
    Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
    Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
    Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
    Me.ToolStripContainer1.ResumeLayout(False)
    Me.ToolStripContainer1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Grid_Results As System.Windows.Forms.DataGridView
  Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents mnu_Export As System.Windows.Forms.ToolStripButton
  Friend WithEvents cmd_CollapseResults As System.Windows.Forms.ToolStripButton
  Friend WithEvents cmd_Unique As System.Windows.Forms.ToolStripButton
  Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
  Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
End Class
