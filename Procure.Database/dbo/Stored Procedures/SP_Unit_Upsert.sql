-- =============================================
-- Author:		Muhammad Shahid Khan Afridi
-- Create date: 2021-01-10
-- Description:	To Insert Data
-- =============================================
CREATE PROCEDURE [dbo].[SP_Unit_Upsert]
	@UnitCode nvarchar(50) output,
	@UnitName nvarchar(200),
	@Description nvarchar(200),
	@RetVal nvarchar(500)='' output
AS
BEGIN
	IF(ISNULL(@UnitCode,'')='')
	BEGIN
		set @UnitCode = (Select RIGHT(CONCAT('000',cast(ISNULL(Max(UnitCode),0)+1 as nvarchar)),3) from Gen.Unit)

		Insert Into Gen.Unit(UnitCode,UnitName,Description,CreatedOn)
		Values(@UnitCode,@UnitName,@Description,GETDATE())

		Set @RetVal='Record Successfully Saved';
	END
	ELSE
	BEGIN
		Update Gen.Unit set UnitName=@UnitName,[Description]=@Description,UpdatedOn=GETDATE()
		Where UnitCode=@UnitCode

		Set @RetVal='Record Successfully Updated';
	END
END
