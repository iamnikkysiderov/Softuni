ALTER TABLE Persons
ADD CONSTRAINT PK_Person PRIMARY KEY (PersonID)
GO

ALTER TABLE Persons
ADD CONSTRAINT FK_PersonPassport
FOREIGN KEY (PassportID) REFERENCES Passports(PassportID)
GO

ALTER TABLE Passports
ADD CONSTRAINT PK_Passport PRIMARY KEY (PassportID)
