CREATE PROCEDURE udp_GetEmployeesSalaryAbove35000
AS
SELECT FirstName, LastName FROM Employees
WHERE Salary > 35000

GO

EXEC udp_GetEmployeesSalaryAbove35000