CREATE FUNCTION fnTableValued
(
	@RequestData nvarchar(100)
)
RETURNS 
@Table_Variable TABLE 
(
	Id int,
	FirstName nvarchar(100)
)
AS
BEGIN
	-- Fill the table variable with the rows for your result set
	
	RETURN 
END
