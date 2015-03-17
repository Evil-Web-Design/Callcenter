<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_History
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
    Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.Grid_Results, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Grid_Results
    '
    Me.Grid_Results.AllowUserToAddRows = False
    Me.Grid_Results.AllowUserToDeleteRows = False
    Me.Grid_Results.AllowUserToResizeColumns = False
    Me.Grid_Results.AllowUserToResizeRows = False
    Me.Grid_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.Grid_Results.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
    Me.Grid_Results.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Grid_Results.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.Grid_Results.Location = New System.Drawing.Point(0, 0)
    Me.Grid_Results.MultiSelect = False
    Me.Grid_Results.Name = "Grid_Results"
    Me.Grid_Results.ReadOnly = True
    Me.Grid_Results.RowHeadersVisible = False
    Me.Grid_Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.Grid_Results.Size = New System.Drawing.Size(719, 397)
    Me.Grid_Results.TabIndex = 1
    '
    'Column1
    '
    Me.Column1.FillWeight = 150.0!
    Me.Column1.HeaderText = "Employee"
    Me.Column1.Name = "Column1"
    Me.Column1.ReadOnly = True
    Me.Column1.Width = 150
    '
    'Column2
    '
    Me.Column2.HeaderText = "Field"
    Me.Column2.Name = "Column2"
    Me.Column2.ReadOnly = True
    '
    'Column3
    '
    Me.Column3.FillWeight = 150.0!
    Me.Column3.HeaderText = "Old"
    Me.Column3.Name = "Column3"
    Me.Column3.ReadOnly = True
    Me.Column3.Width = 150
    '
    'Column4
    '
    Me.Column4.FillWeight = 150.0!
    Me.Column4.HeaderText = "New"
    Me.Column4.Name = "Column4"
    Me.Column4.ReadOnly = True
    Me.Column4.Width = 150
    '
    'Column5
    '
    Me.Column5.FillWeight = 150.0!
    Me.Column5.HeaderText = "ActionTime"
    Me.Column5.Name = "Column5"
    Me.Column5.ReadOnly = True
    Me.Column5.Width = 150
    '
    'Frm_History
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(719, 397)
    Me.Controls.Add(Me.Grid_Results)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
    Me.MaximumSize = New System.Drawing.Size(735, 1600)
    Me.Name = "Frm_History"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Booking History"
    Me.TopMost = True
    CType(Me.Grid_Results, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Grid_Results As System.Windows.Forms.DataGridView
  Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
