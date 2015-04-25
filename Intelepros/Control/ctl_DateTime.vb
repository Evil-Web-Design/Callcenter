Public Class ctl_DateTime
  Implements Popup.IPopupUserControl
#Region "Public"

  Public Enum Mode
    View
    Edit
  End Enum
  Public Shadows Event SetDate(NewDate As Date)
  Public Shadows Event AddDate(NewDate As Date)
  Public Shadows Event DeleteDate(RemoveDate As Date)
  Public Shadows Event Cancel()
  Public Shadows Event Close()
  Public Property DisplayMode() As Mode
    Get
      Return Display_Mode
    End Get
    Set(ByVal value As Mode)
      Display_Mode = value
      ReloadCal(DisplayVal, SelectedVal)
    End Set
  End Property
  Public Property SelectedDate() As Date
    Get
      Return SelectedVal
    End Get
    Set(ByVal value As Date)
      ReloadCal(value, value, ItemExists(value))
    End Set
  End Property
  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    DisplayVal = Now
    SelectedVal = DisplayVal
    BuildCal()
    ReloadCal(DisplayVal, SelectedVal)
  End Sub
  Shadows Sub Update()
    'AvailDates = Nothing
    ReloadCal(DisplayVal, SelectedVal)
  End Sub
  Public Sub AddAvailDate(NewAvailDate As Date, Optional Wave As Integer = default_Int, Optional RealWave As Integer = default_Int)
    Dim index As Integer = 0
    If IsNothing(PAvailDates) Then
      ReDim PAvailDates(index)
    Else
      index = PAvailDates.Length
      ReDim Preserve PAvailDates(index)
    End If
    With PAvailDates(index)
      .DateTime = NewAvailDate
      .Wave = Wave
      .RealWave = RealWave
    End With
    'Console.Write("------AddAvailDate:" & AvailDate & vbCrLf)
    'If autoUpdate Then ParseDates()
  End Sub
  Public Sub RemoveAvailDate(RemoveAvailDate As Date)
    If Not IsNothing(PAvailDates) Then
      ItemExists(RemoveAvailDate, False, True)
    End If
  End Sub
  Public Structure Type_AvailDate
    Dim DateTime As Date
    Dim Wave As Integer
    Dim RealWave As Integer
  End Structure
  Public ReadOnly Property ReAvailDates As Type_AvailDate()
    Get
      Return PAvailDates
    End Get
  End Property
#End Region
#Region "Private"
  Private NewShowTime As Date = Now
  Private PAvailDates As Type_AvailDate()
  Private DisplayVal As Date
  Private SelectedVal As Date
  Private Display_Mode As Mode = Mode.View
  Private SetButton As SetMode
  Private Enum SetMode
    Disabled
    EventSet
    AddTime
    DeleteTime
  End Enum
  Private Enum Week
    Sun
    Mon
    Tues
    Wed
    Thur
    Fri
    Sat
  End Enum
#Region "Events"
  Private Sub ctl_DateTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'ReloadCal(Now, Now)
  End Sub
  Private Sub cmd_Forward_Click(sender As Object, e As EventArgs) Handles cmd_Forward.Click
    DisplayVal = DisplayVal.AddMonths(1)
     ReloadCal(DisplayVal, SelectedVal)
  End Sub
  Private Sub cmd_Back_Click(sender As Object, e As EventArgs) Handles cmd_Back.Click
    DisplayVal = DisplayVal.AddMonths(-1)
    ReloadCal(DisplayVal, SelectedVal)
  End Sub
  Private Sub cmd_MouseHover(sender As Object, e As EventArgs) Handles cmd_Back.MouseHover, cmd_Forward.MouseHover, cmd_Today.MouseHover
    Tip.Show(sender.tag, sender)
  End Sub
  Private Sub cmd_Today_Click(sender As Object, e As EventArgs) Handles cmd_Today.Click
    ReloadCal(Now, Now)
  End Sub
  Private Sub cmd_Day_Click(sender As Object, e As EventArgs) Handles cmd_DayTemplate.Click
    Dim ThisCtl As Button = CType(sender, Button)
    SelectedVal = CDate(DisplayVal.ToString("MM/") & ThisCtl.Text & DisplayVal.ToString("/yyyy"))
    clear(True)
    ThisCtl.FlatAppearance.BorderSize = 1
    ThisCtl.FlatAppearance.BorderColor = Color.Black
    FillTimes(lst_Times, PAvailDates)
    UpdateSetButton()
  End Sub
  Private Sub lst_Times_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Times.SelectedIndexChanged
    If ControlsActive Then
      log("lst_Times_SelectedIndexChanged")
      Dim Obj_ListBox As ListBox = CType(sender, ListBox)
      If Not IsNothing(Obj_ListBox.SelectedItem) Then
        Dim Obj_Value As String = CType(Obj_ListBox.SelectedItem, ValueDescriptionPair).Value
        SelectedVal = Obj_Value 'SelectedVal.ToString("MM/dd/yyyy") ' & lst_Times.Text
        UpdateSetButton(True)
      End If
    End If
  End Sub
  Private Sub Time_Set_Enter(sender As Object, e As EventArgs) Handles Time_Set.Enter
    If ControlsActive Then UpdateSetButton()
  End Sub
  Private Sub Time_Set_ValueChanged(sender As Object, e As EventArgs) Handles Time_Set.ValueChanged
    If ControlsActive Then UpdateSetButton()
  End Sub
  Private Sub cmd_Set_Click(sender As Object, e As EventArgs) Handles cmd_Set.Click
    Select Case SetButton
      Case SetMode.AddTime
        'Add New Time to AvailDates for Selected Date 
        If Not ItemExists(NewShowTime) Then
          AddAvailDate(NewShowTime)
          ReloadCal(DisplayVal, SelectedVal)
          RaiseEvent AddDate(NewShowTime)
        End If
      Case SetMode.DeleteTime
        If ItemExists(SelectedVal) Then
          RemoveAvailDate(SelectedVal)
          ReloadCal(DisplayVal, SelectedVal)
          RaiseEvent DeleteDate(SelectedVal)
        End If
      Case SetMode.EventSet
        RaiseEvent SetDate(SelectedVal)
    End Select
    SetButton = SetMode.Disabled
    DrawSelectedDate() 'This COULD cause issues if RaiseEvent closes form.
  End Sub
  Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
    If DisplayMode = Mode.View Then
      RaiseEvent Cancel()
    Else
      RaiseEvent Close()
    End If
    'Me.Dispose()
  End Sub
  Public Function AcceptPopupClosing() As Boolean Implements Popup.IPopupUserControl.AcceptPopupClosing
    'If RbNone.Checked Then
    'CustomTooltip.ShowTooltip(Label3, Popup.ePlacement.Right, "You must select a direction" & vbCrLf & "The popup won't disappear until you make a choice")
    'Return False
    'Else
    Return True
    'End If
  End Function
#End Region
#Region "Functions / Subs"
  Private Sub BuildCal()
    Dim days As List(Of Week) = [Enum].GetValues(GetType(Week)).Cast(Of Week)().ToList()
    MonthLayout.Controls.Clear()
    Dim TabIndex As Integer = 0
    For day As Integer = 0 To 6
      MonthLayout.Controls.Add(New Label With {
        .Text = days(day).ToString,
        .ForeColor = Color.Black,
        .BackColor = Color.LightGray,
        .Dock = System.Windows.Forms.DockStyle.Fill,
        .TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
        .Margin = New System.Windows.Forms.Padding(1),
        .Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    }, day, 0)
    Next

    For day As Integer = 0 To 6
      For row As Integer = 1 To 6
        TabIndex += 1
        Dim NewDay As New Button With {.Name = "X" & day & "Y" & row, .Text = "", .TabIndex = TabIndex, .Enabled = False}
        With cmd_DayTemplate
          NewDay.Dock = .Dock
          NewDay.Font = .Font
          NewDay.ForeColor = .ForeColor
          NewDay.FlatStyle = .FlatStyle
          NewDay.Margin = .Margin
          NewDay.UseVisualStyleBackColor = .UseVisualStyleBackColor
          NewDay.FlatAppearance.BorderSize = .FlatAppearance.BorderSize
          NewDay.FlatAppearance.BorderColor = .FlatAppearance.BorderColor
          NewDay.FlatAppearance.MouseDownBackColor = .FlatAppearance.MouseDownBackColor
          NewDay.FlatAppearance.MouseOverBackColor = .FlatAppearance.MouseOverBackColor
        End With
        MonthLayout.Controls.Add(NewDay, day, row)
        AddHandler NewDay.Click, AddressOf cmd_Day_Click
      Next
    Next
    clear()
  End Sub
  Private Sub DrawSet(Optional Text As String = "")
    Time_Set.Visible = Display_Mode = Mode.Edit
    Select Case SetButton
      Case SetMode.Disabled
        If Text.Length = 0 Then cmd_Set.Text = "-" Else cmd_Set.Text = Text
      Case SetMode.AddTime
        cmd_Set.Text = "Add"
      Case SetMode.DeleteTime
        cmd_Set.Text = "Delete"
      Case SetMode.EventSet
        cmd_Set.Text = "Set"
    End Select
    If DisplayMode = Mode.View Then
      cmd_Cancel.Text = "Cancel"
      tbl_Time.RowStyles(1).Height = 1
    Else
      cmd_Cancel.Text = "Close"
      tbl_Time.RowStyles(1).Height = 25
    End If
    cmd_Set.Enabled = Not (SetButton = SetMode.Disabled)
  End Sub
  Private Sub ReloadCal(ByVal DisplayDate As Date, SelectedDate As Date, Optional TimeSelected As Boolean = False)
    If ControlsActive Then
      log("ReloadCal DisplayDate:" & DisplayDate & " SelectedDate:" & SelectedDate & " TimeSelected" & TimeSelected)
      DisplayVal = DisplayDate
      SelectedVal = SelectedDate
      On Error Resume Next
      clear()
      MonthName.Text = DisplayDate.ToString("MMMM,yyyy") ' monthstr(ldate.Month)
      Dim fdate As DayOfWeek = GetFirstOfMonthDay(DisplayDate)
      Dim Day As Integer = 1
      Dim row As Integer = 1
      Do
        Dim ThisLabel As Button = getLinkLabel(fdate, row)
        With ThisLabel
          .Text = Day
          .ForeColor = Color.Black
          Dim ThisDate As Date = CDate(DisplayDate.ToString("MM/") & Day.ToString & DisplayDate.ToString("/yyyy"))
          With .FlatAppearance
            'Selected Day
            If Day = SelectedDate.Day And DisplayDate.Month = SelectedDate.Month And DisplayDate.Year = SelectedDate.Year Then
              .BorderSize = 1
              .BorderColor = Color.Black
            Else
              .BorderSize = 0
            End If
          End With

          If ItemExists(ThisDate, True) Then
            .Enabled = True
            .BackColor = Color.LightSkyBlue
          Else
            If Display_Mode = Mode.View Then
              .Enabled = False
              If Day = Now.Day And DisplayDate.Month = Now.Month And DisplayDate.Year = Now.Year Then
                .BackColor = Color.Yellow
              Else
                .BackColor = Color.LightYellow
              End If
            Else
              .BackColor = Color.LightGreen
              .Enabled = True
            End If
          End If



        End With
        If fdate = DayOfWeek.Saturday Then row += 1
        fdate = tdate(fdate)
        Day += 1
        If Day = Date.DaysInMonth(DisplayDate.Year, DisplayDate.Month) + 1 Then Exit Do
      Loop
      FillTimes(lst_Times, PAvailDates)
      UpdateSetButton(TimeSelected)
    End If
  End Sub
  'Sub FillTimes()
  '  lst_Times.DataSource = Nothing
  '  lst_Times.Items.Clear()
  '  cmd_Set.Enabled = False
  '  If Not IsNothing(AvailDates) Then
  '    For Each Item As AvailDate In AvailDates
  '      With Item
  '        If .DateTime.Day = SelectedVal.Day And .DateTime.Month = SelectedVal.Month And .DateTime.Year = SelectedVal.Year Then
  '          lst_Times.Items.Add(.DateTime.ToString("hh:mm") & " - (" & .Slots & ")")
  '        End If
  '      End With
  '    Next
  '  End If
  'End Sub
  Private Sub FillTimes(Ctl_Listbox As ListBox, List() As Type_AvailDate)
    Dim TempControlsActive = ControlsActive : ControlsActive = False

    Ctl_Listbox.DataSource = Nothing
    Ctl_Listbox.Items.Clear()
    Dim VDP_Array As New ArrayList, selectedIndex As Integer = default_Int, CurrentItem As Integer = 0
    'VDP_Array.Add(New ValueDescriptionPair(default_Int, "Select Location"))
    If Not IsNothing(List) Then
      For Each item In List

        With item
          If .DateTime.Day = SelectedVal.Day And .DateTime.Month = SelectedVal.Month And .DateTime.Year = SelectedVal.Year Then
            Dim Text As String = item.DateTime.ToString("hh:mm tt") & " - (" & item.Wave & ")"
            VDP_Array.Add(New ValueDescriptionPair(item.DateTime, Text))

            If SelectedVal.Hour = .DateTime.Hour And SelectedVal.Minute = .DateTime.Minute Then selectedIndex = CurrentItem
            'lst_Times.Items.Add(.DateTime.ToString("hh:mm") & " - (" & .Slots & ")")
            CurrentItem += 1

          End If
        End With






        'Combo.Items.Add(item.Name)
      Next
    End If
    With Ctl_Listbox
      .DisplayMember = "Description"
      .ValueMember = "Value"
      .DataSource = VDP_Array
      .SelectedIndex = selectedIndex
    End With
    ControlsActive = TempControlsActive
  End Sub
  Private Function getLinkLabel(ByVal day As DayOfWeek, ByVal row As Integer) As System.Windows.Forms.Button
    Return getControlFromName(Me, "X" & day & "Y" & row)
  End Function
  Sub clear(Optional SelectionOnly As Boolean = False)
    For day As Integer = 0 To 6
      For row As Integer = 1 To 6
        Dim ThisLabel As Button = getLinkLabel(day, row)
        With ThisLabel
          If Not SelectionOnly Then
            .BackColor = Color.Gray
            .Enabled = False
            .Text = ""
            .Tag = ""
          End If
          With .FlatAppearance
            .BorderSize = 0
            .BorderColor = Color.Black
          End With
        End With
      Next
    Next
  End Sub
  Private Function GetFirstOfMonthDay(ByVal ThisDay As Date) As DayOfWeek
    Dim tday As DayOfWeek = ThisDay.DayOfWeek
    Dim tint As Integer = ThisDay.Day
    If tint = 1 Then
      Return tday
      Exit Function
    End If
    Do
      tint -= 1
      tday = ydate(tday)
      If tint = 1 Then Exit Do
    Loop
    Return tday
  End Function
  Private Function ydate(ByVal tday As DayOfWeek) As DayOfWeek
    Dim rday As DayOfWeek
    Select Case tday
      Case DayOfWeek.Sunday
        rday = DayOfWeek.Saturday
      Case DayOfWeek.Monday
        rday = DayOfWeek.Sunday
      Case DayOfWeek.Tuesday
        rday = DayOfWeek.Monday
      Case DayOfWeek.Wednesday
        rday = DayOfWeek.Tuesday
      Case DayOfWeek.Thursday
        rday = DayOfWeek.Wednesday
      Case DayOfWeek.Friday
        rday = DayOfWeek.Thursday
      Case DayOfWeek.Saturday
        rday = DayOfWeek.Friday
    End Select
    Return rday
  End Function
  Private Function tdate(ByVal tday As DayOfWeek) As DayOfWeek
    Dim rday As DayOfWeek
    Select Case tday
      Case DayOfWeek.Sunday
        rday = DayOfWeek.Monday
      Case DayOfWeek.Monday
        rday = DayOfWeek.Tuesday
      Case DayOfWeek.Tuesday
        rday = DayOfWeek.Wednesday
      Case DayOfWeek.Wednesday
        rday = DayOfWeek.Thursday
      Case DayOfWeek.Thursday
        rday = DayOfWeek.Friday
      Case DayOfWeek.Friday
        rday = DayOfWeek.Saturday
      Case DayOfWeek.Saturday
        rday = DayOfWeek.Sunday
    End Select
    Return rday
  End Function
  Sub ClearAvailDates()
    PAvailDates = Nothing
  End Sub
  Private Function ItemExists(Search As Date, Optional DateOnly As Boolean = False, Optional Remove As Boolean = False) As Boolean
    Dim Found As Boolean = False, Index As Integer = 0
    If Not IsNothing(PAvailDates) Then
      For Each Item As Type_AvailDate In PAvailDates
        With Item

          If .DateTime.Day = Search.Day And .DateTime.Month = Search.Month And .DateTime.Year = Search.Year Then
            If DateOnly Then
              Found = True : Exit For
            Else
              If .DateTime.Hour = Search.Hour And .DateTime.Minute = Search.Minute And .DateTime.ToString("tt") = Search.ToString("tt") Then
                Found = True : Exit For
              End If
            End If
          End If
          ' If .DateTime = Search Then Found = True : Exit For

        End With
        Index += 1
      Next
    End If
    If Remove Then
      System.Array.Clear(PAvailDates, Index, 1)

    End If
    Return Found
  End Function
  Private Function ItemExists(SearchArray As String(), Search As String) As Boolean
    Dim Found As Boolean = False
    If Not IsNothing(SearchArray) Then
      For Each Item As String In SearchArray
        If Item = Search Then Found = True : Exit For
      Next
    End If
    Return Found
  End Function

  Private Sub UpdateSetButton(Optional TimeSelected As Boolean = False)
    If DisplayMode = Mode.View Then
      If TimeSelected Then
        SetButton = SetMode.EventSet
      Else
        lst_Times.SelectedItem = Nothing
        SetButton = SetMode.Disabled
      End If

    Else
      If TimeSelected Then
        SetButton = SetMode.DeleteTime
      Else
        lst_Times.SelectedItem = Nothing
        Dim NewTime As String = Time_Set.Value.ToString("hh:mm:00 tt")
        NewShowTime = SelectedDate.ToString("MM/dd/yyyy") & " " & NewTime
        If ItemExists(NewShowTime) Then
          SetButton = SetMode.Disabled
        Else
          SetButton = SetMode.AddTime
        End If
      End If
    End If
    DrawSelectedDate(TimeSelected)
  End Sub
  Private Sub DrawSelectedDate(Optional TimeSelected As Boolean = False)
    Dim Dstr As String = SelectedVal.ToString("ddd, MMM ") & SelectedVal.Day.DisplayWithSuffix & "," & SelectedVal.ToString("yyy")
    If TimeSelected Then
      Dim Tstr As String = SelectedVal.ToString("hh:mm tt")
      lbl_Selected.Text = "On: " & Dstr & " At: " & Tstr
    Else
      If DisplayMode = Mode.View Then
        lbl_Selected.Text = "On: " & Dstr
      Else
        Dim Tstr As String = Time_Set.Value.ToString("hh:mm tt")
        lbl_Selected.Text = "On: " & Dstr & " At: " & Tstr
      End If

    End If
    DrawSet()
  End Sub
#End Region
#End Region
End Class
