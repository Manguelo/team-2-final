CREATE PROCEDURE [dbo].sp_saveAudit
	@pid nvarchar(7),
	@accessTimeStamp smallDateTime,
	@success bit

AS
	BEGIN
		INSERT INTO [dbo].AUDIT
			(
			PID,
			ACCESSTIMESTAMP,
			SUCCESS
			)
		VALUES
			(
			@pid,
			@accessTimeStamp,
			@success
			)
	END
RETURN @@error