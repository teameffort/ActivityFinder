CREATE TABLE [dbo].[act_Activity] (
    [ActivityId]     INT           IDENTITY (1, 1) NOT NULL,
    [ActivityTypeId] INT           NOT NULL,
    [LocationId]     INT           NOT NULL,
    [Name]           VARCHAR (255) NOT NULL,
    [StartDT]        DATETIME      NOT NULL,
    [EndDT]          DATETIME      NOT NULL,
    [IsActive]       BIT           CONSTRAINT [DF__act_Activ__IsAct__0519C6AF] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK__act_Acti__45F4A7917F60ED59] PRIMARY KEY CLUSTERED ([ActivityId] ASC),
    CONSTRAINT [FK_act_Activity_act_ActivityType] FOREIGN KEY ([ActivityTypeId]) REFERENCES [dbo].[act_ActivityType] ([ActivityTypeId]),
    CONSTRAINT [FK_act_Activity_loc_Location] FOREIGN KEY ([LocationId]) REFERENCES [dbo].[loc_Location] ([LocationId])
);


