USE [DemoDB]
GO

/****** Object:  Table [dbo].[DemoTable]    Script Date: 2018/3/2 ¤U¤È 10:45:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DemoTable](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Gender] [nvarchar](1) NULL,
 CONSTRAINT [PK_DemoTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


