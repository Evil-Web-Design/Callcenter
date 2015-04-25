CREATE TABLE [dbo].[tbl_AccessRights] (
    [ID]    INT           NOT NULL,
    [Name]  NVARCHAR (50) NOT NULL,
    [Value] BIT           NOT NULL,
    CONSTRAINT [PK_tbl_AccessRights] PRIMARY KEY CLUSTERED ([ID] ASC)
);

