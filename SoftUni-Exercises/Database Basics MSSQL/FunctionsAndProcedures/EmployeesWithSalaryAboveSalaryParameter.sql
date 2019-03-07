CREATE PROCEDURE udp_GetEmployeesSalaryAboveNumber @SalaryParameter DECIMAL(18,4)
AS
SELECT FirstName, LastName FROM Employees
WHERE Salary >= @SalaryParameter

GO

EXEC udp_GetEmployeesSalaryAboveNumber @SalaryParameter = 48100