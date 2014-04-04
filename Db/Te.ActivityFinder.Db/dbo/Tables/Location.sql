CREATE TABLE [dbo].[Location] (
    [LocationId] INT          IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (50) NOT NULL,
    [Town]       VARCHAR (50) NOT NULL,
    [Street]     VARCHAR (50) NOT NULL,
    [Suburb]     VARCHAR (50) NOT NULL,
    [Latitude]   VARCHAR (50) NOT NULL,
    [Longitude]  VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED ([LocationId] ASC)
);

