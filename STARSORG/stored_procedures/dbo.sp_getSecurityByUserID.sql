CREATE PROCEDURE [dbo].sp_getSecurityByUserID
	@userID nvarchar(15)
	
AS
	SELECT TOP 1 * FROM SECURITY WHERE UserID = @userID
RETURN 0