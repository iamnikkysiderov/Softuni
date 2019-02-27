SELECT Employees.EmployeeID, Employees.FirstName, Employees.LastName, Departments.Name AS 'DepartmentName'
FROM Employees
INNER JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID
WHERE Departments.Name = 'Sales'
ORDER BY EmployeeID ASC