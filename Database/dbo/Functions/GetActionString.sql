-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[GetActionString] 
(
	@TypeString nvarchar(50),
	@Value nvarchar(50)
)
RETURNS nvarchar(50)
AS
BEGIN
    DECLARE @dtVC VARCHAR(64) 
    SELECT @dtVC = CASE @TypeString 
    WHEN 'StatusID' THEN 
	(SELECT Name FROM tbl_Status WHERE ID = @Value)
    WHEN 'ConfirmerID' THEN 
	(SELECT FirstName + ' ' + LastName AS FullName FROM tbl_Employee WHERE ID = @Value)
    WHEN 'LocationID' THEN 
	(SELECT Name FROM tbl_Location WHERE ID = @Value)
    WHEN 'BookerID' THEN 
	(SELECT FirstName + ' ' + LastName AS FullName FROM tbl_Employee WHERE ID = @Value)
    WHEN 'Gift1' THEN 
	(SELECT Name FROM tbl_Gift WHERE ID = @Value)
    WHEN 'Gift2' THEN 
	(SELECT Name FROM tbl_Gift WHERE ID = @Value)
    WHEN 'Gift3' THEN 
	(SELECT Name FROM tbl_Gift WHERE ID = @Value)
    ELSE 
        @Value 
    END 
    RETURN @dtVC 

END