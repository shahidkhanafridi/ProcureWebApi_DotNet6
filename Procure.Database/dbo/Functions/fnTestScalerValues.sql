CREATE FUNCTION fnTestScalerValues
(
	-- Add the parameters for the function here
	@Request nvarchar(100)
)
RETURNS nvarchar
AS
BEGIN
	-- Declare the return variable here
	DECLARE @ResultVar nvarchar(100)

	set @ResultVar = @Request

	-- Return the result of the function
	RETURN @ResultVar

END
