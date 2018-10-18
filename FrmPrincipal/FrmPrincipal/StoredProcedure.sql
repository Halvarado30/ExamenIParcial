USE AdventureWorks2014

CREATE PROCEDURE sp_AgregarResenia(
	@ProductName NVARCHAR(50),
	@Usuario NVARCHAR(50),
	@Email NVARCHAR(50),
	@Valoracion INT,
	@Comentario NVARCHAR(3850),
	@FechaR DATETIME,
	@FechaM DATETIME
)
AS
BEGIN
	DECLARE @ProductID INT
	SELECT @ProductID = ProductID FROM 
	Production.Product WHERE Name = @ProductName
	INSERT INTO Production.ProductReview(ProductID, ReviewerName, EmailAddress, ReviewDate, ModifiedDate, Comments, Rating) VALUES (@ProductID, @Usuario, @Email, @FechaR, @FechaM, @Comentario, @Valoracion)
END 