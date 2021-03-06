GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[PartsByIdOrder]
(
    @idOrder int
)
RETURNS TABLE AS RETURN
(
    SELECT Parts.IdPart, Parts.PartName, Parts.SerialNumber, Parts.Price
	FROM [dbo].[Order] LEFT OUTER JOIN
    dbo.Parts ON dbo.[Order].IdOrder = dbo.Parts.IdOrder

	WHERE [Order].IdOrder = @idOrder
)
GO
