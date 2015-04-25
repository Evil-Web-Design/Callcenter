CREATE TABLE [dbo].[tbl_MailDropContact] (
    [ClaimNumber] NVARCHAR (50) NOT NULL,
    [PromoID]     INT           NOT NULL,
    [Telephone]   VARCHAR (10)  NULL,
    [CallDate]    DATETIME      NULL,
    [PF_Name]     VARCHAR (25)  NULL,
    [PL_Name]     VARCHAR (25)  NULL,
    [Address1]    VARCHAR (25)  NULL,
    [Address2]    VARCHAR (50)  NULL,
    [City]        VARCHAR (30)  NULL,
    [ST]          NCHAR (2)     NULL,
    [Zip]         NCHAR (5)     NULL,
    [Zip4]        NCHAR (4)     NULL,
    [Email]       NVARCHAR (50) NULL,
    [Fax]         NVARCHAR (10) NULL,
    CONSTRAINT [PK_tbl_MailDropContact] PRIMARY KEY CLUSTERED ([ClaimNumber] ASC),
    CONSTRAINT [FK_tbl_MailDropContact_tbl_Promo] FOREIGN KEY ([PromoID]) REFERENCES [dbo].[tbl_Promo] ([ID])
);

