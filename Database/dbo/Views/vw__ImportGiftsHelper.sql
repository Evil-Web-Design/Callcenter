
CREATE VIEW [dbo].[vw__ImportGiftsHelper]
AS
SELECT      TOP (100) PERCENT dbo.tbl_Gift.ID AS GiftID, tbl_Gift_1.ID AS CorrectGiftID, dbo.tbl_Gift.Name, dbo.tbl_Gift.Enabled,
                       (SELECT      COUNT(*) AS total
                        FROM         dbo.tbl_Booking AS tbl_Booking_1
                        GROUP BY Gift1
                        HAVING      (Gift1 = dbo.tbl_Gift.ID)) AS Gift1COUNT,
                       (SELECT      COUNT(*) AS total
                        FROM         dbo.tbl_Booking AS tbl_Booking_2
                        GROUP BY Gift2
                        HAVING      (Gift2 = dbo.tbl_Gift.ID)) AS Gift2COUNT,
                       (SELECT      COUNT(*) AS total
                        FROM         dbo.tbl_Booking AS tbl_Booking_3
                        GROUP BY Gift3
                        HAVING      (Gift3 = dbo.tbl_Gift.ID)) AS Gift3COUNT
FROM         dbo.tbl_Gift AS tbl_Gift_1 INNER JOIN
                   dbo.tbl__GiftImportHelper AS tbl__GiftImportHelper_1 ON tbl_Gift_1.Name = tbl__GiftImportHelper_1.CorrectGift RIGHT OUTER JOIN
                   dbo.tbl_Gift LEFT OUTER JOIN
                   dbo.tbl__GiftImportHelper ON dbo.tbl_Gift.Name = dbo.tbl__GiftImportHelper.CorrectGift ON tbl__GiftImportHelper_1.BadGift = dbo.tbl_Gift.Name
WHERE      (dbo.tbl__GiftImportHelper.CorrectGift IS NULL)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw__ImportGiftsHelper';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'lter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw__ImportGiftsHelper';


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
         Configuration = "(H (4[30] 2[40] 3) )"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1[56] 3) )"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2[66] 3) )"
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
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 1
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_Gift (dbo)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 204
               Right = 232
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl__GiftImportHelper"
            Begin Extent = 
               Top = 187
               Left = 307
               Bottom = 300
               Right = 501
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl__GiftImportHelper_1"
            Begin Extent = 
               Top = 16
               Left = 303
               Bottom = 129
               Right = 497
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_Gift_1"
            Begin Extent = 
               Top = 44
               Left = 604
               Bottom = 203
               Right = 798
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
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1275
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
         Column = 2565
         Alias = 2625
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Fi', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw__ImportGiftsHelper';

