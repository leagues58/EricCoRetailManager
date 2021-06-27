CREATE PROCEDURE [dbo].[Product_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		Product.Id,
		Product.[Name],
		Product.[Description],
		Product.RetailPrice,
		Product.QuantityInStock,
		Product.CreatedDate,
		Product.LastModified
	FROM [dbo].Product
	ORDER BY
		Product.[Name]
END
