Imports System.Runtime.InteropServices

Public Class Frm_Main
  Dim Hidden As Boolean = False
  Protected Overrides Sub WndProc(ByRef m As Message)
    If m.Msg = NativeMethods.WM_SHOWME Then
      ShowMe()
    End If
    MyBase.WndProc(m)
  End Sub
  Private Sub ShowMe()
    If WindowState = FormWindowState.Minimized Then
      WindowState = FormWindowState.Normal
    End If
    ' get our current "TopMost" value (ours will always be false though)
    Dim top As Boolean = TopMost
    ' make our form jump to the top of everything
    TopMost = True
    ' set it back to whatever it was
    TopMost = top
  End Sub
#Region "Events"
  Protected Overrides Sub SetVisibleCore(ByVal value As Boolean)
    If Not Me.IsHandleCreated Then
      Me.CreateHandle()
      value = Not CC.CurStaff.Rights.SimpleUI
    End If
    MyBase.SetVisibleCore(value)
  End Sub
  Private Sub mnu_HideMain_Click(sender As Object, e As EventArgs) Handles mnu_HideMain.Click, mnu_HideMain_Main.Click
    If Hidden Then
      Me.Show()
      mnu_HideMain.Text = "Hide Menu Window"
      mnu_HideMain_Main.Text = "Hide Menu Window"
    Else
      Me.Hide()
      mnu_HideMain.Text = "Show Menu Window"
      mnu_HideMain_Main.Text = "Show Menu Window"
      TrayIcon.ShowBalloonTip(5000, "Call Center minimized to the tray", "Click this Icon for all options.", ToolTipIcon.Info)
    End If
    Hidden = Not Hidden
  End Sub
  Private Sub mnu_ResetWindows_Click(sender As Object, e As EventArgs) Handles mnu_ResetWindows.Click, mnu_ResetWindows_Main.Click
    Dim regKey As New RegEdit(AppName)
    regKey.ClearallFormLocations()
    regKey.Close()
  End Sub
  Private Sub Frm_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

  End Sub
  Private Sub Frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim TempControlsActive = ControlsActive : ControlsActive = False
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


      mnu_SnoopMySQL.Visible = CC.CurStaff.AccessLevel = enum_AccessLevel.Admin
      cmd_SnoopMySQL.Visible = CC.CurStaff.AccessLevel = enum_AccessLevel.Admin
    End With
    If Not CC.CurStaff.Rights.SimpleUI Then Me.Show()
    TrayIcon.ShowBalloonTip(5000, "Call Center Loaded", "Right Click this Icon to get started", ToolTipIcon.Info)
    Dim regKey As New RegEdit(AppName)
    regKey.GetSavedFormLocation(Me, RegEdit.Enum_FormPos.Location)
    regKey.Close()
    ControlsActive = TempControlsActive
  End Sub




  Private Sub Frm_SignIn_Move(sender As Object, e As EventArgs) Handles MyBase.Move, MyBase.Resize
    If ControlsActive Then
      Dim regKey As New RegEdit(AppName)
      regKey.SetSavedFormLocation(Me)
      regKey.Close()
    End If
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
  Private Sub cmd_Contact_ButtonClick(sender As Object, e As EventArgs) Handles mnu_OpenContact.Click, cmd_Contact.ButtonClick
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
  Private Sub cmd_LocationSettings_Click(sender As Object, e As EventArgs) Handles cmd_LocationSettings.Click, mnu_LocationSettings.Click
    OpenLocationSettings()
  End Sub
#End Region
#Region "Functions"


#End Region

  Private Sub cmd_Simple_Click(sender As Object, e As EventArgs) Handles cmd_Simple.Click, mnu_Simple.Click
    OpenNewRecord(True)
  End Sub

  Private Sub mnu_LogOut_Click(sender As Object, e As EventArgs) Handles cmd_LogOut.Click, mnu_LogOut.Click
    InitSystem()
  End Sub

  Private Sub mnu_SnoopMySQL_Click(sender As Object, e As EventArgs) Handles mnu_SnoopMySQL.Click, cmd_SnoopMySQL.Click
    OpenMySQL()
  End Sub
End Class
