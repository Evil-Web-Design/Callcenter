﻿Imports System.Runtime.InteropServices

Public Class Frm_Main
  Dim Hidden As Boolean = False
#Region "Events"
  Protected Overrides Sub SetVisibleCore(ByVal value As Boolean)
    If Not Me.IsHandleCreated Then
      Me.CreateHandle()
      value = Not CC.CurStaff.Rights.SimpleUI
    End If
    MyBase.SetVisibleCore(value)
  End Sub
  Private Sub cmd_Menu_Click(sender As Object, e As EventArgs) Handles cmd_Menu.Click
    If Hidden Then
      Me.Show()
      cmd_Menu.Text = "Hide Menu Window"
    Else
      Me.Hide()
      cmd_Menu.Text = "Show Menu Window"
    End If
    Hidden = Not Hidden
  End Sub
  Private Sub Frm_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

  End Sub
  Private Sub Frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    mnu_Main.Location = New Point(0, 0)
    With CC.CurStaff.Rights
      mnu_Main.Visible = True

      mnu_Search.Visible = .SearchBookings
      mnu_Settings.Visible = .EditSettings Or .EditEmployees
      mnu_Employees.Visible = .EditEmployees
      mnu_Database.Visible = .EditSettings
      mnu_Log.Visible = .EditSettings

      cmd_Search.Visible = .SearchBookings
      cmd_Settings.Visible = .EditSettings Or .EditEmployees
      cmd_Employees.Visible = .EditEmployees
      cmd_Database.Visible = .EditSettings
      cmd_Log.Visible = .EditSettings

    End With
    If Not CC.CurStaff.Rights.SimpleUI Then Me.Show()
    TrayIcon.ShowBalloonTip(5000, "Call Center Loaded", "Right Click this Icon to get started", ToolTipIcon.Info)
    Dim regKey As New RegEdit(AppName)
    regKey.GetSavedFormLocation(Me, RegEdit.Enum_FormPos.Location)
    regKey.Close()
  End Sub




  Private Sub Frm_SignIn_Move(sender As Object, e As EventArgs) Handles MyBase.Move, MyBase.Resize
    Dim regKey As New RegEdit(AppName)
    regKey.SetSavedFormLocation(Me)
    regKey.Close()
  End Sub

  <DllImportAttribute("user32.dll")> _
  Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
  End Function

  <DllImportAttribute("user32.dll")> Public Shared Function ReleaseCapture() As Boolean
  End Function

  Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown ', cmd_Search.MouseDown, cmd_Contact.MouseDown, cmd_Exit.MouseDown  ', Label1.MouseDown
    Const WM_NCLBUTTONDOWN As Integer = &HA1
    Const HT_CAPTION As Integer = &H2

    If e.Button = MouseButtons.Left Then
      ReleaseCapture()
      SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End If

  End Sub
  'Private Sub Button1_Click(sender As Object, e As EventArgs)
  '  TrayMenu.Show(CType(sender, Control), sender.Location)
  'End Sub
  Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick

  End Sub
  Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    'Mask()
  End Sub
  Sub Mask()
    Dim gpath As New Drawing2D.GraphicsPath 'gpath
    gpath.AddEllipse(New Rectangle(1, 1, 159, 85))
    Me.Region = New Region(gpath)
    gpath.Dispose()
  End Sub
  Private Sub Frm_Main_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
    AppRunning = False
  End Sub
  Private Sub notifyIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles TrayIcon.MouseClick
    If e.Button = MouseButtons.Left Then
      TrayIcon.ContextMenuStrip = TrayMenu
      GetType(NotifyIcon).GetMethod("ShowContextMenu", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).Invoke(TrayIcon, Nothing)
      TrayIcon.ContextMenuStrip = ContextMenuStrip
    End If
  End Sub
  Private Sub TrayIcon_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrayIcon.MouseMove
    'TrayIcon.ShowBalloonTip(5000, "Title", "Hello World", ToolTipIcon.Info)
  End Sub

  Private Sub cmd_Search_Click(sender As Object, e As EventArgs) Handles mnu_Search.Click, cmd_Search.Click
    OpenSearch()
  End Sub
  Private Sub cmd_OpenContact_Click(sender As Object, e As EventArgs) Handles mnu_OpenContact.Click, cmd_Contact.Click
    OpenNewRecord()
  End Sub
  Private Sub mnu_Exit_Click(sender As Object, e As EventArgs) Handles mnu_Exit.Click, cmd_Exit.Click
    If OktoExit() Then Me.Dispose()
  End Sub
  Private Sub mnu_Database_Click(sender As Object, e As EventArgs) Handles mnu_Database.Click, cmd_Database.Click
    OpenSettings()
    InitSystem()
  End Sub
  Private Sub mnu_Employees_Click(sender As Object, e As EventArgs) Handles mnu_Employees.Click, cmd_Employees.Click
    OpenEmployees()
  End Sub
  Private Sub mnu_Log_Click(sender As Object, e As EventArgs) Handles mnu_Log.Click, cmd_Log.Click
    OpenLog()
  End Sub

#End Region
#Region "Functions"


#End Region



End Class