CREATE TABLE [dbo].[tbl_Location] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [CityID]   INT           NOT NULL,
    [Name]     NVARCHAR (50) NOT NULL,
    [Timezone] VARCHAR (2)   NULL,
    [Enabled]  BIT           CONSTRAINT [DF_tbl_Project_Active] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_tbl_Project] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_tbl_Project_tbl_City] FOREIGN KEY ([CityID]) REFERENCES [dbo].[tbl_City] ([ID])
);

