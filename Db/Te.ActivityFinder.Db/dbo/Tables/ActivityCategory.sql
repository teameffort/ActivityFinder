CREATE TABLE [dbo].[ActivityCategory] (
    [ActivityCategoryId] INT          IDENTITY (1, 1) NOT NULL,
    [Name]               VARCHAR (50) NOT NULL,
    [IsActive]           BIT          CONSTRAINT [DF_ActivityCategory_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_ActivityCategory] PRIMARY KEY CLUSTERED ([ActivityCategoryId] ASC)
);

