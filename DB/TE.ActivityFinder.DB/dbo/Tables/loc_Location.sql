CREATE TABLE [dbo].[loc_Location] (
    [LocationId] INT          IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (50) NOT NULL,
    [Latitude]   VARCHAR (50) NOT NULL,
    [Longitude]  VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([LocationId] ASC)
);


