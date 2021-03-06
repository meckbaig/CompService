GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [FullOrderInfoWhenNotCompleted]
AS
SELECT        IdOrder, FullName, PhoneNumber, ReceiptDate, DefectDescription, SerialNumber, Completed, ServiceNames, MasterNames, IdPart, PartName, IdCustomer, CompletionDate
FROM            dbo.FullOrderInfo
WHERE        (Completed = 0)
GO
