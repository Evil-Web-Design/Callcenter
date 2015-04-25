CREATE TABLE [dbo].[tbl__GiftImportHelper] (
    [BadGift]     NVARCHAR (50) NOT NULL,
    [CorrectGift] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tbl__GiftImportHelper] PRIMARY KEY CLUSTERED ([BadGift] ASC, [CorrectGift] ASC)
);

