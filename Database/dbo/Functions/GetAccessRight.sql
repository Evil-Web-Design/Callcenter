CREATE FUNCTION [dbo].[GetAccessRight]
(
	@AccesslevelID int,
	@Name nvarchar(50)
)
RETURNS bit
AS
BEGIN
DECLARE @Value bit 
DECLARE @RetValue bit 

SELECT @Value = (

SELECT Value
FROM tbl_AccessLevelRights LEFT OUTER JOIN
tbl_AccessRights ON tbl_AccessLevelRights.RightsID = tbl_AccessRights.ID
WHERE (tbl_AccessLevelRights.AccessLevelID = @AccesslevelID) AND 
(tbl_AccessRights.Name = @Name) 

)


/*(SELECT CASE WHEN Value IS NULL THEN 'False' ELSE Value END AS Value 
FROM dbo.tbl_AccessLevelRights AS tbl_AccessLevelRights_1 WHERE (AccessLevelID = dbo.tbl_Employee.AccessLevelID) AND (dbo.tbl_AccessLevel.Name = 'EditLockedBooking'))

SELECT CASE WHEN Value IS NULL THEN 'False' ELSE Value END AS Value

*/

SELECT @RetValue = (SELECT CASE WHEN @Value IS NULL THEN 'False' ELSE @Value END AS Value)
RETURN @RetValue
END