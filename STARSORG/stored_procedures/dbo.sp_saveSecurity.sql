CREATE PROCEDURE [dbo].sp_saveSecurity
	@pid nvarchar(7),
	@userID nvarchar(15),
	@password nvarchar(8),
	@secRole nvarchar(10)
AS
	Declare @countExists int
	SELECT @countExists = count(0) FROM SECURITY WHERE @pid = PID
	IF (@countExists = 0)
	BEGIN
		INSERT INTO [dbo].SECURITY
			(
			PID,
			UserID,
			Password,
			SecRole
			)
		VALUES
			(
			@pid,
			@userID,
			@password,
			@secRole
			)
	END
	ELSE
	BEGIN
		UPDATE [dbo].SECURITY
		SET
			[UserID] = @userID,
			[Password] = @password, 
			[SecRole] = @secRole
		WHERE PID = @pid
	END
RETURN @@error