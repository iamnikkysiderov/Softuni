CREATE PROC p_AddAccount @ClientId INT, @AccountTypeId INT AS
INSERT INTO Accounts (ClientId, AccountTypeId) VALUES (@ClientId, @AccountTypeId)

GO

p_AddAccount 2, 2

GO

SELECT * FROM Accounts