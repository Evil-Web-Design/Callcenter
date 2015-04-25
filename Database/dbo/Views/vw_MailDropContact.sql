CREATE VIEW dbo.vw_MailDropContact
AS
SELECT      dbo.vw_Booking.ContactID, dbo.tbl_MailDropContact.Telephone, dbo.tbl_MailDropContact.PF_Name, dbo.tbl_MailDropContact.PL_Name, NULL AS SF_Name, NULL AS SL_Name, dbo.tbl_MailDropContact.Address1, 
                   dbo.tbl_MailDropContact.Address2, dbo.tbl_MailDropContact.City, dbo.tbl_MailDropContact.ST, dbo.tbl_MailDropContact.Zip, dbo.tbl_MailDropContact.Zip4, dbo.tbl_MailDropContact.Email, dbo.tbl_MailDropContact.Fax, NULL 
                   AS ALTPhone, NULL AS Notes, dbo.tbl_MailDropContact.PromoID, dbo.tbl_MailDropContact.ClaimNumber, dbo.tbl_MailDropContact.CallDate, dbo.tbl_Promo.Date AS StartDate, dbo.vw_Locations.LocationID, 
                   dbo.vw_Locations.CityID, dbo.vw_Locations.LocationName, dbo.vw_Locations.LocationCity, dbo.vw_Locations.Timezone, dbo.vw_Locations.Enabled
FROM         dbo.vw_Locations RIGHT OUTER JOIN
                   dbo.tbl_Promo ON dbo.vw_Locations.LocationID = dbo.tbl_Promo.LocationID RIGHT OUTER JOIN
                   dbo.tbl_MailDropContact ON dbo.tbl_Promo.ID = dbo.tbl_MailDropContact.PromoID LEFT OUTER JOIN
                   dbo.vw_Booking ON dbo.tbl_MailDropContact.ClaimNumber = dbo.vw_Booking.ClaimNumber
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_MailDropContact';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'oupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_MailDropContact';


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
         Configuration = "(H (1[43] 4[50] 3) )"
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
         Configuration = "(H (1[45] 4) )"
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
         Begin Table = "tbl_MailDropContact"
            Begin Extent = 
               Top = 6
               Left = 8
               Bottom = 464
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vw_Booking"
            Begin Extent = 
               Top = 0
               Left = 804
               Bottom = 627
               Right = 998
            End
            DisplayFlags = 280
            TopColumn = 15
         End
         Begin Table = "vw_Locations"
            Begin Extent = 
               Top = 346
               Left = 485
               Bottom = 610
               Right = 679
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_Promo"
            Begin Extent = 
               Top = 243
               Left = 258
               Bottom = 494
               Right = 428
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
      Begin ColumnWidths = 11
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 4365
         Alias = 2475
         Table = 2700
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         Gr', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_MailDropContact';

