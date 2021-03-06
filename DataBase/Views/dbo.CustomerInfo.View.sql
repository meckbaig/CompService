GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [CustomerInfo]
AS
SELECT        dbo.Customer.IdCustomer, dbo.Customer.IdUser, dbo.Customer.FullName, dbo.Customer.PhoneNumber, dbo.[User].Login
FROM            dbo.Customer LEFT OUTER JOIN
                         dbo.[User] ON dbo.Customer.IdUser = dbo.[User].IdUser
GO
