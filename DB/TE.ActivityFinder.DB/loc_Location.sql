CREATE TABLE [dbo].[loc_Location]
(
	[LocationId] INT NOT NULL PRIMARY KEY IDENTITY, 
	[ActivityId] INT NOT NULL,
    [Name] VARCHAR(50) NOT NULL, 
    [Latitude] VARCHAR(50) NOT NULL, 
    [Longitude] VARCHAR(50) NOT NULL
)
