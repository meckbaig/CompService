GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Income]
AS
SELECT        TOP (100) PERCENT IdOrder, FullName, CompletionDate, TotalPrice, MONTH(CompletionDate) AS Month, YEAR(CompletionDate) AS Year
FROM            dbo.[Order]
WHERE        (TotalPrice IS NOT NULL)
ORDER BY CompletionDate
GO
