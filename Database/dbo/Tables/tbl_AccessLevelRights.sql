CREATE TABLE [dbo].[tbl_AccessLevelRights] (
    [AccessLevelID] INT NOT NULL,
    [RightsID]      INT NOT NULL,
    CONSTRAINT [PK_tbl_AccessLevelRights] PRIMARY KEY CLUSTERED ([AccessLevelID] ASC, [RightsID] ASC),
    CONSTRAINT [FK_tbl_AccessLevelRights_tbl_AccessLevel] FOREIGN KEY ([AccessLevelID]) REFERENCES [dbo].[tbl_AccessLevel] ([ID]),
    CONSTRAINT [FK_tbl_AccessLevelRights_tbl_AccessRights] FOREIGN KEY ([RightsID]) REFERENCES [dbo].[tbl_AccessRights] ([ID])
);

