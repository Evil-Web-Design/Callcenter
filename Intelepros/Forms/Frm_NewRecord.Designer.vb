<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_NewRecord
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
    Me.lbl_Phone = New System.Windows.Forms.Label()
    Me.cmd_Search = New System.Windows.Forms.Button()
    Me.txt_Claim = New System.Windows.Forms.TextBox()
    Me.bl_Claim = New System.Windows.Forms.Label()
    Me.ctl_Phone = New Intelepros.ctl_Phone()
    Me.SuspendLayout()
    '
    'lbl_Phone
    '
    Me.lbl_Phone.BackColor = System.Drawing.Color.Transparent
    Me.lbl_Phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lbl_Phone.ForeColor = System.Drawing.Color.White
    Me.lbl_Phone.Location = New System.Drawing.Point(12, 69)
    Me.lbl_Phone.Name = "lbl_Phone"
    Me.lbl_Phone.Size = New System.Drawing.Size(298, 30)
    Me.lbl_Phone.TabIndex = 1
    Me.lbl_Phone.Text = "Primary Telephone"
    '
    'cmd_Search
    '
    Me.cmd_Search.Image = Global.Intelepros.My.Resources.Resources.telephone_add
    Me.cmd_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmd_Search.Location = New System.Drawing.Point(215, 102)
    Me.cmd_Search.Name = "cmd_Search"
    Me.cmd_Search.Size = New System.Drawing.Size(94, 30)
    Me.cmd_Search.TabIndex = 2
    Me.cmd_Search.Text = "Create/Open"
    Me.cmd_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.cmd_Search.UseVisualStyleBackColor = True
    '
    'txt_Claim
    '
    Me.txt_Claim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txt_Claim.Location = New System.Drawing.Point(16, 40)
    Me.txt_Claim.Name = "txt_Claim"
    Me.txt_Claim.Size = New System.Drawing.Size(293, 26)
    Me.txt_Claim.TabIndex = 8
    Me.txt_Claim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'bl_Claim
    '
    Me.bl_Claim.BackColor = System.Drawing.Color.Transparent
    Me.bl_Claim.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.bl_Claim.ForeColor = System.Drawing.Color.White
    Me.bl_Claim.Location = New System.Drawing.Point(12, 0)
    Me.bl_Claim.Name = "bl_Claim"
    Me.bl_Claim.Size = New System.Drawing.Size(318, 37)
    Me.bl_Claim.TabIndex = 5
    Me.bl_Claim.Text = "Claim Number"
    Me.bl_Claim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'ctl_Phone
    '
    Me.ctl_Phone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.ctl_Phone.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.ctl_Phone.FieldType = Intelepros.ctl_Phone.Enum_FieldType.Telephone
    Me.ctl_Phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ctl_Phone.Location = New System.Drawing.Point(12, 102)
    Me.ctl_Phone.Name = "ctl_Phone"
    Me.ctl_Phone.Size = New System.Drawing.Size(197, 30)
    Me.ctl_Phone.TabIndex = 0
    Me.ctl_Phone.Value = ""
    '
    'Frm_NewRecord
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = Global.Intelepros.My.Resources.Resources.tv_static
    Me.ClientSize = New System.Drawing.Size(328, 140)
    Me.Controls.Add(Me.cmd_Search)
    Me.Controls.Add(Me.txt_Claim)
    Me.Controls.Add(Me.ctl_Phone)
    Me.Controls.Add(Me.bl_Claim)
    Me.Controls.Add(Me.lbl_Phone)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "Frm_NewRecord"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Create New / Open Contact"
    Me.TopMost = True
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ctl_Phone As Intelepros.ctl_Phone
  Friend WithEvents lbl_Phone As System.Windows.Forms.Label
  Friend WithEvents cmd_Search As System.Windows.Forms.Button
  Friend WithEvents txt_Claim As System.Windows.Forms.TextBox
  Friend WithEvents bl_Claim As System.Windows.Forms.Label
End Class
