SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ServicesInOrder]
(
	@id int
)
RETURNS nvarchar(100)
AS
BEGIN
	DECLARE @serv nvarchar(100);
	SELECT @serv = ServiceNames
	FROM MostFullOrderInfo
	WHERE MostFullOrderInfo.IdOrder = @id;
	return @serv
END
GO
