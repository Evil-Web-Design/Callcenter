<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main
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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Main))
    Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
    Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.mnu_Search = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_OpenContact = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_Simple = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnu_Settings = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_Database = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_LocationSettings = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_Employees = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_Log = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_HideMain = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_ResetWindows = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_LogOut = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_Exit = New System.Windows.Forms.ToolStripMenuItem()
    Me.Tip = New System.Windows.Forms.ToolTip(Me.components)
    Me.mnu_Main = New System.Windows.Forms.ToolStrip()
    Me.cmd_Search = New System.Windows.Forms.ToolStripMenuItem()
    Me.cmd_Contact = New System.Windows.Forms.ToolStripSplitButton()
    Me.cmd_Simple = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.cmd_Settings = New System.Windows.Forms.ToolStripMenuItem()
    Me.cmd_Database = New System.Windows.Forms.ToolStripMenuItem()
    Me.cmd_Employees = New System.Windows.Forms.ToolStripMenuItem()
    Me.cmd_LocationSettings = New System.Windows.Forms.ToolStripMenuItem()
    Me.cmd_Log = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_ResetWindows_Main = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_HideMain_Main = New System.Windows.Forms.ToolStripMenuItem()
    Me.cmd_LogOut = New System.Windows.Forms.ToolStripMenuItem()
    Me.cmd_Exit = New System.Windows.Forms.ToolStripMenuItem()
    Me.cmd_SnoopMySQL = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_SnoopMySQL = New System.Windows.Forms.ToolStripMenuItem()
    Me.TrayMenu.SuspendLayout()
    Me.mnu_Main.SuspendLayout()
    Me.SuspendLayout()
    '
    'TrayIcon
    '
    Me.TrayIcon.ContextMenuStrip = Me.TrayMenu
    Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
    Me.TrayIcon.Text = "Call Center"
    Me.TrayIcon.Visible = True
    '
    'TrayMenu
    '
    Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Search, Me.mnu_OpenContact, Me.ToolStripSeparator2, Me.mnu_Settings, Me.mnu_Exit})
    Me.TrayMenu.Name = "TrayMenu"
    Me.TrayMenu.Size = New System.Drawing.Size(154, 120)
    '
    'mnu_Search
    '
    Me.mnu_Search.Image = Global.Intelepros.My.Resources.Resources.magnifier
    Me.mnu_Search.Name = "mnu_Search"
    Me.mnu_Search.Size = New System.Drawing.Size(153, 22)
    Me.mnu_Search.Text = "Search"
    '
    'mnu_OpenContact
    '
    Me.mnu_OpenContact.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Simple})
    Me.mnu_OpenContact.Image = Global.Intelepros.My.Resources.Resources.telephone
    Me.mnu_OpenContact.Name = "mnu_OpenContact"
    Me.mnu_OpenContact.Size = New System.Drawing.Size(153, 22)
    Me.mnu_OpenContact.Text = "Open Contact"
    '
    'mnu_Simple
    '
    Me.mnu_Simple.Image = Global.Intelepros.My.Resources.Resources.user
    Me.mnu_Simple.Name = "mnu_Simple"
    Me.mnu_Simple.Size = New System.Drawing.Size(188, 22)
    Me.mnu_Simple.Text = "Open using Simple UI"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(150, 6)
    '
    'mnu_Settings
    '
    Me.mnu_Settings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Database, Me.mnu_LocationSettings, Me.mnu_Employees, Me.mnu_Log, Me.mnu_HideMain, Me.mnu_ResetWindows, Me.mnu_LogOut, Me.mnu_SnoopMySQL})
    Me.mnu_Settings.Image = Global.Intelepros.My.Resources.Resources.cog
    Me.mnu_Settings.Name = "mnu_Settings"
    Me.mnu_Settings.Size = New System.Drawing.Size(153, 22)
    Me.mnu_Settings.Text = "&Settings"
    '
    'mnu_Database
    '
    Me.mnu_Database.Image = Global.Intelepros.My.Resources.Resources.database_gear
    Me.mnu_Database.Name = "mnu_Database"
    Me.mnu_Database.Size = New System.Drawing.Size(200, 22)
    Me.mnu_Database.Text = "Database"
    '
    'mnu_LocationSettings
    '
    Me.mnu_LocationSettings.Image = Global.Intelepros.My.Resources.Resources.map
    Me.mnu_LocationSettings.Name = "mnu_LocationSettings"
    Me.mnu_LocationSettings.Size = New System.Drawing.Size(200, 22)
    Me.mnu_LocationSettings.Text = "Locations"
    '
    'mnu_Employees
    '
    Me.mnu_Employees.Image = Global.Intelepros.My.Resources.Resources.user_edit
    Me.mnu_Employees.Name = "mnu_Employees"
    Me.mnu_Employees.Size = New System.Drawing.Size(200, 22)
    Me.mnu_Employees.Text = "Employees"
    '
    'mnu_Log
    '
    Me.mnu_Log.Image = Global.Intelepros.My.Resources.Resources.report
    Me.mnu_Log.Name = "mnu_Log"
    Me.mnu_Log.Size = New System.Drawing.Size(200, 22)
    Me.mnu_Log.Text = "Log"
    '
    'mnu_HideMain
    '
    Me.mnu_HideMain.Image = Global.Intelepros.My.Resources.Resources.wrench
    Me.mnu_HideMain.Name = "mnu_HideMain"
    Me.mnu_HideMain.Size = New System.Drawing.Size(200, 22)
    Me.mnu_HideMain.Text = "Hide Menu Window"
    '
    'mnu_ResetWindows
    '
    Me.mnu_ResetWindows.Image = Global.Intelepros.My.Resources.Resources.application
    Me.mnu_ResetWindows.Name = "mnu_ResetWindows"
    Me.mnu_ResetWindows.Size = New System.Drawing.Size(200, 22)
    Me.mnu_ResetWindows.Text = "Reset Window Positions"
    '
    'mnu_LogOut
    '
    Me.mnu_LogOut.Name = "mnu_LogOut"
    Me.mnu_LogOut.Size = New System.Drawing.Size(200, 22)
    Me.mnu_LogOut.Text = "Log Out"
    '
    'mnu_Exit
    '
    Me.mnu_Exit.Image = Global.Intelepros.My.Resources.Resources.Redstop
    Me.mnu_Exit.Name = "mnu_Exit"
    Me.mnu_Exit.Size = New System.Drawing.Size(153, 22)
    Me.mnu_Exit.Text = "Exit Call Center"
    '
    'Tip
    '
    Me.Tip.IsBalloon = True
    Me.Tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
    Me.Tip.ToolTipTitle = "Call Center Information"
    '
    'mnu_Main
    '
    Me.mnu_Main.Dock = System.Windows.Forms.DockStyle.None
    Me.mnu_Main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.mnu_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmd_Search, Me.cmd_Contact, Me.ToolStripSeparator1, Me.cmd_Settings, Me.cmd_Exit})
    Me.mnu_Main.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
    Me.mnu_Main.Location = New System.Drawing.Point(0, 0)
    Me.mnu_Main.Name = "mnu_Main"
    Me.mnu_Main.Size = New System.Drawing.Size(115, 91)
    Me.mnu_Main.TabIndex = 1
    Me.mnu_Main.Text = "ToolStrip1"
    '
    'cmd_Search
    '
    Me.cmd_Search.Image = Global.Intelepros.My.Resources.Resources.magnifier
    Me.cmd_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmd_Search.Name = "cmd_Search"
    Me.cmd_Search.Size = New System.Drawing.Size(113, 20)
    Me.cmd_Search.Text = "Search"
    '
    'cmd_Contact
    '
    Me.cmd_Contact.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmd_Simple})
    Me.cmd_Contact.Image = Global.Intelepros.My.Resources.Resources.telephone
    Me.cmd_Contact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmd_Contact.Name = "cmd_Contact"
    Me.cmd_Contact.Size = New System.Drawing.Size(113, 20)
    Me.cmd_Contact.Text = "Next &Call"
    '
    'cmd_Simple
    '
    Me.cmd_Simple.Image = Global.Intelepros.My.Resources.Resources.user
    Me.cmd_Simple.Name = "cmd_Simple"
    Me.cmd_Simple.Size = New System.Drawing.Size(188, 22)
    Me.cmd_Simple.Text = "Open using Simple UI"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(113, 6)
    '
    'cmd_Settings
    '
    Me.cmd_Settings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmd_Database, Me.cmd_Employees, Me.cmd_LocationSettings, Me.cmd_Log, Me.mnu_ResetWindows_Main, Me.mnu_HideMain_Main, Me.cmd_LogOut, Me.cmd_SnoopMySQL})
    Me.cmd_Settings.Image = Global.Intelepros.My.Resources.Resources.cog
    Me.cmd_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmd_Settings.Name = "cmd_Settings"
    Me.cmd_Settings.Size = New System.Drawing.Size(113, 20)
    Me.cmd_Settings.Text = "&Settings"
    '
    'cmd_Database
    '
    Me.cmd_Database.Image = Global.Intelepros.My.Resources.Resources.database_gear
    Me.cmd_Database.Name = "cmd_Database"
    Me.cmd_Database.Size = New System.Drawing.Size(200, 22)
    Me.cmd_Database.Text = "Database"
    '
    'cmd_Employees
    '
    Me.cmd_Employees.Image = Global.Intelepros.My.Resources.Resources.user_edit
    Me.cmd_Employees.Name = "cmd_Employees"
    Me.cmd_Employees.Size = New System.Drawing.Size(200, 22)
    Me.cmd_Employees.Text = "Employees"
    '
    'cmd_LocationSettings
    '
    Me.cmd_LocationSettings.Image = Global.Intelepros.My.Resources.Resources.map
    Me.cmd_LocationSettings.Name = "cmd_LocationSettings"
    Me.cmd_LocationSettings.Size = New System.Drawing.Size(200, 22)
    Me.cmd_LocationSettings.Text = "Locations"
    '
    'cmd_Log
    '
    Me.cmd_Log.Image = Global.Intelepros.My.Resources.Resources.report
    Me.cmd_Log.Name = "cmd_Log"
    Me.cmd_Log.Size = New System.Drawing.Size(200, 22)
    Me.cmd_Log.Text = "Log"
    '
    'mnu_ResetWindows_Main
    '
    Me.mnu_ResetWindows_Main.Image = Global.Intelepros.My.Resources.Resources.application
    Me.mnu_ResetWindows_Main.Name = "mnu_ResetWindows_Main"
    Me.mnu_ResetWindows_Main.Size = New System.Drawing.Size(200, 22)
    Me.mnu_ResetWindows_Main.Text = "Reset Window Positions"
    '
    'mnu_HideMain_Main
    '
    Me.mnu_HideMain_Main.Image = Global.Intelepros.My.Resources.Resources.wrench
    Me.mnu_HideMain_Main.Name = "mnu_HideMain_Main"
    Me.mnu_HideMain_Main.Size = New System.Drawing.Size(200, 22)
    Me.mnu_HideMain_Main.Text = "Hide Menu Window"
    '
    'cmd_LogOut
    '
    Me.cmd_LogOut.Name = "cmd_LogOut"
    Me.cmd_LogOut.Size = New System.Drawing.Size(200, 22)
    Me.cmd_LogOut.Text = "Log Out"
    '
    'cmd_Exit
    '
    Me.cmd_Exit.Image = Global.Intelepros.My.Resources.Resources.Redstop
    Me.cmd_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmd_Exit.Name = "cmd_Exit"
    Me.cmd_Exit.Size = New System.Drawing.Size(113, 20)
    Me.cmd_Exit.Text = "Exit Call Center"
    '
    'cmd_SnoopMySQL
    '
    Me.cmd_SnoopMySQL.Name = "cmd_SnoopMySQL"
    Me.cmd_SnoopMySQL.Size = New System.Drawing.Size(200, 22)
    Me.cmd_SnoopMySQL.Text = "Snoop MySQL"
    Me.cmd_SnoopMySQL.Visible = False
    '
    'mnu_SnoopMySQL
    '
    Me.mnu_SnoopMySQL.Name = "mnu_SnoopMySQL"
    Me.mnu_SnoopMySQL.Size = New System.Drawing.Size(200, 22)
    Me.mnu_SnoopMySQL.Text = "Snoop MySQL"
    '
    'Frm_Main
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(111, 90)
    Me.ControlBox = False
    Me.Controls.Add(Me.mnu_Main)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "Frm_Main"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
    Me.Text = "Call Center"
    Me.TopMost = True
    Me.TrayMenu.ResumeLayout(False)
    Me.mnu_Main.ResumeLayout(False)
    Me.mnu_Main.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TrayIcon As System.Windows.Forms.NotifyIcon
  Friend WithEvents TrayMenu As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents mnu_Search As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_OpenContact As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnu_Exit As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents Tip As System.Windows.Forms.ToolTip
  Friend WithEvents mnu_Settings As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_Database As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_Employees As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_Log As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_Main As System.Windows.Forms.ToolStrip
  Friend WithEvents cmd_Search As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents cmd_Settings As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cmd_Database As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cmd_Employees As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cmd_Log As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cmd_Exit As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_ResetWindows As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_HideMain As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_HideMain_Main As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_ResetWindows_Main As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cmd_LocationSettings As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_LocationSettings As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cmd_Contact As System.Windows.Forms.ToolStripSplitButton
  Friend WithEvents cmd_Simple As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_Simple As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_LogOut As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cmd_LogOut As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_SnoopMySQL As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cmd_SnoopMySQL As System.Windows.Forms.ToolStripMenuItem

End Class
