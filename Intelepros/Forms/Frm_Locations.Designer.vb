<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Locations
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
    Me.cbo_Location = New System.Windows.Forms.ComboBox()
    Me.HelpMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.WhatsThisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ReportAnIssueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.tbl_Location = New System.Windows.Forms.TableLayoutPanel()
    Me.cbo_Confirm = New System.Windows.Forms.ComboBox()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txt_Location = New System.Windows.Forms.TextBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.cbo_City = New System.Windows.Forms.ComboBox()
    Me.ck_LocEnabled = New System.Windows.Forms.CheckBox()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.mnu_ToolStrip = New System.Windows.Forms.ToolStrip()
    Me.mnu_Location = New System.Windows.Forms.ToolStripSplitButton()
    Me.mnu_AddNewLocation = New System.Windows.Forms.ToolStripMenuItem()
    Me.EditCitysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_Promo = New System.Windows.Forms.ToolStripButton()
    Me.mnu_Content = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
    Me.StatusStrip = New System.Windows.Forms.StatusStrip()
    Me.lbl_Status = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tbl_ContentEdit = New System.Windows.Forms.TableLayoutPanel()
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.mnu_RTF_Save = New System.Windows.Forms.ToolStripButton()
    Me.cbo_ContentFiles = New System.Windows.Forms.ToolStripComboBox()
    Me.mnu_RTF_DeleteMenu = New System.Windows.Forms.ToolStripDropDownButton()
    Me.DeleteCurrentFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripButton2 = New System.Windows.Forms.ToolStripDropDownButton()
    Me.mnu_ImportFile = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    Me.RichTextBox = New System.Windows.Forms.RichTextBox()
    Me.mnu_RTF = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.mnu_RTF_Cut = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_RTF_Copy = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_RTF_Paste = New System.Windows.Forms.ToolStripMenuItem()
    Me.lst_Clip = New System.Windows.Forms.ListBox()
    Me.tbl_PromoSettings = New System.Windows.Forms.TableLayoutPanel()
    Me.FocusIt = New System.Windows.Forms.Button()
    Me.tbl_LocationSettings = New System.Windows.Forms.TableLayoutPanel()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.tbl_StatusEdit = New System.Windows.Forms.TableLayoutPanel()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.ComboBox1 = New System.Windows.Forms.ComboBox()
    Me.lst_AccessLevel = New System.Windows.Forms.ListBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.tbl_Calendar = New System.Windows.Forms.TableLayoutPanel()
    Me.cmd_EditOpenDates = New System.Windows.Forms.Button()
    Me.Grid_Results = New System.Windows.Forms.DataGridView()
    Me.tbl_MainLoc = New System.Windows.Forms.TableLayoutPanel()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.lst_StatusBranch = New System.Windows.Forms.ListBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.cbo_Status = New System.Windows.Forms.ComboBox()
    Me.cmd_DeleteLocStatus = New System.Windows.Forms.Button()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.ck_AlwaysVis = New System.Windows.Forms.CheckBox()
    Me.cbo_NewStatus = New System.Windows.Forms.ComboBox()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.HelpMenu.SuspendLayout()
    Me.tbl_Location.SuspendLayout()
    Me.mnu_ToolStrip.SuspendLayout()
    Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
    Me.ToolStripContainer1.ContentPanel.SuspendLayout()
    Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
    Me.ToolStripContainer1.SuspendLayout()
    Me.StatusStrip.SuspendLayout()
    Me.tbl_ContentEdit.SuspendLayout()
    Me.ToolStrip1.SuspendLayout()
    Me.mnu_RTF.SuspendLayout()
    Me.tbl_LocationSettings.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.tbl_StatusEdit.SuspendLayout()
    Me.tbl_Calendar.SuspendLayout()
    CType(Me.Grid_Results, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.tbl_MainLoc.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.SuspendLayout()
    '
    'cbo_Location
    '
    Me.cbo_Location.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbo_Location.CausesValidation = False
    Me.cbo_Location.ContextMenuStrip = Me.HelpMenu
    Me.cbo_Location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_Location.IntegralHeight = False
    Me.cbo_Location.Location = New System.Drawing.Point(63, 1)
    Me.cbo_Location.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
    Me.cbo_Location.Name = "cbo_Location"
    Me.cbo_Location.Size = New System.Drawing.Size(190, 21)
    Me.cbo_Location.TabIndex = 19
    '
    'HelpMenu
    '
    Me.HelpMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WhatsThisToolStripMenuItem, Me.ReportAnIssueToolStripMenuItem})
    Me.HelpMenu.Name = "ContextMenuStrip1"
    Me.HelpMenu.Size = New System.Drawing.Size(155, 48)
    '
    'WhatsThisToolStripMenuItem
    '
    Me.WhatsThisToolStripMenuItem.Image = Global.Intelepros.My.Resources.Resources.dialog_question
    Me.WhatsThisToolStripMenuItem.Name = "WhatsThisToolStripMenuItem"
    Me.WhatsThisToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
    Me.WhatsThisToolStripMenuItem.Text = "Whats This"
    '
    'ReportAnIssueToolStripMenuItem
    '
    Me.ReportAnIssueToolStripMenuItem.Image = Global.Intelepros.My.Resources.Resources.bug
    Me.ReportAnIssueToolStripMenuItem.Name = "ReportAnIssueToolStripMenuItem"
    Me.ReportAnIssueToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
    Me.ReportAnIssueToolStripMenuItem.Text = "Report an issue"
    '
    'tbl_Location
    '
    Me.tbl_Location.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.tbl_Location.BackColor = System.Drawing.SystemColors.Control
    Me.tbl_Location.ColumnCount = 2
    Me.tbl_Location.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
    Me.tbl_Location.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.tbl_Location.Controls.Add(Me.cbo_Confirm, 1, 2)
    Me.tbl_Location.Controls.Add(Me.Label13, 0, 2)
    Me.tbl_Location.Controls.Add(Me.Label1, 0, 0)
    Me.tbl_Location.Controls.Add(Me.txt_Location, 1, 0)
    Me.tbl_Location.Controls.Add(Me.Label7, 0, 1)
    Me.tbl_Location.Controls.Add(Me.cbo_City, 1, 1)
    Me.tbl_Location.Controls.Add(Me.ck_LocEnabled, 1, 3)
    Me.tbl_Location.Location = New System.Drawing.Point(3, 33)
    Me.tbl_Location.Name = "tbl_Location"
    Me.tbl_Location.RowCount = 4
    Me.tbl_Location.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.tbl_Location.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.tbl_Location.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.tbl_Location.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.tbl_Location.Size = New System.Drawing.Size(256, 102)
    Me.tbl_Location.TabIndex = 20
    '
    'cbo_Confirm
    '
    Me.cbo_Confirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbo_Confirm.CausesValidation = False
    Me.cbo_Confirm.ContextMenuStrip = Me.HelpMenu
    Me.cbo_Confirm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_Confirm.IntegralHeight = False
    Me.cbo_Confirm.Location = New System.Drawing.Point(55, 52)
    Me.cbo_Confirm.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
    Me.cbo_Confirm.Name = "cbo_Confirm"
    Me.cbo_Confirm.Size = New System.Drawing.Size(198, 21)
    Me.cbo_Confirm.TabIndex = 25
    '
    'Label13
    '
    Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label13.AutoSize = True
    Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label13.Location = New System.Drawing.Point(3, 55)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(46, 15)
    Me.Label13.TabIndex = 25
    Me.Label13.Text = "Confirm"
    Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label1
    '
    Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(3, 5)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(46, 15)
    Me.Label1.TabIndex = 22
    Me.Label1.Text = "Name"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'txt_Location
    '
    Me.txt_Location.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_Location.ContextMenuStrip = Me.HelpMenu
    Me.txt_Location.Location = New System.Drawing.Point(55, 3)
    Me.txt_Location.Name = "txt_Location"
    Me.txt_Location.Size = New System.Drawing.Size(198, 20)
    Me.txt_Location.TabIndex = 36
    '
    'Label7
    '
    Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label7.AutoSize = True
    Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(3, 30)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(46, 15)
    Me.Label7.TabIndex = 24
    Me.Label7.Text = "City"
    Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'cbo_City
    '
    Me.cbo_City.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbo_City.CausesValidation = False
    Me.cbo_City.ContextMenuStrip = Me.HelpMenu
    Me.cbo_City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_City.IntegralHeight = False
    Me.cbo_City.Location = New System.Drawing.Point(55, 27)
    Me.cbo_City.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
    Me.cbo_City.Name = "cbo_City"
    Me.cbo_City.Size = New System.Drawing.Size(198, 21)
    Me.cbo_City.TabIndex = 24
    '
    'ck_LocEnabled
    '
    Me.ck_LocEnabled.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ck_LocEnabled.ContextMenuStrip = Me.HelpMenu
    Me.ck_LocEnabled.Location = New System.Drawing.Point(55, 78)
    Me.ck_LocEnabled.Name = "ck_LocEnabled"
    Me.ck_LocEnabled.Size = New System.Drawing.Size(198, 19)
    Me.ck_LocEnabled.TabIndex = 24
    Me.ck_LocEnabled.Text = "Enabled"
    Me.ck_LocEnabled.UseVisualStyleBackColor = True
    '
    'Label11
    '
    Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label11.AutoSize = True
    Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label11.Location = New System.Drawing.Point(3, 4)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(54, 15)
    Me.Label11.TabIndex = 21
    Me.Label11.Text = "Location"
    Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'mnu_ToolStrip
    '
    Me.mnu_ToolStrip.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.mnu_ToolStrip.Dock = System.Windows.Forms.DockStyle.None
    Me.mnu_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.mnu_ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Location, Me.mnu_Promo, Me.mnu_Content})
    Me.mnu_ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
    Me.mnu_ToolStrip.Location = New System.Drawing.Point(0, 0)
    Me.mnu_ToolStrip.Name = "mnu_ToolStrip"
    Me.mnu_ToolStrip.Padding = New System.Windows.Forms.Padding(0)
    Me.mnu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
    Me.mnu_ToolStrip.Size = New System.Drawing.Size(1179, 25)
    Me.mnu_ToolStrip.Stretch = True
    Me.mnu_ToolStrip.TabIndex = 21
    Me.mnu_ToolStrip.Text = "ToolStrip1"
    '
    'mnu_Location
    '
    Me.mnu_Location.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_AddNewLocation, Me.EditCitysToolStripMenuItem})
    Me.mnu_Location.Image = Global.Intelepros.My.Resources.Resources.map
    Me.mnu_Location.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.mnu_Location.Name = "mnu_Location"
    Me.mnu_Location.Size = New System.Drawing.Size(90, 22)
    Me.mnu_Location.Text = "&Locations"
    '
    'mnu_AddNewLocation
    '
    Me.mnu_AddNewLocation.Image = Global.Intelepros.My.Resources.Resources.map_add
    Me.mnu_AddNewLocation.Name = "mnu_AddNewLocation"
    Me.mnu_AddNewLocation.Size = New System.Drawing.Size(172, 22)
    Me.mnu_AddNewLocation.Text = "Add New Location"
    '
    'EditCitysToolStripMenuItem
    '
    Me.EditCitysToolStripMenuItem.Name = "EditCitysToolStripMenuItem"
    Me.EditCitysToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
    Me.EditCitysToolStripMenuItem.Text = "Edit Citys"
    '
    'mnu_Promo
    '
    Me.mnu_Promo.Image = Global.Intelepros.My.Resources.Resources.email
    Me.mnu_Promo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.mnu_Promo.Name = "mnu_Promo"
    Me.mnu_Promo.Size = New System.Drawing.Size(89, 22)
    Me.mnu_Promo.Text = "&Promotions"
    '
    'mnu_Content
    '
    Me.mnu_Content.Image = Global.Intelepros.My.Resources.Resources.page_edit
    Me.mnu_Content.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.mnu_Content.Name = "mnu_Content"
    Me.mnu_Content.Size = New System.Drawing.Size(70, 22)
    Me.mnu_Content.Text = "Content"
    '
    'ToolStripContainer1
    '
    '
    'ToolStripContainer1.BottomToolStripPanel
    '
    Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.StatusStrip)
    '
    'ToolStripContainer1.ContentPanel
    '
    Me.ToolStripContainer1.ContentPanel.BackColor = System.Drawing.SystemColors.AppWorkspace
    Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.tbl_ContentEdit)
    Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.tbl_PromoSettings)
    Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.FocusIt)
    Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.tbl_LocationSettings)
    Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1179, 568)
    Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStripContainer1.Name = "ToolStripContainer1"
    Me.ToolStripContainer1.Size = New System.Drawing.Size(1179, 615)
    Me.ToolStripContainer1.TabIndex = 22
    Me.ToolStripContainer1.Text = "ToolStripContainer1"
    '
    'ToolStripContainer1.TopToolStripPanel
    '
    Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.mnu_ToolStrip)
    '
    'StatusStrip
    '
    Me.StatusStrip.AutoSize = False
    Me.StatusStrip.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.StatusStrip.Dock = System.Windows.Forms.DockStyle.None
    Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_Status})
    Me.StatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
    Me.StatusStrip.Location = New System.Drawing.Point(0, 0)
    Me.StatusStrip.Name = "StatusStrip"
    Me.StatusStrip.Size = New System.Drawing.Size(1179, 22)
    Me.StatusStrip.TabIndex = 23
    '
    'lbl_Status
    '
    Me.lbl_Status.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.lbl_Status.Name = "lbl_Status"
    Me.lbl_Status.Size = New System.Drawing.Size(35, 17)
    Me.lbl_Status.Text = "Done"
    '
    'tbl_ContentEdit
    '
    Me.tbl_ContentEdit.BackColor = System.Drawing.SystemColors.Control
    Me.tbl_ContentEdit.ColumnCount = 2
    Me.tbl_ContentEdit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.tbl_ContentEdit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
    Me.tbl_ContentEdit.Controls.Add(Me.ToolStrip1, 0, 0)
    Me.tbl_ContentEdit.Controls.Add(Me.RichTextBox, 0, 1)
    Me.tbl_ContentEdit.Controls.Add(Me.lst_Clip, 1, 2)
    Me.tbl_ContentEdit.Location = New System.Drawing.Point(542, 13)
    Me.tbl_ContentEdit.Margin = New System.Windows.Forms.Padding(0)
    Me.tbl_ContentEdit.Name = "tbl_ContentEdit"
    Me.tbl_ContentEdit.RowCount = 3
    Me.tbl_ContentEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.tbl_ContentEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.tbl_ContentEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.tbl_ContentEdit.Size = New System.Drawing.Size(458, 415)
    Me.tbl_ContentEdit.TabIndex = 24
    Me.tbl_ContentEdit.Visible = False
    '
    'ToolStrip1
    '
    Me.tbl_ContentEdit.SetColumnSpan(Me.ToolStrip1, 2)
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_RTF_Save, Me.cbo_ContentFiles, Me.mnu_RTF_DeleteMenu, Me.ToolStripButton2, Me.ToolStripLabel1})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(458, 25)
    Me.ToolStrip1.TabIndex = 1
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'mnu_RTF_Save
    '
    Me.mnu_RTF_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.mnu_RTF_Save.Image = Global.Intelepros.My.Resources.Resources.disk
    Me.mnu_RTF_Save.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.mnu_RTF_Save.Name = "mnu_RTF_Save"
    Me.mnu_RTF_Save.Size = New System.Drawing.Size(23, 22)
    Me.mnu_RTF_Save.Text = "ToolStripButton1"
    Me.mnu_RTF_Save.ToolTipText = "Save"
    '
    'cbo_ContentFiles
    '
    Me.cbo_ContentFiles.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.cbo_ContentFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_ContentFiles.Name = "cbo_ContentFiles"
    Me.cbo_ContentFiles.Size = New System.Drawing.Size(300, 25)
    '
    'mnu_RTF_DeleteMenu
    '
    Me.mnu_RTF_DeleteMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.mnu_RTF_DeleteMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteCurrentFileToolStripMenuItem})
    Me.mnu_RTF_DeleteMenu.Image = Global.Intelepros.My.Resources.Resources.cross
    Me.mnu_RTF_DeleteMenu.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.mnu_RTF_DeleteMenu.Name = "mnu_RTF_DeleteMenu"
    Me.mnu_RTF_DeleteMenu.Size = New System.Drawing.Size(29, 22)
    Me.mnu_RTF_DeleteMenu.Text = "ToolStripButton1"
    '
    'DeleteCurrentFileToolStripMenuItem
    '
    Me.DeleteCurrentFileToolStripMenuItem.Image = Global.Intelepros.My.Resources.Resources.page_delete
    Me.DeleteCurrentFileToolStripMenuItem.Name = "DeleteCurrentFileToolStripMenuItem"
    Me.DeleteCurrentFileToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
    Me.DeleteCurrentFileToolStripMenuItem.Text = "Delete Current File"
    '
    'ToolStripButton2
    '
    Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_ImportFile})
    Me.ToolStripButton2.Image = Global.Intelepros.My.Resources.Resources.add
    Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripButton2.Name = "ToolStripButton2"
    Me.ToolStripButton2.Size = New System.Drawing.Size(29, 22)
    Me.ToolStripButton2.Text = "ToolStripButton2"
    '
    'mnu_ImportFile
    '
    Me.mnu_ImportFile.Image = Global.Intelepros.My.Resources.Resources.page_add
    Me.mnu_ImportFile.Name = "mnu_ImportFile"
    Me.mnu_ImportFile.Size = New System.Drawing.Size(135, 22)
    Me.mnu_ImportFile.Text = "Import Text"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(25, 22)
    Me.ToolStripLabel1.Text = "File"
    '
    'RichTextBox
    '
    Me.RichTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.RichTextBox.ContextMenuStrip = Me.mnu_RTF
    Me.RichTextBox.Location = New System.Drawing.Point(3, 28)
    Me.RichTextBox.Name = "RichTextBox"
    Me.tbl_ContentEdit.SetRowSpan(Me.RichTextBox, 2)
    Me.RichTextBox.Size = New System.Drawing.Size(305, 384)
    Me.RichTextBox.TabIndex = 0
    Me.RichTextBox.Text = ""
    '
    'mnu_RTF
    '
    Me.mnu_RTF.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_RTF_Cut, Me.mnu_RTF_Copy, Me.mnu_RTF_Paste})
    Me.mnu_RTF.Name = "mnu_RTF"
    Me.mnu_RTF.Size = New System.Drawing.Size(103, 70)
    '
    'mnu_RTF_Cut
    '
    Me.mnu_RTF_Cut.Name = "mnu_RTF_Cut"
    Me.mnu_RTF_Cut.Size = New System.Drawing.Size(102, 22)
    Me.mnu_RTF_Cut.Text = "Cut"
    '
    'mnu_RTF_Copy
    '
    Me.mnu_RTF_Copy.Name = "mnu_RTF_Copy"
    Me.mnu_RTF_Copy.Size = New System.Drawing.Size(102, 22)
    Me.mnu_RTF_Copy.Text = "Copy"
    '
    'mnu_RTF_Paste
    '
    Me.mnu_RTF_Paste.Name = "mnu_RTF_Paste"
    Me.mnu_RTF_Paste.Size = New System.Drawing.Size(102, 22)
    Me.mnu_RTF_Paste.Text = "Paste"
    '
    'lst_Clip
    '
    Me.lst_Clip.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lst_Clip.FormattingEnabled = True
    Me.lst_Clip.IntegralHeight = False
    Me.lst_Clip.Location = New System.Drawing.Point(314, 53)
    Me.lst_Clip.Name = "lst_Clip"
    Me.lst_Clip.Size = New System.Drawing.Size(141, 359)
    Me.lst_Clip.TabIndex = 2
    '
    'tbl_PromoSettings
    '
    Me.tbl_PromoSettings.BackColor = System.Drawing.SystemColors.Control
    Me.tbl_PromoSettings.ColumnCount = 1
    Me.tbl_PromoSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.tbl_PromoSettings.Location = New System.Drawing.Point(139, 391)
    Me.tbl_PromoSettings.Name = "tbl_PromoSettings"
    Me.tbl_PromoSettings.RowCount = 1
    Me.tbl_PromoSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.tbl_PromoSettings.Size = New System.Drawing.Size(458, 415)
    Me.tbl_PromoSettings.TabIndex = 23
    Me.tbl_PromoSettings.Visible = False
    '
    'FocusIt
    '
    Me.FocusIt.Location = New System.Drawing.Point(12, 448)
    Me.FocusIt.Name = "FocusIt"
    Me.FocusIt.Size = New System.Drawing.Size(121, 25)
    Me.FocusIt.TabIndex = 22
    Me.FocusIt.Text = "Bam! FocusIt!"
    Me.FocusIt.UseVisualStyleBackColor = True
    '
    'tbl_LocationSettings
    '
    Me.tbl_LocationSettings.BackColor = System.Drawing.SystemColors.Control
    Me.tbl_LocationSettings.ColumnCount = 2
    Me.tbl_LocationSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.tbl_LocationSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.tbl_LocationSettings.Controls.Add(Me.Panel1, 1, 0)
    Me.tbl_LocationSettings.Controls.Add(Me.tbl_MainLoc, 0, 0)
    Me.tbl_LocationSettings.Location = New System.Drawing.Point(0, 0)
    Me.tbl_LocationSettings.Name = "tbl_LocationSettings"
    Me.tbl_LocationSettings.RowCount = 1
    Me.tbl_LocationSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 367.0!))
    Me.tbl_LocationSettings.Size = New System.Drawing.Size(536, 367)
    Me.tbl_LocationSettings.TabIndex = 21
    Me.tbl_LocationSettings.Visible = False
    '
    'Panel1
    '
    Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel1.Controls.Add(Me.tbl_StatusEdit)
    Me.Panel1.Controls.Add(Me.tbl_Calendar)
    Me.Panel1.Location = New System.Drawing.Point(271, 3)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(262, 361)
    Me.Panel1.TabIndex = 37
    '
    'tbl_StatusEdit
    '
    Me.tbl_StatusEdit.ColumnCount = 2
    Me.tbl_StatusEdit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
    Me.tbl_StatusEdit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.tbl_StatusEdit.Controls.Add(Me.Label12, 0, 5)
    Me.tbl_StatusEdit.Controls.Add(Me.Label10, 0, 4)
    Me.tbl_StatusEdit.Controls.Add(Me.ComboBox1, 1, 0)
    Me.tbl_StatusEdit.Controls.Add(Me.lst_AccessLevel, 1, 1)
    Me.tbl_StatusEdit.Controls.Add(Me.Label5, 0, 0)
    Me.tbl_StatusEdit.Controls.Add(Me.Label8, 0, 2)
    Me.tbl_StatusEdit.Controls.Add(Me.Label9, 0, 3)
    Me.tbl_StatusEdit.Controls.Add(Me.Label6, 0, 1)
    Me.tbl_StatusEdit.Location = New System.Drawing.Point(17, 156)
    Me.tbl_StatusEdit.Name = "tbl_StatusEdit"
    Me.tbl_StatusEdit.RowCount = 6
    Me.tbl_StatusEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.tbl_StatusEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.tbl_StatusEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.tbl_StatusEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.tbl_StatusEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.tbl_StatusEdit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.tbl_StatusEdit.Size = New System.Drawing.Size(245, 177)
    Me.tbl_StatusEdit.TabIndex = 38
    '
    'Label12
    '
    Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label12.AutoSize = True
    Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.Location = New System.Drawing.Point(3, 157)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(51, 15)
    Me.Label12.TabIndex = 33
    Me.Label12.Text = "NQ"
    Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label10
    '
    Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label10.AutoSize = True
    Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label10.Location = New System.Drawing.Point(3, 132)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(51, 15)
    Me.Label10.TabIndex = 32
    Me.Label10.Text = "Lock"
    Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'ComboBox1
    '
    Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ComboBox1.CausesValidation = False
    Me.ComboBox1.ContextMenuStrip = Me.HelpMenu
    Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBox1.IntegralHeight = False
    Me.ComboBox1.Location = New System.Drawing.Point(60, 2)
    Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
    Me.ComboBox1.Name = "ComboBox1"
    Me.ComboBox1.Size = New System.Drawing.Size(182, 21)
    Me.ComboBox1.TabIndex = 27
    '
    'lst_AccessLevel
    '
    Me.lst_AccessLevel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lst_AccessLevel.ContextMenuStrip = Me.HelpMenu
    Me.lst_AccessLevel.FormattingEnabled = True
    Me.lst_AccessLevel.IntegralHeight = False
    Me.lst_AccessLevel.Location = New System.Drawing.Point(60, 28)
    Me.lst_AccessLevel.Name = "lst_AccessLevel"
    Me.lst_AccessLevel.ScrollAlwaysVisible = True
    Me.lst_AccessLevel.Size = New System.Drawing.Size(182, 46)
    Me.lst_AccessLevel.TabIndex = 26
    '
    'Label5
    '
    Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(3, 5)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(51, 15)
    Me.Label5.TabIndex = 28
    Me.Label5.Text = "Status"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label8
    '
    Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label8.AutoSize = True
    Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.Location = New System.Drawing.Point(3, 82)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(51, 15)
    Me.Label8.TabIndex = 30
    Me.Label8.Text = "Booking"
    Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label9
    '
    Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label9.AutoSize = True
    Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label9.Location = New System.Drawing.Point(3, 107)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(51, 15)
    Me.Label9.TabIndex = 31
    Me.Label9.Text = "Confirm"
    Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label6
    '
    Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(3, 28)
    Me.Label6.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(51, 15)
    Me.Label6.TabIndex = 33
    Me.Label6.Text = "Access"
    Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'tbl_Calendar
    '
    Me.tbl_Calendar.ColumnCount = 2
    Me.tbl_Calendar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
    Me.tbl_Calendar.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.tbl_Calendar.Controls.Add(Me.cmd_EditOpenDates, 0, 0)
    Me.tbl_Calendar.Controls.Add(Me.Grid_Results, 0, 1)
    Me.tbl_Calendar.Location = New System.Drawing.Point(11, 7)
    Me.tbl_Calendar.Name = "tbl_Calendar"
    Me.tbl_Calendar.RowCount = 2
    Me.tbl_Calendar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
    Me.tbl_Calendar.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.tbl_Calendar.Size = New System.Drawing.Size(248, 126)
    Me.tbl_Calendar.TabIndex = 37
    '
    'cmd_EditOpenDates
    '
    Me.cmd_EditOpenDates.Anchor = System.Windows.Forms.AnchorStyles.Top
    Me.tbl_Calendar.SetColumnSpan(Me.cmd_EditOpenDates, 2)
    Me.cmd_EditOpenDates.ContextMenuStrip = Me.HelpMenu
    Me.cmd_EditOpenDates.Image = Global.Intelepros.My.Resources.Resources.calendar
    Me.cmd_EditOpenDates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmd_EditOpenDates.Location = New System.Drawing.Point(83, 3)
    Me.cmd_EditOpenDates.Name = "cmd_EditOpenDates"
    Me.cmd_EditOpenDates.Size = New System.Drawing.Size(81, 22)
    Me.cmd_EditOpenDates.TabIndex = 37
    Me.cmd_EditOpenDates.Text = "New Date"
    Me.cmd_EditOpenDates.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.cmd_EditOpenDates.UseVisualStyleBackColor = True
    '
    'Grid_Results
    '
    Me.Grid_Results.AllowUserToAddRows = False
    Me.Grid_Results.AllowUserToDeleteRows = False
    Me.Grid_Results.AllowUserToResizeColumns = False
    Me.Grid_Results.AllowUserToResizeRows = False
    Me.Grid_Results.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Grid_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.tbl_Calendar.SetColumnSpan(Me.Grid_Results, 2)
    Me.Grid_Results.ContextMenuStrip = Me.HelpMenu
    Me.Grid_Results.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.Grid_Results.Location = New System.Drawing.Point(3, 31)
    Me.Grid_Results.MultiSelect = False
    Me.Grid_Results.Name = "Grid_Results"
    Me.Grid_Results.RowHeadersVisible = False
    Me.Grid_Results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.Grid_Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.Grid_Results.Size = New System.Drawing.Size(242, 92)
    Me.Grid_Results.TabIndex = 23
    '
    'tbl_MainLoc
    '
    Me.tbl_MainLoc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.tbl_MainLoc.ColumnCount = 1
    Me.tbl_MainLoc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.tbl_MainLoc.Controls.Add(Me.TableLayoutPanel1, 0, 2)
    Me.tbl_MainLoc.Controls.Add(Me.tbl_Location, 0, 1)
    Me.tbl_MainLoc.Controls.Add(Me.TableLayoutPanel3, 0, 0)
    Me.tbl_MainLoc.Location = New System.Drawing.Point(3, 3)
    Me.tbl_MainLoc.Name = "tbl_MainLoc"
    Me.tbl_MainLoc.RowCount = 3
    Me.tbl_MainLoc.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
    Me.tbl_MainLoc.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
    Me.tbl_MainLoc.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.tbl_MainLoc.Size = New System.Drawing.Size(262, 361)
    Me.tbl_MainLoc.TabIndex = 38
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.lst_StatusBranch, 1, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.cbo_Status, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.cmd_DeleteLocStatus, 1, 3)
    Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 4)
    Me.TableLayoutPanel1.Controls.Add(Me.ck_AlwaysVis, 1, 2)
    Me.TableLayoutPanel1.Controls.Add(Me.cbo_NewStatus, 1, 4)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 141)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 5
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(256, 217)
    Me.TableLayoutPanel1.TabIndex = 36
    '
    'lst_StatusBranch
    '
    Me.lst_StatusBranch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lst_StatusBranch.ContextMenuStrip = Me.HelpMenu
    Me.lst_StatusBranch.FormattingEnabled = True
    Me.lst_StatusBranch.IntegralHeight = False
    Me.lst_StatusBranch.Location = New System.Drawing.Point(53, 28)
    Me.lst_StatusBranch.Name = "lst_StatusBranch"
    Me.lst_StatusBranch.ScrollAlwaysVisible = True
    Me.lst_StatusBranch.Size = New System.Drawing.Size(200, 111)
    Me.lst_StatusBranch.TabIndex = 25
    '
    'Label3
    '
    Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(3, 28)
    Me.Label3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(44, 15)
    Me.Label3.TabIndex = 24
    Me.Label3.Text = "Branch"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label2
    '
    Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(3, 5)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(44, 15)
    Me.Label2.TabIndex = 23
    Me.Label2.Text = "Status"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'cbo_Status
    '
    Me.cbo_Status.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbo_Status.CausesValidation = False
    Me.cbo_Status.ContextMenuStrip = Me.HelpMenu
    Me.cbo_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_Status.IntegralHeight = False
    Me.cbo_Status.Location = New System.Drawing.Point(53, 2)
    Me.cbo_Status.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
    Me.cbo_Status.Name = "cbo_Status"
    Me.cbo_Status.Size = New System.Drawing.Size(200, 21)
    Me.cbo_Status.TabIndex = 19
    '
    'cmd_DeleteLocStatus
    '
    Me.cmd_DeleteLocStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmd_DeleteLocStatus.ContextMenuStrip = Me.HelpMenu
    Me.cmd_DeleteLocStatus.Location = New System.Drawing.Point(53, 167)
    Me.cmd_DeleteLocStatus.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
    Me.cmd_DeleteLocStatus.Name = "cmd_DeleteLocStatus"
    Me.cmd_DeleteLocStatus.Size = New System.Drawing.Size(200, 25)
    Me.cmd_DeleteLocStatus.TabIndex = 26
    Me.cmd_DeleteLocStatus.Text = "Remove Selected Branch"
    Me.cmd_DeleteLocStatus.UseVisualStyleBackColor = True
    '
    'Label4
    '
    Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(3, 197)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(44, 15)
    Me.Label4.TabIndex = 24
    Me.Label4.Text = "New"
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'ck_AlwaysVis
    '
    Me.ck_AlwaysVis.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ck_AlwaysVis.ContextMenuStrip = Me.HelpMenu
    Me.ck_AlwaysVis.Location = New System.Drawing.Point(53, 145)
    Me.ck_AlwaysVis.Name = "ck_AlwaysVis"
    Me.ck_AlwaysVis.Size = New System.Drawing.Size(200, 19)
    Me.ck_AlwaysVis.TabIndex = 25
    Me.ck_AlwaysVis.Text = "Always Visable"
    Me.ck_AlwaysVis.UseVisualStyleBackColor = True
    '
    'cbo_NewStatus
    '
    Me.cbo_NewStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbo_NewStatus.CausesValidation = False
    Me.cbo_NewStatus.ContextMenuStrip = Me.HelpMenu
    Me.cbo_NewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_NewStatus.IntegralHeight = False
    Me.cbo_NewStatus.Location = New System.Drawing.Point(53, 194)
    Me.cbo_NewStatus.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
    Me.cbo_NewStatus.Name = "cbo_NewStatus"
    Me.cbo_NewStatus.Size = New System.Drawing.Size(200, 21)
    Me.cbo_NewStatus.TabIndex = 23
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel3.ColumnCount = 2
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.45679!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.54321!))
    Me.TableLayoutPanel3.Controls.Add(Me.cbo_Location, 1, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.Label11, 0, 0)
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 1
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(256, 23)
    Me.TableLayoutPanel3.TabIndex = 37
    '
    'Frm_Locations
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1179, 615)
    Me.Controls.Add(Me.ToolStripContainer1)
    Me.HelpButton = True
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.MinimumSize = New System.Drawing.Size(550, 450)
    Me.Name = "Frm_Locations"
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
    Me.Text = "Call Center Control Panel"
    Me.HelpMenu.ResumeLayout(False)
    Me.tbl_Location.ResumeLayout(False)
    Me.tbl_Location.PerformLayout()
    Me.mnu_ToolStrip.ResumeLayout(False)
    Me.mnu_ToolStrip.PerformLayout()
    Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
    Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
    Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
    Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
    Me.ToolStripContainer1.ResumeLayout(False)
    Me.ToolStripContainer1.PerformLayout()
    Me.StatusStrip.ResumeLayout(False)
    Me.StatusStrip.PerformLayout()
    Me.tbl_ContentEdit.ResumeLayout(False)
    Me.tbl_ContentEdit.PerformLayout()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.mnu_RTF.ResumeLayout(False)
    Me.tbl_LocationSettings.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.tbl_StatusEdit.ResumeLayout(False)
    Me.tbl_StatusEdit.PerformLayout()
    Me.tbl_Calendar.ResumeLayout(False)
    CType(Me.Grid_Results, System.ComponentModel.ISupportInitialize).EndInit()
    Me.tbl_MainLoc.ResumeLayout(False)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.TableLayoutPanel3.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents cbo_Location As System.Windows.Forms.ComboBox
  Friend WithEvents tbl_Location As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents mnu_ToolStrip As System.Windows.Forms.ToolStrip
  Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
  Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
  Friend WithEvents lbl_Status As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents mnu_Location As System.Windows.Forms.ToolStripSplitButton
  Friend WithEvents mnu_AddNewLocation As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ck_LocEnabled As System.Windows.Forms.CheckBox
  Friend WithEvents tbl_LocationSettings As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents FocusIt As System.Windows.Forms.Button
  Friend WithEvents EditCitysToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents Grid_Results As System.Windows.Forms.DataGridView
  Friend WithEvents cbo_Status As System.Windows.Forms.ComboBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lst_StatusBranch As System.Windows.Forms.ListBox
  Friend WithEvents cmd_DeleteLocStatus As System.Windows.Forms.Button
  Friend WithEvents ck_AlwaysVis As System.Windows.Forms.CheckBox
  Friend WithEvents txt_Location As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents cbo_NewStatus As System.Windows.Forms.ComboBox
  Friend WithEvents cmd_EditOpenDates As System.Windows.Forms.Button
  Friend WithEvents tbl_Calendar As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents tbl_PromoSettings As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents cbo_City As System.Windows.Forms.ComboBox
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents tbl_StatusEdit As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
  Friend WithEvents lst_AccessLevel As System.Windows.Forms.ListBox
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents tbl_MainLoc As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents HelpMenu As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents WhatsThisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ReportAnIssueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents mnu_Promo As System.Windows.Forms.ToolStripButton
  Friend WithEvents mnu_Content As System.Windows.Forms.ToolStripButton
  Friend WithEvents tbl_ContentEdit As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents RichTextBox As System.Windows.Forms.RichTextBox
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents mnu_RTF_Save As System.Windows.Forms.ToolStripButton
  Friend WithEvents mnu_RTF As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents mnu_RTF_Cut As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_RTF_Copy As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_RTF_Paste As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cbo_ContentFiles As System.Windows.Forms.ToolStripComboBox
  Friend WithEvents mnu_RTF_DeleteMenu As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents DeleteCurrentFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents mnu_ImportFile As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents lst_Clip As System.Windows.Forms.ListBox
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents cbo_Confirm As System.Windows.Forms.ComboBox
  Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
