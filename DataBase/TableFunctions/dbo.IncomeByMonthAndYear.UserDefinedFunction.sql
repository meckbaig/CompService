GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[IncomeByMonthAndYear]
(
    @month int,
    @year int
)
RETURNS TABLE AS RETURN
(
    SELECT TOP (100) Percent IdOrder, FullName, CompletionDate, TotalPrice
	FROM dbo.Income
	WHERE Income.[Month] = @month AND Income.[Year] = @year
	ORDER BY CompletionDate
)
GO
