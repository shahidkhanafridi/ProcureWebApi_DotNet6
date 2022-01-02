CREATE PROCEDURE [dbo].[SP_Unit_Get]
(
@BranchCode nvarchar(10),
@UnitCode nvarchar(50)
)
AS
BEGIN
BEGIN Transaction;
	--IF(ISNULL(@BranchCode,'')='')
	--BEGIN
	--	Rollback Transaction;
	--	THROW 60000,'This is error message.',1;
	--END
	--Else
	Begin
		Select UnitCode,UnitName,Description,IsActive,CreatedOn,UpdatedOn
		From Gen.Unit
		Where UnitCode=@UnitCode

	Commit Transaction;
	End
END

