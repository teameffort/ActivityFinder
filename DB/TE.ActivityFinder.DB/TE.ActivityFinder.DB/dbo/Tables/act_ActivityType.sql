CREATE TABLE [dbo].[act_ActivityType] (
    [ActivityTypeId] INT           IDENTITY (1, 1) NOT NULL,
    [Type]           VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_act_ActivityCategory] PRIMARY KEY CLUSTERED ([ActivityTypeId] ASC)
);

