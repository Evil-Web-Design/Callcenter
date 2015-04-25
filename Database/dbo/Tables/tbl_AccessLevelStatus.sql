CREATE TABLE [dbo].[tbl_AccessLevelStatus] (
    [AccessLevelID] INT NOT NULL,
    [StatusID]      INT NOT NULL,
    [Allowed]       BIT CONSTRAINT [DF_tbl_AccessLevelStatus_Allowed] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_tbl_AccessLevelStatus] PRIMARY KEY CLUSTERED ([AccessLevelID] ASC, [StatusID] ASC),
    CONSTRAINT [FK_tbl_AccessLevelStatus_tbl_AccessLevel] FOREIGN KEY ([AccessLevelID]) REFERENCES [dbo].[tbl_AccessLevel] ([ID]),
    CONSTRAINT [FK_tbl_AccessLevelStatus_tbl_AccessRights] FOREIGN KEY ([StatusID]) REFERENCES [dbo].[tbl_Status] ([ID])
);

