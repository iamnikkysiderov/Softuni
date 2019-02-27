SELECT TOP 5 Employees.EmployeeID, Employees.FirstName, Projects.Name
FROM Employees
INNER JOIN EmployeesProjects ON EmployeesProjects.EmployeeID = Employees.EmployeeID
INNER JOIN Projects ON Projects.ProjectID = EmployeesProjects.ProjectID
WHERE Projects.StartDate >= '2002-08-12 00:00:00'
ORDER BY Employees.EmployeeID ASC