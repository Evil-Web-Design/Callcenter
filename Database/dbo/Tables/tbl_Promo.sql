CREATE TABLE [dbo].[tbl_Promo] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [LocationID]  INT           NOT NULL,
    [MailhouseID] INT           NULL,
    [Date]        SMALLDATETIME CONSTRAINT [DF_tbl_Promo_StartDate] DEFAULT (getdate()) NOT NULL,
    [MailPiece]   NVARCHAR (50) NULL,
    [MailCost]    MONEY         NULL,
    [MailCount]   INT           CONSTRAINT [DF_tbl_Promo_TotalCount] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_tbl_] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tbl_Promo_tbl_MailHouse] FOREIGN KEY ([MailhouseID]) REFERENCES [dbo].[tbl_MailHouse] ([ID]),
    CONSTRAINT [FK_tbl_Promo_tbl_Project1] FOREIGN KEY ([LocationID]) REFERENCES [dbo].[tbl_Location] ([ID])
);

