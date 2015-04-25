CREATE VIEW dbo.vw_Booking
AS
SELECT      dbo.tbl_Booking.ContactID, dbo.tbl_Booking.PK_ID AS BookingID, dbo.vw_Locations.LocationID, dbo.tbl_Booking.ConfirmerID, dbo.tbl_Booking.StatusID, dbo.tbl_Status.Name AS Status, dbo.tbl_Booking.BookerID, 
                   dbo.tbl_Booking.Confirmed, dbo.tbl_Booking.Booked, dbo.tbl_Booking.Appt, dbo.tbl_Booking.Notes, dbo.vw_Locations.CityID, dbo.vw_Locations.LocationName, dbo.vw_Locations.LocationCity, dbo.tbl_Booking.ClaimNumber, 
                   dbo.vw_Locations.Timezone, dbo.vw_Locations.Enabled, dbo.tbl_Booking.Gift1 AS Gift1ID, dbo.tbl_Booking.Gift2 AS Gift2ID, dbo.tbl_Booking.Gift3 AS Gift3ID, tbl_Gift_1.Name AS Gift1, dbo.tbl_Gift.Name AS Gift2, 
                   tbl_Gift_2.Name AS Gift3
FROM         dbo.tbl_Booking LEFT OUTER JOIN
                   dbo.vw_Locations ON dbo.tbl_Booking.LocationID = dbo.vw_Locations.LocationID LEFT OUTER JOIN
                   dbo.tbl_Gift ON dbo.tbl_Booking.Gift2 = dbo.tbl_Gift.ID LEFT OUTER JOIN
                   dbo.tbl_Gift AS tbl_Gift_2 ON dbo.tbl_Booking.Gift3 = tbl_Gift_2.ID LEFT OUTER JOIN
                   dbo.tbl_Status ON dbo.tbl_Booking.StatusID = dbo.tbl_Status.ID LEFT OUTER JOIN
                   dbo.tbl_Gift AS tbl_Gift_1 ON dbo.tbl_Booking.Gift1 = tbl_Gift_1.ID
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_Booking';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'olumnWidths = 24
         Width = 284
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
         Column = 4680
         Alias = 2835
         Table = 2580
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_Booking';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[50] 4[25] 3) )"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4[51] 2[19] 3) )"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[46] 4[28] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1[41] 4) )"
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
         Left = -147
      End
      Begin Tables = 
         Begin Table = "tbl_Booking (dbo)"
            Begin Extent = 
               Top = 13
               Left = 147
               Bottom = 172
               Right = 341
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vw_Locations (dbo)"
            Begin Extent = 
               Top = 6
               Left = 417
               Bottom = 165
               Right = 611
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_Gift (dbo)"
            Begin Extent = 
               Top = 239
               Left = 151
               Bottom = 398
               Right = 345
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_Gift_2"
            Begin Extent = 
               Top = 191
               Left = 730
               Bottom = 350
               Right = 924
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_Status (dbo)"
            Begin Extent = 
               Top = 220
               Left = 448
               Bottom = 379
               Right = 642
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_Gift_1"
            Begin Extent = 
               Top = 6
               Left = 822
               Bottom = 186
               Right = 1016
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
      Begin C', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_Booking';

