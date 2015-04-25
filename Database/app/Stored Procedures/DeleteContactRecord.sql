CREATE PROCEDURE [dbo].[DeleteContactRecord]
  @ContactID INT = 0,
  @RetVal INT OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
    BEGIN TRANSACTION
		PRINT '--> DELETE';
DELETE FROM dbo.tbl_Booking_Hist
WHERE      (BookingID IN
                       (SELECT     PK_ID
                        FROM       dbo.tbl_Booking
                        WHERE      (ContactID = @ContactID)))
DELETE FROM tbl_Booking WHERE      (ContactID = @ContactID)
DELETE FROM tbl_Contact WHERE      (PK_ID = @ContactID)
/*	PRINT '--> CHECKIDENT';
 DBCC CHECKIDENT ('[tbl_Booking_Hist]', RESEED, 0) 
 DBCC CHECKIDENT ('[tbl_Booking]', RESEED, 0) 
 DBCC CHECKIDENT ('[tbl_Contact]', RESEED, 0) */


    IF (@@ERROR <> 0)
      BEGIN
        ROLLBACK TRANSACTION
        -- Set the Return value to a Failure-Code --
        SET @RetVal = 0
      END
    ELSE 
      BEGIN
        -- Set the Return value to a Success-Code --
        SET @RetVal = 1
        COMMIT TRANSACTION
      END
SELECT @RetVal AS RetVal;
  RETURN @RetVal
END