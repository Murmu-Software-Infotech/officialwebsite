USE [MurmuSoftwareInfotechDB]
GO
/****** Object:  Table [dbo].[CTA_tbl]    Script Date: 19-01-2023 12:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTA_tbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CTA_Link] [nvarchar](max) NULL,
	[CTA_Title] [nvarchar](max) NULL,
	[CTA_Redirection] [nvarchar](100) NULL,
 CONSTRAINT [PK_CTA_tbl] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Google_Map]    Script Date: 19-01-2023 12:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Google_Map](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Location] [varchar](250) NULL,
	[GoogleLink] [varchar](250) NULL,
	[CTA_Id] [int] NOT NULL,
 CONSTRAINT [PK_Google _Map] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblContactForm]    Script Date: 19-01-2023 12:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblContactForm](
	[CF_Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NULL,
	[LastName] [nvarchar](100) NULL,
	[EmailId] [nvarchar](150) NULL,
	[MobileNumber] [nvarchar](10) NULL,
	[Comments] [text] NULL,
 CONSTRAINT [PK_tblContactForm] PRIMARY KEY CLUSTERED 
(
	[CF_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHelp_Support]    Script Date: 19-01-2023 12:55:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHelp_Support](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Title_Discription] [nvarchar](1000) NOT NULL,
	[Title_Logo] [nvarchar](500) NOT NULL,
	[CTA_Id] [int] NOT NULL,
	[Action] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblHelp_Support] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Google_Map] ON 
GO
INSERT [dbo].[Google_Map] ([Id], [Location], [GoogleLink], [CTA_Id]) VALUES (1, N'Delhi', N'http://www.murmusoftwareinfotech.com/contact.html', 1)
GO
INSERT [dbo].[Google_Map] ([Id], [Location], [GoogleLink], [CTA_Id]) VALUES (3, N'Patna', N'http://www.murmusoftwareinfotech.com/contact.html', 2)
GO
INSERT [dbo].[Google_Map] ([Id], [Location], [GoogleLink], [CTA_Id]) VALUES (4, N'Divine meadows', N'http://www.murmusoftwareinfotech.com', 2)
GO
SET IDENTITY_INSERT [dbo].[Google_Map] OFF
GO
SET IDENTITY_INSERT [dbo].[tblContactForm] ON 
GO
INSERT [dbo].[tblContactForm] ([CF_Id], [FirstName], [LastName], [EmailId], [MobileNumber], [Comments]) VALUES (1, N'Nagina', N'Saw', N'test@gmail.com', N'6787655678', N'Hey prem bro')
GO
INSERT [dbo].[tblContactForm] ([CF_Id], [FirstName], [LastName], [EmailId], [MobileNumber], [Comments]) VALUES (2, N'Nagina', N'Saw', N'Kumar@gmail.com', N'9624823997', N'Hey Prem Bro.')
GO
INSERT [dbo].[tblContactForm] ([CF_Id], [FirstName], [LastName], [EmailId], [MobileNumber], [Comments]) VALUES (3, N'Prem', N'Murmu', N'EmailId', N'000123440', N'Demo tast')
GO
INSERT [dbo].[tblContactForm] ([CF_Id], [FirstName], [LastName], [EmailId], [MobileNumber], [Comments]) VALUES (6, N'Madu', N'Sudhan', N'madu@gmail.com', N'2389056', N'Developer')
GO
INSERT [dbo].[tblContactForm] ([CF_Id], [FirstName], [LastName], [EmailId], [MobileNumber], [Comments]) VALUES (7, N'Madu1', N'Sudhan2', N'madu12@gmail.com', N'238905612', N'Developer')
GO
INSERT [dbo].[tblContactForm] ([CF_Id], [FirstName], [LastName], [EmailId], [MobileNumber], [Comments]) VALUES (8, N'Murmu', N'Kumar', N'raj@gmail.com', N'9999999999', N'Developer1')
GO
INSERT [dbo].[tblContactForm] ([CF_Id], [FirstName], [LastName], [EmailId], [MobileNumber], [Comments]) VALUES (9, N'Raj', N'Kumar', N'Testing@gmail.com', N'9995678999', N' .net Developer')
GO
SET IDENTITY_INSERT [dbo].[tblContactForm] OFF
GO
SET IDENTITY_INSERT [dbo].[tblHelp_Support] ON 
GO
INSERT [dbo].[tblHelp_Support] ([Id], [Title], [Title_Discription], [Title_Logo], [CTA_Id], [Action]) VALUES (1, N'ONLINE SUPPORT', N'We believe in focusing on you, not the competition.We are 24/7 available for your problems to be solved in an innovative way. Supporting you with any kind of your approach while you sit back at home.', N'fa fa-laptop', 1, N' Call Now')
GO
INSERT [dbo].[tblHelp_Support] ([Id], [Title], [Title_Discription], [Title_Logo], [CTA_Id], [Action]) VALUES (2, N'LIVE CHAT 24/7', N'We are connected and in touch with you anytime, anywhere and always via the live chat 24/7. We hope together we can find a better solution.', N'fa fa-comments', 2, N'Let''s Chat')
GO
INSERT [dbo].[tblHelp_Support] ([Id], [Title], [Title_Discription], [Title_Logo], [CTA_Id], [Action]) VALUES (3, N'Demo', N'Murmu', N'fa fa-question', 3, N'Ask Now')
GO
SET IDENTITY_INSERT [dbo].[tblHelp_Support] OFF
GO
ALTER TABLE [dbo].[Google_Map]  WITH CHECK ADD  CONSTRAINT [FK_Google _Map_Google _Map] FOREIGN KEY([Id])
REFERENCES [dbo].[Google_Map] ([Id])
GO
ALTER TABLE [dbo].[Google_Map] CHECK CONSTRAINT [FK_Google _Map_Google _Map]
GO
