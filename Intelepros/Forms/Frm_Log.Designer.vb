<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Log
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
    Me.mnu_ToolStrip = New System.Windows.Forms.ToolStrip()
    Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
    Me.mnu_ToggleAutoLaunch = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
    Me.List = New System.Windows.Forms.ListBox()
    Me.mnu_ToolStrip.SuspendLayout()
    Me.ToolStripContainer1.ContentPanel.SuspendLayout()
    Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
    Me.ToolStripContainer1.SuspendLayout()
    Me.SuspendLayout()
    '
    'mnu_ToolStrip
    '
    Me.mnu_ToolStrip.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.mnu_ToolStrip.Dock = System.Windows.Forms.DockStyle.None
    Me.mnu_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.mnu_ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
    Me.mnu_ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
    Me.mnu_ToolStrip.Location = New System.Drawing.Point(0, 0)
    Me.mnu_ToolStrip.Name = "mnu_ToolStrip"
    Me.mnu_ToolStrip.Padding = New System.Windows.Forms.Padding(0)
    Me.mnu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
    Me.mnu_ToolStrip.Size = New System.Drawing.Size(220, 25)
    Me.mnu_ToolStrip.Stretch = True
    Me.mnu_ToolStrip.TabIndex = 1
    Me.mnu_ToolStrip.Text = "ToolStrip1"
    '
    'ToolStripDropDownButton1
    '
    Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_ToggleAutoLaunch})
    Me.ToolStripDropDownButton1.Image = Global.Intelepros.My.Resources.Resources.cog
    Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
    Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(78, 22)
    Me.ToolStripDropDownButton1.Text = "Settings"
    '
    'mnu_ToggleAutoLaunch
    '
    Me.mnu_ToggleAutoLaunch.Name = "mnu_ToggleAutoLaunch"
    Me.mnu_ToggleAutoLaunch.Size = New System.Drawing.Size(282, 22)
    Me.mnu_ToggleAutoLaunch.Text = "Open Log when starting on next launch"
    '
    'ToolStripContainer1
    '
    '
    'ToolStripContainer1.ContentPanel
    '
    Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.List)
    Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(220, 95)
    Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStripContainer1.Name = "ToolStripContainer1"
    Me.ToolStripContainer1.Size = New System.Drawing.Size(220, 120)
    Me.ToolStripContainer1.TabIndex = 2
    Me.ToolStripContainer1.Text = "ToolStripContainer1"
    '
    'ToolStripContainer1.TopToolStripPanel
    '
    Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.mnu_ToolStrip)
    '
    'List
    '
    Me.List.Dock = System.Windows.Forms.DockStyle.Fill
    Me.List.FormattingEnabled = True
    Me.List.Location = New System.Drawing.Point(0, 0)
    Me.List.Name = "List"
    Me.List.Size = New System.Drawing.Size(220, 95)
    Me.List.TabIndex = 0
    '
    'Frm_Log
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(220, 120)
    Me.Controls.Add(Me.ToolStripContainer1)
    Me.Name = "Frm_Log"
    Me.Text = "Log"
    Me.mnu_ToolStrip.ResumeLayout(False)
    Me.mnu_ToolStrip.PerformLayout()
    Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
    Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
    Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
    Me.ToolStripContainer1.ResumeLayout(False)
    Me.ToolStripContainer1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents mnu_ToolStrip As System.Windows.Forms.ToolStrip
  Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
  Friend WithEvents List As System.Windows.Forms.ListBox
  Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents mnu_ToggleAutoLaunch As System.Windows.Forms.ToolStripMenuItem
End Class
