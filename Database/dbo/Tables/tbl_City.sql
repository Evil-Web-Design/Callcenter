CREATE TABLE [dbo].[tbl_City] (
    [ID]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tbl_City] PRIMARY KEY CLUSTERED ([ID] ASC)
);

