CREATE PROCEDURE [dbo].sp_CheckCredentials
	@userID nvarchar(15),
	@password nvarchar(8)
AS
	SELECT * FROM SECURITY WHERE UserID = @userID AND Password = @password 
RETURN 