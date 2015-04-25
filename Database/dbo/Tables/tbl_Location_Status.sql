CREATE TABLE [dbo].[tbl_Location_Status] (
    [LocationID] INT NOT NULL,
    [CurrentID]  INT NOT NULL,
    [AllowedID]  INT NOT NULL,
    [AlwaysVis]  BIT CONSTRAINT [DF_tbl_Location_Status_AlwaysVis] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_tbl_Location_Status] PRIMARY KEY CLUSTERED ([LocationID] ASC, [AllowedID] ASC, [CurrentID] ASC),
    CONSTRAINT [FK_tbl_Location_Status_tbl_Location] FOREIGN KEY ([LocationID]) REFERENCES [dbo].[tbl_Location] ([ID]),
    CONSTRAINT [FK_tbl_Location_Status_tbl_Status] FOREIGN KEY ([CurrentID]) REFERENCES [dbo].[tbl_Status] ([ID])
);

