CREATE VIEW dbo.vw_Employee
AS
SELECT      dbo.tbl_Employee.ID AS EmployeeID, dbo.tbl_Employee.FirstName, dbo.tbl_Employee.LastName, dbo.tbl_Employee.SS, dbo.tbl_Employee.Phone, dbo.tbl_Employee.Phone2, dbo.tbl_Employee.Email, 
                   dbo.tbl_Employee.EContact, dbo.tbl_Employee.EContactPhone, dbo.tbl_Employee.Address1, dbo.tbl_Employee.Address2, dbo.tbl_Employee.City, dbo.tbl_Employee.State, dbo.tbl_Employee.Zip, dbo.tbl_Employee.Zip4, 
                   dbo.tbl_Employee.Rate, dbo.tbl_Employee.Supervisor, dbo.tbl_Employee.Notes, dbo.tbl_Employee.TermDate, dbo.tbl_Employee.HireDate, dbo.tbl_Employee.Active, dbo.tbl_Employee.Password, 
                   dbo.tbl_Employee.AccessLevelID, dbo.vw_AccessRights.Name AS AccessLevelName, dbo.vw_AccessRights.EditHours, dbo.vw_AccessRights.EditSchedule, dbo.vw_AccessRights.EditSettings, 
                   dbo.vw_AccessRights.ChangeBookDate, dbo.vw_AccessRights.SeeBooker, dbo.vw_AccessRights.EditLockedBooking, dbo.vw_AccessRights.PublishBookings, dbo.vw_AccessRights.SearchBookings, 
                   dbo.vw_AccessRights.EditRecords, dbo.vw_AccessRights.EditBookings, dbo.vw_AccessRights.MultiRecordUI, dbo.vw_AccessRights.EditEmployees, dbo.vw_AccessRights.SimpleUI, dbo.vw_AccessRights.DeleteRecords
FROM         dbo.tbl_Employee LEFT OUTER JOIN
                   dbo.vw_AccessRights ON dbo.tbl_Employee.AccessLevelID = dbo.vw_AccessRights.ID
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_Employee';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[33] 4[27] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[30] 4[46] 3) )"
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
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2[66] 3) )"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4[75] 3) )"
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
         Configuration = "(H (1[36] 4) )"
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
         Begin Table = "tbl_Employee (dbo)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 165
               Right = 232
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vw_AccessRights (dbo)"
            Begin Extent = 
               Top = 168
               Left = 38
               Bottom = 327
               Right = 259
            End
            DisplayFlags = 280
            TopColumn = 12
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
      Begin ColumnWidths = 25
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
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 7290
         Alias = 2325
         Table = 1170
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_Employee';

