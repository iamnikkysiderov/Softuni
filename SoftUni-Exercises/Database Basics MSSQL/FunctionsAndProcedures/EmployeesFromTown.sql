CREATE OR ALTER PROCEDURE udp_GetEmployeesFromTown @TownName VARCHAR(50)
AS
SELECT FirstName, LastName FROM Employees
WHERE Employees.AddressID = 
(SELECT Addresses.AddressID  
FROM Addresses 
WHERE Addresses.TownID = 
(SELECT Towns.TownID 
FROM Towns  
WHERE Name = @TownName));

GO 

EXEC udp_GetEmployeesFromTown @TownName = 'Sofia'