GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteService]
	@name nvarchar(100)
AS
BEGIN
DELETE FROM [Service]
WHERE ServiceName = @name
END;
GO
