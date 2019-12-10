CREATE PROCEDURE [dbo].sp_getMemberByPID
@pid nvarchar(75)
AS
	SELECT * FROM MEMBER
	WHERE PID = @pid;
Return 0