Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text


Public Class Class_CallCenter
  Public Enum enum_EmpAction
    Booked = 1
    Confirmed = 2
  End Enum
  Public Enum enum_DateAction
    BookedOn = 1
    AppointmentOn = 2
  End Enum
  Public Enum enum_AccessLevel
    Restricted = 0
    Admin = 1
    Accounting = 2
    Manager = 3
    Confirmer = 4
    OP = 5
  End Enum
  Public Event MsgEvent(Messagetext As String)
  Public WithEvents DBManager As DataManager
  Public Structure Type_Simple
    Dim ID As Integer
    Dim Name As String
  End Structure
  Public Structure Type_Location
    Dim ID As Integer
    Dim CityID As Integer
    'Dim MailHouseID As Integer
    Dim Name As String
    Dim City As String
    'Dim MailHouse As String
    'Dim ClaimPrefex As String
    Dim Timezone As String
    'Dim HasRooms As Boolean
    Dim Enabled As Boolean
    Dim Script As Type_LocationScript()
    Dim Status As Type_Status()
    Dim ShowTimes As Type_ShowTimes()
    Dim Rooms As Type_Simple()
  End Structure
  Public Structure Type_LocationScript
    Dim LocationID As Integer, Name As String, Seq As Integer, Value As String, ID As Integer
  End Structure
  Public Structure Type_Promo
    Dim ID As Integer
    Dim ClaimNumber As String
    Dim CallDate As Date
    Dim StartDate As Date
    Dim Location As Type_Location

  End Structure
  Public Structure Type_Gift
    Dim ID As Integer
    Dim Name As String
    Dim Value As Decimal
    Dim Enabled As Boolean
  End Structure
  Public Structure Type_Booking
    Dim Location As Type_Location

    Dim ID As Integer
    Dim ClaimNumber As String
    Dim ClaimNumberValid As Boolean
    Dim ContactID As Integer
    Dim LocationID As Integer

    Dim ConfirmerID As Integer
    Dim StatusID As Integer
    Dim Status As String
    Dim BookerID As Integer

    Dim Booked As Date
    Dim Conf As Date
    Dim Appt As Date

    Dim Gift1_ID As Integer
    Dim Gift2_ID As Integer
    Dim Gift3_ID As Integer
    Dim Notes As String
  End Structure
  Public Structure Type_ContactBooking

    Dim Index As Integer
    Dim Booking As Type_Booking
    Dim Hist As Type_BookingHist()
    Dim Exists As Boolean
    'Dim Status As String
  End Structure
  Public Structure Type_BookingHist
    Dim ID As Integer
    Dim Index As Integer
    Dim EmployeeID As Integer
    Dim Employee As String
    Dim Field As String
    Dim OldVal As String
    Dim NewVal As String
    Dim OldValStr As String
    Dim NewValStr As String
    Dim ActionTime As Date
  End Structure
  Public Structure Type_ContactRecord
    Dim Contact As Type_Contact
    Dim Promo As Type_Promo
    Dim Booking As Type_ContactBooking()
    Dim BookingIndex As Integer
  End Structure
  Public Structure Type_Contact
    Dim ID As Integer
    'Dim LocationID As Integer
    'Dim CityID As Integer
    'Dim MailHouseID As Integer
    'following should be merged with Type_SearchResult
    'Dim ClaimNumber As String
    Dim Telephone As String
    Dim PF_Name As String
    Dim PL_Name As String
    Dim SF_Name As String
    Dim SL_Name As String
    Dim Address1 As String
    Dim Address2 As String
    Dim City As String
    Dim ST As String
    Dim Zip As String
    Dim Zip4 As String
    Dim Email As String
    Dim Fax As String
    Dim AltPhone As String
    Dim Notes As String

    'Dim PDOB As Date
    'Dim SDOB As Date
    'Dim Marital As Integer
    'Dim Income As Integer

  End Structure
  Public Structure Type_SearchCry
    Dim StatusID As Integer()
    Dim LocationID As Integer()
    Dim DeptID As Integer()
    '--------------------------
    Dim UseDates As Boolean
    Dim DateAction As enum_DateAction
    Dim DateStart As Date
    Dim DateEnd As Date
    '--------------------------
    Dim UseString As Boolean
    Dim SearchString As String
    '--------------------------
    Dim UseEmployee As Boolean
    Dim EmpAction As enum_EmpAction
    Dim EmployeeID As Integer
    '--------------------------
  End Structure
  Public Structure Type_SearchResult


    'Dim Location As String
    Dim Booker As String
    Dim Confirmer As String
    'Dim Statis As String

    Dim Contact As Type_Contact
    Dim Booking As Type_Booking

  End Structure
  Public Structure Type_Site
    Dim ID As Integer
    Dim Name As String
  End Structure
  Public Structure Type_Staff
    Dim ID As Long
    'Dim PA As Boolean
    Dim FirstName As String
    Dim LastName As String
    Dim OpName As String
    Dim SiteID As Integer

    Dim Address1 As String
    Dim Address2 As String
    Dim City As String
    Dim State As String
    Dim Zip As String

    Dim Phone As String
    Dim EContact As String
    Dim EContactPhone As String
    ' Dim SalesActive As Boolean
    'Dim Dept As String
    Dim ss As String
    Dim Active As Boolean
    Dim Password As String
    'Dim Message As String

    '    Dim Start_Date As String
    '    Dim Term_Date As String

    Dim AccessLevel As enum_AccessLevel
    Dim AccessLevelName As String
    Dim Rights As Type_StaffRights

    '    Dim DayAction() As Type_DayAction
    '    Dim Shift As String
    '    Dim ShiftShows As Integer
    '    Dim OfficeName As String
    '    Dim Display As Boolean

  End Structure
  Public Structure Type_AccessLevel
    Dim ID As enum_AccessLevel
    Dim Name As String
  End Structure
  Public Structure Type_AccessRights
    Dim ID As enum_AccessLevel
    Dim Name As String
    Dim Rights As Type_StaffRights
  End Structure

  Public Structure Type_StaffRights
    Dim ChangeBookDate As Boolean '1
    Dim SeeBooker As Boolean '2
    Dim EditSettings As Boolean '3
    Dim EditHours As Boolean '4
    Dim EditSchedule As Boolean '5
    Dim EditLockedBooking As Boolean '6
    Dim PublishBookings As Boolean '7
    Dim SearchBookings As Boolean '8
    Dim EditRecords As Boolean '9
    Dim EditBookings As Boolean '10
    Dim MultiRecordUI As Boolean '11
    Dim EditEmployees As Boolean '12
    Dim SimpleUI As Boolean '13
  End Structure

  Public Structure type_Hours
    Dim ID As Integer
    Dim StartTime As Date
    Dim EndTime As Date
  End Structure
  Public Structure Type_Status
    Dim ID As Integer
    Dim Name As String
    Dim LogOnly As Boolean
    Dim IsBooking As Boolean
    Dim Enabled As Boolean
    Dim LockBooking As Boolean
  End Structure
  Public Structure Type_ShowTimes
    Dim ID As Integer
    Dim LocationName As String
    Dim LocationID As Integer
    Dim Showtime As Date
    Dim Wave As Integer
    Dim RealWave As Integer
  End Structure
  Public Structure Type_Dept
    Dim ID As Integer
    Dim Name As String
  End Structure
  'Public Contact As Type_Contact
  'Public Record As Type_ContactRecord
  Public SearchResult As Type_SearchResult()
  Public SearchCry As Type_SearchCry
  Public CurStaff As Type_Staff
  Public StaffList As Type_Staff()
  Public RightsList As Type_AccessRights()
  Public SiteList As Type_Site()
  Public AccessLevel As Type_AccessLevel()

  Public Marital As Type_Simple()
  Public Income As Type_Simple()
  'Public WithEvents DBManager As DataManager

  Public Sub New()
    Erase Status
    Erase LocationList

    'MyBase.New(New Control())
  End Sub
  Sub DBEvent(Message As String) Handles DBManager.MsgEvent
    log(Message)
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub


#Region "Get...listIndex"
  Public Function GetStafflistIndex(StaffID As Integer) As Integer
    Dim Index As Integer = default_Int
    If Not IsNothing(StaffList) Then
      For i As Integer = 0 To StaffList.Length - 1
        If StaffList(i).ID = StaffID Then Index = i
      Next
    End If
    Return Index
  End Function
  Public Function GetLocationlistIndex(LocationID As Integer) As Integer
    Dim Index As Integer = default_Int
    If Not IsNothing(LocationList) Then
      For i As Integer = 0 To LocationList.Length - 1
        If LocationList(i).ID = LocationID Then Index = i
      Next
    End If
    Return Index
  End Function
  Public Function GetStatuslistIndex(StatusID As Integer) As Integer
    Dim Index As Integer = default_Int
    If Not IsNothing(Status) Then
      For i As Integer = 0 To Status.Length - 1
        If Status(i).ID = StatusID Then Index = i
      Next
    End If
    Return Index
  End Function
  Public Function GetBookingsIDIndex(Record As Type_ContactRecord, BookingsID As Integer) As Integer
    Dim Index As Integer = default_Int
    If Not IsNothing(Record.Booking) Then
      For i As Integer = 0 To Record.Booking.Length - 1
        If Record.Booking(i).Booking.ID = BookingsID Then Index = i
      Next
    End If
    Return Index
  End Function
#End Region

#Region "Record"
  Public Sub initMarital()
    Dim sSQL As String = "SELECT * FROM tbl_Marital ORDER BY Name"
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
    Marital = ReadSimpleRdr(Rdr)
    DBManager.CloseConnection()
  End Sub
  Public Sub initIncome()
    Dim sSQL As String = "SELECT * FROM tbl_Income ORDER BY Name"
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
    Income = ReadSimpleRdr(Rdr)
    DBManager.CloseConnection()
  End Sub

  Function SearchRecords() As Boolean
    'Telephone, AltPhone, Fax, ClaimNumber, Email, LocationID, ConfirmerID, StatusID, BookerID, Location, Booker, Confirmer, Status, Booked, Appt, PF_Name, PL_Name,  SF_Name, SL_Name 
    Dim Condution As String = ""
    With SearchCry

      Condution = AddWhere(Condution, BuildDelemiter("StatusID", .StatusID), "AND")
      Condution = AddWhere(Condution, BuildDelemiter("LocationID", .LocationID), "AND")
      Condution = AddWhere(Condution, BuildDelemiter("DeptID", .DeptID), "AND")


      If .UseDates Then
        Dim DateString As String = ""
        If .DateAction = enum_DateAction.AppointmentOn Then DateString = "Appt" Else DateString = "Booked"

        Condution = AddWhere(Condution, "(CAST(" & DateString & " AS DATE) BETWEEN CONVERT(DATETIME, '" & .DateStart.ToString("yyyy-MM-dd") & " 00:00:00', 102) AND " & _
                              "CONVERT(DATETIME, '" & .DateEnd.ToString("yyyy-MM-dd") & " 00:00:00', 102))", "AND")
      End If
      If .UseString Then
        If .SearchString.Length > 0 Then
          Dim StringQuery As String = ""
          StringQuery = AddWhere(StringQuery, "Telephone like '%" & .SearchString & "%'")
          StringQuery = AddWhere(StringQuery, "AltPhone like '%" & .SearchString & "%'")
          StringQuery = AddWhere(StringQuery, "Fax like '%" & .SearchString & "%'")
          StringQuery = AddWhere(StringQuery, "ClaimNumber like '%" & .SearchString & "%'")
          StringQuery = AddWhere(StringQuery, "Email like '%" & .SearchString & "%'")
          StringQuery = AddWhere(StringQuery, "PF_Name like '%" & .SearchString & "%'")
          StringQuery = AddWhere(StringQuery, "PL_Name like '%" & .SearchString & "%'")
          StringQuery = AddWhere(StringQuery, "SF_Name like '%" & .SearchString & "%'")
          StringQuery = AddWhere(StringQuery, "SL_Name like '%" & .SearchString & "%'")
          Condution = AddWhere(Condution, "(" & StringQuery & ")", "AND")
        End If
      End If
      If .UseEmployee Then
        Dim EmpString As String = ""
        If .EmpAction = enum_EmpAction.Booked Then EmpString = "BookerID" Else EmpString = "ConfirmerID"
        Condution = AddWhere(Condution, EmpString & "=" & .EmployeeID, "AND")
      End If
    End With
    If Condution.Length > 0 Then Condution = " WHERE " & Condution
    Dim sSQL As String = "SELECT * FROM vw_SearchBookings" & Condution
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Erase SearchResult
    Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
    If Not IsNothing(Rdr) Then
      If Rdr.HasRows Then
        Dim NewItem As Integer = 0
        While Rdr.Read
          ReDim Preserve SearchResult(NewItem)
          SearchResult(NewItem) = Search_DataReader(Rdr)
          NewItem += 1
        End While
      End If
      Rdr.Close()
    End If
    DBManager.CloseConnection()
    Return False
  End Function
  Public Function FindClaim(ClaimNumber As String) As Boolean
    Dim TempRecord As New Class_CallCenter.Type_ContactRecord
    Return FindClaim(TempRecord, ClaimNumber)
  End Function
  Public Function FindClaim(ByRef Record As Type_ContactRecord, ClaimNumber As String) As Boolean ', ClaimNumber As String, Optional Telephone As String = ""
    Dim Found As Boolean = False
    If ClaimNumber.Length > 0 Then
      Dim sSQL As String = "SELECT TOP 1 * FROM vw_MailDropContact where ClaimNumber='" & ClaimNumber & "'"
      DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
      Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
      Record = Nothing
      Record.Promo.ClaimNumber = ClaimNumber
      Found = ContactReader(Rdr, Record.Contact, Record.Promo)
      DBManager.CloseConnection()
    End If
    Return Found ' Or RecordFound
  End Function

  Public Function FindRecord(ByRef Record As Type_ContactRecord) As Boolean
    Dim Found As Boolean = False, UpdatePhone As Boolean = False
    Dim sSQL As String = "SELECT TOP 1 * FROM vw_Contact where Telephone='" & Record.Contact.Telephone & "'"
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
    Record = Nothing
    Found = ContactReader(Rdr, Record.Contact)
    DBManager.CloseConnection()
    Return Found
  End Function
  Public Function FindRecord(ByRef Record As Type_ContactRecord, ContactID As Integer) As Boolean
    Dim Found As Boolean = False, UpdatePhone As Boolean = False
    Dim sSQL As String = "SELECT TOP 1 * FROM vw_Contact where ContactID='" & ContactID & "'"
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
    Record = Nothing
    Found = ContactReader(Rdr, Record.Contact)
    DBManager.CloseConnection()
    Return Found
  End Function
  Function ContactReader(ByRef Rdr As SqlClient.SqlDataReader, ByRef Contact As Type_Contact,
                         Optional ByRef Promo As Type_Promo = Nothing) As Boolean
    Dim Found As Boolean = False
    If Not IsNothing(Rdr) Then
      If Rdr.HasRows Then
        While Rdr.Read
          Contact = ContactFrom_DataReader(Rdr)
          If Not IsNothing(Promo.ClaimNumber) Then Promo = PromoFrom_DataReader(Rdr)
          Found = True
        End While
      End If
      Rdr.Close()
    End If
    Return Found
  End Function





  'Function CreateContact(ByRef Record As Type_ContactRecord, Telephone As String) As Boolean
  '  Record.Contact.Telephone = Telephone
  '  Return CreateContact(Record)
  'End Function


  Function CreateContact(ByRef Record As Type_ContactRecord, Optional CreateNew As Boolean = False) As Boolean
    Dim Success As Boolean, Sqlstr As String
    If CreateNew Then
      Dim Telephone As String = Record.Contact.Telephone
      Record = New Type_ContactRecord
      With Record.Contact
        .Telephone = Telephone
        '.ID = default_Int
      End With

    End If

    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    With Record.Contact
      Sqlstr = "INSERT INTO tbl_Contact " & _
        "(Telephone, PF_Name, PL_Name, SF_Name, SL_Name, " & _
        "Address1, Address2, City, ST, Zip, Zip4, " & _
        "Email, Fax) " & _
        "VALUES ('" & .Telephone & "', '" & .PF_Name & "', '" & .PL_Name & "', '" & .SF_Name & "', '" & .SL_Name & "', " & _
        "'" & .Address1 & "', '" & .Address2 & "', '" & .City & "', N'" & .ST & "', N'" & .Zip & "', N'" & .Zip4 & "', " & _
        "N'" & .Email & "', N'" & .Fax & "')"
      Success = DBManager.RunSQL(Sqlstr)
    End With



    DBManager.CloseConnection()

    GetContactByRef(Record.Contact)
    Return Success
  End Function
  Function GetContactByRef(ByRef Contact As Type_Contact) As Boolean
    Dim SQLWhere As String = "", Found As Boolean = False
    With Contact
      AddWhere(SQLWhere, "Telephone='" & .Telephone & "'", " AND ")
      AddWhere(SQLWhere, "PF_Name='" & .PF_Name & "'", " AND ")
      AddWhere(SQLWhere, "PL_Name='" & .PL_Name & "'", " AND ")
      AddWhere(SQLWhere, "Email='" & .Email & "'", " AND ")
      AddWhere(SQLWhere, "Fax='" & .Fax & "'", " AND ")
      AddWhere(SQLWhere, "City='" & .City & "'", " AND ")
    End With
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Dim sSQL As String = "SELECT * FROM vw_Contact  WHERE " & SQLWhere
    Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
    Contact = Nothing
    Found = ContactReader(Rdr, Contact)
    DBManager.CloseConnection()
    Return Found
  End Function
  Function UpdateContactField(ByRef Record As Type_ContactRecord, Field As String, Value As String) As Boolean
    Dim Success As Boolean = False, Sqlstr As String
    If Record.Contact.ID > default_Int Then
      Sqlstr = "UPDATE tbl_Contact SET " & Field & " = '" & Value & "' WHERE (PK_ID = '" & Record.Contact.ID & "')"
      Success = RunSQL(Sqlstr)
    End If
    Return Success
  End Function
  Function UpdateContactBooking(ByRef ContactBooking As Type_ContactBooking, Field As String, NewValue As String, OldValue As String) As Boolean
    Dim Success As Boolean = False, Sqlstr As String
    If ContactBooking.Booking.ID > default_Int Then
      Sqlstr = "UPDATE tbl_Booking SET " & Field & " = '" & NewValue & "' WHERE (PK_ID = '" & ContactBooking.Booking.ID & "')"
      Success = RunSQL(Sqlstr)
      If Success Then InsertBookingHistory(ContactBooking.Booking.ID, Field, NewValue, OldValue)
    End If
    Return Success
  End Function
  Function CreateBooking(ByRef ContactBooking As Type_ContactBooking) As Boolean
    Dim Success As Boolean, Sqlstr As String
    With ContactBooking.Booking
      If (.ContactID > default_Int) And (.LocationID > default_Int) And (.StatusID > default_Int) And (.BookerID > default_Int) Then '2015-03-07 02:36:19
        Dim Claim As String = "", ClaimNumber As String = ""
        If .ClaimNumber.Length > 0 And .ClaimNumberValid Then Claim = ",ClaimNumber" : ClaimNumber = ",'" & .ClaimNumber & "'"
        Sqlstr = "INSERT INTO tbl_Booking (ContactID,LocationID,StatusID,BookerID,Booked" & Claim & ") " & _
            "VALUES (" & .ContactID & "," & .LocationID & "," & .StatusID & "," & .BookerID & ",CONVERT(DATETIME, '" & .Booked.ToString("yyyy-MM-dd hh:mm:00") & "', 102)" & ClaimNumber & ") "
        Success = RunSQL(Sqlstr)
        If Success Then Success = GetBookingByRef(ContactBooking)
      End If
      'Dim HasAppt As Boolean = .Appt <> YesterdayDateTime
    End With
    Return Success
  End Function
  Function GetBookingByRef(ByRef ContactBooking As Type_ContactBooking) As Boolean
    Dim Bookingindex As Integer = ContactBooking.Index
    Dim SQLWhere As String = "", Found As Boolean = False
    With ContactBooking.Booking
      AddWhere(SQLWhere, "ContactID='" & .ContactID & "'", " AND ")
      AddWhere(SQLWhere, "LocationID='" & .LocationID & "'", " AND ")
      AddWhere(SQLWhere, "StatusID='" & .StatusID & "'", " AND ")
      AddWhere(SQLWhere, "BookerID='" & .BookerID & "'", " AND ")
      If .ClaimNumber.Length > 0 Then AddWhere(SQLWhere, "ClaimNumber='" & .ClaimNumber & "'", " AND ")
      AddWhere(SQLWhere, "Booked='" & .Booked.ToString("yyyy-MM-dd hh:mm:00") & "'", " AND ")
    End With
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Dim sSQL As String = "SELECT * FROM vw_Booking  WHERE " & SQLWhere
    Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
    If Not IsNothing(Rdr) Then
      If Rdr.HasRows Then
        Found = True
        While Rdr.Read
          ContactBooking.Booking = BookingFrom_DataReader(Rdr)
          ContactBooking.Index = Bookingindex
        End While
      End If
      Rdr.Close()
    End If
    DBManager.CloseConnection()
    Return Found
  End Function
  Sub LoadContactBooking(ByRef ContactBooking As Type_ContactBooking)
    Dim Bookingindex As Integer = ContactBooking.Index
    Dim sSQL As String = "SELECT * FROM vw_Booking WHERE BookingID='" & ContactBooking.Booking.ID & "'"
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
    If Not IsNothing(Rdr) Then
      If Rdr.HasRows Then
        While Rdr.Read
          ContactBooking.Booking = BookingFrom_DataReader(Rdr)
          ContactBooking.Index = Bookingindex
        End While
      End If
      Rdr.Close()
    End If
    DBManager.CloseConnection()
  End Sub
  Public Sub LoadContactBookings(ByRef Record As Type_ContactRecord, Optional SelectedBookingID As Integer = default_Int)
    Erase Record.Booking
    Record.BookingIndex = default_Int
    Dim sSQL As String = "SELECT * FROM vw_Booking WHERE ContactID='" & Record.Contact.ID & "'"
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
    If Not IsNothing(Rdr) Then

      If Rdr.HasRows Then
        Dim NewItem As Integer = 0
        Record.BookingIndex = 0
        While Rdr.Read
          ReDim Preserve Record.Booking(NewItem)
          Record.Booking(NewItem).Booking = BookingFrom_DataReader(Rdr)
          With Record.Booking(NewItem)
            .Index = NewItem
            If SelectedBookingID = .Booking.ID Then Record.BookingIndex = .Index
            .Exists = True
          End With
          NewItem += 1
        End While

      End If
      Rdr.Close()
    End If
    DBManager.CloseConnection()

  End Sub
  Function UpdateBookingField(ByRef Record As Type_ContactRecord, _
                            Booking_Index As Integer, Field As String, Value As Object) As Boolean
    Dim Success As Boolean, Sqlstr As String
    If Not IsNothing(Record.Booking) Then
      With Record.Booking(Booking_Index).Booking

        Sqlstr = "UPDATE tbl_Booking SET " & Field & " = " & DBManager.Default_ToNULL(Value) & " WHERE (ID = " & .ID & ")"
        Success = RunSQL(Sqlstr)

      End With
    End If
    Return Success
  End Function
  Function InsertBookingHistory(ID As Integer, Field As String, NewValue As Object, OldValue As Object) As Boolean
    Dim Success As Boolean, Sqlstr As String
    If ID > default_Int Then

      Sqlstr = "INSERT INTO tbl_Booking_Hist " & _
        "(BookingID, EmployeeID, Field, Old, New, ActionTime) VALUES " & _
        "(" & ID & ", " & CurStaff.ID & ", N'" & Field & "', N'" & OldValue.ToString & "', N'" & NewValue.ToString & "', GETDATE())"
      Success = RunSQL(Sqlstr)

    End If
    Return Success
  End Function
  Public Sub LoadBookingHistory(ByRef Record As Type_ContactRecord, BookingIndex As Integer)

    Dim sSQL As String = "SELECT * FROM vw_Booking_Hist WHERE BookingID='" & Record.Booking(BookingIndex).Booking.ID & "'"
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
    If Not IsNothing(Rdr) Then
      If Rdr.HasRows Then
        With Record.Booking(BookingIndex)
          Dim NewItem As Integer = 0
          Erase .Hist
          While Rdr.Read

            ReDim Preserve .Hist(NewItem)
            .Hist(NewItem) = BookingHistFrom_DataReader(Rdr)
            .Hist(NewItem).Index = NewItem

            NewItem += 1
          End While
        End With
      End If
      Rdr.Close()
    End If

    DBManager.CloseConnection()
  End Sub
  Function UpdateMailPhone(ByRef Record As Type_ContactRecord, ClaimNumber As String, Telephone As String) As Boolean
    Dim Sqlstr As String
    Record.Contact.Telephone = Telephone
    Sqlstr = "UPDATE tbl_MailDropContact SET Telephone = " & Telephone & " WHERE (ClaimNumber = '" & ClaimNumber & "')"
    Return RunSQL(Sqlstr)
  End Function

#End Region
#Region "Staff"
  Public Function initStaff(Optional ByVal ActiveOnly As Boolean = True) As Type_Staff()

    Dim Condution As String = ""
    If ActiveOnly = True Then Condution = "WHERE (Active = 1) "
    Dim sSQL As String = "SELECT * FROM vw_Employee " & Condution & "ORDER BY FirstName"
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
    Erase StaffList
    If Not IsNothing(Rdr) Then

      If Rdr.HasRows Then
        Dim NewItem As Integer = 0
        While Rdr.Read
          ReDim Preserve StaffList(NewItem)
          StaffList(NewItem) = StaffFrom_DataReader(Rdr)
          NewItem += 1
        End While
      End If
      Rdr.Close()
    End If
    DBManager.CloseConnection()

    Return StaffList
  End Function
  Public Function initSite() As Type_Site()
    Dim sSQL As String = "SELECT * FROM tbl_Site"
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
    Erase SiteList
    If Not IsNothing(Rdr) Then
      If Rdr.HasRows Then
        Dim NewItem As Integer = 0
        While Rdr.Read
          ReDim Preserve SiteList(NewItem)
          With SiteList(NewItem)
            .ID = InputVar(Rdr("ID"), 0)
            .Name = InputVar(Rdr("Name"), "")
          End With
          NewItem += 1
        End While
      End If
      Rdr.Close()
    End If

    DBManager.CloseConnection()
    Return SiteList
  End Function
  Public Function initAccessLevel() As Type_AccessLevel()
    Dim sSQL As String = "SELECT * FROM vw_AccessLevelList where value=1"
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Erase AccessLevel
    Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
    If Not IsNothing(Rdr) Then

      If Rdr.HasRows Then
        Dim NewItem As Integer = 0
        While Rdr.Read
          ReDim Preserve AccessLevel(NewItem)
          With AccessLevel(NewItem)
            .ID = CType(InputVar(Rdr("ID"), 0), enum_AccessLevel)
            .Name = InputVar(Rdr("Name"), "")
          End With
          NewItem += 1
        End While
      End If
      Rdr.Close()
    End If
    DBManager.CloseConnection()

    Return AccessLevel
  End Function
  Public Function initRights() As Type_AccessRights()
    Dim sSQL As String = "SELECT * FROM  vw_AccessRights"
    Erase RightsList
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
    If Not IsNothing(Rdr) Then

      If Rdr.HasRows Then
        Dim NewItem As Integer = 0
        While Rdr.Read
          ReDim Preserve RightsList(NewItem)
          With RightsList(NewItem)
            .ID = CType(InputVar(Rdr("ID"), 0), enum_AccessLevel)
            .Name = InputVar(Rdr("Name"), "")
            .Rights = StaffRightsFrom_DataReader(Rdr)
          End With
          NewItem += 1
        End While
      End If
      Rdr.Close()
    End If
    DBManager.CloseConnection()

    Return RightsList
  End Function
  Sub SendMessage(EmailAddress As String, Name As String) ', ContactIndex As Integer
    CDO.ClearAddr(CDO.ToAddrs)
    CDO.AddMessageAddr(CDO.ToAddrs, EmailAddress, Name, EmailAddress)
    'If Not IsNothing(LocalAttrb.Setting.BCCAddress) Then _
    'If LocalAttrb.Setting.BCCAddress.Length > 0 Then CDO.AddMessageAddr(bccAddrs, LocalAttrb.Setting.BCCAddress)

    Dim Subject As String = "testMessage"
    Dim HtmlMessage As String = "Hello"
    Dim textMessage As String = "HI"
    If HtmlMessage.Length > 0 Then HtmlMessage = "<html>" & HtmlMessage & "</html>"

    If CDO.SendMail(CDO.ToAddrs, CDO.FromAddr, CDO.ccAddrs, CDO.bccAddrs, Subject, HtmlMessage, textMessage, Nothing, True, False) Then 'Call to ModMain

    End If
  End Sub
  Function CreateStaff(FirstName As String, LastName As String) As Boolean

    Dim Success As Boolean, Sqlstr As String

    Sqlstr = "INSERT INTO tbl_Employee " & _
      "(AccessLevelID, FirstName, LastName, SS, Phone, " & _
      "EContact, EContactPhone, Address1, Address2, City, State, Zip, Active, Password) " & _
      "VALUES (0, '" & FirstName & "', '" & LastName & "', '', '', '', '', '', '', '', '', '', 1, 'Password')"

    Success = RunSQL(Sqlstr)
 
    Return Success
  End Function
  Function GetStaffID(FirstName As String, LastName As String) As Integer
    Dim sSQL As String = "Select ID FROM tbl_Employee WHERE FirstName='" & FirstName & "' AND LastName='" & LastName & "'"
    Dim TheID As Integer = default_Int
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
    If Not IsNothing(Rdr) Then
      If Rdr.HasRows Then
        While Rdr.Read
          TheID = InputVar(Rdr("ID"), default_Int)
        End While
      End If
      Rdr.Close()
    End If
    DBManager.CloseConnection()
    Return TheID
  End Function
  Function UpdateStaffField(Staff As Type_Staff, Field As String, Value As String) As Boolean
    Return UPDATESQL("tbl_Employee", Field, Value, Staff.ID)
  End Function
  Function UpdateStaffField(Staff As Type_Staff, Field As String, Value As Integer) As Boolean
    Return UPDATESQL("tbl_Employee", Field, Value, Staff.ID)
  End Function
  Function UpdateStaffField(Staff As Type_Staff, Field As String, Value As Boolean) As Boolean
    Dim NewValue As Integer = 0 : If Value = True Then NewValue = 1
    Return UpdateStaffField(Staff, Field, NewValue)
  End Function
  Function UPDATESQL(Table As String, Field As String, Value As String, ID As Long, Optional ByVal DBConnection As DB = DB.CallCenter) As Boolean
    Return RunSQL("UPDATE " + Table + " SET " & Field & " = '" & Value & "' WHERE (ID = '" & ID & "')")
  End Function
  Function UPDATESQL(Table As String, Field As String, Value As Long, ID As Long, Optional ByVal DBConnection As DB = DB.CallCenter) As Boolean
    Return RunSQL("UPDATE " + Table + " SET " & Field & " = " & Value & " WHERE (ID = '" & ID & "')")
  End Function
  Function RunSQL(Sqlstr As String, Optional ByVal DBConnection As DB = DB.CallCenter) As Boolean
    Dim Index As Integer = DB_CallCenter
    Select Case DBConnection
      Case DB.CallCenter : Index = DB_CallCenter
      Case DB.Recordings : Index = DB_Recordings
    End Select
    Dim Success As Boolean = False
    Try
      DBManager = New DataManager(Connection(Index).connectionString)
      Success = DBManager.RunSQL(Sqlstr)
      DBManager.CloseConnection()
      Success = True
    Catch
      log("ERROR: " & Err.Description)
      Success = False
    End Try

    Return Success
  End Function
#Region "Timeclock"
  'SELECT ID, EmployeeID, StartTime, EndTime, Tardy, Absent, Notes, Timestamp FROM tbl_Hours
  Public Hours As type_Hours()
  Public ClockedIN As Boolean = False
  Private Function GetMondayForWeek(inputDate As DateTime) As DateTime
    Dim daysFromMonday As Integer = inputDate.DayOfWeek - DayOfWeek.Monday
    Return inputDate.AddDays(-daysFromMonday)
  End Function
  Private Function GetStartForWeek(inputDate As DateTime, Optional FirstDay As FirstDayOfWeek = FirstDayOfWeek.Sunday) As DateTime 'FirstDayOfWeek.System
    Dim daysFromStart As Integer = Weekday(inputDate, FirstDay)
    Return inputDate.AddDays(-daysFromStart)
  End Function
  Public Function GetSubsequentMonday(ByVal startDate As DateTime, ByVal subsequentWeeks As Integer) As DateTime
    Dim dayOfWeek As Integer = CInt(startDate.DayOfWeek)
    Dim daysUntilMonday As Integer = (Math.Sign(dayOfWeek) * (7 - dayOfWeek)) + 1
    'number of days until the next Monday
    Return startDate.AddDays(CDbl((daysUntilMonday + (7 * (subsequentWeeks - 1)))))
  End Function

  Public Shared Function Ordinal(number As Integer) As String
    Dim ones = number Mod 10
    Dim tens = Math.Floor(number / 10.0F) Mod 10
    If tens = 1 Then
      Return number & "th"
    End If
    Select Case ones
      Case 1
        Return number & "st"
      Case 2
        Return number & "nd"
      Case 3
        Return number & "rd"
      Case Else
        Return number & "th"
    End Select
  End Function
  Function NuRoundNearest(ByVal Number As Double, ByVal Interval As Double) As Double
    'Nucleus
    'Rounding Function developed To minimises floating point rounding errors
    If Interval = 0 Then NuRoundNearest = Number : Exit Function 'exit If interval = 0
    Dim r As Double, i As Long
    Interval = Math.Abs(Interval) 'only positive intervals considered
    r = Math.Abs(Number) / Interval 'result from dividing number by interval
    i = CLng(Int(r))  'the Integer value from the initial division (e.g. If r = 1.3, i = 1)
    'if remainder is less than 50% of the Next interval need To round down
    If r - i < 0.5 Then NuRoundNearest = i * Interval Else NuRoundNearest = (i + 1) * Interval
    If Number < 0 Then NuRoundNearest = NuRoundNearest * -1 ' account For negative numbers
  End Function
  Function TimeToNearest15Mins(ByVal stime As Date, Optional ReturnFormat As String = "hh:mm") As String
    Dim TimeToNearest = Format(TimeSerial(Hour(stime), CInt(NuRoundNearest(Minute(stime), 15)), 0), "hh:mm:ss")
    Return TimeToNearest.ToString
  End Function

  Function GetHours(EmployeeID As Integer, ForDate As Date) As type_Hours()
    Dim Condution As String = ""

    Dim Startdate As Date = GetStartForWeek(CDate(Now.ToString("MM/dd/yyyy")), FirstDayOfWeek.Monday)

    Dim Enddate As Date = DateAdd(DateInterval.Day, 7, Startdate)
    If EmployeeID > -1 Then Condution = " WHERE (EmployeeID = " & EmployeeID & ")" & _
  " AND (StartDate BETWEEN CONVERT(DATETIME, '" & Startdate.ToString("yyyy-MM-dd") & " 00:00:00', 102) AND " & _
                          "CONVERT(DATETIME, '" & Enddate.ToString("yyyy-MM-dd") & " 00:00:00', 102))"

    Dim sSQL As String = "SELECT * FROM vw_Hours" & Condution & " ORDER BY Timestamp"
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Dim rsList As Data.DataTable, ItemCount As Integer = 0
    rsList = DBManager.RetrieveDataTable(sSQL)
    Erase Hours
    If (rsList.Rows.Count > 0) Then
      ReDim Hours(rsList.Rows.Count - 1)
      Do While ItemCount < rsList.Rows.Count
        With Hours(ItemCount)
          .ID = InputVar(rsList.Rows(ItemCount).Item("ID"), 0)
          .StartTime = InputVar(rsList.Rows(ItemCount).Item("StartTime"), default_Date)
          .EndTime = InputVar(rsList.Rows(ItemCount).Item("EndTime"), default_Date)

          ClockedIN = CBool(.EndTime = default_Date)

        End With
        ItemCount = ItemCount + 1
      Loop
    End If
    DBManager.CloseConnection()
    Return Hours
  End Function

  Public Function PunchClock() As Boolean
    Dim Success As Boolean, Sqlstr As String
    Dim PunchTime As Date = CDate(Now.ToString("MM/dd/yyyy") & " " & TimeToNearest15Mins(Now, "MM/dd/yyyy hh:mm:ss"))
    Dim LastIndex As Integer = default_Int


    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    If ClockedIN Then
      'Update
      If Not IsNothing(Hours) Then
        LastIndex = Hours.Length - 1
        Sqlstr = "UPDATE tbl_Hours SET EndTime = '" & PunchTime & "' WHERE (ID = " & Hours(LastIndex).ID & ")"
        Success = DBManager.RunSQL(Sqlstr)
      Else
        Success = False
      End If
    Else
      'Insert
      Sqlstr = "INSERT INTO tbl_Hours (EmployeeID, StartTime) VALUES (" & CurStaff.ID & ", CONVERT(DATETIME, '" & PunchTime.ToString("yyyy-MM-dd hh:mm:ss") & "', 102))"
      Success = DBManager.RunSQL(Sqlstr)
    End If
    DBManager.CloseConnection()



    Return Success
  End Function
#End Region
#End Region
#Region "Status"
  Public Status As Type_Status()
  Public Sub initStatus(Optional Refresh As Boolean = False)
    If IsNothing(Status) Or Refresh Then
      Dim sSQL As String = "SELECT * FROM tbl_Status ORDER BY Name"
      DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
      Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
      Status = ReadStatusRdr(Rdr)
      DBManager.CloseConnection()
    End If
  End Sub
  Public Function GetStatus(StatusID As Integer) As Type_Status
    Dim Index As Integer = default_Int
    If Not IsNothing(Status) Then
      For i As Integer = 0 To Status.Length - 1
        If Status(i).ID = StatusID Then Index = i
      Next
    End If
    If Index > default_Int Then
      Return Status(Index)
    Else
      Return Nothing
    End If
  End Function
#End Region
#Region "Location"


  Public Function GetLocationScriptIndex(LocationID As Integer, PartID As Integer) As Integer
    Dim PIndex As Integer = GetLocationlistIndex(LocationID)
    If PIndex > default_Int Then
      Dim Index As Integer = default_Int
      With LocationList(PIndex)
        If Not IsNothing(.Script) Then
          For i As Integer = 0 To .Script.Length - 1
            If .Script(i).ID = PartID Then Index = i
          Next
        End If
      End With
      Return Index
    Else
      Return default_Int
    End If
  End Function
  Public LocationList As Type_Location()


  Public Sub initLocations(LocationID As Integer)
    GetLocations(LocationID)
  End Sub

  Public Function ClaimLocationName(ClaimPrefex As String) As Type_Location
    Dim Condition As String = "", ClaimLocation As Type_Location = Nothing
    If Not IsNothing(ClaimPrefex) Then Condition = BuildWhere(Condition, "'" & ClaimPrefex & "'", "ClaimPrefex")

    Dim sSQL As String = "SELECT * FROM vw_Locations" & Condition & " ORDER BY LocationName"
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
    If Not IsNothing(Rdr) Then
      If Rdr.HasRows Then
        Dim NewItem As Integer = 0
        While Rdr.Read
          ClaimLocation = LocationFrom_DataReader(Rdr)
          NewItem += 1
        End While
      End If
      Rdr.Close()
    End If

    DBManager.CloseConnection()
    Return ClaimLocation
  End Function
  Public Sub initLocations(Optional Refresh As Boolean = False)
    If IsNothing(LocationList) Then
      GetLocations()
    Else
      If Refresh Then GetLocations()
    End If
  End Sub
  Dim int_LocationID As Integer = default_Int, str_ClaimPrefex As String = ""
  Private Sub GetLocations(Optional LocationID As Integer = default_Int, Optional ClaimPrefex As String = Nothing)
    Dim Condition As String = ""
    'If IsNothing(LocationList) Or (int_LocationID > default_Int Or str_ClaimPrefex > default_Int) Then
    If LocationID > default_Int Then Condition = BuildWhere(Condition, LocationID.ToString, "ID")
    If Not IsNothing(ClaimPrefex) Then Condition = BuildWhere(Condition, "'" & ClaimPrefex & "'", "ClaimPrefex")

    Dim sSQL As String = "SELECT * FROM vw_Locations" & Condition & " ORDER BY LocationName"
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
    Erase LocationList
    If Not IsNothing(Rdr) Then
      If Rdr.HasRows Then
        Dim NewItem As Integer = 0
        While Rdr.Read
          ReDim Preserve LocationList(NewItem)
          LocationList(NewItem) = LocationFrom_DataReader(Rdr)
          NewItem += 1
        End While
      End If
      Rdr.Close()
    End If
    DBManager.CloseConnection()
  End Sub

  Public Sub initStatus(LocationID As Integer, Optional Refresh As Boolean = False)
    Dim Index As Integer = GetLocationlistIndex(LocationID)
    If Index > default_Int Then
      With LocationList(Index)
        If IsNothing(.Status) Or Refresh Then
          Dim sSQL = "SELECT * FROM vw_Location_Status WHERE (LocationID = " & .ID & ")"
          DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
          Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
          .Status = ReadStatusRdr(Rdr)
        End If
        DBManager.CloseConnection()
      End With
    End If
  End Sub
  Public Function GetLocationStatus(LocationID As Integer, StatusID As Integer) As Type_Status
    If LocationID > 0 Then
      Dim LocationIndex As Integer = GetLocationlistIndex(LocationID)
      Dim StatusIndex As Integer = default_Int
      If LocationIndex > default_Int Then

        With LocationList(LocationIndex)
          If Not IsNothing(.Status) Then
            For i As Integer = 0 To .Status.Length - 1
              If .Status(i).ID = StatusID Then StatusIndex = i
            Next
          End If
          If StatusIndex > default_Int Then
            Return .Status(StatusIndex)
          Else
            Return Nothing
          End If
        End With
      Else
        Return Nothing
      End If
    Else
      Return Nothing
    End If
  End Function


  Public Sub initShowTimes(LocationID As Integer, Optional Refresh As Boolean = False)
    Dim Index As Integer = GetLocationlistIndex(LocationID)
    If Index > default_Int Then
      With LocationList(Index)
        If IsNothing(.ShowTimes) Or Refresh Then
          Dim sSQL = "SELECT * FROM vw_ShowTimes WHERE (LocationID = " & .ID & ") ORDER BY Showtime"
          DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
          Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
          .ShowTimes = ReadShowTimesRdr(Rdr)
        End If
        DBManager.CloseConnection()
      End With
    End If
  End Sub

  Public Sub GetLocationScripts(LocationID As Integer)
    Dim Index As Integer = GetLocationlistIndex(LocationID)
    With LocationList(Index)
      If IsNothing(.Script) Then

        Dim sSQL As String = "SELECT * FROM vw_LocationScripts where LocationID='" & LocationID & "'"
        DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
        Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
        If Not IsNothing(Rdr) Then

          If Rdr.HasRows Then
            Dim NewItem As Integer = 0
            While Rdr.Read
              ReDim Preserve .Script(NewItem)
              .Script(NewItem) = LocationScriptFrom_DataReader(Rdr)
              NewItem += 1
            End While
          End If
          Rdr.Close()
        End If
        DBManager.CloseConnection()

      End If
    End With
  End Sub
  Dim Script_List As ArrayList
  Public Function GetScriptNames() As ArrayList

    Dim sSQL As String = "SELECT * FROM tbl_Script_Part"
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    If IsNothing(Script_List) Then
      Dim Rdr As SqlDataReader = DBManager.GetDataReaderFromQuery(sSQL)
      If Not IsNothing(Rdr) Then

        Script_List = New ArrayList
        If Rdr.HasRows Then
          Dim NewItem As Integer = 0
          While Rdr.Read
            Script_List.Add(New ValueDescriptionPair(InputVar(Rdr("ID"), default_Int),
                                                   InputVar(Rdr("Name"), "")))
          End While
        End If
        Rdr.Close()
      End If

    End If
    DBManager.CloseConnection()
    Return Script_List
  End Function

#End Region
#Region "Dept"
  Public DeptList As Type_Dept()
  Public Sub initDept()
    Dim sSQL As String = ""
    sSQL = "SELECT * FROM tbl_Dept ORDER BY Name"
    Dim rsList As Data.DataTable, ItemCount As Integer = 0
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    rsList = DBManager.RetrieveDataTable(sSQL)
    Erase GiftList
    If (rsList.Rows.Count > 0) Then
      ReDim GiftList(rsList.Rows.Count - 1)
      Do While ItemCount < rsList.Rows.Count
        With GiftList(ItemCount)
          .ID = InputVar(rsList.Rows(ItemCount).Item("ID"), 0)
          .Name = InputVar(rsList.Rows(ItemCount).Item("Name"), "")
        End With
        ItemCount = ItemCount + 1
      Loop
    End If
    DBManager.CloseConnection()
  End Sub
#End Region
#Region "Gift"
  Public GiftList As Type_Gift()
  Public Sub initGifts()
    Dim sSQL As String = ""
    sSQL = "SELECT * FROM tbl_Gift ORDER BY Name"
    Dim rsList As Data.DataTable, ItemCount As Integer = 0
    DBManager = New DataManager(Connection(DB_CallCenter).connectionString)
    rsList = DBManager.RetrieveDataTable(sSQL)
    Erase GiftList
    If (rsList.Rows.Count > 0) Then
      ReDim GiftList(rsList.Rows.Count - 1)
      Do While ItemCount < rsList.Rows.Count
        With GiftList(ItemCount)
          .ID = InputVar(rsList.Rows(ItemCount).Item("ID"), 0)
          .Name = InputVar(rsList.Rows(ItemCount).Item("Name"), "")
          .Value = InputVar(rsList.Rows(ItemCount).Item("Value"), New Decimal(0))
          .Enabled = InputVar(rsList.Rows(ItemCount).Item("Enabled"), False)
        End With
        ItemCount = ItemCount + 1
      Loop
    End If
    DBManager.CloseConnection()
  End Sub
#End Region
#Region "System"
  Private Sub log(Message As String, Optional Source As String = "-")
    ' FormMain.log(Message)
    RaiseEvent MsgEvent(Message)
  End Sub
  Public Function LoadServerList() As Boolean

    Dim ConIndex As Integer = 0, Retval As Boolean
    ReDim Preserve Connection(ConIndex) 'Zero out Extra Database Connections (Preserveing 0)
    Dim sSQL As String = "SELECT tbl_Databases.* From tbl_Databases order by DB;"
    DBManager = New DataManager(Connection(0).connectionString)
    Dim rsList As Data.DataTable, ItemCount As Integer = 0

    rsList = DBManager.RetrieveDataTable(sSQL)
    If (rsList.Rows.Count > 0) Then
      Do While ItemCount < rsList.Rows.Count
        ConIndex = InputVar(rsList.Rows(ItemCount)!db, 0)
        If ConIndex > 0 Then
          ReDim Preserve Connection(ConIndex)
          With Connection(ConIndex)
            .DataSource = InputVar(rsList.Rows(ItemCount)!Server, "")
            .Provider = InputVar(rsList.Rows(ItemCount)!Provider, "")
            .Database = InputVar(rsList.Rows(ItemCount)!DatabaseName, "")

            If .DataSource = "[InitialDataSource]" Then
              .DataSource = Connection(0).DataSource
              .UserName = Connection(0).UserName
              .UserPassword = Connection(0).UserPassword
            Else
              .UserName = InputVar(rsList.Rows(ItemCount)!UserName, "")
              .UserPassword = InputVar(rsList.Rows(ItemCount)!Password, "")
            End If
            '.OptionalDatabase = Data(ConIndex, RSIndex, "OptionalDatabase", adVarChar, "")
            .OptionalDatabase = InputVar(rsList.Rows(ItemCount)!OptionalDatabase, "")
            .Enabled = InputVar(rsList.Rows(ItemCount)!Enabled, False)
            If Len(.Provider) = 0 Then .Provider = "sqloledb"
            SetConntoString(Connection(ConIndex))

          End With
        End If
        ItemCount = ItemCount + 1
      Loop
      Retval = True
    Else
      Retval = False
    End If
    DBManager.CloseConnection()
    Return Retval
  End Function
  Public Function getdatabaseIndex(DB_Name As String) As Integer
    Dim index As Integer = -1
    For loopvar As Integer = 1 To Connection.Length - 1
      If Connection(loopvar).Database = DB_Name Then index = loopvar
    Next
    Return index
  End Function
#End Region
#Region "DataReader"
  Public Function StaffFrom_DataReader(ByRef Rdr As SqlClient.SqlDataReader) As Type_Staff
    Dim Staff As New Type_Staff
    Try
      With Staff
        'EmployeeID, SiteID, SiteName, FirstName, LastName, Address1, Address2, City, State, Zip, Phone, EContact, EContactPhone, SS
        .ID = InputVar(Rdr("EmployeeID"), 0)
        '.SiteID = InputVar(Rdr("SiteID"), 0)

        .FirstName = InputVar(Rdr("FirstName"), "")
        .LastName = InputVar(Rdr("LastName"), "")
        .OpName = .FirstName & " " & .LastName

        .Address1 = InputVar(Rdr("Address1"), "")
        .Address2 = InputVar(Rdr("Address2"), "")
        .City = InputVar(Rdr("City"), "")
        .State = InputVar(Rdr("State"), "")
        .Zip = InputVar(Rdr("Zip"), "")

        .Phone = InputVar(Rdr("Phone"), "")

        .EContact = InputVar(Rdr("EContact"), "")
        .EContactPhone = InputVar(Rdr("EContactPhone"), "")

        .ss = InputVar(Rdr("SS"), "")
        .Password = InputVar(Rdr("Password"), "")
        .Active = InputVar(Rdr("Active"), False)
        .AccessLevel = CType(InputVar(Rdr("AccessLevelID"), 0), enum_AccessLevel)
        .AccessLevelName = InputVar(Rdr("AccessLevelName"), "")
        .Rights = StaffRightsFrom_DataReader(Rdr)
      End With
    Catch
      log("ERROR: " & Err.Description, "StaffFrom_DataReader")
    End Try
    Return Staff
  End Function
  Public Function StaffRightsFrom_DataReader(ByRef Rdr As SqlClient.SqlDataReader) As Type_StaffRights
    Dim Rights As New Type_StaffRights
    Try
      With Rights
        .ChangeBookDate = InputVar(Rdr("ChangeBookDate"), False) '1
        .SeeBooker = InputVar(Rdr("SeeBooker"), False) '2
        .EditSettings = InputVar(Rdr("EditSettings"), False) '3
        .EditHours = InputVar(Rdr("EditHours"), False) '4
        .EditSchedule = InputVar(Rdr("EditSchedule"), False) '5
        .EditLockedBooking = InputVar(Rdr("EditLockedBooking"), False) '6
        .PublishBookings = InputVar(Rdr("PublishBookings"), False) '7
        .SearchBookings = InputVar(Rdr("SearchBookings"), False) '8
        .EditRecords = InputVar(Rdr("EditRecords"), False) '9'
        .EditBookings = InputVar(Rdr("EditBookings"), False) '10
        .MultiRecordUI = InputVar(Rdr("MultiRecordUI"), False) '11
        .EditEmployees = InputVar(Rdr("EditEmployees"), False) '12
        .SimpleUI = InputVar(Rdr("SimpleUI"), False) '12

      End With
    Catch
      log("ERROR: " & Err.Description, "StaffRightsFrom_DataReader")
    End Try
    Return Rights
  End Function
  Public Function PromoFrom_DataReader(ByRef Rdr As SqlClient.SqlDataReader) As Type_Promo
    Dim Promo As New Type_Promo
    Try
      With Promo
        .ID = InputVar(Rdr("PromoID"), default_Int)

        .ClaimNumber = InputVar(Rdr("ClaimNumber"), "")
        .CallDate = InputVar(Rdr("CallDate"), default_DateTime)
        .StartDate = InputVar(Rdr("StartDate"), default_Date)
        .Location = LocationFrom_DataReader(Rdr)

      End With
    Catch
      log("ERROR: " & Err.Description, "PromoFrom_DataReader")
    End Try
    Return Promo
  End Function
  Public Function Search_DataReader(ByRef Rdr As SqlClient.SqlDataReader) As Type_SearchResult
    'Telephone, AltPhone, Fax, ClaimNumber, Email, LocationID, ConfirmerID, StatusID, BookerID
    'Location, Booker, Confirmer, Statis, Booked, Appt, PF_Name, PL_Name,  SF_Name, SL_Name 

    Dim SearchResult As New Type_SearchResult
    Try
      With SearchResult
        .Booker = InputVar(Rdr("Booker"), "")
        .Confirmer = InputVar(Rdr("Confirmer"), "")
        .Booking = BookingFrom_DataReader(Rdr)
        .Contact = ContactFrom_DataReader(Rdr)
      End With
    Catch
      log("ERROR: " & Err.Description, "Search_DataReader")
    End Try
    Return SearchResult
  End Function
  Public Function LocationFrom_DataReader(ByRef Rdr As SqlDataReader) As Type_Location
    Dim Location As New Type_Location
    Try
      With Location
        .ID = InputVar(Rdr("LocationID"), default_Int)
        .CityID = InputVar(Rdr("CityID"), default_Int)
        '.MailHouseID = InputVar(Rdr("MailHouseID"), default_Int)
        .Name = InputVar(Rdr("LocationName"), "")
        .City = InputVar(Rdr("LocationCity"), "")
        '.ClaimPrefex = InputVar(Rdr("ClaimPrefex"), "")
        '.MailHouse = InputVar(Rdr("MailHouse"), "")
        .Timezone = InputVar(Rdr("Timezone"), "")
        '.HasRooms = InputVar(Rdr("HasRooms"), False)
        .Enabled = InputVar(Rdr("Enabled"), False)
      End With
    Catch
      log("ERROR: " & Err.Description, "LocationFrom_DataReader")
    End Try
    Return Location
  End Function
  Public Function StatusFrom_DataReader(ByRef Rdr As SqlDataReader) As Type_Status
    Dim Status As New Type_Status
    Try
      With Status
        .ID = InputVar(Rdr("ID"), default_Int)
        .Name = InputVar(Rdr("Name"), "")
        .LogOnly = InputVar(Rdr("LogOnly"), False)
        .IsBooking = InputVar(Rdr("IsBooking"), False)
        .Enabled = InputVar(Rdr("Enabled"), False)
        .LockBooking = InputVar(Rdr("LockBooking"), False)
      End With
    Catch
      log("ERROR: " & Err.Description, "StatusFrom_DataReader")
    End Try
    Return Status
  End Function
  '
  Public Function ShowTimesFrom_DataReader(ByRef Rdr As SqlDataReader) As Type_ShowTimes
    Dim Status As New Type_ShowTimes
    Try
      With Status
        .ID = InputVar(Rdr("ID"), default_Int)
        .LocationID = InputVar(Rdr("LocationID"), default_Int)
        .LocationName = InputVar(Rdr("LocationName"), "")
        .RealWave = InputVar(Rdr("RealWave"), default_Int)
        .Showtime = InputVar(Rdr("Showtime"), default_DateTime)
        .Wave = InputVar(Rdr("Wave"), default_Int)
      End With
    Catch
      log("ERROR: " & Err.Description, "StatusFrom_DataReader")
    End Try
    Return Status
  End Function
  Public Function ReadStatusRdr(ByRef Rdr As SqlDataReader) As Type_Status()
    Dim PStatus() As Type_Status : Erase PStatus
    Try
      If Not IsNothing(Rdr) Then
        If Rdr.HasRows Then
          Dim NewItem As Integer = 0
          While Rdr.Read
            ReDim Preserve PStatus(NewItem)
            PStatus(NewItem) = StatusFrom_DataReader(Rdr)
            NewItem += 1
          End While
        End If
      End If
    Catch
      log("ERROR: " & Err.Description, "ReadStatusRdr")
    End Try
    Return PStatus
  End Function
  Public Function ReadShowTimesRdr(ByRef Rdr As SqlDataReader) As Type_ShowTimes()
    Dim PStatus() As Type_ShowTimes : Erase PStatus
    Try
      If Not IsNothing(Rdr) Then
        If Rdr.HasRows Then
          Dim NewItem As Integer = 0
          While Rdr.Read
            ReDim Preserve PStatus(NewItem)
            PStatus(NewItem) = ShowTimesFrom_DataReader(Rdr)
            NewItem += 1
          End While
        End If
      End If
    Catch
      log("ERROR: " & Err.Description, "ReadStatusRdr")
    End Try
    Return PStatus
  End Function
  Public Function ReadSimpleRdr(ByRef Rdr As SqlDataReader) As Type_Simple()
    Dim PSimple() As Type_Simple : Erase PSimple
    Try
      If Not IsNothing(Rdr) Then
        If Rdr.HasRows Then
          Dim NewItem As Integer = 0
          While Rdr.Read
            ReDim Preserve PSimple(NewItem)
            With PSimple(NewItem)
              .ID = InputVar(Rdr("ID"), default_Int)
              .Name = InputVar(Rdr("Name"), "")
            End With
            NewItem += 1
          End While
        End If
      End If
    Catch
      log("ERROR: " & Err.Description, "ReadSimpleRdr")
    End Try
    Return PSimple
  End Function
  Public Function LocationScriptFrom_DataReader(ByRef Rdr As SqlClient.SqlDataReader) As Type_LocationScript
    Dim Script As New Type_LocationScript
    Try
      With Script
        'LocationID, Name, Seq, Value, PartID
        .LocationID = InputVar(Rdr("LocationID"), default_Int)
        .ID = InputVar(Rdr("PartID"), default_Int)
        .Name = InputVar(Rdr("Name"), "")
        .Seq = InputVar(Rdr("Seq"), default_Int)
        .Value = InputVar(Rdr("Value"), "")
      End With
    Catch
      log("ERROR: " & Err.Description, "LocationScriptFrom_DataReader")
    End Try
    Return Script
  End Function
  Public Function ContactFrom_DataReader(ByRef Rdr As SqlClient.SqlDataReader) As Type_Contact
    Dim Contact As New Type_Contact
    Try
      With Contact
        .ID = InputVar(Rdr("ContactID"), default_Int)

        '.ClaimNumber = InputVar(Rdr("ClaimNumber"), "")
        .Telephone = InputVar(Rdr("Telephone"), "")
        .PF_Name = InputVar(Rdr("PF_Name"), "")
        .PL_Name = InputVar(Rdr("PL_Name"), "")
        .SF_Name = InputVar(Rdr("SF_Name"), "")
        .SL_Name = InputVar(Rdr("SL_Name"), "")
        .Address1 = InputVar(Rdr("Address1"), "")
        .Address2 = InputVar(Rdr("Address2"), "")
        .City = InputVar(Rdr("City"), "")
        .ST = InputVar(Rdr("ST"), "")
        .Zip = InputVar(Rdr("Zip"), "")
        .Zip4 = InputVar(Rdr("Zip4"), "")
        .Email = InputVar(Rdr("Email"), "")
        .AltPhone = InputVar(Rdr("AltPhone"), "")
        .Fax = InputVar(Rdr("Fax"), "")
        .Notes = InputVar(Rdr("Notes"), "")


        '.PDOB = InputVar(Rdr("PDOB"), CDate(Default_DateValue))
        '.SDOB = InputVar(Rdr("SDOB"), CDate(Default_DateValue))
        '.Marital = InputVar(Rdr("Marital"), default_Int)
        '.Income = InputVar(Rdr("Income"), default_Int)

      End With
    Catch
      log("ERROR: " & Err.Description, "ContactFrom_DataReader")
    End Try
    Return Contact
  End Function
  Public Function BookingFrom_DataReader(ByRef Rdr As SqlClient.SqlDataReader) As Type_Booking
    Dim Booking As New Type_Booking
    Try
      With Booking
        'ID, Telephone, LocationID, ConfirmerID, StatusID, BookerID, Booked, Appt
        .ContactID = InputVar(Rdr("ContactID"), default_Int)
        .ID = InputVar(Rdr("BookingID"), default_Int)
        .ClaimNumber = InputVar(Rdr("ClaimNumber"), "")
        If .ClaimNumber.Length > 0 Then .ClaimNumberValid = True
        .LocationID = InputVar(Rdr("LocationID"), default_Int)
        .ConfirmerID = InputVar(Rdr("ConfirmerID"), default_Int)
        .StatusID = InputVar(Rdr("StatusID"), default_Int)
        .BookerID = InputVar(Rdr("BookerID"), default_Int)
        .Conf = InputVar(Rdr("Confirmed"), default_Date)
        .Booked = InputVar(Rdr("Booked"), default_Date)
        .Appt = InputVar(Rdr("Appt"), New Date)
        .Notes = InputVar(Rdr("Notes"), "")
        .Gift1_ID = InputVar(Rdr("Gift1ID"), default_Int)
        .Gift2_ID = InputVar(Rdr("Gift2ID"), default_Int)
        .Gift3_ID = InputVar(Rdr("Gift3ID"), default_Int)
        '.LocationName = InputVar(Rdr("Location"), "")
        '.Statis = InputVar(Rdr("Statis"), "")
        .Status = InputVar(Rdr("Status"), "")
        .Location = LocationFrom_DataReader(Rdr)

      End With
    Catch
      log("ERROR: " & Err.Description, "BookingFrom_DataReader")
    End Try

    Return Booking
  End Function
  Public Function BookingHistFrom_DataReader(ByRef Rdr As SqlClient.SqlDataReader) As Type_BookingHist
    Dim BookingHist As New Type_BookingHist
    Try
      With BookingHist
        'BookingID, EmployeeID, Field, Old, New, ActionTime
        .ID = InputVar(Rdr("BookingID"), default_Int)
        .EmployeeID = InputVar(Rdr("EmployeeID"), default_Int)
        .Employee = InputVar(Rdr("Employee"), "")
        .Field = InputVar(Rdr("Field"), "")
        .OldVal = InputVar(Rdr("OldRaw"), "")
        .NewVal = InputVar(Rdr("NewRaw"), "")
        .OldValStr = InputVar(Rdr("OldString"), "")
        .NewValStr = InputVar(Rdr("NewString"), "")
        .ActionTime = InputVar(Rdr("ActionTime"), default_Date)
      End With
    Catch
      log("ERROR: " & Err.Description, "BookingHistFrom_DataReader")
    End Try

    Return BookingHist
  End Function
#End Region

End Class



