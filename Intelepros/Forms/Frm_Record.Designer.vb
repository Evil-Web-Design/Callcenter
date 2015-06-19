<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Record
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Record))
    Me.Table_Contact = New System.Windows.Forms.TableLayoutPanel()
    Me.Table_Primary = New System.Windows.Forms.TableLayoutPanel()
    Me.txt_PLast = New System.Windows.Forms.TextBox()
    Me.txt_PFirst = New System.Windows.Forms.TextBox()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.txt_Notes = New System.Windows.Forms.TextBox()
    Me.Table_Secondary = New System.Windows.Forms.TableLayoutPanel()
    Me.txt_SLast = New System.Windows.Forms.TextBox()
    Me.txt_SFirst = New System.Windows.Forms.TextBox()
    Me.txt_Email = New System.Windows.Forms.TextBox()
    Me.txt_Address = New System.Windows.Forms.TextBox()
    Me.txt_AddressExtra = New System.Windows.Forms.TextBox()
    Me.txt_City = New System.Windows.Forms.TextBox()
    Me.Table_StateZip = New System.Windows.Forms.TableLayoutPanel()
    Me.txt_Zip = New System.Windows.Forms.TextBox()
    Me.txt_State = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.tel_Phone = New Intelepros.ctl_Phone()
    Me.tel_AltPhone = New Intelepros.ctl_Phone()
    Me.Table_Booking = New System.Windows.Forms.TableLayoutPanel()
    Me.cbo_NQReason = New System.Windows.Forms.ComboBox()
    Me.Label20 = New System.Windows.Forms.Label()
    Me.cmd_NewBooking = New System.Windows.Forms.Button()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.lbl_ClaimLbl = New System.Windows.Forms.Label()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.cmd_ApptDate = New System.Windows.Forms.Button()
    Me.txt_Appt = New System.Windows.Forms.TextBox()
    Me.cbo_Location = New System.Windows.Forms.ComboBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.cbo_Booker = New System.Windows.Forms.ComboBox()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.lbl_Booked = New System.Windows.Forms.Label()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.cbo_Confirmer = New System.Windows.Forms.ComboBox()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.lbl_ConfDate = New System.Windows.Forms.Label()
    Me.Label17 = New System.Windows.Forms.Label()
    Me.cbo_Gift1 = New System.Windows.Forms.ComboBox()
    Me.Label18 = New System.Windows.Forms.Label()
    Me.cbo_Gift2 = New System.Windows.Forms.ComboBox()
    Me.Label19 = New System.Windows.Forms.Label()
    Me.cbo_Gift3 = New System.Windows.Forms.ComboBox()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.txt_BookNotes = New System.Windows.Forms.TextBox()
    Me.cbo_Status = New System.Windows.Forms.ComboBox()
    Me.mnu_ToolStrip = New System.Windows.Forms.ToolStrip()
    Me.mnu_Contact = New System.Windows.Forms.ToolStripSplitButton()
    Me.mnu_Search = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_NewRecord = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.cmd_Close = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_Booking = New System.Windows.Forms.ToolStripSplitButton()
    Me.mnu_NewBooking = New System.Windows.Forms.ToolStripMenuItem()
    Me.cmd_History = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
    Me.cmd_ShowAllGifts = New System.Windows.Forms.ToolStripMenuItem()
    Me.cmd_NavNext = New System.Windows.Forms.ToolStripButton()
    Me.cbo_NavLocation = New System.Windows.Forms.ToolStripComboBox()
    Me.cmd_NavBack = New System.Windows.Forms.ToolStripButton()
    Me.mnu_Separator = New System.Windows.Forms.ToolStripSeparator()
    Me.mnu_Admin = New System.Windows.Forms.ToolStripMenuItem()
    Me.cmd_DisableLock = New System.Windows.Forms.ToolStripMenuItem()
    Me.cmd_ClearConfirmer = New System.Windows.Forms.ToolStripMenuItem()
    Me.cmd_OpView = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnu_DeleteContact = New System.Windows.Forms.ToolStripMenuItem()
    Me.cmd_DeleteContact = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_DeleteBooking = New System.Windows.Forms.ToolStripMenuItem()
    Me.cmd_DeleteBooking = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnu_Send = New System.Windows.Forms.ToolStripDropDownButton()
    Me.mnu_SendConfirmation = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripOuterContainer = New System.Windows.Forms.ToolStripContainer()
    Me.StatusStrip = New System.Windows.Forms.StatusStrip()
    Me.lbl_Status = New System.Windows.Forms.ToolStripStatusLabel()
    Me.cmd_NextCall = New System.Windows.Forms.ToolStripButton()
    Me.cmd_Save = New System.Windows.Forms.ToolStripButton()
    Me.FocusIt = New System.Windows.Forms.Button()
    Me.Label21 = New System.Windows.Forms.Label()
    Me.Table_Contact.SuspendLayout()
    Me.Table_Primary.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.Table_Secondary.SuspendLayout()
    Me.Table_StateZip.SuspendLayout()
    Me.Table_Booking.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.mnu_ToolStrip.SuspendLayout()
    Me.ToolStripOuterContainer.BottomToolStripPanel.SuspendLayout()
    Me.ToolStripOuterContainer.ContentPanel.SuspendLayout()
    Me.ToolStripOuterContainer.TopToolStripPanel.SuspendLayout()
    Me.ToolStripOuterContainer.SuspendLayout()
    Me.StatusStrip.SuspendLayout()
    Me.SuspendLayout()
    '
    'Table_Contact
    '
    Me.Table_Contact.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.Table_Contact.ColumnCount = 2
    Me.Table_Contact.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
    Me.Table_Contact.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.Table_Contact.Controls.Add(Me.Table_Primary, 1, 2)
    Me.Table_Contact.Controls.Add(Me.GroupBox1, 0, 9)
    Me.Table_Contact.Controls.Add(Me.Table_Secondary, 1, 3)
    Me.Table_Contact.Controls.Add(Me.txt_Email, 1, 4)
    Me.Table_Contact.Controls.Add(Me.txt_Address, 1, 5)
    Me.Table_Contact.Controls.Add(Me.txt_AddressExtra, 1, 6)
    Me.Table_Contact.Controls.Add(Me.txt_City, 1, 7)
    Me.Table_Contact.Controls.Add(Me.Table_StateZip, 1, 8)
    Me.Table_Contact.Controls.Add(Me.Label1, 0, 0)
    Me.Table_Contact.Controls.Add(Me.Label2, 0, 1)
    Me.Table_Contact.Controls.Add(Me.Label3, 0, 2)
    Me.Table_Contact.Controls.Add(Me.Label4, 0, 3)
    Me.Table_Contact.Controls.Add(Me.Label5, 0, 5)
    Me.Table_Contact.Controls.Add(Me.Label6, 0, 6)
    Me.Table_Contact.Controls.Add(Me.Label7, 0, 4)
    Me.Table_Contact.Controls.Add(Me.Label8, 0, 7)
    Me.Table_Contact.Controls.Add(Me.Label9, 0, 8)
    Me.Table_Contact.Controls.Add(Me.tel_Phone, 1, 0)
    Me.Table_Contact.Controls.Add(Me.tel_AltPhone, 1, 1)
    Me.Table_Contact.Location = New System.Drawing.Point(285, 8)
    Me.Table_Contact.Margin = New System.Windows.Forms.Padding(0)
    Me.Table_Contact.Name = "Table_Contact"
    Me.Table_Contact.RowCount = 10
    Me.Table_Contact.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Contact.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Contact.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Contact.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Contact.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Contact.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Contact.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Contact.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Contact.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Contact.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.Table_Contact.Size = New System.Drawing.Size(252, 350)
    Me.Table_Contact.TabIndex = 0
    '
    'Table_Primary
    '
    Me.Table_Primary.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Table_Primary.ColumnCount = 2
    Me.Table_Primary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.0303!))
    Me.Table_Primary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.9697!))
    Me.Table_Primary.Controls.Add(Me.txt_PLast, 0, 0)
    Me.Table_Primary.Controls.Add(Me.txt_PFirst, 0, 0)
    Me.Table_Primary.Location = New System.Drawing.Point(85, 50)
    Me.Table_Primary.Margin = New System.Windows.Forms.Padding(0)
    Me.Table_Primary.Name = "Table_Primary"
    Me.Table_Primary.RowCount = 1
    Me.Table_Primary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.Table_Primary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Primary.Size = New System.Drawing.Size(167, 25)
    Me.Table_Primary.TabIndex = 3
    '
    'txt_PLast
    '
    Me.txt_PLast.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_PLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
    Me.txt_PLast.Location = New System.Drawing.Point(71, 0)
    Me.txt_PLast.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_PLast.MaxLength = 25
    Me.txt_PLast.Name = "txt_PLast"
    Me.txt_PLast.Size = New System.Drawing.Size(96, 24)
    Me.txt_PLast.TabIndex = 5
    '
    'txt_PFirst
    '
    Me.txt_PFirst.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_PFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
    Me.txt_PFirst.Location = New System.Drawing.Point(0, 0)
    Me.txt_PFirst.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_PFirst.MaxLength = 25
    Me.txt_PFirst.Name = "txt_PFirst"
    Me.txt_PFirst.Size = New System.Drawing.Size(71, 24)
    Me.txt_PFirst.TabIndex = 4
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.Table_Contact.SetColumnSpan(Me.GroupBox1, 2)
    Me.GroupBox1.Controls.Add(Me.txt_Notes)
    Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox1.Location = New System.Drawing.Point(0, 225)
    Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(252, 125)
    Me.GroupBox1.TabIndex = 30
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Contact Notes"
    '
    'txt_Notes
    '
    Me.txt_Notes.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txt_Notes.Location = New System.Drawing.Point(3, 16)
    Me.txt_Notes.Multiline = True
    Me.txt_Notes.Name = "txt_Notes"
    Me.txt_Notes.Size = New System.Drawing.Size(246, 106)
    Me.txt_Notes.TabIndex = 31
    '
    'Table_Secondary
    '
    Me.Table_Secondary.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Table_Secondary.ColumnCount = 2
    Me.Table_Secondary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.0303!))
    Me.Table_Secondary.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.9697!))
    Me.Table_Secondary.Controls.Add(Me.txt_SLast, 0, 0)
    Me.Table_Secondary.Controls.Add(Me.txt_SFirst, 0, 0)
    Me.Table_Secondary.Location = New System.Drawing.Point(85, 75)
    Me.Table_Secondary.Margin = New System.Windows.Forms.Padding(0)
    Me.Table_Secondary.Name = "Table_Secondary"
    Me.Table_Secondary.RowCount = 1
    Me.Table_Secondary.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.Table_Secondary.Size = New System.Drawing.Size(167, 25)
    Me.Table_Secondary.TabIndex = 6
    '
    'txt_SLast
    '
    Me.txt_SLast.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_SLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
    Me.txt_SLast.Location = New System.Drawing.Point(71, 0)
    Me.txt_SLast.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_SLast.MaxLength = 25
    Me.txt_SLast.Name = "txt_SLast"
    Me.txt_SLast.Size = New System.Drawing.Size(96, 24)
    Me.txt_SLast.TabIndex = 8
    '
    'txt_SFirst
    '
    Me.txt_SFirst.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_SFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
    Me.txt_SFirst.Location = New System.Drawing.Point(0, 0)
    Me.txt_SFirst.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_SFirst.MaxLength = 25
    Me.txt_SFirst.Name = "txt_SFirst"
    Me.txt_SFirst.Size = New System.Drawing.Size(71, 24)
    Me.txt_SFirst.TabIndex = 7
    '
    'txt_Email
    '
    Me.txt_Email.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
    Me.txt_Email.Location = New System.Drawing.Point(85, 100)
    Me.txt_Email.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_Email.MaxLength = 50
    Me.txt_Email.Name = "txt_Email"
    Me.txt_Email.Size = New System.Drawing.Size(167, 24)
    Me.txt_Email.TabIndex = 9
    '
    'txt_Address
    '
    Me.txt_Address.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
    Me.txt_Address.Location = New System.Drawing.Point(85, 125)
    Me.txt_Address.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_Address.MaxLength = 25
    Me.txt_Address.Name = "txt_Address"
    Me.txt_Address.Size = New System.Drawing.Size(167, 24)
    Me.txt_Address.TabIndex = 10
    '
    'txt_AddressExtra
    '
    Me.txt_AddressExtra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_AddressExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
    Me.txt_AddressExtra.Location = New System.Drawing.Point(85, 150)
    Me.txt_AddressExtra.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_AddressExtra.MaxLength = 50
    Me.txt_AddressExtra.Name = "txt_AddressExtra"
    Me.txt_AddressExtra.Size = New System.Drawing.Size(167, 24)
    Me.txt_AddressExtra.TabIndex = 11
    '
    'txt_City
    '
    Me.txt_City.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_City.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
    Me.txt_City.Location = New System.Drawing.Point(85, 175)
    Me.txt_City.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_City.MaxLength = 30
    Me.txt_City.Name = "txt_City"
    Me.txt_City.Size = New System.Drawing.Size(167, 24)
    Me.txt_City.TabIndex = 12
    '
    'Table_StateZip
    '
    Me.Table_StateZip.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Table_StateZip.ColumnCount = 2
    Me.Table_StateZip.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.Table_StateZip.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
    Me.Table_StateZip.Controls.Add(Me.txt_Zip, 0, 0)
    Me.Table_StateZip.Controls.Add(Me.txt_State, 0, 0)
    Me.Table_StateZip.Location = New System.Drawing.Point(85, 200)
    Me.Table_StateZip.Margin = New System.Windows.Forms.Padding(0)
    Me.Table_StateZip.Name = "Table_StateZip"
    Me.Table_StateZip.RowCount = 1
    Me.Table_StateZip.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.Table_StateZip.Size = New System.Drawing.Size(167, 25)
    Me.Table_StateZip.TabIndex = 13
    '
    'txt_Zip
    '
    Me.txt_Zip.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_Zip.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
    Me.txt_Zip.Location = New System.Drawing.Point(55, 0)
    Me.txt_Zip.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_Zip.MaxLength = 5
    Me.txt_Zip.Name = "txt_Zip"
    Me.txt_Zip.Size = New System.Drawing.Size(112, 24)
    Me.txt_Zip.TabIndex = 15
    '
    'txt_State
    '
    Me.txt_State.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_State.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
    Me.txt_State.Location = New System.Drawing.Point(0, 0)
    Me.txt_State.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_State.MaxLength = 2
    Me.txt_State.Name = "txt_State"
    Me.txt_State.Size = New System.Drawing.Size(55, 24)
    Me.txt_State.TabIndex = 14
    '
    'Label1
    '
    Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(0, 5)
    Me.Label1.Margin = New System.Windows.Forms.Padding(0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(85, 15)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Phone"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label2
    '
    Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(0, 30)
    Me.Label2.Margin = New System.Windows.Forms.Padding(0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(85, 15)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Alt Phone"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label3
    '
    Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(0, 55)
    Me.Label3.Margin = New System.Windows.Forms.Padding(0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(85, 15)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Primary Name"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label4
    '
    Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(0, 80)
    Me.Label4.Margin = New System.Windows.Forms.Padding(0)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(85, 15)
    Me.Label4.TabIndex = 3
    Me.Label4.Text = "Secondary Name"
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label5
    '
    Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(0, 130)
    Me.Label5.Margin = New System.Windows.Forms.Padding(0)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(85, 15)
    Me.Label5.TabIndex = 4
    Me.Label5.Text = "Address"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label6
    '
    Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(0, 155)
    Me.Label6.Margin = New System.Windows.Forms.Padding(0)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(85, 15)
    Me.Label6.TabIndex = 5
    Me.Label6.Text = "Address Extra"
    Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label7
    '
    Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label7.AutoSize = True
    Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(0, 105)
    Me.Label7.Margin = New System.Windows.Forms.Padding(0)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(85, 15)
    Me.Label7.TabIndex = 20
    Me.Label7.Text = "Email"
    Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label8
    '
    Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label8.AutoSize = True
    Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.Location = New System.Drawing.Point(0, 180)
    Me.Label8.Margin = New System.Windows.Forms.Padding(0)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(85, 15)
    Me.Label8.TabIndex = 16
    Me.Label8.Text = "City"
    Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label9
    '
    Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label9.AutoSize = True
    Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label9.Location = New System.Drawing.Point(0, 205)
    Me.Label9.Margin = New System.Windows.Forms.Padding(0)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(85, 15)
    Me.Label9.TabIndex = 17
    Me.Label9.Text = "State Zip"
    Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'tel_Phone
    '
    Me.tel_Phone.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.tel_Phone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.tel_Phone.FieldType = Intelepros.ctl_Phone.Enum_FieldType.Telephone
    Me.tel_Phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.tel_Phone.Location = New System.Drawing.Point(85, 0)
    Me.tel_Phone.Margin = New System.Windows.Forms.Padding(0)
    Me.tel_Phone.Name = "tel_Phone"
    Me.tel_Phone.Size = New System.Drawing.Size(167, 25)
    Me.tel_Phone.TabIndex = 31
    Me.tel_Phone.Value = ""
    '
    'tel_AltPhone
    '
    Me.tel_AltPhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.tel_AltPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.tel_AltPhone.FieldType = Intelepros.ctl_Phone.Enum_FieldType.Telephone
    Me.tel_AltPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.tel_AltPhone.Location = New System.Drawing.Point(85, 25)
    Me.tel_AltPhone.Margin = New System.Windows.Forms.Padding(0)
    Me.tel_AltPhone.Name = "tel_AltPhone"
    Me.tel_AltPhone.Size = New System.Drawing.Size(167, 25)
    Me.tel_AltPhone.TabIndex = 32
    Me.tel_AltPhone.Value = ""
    '
    'Table_Booking
    '
    Me.Table_Booking.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.Table_Booking.ColumnCount = 2
    Me.Table_Booking.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
    Me.Table_Booking.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.Table_Booking.Controls.Add(Me.cbo_NQReason, 1, 13)
    Me.Table_Booking.Controls.Add(Me.Label20, 0, 13)
    Me.Table_Booking.Controls.Add(Me.cmd_NewBooking, 0, 0)
    Me.Table_Booking.Controls.Add(Me.Label12, 0, 3)
    Me.Table_Booking.Controls.Add(Me.Label11, 0, 2)
    Me.Table_Booking.Controls.Add(Me.lbl_ClaimLbl, 0, 1)
    Me.Table_Booking.Controls.Add(Me.Label14, 0, 12)
    Me.Table_Booking.Controls.Add(Me.TableLayoutPanel1, 1, 3)
    Me.Table_Booking.Controls.Add(Me.cbo_Location, 1, 2)
    Me.Table_Booking.Controls.Add(Me.Label10, 0, 4)
    Me.Table_Booking.Controls.Add(Me.cbo_Booker, 1, 4)
    Me.Table_Booking.Controls.Add(Me.Label15, 0, 5)
    Me.Table_Booking.Controls.Add(Me.lbl_Booked, 1, 5)
    Me.Table_Booking.Controls.Add(Me.Label13, 0, 6)
    Me.Table_Booking.Controls.Add(Me.cbo_Confirmer, 1, 6)
    Me.Table_Booking.Controls.Add(Me.Label16, 0, 7)
    Me.Table_Booking.Controls.Add(Me.lbl_ConfDate, 1, 7)
    Me.Table_Booking.Controls.Add(Me.Label17, 0, 8)
    Me.Table_Booking.Controls.Add(Me.cbo_Gift1, 1, 8)
    Me.Table_Booking.Controls.Add(Me.Label18, 0, 9)
    Me.Table_Booking.Controls.Add(Me.cbo_Gift2, 1, 9)
    Me.Table_Booking.Controls.Add(Me.Label19, 0, 10)
    Me.Table_Booking.Controls.Add(Me.cbo_Gift3, 1, 10)
    Me.Table_Booking.Controls.Add(Me.GroupBox2, 0, 11)
    Me.Table_Booking.Controls.Add(Me.cbo_Status, 1, 12)
    Me.Table_Booking.Location = New System.Drawing.Point(3, 3)
    Me.Table_Booking.Name = "Table_Booking"
    Me.Table_Booking.RowCount = 14
    Me.Table_Booking.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
    Me.Table_Booking.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Booking.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Booking.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Booking.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Booking.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Booking.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Booking.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Booking.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Booking.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Booking.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.Table_Booking.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.Table_Booking.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
    Me.Table_Booking.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
    Me.Table_Booking.Size = New System.Drawing.Size(279, 420)
    Me.Table_Booking.TabIndex = 16
    '
    'cbo_NQReason
    '
    Me.cbo_NQReason.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbo_NQReason.CausesValidation = False
    Me.cbo_NQReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_NQReason.FormattingEnabled = True
    Me.cbo_NQReason.Location = New System.Drawing.Point(88, 396)
    Me.cbo_NQReason.Name = "cbo_NQReason"
    Me.cbo_NQReason.Size = New System.Drawing.Size(188, 21)
    Me.cbo_NQReason.TabIndex = 26
    '
    'Label20
    '
    Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label20.AutoSize = True
    Me.Label20.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label20.Location = New System.Drawing.Point(3, 399)
    Me.Label20.Name = "Label20"
    Me.Label20.Size = New System.Drawing.Size(79, 15)
    Me.Label20.TabIndex = 21
    Me.Label20.Text = "NQ Reason"
    Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'cmd_NewBooking
    '
    Me.cmd_NewBooking.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmd_NewBooking.BackColor = System.Drawing.SystemColors.Info
    Me.Table_Booking.SetColumnSpan(Me.cmd_NewBooking, 2)
    Me.cmd_NewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.cmd_NewBooking.Image = Global.Intelepros.My.Resources.Resources.lock
    Me.cmd_NewBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmd_NewBooking.Location = New System.Drawing.Point(3, 0)
    Me.cmd_NewBooking.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
    Me.cmd_NewBooking.Name = "cmd_NewBooking"
    Me.cmd_NewBooking.Size = New System.Drawing.Size(273, 50)
    Me.cmd_NewBooking.TabIndex = 38
    Me.cmd_NewBooking.Text = "This Booking is Closed.  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click here to edit the active booking."
    Me.cmd_NewBooking.UseVisualStyleBackColor = False
    '
    'Label12
    '
    Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label12.AutoSize = True
    Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.Location = New System.Drawing.Point(3, 105)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(79, 15)
    Me.Label12.TabIndex = 21
    Me.Label12.Text = "Appointment"
    Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label11
    '
    Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label11.AutoSize = True
    Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label11.Location = New System.Drawing.Point(3, 80)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(79, 15)
    Me.Label11.TabIndex = 20
    Me.Label11.Text = "Location"
    Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lbl_ClaimLbl
    '
    Me.lbl_ClaimLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lbl_ClaimLbl.AutoSize = True
    Me.lbl_ClaimLbl.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lbl_ClaimLbl.Location = New System.Drawing.Point(3, 55)
    Me.lbl_ClaimLbl.Name = "lbl_ClaimLbl"
    Me.lbl_ClaimLbl.Size = New System.Drawing.Size(79, 15)
    Me.lbl_ClaimLbl.TabIndex = 28
    Me.lbl_ClaimLbl.Text = "Claim Number"
    Me.lbl_ClaimLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label14
    '
    Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label14.AutoSize = True
    Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label14.Location = New System.Drawing.Point(3, 367)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(79, 19)
    Me.Label14.TabIndex = 23
    Me.Label14.Text = "Status"
    Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.cmd_ApptDate, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.txt_Appt, 0, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(88, 103)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(188, 19)
    Me.TableLayoutPanel1.TabIndex = 35
    '
    'cmd_ApptDate
    '
    Me.cmd_ApptDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.cmd_ApptDate.BackgroundImage = Global.Intelepros.My.Resources.Resources.calendar
    Me.cmd_ApptDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
    Me.cmd_ApptDate.Dock = System.Windows.Forms.DockStyle.Fill
    Me.cmd_ApptDate.FlatAppearance.BorderSize = 0
    Me.cmd_ApptDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.cmd_ApptDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmd_ApptDate.Location = New System.Drawing.Point(171, 0)
    Me.cmd_ApptDate.Margin = New System.Windows.Forms.Padding(0)
    Me.cmd_ApptDate.Name = "cmd_ApptDate"
    Me.cmd_ApptDate.Size = New System.Drawing.Size(17, 19)
    Me.cmd_ApptDate.TabIndex = 35
    Me.cmd_ApptDate.Tag = "Set Appt Date and Time"
    Me.cmd_ApptDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.cmd_ApptDate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    Me.cmd_ApptDate.UseCompatibleTextRendering = True
    Me.cmd_ApptDate.UseVisualStyleBackColor = False
    '
    'txt_Appt
    '
    Me.txt_Appt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_Appt.Location = New System.Drawing.Point(3, 0)
    Me.txt_Appt.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
    Me.txt_Appt.Name = "txt_Appt"
    Me.txt_Appt.ReadOnly = True
    Me.txt_Appt.Size = New System.Drawing.Size(165, 20)
    Me.txt_Appt.TabIndex = 36
    Me.txt_Appt.Text = "No Appt Date"
    '
    'cbo_Location
    '
    Me.cbo_Location.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbo_Location.CausesValidation = False
    Me.cbo_Location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_Location.IntegralHeight = False
    Me.cbo_Location.Location = New System.Drawing.Point(88, 78)
    Me.cbo_Location.Name = "cbo_Location"
    Me.cbo_Location.Size = New System.Drawing.Size(188, 21)
    Me.cbo_Location.TabIndex = 17
    '
    'Label10
    '
    Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label10.AutoSize = True
    Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label10.Location = New System.Drawing.Point(3, 130)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(79, 15)
    Me.Label10.TabIndex = 18
    Me.Label10.Text = "Booker"
    Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'cbo_Booker
    '
    Me.cbo_Booker.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbo_Booker.CausesValidation = False
    Me.cbo_Booker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_Booker.FormattingEnabled = True
    Me.cbo_Booker.Location = New System.Drawing.Point(88, 128)
    Me.cbo_Booker.Name = "cbo_Booker"
    Me.cbo_Booker.Size = New System.Drawing.Size(188, 21)
    Me.cbo_Booker.TabIndex = 20
    '
    'Label15
    '
    Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label15.AutoSize = True
    Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label15.Location = New System.Drawing.Point(3, 155)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(79, 15)
    Me.Label15.TabIndex = 27
    Me.Label15.Text = "Booked"
    Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lbl_Booked
    '
    Me.lbl_Booked.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lbl_Booked.AutoEllipsis = True
    Me.lbl_Booked.BackColor = System.Drawing.SystemColors.Control
    Me.lbl_Booked.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lbl_Booked.Location = New System.Drawing.Point(85, 150)
    Me.lbl_Booked.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
    Me.lbl_Booked.Name = "lbl_Booked"
    Me.lbl_Booked.Size = New System.Drawing.Size(191, 24)
    Me.lbl_Booked.TabIndex = 37
    Me.lbl_Booked.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label13
    '
    Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label13.AutoSize = True
    Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label13.Location = New System.Drawing.Point(3, 180)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(79, 15)
    Me.Label13.TabIndex = 22
    Me.Label13.Text = "Confirmer"
    Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'cbo_Confirmer
    '
    Me.cbo_Confirmer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbo_Confirmer.CausesValidation = False
    Me.cbo_Confirmer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_Confirmer.FormattingEnabled = True
    Me.cbo_Confirmer.Location = New System.Drawing.Point(88, 178)
    Me.cbo_Confirmer.Name = "cbo_Confirmer"
    Me.cbo_Confirmer.Size = New System.Drawing.Size(188, 21)
    Me.cbo_Confirmer.TabIndex = 22
    '
    'Label16
    '
    Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label16.AutoSize = True
    Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label16.Location = New System.Drawing.Point(3, 205)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(79, 15)
    Me.Label16.TabIndex = 31
    Me.Label16.Text = "Confirmed"
    Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lbl_ConfDate
    '
    Me.lbl_ConfDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lbl_ConfDate.AutoEllipsis = True
    Me.lbl_ConfDate.BackColor = System.Drawing.SystemColors.Control
    Me.lbl_ConfDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lbl_ConfDate.Location = New System.Drawing.Point(85, 200)
    Me.lbl_ConfDate.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
    Me.lbl_ConfDate.Name = "lbl_ConfDate"
    Me.lbl_ConfDate.Size = New System.Drawing.Size(191, 24)
    Me.lbl_ConfDate.TabIndex = 36
    Me.lbl_ConfDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label17
    '
    Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label17.AutoSize = True
    Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label17.Location = New System.Drawing.Point(3, 230)
    Me.Label17.Name = "Label17"
    Me.Label17.Size = New System.Drawing.Size(79, 15)
    Me.Label17.TabIndex = 32
    Me.Label17.Text = "Gift One"
    Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'cbo_Gift1
    '
    Me.cbo_Gift1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbo_Gift1.CausesValidation = False
    Me.cbo_Gift1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_Gift1.FormattingEnabled = True
    Me.cbo_Gift1.Location = New System.Drawing.Point(88, 228)
    Me.cbo_Gift1.Name = "cbo_Gift1"
    Me.cbo_Gift1.Size = New System.Drawing.Size(188, 21)
    Me.cbo_Gift1.TabIndex = 25
    '
    'Label18
    '
    Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label18.AutoSize = True
    Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label18.Location = New System.Drawing.Point(3, 255)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(79, 15)
    Me.Label18.TabIndex = 33
    Me.Label18.Text = "Gift Two"
    Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'cbo_Gift2
    '
    Me.cbo_Gift2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbo_Gift2.CausesValidation = False
    Me.cbo_Gift2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_Gift2.FormattingEnabled = True
    Me.cbo_Gift2.Location = New System.Drawing.Point(88, 253)
    Me.cbo_Gift2.Name = "cbo_Gift2"
    Me.cbo_Gift2.Size = New System.Drawing.Size(188, 21)
    Me.cbo_Gift2.TabIndex = 26
    '
    'Label19
    '
    Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label19.AutoSize = True
    Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label19.Location = New System.Drawing.Point(3, 280)
    Me.Label19.Name = "Label19"
    Me.Label19.Size = New System.Drawing.Size(79, 15)
    Me.Label19.TabIndex = 34
    Me.Label19.Text = "Gift Three"
    Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'cbo_Gift3
    '
    Me.cbo_Gift3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbo_Gift3.CausesValidation = False
    Me.cbo_Gift3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_Gift3.FormattingEnabled = True
    Me.cbo_Gift3.Location = New System.Drawing.Point(88, 278)
    Me.cbo_Gift3.Name = "cbo_Gift3"
    Me.cbo_Gift3.Size = New System.Drawing.Size(188, 21)
    Me.cbo_Gift3.TabIndex = 27
    '
    'GroupBox2
    '
    Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.Table_Booking.SetColumnSpan(Me.GroupBox2, 2)
    Me.GroupBox2.Controls.Add(Me.txt_BookNotes)
    Me.GroupBox2.Location = New System.Drawing.Point(3, 303)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(273, 54)
    Me.GroupBox2.TabIndex = 28
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Booking Notes"
    '
    'txt_BookNotes
    '
    Me.txt_BookNotes.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txt_BookNotes.Location = New System.Drawing.Point(3, 16)
    Me.txt_BookNotes.Multiline = True
    Me.txt_BookNotes.Name = "txt_BookNotes"
    Me.txt_BookNotes.Size = New System.Drawing.Size(267, 35)
    Me.txt_BookNotes.TabIndex = 29
    '
    'cbo_Status
    '
    Me.cbo_Status.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbo_Status.CausesValidation = False
    Me.cbo_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbo_Status.FormattingEnabled = True
    Me.cbo_Status.Location = New System.Drawing.Point(88, 363)
    Me.cbo_Status.Name = "cbo_Status"
    Me.cbo_Status.Size = New System.Drawing.Size(188, 28)
    Me.cbo_Status.TabIndex = 19
    '
    'mnu_ToolStrip
    '
    Me.mnu_ToolStrip.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.mnu_ToolStrip.Dock = System.Windows.Forms.DockStyle.None
    Me.mnu_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.mnu_ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Contact, Me.mnu_Booking, Me.cmd_NavNext, Me.cbo_NavLocation, Me.cmd_NavBack, Me.mnu_Separator, Me.mnu_Admin, Me.mnu_Send})
    Me.mnu_ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
    Me.mnu_ToolStrip.Location = New System.Drawing.Point(0, 0)
    Me.mnu_ToolStrip.Name = "mnu_ToolStrip"
    Me.mnu_ToolStrip.Padding = New System.Windows.Forms.Padding(0)
    Me.mnu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
    Me.mnu_ToolStrip.Size = New System.Drawing.Size(536, 25)
    Me.mnu_ToolStrip.Stretch = True
    Me.mnu_ToolStrip.TabIndex = 0
    Me.mnu_ToolStrip.Text = "ToolStrip1"
    '
    'mnu_Contact
    '
    Me.mnu_Contact.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Search, Me.mnu_NewRecord, Me.ToolStripSeparator1, Me.cmd_Close})
    Me.mnu_Contact.Image = Global.Intelepros.My.Resources.Resources.telephone
    Me.mnu_Contact.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.mnu_Contact.Name = "mnu_Contact"
    Me.mnu_Contact.Size = New System.Drawing.Size(81, 22)
    Me.mnu_Contact.Text = "&Contact"
    '
    'mnu_Search
    '
    Me.mnu_Search.Image = Global.Intelepros.My.Resources.Resources.magnifier
    Me.mnu_Search.Name = "mnu_Search"
    Me.mnu_Search.Size = New System.Drawing.Size(173, 22)
    Me.mnu_Search.Text = "&Search"
    '
    'mnu_NewRecord
    '
    Me.mnu_NewRecord.Image = Global.Intelepros.My.Resources.Resources.telephone
    Me.mnu_NewRecord.Name = "mnu_NewRecord"
    Me.mnu_NewRecord.Size = New System.Drawing.Size(173, 22)
    Me.mnu_NewRecord.Text = "Next &Call"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
    '
    'cmd_Close
    '
    Me.cmd_Close.Image = Global.Intelepros.My.Resources.Resources.Redstop
    Me.cmd_Close.Name = "cmd_Close"
    Me.cmd_Close.Size = New System.Drawing.Size(173, 22)
    Me.cmd_Close.Text = "Close This Contact"
    '
    'mnu_Booking
    '
    Me.mnu_Booking.BackColor = System.Drawing.Color.Transparent
    Me.mnu_Booking.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_NewBooking, Me.cmd_History, Me.ToolStripSeparator4, Me.cmd_ShowAllGifts})
    Me.mnu_Booking.Image = Global.Intelepros.My.Resources.Resources.book
    Me.mnu_Booking.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.mnu_Booking.Name = "mnu_Booking"
    Me.mnu_Booking.Size = New System.Drawing.Size(83, 22)
    Me.mnu_Booking.Text = "&Booking"
    '
    'mnu_NewBooking
    '
    Me.mnu_NewBooking.Image = Global.Intelepros.My.Resources.Resources.book_add
    Me.mnu_NewBooking.Name = "mnu_NewBooking"
    Me.mnu_NewBooking.Size = New System.Drawing.Size(147, 22)
    Me.mnu_NewBooking.Text = "&New Booking"
    Me.mnu_NewBooking.Visible = False
    '
    'cmd_History
    '
    Me.cmd_History.Image = Global.Intelepros.My.Resources.Resources.report
    Me.cmd_History.Name = "cmd_History"
    Me.cmd_History.Size = New System.Drawing.Size(147, 22)
    Me.cmd_History.Text = "View &History"
    '
    'ToolStripSeparator4
    '
    Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
    Me.ToolStripSeparator4.Size = New System.Drawing.Size(144, 6)
    '
    'cmd_ShowAllGifts
    '
    Me.cmd_ShowAllGifts.Name = "cmd_ShowAllGifts"
    Me.cmd_ShowAllGifts.Size = New System.Drawing.Size(147, 22)
    Me.cmd_ShowAllGifts.Text = "Show All Gifts"
    '
    'cmd_NavNext
    '
    Me.cmd_NavNext.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.cmd_NavNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.cmd_NavNext.Image = Global.Intelepros.My.Resources.Resources.book_next
    Me.cmd_NavNext.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.cmd_NavNext.Name = "cmd_NavNext"
    Me.cmd_NavNext.Size = New System.Drawing.Size(23, 22)
    Me.cmd_NavNext.Text = "Next Booking"
    '
    'cbo_NavLocation
    '
    Me.cbo_NavLocation.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.cbo_NavLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_NavLocation.Name = "cbo_NavLocation"
    Me.cbo_NavLocation.Size = New System.Drawing.Size(121, 25)
    '
    'cmd_NavBack
    '
    Me.cmd_NavBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.cmd_NavBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.cmd_NavBack.Image = Global.Intelepros.My.Resources.Resources.book_previous
    Me.cmd_NavBack.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.cmd_NavBack.Name = "cmd_NavBack"
    Me.cmd_NavBack.Size = New System.Drawing.Size(23, 22)
    Me.cmd_NavBack.Text = "PPrev Booking"
    '
    'mnu_Separator
    '
    Me.mnu_Separator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.mnu_Separator.Name = "mnu_Separator"
    Me.mnu_Separator.Size = New System.Drawing.Size(6, 25)
    '
    'mnu_Admin
    '
    Me.mnu_Admin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmd_DisableLock, Me.cmd_ClearConfirmer, Me.cmd_OpView, Me.ToolStripSeparator2, Me.mnu_DeleteContact, Me.mnu_DeleteBooking})
    Me.mnu_Admin.Image = Global.Intelepros.My.Resources.Resources.key
    Me.mnu_Admin.Name = "mnu_Admin"
    Me.mnu_Admin.Size = New System.Drawing.Size(28, 25)
    '
    'cmd_DisableLock
    '
    Me.cmd_DisableLock.Image = Global.Intelepros.My.Resources.Resources.lock_break
    Me.cmd_DisableLock.Name = "cmd_DisableLock"
    Me.cmd_DisableLock.Size = New System.Drawing.Size(196, 22)
    Me.cmd_DisableLock.Text = "Override Record Lock"
    '
    'cmd_ClearConfirmer
    '
    Me.cmd_ClearConfirmer.Image = Global.Intelepros.My.Resources.Resources.user_delete
    Me.cmd_ClearConfirmer.Name = "cmd_ClearConfirmer"
    Me.cmd_ClearConfirmer.Size = New System.Drawing.Size(196, 22)
    Me.cmd_ClearConfirmer.Text = "Clear Confirmer"
    '
    'cmd_OpView
    '
    Me.cmd_OpView.Image = Global.Intelepros.My.Resources.Resources.telephone
    Me.cmd_OpView.Name = "cmd_OpView"
    Me.cmd_OpView.Size = New System.Drawing.Size(196, 22)
    Me.cmd_OpView.Text = "View in Operator Mode"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(193, 6)
    '
    'mnu_DeleteContact
    '
    Me.mnu_DeleteContact.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmd_DeleteContact})
    Me.mnu_DeleteContact.Image = Global.Intelepros.My.Resources.Resources.cross
    Me.mnu_DeleteContact.Name = "mnu_DeleteContact"
    Me.mnu_DeleteContact.Size = New System.Drawing.Size(196, 22)
    Me.mnu_DeleteContact.Text = "Delete This Contact"
    '
    'cmd_DeleteContact
    '
    Me.cmd_DeleteContact.Image = Global.Intelepros.My.Resources.Resources.cross
    Me.cmd_DeleteContact.Name = "cmd_DeleteContact"
    Me.cmd_DeleteContact.Size = New System.Drawing.Size(257, 22)
    Me.cmd_DeleteContact.Text = "Yes, I'm Sure! Just Delete it already!"
    '
    'mnu_DeleteBooking
    '
    Me.mnu_DeleteBooking.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmd_DeleteBooking})
    Me.mnu_DeleteBooking.Image = Global.Intelepros.My.Resources.Resources.cross
    Me.mnu_DeleteBooking.Name = "mnu_DeleteBooking"
    Me.mnu_DeleteBooking.Size = New System.Drawing.Size(196, 22)
    Me.mnu_DeleteBooking.Text = "Delete This Booking"
    '
    'cmd_DeleteBooking
    '
    Me.cmd_DeleteBooking.Image = Global.Intelepros.My.Resources.Resources.cross
    Me.cmd_DeleteBooking.Name = "cmd_DeleteBooking"
    Me.cmd_DeleteBooking.Size = New System.Drawing.Size(313, 22)
    Me.cmd_DeleteBooking.Text = "Yes, Really I don't know why it's here anyway!"
    '
    'mnu_Send
    '
    Me.mnu_Send.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.mnu_Send.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.mnu_Send.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_SendConfirmation})
    Me.mnu_Send.Image = Global.Intelepros.My.Resources.Resources.email_go
    Me.mnu_Send.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.mnu_Send.Name = "mnu_Send"
    Me.mnu_Send.Size = New System.Drawing.Size(29, 22)
    Me.mnu_Send.Text = "ToolStripButton1"
    '
    'mnu_SendConfirmation
    '
    Me.mnu_SendConfirmation.Image = Global.Intelepros.My.Resources.Resources.email
    Me.mnu_SendConfirmation.Name = "mnu_SendConfirmation"
    Me.mnu_SendConfirmation.Size = New System.Drawing.Size(207, 22)
    Me.mnu_SendConfirmation.Text = "Send Confirmation Letter"
    '
    'ToolStripOuterContainer
    '
    '
    'ToolStripOuterContainer.BottomToolStripPanel
    '
    Me.ToolStripOuterContainer.BottomToolStripPanel.Controls.Add(Me.StatusStrip)
    '
    'ToolStripOuterContainer.ContentPanel
    '
    Me.ToolStripOuterContainer.ContentPanel.BackColor = System.Drawing.SystemColors.AppWorkspace
    Me.ToolStripOuterContainer.ContentPanel.Controls.Add(Me.FocusIt)
    Me.ToolStripOuterContainer.ContentPanel.Controls.Add(Me.Table_Booking)
    Me.ToolStripOuterContainer.ContentPanel.Controls.Add(Me.Table_Contact)
    Me.ToolStripOuterContainer.ContentPanel.Size = New System.Drawing.Size(536, 531)
    Me.ToolStripOuterContainer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ToolStripOuterContainer.LeftToolStripPanelVisible = False
    Me.ToolStripOuterContainer.Location = New System.Drawing.Point(0, 0)
    Me.ToolStripOuterContainer.Name = "ToolStripOuterContainer"
    Me.ToolStripOuterContainer.RightToolStripPanelVisible = False
    Me.ToolStripOuterContainer.Size = New System.Drawing.Size(536, 578)
    Me.ToolStripOuterContainer.TabIndex = 5
    Me.ToolStripOuterContainer.Text = "ToolStripContainer1"
    '
    'ToolStripOuterContainer.TopToolStripPanel
    '
    Me.ToolStripOuterContainer.TopToolStripPanel.BackColor = System.Drawing.SystemColors.ButtonShadow
    Me.ToolStripOuterContainer.TopToolStripPanel.Controls.Add(Me.mnu_ToolStrip)
    Me.ToolStripOuterContainer.TopToolStripPanel.Margin = New System.Windows.Forms.Padding(3)
    Me.ToolStripOuterContainer.TopToolStripPanel.Padding = New System.Windows.Forms.Padding(3)
    '
    'StatusStrip
    '
    Me.StatusStrip.AutoSize = False
    Me.StatusStrip.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.StatusStrip.Dock = System.Windows.Forms.DockStyle.None
    Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_Status, Me.cmd_NextCall, Me.cmd_Save})
    Me.StatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
    Me.StatusStrip.Location = New System.Drawing.Point(0, 0)
    Me.StatusStrip.Name = "StatusStrip"
    Me.StatusStrip.Size = New System.Drawing.Size(536, 22)
    Me.StatusStrip.TabIndex = 0
    '
    'lbl_Status
    '
    Me.lbl_Status.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.lbl_Status.Name = "lbl_Status"
    Me.lbl_Status.Size = New System.Drawing.Size(35, 17)
    Me.lbl_Status.Text = "Done"
    '
    'cmd_NextCall
    '
    Me.cmd_NextCall.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.cmd_NextCall.Image = Global.Intelepros.My.Resources.Resources.telephone
    Me.cmd_NextCall.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.cmd_NextCall.Name = "cmd_NextCall"
    Me.cmd_NextCall.Size = New System.Drawing.Size(74, 20)
    Me.cmd_NextCall.Text = "Next Call"
    '
    'cmd_Save
    '
    Me.cmd_Save.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.cmd_Save.Image = Global.Intelepros.My.Resources.Resources.disk
    Me.cmd_Save.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.cmd_Save.Name = "cmd_Save"
    Me.cmd_Save.Size = New System.Drawing.Size(51, 20)
    Me.cmd_Save.Text = "Save"
    '
    'FocusIt
    '
    Me.FocusIt.Location = New System.Drawing.Point(304, 361)
    Me.FocusIt.Name = "FocusIt"
    Me.FocusIt.Size = New System.Drawing.Size(121, 25)
    Me.FocusIt.TabIndex = 17
    Me.FocusIt.Text = "Bam! FocusIt!"
    Me.FocusIt.UseVisualStyleBackColor = True
    '
    'Label21
    '
    Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label21.Location = New System.Drawing.Point(85, 125)
    Me.Label21.Margin = New System.Windows.Forms.Padding(0)
    Me.Label21.Name = "Label21"
    Me.Label21.Size = New System.Drawing.Size(194, 25)
    Me.Label21.TabIndex = 37
    Me.Label21.Text = "Label21"
    '
    'Frm_Record
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Gray
    Me.ClientSize = New System.Drawing.Size(536, 578)
    Me.Controls.Add(Me.ToolStripOuterContainer)
    Me.HelpButton = True
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MaximumSize = New System.Drawing.Size(573, 688)
    Me.MinimizeBox = False
    Me.MinimumSize = New System.Drawing.Size(400, 500)
    Me.Name = "Frm_Record"
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
    Me.Text = "Call Center"
    Me.Table_Contact.ResumeLayout(False)
    Me.Table_Contact.PerformLayout()
    Me.Table_Primary.ResumeLayout(False)
    Me.Table_Primary.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.Table_Secondary.ResumeLayout(False)
    Me.Table_Secondary.PerformLayout()
    Me.Table_StateZip.ResumeLayout(False)
    Me.Table_StateZip.PerformLayout()
    Me.Table_Booking.ResumeLayout(False)
    Me.Table_Booking.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.mnu_ToolStrip.ResumeLayout(False)
    Me.mnu_ToolStrip.PerformLayout()
    Me.ToolStripOuterContainer.BottomToolStripPanel.ResumeLayout(False)
    Me.ToolStripOuterContainer.ContentPanel.ResumeLayout(False)
    Me.ToolStripOuterContainer.TopToolStripPanel.ResumeLayout(False)
    Me.ToolStripOuterContainer.TopToolStripPanel.PerformLayout()
    Me.ToolStripOuterContainer.ResumeLayout(False)
    Me.ToolStripOuterContainer.PerformLayout()
    Me.StatusStrip.ResumeLayout(False)
    Me.StatusStrip.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Table_Contact As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents txt_AddressExtra As System.Windows.Forms.TextBox
  Friend WithEvents txt_Address As System.Windows.Forms.TextBox
  Friend WithEvents txt_Email As System.Windows.Forms.TextBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Table_Secondary As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents txt_SLast As System.Windows.Forms.TextBox
  Friend WithEvents txt_SFirst As System.Windows.Forms.TextBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents Table_Primary As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents txt_PLast As System.Windows.Forms.TextBox
  Friend WithEvents txt_PFirst As System.Windows.Forms.TextBox
  Friend WithEvents Table_Booking As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents cbo_Location As System.Windows.Forms.ComboBox
  Friend WithEvents Table_StateZip As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents txt_Zip As System.Windows.Forms.TextBox
  Friend WithEvents txt_State As System.Windows.Forms.TextBox
  Friend WithEvents txt_City As System.Windows.Forms.TextBox
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents cbo_Booker As System.Windows.Forms.ComboBox
  Friend WithEvents cbo_Confirmer As System.Windows.Forms.ComboBox
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents cbo_Status As System.Windows.Forms.ComboBox
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents txt_Notes As System.Windows.Forms.TextBox
  Friend WithEvents mnu_ToolStrip As System.Windows.Forms.ToolStrip
  Friend WithEvents ToolStripOuterContainer As System.Windows.Forms.ToolStripContainer
  Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
  Friend WithEvents lbl_Status As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents lbl_ClaimLbl As System.Windows.Forms.Label
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents txt_BookNotes As System.Windows.Forms.TextBox
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents Label17 As System.Windows.Forms.Label
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents Label19 As System.Windows.Forms.Label
  Friend WithEvents cbo_Gift1 As System.Windows.Forms.ComboBox
  Friend WithEvents cbo_Gift2 As System.Windows.Forms.ComboBox
  Friend WithEvents cbo_Gift3 As System.Windows.Forms.ComboBox
  Friend WithEvents mnu_Separator As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnu_Contact As System.Windows.Forms.ToolStripSplitButton
  Friend WithEvents mnu_Search As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_NewRecord As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_Booking As System.Windows.Forms.ToolStripSplitButton
  Friend WithEvents mnu_NewBooking As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cmd_History As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents cmd_ShowAllGifts As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents FocusIt As System.Windows.Forms.Button
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents cmd_Close As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cmd_NavNext As System.Windows.Forms.ToolStripButton
  Friend WithEvents cbo_NavLocation As System.Windows.Forms.ToolStripComboBox
  Friend WithEvents cmd_NavBack As System.Windows.Forms.ToolStripButton
  Friend WithEvents cmd_NextCall As System.Windows.Forms.ToolStripButton
  Friend WithEvents cmd_Save As System.Windows.Forms.ToolStripButton
  Friend WithEvents cmd_ApptDate As System.Windows.Forms.Button
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Private WithEvents lbl_ConfDate As System.Windows.Forms.Label
  Private WithEvents lbl_Booked As System.Windows.Forms.Label
  Private WithEvents Label21 As System.Windows.Forms.Label
  Friend WithEvents tel_Phone As Intelepros.ctl_Phone
  Friend WithEvents tel_AltPhone As Intelepros.ctl_Phone
  Friend WithEvents cmd_NewBooking As System.Windows.Forms.Button
  Friend WithEvents txt_Appt As System.Windows.Forms.TextBox
  Friend WithEvents mnu_Admin As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cmd_ClearConfirmer As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cmd_OpView As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnu_DeleteContact As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cmd_DeleteContact As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnu_DeleteBooking As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cmd_DeleteBooking As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cmd_DisableLock As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents cbo_NQReason As System.Windows.Forms.ComboBox
  Friend WithEvents Label20 As System.Windows.Forms.Label
  Friend WithEvents mnu_Send As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents mnu_SendConfirmation As System.Windows.Forms.ToolStripMenuItem
End Class
