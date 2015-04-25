CREATE VIEW dbo.vw_AccessRights
AS
SELECT      ID, Name,
                       (SELECT      dbo.GetAccessRight(dbo.tbl_AccessLevel.ID, N'EditHours') AS Expr1) AS EditHours,
                       (SELECT      dbo.GetAccessRight(dbo.tbl_AccessLevel.ID, N'EditSchedule') AS Expr1) AS EditSchedule,
                       (SELECT      dbo.GetAccessRight(dbo.tbl_AccessLevel.ID, N'EditSettings') AS Expr1) AS EditSettings,
                       (SELECT      dbo.GetAccessRight(dbo.tbl_AccessLevel.ID, N'ChangeBookDate') AS Expr1) AS ChangeBookDate,
                       (SELECT      dbo.GetAccessRight(dbo.tbl_AccessLevel.ID, N'SeeBooker') AS Expr1) AS SeeBooker,
                       (SELECT      dbo.GetAccessRight(dbo.tbl_AccessLevel.ID, N'EditLockedBooking') AS Expr1) AS EditLockedBooking,
                       (SELECT      dbo.GetAccessRight(dbo.tbl_AccessLevel.ID, N'PublishBookings') AS Expr1) AS PublishBookings,
                       (SELECT      dbo.GetAccessRight(dbo.tbl_AccessLevel.ID, N'SearchBookings') AS Expr1) AS SearchBookings,
                       (SELECT      dbo.GetAccessRight(dbo.tbl_AccessLevel.ID, N'EditRecords') AS Expr1) AS EditRecords,
                       (SELECT      dbo.GetAccessRight(dbo.tbl_AccessLevel.ID, N'EditBookings') AS Expr1) AS EditBookings,
                       (SELECT      dbo.GetAccessRight(dbo.tbl_AccessLevel.ID, N'MultiRecordUI') AS Expr1) AS MultiRecordUI,
                       (SELECT      dbo.GetAccessRight(dbo.tbl_AccessLevel.ID, N'EditEmployees') AS Expr1) AS EditEmployees,
                       (SELECT      dbo.GetAccessRight(dbo.tbl_AccessLevel.ID, N'SimpleUI') AS Expr1) AS SimpleUI,
                       (SELECT      dbo.GetAccessRight(dbo.tbl_AccessLevel.ID, N'DeleteRecords') AS Expr1) AS DeleteRecords
FROM         dbo.tbl_AccessLevel
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_AccessRights';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[28] 2[12] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[27] 4[48] 3) )"
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
         Configuration = "(H (1 [56] 3))"
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
         Configuration = "(H (1[40] 4) )"
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
      ActivePaneConfig = 9
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_AccessLevel (dbo)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 232
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
      Begin ColumnWidths = 9
         Width = 284
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
         Column = 9330
         Alias = 2550
         Table = 3360
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_AccessRights';

