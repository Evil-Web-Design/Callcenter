CREATE TABLE [dbo].[tbl_Databases] (
    [DB]               INT          NOT NULL,
    [DatabaseName]     VARCHAR (50) NOT NULL,
    [Server]           VARCHAR (50) NOT NULL,
    [Provider]         VARCHAR (50) CONSTRAINT [DF_tblDatabases_Provider] DEFAULT ('sqloledb') NOT NULL,
    [UserName]         VARCHAR (50) NOT NULL,
    [Password]         VARCHAR (50) NULL,
    [OptionalDatabase] VARCHAR (50) NULL,
    [Enabled]          BIT          CONSTRAINT [DF_tbl_Databases_Enabled] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_tbl_Databases] PRIMARY KEY CLUSTERED ([DB] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'DataConn Provider', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'tbl_Databases', @level2type = N'COLUMN', @level2name = N'Provider';

