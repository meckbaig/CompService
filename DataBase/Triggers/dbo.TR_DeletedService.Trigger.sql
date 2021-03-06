GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [dbo].[TR_CompletedOrder] 
   ON  [dbo].[Order]
   INSTEAD OF DELETE
AS 
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.[Order]
	SET Completed = 1
	WHERE IdOrder IN (SELECT IdOrder FROM deleted);
END
