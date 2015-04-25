CREATE TABLE [dbo].[tbl_Booking_Hist] (
    [PK_ID]      INT           IDENTITY (1, 1) NOT NULL,
    [BookingID]  INT           NOT NULL,
    [EmployeeID] INT           NOT NULL,
    [Field]      NVARCHAR (50) NOT NULL,
    [Old]        TEXT          NOT NULL,
    [New]        TEXT          NOT NULL,
    [ActionTime] DATETIME      NOT NULL,
    CONSTRAINT [PK_tbl_Booking_Hist] PRIMARY KEY CLUSTERED ([PK_ID] ASC),
    CONSTRAINT [FK_tbl_Booking_Hist_tbl_Booking] FOREIGN KEY ([BookingID]) REFERENCES [dbo].[tbl_Booking] ([PK_ID]),
    CONSTRAINT [FK_tbl_Booking_Hist_tbl_Employee] FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[tbl_Employee] ([ID])
);

