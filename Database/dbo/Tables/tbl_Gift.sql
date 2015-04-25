CREATE TABLE [dbo].[tbl_Gift] (
    [ID]      INT           IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (50) CONSTRAINT [DF_tbl_Gift_Name] DEFAULT (N'New Gift') NOT NULL,
    [Value]   MONEY         CONSTRAINT [DF_tbl_Gift_Value] DEFAULT ((0)) NOT NULL,
    [Enabled] BIT           CONSTRAINT [DF_tbl_Gift_Enabled] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_tbl_Gift] PRIMARY KEY CLUSTERED ([ID] ASC)
);

