<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Progress
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
    Me.ProgressBar = New System.Windows.Forms.ProgressBar()
    Me.lbl_MessageMask = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'ProgressBar
    '
    Me.ProgressBar.Location = New System.Drawing.Point(12, 38)
    Me.ProgressBar.Name = "ProgressBar"
    Me.ProgressBar.Size = New System.Drawing.Size(360, 20)
    Me.ProgressBar.TabIndex = 1
    '
    'lbl_MessageMask
    '
    Me.lbl_MessageMask.BackColor = System.Drawing.Color.Transparent
    Me.lbl_MessageMask.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lbl_MessageMask.ForeColor = System.Drawing.Color.White
    Me.lbl_MessageMask.Location = New System.Drawing.Point(12, 1)
    Me.lbl_MessageMask.Name = "lbl_MessageMask"
    Me.lbl_MessageMask.Size = New System.Drawing.Size(360, 34)
    Me.lbl_MessageMask.TabIndex = 9
    Me.lbl_MessageMask.Text = "Working... I'll be right with you!"
    Me.lbl_MessageMask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Frm_Progress
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = Global.Intelepros.My.Resources.Resources.tv_static
    Me.ClientSize = New System.Drawing.Size(384, 69)
    Me.ControlBox = False
    Me.Controls.Add(Me.lbl_MessageMask)
    Me.Controls.Add(Me.ProgressBar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.Name = "Frm_Progress"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Frm_Progress"
    Me.TopMost = True
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
  Friend WithEvents lbl_MessageMask As System.Windows.Forms.Label
End Class
