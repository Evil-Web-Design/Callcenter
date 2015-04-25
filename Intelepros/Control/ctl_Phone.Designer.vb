<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctl_Phone
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Me.components = New System.ComponentModel.Container()
    Me.tbl_Layout = New System.Windows.Forms.TableLayoutPanel()
    Me.txt_Suffix = New System.Windows.Forms.TextBox()
    Me.Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.mnu_Copy = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_Paste = New System.Windows.Forms.ToolStripMenuItem()
    Me.txt_Prefix = New System.Windows.Forms.TextBox()
    Me.txt_Area = New System.Windows.Forms.TextBox()
    Me.LBL_3 = New System.Windows.Forms.Label()
    Me.LBL_2 = New System.Windows.Forms.Label()
    Me.LBL_1 = New System.Windows.Forms.Label()
    Me.tbl_Layout.SuspendLayout()
    Me.Menu.SuspendLayout()
    Me.SuspendLayout()
    '
    'tbl_Layout
    '
    Me.tbl_Layout.BackColor = System.Drawing.SystemColors.Window
    Me.tbl_Layout.ColumnCount = 6
    Me.tbl_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
    Me.tbl_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
    Me.tbl_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
    Me.tbl_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
    Me.tbl_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
    Me.tbl_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
    Me.tbl_Layout.Controls.Add(Me.txt_Suffix, 5, 0)
    Me.tbl_Layout.Controls.Add(Me.txt_Prefix, 3, 0)
    Me.tbl_Layout.Controls.Add(Me.txt_Area, 1, 0)
    Me.tbl_Layout.Controls.Add(Me.LBL_3, 4, 0)
    Me.tbl_Layout.Controls.Add(Me.LBL_2, 2, 0)
    Me.tbl_Layout.Controls.Add(Me.LBL_1, 0, 0)
    Me.tbl_Layout.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tbl_Layout.Location = New System.Drawing.Point(0, 0)
    Me.tbl_Layout.Margin = New System.Windows.Forms.Padding(0)
    Me.tbl_Layout.Name = "tbl_Layout"
    Me.tbl_Layout.RowCount = 1
    Me.tbl_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.tbl_Layout.Size = New System.Drawing.Size(230, 24)
    Me.tbl_Layout.TabIndex = 4
    '
    'txt_Suffix
    '
    Me.txt_Suffix.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txt_Suffix.ContextMenuStrip = Me.Menu
    Me.txt_Suffix.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txt_Suffix.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txt_Suffix.Location = New System.Drawing.Point(150, 0)
    Me.txt_Suffix.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_Suffix.MaxLength = 4
    Me.txt_Suffix.Name = "txt_Suffix"
    Me.txt_Suffix.Size = New System.Drawing.Size(80, 15)
    Me.txt_Suffix.TabIndex = 2
    Me.txt_Suffix.Tag = "Last"
    Me.txt_Suffix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    Me.txt_Suffix.WordWrap = False
    '
    'Menu
    '
    Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Copy, Me.mnu_Paste})
    Me.Menu.Name = "Menu"
    Me.Menu.Size = New System.Drawing.Size(103, 48)
    '
    'mnu_Copy
    '
    Me.mnu_Copy.Name = "mnu_Copy"
    Me.mnu_Copy.Size = New System.Drawing.Size(102, 22)
    Me.mnu_Copy.Text = "&Copy"
    '
    'mnu_Paste
    '
    Me.mnu_Paste.Name = "mnu_Paste"
    Me.mnu_Paste.Size = New System.Drawing.Size(102, 22)
    Me.mnu_Paste.Text = "&Paste"
    '
    'txt_Prefix
    '
    Me.txt_Prefix.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txt_Prefix.ContextMenuStrip = Me.Menu
    Me.txt_Prefix.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txt_Prefix.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txt_Prefix.Location = New System.Drawing.Point(80, 0)
    Me.txt_Prefix.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_Prefix.MaxLength = 3
    Me.txt_Prefix.Name = "txt_Prefix"
    Me.txt_Prefix.Size = New System.Drawing.Size(60, 15)
    Me.txt_Prefix.TabIndex = 1
    Me.txt_Prefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    Me.txt_Prefix.WordWrap = False
    '
    'txt_Area
    '
    Me.txt_Area.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txt_Area.ContextMenuStrip = Me.Menu
    Me.txt_Area.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txt_Area.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txt_Area.Location = New System.Drawing.Point(10, 0)
    Me.txt_Area.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_Area.MaxLength = 3
    Me.txt_Area.Name = "txt_Area"
    Me.txt_Area.Size = New System.Drawing.Size(60, 15)
    Me.txt_Area.TabIndex = 0
    Me.txt_Area.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    Me.txt_Area.WordWrap = False
    '
    'LBL_3
    '
    Me.LBL_3.BackColor = System.Drawing.Color.Transparent
    Me.LBL_3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LBL_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LBL_3.Location = New System.Drawing.Point(140, 0)
    Me.LBL_3.Margin = New System.Windows.Forms.Padding(0)
    Me.LBL_3.Name = "LBL_3"
    Me.LBL_3.Size = New System.Drawing.Size(10, 24)
    Me.LBL_3.TabIndex = 3
    Me.LBL_3.Text = "-"
    Me.LBL_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'LBL_2
    '
    Me.LBL_2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LBL_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LBL_2.Location = New System.Drawing.Point(70, 0)
    Me.LBL_2.Margin = New System.Windows.Forms.Padding(0)
    Me.LBL_2.Name = "LBL_2"
    Me.LBL_2.Size = New System.Drawing.Size(10, 24)
    Me.LBL_2.TabIndex = 6
    Me.LBL_2.Text = ")"
    Me.LBL_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'LBL_1
    '
    Me.LBL_1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LBL_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LBL_1.Location = New System.Drawing.Point(0, 0)
    Me.LBL_1.Margin = New System.Windows.Forms.Padding(0)
    Me.LBL_1.Name = "LBL_1"
    Me.LBL_1.Size = New System.Drawing.Size(10, 24)
    Me.LBL_1.TabIndex = 5
    Me.LBL_1.Text = "("
    Me.LBL_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'ctl_Phone
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.tbl_Layout)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "ctl_Phone"
    Me.Size = New System.Drawing.Size(230, 24)
    Me.tbl_Layout.ResumeLayout(False)
    Me.tbl_Layout.PerformLayout()
    Me.Menu.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents tbl_Layout As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents LBL_2 As System.Windows.Forms.Label
  Friend WithEvents txt_Suffix As System.Windows.Forms.TextBox
  Friend WithEvents LBL_1 As System.Windows.Forms.Label
  Friend WithEvents LBL_3 As System.Windows.Forms.Label
  Friend WithEvents txt_Prefix As System.Windows.Forms.TextBox
  Friend WithEvents txt_Area As System.Windows.Forms.TextBox
  Friend WithEvents Menu As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents mnu_Copy As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_Paste As System.Windows.Forms.ToolStripMenuItem

End Class
