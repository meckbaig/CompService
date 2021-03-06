GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [FullOrderInfo]
AS
SELECT        OrderInfo.IdOrder, OrderInfo.FullName, OrderInfo.PhoneNumber, OrderInfo.ReceiptDate, OrderInfo.CompletionDate, OrderInfo.DefectDescription, OrderInfo.SerialNumber, OrderInfo.Completed, OrderInfo.ServiceNames, 
                         STRING_AGG(dbo.Master.FullName, '; ') AS MasterNames, OrderInfo.IdPart, OrderInfo.PartName, OrderInfo.IdCustomer
FROM            dbo.OrderInfo AS OrderInfo LEFT OUTER JOIN
                         dbo.MasterInOrder ON OrderInfo.IdOrder = dbo.MasterInOrder.IdOrder LEFT OUTER JOIN
                         dbo.Master ON dbo.MasterInOrder.IdMaster = dbo.Master.IdMaster
GROUP BY OrderInfo.IdOrder, OrderInfo.FullName, OrderInfo.PhoneNumber, OrderInfo.ReceiptDate, OrderInfo.CompletionDate, OrderInfo.DefectDescription, OrderInfo.SerialNumber, OrderInfo.ServiceNames, OrderInfo.IdPart, 
                         OrderInfo.PartName, OrderInfo.Completed, OrderInfo.IdCustomer
GO
