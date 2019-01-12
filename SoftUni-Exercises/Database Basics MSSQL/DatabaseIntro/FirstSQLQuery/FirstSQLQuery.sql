USE Bank

CREATE TABLE Clients (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL
)

CREATE TABLE AccountTypes (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Accounts (
	Id INT PRIMARY KEY IDENTITY,
	AccountTypeId INT FOREIGN KEY REFERENCES AccountTypes(Id),
	Balance DECIMAL(15, 2) NOT NULL DEFAULT(0),
	ClientId INT FOREIGN KEY REFERENCES Clients(Id)
)

INSERT INTO Clients (FirstName, LastName) VALUES
	('Gosho', 'Ivanov'),
	('Petur', 'Paleka'),
	('Mitko', 'Tonev'),
	('Ani', 'Ivaylova')

INSERT INTO AccountTypes (Name) VALUES
	('Savings'),
	('Checkings')

INSERT INTO Accounts (ClientId, AccountTypeId, Balance) VALUES
	(1, 1, 175),
	(2, 1, 275.56),
	(3, 1, 138.01),
	(4, 1, 40.30),
	(4, 2, 375.50)

GO

CREATE FUNCTION f_CalculateTotalBalance (@ClientID INT)
RETURNS DECIMAL(15, 2)
	BEGIN
		DECLARE @result AS DECIMAL(15, 2) = (
		SELECT SUM(Balance)
		FROM Accounts WHERE ClientId = @ClientID
		)
		RETURN @result
	END

GO

CREATE PROC p_AddAccount @ClientId INT, @AccountTypeId INT AS
	INSERT INTO Accounts (ClientId, AccountTypeId)
	VALUES (@ClientId, @AccountTypeId)

GO

p_AddAccount 2, 2