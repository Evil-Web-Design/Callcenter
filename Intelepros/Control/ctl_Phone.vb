Imports System.Windows.Forms.Design
Imports System.ComponentModel
Imports System.Windows.Forms

'<ToolStripItemDesignerAvailabilityAttribute(ToolStripItemDesignerAvailability.All), DefaultEvent("TextChanged")> _
<DefaultEvent("TextChanged")>
Public Class ctl_Phone
  Public Shadows Event TextChanged(sender As Object, e As EventArgs)
  Public Shadows Event KeyUp(sender As Object, e As KeyEventArgs)
  Public Shadows Event KeyPress(sender As Object, e As KeyPressEventArgs)
  Public Shadows Event LostFocus(sender As Object, e As EventArgs)
  Public Shadows Event GotFocus(sender As Object, e As EventArgs)
  Private Sub ctl_Phone_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
    RaiseEvent LostFocus(Me, e)
  End Sub
  Private Sub ctl_Phone_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
    RaiseEvent GotFocus(Me, e)
  End Sub
  Private Sub txt_Area_GotFocus(sender As Object, e As EventArgs) Handles txt_Area.GotFocus, txt_Prefix.GotFocus, txt_Suffix.GotFocus
    Dim Part As TextBox = CType(sender, TextBox)
    Part.SelectionStart = 0
    Part.SelectionLength = Part.TextLength
  End Sub
  Private Sub txt_Area_LostFocus(sender As Object, e As EventArgs) Handles txt_Area.LostFocus, txt_Prefix.LostFocus, txt_Suffix.LostFocus

  End Sub
  Private Structure PhoneParts
    Dim Area As String
    Dim Prefix As String
    Dim DNIS As String
  End Structure
  Public Enum Enum_FieldType
    Telephone
    SS
    Zip
    CreditCard
  End Enum
  Private ThisValue As PhoneParts
  Private PBackColor As Color
  Private Updating As Boolean = False
  'Private ThisFont As New Font("MS Sans Serif", 8, FontStyle.Regular, GraphicsUnit.Point, Nothing)
  Public Property FieldType As Enum_FieldType = Enum_FieldType.Telephone
  Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    'ThisFont = Font ' New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

    ' Add any initialization after the InitializeComponent() call.
    FieldType = Enum_FieldType.Telephone
    ThisValue = New PhoneParts With {.Area = "", .Prefix = "", .DNIS = ""}
    PBackColor = Color.FromArgb(255, 255, 255, 255)
    UpdateMe()
  End Sub
  Private Function Isnumber(ByVal KCode As String) As Boolean
    Dim Returnvar As Boolean = True
    If Not IsNumeric(KCode) And KCode <> ChrW(Keys.Back) And KCode <> ChrW(Keys.Enter) And KCode <> "."c Then
      Returnvar = False
    End If
    Return Returnvar
  End Function
  'Public Overrides Property Font() As Font
  '  Get
  '    Return ThisFont
  '  End Get
  '  Set(NewValue As Font)
  '    ThisFont = NewValue

  '    txt_Area.Font = ThisFont
  '    txt_Prefix.Font = ThisFont
  '    txt_Suffix.Font = ThisFont
  '    LBL_1.Font = ThisFont
  '    LBL_2.Font = ThisFont
  '    LBL_3.Font = ThisFont

  '  End Set
  'End Property
  <Browsable(True)>
  Public ReadOnly Property IsValid As Boolean
    Get
      Return ((ThisValue.Area.Length + ThisValue.Prefix.Length + ThisValue.DNIS.Length) = 10)
    End Get
  End Property
  <Browsable(True)>
Public Property Value As String
    Set(NewValue As String)
      If Not IsNothing(NewValue) Then Update_ThisValue(NewValue)
    End Set
    Get
      'Return Format(Long.Parse(ThisValue), "(###) ###-####")
      Dim RV As PhoneParts
      If ThisValue.Area.Length = 0 Then RV.Area = ThisValue.Area Else RV.Area = ThisValue.Area.PadLeft(3, "0")
      If ThisValue.Prefix.Length = 0 Then RV.Prefix = ThisValue.Prefix Else RV.Prefix = ThisValue.Prefix.PadLeft(3, "0")
      If ThisValue.DNIS.Length = 0 Then RV.DNIS = ThisValue.DNIS Else RV.DNIS = ThisValue.DNIS.PadLeft(4, "0")
      Return RV.Area & RV.Prefix & RV.DNIS
      ' Return ThisValue.Area.PadLeft(3, "0") & ThisValue.Prefix.PadLeft(3, "0") & ThisValue.DNIS.PadLeft(4, "0")
    End Get
  End Property
  Public Overrides Property Text As String
    Get
      Return Value
    End Get
    Set(NewValue As String)
      Value = NewValue
    End Set
  End Property
  Public Overrides Property BackColor As Color
    Get
      Return PBackColor
    End Get
    Set(NewValue As Color)
      PBackColor = NewValue
      UpdateMe()
    End Set
  End Property
  Sub Update_ThisValue(NewValue)
    Updating = True
    Dim charsToTrim() As Char = {"("c, ")"c, "-"c, " "c}
    For Each item In charsToTrim
      NewValue = NewValue.Replace(item, "")
    Next
    If NewValue.Length = 10 Then
      ThisValue.Area = NewValue.Substring(0, 3)
      ThisValue.Prefix = NewValue.Substring(3, 3)
      ThisValue.DNIS = NewValue.Substring(6, 4)
    ElseIf NewValue.Length = 7 Then
      ThisValue.Area = ""
      ThisValue.Prefix = NewValue.Substring(0, 3)
      ThisValue.DNIS = NewValue.Substring(3, 4)
    Else
      ThisValue.Area = ""
      ThisValue.Prefix = ""
      ThisValue.DNIS = ""
    End If
    txt_Area.Text = ThisValue.Area
    txt_Prefix.Text = ThisValue.Prefix
    txt_Suffix.Text = ThisValue.DNIS
    Updating = False
  End Sub

  Public Sub Changed(sender As Object, e As EventArgs) Handles txt_Area.TextChanged, txt_Prefix.TextChanged, txt_Suffix.TextChanged
    RaiseEvent TextChanged(Me, e)
  End Sub
  Private Sub txt_Area_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Area.KeyPress, txt_Prefix.KeyPress, txt_Suffix.KeyPress
    If Not Isnumber(e.KeyChar) Then
      e.KeyChar = ""
    End If
    RaiseEvent KeyPress(sender, e)
  End Sub
  Private Sub ctl_Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
    RaiseEvent KeyPress(sender, e)
  End Sub
  Private Sub txt_Area_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_Area.KeyUp, txt_Prefix.KeyUp, txt_Suffix.KeyUp
    Dim Part As TextBox = CType(sender, TextBox)
    Select Case Part.Name
      Case "txt_Area", "txt_Prefix"
        If Part.TextLength = 3 And Part.SelectionLength = 0 Then Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
      Case "txt_Suffix"
        'If Part.TextLength = 4 Then Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
    End Select
    ThisValue.Area = txt_Area.Text
    ThisValue.Prefix = txt_Prefix.Text
    ThisValue.DNIS = txt_Suffix.Text
    RaiseEvent KeyUp(Me, e)
  End Sub



  Private Sub ctl_Phone_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
    UpdateMe()
  End Sub

  Private Sub ctl_Phone_FontChanged(sender As Object, e As EventArgs) Handles MyBase.FontChanged
    UpdateMe()
  End Sub
  Sub UpdateMe()
    txt_Area.Font = Font
    txt_Prefix.Font = Font
    txt_Suffix.Font = Font
    LBL_1.Font = Font
    LBL_2.Font = Font
    LBL_3.Font = Font

    txt_Area.BackColor = PBackColor
    txt_Prefix.BackColor = PBackColor
    txt_Suffix.BackColor = PBackColor
    LBL_1.BackColor = PBackColor
    LBL_2.BackColor = PBackColor
    LBL_3.BackColor = PBackColor
    tbl_Layout.BackColor = PBackColor
  End Sub

End Class
