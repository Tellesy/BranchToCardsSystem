USE [newDB]
GO
/****** Object:  Table [dbo].[Branches]    Script Date: 2/2/2019 11:50:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branches](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Branch_code] [int] NULL,
	[Branch] [nvarchar](255) NULL,
 CONSTRAINT [Branches$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CAF]    Script Date: 2/2/2019 11:50:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAF](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Card_Number] [nvarchar](16) NOT NULL,
	[Card_Account] [nvarchar](16) NOT NULL,
	[EXP_Date] [nvarchar](4) NOT NULL,
	[Product] [nvarchar](2) NOT NULL,
	[Inputter] [int] NOT NULL,
	[Authorizer] [int] NULL,
	[Authorized] [bit] NOT NULL,
	[Processed] [bit] NOT NULL,
	[Time] [datetime2](7) NULL,
 CONSTRAINT [PK_CAF] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Card_Accounts]    Script Date: 2/2/2019 11:50:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Card_Accounts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Card_Account] [nvarchar](max) NOT NULL,
	[Customer_Account] [nvarchar](max) NULL,
	[Customer_ID] [int] NULL,
	[Product_Code] [nvarchar](255) NULL,
	[NID] [nvarchar](255) NULL,
	[SSMA_TimeStamp] [timestamp] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cards]    Script Date: 2/2/2019 11:50:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cards](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Card_Account] [nvarchar](max) NULL,
	[Card_Number] [nvarchar](max) NOT NULL,
	[Active] [bit] NULL,
	[SSMA_TimeStamp] [timestamp] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2/2/2019 11:50:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Customer_ID] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Birthdate] [nvarchar](255) NULL,
	[Phone] [nvarchar](255) NULL,
	[NID] [nvarchar](max) NULL,
	[SSMA_TimeStamp] [timestamp] NOT NULL,
 CONSTRAINT [Customer$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PBF]    Script Date: 2/2/2019 11:50:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PBF](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Card_Account] [nvarchar](16) NOT NULL,
	[Balance] [int] NOT NULL,
	[Inputter] [int] NOT NULL,
	[Authorizer] [int] NULL,
	[Authorized] [bit] NOT NULL,
	[Processed] [bit] NOT NULL,
	[Time] [datetime2](7) NULL,
	[NID] [nvarchar](12) NULL,
	[Product] [nvarchar](2) NULL,
 CONSTRAINT [PK_PBF] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PO]    Script Date: 2/2/2019 11:50:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Card_Number] [nvarchar](16) NOT NULL,
	[Name] [nvarchar](25) NOT NULL,
	[Customer_ID] [nchar](7) NOT NULL,
	[Account] [nvarchar](15) NOT NULL,
	[Begin_Date] [nvarchar](4) NOT NULL,
	[End_Date] [nvarchar](4) NOT NULL,
	[Email] [nvarchar](20) NOT NULL,
	[Phone] [nvarchar](10) NOT NULL,
	[Passport] [nvarchar](8) NOT NULL,
	[Update_Code] [int] NOT NULL,
	[Process_Indicator] [nchar](1) NOT NULL,
	[Branch_Code] [nchar](5) NOT NULL,
	[Inputter] [int] NOT NULL,
	[Authorizer] [int] NULL,
	[Authorized] [bit] NOT NULL,
	[Processed] [bit] NOT NULL,
	[Time] [datetime] NULL,
 CONSTRAINT [PK_PO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 2/2/2019 11:50:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](255) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Cash_Limit] [int] NULL,
	[Cash_Transactions_Limit] [int] NULL,
	[POS_Limit] [int] NULL,
	[POS_Transactions_Limit] [int] NULL,
 CONSTRAINT [Products$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recharge]    Script Date: 2/2/2019 11:50:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recharge](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Customer_ID] [nvarchar](255) NULL,
	[R_Year] [int] NULL,
	[Product] [nvarchar](255) NULL,
	[Amount] [int] NULL,
	[Time] [datetime2](0) NULL,
	[NID] [nvarchar](max) NULL,
	[SSMA_TimeStamp] [timestamp] NOT NULL,
	[Inputter] [int] NULL,
	[Branch] [int] NULL,
	[Authorizer] [int] NULL,
	[Authorized] [bit] NULL,
	[CardAccount] [nvarchar](16) NULL,
 CONSTRAINT [Recharge$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sequences]    Script Date: 2/2/2019 11:50:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sequences](
	[Card_Number] [nvarchar](16) NOT NULL,
	[Used] [bit] NOT NULL,
	[Branch] [int] NOT NULL,
	[Product] [nvarchar](2) NOT NULL,
	[Locked] [bit] NOT NULL,
 CONSTRAINT [PK_Sequence1] PRIMARY KEY CLUSTERED 
(
	[Card_Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2/2/2019 11:50:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Employee] [nvarchar](max) NULL,
	[Active] [bit] NULL,
	[LIB_ID] [int] NULL,
	[Role] [int] NULL,
	[Branch] [int] NULL,
	[SSMA_TimeStamp] [timestamp] NOT NULL,
 CONSTRAINT [Users$PrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Year]    Script Date: 2/2/2019 11:50:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Year](
	[Year] [nchar](4) NULL,
	[Amount] [int] NULL,
	[Active] [bit] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Branches] ADD  DEFAULT ((0)) FOR [Branch_code]
GO
ALTER TABLE [dbo].[CAF] ADD  CONSTRAINT [DF_CAF_Authorized]  DEFAULT ((0)) FOR [Authorized]
GO
ALTER TABLE [dbo].[CAF] ADD  CONSTRAINT [DF_CAF_Processed]  DEFAULT ((0)) FOR [Processed]
GO
ALTER TABLE [dbo].[CAF] ADD  CONSTRAINT [DF_CAF_Time]  DEFAULT (getdate()) FOR [Time]
GO
ALTER TABLE [dbo].[Card_Accounts] ADD  DEFAULT ((0)) FOR [Customer_ID]
GO
ALTER TABLE [dbo].[Cards] ADD  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT ((0)) FOR [Customer_ID]
GO
ALTER TABLE [dbo].[PBF] ADD  CONSTRAINT [DF_PBF_Authorized]  DEFAULT ((0)) FOR [Authorized]
GO
ALTER TABLE [dbo].[PBF] ADD  CONSTRAINT [DF_PBF_Processed]  DEFAULT ((0)) FOR [Processed]
GO
ALTER TABLE [dbo].[PBF] ADD  CONSTRAINT [DF_PBF_Time]  DEFAULT (getdate()) FOR [Time]
GO
ALTER TABLE [dbo].[PO] ADD  CONSTRAINT [DF_PO_Customer_ID]  DEFAULT ((2000000)) FOR [Customer_ID]
GO
ALTER TABLE [dbo].[PO] ADD  CONSTRAINT [DF_PO_Account]  DEFAULT ((200000084002016.)) FOR [Account]
GO
ALTER TABLE [dbo].[PO] ADD  CONSTRAINT [DF_PO_Begin_Date]  DEFAULT ((1118)) FOR [Begin_Date]
GO
ALTER TABLE [dbo].[PO] ADD  CONSTRAINT [DF_PO_Email]  DEFAULT (N'email@email.com') FOR [Email]
GO
ALTER TABLE [dbo].[PO] ADD  CONSTRAINT [DF_PO_Phone]  DEFAULT ((900000000)) FOR [Phone]
GO
ALTER TABLE [dbo].[PO] ADD  CONSTRAINT [DF_PO_Passport]  DEFAULT (N'9100000000') FOR [Passport]
GO
ALTER TABLE [dbo].[PO] ADD  CONSTRAINT [DF_PO_Update_Code]  DEFAULT ((1)) FOR [Update_Code]
GO
ALTER TABLE [dbo].[PO] ADD  CONSTRAINT [DF_PO_Process_Indicator]  DEFAULT (N'D') FOR [Process_Indicator]
GO
ALTER TABLE [dbo].[PO] ADD  CONSTRAINT [DF_PO_Authorized]  DEFAULT ((0)) FOR [Authorized]
GO
ALTER TABLE [dbo].[PO] ADD  CONSTRAINT [DF_PO_Processed]  DEFAULT ((0)) FOR [Processed]
GO
ALTER TABLE [dbo].[PO] ADD  CONSTRAINT [DF_PO_Time]  DEFAULT (getdate()) FOR [Time]
GO
ALTER TABLE [dbo].[Recharge] ADD  DEFAULT ((0)) FOR [R_Year]
GO
ALTER TABLE [dbo].[Recharge] ADD  DEFAULT ((0)) FOR [Amount]
GO
ALTER TABLE [dbo].[Recharge] ADD  DEFAULT (getdate()) FOR [Time]
GO
ALTER TABLE [dbo].[Recharge] ADD  CONSTRAINT [DF_Recharge_Authorized]  DEFAULT ((0)) FOR [Authorized]
GO
ALTER TABLE [dbo].[Sequences] ADD  CONSTRAINT [DF_Sequence1_Used]  DEFAULT ((0)) FOR [Used]
GO
ALTER TABLE [dbo].[Sequences] ADD  CONSTRAINT [DF_Sequence1_Locked]  DEFAULT ((0)) FOR [Locked]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((0)) FOR [Active]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((0)) FOR [LIB_ID]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((0)) FOR [Role]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((0)) FOR [Branch]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Branches].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Branches', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Branches].[Branch_code]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Branches', @level2type=N'COLUMN',@level2name=N'Branch_code'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Branches].[Branch]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Branches', @level2type=N'COLUMN',@level2name=N'Branch'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Branches].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Branches', @level2type=N'CONSTRAINT',@level2name=N'Branches$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Branches]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Branches'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Card_Accounts].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Card_Accounts', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Card_Accounts].[Card_Account]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Card_Accounts', @level2type=N'COLUMN',@level2name=N'Card_Account'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Card_Accounts].[Customer_Account]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Card_Accounts', @level2type=N'COLUMN',@level2name=N'Customer_Account'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Card_Accounts].[Customer_ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Card_Accounts', @level2type=N'COLUMN',@level2name=N'Customer_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Card_Accounts].[Product_Code]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Card_Accounts', @level2type=N'COLUMN',@level2name=N'Product_Code'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Card_Accounts].[NID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Card_Accounts', @level2type=N'COLUMN',@level2name=N'NID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Card_Accounts]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Card_Accounts'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Cards].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cards', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Cards].[Card_Account]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cards', @level2type=N'COLUMN',@level2name=N'Card_Account'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Cards].[Card_Number]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cards', @level2type=N'COLUMN',@level2name=N'Card_Number'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Cards].[Active]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cards', @level2type=N'COLUMN',@level2name=N'Active'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Cards]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cards'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Customer].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Customer].[Customer_ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Customer_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Customer].[Name]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Customer].[Birthdate]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Birthdate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Customer].[Phone]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Customer].[NID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'COLUMN',@level2name=N'NID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Customer].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer', @level2type=N'CONSTRAINT',@level2name=N'Customer$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Customer]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Products].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Products].[Code]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Code'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Products].[Name]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Products].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products', @level2type=N'CONSTRAINT',@level2name=N'Products$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Products]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Products'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Recharge].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Recharge', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Recharge].[Customer_ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Recharge', @level2type=N'COLUMN',@level2name=N'Customer_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Recharge].[R_Year]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Recharge', @level2type=N'COLUMN',@level2name=N'R_Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Recharge].[Product]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Recharge', @level2type=N'COLUMN',@level2name=N'Product'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Recharge].[Amount]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Recharge', @level2type=N'COLUMN',@level2name=N'Amount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Recharge].[Time]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Recharge', @level2type=N'COLUMN',@level2name=N'Time'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Recharge].[NID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Recharge', @level2type=N'COLUMN',@level2name=N'NID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Recharge].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Recharge', @level2type=N'CONSTRAINT',@level2name=N'Recharge$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Recharge]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Recharge'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Users].[ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Users].[Username]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Username'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Users].[Password]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Users].[Employee]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Employee'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Users].[Active]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Active'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Users].[LIB_ID]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'LIB_ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Users].[Role]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Role'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Users].[Branch]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'COLUMN',@level2name=N'Branch'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Users].[PrimaryKey]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users', @level2type=N'CONSTRAINT',@level2name=N'Users$PrimaryKey'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'Branch_system1.[Users]' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Users'
GO
