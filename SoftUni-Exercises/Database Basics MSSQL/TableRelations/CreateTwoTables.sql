CREATE TABLE Persons (
	PersonID INT NOT NULL,
	FirstName NVARCHAR(50),
	Salary DECIMAL(15, 2),
	PassportID INT NOT NULL
	)

GO

CREATE TABLE Passports (
	PassportID INT NOT NULL,
	PassportNumber NVARCHAR(50)
	)