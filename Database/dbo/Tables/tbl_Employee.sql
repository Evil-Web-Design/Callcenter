﻿CREATE TABLE [dbo].[tbl_Employee] (
    [ID]            INT           IDENTITY (1, 1) NOT NULL,
    [AccessLevelID] INT           CONSTRAINT [DF_tbl_Employee_AccessLevelID] DEFAULT ((0)) NOT NULL,
    [FirstName]     NVARCHAR (50) NOT NULL,
    [LastName]      NVARCHAR (50) NOT NULL,
    [SS]            VARCHAR (9)   NULL,
    [Phone]         VARCHAR (10)  NULL,
    [Phone2]        NCHAR (10)    NULL,
    [Email]         NVARCHAR (50) NULL,
    [EContact]      NVARCHAR (50) NULL,
    [EContactPhone] VARCHAR (10)  NULL,
    [Address1]      NVARCHAR (50) NULL,
    [Address2]      NVARCHAR (50) NULL,
    [City]          NVARCHAR (50) NULL,
    [State]         VARCHAR (2)   NULL,
    [Zip]           NCHAR (10)    NULL,
    [Zip4]          NCHAR (10)    NULL,
    [Password]      NVARCHAR (50) CONSTRAINT [DF_tbl_Employee_Password] DEFAULT (N'password') NOT NULL,
    [Rate]          MONEY         NULL,
    [Supervisor]    INT           NULL,
    [Notes]         NVARCHAR (50) NULL,
    [TermDate]      SMALLDATETIME NULL,
    [HireDate]      SMALLDATETIME NULL,
    [Active]        BIT           CONSTRAINT [DF_tbl_Employee_Active] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_tbl_Employee] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tbl_Employee_tbl_AccessLevel] FOREIGN KEY ([AccessLevelID]) REFERENCES [dbo].[tbl_AccessLevel] ([ID])
);

