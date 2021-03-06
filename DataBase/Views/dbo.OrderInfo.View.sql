GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [OrderInfo]
AS
SELECT        dbo.OrderInfoWithParts.IdOrder, dbo.OrderInfoWithParts.FullName, dbo.OrderInfoWithParts.PhoneNumber, dbo.OrderInfoWithParts.ReceiptDate, dbo.OrderInfoWithParts.CompletionDate, 
                         dbo.OrderInfoWithParts.DefectDescription, dbo.OrderInfoWithParts.SerialNumber, dbo.OrderInfoWithParts.Completed, STRING_AGG(dbo.Service.ServiceName, '; ') AS ServiceNames, dbo.OrderInfoWithParts.IdPart, 
                         dbo.OrderInfoWithParts.PartName, dbo.OrderInfoWithParts.IdCustomer
FROM            dbo.OrderInfoWithParts LEFT OUTER JOIN
                         dbo.ServiceInOrder ON dbo.OrderInfoWithParts.IdOrder = dbo.ServiceInOrder.IdOrder LEFT OUTER JOIN
                         dbo.Service ON dbo.ServiceInOrder.IdService = dbo.Service.IdService
GROUP BY dbo.OrderInfoWithParts.IdOrder, dbo.OrderInfoWithParts.FullName, dbo.OrderInfoWithParts.PhoneNumber, dbo.OrderInfoWithParts.ReceiptDate, dbo.OrderInfoWithParts.CompletionDate, 
                         dbo.OrderInfoWithParts.DefectDescription, dbo.OrderInfoWithParts.SerialNumber, dbo.OrderInfoWithParts.Completed, dbo.OrderInfoWithParts.IdPart, dbo.OrderInfoWithParts.PartName, dbo.OrderInfoWithParts.IdCustomer
GO
