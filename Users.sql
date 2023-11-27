USE [CSOLconnect]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 11/15/2023 9:10:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[User ID] [int] IDENTITY(1,1) NOT NULL,
	[First Name] [varchar](200) NOT NULL,
	[Last Name] [varchar](50) NOT NULL,
	[Email Address] [varchar](100) NOT NULL,
	[Password] [varchar](500) NOT NULL,
	[User Level] [varchar](20) NOT NULL,
	[SQ1] [varchar](255) NOT NULL,
	[SQ2] [varchar](255) NOT NULL,
	[SQ3] [varchar](255) NOT NULL,
	[SQ1_ans] [varchar](100) NOT NULL,
	[SQ2_ans] [varchar](100) NOT NULL,
	[SQ3_ans] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[User ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_EmailAddress] UNIQUE NONCLUSTERED 
(
	[Email Address] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

