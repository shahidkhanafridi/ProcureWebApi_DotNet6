CREATE PROCEDURE [dbo].[SP_Unit_GetAll]
AS
BEGIN
	Select UnitCode,UnitName,Description,IsActive,CreatedOn,UpdatedOn
	From Inv.Unit
END


