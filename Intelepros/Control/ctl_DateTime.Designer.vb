<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctl_DateTime
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Me.MonthName = New System.Windows.Forms.Label()
    Me.MonthLayout = New System.Windows.Forms.TableLayoutPanel()
    Me.cmd_DayTemplate = New System.Windows.Forms.Button()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.tbl_Time = New System.Windows.Forms.TableLayoutPanel()
    Me.lst_Times = New System.Windows.Forms.ListBox()
    Me.Time_Set = New System.Windows.Forms.DateTimePicker()
    Me.cmd_Cancel = New System.Windows.Forms.Button()
    Me.cmd_Set = New System.Windows.Forms.Button()
    Me.cmd_Back = New System.Windows.Forms.Button()
    Me.cmd_Forward = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.lbl_Selected = New System.Windows.Forms.Label()
    Me.cmd_Today = New System.Windows.Forms.Button()
    Me.Tip = New System.Windows.Forms.ToolTip(Me.components)
    Me.MonthLayout.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.tbl_Time.SuspendLayout()
    Me.SuspendLayout()
    '
    'MonthName
    '
    Me.MonthName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MonthName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MonthName.Location = New System.Drawing.Point(39, 0)
    Me.MonthName.Name = "MonthName"
    Me.MonthName.Size = New System.Drawing.Size(179, 25)
    Me.MonthName.TabIndex = 0
    Me.MonthName.Text = "MonthName"
    Me.MonthName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'MonthLayout
    '
    Me.MonthLayout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.MonthLayout.ColumnCount = 7
    Me.TableLayoutPanel1.SetColumnSpan(Me.MonthLayout, 3)
    Me.MonthLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
    Me.MonthLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
    Me.MonthLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
    Me.MonthLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
    Me.MonthLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
    Me.MonthLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
    Me.MonthLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
    Me.MonthLayout.Controls.Add(Me.cmd_DayTemplate, 0, 1)
    Me.MonthLayout.Location = New System.Drawing.Point(1, 26)
    Me.MonthLayout.Margin = New System.Windows.Forms.Padding(1)
    Me.MonthLayout.MinimumSize = New System.Drawing.Size(200, 140)
    Me.MonthLayout.Name = "MonthLayout"
    Me.MonthLayout.RowCount = 7
    Me.MonthLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
    Me.MonthLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
    Me.MonthLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
    Me.MonthLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
    Me.MonthLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
    Me.MonthLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
    Me.MonthLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
    Me.MonthLayout.Size = New System.Drawing.Size(255, 142)
    Me.MonthLayout.TabIndex = 1
    '
    'cmd_DayTemplate
    '
    Me.cmd_DayTemplate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmd_DayTemplate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.cmd_DayTemplate.Enabled = False
    Me.cmd_DayTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.cmd_DayTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmd_DayTemplate.ForeColor = System.Drawing.Color.Black
    Me.cmd_DayTemplate.Location = New System.Drawing.Point(0, 20)
    Me.cmd_DayTemplate.Margin = New System.Windows.Forms.Padding(0)
    Me.cmd_DayTemplate.Name = "cmd_DayTemplate"
    Me.cmd_DayTemplate.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
    Me.cmd_DayTemplate.Size = New System.Drawing.Size(36, 20)
    Me.cmd_DayTemplate.TabIndex = 0
    Me.cmd_DayTemplate.Text = "30"
    Me.cmd_DayTemplate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
    Me.cmd_DayTemplate.UseCompatibleTextRendering = True
    Me.cmd_DayTemplate.UseMnemonic = False
    Me.cmd_DayTemplate.UseVisualStyleBackColor = False
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 4
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.MonthName, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.tbl_Time, 3, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.MonthLayout, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.cmd_Back, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.cmd_Forward, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label1, 3, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.lbl_Selected, 1, 2)
    Me.TableLayoutPanel1.Controls.Add(Me.cmd_Today, 0, 2)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
    Me.TableLayoutPanel1.MinimumSize = New System.Drawing.Size(280, 180)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 3
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(348, 198)
    Me.TableLayoutPanel1.TabIndex = 2
    '
    'tbl_Time
    '
    Me.tbl_Time.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.tbl_Time.ColumnCount = 1
    Me.tbl_Time.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.tbl_Time.Controls.Add(Me.lst_Times, 0, 0)
    Me.tbl_Time.Controls.Add(Me.Time_Set, 0, 1)
    Me.tbl_Time.Controls.Add(Me.cmd_Cancel, 0, 3)
    Me.tbl_Time.Controls.Add(Me.cmd_Set, 0, 2)
    Me.tbl_Time.Location = New System.Drawing.Point(260, 28)
    Me.tbl_Time.Name = "tbl_Time"
    Me.tbl_Time.RowCount = 4
    Me.tbl_Time.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.tbl_Time.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.tbl_Time.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.tbl_Time.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
    Me.tbl_Time.Size = New System.Drawing.Size(85, 138)
    Me.tbl_Time.TabIndex = 10
    '
    'lst_Times
    '
    Me.lst_Times.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lst_Times.FormattingEnabled = True
    Me.lst_Times.IntegralHeight = False
    Me.lst_Times.Location = New System.Drawing.Point(3, 3)
    Me.lst_Times.Name = "lst_Times"
    Me.lst_Times.Size = New System.Drawing.Size(79, 57)
    Me.lst_Times.TabIndex = 4
    '
    'Time_Set
    '
    Me.Time_Set.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Time_Set.CustomFormat = "hh:mm tt"
    Me.Time_Set.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Time_Set.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.Time_Set.Location = New System.Drawing.Point(3, 66)
    Me.Time_Set.Name = "Time_Set"
    Me.Time_Set.ShowUpDown = True
    Me.Time_Set.Size = New System.Drawing.Size(72, 20)
    Me.Time_Set.TabIndex = 8
    Me.Time_Set.Value = New Date(2015, 4, 14, 8, 0, 0, 0)
    '
    'cmd_Cancel
    '
    Me.cmd_Cancel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmd_Cancel.ForeColor = System.Drawing.SystemColors.ControlText
    Me.cmd_Cancel.Location = New System.Drawing.Point(1, 114)
    Me.cmd_Cancel.Margin = New System.Windows.Forms.Padding(1)
    Me.cmd_Cancel.Name = "cmd_Cancel"
    Me.cmd_Cancel.Size = New System.Drawing.Size(83, 23)
    Me.cmd_Cancel.TabIndex = 7
    Me.cmd_Cancel.Text = "Cancel"
    Me.cmd_Cancel.UseVisualStyleBackColor = True
    '
    'cmd_Set
    '
    Me.cmd_Set.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmd_Set.ForeColor = System.Drawing.SystemColors.ControlText
    Me.cmd_Set.Location = New System.Drawing.Point(1, 89)
    Me.cmd_Set.Margin = New System.Windows.Forms.Padding(1)
    Me.cmd_Set.Name = "cmd_Set"
    Me.cmd_Set.Size = New System.Drawing.Size(83, 23)
    Me.cmd_Set.TabIndex = 6
    Me.cmd_Set.Text = "Set"
    Me.cmd_Set.UseVisualStyleBackColor = True
    '
    'cmd_Back
    '
    Me.cmd_Back.Dock = System.Windows.Forms.DockStyle.Fill
    Me.cmd_Back.FlatAppearance.BorderSize = 0
    Me.cmd_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.cmd_Back.Image = Global.Intelepros.My.Resources.Resources.control_rewind_blue
    Me.cmd_Back.Location = New System.Drawing.Point(0, 0)
    Me.cmd_Back.Margin = New System.Windows.Forms.Padding(0)
    Me.cmd_Back.Name = "cmd_Back"
    Me.cmd_Back.Size = New System.Drawing.Size(36, 25)
    Me.cmd_Back.TabIndex = 2
    Me.cmd_Back.Tag = "Back one month"
    Me.cmd_Back.UseVisualStyleBackColor = True
    '
    'cmd_Forward
    '
    Me.cmd_Forward.Dock = System.Windows.Forms.DockStyle.Fill
    Me.cmd_Forward.FlatAppearance.BorderSize = 0
    Me.cmd_Forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.cmd_Forward.Image = Global.Intelepros.My.Resources.Resources.control_fastforward_blue
    Me.cmd_Forward.Location = New System.Drawing.Point(221, 0)
    Me.cmd_Forward.Margin = New System.Windows.Forms.Padding(0)
    Me.cmd_Forward.Name = "cmd_Forward"
    Me.cmd_Forward.Size = New System.Drawing.Size(36, 25)
    Me.cmd_Forward.TabIndex = 3
    Me.cmd_Forward.Tag = "Forward one month"
    Me.cmd_Forward.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(260, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(85, 25)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "Time"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lbl_Selected
    '
    Me.lbl_Selected.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lbl_Selected.AutoSize = True
    Me.lbl_Selected.BackColor = System.Drawing.SystemColors.Window
    Me.lbl_Selected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.TableLayoutPanel1.SetColumnSpan(Me.lbl_Selected, 3)
    Me.lbl_Selected.ForeColor = System.Drawing.SystemColors.ControlText
    Me.lbl_Selected.Location = New System.Drawing.Point(39, 169)
    Me.lbl_Selected.Name = "lbl_Selected"
    Me.lbl_Selected.Size = New System.Drawing.Size(306, 29)
    Me.lbl_Selected.TabIndex = 8
    Me.lbl_Selected.Text = "Selected Date and Time."
    Me.lbl_Selected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'cmd_Today
    '
    Me.cmd_Today.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmd_Today.FlatAppearance.BorderSize = 0
    Me.cmd_Today.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.cmd_Today.Image = Global.Intelepros.My.Resources.Resources.calendar
    Me.cmd_Today.Location = New System.Drawing.Point(1, 170)
    Me.cmd_Today.Margin = New System.Windows.Forms.Padding(1)
    Me.cmd_Today.Name = "cmd_Today"
    Me.cmd_Today.Size = New System.Drawing.Size(34, 27)
    Me.cmd_Today.TabIndex = 9
    Me.cmd_Today.Tag = "Show Today"
    Me.cmd_Today.UseVisualStyleBackColor = True
    '
    'ctl_DateTime
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.MinimumSize = New System.Drawing.Size(350, 200)
    Me.Name = "ctl_DateTime"
    Me.Size = New System.Drawing.Size(348, 198)
    Me.MonthLayout.ResumeLayout(False)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.tbl_Time.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Private WithEvents MonthName As System.Windows.Forms.Label
  Private WithEvents MonthLayout As System.Windows.Forms.TableLayoutPanel
  Private WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Private WithEvents cmd_Back As System.Windows.Forms.Button
  Private WithEvents cmd_Forward As System.Windows.Forms.Button
  Private WithEvents lst_Times As System.Windows.Forms.ListBox
  Private WithEvents Label1 As System.Windows.Forms.Label
  Private WithEvents cmd_Cancel As System.Windows.Forms.Button
  Private WithEvents cmd_Set As System.Windows.Forms.Button
  Private WithEvents cmd_DayTemplate As System.Windows.Forms.Button
  Private WithEvents Tip As System.Windows.Forms.ToolTip
  Private WithEvents lbl_Selected As System.Windows.Forms.Label
  Private WithEvents cmd_Today As System.Windows.Forms.Button
  Private WithEvents tbl_Time As System.Windows.Forms.TableLayoutPanel
  Private WithEvents Time_Set As System.Windows.Forms.DateTimePicker

End Class
