CREATE TABLE [dbo].[tbl_Location_Calendar] (
    [ID]         INT           IDENTITY (1, 1) NOT NULL,
    [LocationID] INT           NOT NULL,
    [Showtime]   SMALLDATETIME NOT NULL,
    [Wave]       INT           NOT NULL,
    [RealWave]   INT           NOT NULL,
    CONSTRAINT [PK_tbl_LocationCalendar] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tbl_LocationCalendar_tbl_Location] FOREIGN KEY ([LocationID]) REFERENCES [dbo].[tbl_Location] ([ID])
);

