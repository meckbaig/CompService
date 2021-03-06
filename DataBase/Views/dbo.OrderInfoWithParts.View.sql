GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [OrderInfoWithParts]
AS
SELECT        dbo.[Order].IdOrder, dbo.[Order].FullName, dbo.[Order].PhoneNumber, dbo.[Order].ReceiptDate, dbo.[Order].CompletionDate, dbo.[Order].DefectDescription, dbo.[Order].SerialNumber, dbo.[Order].Completed, 
                         STRING_AGG(dbo.Parts.IdPart, '; ') AS IdPart, STRING_AGG(dbo.Parts.PartName, '; ') AS PartName, dbo.[Order].IdCustomer
FROM            dbo.[Order] LEFT OUTER JOIN
                         dbo.Parts ON dbo.[Order].IdOrder = dbo.Parts.IdOrder
GROUP BY dbo.[Order].IdOrder, dbo.[Order].FullName, dbo.[Order].PhoneNumber, dbo.[Order].ReceiptDate, dbo.[Order].CompletionDate, dbo.[Order].DefectDescription, dbo.[Order].SerialNumber, dbo.[Order].Completed, 
                         dbo.[Order].IdCustomer
GO
