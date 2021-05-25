USE [UpstreamDB]
GO

/****** Object:  Table [dbo].[Clients]    Script Date: 5/25/2021 2:00:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clients](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NULL,
	[Gender] [nvarchar](8) NULL,
	[WorkNumber] [int] NULL,
	[CellNumber] [int] NULL,
	[ResidentialAddress] [nvarchar](50) NULL,
	[PostalAddress] [nvarchar](50) NULL,
	[WorkAddress] [nvarchar](50) NULL
) ON [PRIMARY]
GO

