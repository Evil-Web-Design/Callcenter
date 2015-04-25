'Title:       Display any usercontrol as a popup menu
'Author:      Pascal GANAYE
'Email:       pascalcp@ganaye.com
'Environment: VB.NET 2003
'Keywords:    Popup, Contextual, Menu, Tooltip
'Level:       Beginner
'Description: This class let you show any usercontrol in XP style popup menu.

' feb 12, 2005 - Modification by Stumpy842 alias Steven Stover
'           Added line to prevent showing in taskbar 
'           Changed 4 dockpadding into one dockpadding.all

Option Explicit On 
Option Strict On
Imports System.ComponentModel

Public Class Popup
   Inherits System.ComponentModel.Component

   Public Interface IPopupUserControl
      Function AcceptPopupClosing() As Boolean
   End Interface

   Enum ePlacement
      Left = 1
      Right = 2
      Top = 4
      Bottom = 8
      TopLeft = Top Or Left
      TopRight = Top Or Right
      BottomLeft = Bottom Or Left
      BottomRight = Bottom Or Right
   End Enum
   Private mResizable As Boolean = False
   Private mUserControl As Control
  Private mParent As Control
  Private mPlacement As ePlacement = ePlacement.BottomLeft
   Private mBorderColor As Color = Color.DarkGray
   Private mAnimationSpeed As Integer = 150
   Private mShowShadow As Boolean = True

   Private mForm As PopupForm

  Sub New(Optional ByVal UserControl As Control = Nothing, Optional ByVal parent As Control = Nothing)
    mParent = parent
    mUserControl = UserControl
  End Sub

  'Sub New(ByVal UserControl As Control, parent As Object)
  '  ' TODO: Complete member initialization 
  '  mParent = parent
  '  mUserControl = UserControl
  'End Sub

   Public Sub Show()
      ' I use a shared variable in PopupForm class level for this ShowShadow
      ' because the CreateParams is called from within the form constructor 
      ' and we need a way to inform the form if a shadow is nescessary or not
      PopupForm.mShowShadow = Me.mShowShadow
      If Not mForm Is Nothing Then mForm.DoClose()
      mForm = New PopupForm(Me)
      OnDropDown(mParent, New EventArgs)
   End Sub
  Public Sub Hide()
    If Not mForm Is Nothing Then mForm.DoClose()
  End Sub
   ' This internal class is a borderless form used to show the popup
   Private Class PopupForm
      Inherits Form
      Public Shared mShowShadow As Boolean
      Private mClosing As Boolean
      Const BORDER_MARGIN As Integer = 1
      Private mTimer As Timer
      Private mControlSize As Size
      Private mWindowSize As Size
      Private mNormalPos As Point
      Private mCurrentBounds As Rectangle
      Private mPopup As Popup
      Private mPlacement As ePlacement
      Private mTimerStarted As DateTime
      Private mProgress As Double
      Dim mx, my As Integer
      Dim mResizing As Boolean
      Friend WithEvents mResizingPanel As Panel
      Private Const CS_DROPSHADOW As Integer = &H20000
      Private Shared mBackgroundImage As System.Drawing.Image
      Public Event DropDown(ByVal Sender As Object, ByVal e As EventArgs)
      Public Event DropDownClosed(ByVal Sender As Object, ByVal e As EventArgs)

      Sub New(ByVal popup As Popup)
         mPopup = popup
         setstyle(ControlStyles.ResizeRedraw, True)
         FormBorderStyle = FormBorderStyle.None
         StartPosition = FormStartPosition.Manual
         Me.ShowInTaskbar = False
         Me.DockPadding.All = BORDER_MARGIN
         mControlSize = mPopup.mUserControl.Size
         mPopup.mUserControl.Dock = DockStyle.Fill
         Controls.Add(mPopup.mUserControl)
         mWindowSize.Width = mControlSize.Width + 2 * BORDER_MARGIN
         mWindowSize.Height = mControlSize.Height + 2 * BORDER_MARGIN
         Dim parentForm As Form = mPopup.mParent.FindForm
         If Not parentForm Is Nothing Then
            parentForm.AddOwnedForm(Me)
         End If
         If mPopup.mResizable Then
            mResizingPanel = New Panel
            If mBackgroundImage Is Nothing Then
               Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Popup))
               mBackgroundImage = CType(resources.GetObject("CornerPicture.Image"), System.Drawing.Image)
            End If
            mResizingPanel.BackgroundImage = mBackgroundImage
            With mResizingPanel
               .Width = 12
               .Height = 12
               .BackColor = Color.Red
               .Left = mPopup.mUserControl.Width - 15
               .Top = mPopup.mUserControl.Height - 15
               .Cursor = Cursors.SizeNWSE
               .Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
               .Parent = Me
               .BringToFront()
            End With
         End If
         mPlacement = mPopup.mPlacement
         ' Try to place the popup at the asked location
         ReLocate()

         ' Check if the form is out of the screen 
         ' And if yes try to adapt the placement
         Dim workingArea As Rectangle = Screen.FromControl(mPopup.mParent).WorkingArea
         If mNormalPos.X + Me.Width > workingArea.Right Then
            If (mPlacement And ePlacement.Right) <> 0 Then
               mPlacement = (mPlacement And Not ePlacement.Right) Or ePlacement.Left
            End If
         ElseIf mNormalPos.X < workingArea.Left Then
            If (mPlacement And ePlacement.Left) <> 0 Then
               mPlacement = (mPlacement And Not ePlacement.Left) Or ePlacement.Right
            End If
         End If
         If mNormalPos.Y + Me.Height > workingArea.Bottom Then
            If (mPlacement And ePlacement.Bottom) <> 0 Then
               mPlacement = (mPlacement And Not ePlacement.Bottom) Or ePlacement.Top
            End If
         ElseIf mNormalPos.Y < workingArea.Top Then
            If (mPlacement And ePlacement.Top) <> 0 Then
               mPlacement = (mPlacement And Not ePlacement.Top) Or ePlacement.Bottom
            End If
         End If
         If mPlacement <> mPopup.mPlacement Then
            ReLocate()
         End If

         ' Check if the form is still out of the screen
         ' If yes just move it back into the screen without changing Placement
         If mNormalPos.X + mWindowSize.Width > workingArea.Right Then
            mNormalPos.X = workingArea.Right - mWindowSize.Width
         ElseIf mNormalPos.X < workingArea.Left Then
            mNormalPos.X = workingArea.Left
         End If
         If mNormalPos.Y + mWindowSize.Height > workingArea.Bottom Then
            mNormalPos.Y = workingArea.Bottom - mWindowSize.Height
         ElseIf mNormalPos.Y < workingArea.Top Then
            mNormalPos.Y = workingArea.Top
         End If

         ' Initialize the animation
         mProgress = 0
         If mPopup.mAnimationSpeed > 0 Then
            mTimer = New Timer
            ' I always aim 25 images per seconds.. seems to be a good value
            ' it looks smooth enough on fast computers and do not drain slower one
            mTimer.Interval = 1000 \ 25
            mTimerStarted = Now
            AddHandler mTimer.Tick, AddressOf Showing
            mTimer.Start()
            Showing(Nothing, Nothing)
         Else
            SetFinalLocation()
         End If
         Show()
         mPopup.OnDropDown(mPopup.mParent, New EventArgs)
      End Sub

      Public Shared Function DropShadowSupported() As Boolean
         Dim os As OperatingSystem = Environment.OSVersion
         Return (os.Platform = PlatformID.Win32NT) And os.Version.CompareTo(New Version(5, 1, 0, 0)) >= 0
      End Function

      Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
         Get
            Dim parameters As CreateParams = MyBase.CreateParams
            If (mShowShadow AndAlso DropShadowSupported()) Then
               parameters.ClassStyle = parameters.ClassStyle Or CS_DROPSHADOW
            End If
            Return parameters
         End Get
      End Property

      Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
         If disposing Then
            If Not mTimer Is Nothing Then
               mTimer.Dispose()
            End If
         End If
         MyBase.Dispose(disposing)
      End Sub

      Private Sub ReLocate()
      'Dim parent As Integer
         Dim rW, rH As Integer
         rW = mWindowSize.Width
         rH = mWindowSize.Height
         mNormalPos = mPopup.mParent.PointToScreen(New Point)
         Select Case mPlacement
            Case ePlacement.Top, ePlacement.TopLeft, ePlacement.TopRight
               mNormalPos.Y -= rH
            Case ePlacement.Bottom, ePlacement.BottomLeft, ePlacement.BottomRight
               mNormalPos.Y += mPopup.mParent.Height
            Case ePlacement.Left, ePlacement.Right
               mNormalPos.Y += (mPopup.mParent.Height - rH) \ 2
         End Select
         Select Case mPlacement
            Case ePlacement.Left
               mNormalPos.X -= rW
            Case ePlacement.TopRight, ePlacement.BottomRight
               ' nothing
            Case ePlacement.Right
               mNormalPos.X += mPopup.mParent.Width
            Case ePlacement.TopLeft, ePlacement.BottomLeft
               mNormalPos.X += mPopup.mParent.Width - rW
            Case ePlacement.Top, ePlacement.Bottom
               mNormalPos.X += (mPopup.mParent.Width - rW) \ 2
         End Select
      End Sub

      Private Sub Showing(ByVal sender As Object, ByVal e As EventArgs)
         mProgress = Now.Subtract(mTimerStarted).TotalMilliseconds / mPopup.mAnimationSpeed
         If mProgress >= 1 Then
            mTimer.Stop()
            RemoveHandler mTimer.Tick, AddressOf Showing
            AnimateForm(1)
         Else
            AnimateForm(mProgress)
         End If

      End Sub

      Protected Overrides Sub OnDeactivate(ByVal e As System.EventArgs)
         MyBase.OnDeactivate(e)
         If mClosing = False Then
            If TypeOf Me.mPopup.mUserControl Is IPopupUserControl Then
               mClosing = DirectCast(Me.mPopup.mUserControl, IPopupUserControl).AcceptPopupClosing()
            Else
               mClosing = True
            End If
            If mClosing Then DoClose()
         End If
      End Sub

      Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
         e.Graphics.DrawRectangle(New Pen(mPopup.mBorderColor), 0, 0, Me.Width - 1, Me.Height - 1)
      End Sub

      Private Sub SetFinalLocation()
         mProgress = 1
         AnimateForm(1)
         Invalidate()
      End Sub

      Private Sub AnimateForm(ByVal Progress As Double)
         Dim x, y, w, h As Double
         If Progress <= 0.1 Then Progress = 0.1
         Select Case mPlacement
            Case ePlacement.Top, ePlacement.TopLeft, ePlacement.TopRight
               y = 1 - Progress
               h = Progress
            Case ePlacement.Bottom, ePlacement.BottomLeft, ePlacement.BottomRight
               y = 0
               h = Progress
            Case ePlacement.Left, ePlacement.Right
               y = 0
               h = 1
         End Select
         Select Case mPlacement
            Case ePlacement.TopRight, ePlacement.BottomRight, ePlacement.Right
               x = 0
               w = Progress
            Case ePlacement.TopLeft, ePlacement.BottomLeft, ePlacement.Left
               x = 1 - Progress
               w = Progress
            Case ePlacement.Top, ePlacement.Bottom
               x = 0
               w = 1
         End Select
         mCurrentBounds.X = mNormalPos.X + CInt(x * mControlSize.Width)
         mCurrentBounds.Y = mNormalPos.Y + CInt(y * mControlSize.Height)
         mCurrentBounds.Width = CInt(w * mControlSize.Width) + 2 * BORDER_MARGIN
         mCurrentBounds.Height = CInt(h * mControlSize.Height) + 2 * BORDER_MARGIN
         Me.Bounds = mCurrentBounds
      End Sub

      Friend Sub DoClose()
         With mPopup
            Try
               .OnDropDownClosed(.mParent, New EventArgs)
            Finally
               .mUserControl.Parent = Nothing
               .mUserControl.Size = mControlSize
               .mForm = Nothing
               Dim parentForm As Form = mPopup.mParent.FindForm
               If Not parentForm Is Nothing Then
                  parentForm.RemoveOwnedForm(Me)
               End If
               parentForm.Focus()
               Close()
            End Try
         End With
      End Sub

      Private Sub mResizingPanel_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mResizingPanel.MouseUp
         mResizing = False
         Invalidate()
      End Sub

      Private Sub mResizingPanel_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mResizingPanel.MouseMove
         If mResizing Then
            Dim s As Size = Size
            s.Width += (e.X - mx)
            s.Height += (e.Y - my)
            Me.Size = s
         End If
      End Sub

      Private Sub mResizingPanel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mResizingPanel.MouseDown
         If e.Button = MouseButtons.Left Then
            mResizing = True
            mx = e.X
            my = e.Y
         End If
      End Sub

      Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
         MyBase.OnLoad(e)
         ' for some reason setbounds do not work well in the constructor
         Me.Bounds = mCurrentBounds
      End Sub
   End Class

   Protected Overridable Sub OnDropDown(ByVal Sender As Object, ByVal e As EventArgs)
      RaiseEvent DropDown(Sender, e)
   End Sub

   Protected Overridable Sub OnDropDownClosed(ByVal Sender As Object, ByVal e As EventArgs)
      RaiseEvent DropDownClosed(Sender, e)
   End Sub

#Region "Public properties and events"

   Public Event DropDown(ByVal Sender As Object, ByVal e As EventArgs)
   Public Event DropDownClosed(ByVal Sender As Object, ByVal e As EventArgs)

   <DefaultValue(False)> _
   Public Property Resizable() As Boolean
      Get
         Return mResizable
      End Get
      Set(ByVal Value As Boolean)
         mResizable = Value
      End Set
   End Property

   <Browsable(False)> Public Property UserControl() As Control
      Get
         Return mUserControl
      End Get
      Set(ByVal Value As Control)
         mUserControl = Value
      End Set
   End Property

   <Browsable(False)> Public Property Parent() As Control
      Get
         Return mParent
      End Get
      Set(ByVal Value As Control)
         mParent = Value
      End Set
   End Property

   <DefaultValue(GetType(ePlacement), "BottomLeft")> _
      Public Property HorizontalPlacement() As ePlacement
      Get
         Return mPlacement
      End Get
      Set(ByVal Value As ePlacement)
         mPlacement = Value
      End Set
   End Property

   <DefaultValue(GetType(Color), "DarkGray")> _
   Public Property BorderColor() As Color
      Get
         Return mBorderColor
      End Get
      Set(ByVal Value As Color)
         mBorderColor = Value
      End Set
   End Property

   <DefaultValue(True)> _
   Public Property ShowShadow() As Boolean
      Get
         Return mShowShadow
      End Get
      Set(ByVal Value As Boolean)
         mShowShadow = Value
      End Set
   End Property

   <DefaultValue(150)> _
   Public Property AnimationSpeed() As Integer
      Get
         Return mAnimationSpeed
      End Get
      Set(ByVal Value As Integer)
         mAnimationSpeed = Value
      End Set
   End Property
#End Region

   Friend WithEvents CornerPicture As System.Windows.Forms.PictureBox

   ' not called, just an easy way to embed the resizing corner bitmap for the PopupForm
   Private Sub InitializeComponent()
      Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Popup))
      Me.CornerPicture = New System.Windows.Forms.PictureBox
      '
      'CornerPicture
      '
      Me.CornerPicture.Image = CType(resources.GetObject("CornerPicture.Image"), System.Drawing.Image)
      Me.CornerPicture.Location = New System.Drawing.Point(17, 17)
      Me.CornerPicture.Name = "CornerPicture"
      Me.CornerPicture.TabIndex = 0
      Me.CornerPicture.TabStop = False

   End Sub
End Class
