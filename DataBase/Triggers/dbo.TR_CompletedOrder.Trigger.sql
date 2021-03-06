GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [dbo].[TR_DeletedService]
ON [dbo].[Service]
AFTER DELETE
AS
SET IDENTITY_INSERT dbo.DeletedService ON
INSERT INTO dbo.DeletedService(IdService, ServiceName, Category, Price)
SELECT IdService, ServiceName, Category, Price
FROM deleted;