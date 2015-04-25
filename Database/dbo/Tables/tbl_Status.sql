CREATE TABLE [dbo].[tbl_Status] (
    [ID]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [LogOnly]     BIT           CONSTRAINT [DF_tbl_Status_LogOnly] DEFAULT ((0)) NOT NULL,
    [IsBooking]   BIT           CONSTRAINT [DF_tbl_Status_IsBooking] DEFAULT ((0)) NOT NULL,
    [Enabled]     BIT           CONSTRAINT [DF_tbl_Status_Enabled] DEFAULT ((1)) NOT NULL,
    [IsConfirm]   BIT           CONSTRAINT [DF_tbl_Status_IsConfirmed] DEFAULT ((0)) NOT NULL,
    [LockBooking] BIT           CONSTRAINT [DF_tbl_Status_LockBooking] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_tbl_Status] PRIMARY KEY CLUSTERED ([ID] ASC)
);

