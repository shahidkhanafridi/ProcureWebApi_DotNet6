-- =============================================
-- Author:		Muhammad Shahid Khan Afridi
-- Create date: 2021-07-10 06:56:47.183
-- Description:	To get list of associated menus for specific user
-- =============================================
CREATE PROCEDURE [dbo].[SP_Pages_GetByUser]
(
	@UserId nvarchar(1000)=null
)
AS
BEGIN
	Select Id,ParentId,PageName,PageUrl,IsRoot,IsParent,IsChild,IsActive
	From Pages
END
