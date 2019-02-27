SELECT Employees.FirstName, Employees.LastName, Employees.HireDate, Departments.Name
FROM Employees
INNER JOIN Departments ON Departments.DepartmentID = Employees.DepartmentID
WHERE HireDate > '1999-01-01 00:00:00' AND (Departments.Name = 'Sales' OR Departments.Name = 'Finance')
ORDER BY HireDate ASC