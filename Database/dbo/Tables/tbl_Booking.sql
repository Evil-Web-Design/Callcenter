CREATE TABLE [dbo].[tbl_Booking] (
    [PK_ID]       INT           IDENTITY (1, 1) NOT NULL,
    [ClaimNumber] NVARCHAR (50) NULL,
    [ContactID]   INT           NOT NULL,
    [LocationID]  INT           NULL,
    [ConfirmerID] INT           NULL,
    [StatusID]    INT           NULL,
    [BookerID]    INT           NOT NULL,
    [Booked]      SMALLDATETIME NULL,
    [Confirmed]   SMALLDATETIME NULL,
    [Appt]        SMALLDATETIME NULL,
    [Gift1]       INT           NULL,
    [Gift2]       INT           NULL,
    [Gift3]       INT           NULL,
    [Notes]       TEXT          NULL,
    CONSTRAINT [PK_tbl_Bookings] PRIMARY KEY CLUSTERED ([PK_ID] ASC),
    CONSTRAINT [FK_tbl_Booking_tbl_Contact] FOREIGN KEY ([ContactID]) REFERENCES [dbo].[tbl_Contact] ([PK_ID]),
    CONSTRAINT [FK_tbl_Booking_tbl_MailDropContact] FOREIGN KEY ([ClaimNumber]) REFERENCES [dbo].[tbl_MailDropContact] ([ClaimNumber]),
    CONSTRAINT [FK_tbl_Booking_tbl_Status] FOREIGN KEY ([StatusID]) REFERENCES [dbo].[tbl_Status] ([ID]),
    CONSTRAINT [FK_tbl_Bookings_tbl_Employee] FOREIGN KEY ([BookerID]) REFERENCES [dbo].[tbl_Employee] ([ID]),
    CONSTRAINT [FK_tbl_Bookings_tbl_Employee1] FOREIGN KEY ([ConfirmerID]) REFERENCES [dbo].[tbl_Employee] ([ID]),
    CONSTRAINT [FK_tbl_Bookings_tbl_Project] FOREIGN KEY ([LocationID]) REFERENCES [dbo].[tbl_Location] ([ID])
);

