<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MySQL
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
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Port = New System.Windows.Forms.TextBox()
    Me.databaseList = New System.Windows.Forms.ComboBox()
    Me.label5 = New System.Windows.Forms.Label()
    Me.updateBtn = New System.Windows.Forms.Button()
    Me.dataGrid = New System.Windows.Forms.DataGrid()
    Me.tables = New System.Windows.Forms.ComboBox()
    Me.connectBtn = New System.Windows.Forms.Button()
    Me.password = New System.Windows.Forms.TextBox()
    Me.label3 = New System.Windows.Forms.Label()
    Me.userid = New System.Windows.Forms.TextBox()
    Me.label2 = New System.Windows.Forms.Label()
    Me.server = New System.Windows.Forms.TextBox()
    Me.label1 = New System.Windows.Forms.Label()
    Me.label4 = New System.Windows.Forms.Label()
    CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label6
    '
    Me.Label6.Location = New System.Drawing.Point(243, 19)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(55, 16)
    Me.Label6.TabIndex = 41
    Me.Label6.Text = "Port:"
    '
    'Port
    '
    Me.Port.Location = New System.Drawing.Point(305, 16)
    Me.Port.Name = "Port"
    Me.Port.Size = New System.Drawing.Size(78, 20)
    Me.Port.TabIndex = 40
    Me.Port.Text = "3306"
    '
    'databaseList
    '
    Me.databaseList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.databaseList.Enabled = False
    Me.databaseList.Location = New System.Drawing.Point(84, 88)
    Me.databaseList.Name = "databaseList"
    Me.databaseList.Size = New System.Drawing.Size(295, 21)
    Me.databaseList.TabIndex = 39
    '
    'label5
    '
    Me.label5.Location = New System.Drawing.Point(12, 96)
    Me.label5.Name = "label5"
    Me.label5.Size = New System.Drawing.Size(63, 16)
    Me.label5.TabIndex = 38
    Me.label5.Text = "Databases"
    '
    'updateBtn
    '
    Me.updateBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.updateBtn.Enabled = False
    Me.updateBtn.Location = New System.Drawing.Point(393, 88)
    Me.updateBtn.Name = "updateBtn"
    Me.updateBtn.Size = New System.Drawing.Size(73, 23)
    Me.updateBtn.TabIndex = 37
    Me.updateBtn.Text = "Update"
    '
    'dataGrid
    '
    Me.dataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dataGrid.DataMember = ""
    Me.dataGrid.Enabled = False
    Me.dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
    Me.dataGrid.Location = New System.Drawing.Point(12, 144)
    Me.dataGrid.Name = "dataGrid"
    Me.dataGrid.Size = New System.Drawing.Size(460, 160)
    Me.dataGrid.TabIndex = 36
    '
    'tables
    '
    Me.tables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.tables.Enabled = False
    Me.tables.Location = New System.Drawing.Point(84, 112)
    Me.tables.Name = "tables"
    Me.tables.Size = New System.Drawing.Size(295, 21)
    Me.tables.TabIndex = 35
    '
    'connectBtn
    '
    Me.connectBtn.Location = New System.Drawing.Point(404, 16)
    Me.connectBtn.Name = "connectBtn"
    Me.connectBtn.Size = New System.Drawing.Size(74, 23)
    Me.connectBtn.TabIndex = 34
    Me.connectBtn.Text = "Connect"
    '
    'password
    '
    Me.password.Location = New System.Drawing.Point(268, 40)
    Me.password.Name = "password"
    Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.password.Size = New System.Drawing.Size(115, 20)
    Me.password.TabIndex = 33
    Me.password.Text = "IntelePro$0319"
    '
    'label3
    '
    Me.label3.Location = New System.Drawing.Point(196, 48)
    Me.label3.Name = "label3"
    Me.label3.Size = New System.Drawing.Size(55, 16)
    Me.label3.TabIndex = 32
    Me.label3.Text = "Password:"
    '
    'userid
    '
    Me.userid.Location = New System.Drawing.Point(60, 40)
    Me.userid.Name = "userid"
    Me.userid.Size = New System.Drawing.Size(119, 20)
    Me.userid.TabIndex = 31
    Me.userid.Text = "intelepros"
    '
    'label2
    '
    Me.label2.Location = New System.Drawing.Point(12, 48)
    Me.label2.Name = "label2"
    Me.label2.Size = New System.Drawing.Size(47, 16)
    Me.label2.TabIndex = 30
    Me.label2.Text = "User Id:"
    '
    'server
    '
    Me.server.Location = New System.Drawing.Point(60, 16)
    Me.server.Name = "server"
    Me.server.Size = New System.Drawing.Size(163, 20)
    Me.server.TabIndex = 29
    Me.server.Text = "xvp-rds.kunnect.com"
    '
    'label1
    '
    Me.label1.Location = New System.Drawing.Point(12, 24)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(47, 16)
    Me.label1.TabIndex = 27
    Me.label1.Text = "Server:"
    '
    'label4
    '
    Me.label4.Location = New System.Drawing.Point(12, 120)
    Me.label4.Name = "label4"
    Me.label4.Size = New System.Drawing.Size(63, 16)
    Me.label4.TabIndex = 28
    Me.label4.Text = "Tables"
    '
    'Frm_MySQL
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(484, 316)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Port)
    Me.Controls.Add(Me.databaseList)
    Me.Controls.Add(Me.label5)
    Me.Controls.Add(Me.updateBtn)
    Me.Controls.Add(Me.dataGrid)
    Me.Controls.Add(Me.tables)
    Me.Controls.Add(Me.connectBtn)
    Me.Controls.Add(Me.password)
    Me.Controls.Add(Me.label3)
    Me.Controls.Add(Me.userid)
    Me.Controls.Add(Me.label2)
    Me.Controls.Add(Me.server)
    Me.Controls.Add(Me.label1)
    Me.Controls.Add(Me.label4)
    Me.Name = "Frm_MySQL"
    Me.Text = "Frm_MySQL"
    CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Port As System.Windows.Forms.TextBox
  Friend WithEvents databaseList As System.Windows.Forms.ComboBox
  Friend WithEvents label5 As System.Windows.Forms.Label
  Friend WithEvents updateBtn As System.Windows.Forms.Button
  Friend WithEvents dataGrid As System.Windows.Forms.DataGrid
  Friend WithEvents tables As System.Windows.Forms.ComboBox
  Friend WithEvents connectBtn As System.Windows.Forms.Button
  Friend WithEvents password As System.Windows.Forms.TextBox
  Friend WithEvents label3 As System.Windows.Forms.Label
  Friend WithEvents userid As System.Windows.Forms.TextBox
  Friend WithEvents label2 As System.Windows.Forms.Label
  Friend WithEvents server As System.Windows.Forms.TextBox
  Friend WithEvents label1 As System.Windows.Forms.Label
  Friend WithEvents label4 As System.Windows.Forms.Label
End Class
