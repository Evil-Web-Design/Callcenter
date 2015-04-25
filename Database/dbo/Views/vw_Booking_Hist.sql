CREATE VIEW [dbo].[vw_Booking_Hist]
AS
SELECT      dbo.tbl_Booking_Hist.PK_ID, dbo.tbl_Booking_Hist.BookingID, dbo.tbl_Booking_Hist.EmployeeID, dbo.tbl_Booking_Hist.Field, dbo.tbl_Booking_Hist.Old AS OldRaw, dbo.tbl_Booking_Hist.New AS NewRaw,
                       (SELECT      dbo.tbl_Employee.FirstName + ' ' + dbo.tbl_Employee.LastName AS Expr1) AS Employee,
                       (SELECT      dbo.GetActionString(dbo.tbl_Booking_Hist.Field, dbo.tbl_Booking_Hist.Old) AS Expr1) AS OldString,
                       (SELECT      dbo.GetActionString(dbo.tbl_Booking_Hist.Field, dbo.tbl_Booking_Hist.New) AS Expr1) AS NewString, dbo.tbl_Booking_Hist.ActionTime
FROM         dbo.tbl_Booking_Hist LEFT OUTER JOIN
                   dbo.tbl_Employee ON dbo.tbl_Booking_Hist.EmployeeID = dbo.tbl_Employee.ID
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_Booking_Hist';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[34] 4[27] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
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
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_Booking_Hist"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 458
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_Employee"
            Begin Extent = 
               Top = 39
               Left = 294
               Bottom = 388
               Right = 465
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 855
         Width = 1320
         Width = 1485
         Width = 1500
         Width = 2535
         Width = 2535
         Width = 1800
         Width = 2535
         Width = 2535
         Width = 2835
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 12180
         Alias = 1845
         Table = 2325
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_Booking_Hist';

