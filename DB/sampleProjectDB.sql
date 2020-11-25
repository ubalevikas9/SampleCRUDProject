USE [sample_project]
GO
/****** Object:  Table [dbo].[ITEM_DATA]    Script Date: 25-11-2020 11:41:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITEM_DATA](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [varchar](50) NULL,
	[Description] [varchar](100) NULL,
	[Rate] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ITEM_DATA] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STATE_DATA]    Script Date: 25-11-2020 11:41:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STATE_DATA](
	[STATE_Id] [int] IDENTITY(1,1) NOT NULL,
	[STATE_CODE] [varchar](50) NULL,
	[STATE_NAME] [varchar](50) NULL,
 CONSTRAINT [PK_STATE_DATA] PRIMARY KEY CLUSTERED 
(
	[STATE_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
