CREATE TABLE [dbo].[tbl_MailHouse] (
    [ID]      INT           IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (50) NOT NULL,
    [Enabled] BIT           CONSTRAINT [DF_tbl_MailHouse_Enabled] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_tbl_MailHouse] PRIMARY KEY CLUSTERED ([ID] ASC)
);

