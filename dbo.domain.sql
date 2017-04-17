CREATE TABLE [dbo].[domain]
(
	[DomainId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(100) NULL, 
    [Details] VARCHAR(5000) NULL, 
    [Rules] VARCHAR(5000) NULL, 
    [AgreementDocument] NCHAR(10) NULL, 
    
)
