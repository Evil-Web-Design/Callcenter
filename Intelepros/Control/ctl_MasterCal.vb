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
    DateFormat = "MM-dd-yyyy"
    TimeFormat = "hh:mm:ss tt"
    Erase AvailDates
  End Sub
  Private Sub cbo_Date_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Date.SelectedIndexChanged
    If Ctl_Active Then
      Dim Obj_Combo As ComboBox = CType(sender, ComboBox)
      Dim Obj_Value As String = CType(Obj_Combo.SelectedItem, ValueDescriptionPair).m_Description
      Console.Write("cbo_Date_SelectedIndexChanged:" & ThisValue & vbCrLf)
      ParseDates(Obj_Value, True)
      PIsValid = False
      RaiseEvent SelectedIndexChanged(Me, e)
    End If
  End Sub
  Public Sub cbo_Time_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Time.SelectedIndexChanged
    If Ctl_Active Then
      Dim Date_Value As String = CType(cbo_Date.SelectedItem, ValueDescriptionPair).m_Description
      Dim Time_Value As String = CType(cbo_Time.SelectedItem, ValueDescriptionPair).m_Description
      ThisValue = CDate(Date_Value & " " & Time_Value)


      PIsValid = ItemExists(AvailDates, ThisValue)
      RaiseEvent SelectedIndexChanged(Me, e)
    End If
  End Sub

  <Browsable(True)>
  Public ReadOnly Property IsValid As Boolean
    Get
      Return PIsValid
    End Get
  End Property
  <Browsable(True)>
  Public Property Value As Date
    Set(NewValue As Date)
      Console.Write("Set Value:" & NewValue & vbCrLf)
      ThisValue = NewValue
      ParseDates()
    End Set
    Get
      Console.Write("Get Value:" & ThisValue & vbCrLf)
      Return ThisValue
    End Get
  End Property
  <Browsable(True)>
  Public Property DateFormat As String
  <Browsable(True)>
  Public Property TimeFormat As String
  <Browsable(True)>
  Public Property AvailDates As Date()
  Sub Clear()
    AvailDates = Nothing
    Console.Write("Clear:" & ThisValue & vbCrLf)
    ParseDates()
  End Sub


  Public Sub Add(AvailDate As Date)
    Dim index As Integer = 0
    If IsNothing(AvailDates) Then
      ReDim AvailDates(index)
    Else
      index = AvailDates.Length
      ReDim Preserve AvailDates(index)
    End If
    AvailDates(index) = AvailDate
    Console.Write("Add:" & ThisValue & " AvailDate:" & AvailDate & vbCrLf)
    ParseDates()
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
  End Sub


  Private Sub ctl_MasterCal_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
    UpdateMe()
  End Sub
  Private Sub ctl_MasterCal_FontChanged(sender As Object, e As EventArgs) Handles Me.FontChanged
    UpdateMe()
  End Sub
  Private Sub ctl_MasterCal_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
    UpdateMe()
  End Sub
  Sub UpdateMe()
    cbo_Date.Font = Font
    cbo_Time.Font = Font
    cbo_Date.BackColor = PBackColor
    cbo_Time.BackColor = PBackColor
    tbl_Layout.BackColor = PBackColor
    If Not IsNothing(AvailDates) Then
      Console.Write("UpdateMe:" & ThisValue & vbCrLf)
      ParseDates()
    End If
  End Sub
  'Ctl_Appt.AddMonth(New Field With {.FieldName = "hi"})
  Sub ParseDates()
    Dim Dates As String()
    Erase Dates
    If Not IsNothing(AvailDates) Then
      For Each Item As Date In AvailDates
        If Not ItemExists(Dates, Item.ToString(DateFormat)) Then
          Add(Dates, Item.ToString(DateFormat))
          Console.Write("ParseDates Add:" & Item.ToString(DateFormat) & vbCrLf)
        End If
      Next
      If Not ThisValue = New Date Then
        If Not ItemExists(Dates, ThisValue.ToString(DateFormat)) Then
          Add(Dates, ThisValue.ToString(DateFormat))
          Console.Write("ParseDates Add:" & ThisValue & vbCrLf)
        End If
      End If
    End If
    Ctl_Active = False
    FillCombo(cbo_Date, Dates, ThisValue.ToString(DateFormat), "Select Date")
    Console.Write("ParseDates:" & ThisValue & vbCrLf)
    ParseDates(ThisValue.ToString(DateFormat))

    'FillCombo(cbo_Time, Nothing, "Select Time")
    Ctl_Active = True
  End Sub
  Sub ParseDates(OnDate As String, Optional ResetTime As Boolean = False)
    Dim Times As String()
    Erase Times
    If Not IsNothing(AvailDates) Then

      For Each Item As Date In AvailDates
        If Item.ToString(DateFormat) = OnDate Then
          If Not ItemExists(Times, Item.ToString(TimeFormat)) Then
            Add(Times, Item.ToString(TimeFormat))
            Console.Write("ParseDates " & OnDate & " Add:" & Item.ToString(TimeFormat) & vbCrLf)
          End If
        End If
      Next
      If Not ThisValue = New Date Then
        If Not ItemExists(Times, ThisValue.ToString(TimeFormat)) Then
          Add(Times, ThisValue.ToString(TimeFormat))
          Console.Write("ParseDates " & OnDate & " Add:" & ThisValue & vbCrLf)
        End If
      End If
    End If
    'FillCombo(cbo_Date, Dates, "Select Date")
    Dim Temp As Boolean = Ctl_Active : Ctl_Active = False
    If ResetTime Then
      FillCombo(cbo_Time, Times, New Date().ToString(TimeFormat), "Select Time")
    Else
      FillCombo(cbo_Time, Times, ThisValue.ToString(TimeFormat), "Select Time")
    End If
    Console.Write("ParseDates:" & ThisValue & "         ResetTime:" & ResetTime & vbCrLf)
    Console.Write("---------------------------------------------------" & vbCrLf)
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
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = 0, CurrentItem As Integer = 1
    VDP_Array.Add(New ValueDescriptionPair(-1, SelectText))
    Dim index As Integer = 0
    If IsNothing(Items) Then
      Combo.Enabled = False
    Else

      For Each Item As String In Items
        VDP_Array.Add(New ValueDescriptionPair(index, Item.ToString))
        If SelectedText.Length > 0 Then
          If SelectedText = Item.ToString Then
            selectedIndex = index
          End If
        End If
        index += 1
      Next
      Combo.Enabled = True
    End If
    With Combo
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      .SelectedIndex = selectedIndex
    End With
  End Sub



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
