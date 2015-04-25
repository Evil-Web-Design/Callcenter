CREATE TABLE [dbo].[tbl_Network] (
    [PK_ID]    INT             IDENTITY (1, 1) NOT NULL,
    [OwnerID]  INT             NOT NULL,
    [TargetID] INT             NULL,
    [Recived]  BIT             CONSTRAINT [DF_tbl_Network_recived] DEFAULT ((0)) NOT NULL,
    [Message]  NVARCHAR (2000) NULL,
    [Expires]  DATE            CONSTRAINT [DF_tbl_Network_Expires] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_tbl_Network] PRIMARY KEY CLUSTERED ([PK_ID] ASC)
);

