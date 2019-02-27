SELECT TOP 5 Employees.EmployeeID, Employees.FirstName, Employees.Salary, Departments.Name
FROM Employees
INNER JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID
ORDER BY Departments.DepartmentID ASC