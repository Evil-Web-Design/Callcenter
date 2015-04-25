CREATE TABLE [dbo].[tbl_Contact] (
    [PK_ID]     INT           IDENTITY (1, 1) NOT NULL,
    [Telephone] VARCHAR (10)  NOT NULL,
    [PF_Name]   VARCHAR (25)  NULL,
    [PL_Name]   VARCHAR (25)  NULL,
    [SF_Name]   VARCHAR (25)  NULL,
    [SL_Name]   VARCHAR (25)  NULL,
    [Address1]  VARCHAR (25)  NULL,
    [Address2]  VARCHAR (50)  NULL,
    [City]      VARCHAR (30)  NULL,
    [ST]        NCHAR (2)     NULL,
    [Zip]       NCHAR (5)     NULL,
    [Zip4]      NCHAR (4)     NULL,
    [Email]     NVARCHAR (50) NULL,
    [Fax]       NVARCHAR (10) NULL,
    [AltPhone]  NVARCHAR (10) NULL,
    [Notes]     TEXT          NULL,
    [Income]    INT           NULL,
    CONSTRAINT [PK_tbl_Contact] PRIMARY KEY CLUSTERED ([PK_ID] ASC)
);

