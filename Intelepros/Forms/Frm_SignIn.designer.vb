<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SignIn
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_SignIn))
    Me.Button1 = New System.Windows.Forms.Button()
    Me.cbo_Staff = New System.Windows.Forms.ComboBox()
    Me.Txt_Password = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.lbl_MessageMask = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(268, 74)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(86, 29)
    Me.Button1.TabIndex = 1
    Me.Button1.Text = "Click to sign in"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'cbo_Staff
    '
    Me.cbo_Staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_Staff.FormattingEnabled = True
    Me.cbo_Staff.Location = New System.Drawing.Point(60, 48)
    Me.cbo_Staff.Name = "cbo_Staff"
    Me.cbo_Staff.Size = New System.Drawing.Size(294, 21)
    Me.cbo_Staff.TabIndex = 2
    '
    'Txt_Password
    '
    Me.Txt_Password.Font = New System.Drawing.Font("Marlett", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
    Me.Txt_Password.Location = New System.Drawing.Point(60, 74)
    Me.Txt_Password.MaxLength = 9
    Me.Txt_Password.Name = "Txt_Password"
    Me.Txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(110)
    Me.Txt_Password.Size = New System.Drawing.Size(202, 26)
    Me.Txt_Password.TabIndex = 3
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.ForeColor = System.Drawing.Color.White
    Me.Label1.Location = New System.Drawing.Point(23, 52)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(35, 13)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Name"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.ForeColor = System.Drawing.Color.White
    Me.Label2.Location = New System.Drawing.Point(5, 81)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(53, 13)
    Me.Label2.TabIndex = 5
    Me.Label2.Text = "Password"
    '
    'lbl_MessageMask
    '
    Me.lbl_MessageMask.BackColor = System.Drawing.Color.Transparent
    Me.lbl_MessageMask.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lbl_MessageMask.ForeColor = System.Drawing.Color.White
    Me.lbl_MessageMask.Location = New System.Drawing.Point(8, 9)
    Me.lbl_MessageMask.Name = "lbl_MessageMask"
    Me.lbl_MessageMask.Size = New System.Drawing.Size(346, 26)
    Me.lbl_MessageMask.TabIndex = 7
    Me.lbl_MessageMask.Text = "Login"
    Me.lbl_MessageMask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Frm_SignIn
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackgroundImage = Global.Intelepros.My.Resources.Resources.tv_static
    Me.ClientSize = New System.Drawing.Size(361, 119)
    Me.Controls.Add(Me.lbl_MessageMask)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Txt_Password)
    Me.Controls.Add(Me.cbo_Staff)
    Me.Controls.Add(Me.Button1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Frm_SignIn"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Log into System"
    Me.TopMost = True
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbo_Staff As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_Password As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lbl_MessageMask As System.Windows.Forms.Label
End Class
