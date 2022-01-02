CREATE PROCEDURE [dbo].[SP_GetTableProperties]
(
	@TableName nvarchar(max)
)
AS
BEGIN
	SELECT 'public '+ DATA_TYPE +' ' + COLUMN_NAME + '{ get; set; }'

	FROM INFORMATION_SCHEMA.COLUMNS

	WHERE TABLE_NAME = @TableName
END
