SELECT TOP 50 Employees.FirstName, Employees.LastName, Towns.Name AS 'Town', Addresses.AddressText
FROM Employees
INNER JOIN Addresses ON Employees.AddressID = Addresses.AddressID
INNER JOIN Towns ON Addresses.TownID = Towns.TownID
ORDER BY FirstName ASC, LastName ASC