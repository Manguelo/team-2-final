CREATE PROCEDURE [dbo].sp_getMemberByLName
@lname nvarchar(75)
AS
	SELECT * FROM MEMBER
	WHERE LName = @lname;
Return 0