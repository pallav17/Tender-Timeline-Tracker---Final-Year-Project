CREATE TABLE [dbo].[officer]
(
	[OfficerId] INT NOT NULL  IDENTITY, 
    [Name] VARCHAR(100) NULL, 
    [MobileNo] VARCHAR(50) NULL, 
    [EmailId] VARCHAR(100) NULL, 
    [Username] VARCHAR(100) NULL, 
    [Password] VARCHAR(100) NULL, 
    [AllocationTime] DATETIME NULL, 
    [ProjectId] INT NULL, 
    CONSTRAINT [PK_officer] PRIMARY KEY ([OfficerId])
)
