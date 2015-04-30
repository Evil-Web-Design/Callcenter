<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Employees
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
    Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
    Me.lst_Employees = New System.Windows.Forms.ListBox()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage5 = New System.Windows.Forms.TabPage()
    Me.EmployeeInfo = New System.Windows.Forms.TableLayoutPanel()
    Me.grp_Employee = New System.Windows.Forms.GroupBox()
    Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txt_email = New System.Windows.Forms.TextBox()
    Me.Ctl_Phone = New Intelepros.ctl_Phone()
    Me.txt_E_SS = New System.Windows.Forms.TextBox()
    Me.txt_E_Last = New System.Windows.Forms.TextBox()
    Me.Label23 = New System.Windows.Forms.Label()
    Me.Label24 = New System.Windows.Forms.Label()
    Me.Label25 = New System.Windows.Forms.Label()
    Me.Label26 = New System.Windows.Forms.Label()
    Me.txt_E_First = New System.Windows.Forms.TextBox()
    Me.Label33 = New System.Windows.Forms.Label()
    Me.Label32 = New System.Windows.Forms.Label()
    Me.Label31 = New System.Windows.Forms.Label()
    Me.Label30 = New System.Windows.Forms.Label()
    Me.Label29 = New System.Windows.Forms.Label()
    Me.txt_E_Zip = New System.Windows.Forms.TextBox()
    Me.txt_E_State = New System.Windows.Forms.TextBox()
    Me.txt_E_City = New System.Windows.Forms.TextBox()
    Me.txt_E_Add2 = New System.Windows.Forms.TextBox()
    Me.txt_E_Add1 = New System.Windows.Forms.TextBox()
    Me.grp_Emergency = New System.Windows.Forms.GroupBox()
    Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
    Me.Label27 = New System.Windows.Forms.Label()
    Me.Label28 = New System.Windows.Forms.Label()
    Me.txt_E_Econtact = New System.Windows.Forms.TextBox()
    Me.Ctl_AltPhone = New Intelepros.ctl_Phone()
    Me.TabPage7 = New System.Windows.Forms.TabPage()
    Me.grp_E_Settings = New System.Windows.Forms.GroupBox()
    Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
    Me.Label34 = New System.Windows.Forms.Label()
    Me.txt_E_Password = New System.Windows.Forms.TextBox()
    Me.Label36 = New System.Windows.Forms.Label()
    Me.Check_E_Enabled = New System.Windows.Forms.CheckBox()
    Me.Label35 = New System.Windows.Forms.Label()
    Me.Label38 = New System.Windows.Forms.Label()
    Me.cbo_E_Access = New System.Windows.Forms.ComboBox()
    Me.lst_E_Rights = New System.Windows.Forms.ListBox()
    Me.cmd_NewStaff = New System.Windows.Forms.Button()
    Me.TableLayoutPanel11.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage5.SuspendLayout()
    Me.EmployeeInfo.SuspendLayout()
    Me.grp_Employee.SuspendLayout()
    Me.TableLayoutPanel12.SuspendLayout()
    Me.grp_Emergency.SuspendLayout()
    Me.TableLayoutPanel13.SuspendLayout()
    Me.TabPage7.SuspendLayout()
    Me.grp_E_Settings.SuspendLayout()
    Me.TableLayoutPanel14.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel11
    '
    Me.TableLayoutPanel11.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.TableLayoutPanel11.ColumnCount = 2
    Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
    Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel11.Controls.Add(Me.lst_Employees, 0, 0)
    Me.TableLayoutPanel11.Controls.Add(Me.TabControl1, 1, 0)
    Me.TableLayoutPanel11.Controls.Add(Me.cmd_NewStaff, 0, 1)
    Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel11.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel11.Margin = New System.Windows.Forms.Padding(0)
    Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
    Me.TableLayoutPanel11.RowCount = 2
    Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
    Me.TableLayoutPanel11.Size = New System.Drawing.Size(462, 533)
    Me.TableLayoutPanel11.TabIndex = 2
    '
    'lst_Employees
    '
    Me.lst_Employees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lst_Employees.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lst_Employees.FormattingEnabled = True
    Me.lst_Employees.IntegralHeight = False
    Me.lst_Employees.Location = New System.Drawing.Point(0, 0)
    Me.lst_Employees.Margin = New System.Windows.Forms.Padding(0)
    Me.lst_Employees.Name = "lst_Employees"
    Me.lst_Employees.Size = New System.Drawing.Size(178, 499)
    Me.lst_Employees.TabIndex = 0
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage5)
    Me.TabControl1.Controls.Add(Me.TabPage7)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(178, 0)
    Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
    Me.TabControl1.Name = "TabControl1"
    Me.TableLayoutPanel11.SetRowSpan(Me.TabControl1, 2)
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(284, 533)
    Me.TabControl1.TabIndex = 1
    '
    'TabPage5
    '
    Me.TabPage5.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.TabPage5.Controls.Add(Me.EmployeeInfo)
    Me.TabPage5.Location = New System.Drawing.Point(4, 22)
    Me.TabPage5.Name = "TabPage5"
    Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage5.Size = New System.Drawing.Size(276, 507)
    Me.TabPage5.TabIndex = 0
    Me.TabPage5.Text = "Employee Information"
    '
    'EmployeeInfo
    '
    Me.EmployeeInfo.ColumnCount = 1
    Me.EmployeeInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.EmployeeInfo.Controls.Add(Me.grp_Employee, 0, 0)
    Me.EmployeeInfo.Controls.Add(Me.grp_Emergency, 0, 1)
    Me.EmployeeInfo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.EmployeeInfo.Location = New System.Drawing.Point(3, 3)
    Me.EmployeeInfo.Name = "EmployeeInfo"
    Me.EmployeeInfo.RowCount = 3
    Me.EmployeeInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
    Me.EmployeeInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
    Me.EmployeeInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
    Me.EmployeeInfo.Size = New System.Drawing.Size(270, 501)
    Me.EmployeeInfo.TabIndex = 3
    '
    'grp_Employee
    '
    Me.grp_Employee.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.grp_Employee.Controls.Add(Me.TableLayoutPanel12)
    Me.grp_Employee.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grp_Employee.Enabled = False
    Me.grp_Employee.Location = New System.Drawing.Point(3, 3)
    Me.grp_Employee.Name = "grp_Employee"
    Me.grp_Employee.Size = New System.Drawing.Size(264, 294)
    Me.grp_Employee.TabIndex = 1
    Me.grp_Employee.TabStop = False
    Me.grp_Employee.Text = "Employee"
    '
    'TableLayoutPanel12
    '
    Me.TableLayoutPanel12.ColumnCount = 2
    Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
    Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel12.Controls.Add(Me.Label1, 0, 4)
    Me.TableLayoutPanel12.Controls.Add(Me.txt_email, 1, 4)
    Me.TableLayoutPanel12.Controls.Add(Me.Ctl_Phone, 1, 3)
    Me.TableLayoutPanel12.Controls.Add(Me.txt_E_SS, 1, 2)
    Me.TableLayoutPanel12.Controls.Add(Me.txt_E_Last, 1, 1)
    Me.TableLayoutPanel12.Controls.Add(Me.Label23, 0, 0)
    Me.TableLayoutPanel12.Controls.Add(Me.Label24, 0, 1)
    Me.TableLayoutPanel12.Controls.Add(Me.Label25, 0, 2)
    Me.TableLayoutPanel12.Controls.Add(Me.Label26, 0, 3)
    Me.TableLayoutPanel12.Controls.Add(Me.txt_E_First, 1, 0)
    Me.TableLayoutPanel12.Controls.Add(Me.Label33, 0, 9)
    Me.TableLayoutPanel12.Controls.Add(Me.Label32, 0, 8)
    Me.TableLayoutPanel12.Controls.Add(Me.Label31, 0, 7)
    Me.TableLayoutPanel12.Controls.Add(Me.Label30, 0, 6)
    Me.TableLayoutPanel12.Controls.Add(Me.Label29, 0, 5)
    Me.TableLayoutPanel12.Controls.Add(Me.txt_E_Zip, 1, 9)
    Me.TableLayoutPanel12.Controls.Add(Me.txt_E_State, 1, 8)
    Me.TableLayoutPanel12.Controls.Add(Me.txt_E_City, 1, 7)
    Me.TableLayoutPanel12.Controls.Add(Me.txt_E_Add2, 1, 6)
    Me.TableLayoutPanel12.Controls.Add(Me.txt_E_Add1, 1, 5)
    Me.TableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel12.Location = New System.Drawing.Point(3, 16)
    Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
    Me.TableLayoutPanel12.Padding = New System.Windows.Forms.Padding(3)
    Me.TableLayoutPanel12.RowCount = 10
    Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
    Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
    Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
    Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
    Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
    Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
    Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
    Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
    Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
    Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel12.Size = New System.Drawing.Size(258, 275)
    Me.TableLayoutPanel12.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label1.Location = New System.Drawing.Point(6, 111)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(84, 27)
    Me.Label1.TabIndex = 11
    Me.Label1.Text = "Email"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'txt_email
    '
    Me.txt_email.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txt_email.Location = New System.Drawing.Point(93, 114)
    Me.txt_email.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_email.Name = "txt_email"
    Me.txt_email.Size = New System.Drawing.Size(162, 20)
    Me.txt_email.TabIndex = 21
    Me.txt_email.Tag = "Address2"
    '
    'Ctl_Phone
    '
    Me.Ctl_Phone.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Ctl_Phone.FieldType = Intelepros.ctl_Phone.Enum_FieldType.Telephone
    Me.Ctl_Phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Ctl_Phone.Location = New System.Drawing.Point(97, 88)
    Me.Ctl_Phone.Margin = New System.Windows.Forms.Padding(4)
    Me.Ctl_Phone.Name = "Ctl_Phone"
    Me.Ctl_Phone.Size = New System.Drawing.Size(154, 19)
    Me.Ctl_Phone.TabIndex = 25
    Me.Ctl_Phone.Value = ""
    '
    'txt_E_SS
    '
    Me.txt_E_SS.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_E_SS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txt_E_SS.Location = New System.Drawing.Point(93, 60)
    Me.txt_E_SS.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_E_SS.Name = "txt_E_SS"
    Me.txt_E_SS.Size = New System.Drawing.Size(162, 20)
    Me.txt_E_SS.TabIndex = 17
    Me.txt_E_SS.Tag = "SS"
    '
    'txt_E_Last
    '
    Me.txt_E_Last.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_E_Last.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txt_E_Last.Location = New System.Drawing.Point(93, 33)
    Me.txt_E_Last.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_E_Last.Name = "txt_E_Last"
    Me.txt_E_Last.Size = New System.Drawing.Size(162, 20)
    Me.txt_E_Last.TabIndex = 16
    Me.txt_E_Last.Tag = "LastName"
    '
    'Label23
    '
    Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label23.Location = New System.Drawing.Point(6, 3)
    Me.Label23.Name = "Label23"
    Me.Label23.Size = New System.Drawing.Size(84, 27)
    Me.Label23.TabIndex = 6
    Me.Label23.Text = "First Name"
    Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label24
    '
    Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label24.Location = New System.Drawing.Point(6, 30)
    Me.Label24.Name = "Label24"
    Me.Label24.Size = New System.Drawing.Size(84, 27)
    Me.Label24.TabIndex = 7
    Me.Label24.Text = "Last Name"
    Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label25
    '
    Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label25.Location = New System.Drawing.Point(6, 57)
    Me.Label25.Name = "Label25"
    Me.Label25.Size = New System.Drawing.Size(84, 27)
    Me.Label25.TabIndex = 8
    Me.Label25.Text = "Social Security"
    Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label26
    '
    Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label26.Location = New System.Drawing.Point(6, 84)
    Me.Label26.Name = "Label26"
    Me.Label26.Size = New System.Drawing.Size(84, 27)
    Me.Label26.TabIndex = 9
    Me.Label26.Text = "Phone"
    Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'txt_E_First
    '
    Me.txt_E_First.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_E_First.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txt_E_First.Location = New System.Drawing.Point(93, 6)
    Me.txt_E_First.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_E_First.Name = "txt_E_First"
    Me.txt_E_First.Size = New System.Drawing.Size(162, 20)
    Me.txt_E_First.TabIndex = 15
    Me.txt_E_First.Tag = "FirstName"
    '
    'Label33
    '
    Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label33.Location = New System.Drawing.Point(6, 246)
    Me.Label33.Name = "Label33"
    Me.Label33.Size = New System.Drawing.Size(84, 26)
    Me.Label33.TabIndex = 14
    Me.Label33.Text = "Zip"
    Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label32
    '
    Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label32.Location = New System.Drawing.Point(6, 219)
    Me.Label32.Name = "Label32"
    Me.Label32.Size = New System.Drawing.Size(84, 27)
    Me.Label32.TabIndex = 13
    Me.Label32.Text = "State"
    Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label31
    '
    Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label31.Location = New System.Drawing.Point(6, 192)
    Me.Label31.Name = "Label31"
    Me.Label31.Size = New System.Drawing.Size(84, 27)
    Me.Label31.TabIndex = 12
    Me.Label31.Text = "City"
    Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label30
    '
    Me.Label30.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label30.Location = New System.Drawing.Point(6, 165)
    Me.Label30.Name = "Label30"
    Me.Label30.Size = New System.Drawing.Size(84, 27)
    Me.Label30.TabIndex = 11
    Me.Label30.Text = "Address 2"
    Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label29
    '
    Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label29.Location = New System.Drawing.Point(6, 138)
    Me.Label29.Name = "Label29"
    Me.Label29.Size = New System.Drawing.Size(84, 27)
    Me.Label29.TabIndex = 10
    Me.Label29.Text = "Address 1"
    Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'txt_E_Zip
    '
    Me.txt_E_Zip.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_E_Zip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txt_E_Zip.Location = New System.Drawing.Point(93, 249)
    Me.txt_E_Zip.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_E_Zip.Name = "txt_E_Zip"
    Me.txt_E_Zip.Size = New System.Drawing.Size(162, 20)
    Me.txt_E_Zip.TabIndex = 23
    Me.txt_E_Zip.Tag = "Zip"
    '
    'txt_E_State
    '
    Me.txt_E_State.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_E_State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txt_E_State.Location = New System.Drawing.Point(93, 222)
    Me.txt_E_State.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_E_State.Name = "txt_E_State"
    Me.txt_E_State.Size = New System.Drawing.Size(162, 20)
    Me.txt_E_State.TabIndex = 22
    Me.txt_E_State.Tag = "State"
    '
    'txt_E_City
    '
    Me.txt_E_City.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_E_City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txt_E_City.Location = New System.Drawing.Point(93, 195)
    Me.txt_E_City.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_E_City.Name = "txt_E_City"
    Me.txt_E_City.Size = New System.Drawing.Size(162, 20)
    Me.txt_E_City.TabIndex = 21
    Me.txt_E_City.Tag = "City"
    '
    'txt_E_Add2
    '
    Me.txt_E_Add2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_E_Add2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txt_E_Add2.Location = New System.Drawing.Point(93, 168)
    Me.txt_E_Add2.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_E_Add2.Name = "txt_E_Add2"
    Me.txt_E_Add2.Size = New System.Drawing.Size(162, 20)
    Me.txt_E_Add2.TabIndex = 20
    Me.txt_E_Add2.Tag = "Address2"
    '
    'txt_E_Add1
    '
    Me.txt_E_Add1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_E_Add1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txt_E_Add1.Location = New System.Drawing.Point(93, 141)
    Me.txt_E_Add1.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_E_Add1.Name = "txt_E_Add1"
    Me.txt_E_Add1.Size = New System.Drawing.Size(162, 20)
    Me.txt_E_Add1.TabIndex = 19
    Me.txt_E_Add1.Tag = "Address1"
    '
    'grp_Emergency
    '
    Me.grp_Emergency.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.grp_Emergency.Controls.Add(Me.TableLayoutPanel13)
    Me.grp_Emergency.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grp_Emergency.Enabled = False
    Me.grp_Emergency.Location = New System.Drawing.Point(3, 303)
    Me.grp_Emergency.Name = "grp_Emergency"
    Me.grp_Emergency.Size = New System.Drawing.Size(264, 81)
    Me.grp_Emergency.TabIndex = 2
    Me.grp_Emergency.TabStop = False
    Me.grp_Emergency.Text = "Emergency Contact"
    '
    'TableLayoutPanel13
    '
    Me.TableLayoutPanel13.ColumnCount = 2
    Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
    Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel13.Controls.Add(Me.Label27, 0, 0)
    Me.TableLayoutPanel13.Controls.Add(Me.Label28, 0, 1)
    Me.TableLayoutPanel13.Controls.Add(Me.txt_E_Econtact, 1, 0)
    Me.TableLayoutPanel13.Controls.Add(Me.Ctl_AltPhone, 1, 1)
    Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel13.Location = New System.Drawing.Point(3, 16)
    Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
    Me.TableLayoutPanel13.Padding = New System.Windows.Forms.Padding(3)
    Me.TableLayoutPanel13.RowCount = 2
    Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
    Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
    Me.TableLayoutPanel13.Size = New System.Drawing.Size(258, 62)
    Me.TableLayoutPanel13.TabIndex = 1
    '
    'Label27
    '
    Me.Label27.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label27.Location = New System.Drawing.Point(6, 3)
    Me.Label27.Name = "Label27"
    Me.Label27.Size = New System.Drawing.Size(84, 27)
    Me.Label27.TabIndex = 6
    Me.Label27.Text = "Name"
    Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label28
    '
    Me.Label28.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label28.Location = New System.Drawing.Point(6, 30)
    Me.Label28.Name = "Label28"
    Me.Label28.Size = New System.Drawing.Size(84, 29)
    Me.Label28.TabIndex = 7
    Me.Label28.Text = "Phone"
    Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'txt_E_Econtact
    '
    Me.txt_E_Econtact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txt_E_Econtact.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txt_E_Econtact.Location = New System.Drawing.Point(93, 3)
    Me.txt_E_Econtact.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_E_Econtact.Name = "txt_E_Econtact"
    Me.txt_E_Econtact.Size = New System.Drawing.Size(162, 20)
    Me.txt_E_Econtact.TabIndex = 16
    Me.txt_E_Econtact.Tag = "EContact"
    '
    'Ctl_AltPhone
    '
    Me.Ctl_AltPhone.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Ctl_AltPhone.FieldType = Intelepros.ctl_Phone.Enum_FieldType.Telephone
    Me.Ctl_AltPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Ctl_AltPhone.Location = New System.Drawing.Point(97, 34)
    Me.Ctl_AltPhone.Margin = New System.Windows.Forms.Padding(4)
    Me.Ctl_AltPhone.Name = "Ctl_AltPhone"
    Me.Ctl_AltPhone.Size = New System.Drawing.Size(154, 21)
    Me.Ctl_AltPhone.TabIndex = 24
    Me.Ctl_AltPhone.Value = ""
    '
    'TabPage7
    '
    Me.TabPage7.BackColor = System.Drawing.SystemColors.ButtonFace
    Me.TabPage7.Controls.Add(Me.grp_E_Settings)
    Me.TabPage7.Location = New System.Drawing.Point(4, 22)
    Me.TabPage7.Name = "TabPage7"
    Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage7.Size = New System.Drawing.Size(276, 507)
    Me.TabPage7.TabIndex = 1
    Me.TabPage7.Text = "Settings"
    '
    'grp_E_Settings
    '
    Me.grp_E_Settings.Controls.Add(Me.TableLayoutPanel14)
    Me.grp_E_Settings.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grp_E_Settings.Enabled = False
    Me.grp_E_Settings.Location = New System.Drawing.Point(3, 3)
    Me.grp_E_Settings.Name = "grp_E_Settings"
    Me.grp_E_Settings.Size = New System.Drawing.Size(270, 501)
    Me.grp_E_Settings.TabIndex = 3
    Me.grp_E_Settings.TabStop = False
    Me.grp_E_Settings.Text = "User Settings"
    '
    'TableLayoutPanel14
    '
    Me.TableLayoutPanel14.ColumnCount = 2
    Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
    Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel14.Controls.Add(Me.Label34, 0, 0)
    Me.TableLayoutPanel14.Controls.Add(Me.txt_E_Password, 1, 0)
    Me.TableLayoutPanel14.Controls.Add(Me.Label36, 0, 1)
    Me.TableLayoutPanel14.Controls.Add(Me.Check_E_Enabled, 1, 1)
    Me.TableLayoutPanel14.Controls.Add(Me.Label35, 0, 2)
    Me.TableLayoutPanel14.Controls.Add(Me.Label38, 0, 3)
    Me.TableLayoutPanel14.Controls.Add(Me.cbo_E_Access, 1, 2)
    Me.TableLayoutPanel14.Controls.Add(Me.lst_E_Rights, 1, 3)
    Me.TableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel14.Location = New System.Drawing.Point(3, 16)
    Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
    Me.TableLayoutPanel14.Padding = New System.Windows.Forms.Padding(3)
    Me.TableLayoutPanel14.RowCount = 4
    Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
    Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
    Me.TableLayoutPanel14.Size = New System.Drawing.Size(264, 482)
    Me.TableLayoutPanel14.TabIndex = 1
    '
    'Label34
    '
    Me.Label34.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label34.Location = New System.Drawing.Point(6, 3)
    Me.Label34.Name = "Label34"
    Me.Label34.Size = New System.Drawing.Size(84, 20)
    Me.Label34.TabIndex = 6
    Me.Label34.Text = "Password"
    Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'txt_E_Password
    '
    Me.txt_E_Password.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txt_E_Password.Location = New System.Drawing.Point(93, 3)
    Me.txt_E_Password.Margin = New System.Windows.Forms.Padding(0)
    Me.txt_E_Password.Name = "txt_E_Password"
    Me.txt_E_Password.Size = New System.Drawing.Size(168, 20)
    Me.txt_E_Password.TabIndex = 16
    Me.txt_E_Password.Tag = "Password"
    '
    'Label36
    '
    Me.Label36.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label36.Location = New System.Drawing.Point(6, 23)
    Me.Label36.Name = "Label36"
    Me.Label36.Size = New System.Drawing.Size(84, 20)
    Me.Label36.TabIndex = 18
    Me.Label36.Text = "Enabled"
    Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Check_E_Enabled
    '
    Me.Check_E_Enabled.AutoSize = True
    Me.Check_E_Enabled.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Check_E_Enabled.Location = New System.Drawing.Point(93, 23)
    Me.Check_E_Enabled.Margin = New System.Windows.Forms.Padding(0)
    Me.Check_E_Enabled.Name = "Check_E_Enabled"
    Me.Check_E_Enabled.Size = New System.Drawing.Size(168, 20)
    Me.Check_E_Enabled.TabIndex = 19
    Me.Check_E_Enabled.Tag = "Active"
    Me.Check_E_Enabled.Text = "Employee Not Selected"
    Me.Check_E_Enabled.UseVisualStyleBackColor = True
    '
    'Label35
    '
    Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label35.Location = New System.Drawing.Point(6, 45)
    Me.Label35.Name = "Label35"
    Me.Label35.Size = New System.Drawing.Size(84, 22)
    Me.Label35.TabIndex = 7
    Me.Label35.Text = "Access Level"
    Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Label38
    '
    Me.Label38.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label38.Location = New System.Drawing.Point(6, 70)
    Me.Label38.Name = "Label38"
    Me.Label38.Size = New System.Drawing.Size(84, 409)
    Me.Label38.TabIndex = 23
    Me.Label38.Text = "Rights"
    Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopRight
    '
    'cbo_E_Access
    '
    Me.cbo_E_Access.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbo_E_Access.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_E_Access.FormattingEnabled = True
    Me.cbo_E_Access.Location = New System.Drawing.Point(93, 46)
    Me.cbo_E_Access.Margin = New System.Windows.Forms.Padding(0)
    Me.cbo_E_Access.Name = "cbo_E_Access"
    Me.cbo_E_Access.Size = New System.Drawing.Size(168, 21)
    Me.cbo_E_Access.TabIndex = 17
    Me.cbo_E_Access.Tag = "AccessLevelID"
    '
    'lst_E_Rights
    '
    Me.lst_E_Rights.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lst_E_Rights.Enabled = False
    Me.lst_E_Rights.FormattingEnabled = True
    Me.lst_E_Rights.Location = New System.Drawing.Point(93, 70)
    Me.lst_E_Rights.Margin = New System.Windows.Forms.Padding(0)
    Me.lst_E_Rights.Name = "lst_E_Rights"
    Me.lst_E_Rights.Size = New System.Drawing.Size(168, 407)
    Me.lst_E_Rights.TabIndex = 22
    '
    'cmd_NewStaff
    '
    Me.cmd_NewStaff.Dock = System.Windows.Forms.DockStyle.Fill
    Me.cmd_NewStaff.Location = New System.Drawing.Point(3, 502)
    Me.cmd_NewStaff.Name = "cmd_NewStaff"
    Me.cmd_NewStaff.Size = New System.Drawing.Size(172, 28)
    Me.cmd_NewStaff.TabIndex = 2
    Me.cmd_NewStaff.Text = "New Staff Member"
    Me.cmd_NewStaff.UseVisualStyleBackColor = True
    '
    'Frm_Employees
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(462, 533)
    Me.Controls.Add(Me.TableLayoutPanel11)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
    Me.MinimumSize = New System.Drawing.Size(478, 430)
    Me.Name = "Frm_Employees"
    Me.Text = "Employee Management"
    Me.TopMost = True
    Me.TableLayoutPanel11.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage5.ResumeLayout(False)
    Me.EmployeeInfo.ResumeLayout(False)
    Me.grp_Employee.ResumeLayout(False)
    Me.TableLayoutPanel12.ResumeLayout(False)
    Me.TableLayoutPanel12.PerformLayout()
    Me.grp_Emergency.ResumeLayout(False)
    Me.TableLayoutPanel13.ResumeLayout(False)
    Me.TableLayoutPanel13.PerformLayout()
    Me.TabPage7.ResumeLayout(False)
    Me.grp_E_Settings.ResumeLayout(False)
    Me.TableLayoutPanel14.ResumeLayout(False)
    Me.TableLayoutPanel14.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel11 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents lst_Employees As System.Windows.Forms.ListBox
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
  Friend WithEvents EmployeeInfo As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents grp_Employee As System.Windows.Forms.GroupBox
  Friend WithEvents TableLayoutPanel12 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents txt_E_Zip As System.Windows.Forms.TextBox
  Friend WithEvents txt_E_State As System.Windows.Forms.TextBox
  Friend WithEvents txt_E_City As System.Windows.Forms.TextBox
  Friend WithEvents txt_E_Add2 As System.Windows.Forms.TextBox
  Friend WithEvents txt_E_Add1 As System.Windows.Forms.TextBox
  Friend WithEvents txt_E_SS As System.Windows.Forms.TextBox
  Friend WithEvents txt_E_Last As System.Windows.Forms.TextBox
  Friend WithEvents Label33 As System.Windows.Forms.Label
  Friend WithEvents Label32 As System.Windows.Forms.Label
  Friend WithEvents Label23 As System.Windows.Forms.Label
  Friend WithEvents Label24 As System.Windows.Forms.Label
  Friend WithEvents Label25 As System.Windows.Forms.Label
  Friend WithEvents Label26 As System.Windows.Forms.Label
  Friend WithEvents Label29 As System.Windows.Forms.Label
  Friend WithEvents Label30 As System.Windows.Forms.Label
  Friend WithEvents Label31 As System.Windows.Forms.Label
  Friend WithEvents txt_E_First As System.Windows.Forms.TextBox
  Friend WithEvents grp_Emergency As System.Windows.Forms.GroupBox
  Friend WithEvents TableLayoutPanel13 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents Label27 As System.Windows.Forms.Label
  Friend WithEvents Label28 As System.Windows.Forms.Label
  Friend WithEvents txt_E_Econtact As System.Windows.Forms.TextBox
  Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
  Friend WithEvents grp_E_Settings As System.Windows.Forms.GroupBox
  Friend WithEvents TableLayoutPanel14 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents Label38 As System.Windows.Forms.Label
  Friend WithEvents Label34 As System.Windows.Forms.Label
  Friend WithEvents txt_E_Password As System.Windows.Forms.TextBox
  Friend WithEvents Label36 As System.Windows.Forms.Label
  Friend WithEvents Check_E_Enabled As System.Windows.Forms.CheckBox
  Friend WithEvents Label35 As System.Windows.Forms.Label
  Friend WithEvents cbo_E_Access As System.Windows.Forms.ComboBox
  Friend WithEvents lst_E_Rights As System.Windows.Forms.ListBox
  Friend WithEvents cmd_NewStaff As System.Windows.Forms.Button
  Friend WithEvents Ctl_Phone As Intelepros.ctl_Phone
  Friend WithEvents Ctl_AltPhone As Intelepros.ctl_Phone
  Friend WithEvents txt_email As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
