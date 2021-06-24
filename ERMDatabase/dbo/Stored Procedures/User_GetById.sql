CREATE PROCEDURE [dbo].[User_GetById]
	@Id nvarchar(128)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		[User].Id,
		[User].FirstName,
		[User].LastName,
		[User].EmailAddress,
		[User].CreatedDate
	FROM dbo.[User]
	WHERE
		[User].Id = @Id;
END
