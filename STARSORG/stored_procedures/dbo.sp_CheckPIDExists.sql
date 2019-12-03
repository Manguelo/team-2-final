CREATE PROCEDURE [dbo].sp_CheckPIDExists
	@pid nvarchar(7),
	@recCount int = 0 OUTPUT
AS
	BEGIN
		SET @recCount = (Select count(0) FROM MEMBER WHERE PID = @pid)
		SELECT @recCount as RecordCount
	END
RETURN 0