CREATE PROCEDURE [dbo].sp_CheckCredentials
	@pid nvarchar(15),
	@password nvarchar(8)
AS
	SELECT * FROM SECURITY WHERE PID = @pid AND Password = @password
RETURN 0