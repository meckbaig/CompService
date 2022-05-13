GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[WindowsSale]
	@discount int,
	@rowCount INT OUTPUT
AS
BEGIN
UPDATE Service
SET Price = Price - Price * (@discount/100.00)
WHERE Category = 'Работа с ОС'
SET @rowCount = @@ROWCOUNT
END;
GO
