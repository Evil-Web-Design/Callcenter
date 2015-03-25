Imports System.ComponentModel

'Imports System
'Imports System.Collections
'Imports System.Collections.Generic
'Imports System.Data
'Imports System.ComponentModel.Design    ' Important!!
'Imports System.Windows.Forms            ' Important!!

<DefaultEvent("SelectedIndexChanged")>
Public Class ctl_MasterCal
  Private Ctl_Active As Boolean = True
  Private ThisValue As Date


  Private PBackColor As Color
  Private PIsValid As Boolean = False
  Public Shadows Event SelectedIndexChanged(sender As Object, e As EventArgs)
  Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    ThisValue = New Date
    DateFormat = "ddd MMM dd yyyy"
    TimeFormat = "hh:mm:ss tt"
    'Console.Write("------New:" & ThisValue.ToString(DateFormat & " " & TimeFormat) & vbCrLf)
    Erase AvailDates
  End Sub

  Property autoUpdate As Boolean

  Private Sub cbo_Date_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Date.SelectedIndexChanged
    If Ctl_Active Then
      Dim Date_Value As String = CType(cbo_Date.SelectedItem, ValueDescriptionPair).m_Description
      Dim Time_Value As String = CType(cbo_Time.SelectedItem, ValueDescriptionPair).m_Description
      'Console.Write("cbo_Date_SelectedIndexChanged:" & Date_Value & vbCrLf)
      ThisValue = CDate(Date_Value & " " & Time_Value)
      ParseDates(Date_Value, True)
      PIsValid = ItemExists(AvailDates, ThisValue)
      SetDisplay()
      RaiseEvent SelectedIndexChanged(Me, e)
    End If
  End Sub
  Public Sub cbo_Time_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Time.SelectedIndexChanged
    If Ctl_Active Then
      Dim Date_Value As String = CType(cbo_Date.SelectedItem, ValueDescriptionPair).m_Description
      Dim Time_Value As String = CType(cbo_Time.SelectedItem, ValueDescriptionPair).m_Description
      'Console.Write("cbo_Time_SelectedIndexChanged:" & Time_Value & vbCrLf)
      ThisValue = CDate(Date_Value & " " & Time_Value)
      ParseDates(Date_Value)
      PIsValid = ItemExists(AvailDates, ThisValue)
      SetDisplay()
      RaiseEvent SelectedIndexChanged(Me, e)
    End If
  End Sub


  <Browsable(True)>
  Public ReadOnly Property IsValid As Boolean
    Get
      'Console.Write("PIsValid:" & PIsValid & vbCrLf)
      Return PIsValid
    End Get
  End Property
  <Browsable(True)>
  Public Property Value As Date
    Set(NewValue As Date)
      'Console.Write("------Set Value:" & NewValue.ToString(DateFormat & " " & TimeFormat) & vbCrLf)
      ThisValue = NewValue
      ParseDates()
      SetDisplay()
    End Set
    Get
      'Console.Write("Get Value:" & ThisValue.ToString(DateFormat & " " & TimeFormat) & vbCrLf)
      Return ThisValue
    End Get
  End Property
  <Browsable(True)>
  Public Property DateFormat As String
  <Browsable(True)>
  Public Property TimeFormat As String
  <Browsable(True)>
  Public Property AvailDates As Date()
  Sub ClearAvailDates()
    AvailDates = Nothing
    'Console.Write("ClearAvailDates:" & ThisValue & vbCrLf)
    ParseDates()
  End Sub


  Public Sub AddAvailDate(AvailDate As Date)
    Dim index As Integer = 0
    If IsNothing(AvailDates) Then
      ReDim AvailDates(index)
    Else
      index = AvailDates.Length
      ReDim Preserve AvailDates(index)
    End If
    AvailDates(index) = AvailDate
    'Console.Write("------AddAvailDate:" & AvailDate & vbCrLf)
    If autoUpdate Then ParseDates()
  End Sub
  Private Sub Add(ByRef StringArray As String(), newString As String)
    Dim index As Integer = 0
    If IsNothing(StringArray) Then
      ReDim StringArray(index)
    Else
      index = StringArray.Length
      ReDim Preserve StringArray(index)
    End If
    StringArray(index) = newString
    'Console.Write("AddString:" & newString & vbCrLf)
  End Sub

  Private Sub SetDisplay()
    cbo_Date.Font = Font
    cbo_Time.Font = Font
    cbo_Date.BackColor = PBackColor
    cbo_Time.BackColor = PBackColor
    tbl_Layout.BackColor = PBackColor
    ' Me.BackColor = Color.FromArgb(255, 255, 255, 255)
  End Sub
  Private Sub ctl_MasterCal_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
    SetDisplay()
  End Sub
  Private Sub ctl_MasterCal_FontChanged(sender As Object, e As EventArgs) Handles Me.FontChanged
    SetDisplay()
  End Sub
  Private Sub ctl_MasterCal_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
    UpdateMe()
  End Sub
  Sub UpdateMe()
    'Console.Write("UpdateMe:" & ThisValue.ToString(DateFormat & " " & TimeFormat) & vbCrLf)
    SetDisplay()
    ParseDates()
  End Sub
  'Ctl_Appt.AddMonth(New Field With {.FieldName = "hi"})
  Sub ParseDates()
    'Console.Write("------ParseDates()" & ThisValue & vbCrLf)
    Dim Dates As String()
    Erase Dates
    If Not IsNothing(AvailDates) Then
      For Each Item As Date In AvailDates
        If Not ItemExists(Dates, Item.ToString(DateFormat)) Then
          Add(Dates, Item.ToString(DateFormat))
          'Console.Write("ParseDates Add:" & Item.ToString(DateFormat) & vbCrLf)
        End If
      Next
      If Not ThisValue.ToString(DateFormat) = New Date().ToString(DateFormat) Then
        If Not ItemExists(Dates, ThisValue.ToString(DateFormat)) Then
          Add(Dates, ThisValue.ToString(DateFormat))
          Console.Write("ParseDates AddMissing Date:" & ThisValue.ToString(DateFormat) & vbCrLf)
        End If
      End If
    Else

    End If
    Ctl_Active = False
    FillCombo(cbo_Date, Dates, ThisValue.ToString(DateFormat), "Select Date")
    ParseDates(ThisValue.ToString(DateFormat))
    PIsValid = ItemExists(AvailDates, ThisValue)

    'FillCombo(cbo_Time, Nothing, "Select Time")
    'Console.Write("--------------------------------------------------- ParseDates" & vbCrLf)
    Ctl_Active = True
  End Sub
  Sub ParseDates(OnDate As String, Optional ResetTime As Boolean = False)
    'Console.Write("------ParseDates:" & ThisValue & "         OnDate:" & OnDate & vbCrLf)
    Dim Times As String()
    Erase Times
    If Not IsNothing(AvailDates) Then

      For Each Item As Date In AvailDates
        If Item.ToString(DateFormat) = OnDate Then
          If Not ItemExists(Times, Item.ToString(TimeFormat)) Then
            Add(Times, Item.ToString(TimeFormat))
          End If
        End If
      Next
      ' If Not ThisValue.ToString(TimeFormat) = New Date().ToString(TimeFormat) Then
      If Not ItemExists(Times, ThisValue.ToString(TimeFormat)) Then
        Add(Times, ThisValue.ToString(TimeFormat))
        Console.Write("ParseDates AddMissing Time:" & ThisValue.ToString(TimeFormat) & vbCrLf)
      End If
      'Else
      'Console.Write(" Time is new:" & ThisValue.ToString(TimeFormat) & vbCrLf)
      ' End If
    End If
    'FillCombo(cbo_Date, Dates, "Select Date")
    Dim Temp As Boolean = Ctl_Active : Ctl_Active = False
    If ResetTime Then
      FillCombo(cbo_Time, Times, New Date().ToString(TimeFormat), "Select Time")
    Else
      FillCombo(cbo_Time, Times, ThisValue.ToString(TimeFormat), "Select Time")
    End If
    'Console.Write("---------------------------------------------------ParseDates" & vbCrLf)
    Ctl_Active = Temp
  End Sub
  Function ItemExists(SearchArray As String(), Search As String) As Boolean
    Dim Found As Boolean = False
    If Not IsNothing(SearchArray) Then
      For Each Item As String In SearchArray
        If Item = Search Then Found = True : Exit For
      Next
    End If
    Return Found
  End Function
  Function ItemExists(SearchArray As Date(), Search As Date) As Boolean
    Dim Found As Boolean = False
    If Not IsNothing(SearchArray) Then
      For Each Item As Date In SearchArray
        If Item = Search Then Found = True : Exit For
      Next
    End If
    Return Found
  End Function

  Private Sub FillCombo(Combo As ComboBox, Items As String(), Optional SelectedText As String = "", Optional SelectText As String = "Select")
    Combo.DataSource = Nothing
    Combo.Items.Clear()
    'Console.Write("FillCombo:-------------------------------------------------------" & vbCrLf)
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = 0, CurrentItem As Integer = 1
    VDP_Array.Add(New ValueDescriptionPair(-1, SelectText))
    Dim index As Integer = 0
    If IsNothing(Items) Then
      Combo.Enabled = False
    Else
      index += 1
      For Each Item As String In Items
        VDP_Array.Add(New ValueDescriptionPair(index, Item.ToString))
      Next
      Combo.Enabled = True
    End If
    With Combo
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      .SelectedIndex = finditem(Combo, SelectedText)
    End With
    'Console.Write("FillCombo:" & SelectedText & " selectedIndex:" & selectedIndex & " -=- " & finditem(Combo, SelectedText) & vbCrLf)
  End Sub

  Function finditem(Combo As ComboBox, SearchString As String) As Integer
    Dim index As Integer
    Dim table As ArrayList = DirectCast(Combo.DataSource, ArrayList)
    For i As Integer = 0 To table.Count - 1
      Dim Obj_Value As String = CType(table(i), ValueDescriptionPair).m_Description
      If SearchString = Obj_Value Then
        ' something to do e.g.
        index = i
      End If
    Next
    Return index
  End Function

End Class
#Region " Collection Experiment"

Public Class Field
  Private Item As Integer
  Private Name As String = "FieldName"
  Public Property FieldItem() As Integer
    Get
      Return Item
    End Get
    Set(ByVal value As Integer)
      Item = value
    End Set
  End Property
  Public Property FieldName() As String
    Get
      Return Name
    End Get
    Set(ByVal value As String)
      Name = value
    End Set
  End Property
End Class
Public Class Fields
  Inherits CollectionBase

  Default Public Property Item(ByVal Index As Integer) As Field
    Get
      Return CType(List.Item(Index), Field)
    End Get
    Set(ByVal value As Field)
      List.Item(Index) = value
    End Set
  End Property
  Public Sub Add(ByVal Item As Field)
    If List.Count = 0 Then
      List.Add(Item)
    Else
      For i = 0 To List.Count - 1
        Dim myField As New Field
        myField = List(i)
        If myField.FieldName = Item.FieldName Then
          Item.FieldName += "1"
        End If
      Next
      List.Add(Item)
    End If
  End Sub

End Class
'Public Class FieldCollection
'  Inherits CollectionEditor
'  Public Sub New()
'    MyBase.New(GetType(List(Of Field)))
'  End Sub
'End Class
#End Region
