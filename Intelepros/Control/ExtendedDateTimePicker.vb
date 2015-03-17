Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class ExtendedDateTimePicker
  Inherits DateTimePicker

  Public Declare Auto Function GetWindowLong Lib "user32.dll" ( _
      ByVal hWnd As IntPtr, _
      ByVal nIndex As Int32 _
  ) As Int32

  Private Declare Auto Function SetWindowLong Lib "user32.dll" ( _
      ByVal hWnd As IntPtr, _
      ByVal nIndex As Int32, _
      ByVal dwNewLong As Int32 _
  ) As Int32

  Private Const GWL_STYLE As Int32 = (-16)

  Private Const MCM_FIRST As Int32 = &H1000
  Private Const MCM_GETMINREQRECT As Int32 = (MCM_FIRST + 9)
  Private Const MCS_WEEKNUMBERS As Int32 = &H4

  Private Const DTM_FIRST As Int32 = &H1000
  Private Const DTM_GETMONTHCAL As Int32 = (DTM_FIRST + 8)

  Private Declare Auto Function SendMessage Lib "user32.dll" ( _
      ByVal hWnd As IntPtr, _
      ByVal Msg As Int32, _
      ByVal wParam As IntPtr, _
      ByVal lParam As IntPtr _
  ) As IntPtr

  Private Declare Auto Function SendMessage Lib "user32.dll" ( _
      ByVal hWnd As IntPtr, _
      ByVal Msg As Int32, _
      ByVal wParam As IntPtr, _
      ByRef lParam As Rectangle _
  ) As IntPtr

  Private Declare Function MoveWindow Lib "user32.dll" ( _
      ByVal hwnd As IntPtr, _
      ByVal x As Int32, _
      ByVal y As Int32, _
      ByVal nWidth As Int32, _
      ByVal nHeight As Int32, _
      ByVal bRepaint As Boolean _
  ) As Int32

  Private m_ShowWeekNumbers As Boolean

  < _
      Browsable(True), _
      DesignerSerializationVisibility( _
          DesignerSerializationVisibility.Visible _
      ) _
  > _
  Public Property ShowWeekNumbers() As Boolean
    Get
      Return m_ShowWeekNumbers
    End Get
    Set(ByVal Value As Boolean)
      m_ShowWeekNumbers = Value
    End Set
  End Property

  Protected Overloads Overrides Sub OnDropDown(ByVal e As EventArgs)
    Dim hMonthView As IntPtr = _
        SendMessage(Me.Handle, DTM_GETMONTHCAL, IntPtr.Zero, IntPtr.Zero)
    Dim dwStyle As Int32 = GetWindowLong(hMonthView, GWL_STYLE)
    If Me.ShowWeekNumbers Then
      dwStyle = dwStyle Or MCS_WEEKNUMBERS
    Else
      dwStyle = dwStyle And Not MCS_WEEKNUMBERS
    End If
    Dim rct As Rectangle
    SetWindowLong(hMonthView, GWL_STYLE, dwStyle)
    SendMessage(hMonthView, MCM_GETMINREQRECT, IntPtr.Zero, rct)
    MoveWindow(hMonthView, 0, 0, rct.Right + 2, rct.Bottom, True)
    MyBase.OnDropDown(e)
  End Sub
End Class