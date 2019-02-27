SELECT TOP 3 Employees.EmployeeID, Employees.FirstName
FROM Employees
WHERE Employees.EmployeeID NOT IN (SELECT EmployeesProjects.EmployeeID FROM EmployeesProjects)