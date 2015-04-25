CREATE TABLE [dbo].[tbl_Promo_Gift] (
    [GiftID]  INT IDENTITY (1, 1) NOT NULL,
    [PromoID] INT NOT NULL,
    CONSTRAINT [PK_tbl_Promo_Gift] PRIMARY KEY CLUSTERED ([GiftID] ASC, [PromoID] ASC),
    CONSTRAINT [FK_tbl_Promo_Gift_tbl_Gift] FOREIGN KEY ([GiftID]) REFERENCES [dbo].[tbl_Gift] ([ID]),
    CONSTRAINT [FK_tbl_Promo_Gift_tbl_Promo] FOREIGN KEY ([PromoID]) REFERENCES [dbo].[tbl_Promo] ([ID])
);

