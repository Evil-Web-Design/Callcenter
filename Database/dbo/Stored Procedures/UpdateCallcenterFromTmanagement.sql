
CREATE PROCEDURE [dbo].[UpdateCallcenterFromTmanagement]
AS
BEGIN
	/*SET NOCOUNT ON;*/
		PRINT '--> DELETE';
DELETE tbl_Booking_Hist;
DELETE tbl_Booking;
DELETE tbl_Contact;
DELETE tbl_Gift;
DELETE tbl_Employee;
	PRINT '--> CHECKIDENT';

 DBCC CHECKIDENT ('[tbl_Employee]', RESEED, 0) 
 DBCC CHECKIDENT ('[tbl_Booking]', RESEED, 0) 
 DBCC CHECKIDENT ('[tbl_Contact]', RESEED, 0) 


PRINT '--> INSERT:tbl_Employee';
SET IDENTITY_INSERT tbl_Employee ON;
INSERT INTO tbl_Employee
                   (ID, FirstName, LastName, Address1, Address2, City, State, Zip, Zip4, Phone, Phone2, Email, Active, HireDate, TermDate, SS, Notes, Rate, Password)
SELECT      PK_EmployeeNum, FirstName, LastName, Address1, Address2, City, State, Zip, Zip4, 
Telephone, Telephone2, email, active, HireDate, TermDate, SSNum, Notes, Rate, 'ou812' AS Expr1
FROM         [INTELEPROS.COM].[tmanagement].[dbo].[tblEmployees]
SET IDENTITY_INSERT tbl_Employee OFF;

PRINT '--> INSERT:tbl_Employee (Ken)';
INSERT INTO tbl_Employee
                   (AccessLevelID, FirstName, LastName, SS, Phone, Email, Address1, City, State, Zip, Password, Active)
VALUES      (1, N'Ken', N'Delaurentis', '123121234', '3862993196', N'eviltek2099@gmail.com', N'5795 Old Perkins Hwy', N'De Leon Springs', 'FL', N'32130', N'ou812', 1)



PRINT '--> INSERT:tbl_Gift';
INSERT INTO tbl_Gift (Name)
SELECT DISTINCT [Gift1]
FROM         [INTELEPROS.COM].[tmanagement].[dbo].[tblNewBookings]  LEFT OUTER JOIN
tbl_Gift AS tbl_Gift_1 ON [tblNewBookings].[Gift1] = tbl_Gift_1.Name
WHERE (NOT (Gift1 IS NULL)) and (tbl_Gift_1.Name IS NULL)

INSERT INTO tbl_Gift (Name)
SELECT DISTINCT [Gift2]
FROM         [INTELEPROS.COM].[tmanagement].[dbo].[tblNewBookings]  LEFT OUTER JOIN
tbl_Gift AS tbl_Gift_2 ON [tblNewBookings].[Gift2] = tbl_Gift_2.Name
WHERE (NOT (Gift2 IS NULL)) and (tbl_Gift_2.Name IS NULL)




 PRINT '--> INSERT:tbl_Contact';
SET IDENTITY_INSERT tbl_Contact ON;
INSERT INTO tbl_Contact
                   (PK_ID, Telephone, AltPhone, PF_Name, PL_Name, SF_Name, SL_Name, Address1, Address2, City, ST, Zip, Email)
SELECT   
[tblNewBookings].[PK_NewBookings], 
[tblNewBookings].[Telephone], 
[tblNewBookings].[Telephone2], 
[tblNewBookings].[PF_Name], 
[tblNewBookings].[PL_Name], 
[tblNewBookings].[SF_Name], 
[tblNewBookings].[SL_Name], 
[tblNewBookings].[Address1], 
[tblNewBookings].[Address2], 
[tblNewBookings].[City], 
[tblNewBookings].[State], 
[tblNewBookings].[Zip], 
[tblNewBookings].[Email]
FROM  [INTELEPROS.COM].[tmanagement].[dbo].[tblNewBookings] LEFT OUTER JOIN
tbl_Contact AS tbl_Contact_1 ON [tblNewBookings].[Telephone] = tbl_Contact_1.Telephone
WHERE      (tbl_Contact_1.Telephone IS NULL)

SET IDENTITY_INSERT tbl_Contact OFF;



PRINT '--> INSERT:tbl_Booking';
INSERT INTO tbl_Booking
                   (ContactID, LocationID, ConfirmerID, StatusID, BookerID, Booked, Confirmed, Appt, Gift1, Gift2)
SELECT     
[tblNewBookings].[PK_NewBookings], 
(SELECT TOP (1) ID from [tbl_Location] WHERE ([Name] = [tblNewBookings].[Project])) AS [ProjectID],
(SELECT TOP (1) [PK_EmployeeNum]
                        FROM [INTELEPROS.COM].[Tmanagement].[dbo].[tblEmployees] AS tbl_Employee_1
                        WHERE      (FullName = [tblNewBookings].[Confirmer])) AS [ConfirmerID],
(SELECT TOP (1) [Status_ID]
                        FROM [INTELEPROS.COM].[Tmanagement].[dbo].[tblStatus] AS tbl_Employee_1
                        WHERE      ([Status] = [tblNewBookings].[Status])) AS [Status_ID],
(SELECT TOP (1) [PK_EmployeeNum]
                        FROM [INTELEPROS.COM].[Tmanagement].[dbo].[tblEmployees] AS tbl_Employee_2
                        WHERE      (FullName = [tblNewBookings].[Booker])) AS [BookerID],
[tblNewBookings].[BookingDate],
[tblNewBookings].[ConfDate],
(SELECT 
Case When ISDATE([tblNewBookings].[ApptDate]) = 1 AND ISDATE([tblNewBookings].[ApptTime]) = 1 
Then CONVERT(datetime, [ApptDate] + cast([ApptTime] as time), 127) else null end) as [Appt],
(SELECT TOP (1) ID from tbl_Gift WHERE (Name = [tblNewBookings].[Gift1])) AS [Gift1],
(SELECT TOP (1) ID from tbl_Gift WHERE (Name = [tblNewBookings].[Gift2])) AS [Gift2]

FROM [INTELEPROS.COM].[tmanagement].[dbo].[tblNewBookings]


UPDATE     dbo.tbl_Booking
SET            Gift1 = vw__ImportGiftsHelper.CorrectGiftID
FROM         dbo.tbl_Booking LEFT OUTER JOIN
                   vw__ImportGiftsHelper ON dbo.tbl_Booking.Gift1 = vw__ImportGiftsHelper.GiftID
WHERE      (NOT (vw__ImportGiftsHelper.CorrectGiftID IS NULL))

UPDATE     dbo.tbl_Booking
SET            Gift2 = vw__ImportGiftsHelper.CorrectGiftID
FROM         dbo.tbl_Booking LEFT OUTER JOIN
                   vw__ImportGiftsHelper ON dbo.tbl_Booking.Gift2 = vw__ImportGiftsHelper.GiftID
WHERE      (NOT (vw__ImportGiftsHelper.CorrectGiftID IS NULL))

UPDATE     dbo.tbl_Booking
SET            Gift3 = vw__ImportGiftsHelper.CorrectGiftID
FROM         dbo.tbl_Booking LEFT OUTER JOIN
                   vw__ImportGiftsHelper ON dbo.tbl_Booking.Gift3 = vw__ImportGiftsHelper.GiftID
WHERE      (NOT (vw__ImportGiftsHelper.CorrectGiftID IS NULL))

UPDATE     dbo.tbl_Gift
SET            Enabled = 0
FROM         tbl__GiftImportHelper LEFT OUTER JOIN
                   dbo.tbl_Gift ON tbl__GiftImportHelper.BadGift = dbo.tbl_Gift.Name

END