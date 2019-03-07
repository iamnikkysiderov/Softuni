CREATE OR ALTER PROCEDURE udp_GetTownsStartingWith @StartingTownCharacter VARCHAR(1)
AS
SELECT Name FROM Towns
WHERE SUBSTRING(Name, 1, 1) = @StartingTownCharacter

GO

EXEC udp_GetTownsStartingWith @StartingTownCharacter = 'b'