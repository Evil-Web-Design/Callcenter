CREATE VIEW dbo.vw_SearchBookings
AS
SELECT      dbo.tbl_Contact.PK_ID AS ContactID, dbo.vw_Booking.BookingID, dbo.tbl_Contact.Telephone, dbo.tbl_Contact.AltPhone, dbo.tbl_Contact.Fax, dbo.vw_Booking.ClaimNumber, dbo.tbl_Contact.Email, dbo.vw_Booking.Confirmed, 
                   dbo.vw_Booking.StatusID, dbo.vw_Booking.Status, dbo.vw_Booking.Booked, dbo.vw_Booking.Appt, dbo.tbl_Contact.PF_Name, dbo.tbl_Contact.PL_Name, dbo.tbl_Contact.SF_Name, dbo.tbl_Contact.SL_Name, 
                   dbo.tbl_Contact.Address1, dbo.tbl_Contact.Address2, dbo.tbl_Contact.City, dbo.tbl_Contact.ST, dbo.tbl_Contact.Zip, dbo.tbl_Contact.Zip4, dbo.vw_Booking.Notes, dbo.vw_Booking.ConfirmerID, dbo.vw_Booking.BookerID,
                       (SELECT      FirstName + ' ' + LastName AS Expr1
                        FROM         dbo.tbl_Employee
                        WHERE      (ID = dbo.vw_Booking.ConfirmerID)) AS Confirmer,
                       (SELECT      FirstName + ' ' + LastName AS Expr1
                        FROM         dbo.tbl_Employee AS tbl_Employee_2
                        WHERE      (ID = dbo.vw_Booking.BookerID)) AS Booker, dbo.vw_Booking.Gift1 AS Gift1ID, dbo.vw_Booking.Gift2 AS Gift2ID, dbo.vw_Booking.Gift3 AS Gift3ID, dbo.vw_Booking.LocationID, dbo.vw_Booking.CityID, 
                   dbo.vw_Booking.LocationName, dbo.vw_Booking.LocationCity, dbo.vw_Booking.Timezone, dbo.vw_Booking.Enabled
FROM         dbo.vw_Booking RIGHT OUTER JOIN
                   dbo.tbl_Contact ON dbo.vw_Booking.ContactID = dbo.tbl_Contact.PK_ID
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_SearchBookings';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_SearchBookings';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[24] 4[37] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[42] 4[34] 3) )"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4[30] 2[40] 3) )"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1[56] 3) )"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4[50] 3) )"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3) )"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1[46] 4) )"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4[60] 2) )"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4) )"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2) )"
      End
      ActivePaneConfig = 9
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_Contact"
            Begin Extent = 
               Top = 16
               Left = 15
               Bottom = 480
               Right = 185
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vw_Booking"
            Begin Extent = 
               Top = 13
               Left = 249
               Bottom = 615
               Right = 443
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
      PaneHidden = 
   End
   Begin DataPane = 
      PaneHidden = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 29
         Width = 284
         Width = 1500
         Width = 2580
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1845
         Width = 2130
         Width = 3165
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 13230
         Alias = 1680
         Table = 2535
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_SearchBookings';

