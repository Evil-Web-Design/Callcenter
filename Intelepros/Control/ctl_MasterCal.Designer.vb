<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctl_MasterCal
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
    Me.tbl_Layout = New System.Windows.Forms.TableLayoutPanel()
    Me.cbo_Time = New System.Windows.Forms.ComboBox()
    Me.tbl_Layout.SuspendLayout()
    Me.SuspendLayout()
    '
    'tbl_Layout
    '
    Me.tbl_Layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.tbl_Layout.ColumnCount = 2
    Me.tbl_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
    Me.tbl_Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
    Me.tbl_Layout.Controls.Add(Me.cbo_Time, 1, 0)
    Me.tbl_Layout.Location = New System.Drawing.Point(0, 0)
    Me.tbl_Layout.Name = "tbl_Layout"
    Me.tbl_Layout.RowCount = 1
    Me.tbl_Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.tbl_Layout.Size = New System.Drawing.Size(285, 46)
    Me.tbl_Layout.TabIndex = 0
    '
    'cbo_Time
    '
    Me.cbo_Time.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbo_Time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbo_Time.FormattingEnabled = True
    Me.cbo_Time.Location = New System.Drawing.Point(156, 12)
    Me.cbo_Time.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
    Me.cbo_Time.Name = "cbo_Time"
    Me.cbo_Time.Size = New System.Drawing.Size(126, 21)
    Me.cbo_Time.TabIndex = 1
    '
    'ctl_MasterCal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.Controls.Add(Me.tbl_Layout)
    Me.MinimumSize = New System.Drawing.Size(90, 20)
    Me.Name = "ctl_MasterCal"
    Me.Size = New System.Drawing.Size(295, 66)
    Me.tbl_Layout.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents tbl_Layout As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents cbo_Time As System.Windows.Forms.ComboBox

End Class
