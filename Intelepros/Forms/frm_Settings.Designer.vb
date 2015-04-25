<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Settings
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
    Me.cbo_Server = New System.Windows.Forms.ComboBox()
    Me.txt_Login = New System.Windows.Forms.TextBox()
    Me.txt_Password = New System.Windows.Forms.TextBox()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cmd_Connect = New System.Windows.Forms.Button()
    Me.cmd_Cancel = New System.Windows.Forms.Button()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'cbo_Server
    '
    Me.cbo_Server.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.SetColumnSpan(Me.cbo_Server, 2)
    Me.cbo_Server.FormattingEnabled = True
    Me.cbo_Server.Location = New System.Drawing.Point(80, 4)
    Me.cbo_Server.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
    Me.cbo_Server.Name = "cbo_Server"
    Me.cbo_Server.Size = New System.Drawing.Size(226, 21)
    Me.cbo_Server.TabIndex = 1
    '
    'txt_Login
    '
    Me.txt_Login.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.SetColumnSpan(Me.txt_Login, 2)
    Me.txt_Login.Location = New System.Drawing.Point(80, 35)
    Me.txt_Login.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
    Me.txt_Login.Name = "txt_Login"
    Me.txt_Login.Size = New System.Drawing.Size(226, 20)
    Me.txt_Login.TabIndex = 2
    '
    'txt_Password
    '
    Me.txt_Password.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.SetColumnSpan(Me.txt_Password, 2)
    Me.txt_Password.Location = New System.Drawing.Point(80, 65)
    Me.txt_Password.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
    Me.txt_Password.Name = "txt_Password"
    Me.txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txt_Password.Size = New System.Drawing.Size(226, 20)
    Me.txt_Password.TabIndex = 3
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 3
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
    Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.cbo_Server, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.txt_Password, 1, 2)
    Me.TableLayoutPanel1.Controls.Add(Me.txt_Login, 1, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.cmd_Connect, 2, 3)
    Me.TableLayoutPanel1.Controls.Add(Me.cmd_Cancel, 1, 3)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 4
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(309, 140)
    Me.TableLayoutPanel1.TabIndex = 4
    '
    'Label3
    '
    Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label3.AutoSize = True
    Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Label3.Location = New System.Drawing.Point(3, 68)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(71, 13)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "Password"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label2
    '
    Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label2.AutoSize = True
    Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Label2.Location = New System.Drawing.Point(3, 38)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(71, 13)
    Me.Label2.TabIndex = 5
    Me.Label2.Text = "Login"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label1
    '
    Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label1.AutoSize = True
    Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Label1.Location = New System.Drawing.Point(3, 8)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(71, 13)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Server Name"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'cmd_Connect
    '
    Me.cmd_Connect.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmd_Connect.Location = New System.Drawing.Point(196, 93)
    Me.cmd_Connect.Name = "cmd_Connect"
    Me.cmd_Connect.Size = New System.Drawing.Size(110, 44)
    Me.cmd_Connect.TabIndex = 7
    Me.cmd_Connect.Text = "Connect"
    Me.cmd_Connect.UseVisualStyleBackColor = True
    '
    'cmd_Cancel
    '
    Me.cmd_Cancel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmd_Cancel.Location = New System.Drawing.Point(80, 93)
    Me.cmd_Cancel.Name = "cmd_Cancel"
    Me.cmd_Cancel.Size = New System.Drawing.Size(110, 44)
    Me.cmd_Cancel.TabIndex = 8
    Me.cmd_Cancel.Text = "Cancel"
    Me.cmd_Cancel.UseVisualStyleBackColor = True
    '
    'frm_Settings
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(309, 140)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frm_Settings"
    Me.Text = "Database Settings"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txt_Password As System.Windows.Forms.TextBox
  Friend WithEvents txt_Login As System.Windows.Forms.TextBox
  Friend WithEvents cbo_Server As System.Windows.Forms.ComboBox
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cmd_Connect As System.Windows.Forms.Button
  Friend WithEvents cmd_Cancel As System.Windows.Forms.Button
End Class
