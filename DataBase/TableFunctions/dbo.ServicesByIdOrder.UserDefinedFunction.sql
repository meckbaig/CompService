GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ServicesByIdOrder]
(
    @idOrder int
)
RETURNS TABLE AS RETURN
(
    SELECT Service.*
	FROM [dbo].[Order] LEFT OUTER JOIN
    dbo.ServiceInOrder ON dbo.[Order].IdOrder = dbo.ServiceInOrder.IdOrder LEFT OUTER JOIN
	dbo.Service ON dbo.ServiceInOrder.IdService = dbo.Service.IdService

	WHERE [Order].IdOrder = @idOrder
)
GO
