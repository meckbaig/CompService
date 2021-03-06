GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [MasterInfo]
AS
SELECT        dbo.Master.IdMaster, dbo.Master.IdUser, dbo.Master.FullName, dbo.[User].Login, dbo.[User].Password
FROM            dbo.Master LEFT OUTER JOIN
                         dbo.[User] ON dbo.Master.IdUser = dbo.[User].IdUser
GO
