USE [master]
GO
/****** Object:  Database [Kalan_Rashmika_SEN381_Project]    Script Date: 2020/07/12 2:24:30 PM ******/
CREATE DATABASE [Kalan_Rashmika_SEN381_Project]
 
GO
USE [Kalan_Rashmika_SEN381_Project]
GO
/****** Object:  Table [dbo].[tblAddOn]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAddOn](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[Cost] [money] NOT NULL,
	[ManufacturerID] [int] NOT NULL,
 CONSTRAINT [PK_tblAddOn] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCallCentre]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCallCentre](
	[CallID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Duration] [decimal](34, 2) NOT NULL,
 CONSTRAINT [PK_tblCallCentre] PRIMARY KEY CLUSTERED 
(
	[CallID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblClient]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblClient](
	[ID] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[IDNum] [varchar](50) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Location] [varchar](50) NOT NULL,
	[Importance] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblClient] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblClientAddOn]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblClientAddOn](
	[AddID] [int] NOT NULL,
	[SubscriptionID] [int] NOT NULL,
	[Quantity] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblClientImportance]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblClientImportance](
	[ID] [varchar](50) NOT NULL,
	[Importance] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblClientImportance] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblContract]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblContract](
	[ContractID] [varchar](50) NOT NULL,
	[ClientID] [varchar](50) NOT NULL,
	[SubscriptionID] [int] NOT NULL,
 CONSTRAINT [PK_tblContract] PRIMARY KEY CLUSTERED 
(
	[ContractID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmpBooking]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmpBooking](
	[BookingID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[ClientID] [varchar](50) NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Priority] [int] NOT NULL,
 CONSTRAINT [PK_tblEmpBooking] PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmpLevel]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmpLevel](
	[EmpLevel] [int] IDENTITY(1,1) NOT NULL,
	[Role] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblEmpLevel] PRIMARY KEY CLUSTERED 
(
	[EmpLevel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmployee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[EmpLevel] [int] NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblEmployee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblManufacturer]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblManufacturer](
	[ManufacturerID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblManufacturer] PRIMARY KEY CLUSTERED 
(
	[ManufacturerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMonthlyBill]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMonthlyBill](
	[InvoiceID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [varchar](50) NOT NULL,
	[DateIssued] [date] NOT NULL,
	[Month] [varchar](50) NOT NULL,
	[Amount] [money] NOT NULL,
	[SubscriptionID] [int] NOT NULL,
 CONSTRAINT [PK_tblMonthlyBill] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProdManufacture]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProdManufacture](
	[ProductID] [varchar](50) NOT NULL,
	[MaufacturerID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProduct]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProduct](
	[ProdID] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[CostPerMonth] [money] NOT NULL,
	[LatestVersion] [varchar](50) NOT NULL,
	[VersionReleaseDate] [date] NOT NULL,
	[ManufacturerID] [int] NOT NULL,
 CONSTRAINT [PK_tblProduct] PRIMARY KEY CLUSTERED 
(
	[ProdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProductTerms]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProductTerms](
	[ProdID] [varchar](50) NOT NULL,
	[UpgradeConditions] [varchar](max) NOT NULL,
	[CorrectiveMaintenance] [varchar](max) NOT NULL,
	[PremeptiveMaintenance] [varchar](max) NOT NULL,
 CONSTRAINT [PK_tblProductTerms] PRIMARY KEY CLUSTERED 
(
	[ProdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProvinces]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProvinces](
	[Province] [varchar](max) NOT NULL,
	[City] [varchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSubscriptions]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSubscriptions](
	[SubscriptionID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [varchar](50) NOT NULL,
	[ProdID] [varchar](50) NOT NULL,
	[Version] [varchar](50) NOT NULL,
	[Date] [date] NOT NULL,
	[CostPerMonth] [money] NOT NULL,
	[SerialNumber] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblSuscriptions] PRIMARY KEY CLUSTERED 
(
	[SubscriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblAddOn] ON 

INSERT [dbo].[tblAddOn] ([ID], [Name], [Description], [Cost], [ManufacturerID]) VALUES (3, N'Sensor', N' may be passive, simply relaying observations continuously, or active, reporting only changes in values or measurements outside specified ranges', 90.0000, 4)
INSERT [dbo].[tblAddOn] ([ID], [Name], [Description], [Cost], [ManufacturerID]) VALUES (4, N'Actors', N'effect changes in the environment, within continuous ranges such as mechanical movement or discrete states such as toggling switches.  ', 150.0000, 5)
INSERT [dbo].[tblAddOn] ([ID], [Name], [Description], [Cost], [ManufacturerID]) VALUES (5, N'Controllers', N' perform logical operations, make decisions and manage environmental factors within defined ranges through negative feedback loops. 
Each ', 160.0000, 6)
SET IDENTITY_INSERT [dbo].[tblAddOn] OFF
GO
SET IDENTITY_INSERT [dbo].[tblCallCentre] ON 

INSERT [dbo].[tblCallCentre] ([CallID], [EmployeeID], [Date], [Duration]) VALUES (1, 4, CAST(N'2020-05-05T00:00:00.000' AS DateTime), CAST(120.00 AS Decimal(34, 2)))
INSERT [dbo].[tblCallCentre] ([CallID], [EmployeeID], [Date], [Duration]) VALUES (3, 20, CAST(N'2020-05-16T19:00:03.767' AS DateTime), CAST(1.00 AS Decimal(34, 2)))
INSERT [dbo].[tblCallCentre] ([CallID], [EmployeeID], [Date], [Duration]) VALUES (4, 20, CAST(N'2020-05-27T10:31:35.300' AS DateTime), CAST(0.00 AS Decimal(34, 2)))
INSERT [dbo].[tblCallCentre] ([CallID], [EmployeeID], [Date], [Duration]) VALUES (5, 20, CAST(N'2020-05-28T19:20:06.153' AS DateTime), CAST(0.00 AS Decimal(34, 2)))
SET IDENTITY_INSERT [dbo].[tblCallCentre] OFF
GO
INSERT [dbo].[tblClient] ([ID], [FirstName], [LastName], [IDNum], [Phone], [Email], [Location], [Importance]) VALUES (N'A00000002', N'Chandler', N'Bing', N'9705120125268', N'0845213698', N'cb@gmail.com', N'21 New York Avenue', N'B         ')
INSERT [dbo].[tblClient] ([ID], [FirstName], [LastName], [IDNum], [Phone], [Email], [Location], [Importance]) VALUES (N'A00000003', N'Monica', N'Geller', N'9908154522369', N'0541223578', N'mg@yahoo.com', N'32 Friends Street', N'C         ')
INSERT [dbo].[tblClient] ([ID], [FirstName], [LastName], [IDNum], [Phone], [Email], [Location], [Importance]) VALUES (N'A00705018', N'TestConID', N'TestConID', N'9808160152080', N'0848118675', N'test@yahoo.com', N'12 There, Johannesburg, Gauteng', N'A         ')
INSERT [dbo].[tblClient] ([ID], [FirstName], [LastName], [IDNum], [Phone], [Email], [Location], [Importance]) VALUES (N'B00000002', N'Ross', N'Geller', N'7501125885622', N'0215487896', N'rg@dinosaurs.com', N'90 Break Avenue', N'D         ')
INSERT [dbo].[tblClient] ([ID], [FirstName], [LastName], [IDNum], [Phone], [Email], [Location], [Importance]) VALUES (N'C00000001', N'Khaleesi', N'Dragon', N'9512054789568', N'0845789546', N'khaleesi@dragon.com', N'12 Game Road, Winterfell', N'A         ')
INSERT [dbo].[tblClient] ([ID], [FirstName], [LastName], [IDNum], [Phone], [Email], [Location], [Importance]) VALUES (N'D00512137', N'Rashmika', N'Kalan', N'9908160182080', N'0848102707', N'kalan@gmail.com', N'Sunflower, Bela-Bela, Limpopo', N'A         ')
GO
INSERT [dbo].[tblClientAddOn] ([AddID], [SubscriptionID], [Quantity]) VALUES (3, 29, 2)
GO
INSERT [dbo].[tblClientImportance] ([ID], [Importance]) VALUES (N'A         ', N'Very Important')
INSERT [dbo].[tblClientImportance] ([ID], [Importance]) VALUES (N'B         ', N'Important')
INSERT [dbo].[tblClientImportance] ([ID], [Importance]) VALUES (N'C         ', N'Slightly Important')
INSERT [dbo].[tblClientImportance] ([ID], [Importance]) VALUES (N'D         ', N'Normal')
INSERT [dbo].[tblClientImportance] ([ID], [Importance]) VALUES (N'E         ', N'General')
GO
INSERT [dbo].[tblContract] ([ContractID], [ClientID], [SubscriptionID]) VALUES (N'2020CA022449', N'D00512137', 29)
INSERT [dbo].[tblContract] ([ContractID], [ClientID], [SubscriptionID]) VALUES (N'2020EA086207', N'D00512137', 32)
GO
SET IDENTITY_INSERT [dbo].[tblEmpBooking] ON 

INSERT [dbo].[tblEmpBooking] ([BookingID], [EmployeeID], [ClientID], [Description], [Date], [Priority]) VALUES (1, 5, N'A00000002', N'Upgrade', CAST(N'2020-05-26T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[tblEmpBooking] ([BookingID], [EmployeeID], [ClientID], [Description], [Date], [Priority]) VALUES (7, 5, N'A00000003', N'Upgrade', CAST(N'2020-05-28T08:20:00.000' AS DateTime), 3)
INSERT [dbo].[tblEmpBooking] ([BookingID], [EmployeeID], [ClientID], [Description], [Date], [Priority]) VALUES (9, 5, N'B00000002', N'Maintanance', CAST(N'2020-05-14T17:47:58.000' AS DateTime), 2)
INSERT [dbo].[tblEmpBooking] ([BookingID], [EmployeeID], [ClientID], [Description], [Date], [Priority]) VALUES (12, 5, N'B00000002', N'Maintanance', CAST(N'2020-05-13T17:48:40.000' AS DateTime), 3)
INSERT [dbo].[tblEmpBooking] ([BookingID], [EmployeeID], [ClientID], [Description], [Date], [Priority]) VALUES (14, 7, N'B00000002', N'Maintanance', CAST(N'2020-05-29T20:39:47.137' AS DateTime), 1)
INSERT [dbo].[tblEmpBooking] ([BookingID], [EmployeeID], [ClientID], [Description], [Date], [Priority]) VALUES (17, 6, N'B00000002', N'Other', CAST(N'2020-07-24T16:00:03.000' AS DateTime), 3)
INSERT [dbo].[tblEmpBooking] ([BookingID], [EmployeeID], [ClientID], [Description], [Date], [Priority]) VALUES (18, 6, N'B00000002', N'Other', CAST(N'2020-07-24T18:00:06.000' AS DateTime), 3)
INSERT [dbo].[tblEmpBooking] ([BookingID], [EmployeeID], [ClientID], [Description], [Date], [Priority]) VALUES (21, 22, N'B00000002', N'Maintanance', CAST(N'2020-07-25T14:20:12.000' AS DateTime), 2)
INSERT [dbo].[tblEmpBooking] ([BookingID], [EmployeeID], [ClientID], [Description], [Date], [Priority]) VALUES (28, 5, N'D00512137', N'Upgrade', CAST(N'2020-07-31T13:15:11.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[tblEmpBooking] OFF
GO
SET IDENTITY_INSERT [dbo].[tblEmpLevel] ON 

INSERT [dbo].[tblEmpLevel] ([EmpLevel], [Role]) VALUES (1, N'CEO')
INSERT [dbo].[tblEmpLevel] ([EmpLevel], [Role]) VALUES (2, N'Product')
INSERT [dbo].[tblEmpLevel] ([EmpLevel], [Role]) VALUES (3, N'Client')
INSERT [dbo].[tblEmpLevel] ([EmpLevel], [Role]) VALUES (4, N'Technical')
INSERT [dbo].[tblEmpLevel] ([EmpLevel], [Role]) VALUES (5, N'Maintanance')
INSERT [dbo].[tblEmpLevel] ([EmpLevel], [Role]) VALUES (6, N'Employee')
SET IDENTITY_INSERT [dbo].[tblEmpLevel] OFF
GO
SET IDENTITY_INSERT [dbo].[tblEmployee] ON 

INSERT [dbo].[tblEmployee] ([ID], [FirstName], [LastName], [Phone], [Email], [EmpLevel], [Username], [Password]) VALUES (2, N'Rachel', N'Greene', N'0215896521', N'rg@ralphlauren.co.za', 1, N'Rachel', N'Credit')
INSERT [dbo].[tblEmployee] ([ID], [FirstName], [LastName], [Phone], [Email], [EmpLevel], [Username], [Password]) VALUES (3, N'Joey', N'Tribianni', N'0356987548', N'jt@gmail.com', 2, N'Joey', N'Food')
INSERT [dbo].[tblEmployee] ([ID], [FirstName], [LastName], [Phone], [Email], [EmpLevel], [Username], [Password]) VALUES (4, N'Phoebe', N'Buffay', N'0452158547', N'pb@yahoomail.com', 3, N'Phoebe', N'Cat')
INSERT [dbo].[tblEmployee] ([ID], [FirstName], [LastName], [Phone], [Email], [EmpLevel], [Username], [Password]) VALUES (5, N'Harry', N'Styles', N'0652587469', N'hs@one.com', 4, N'Harry', N'Music')
INSERT [dbo].[tblEmployee] ([ID], [FirstName], [LastName], [Phone], [Email], [EmpLevel], [Username], [Password]) VALUES (6, N'Niall', N'Horan', N'0145698565', N'nh@one.com', 5, N'Niall', N'Ireland')
INSERT [dbo].[tblEmployee] ([ID], [FirstName], [LastName], [Phone], [Email], [EmpLevel], [Username], [Password]) VALUES (7, N'Louis', N'Tomlinson', N'0312564555', N'lt@one.com', 6, N'Louis', N'Kevin')
INSERT [dbo].[tblEmployee] ([ID], [FirstName], [LastName], [Phone], [Email], [EmpLevel], [Username], [Password]) VALUES (8, N'Liam', N'Payne', N'0545896745', N'lp@one.com', 1, N'Liam', N'Spoon')
INSERT [dbo].[tblEmployee] ([ID], [FirstName], [LastName], [Phone], [Email], [EmpLevel], [Username], [Password]) VALUES (9, N'Zayn', N'Malik', N'0312547852', N'zm@one.com', 2, N'Zayn', N'Movie')
INSERT [dbo].[tblEmployee] ([ID], [FirstName], [LastName], [Phone], [Email], [EmpLevel], [Username], [Password]) VALUES (10, N'Test', N'Test', N'0848118657', N'test@gmail.com', 1, N'Test', N'Password')
INSERT [dbo].[tblEmployee] ([ID], [FirstName], [LastName], [Phone], [Email], [EmpLevel], [Username], [Password]) VALUES (11, N'MARKER', N'MARKER', N'0847854596', N'MARKER@GMAIL.COM', 1, N'MARKER', N'MARKER')
INSERT [dbo].[tblEmployee] ([ID], [FirstName], [LastName], [Phone], [Email], [EmpLevel], [Username], [Password]) VALUES (20, N'Rashmika', N'Kalan', N'0848102707', N'kalan@gmail.com', 1, N'Rashmika', N'Brady')
INSERT [dbo].[tblEmployee] ([ID], [FirstName], [LastName], [Phone], [Email], [EmpLevel], [Username], [Password]) VALUES (21, N'Abishek', N'Kalan', N'0848775487', N'abi@gmail.com', 2, N'Abishek', N'game')
INSERT [dbo].[tblEmployee] ([ID], [FirstName], [LastName], [Phone], [Email], [EmpLevel], [Username], [Password]) VALUES (22, N'Stored', N'Proc', N'0848756556', N'proc@yahoo.com', 6, N'Proc', N'Stored')
INSERT [dbo].[tblEmployee] ([ID], [FirstName], [LastName], [Phone], [Email], [EmpLevel], [Username], [Password]) VALUES (23, N'Vanusha', N'Kalan', N'0848118675', N'vanusha@bing.com', 3, N'VKalan', N'Mom')
INSERT [dbo].[tblEmployee] ([ID], [FirstName], [LastName], [Phone], [Email], [EmpLevel], [Username], [Password]) VALUES (24, N'Test1', N'Test1', N'0848118657', N'text@gmail.com', 1, N'Test1', N'Pass')
INSERT [dbo].[tblEmployee] ([ID], [FirstName], [LastName], [Phone], [Email], [EmpLevel], [Username], [Password]) VALUES (26, N'TEST', N'TEST', N'0845802565', N'T@GMAIL', 1, N'TEST', N'Test')
INSERT [dbo].[tblEmployee] ([ID], [FirstName], [LastName], [Phone], [Email], [EmpLevel], [Username], [Password]) VALUES (27, N'Check', N'check', N'0884401520', N'C@', 1, N'CC', N'Pass')
SET IDENTITY_INSERT [dbo].[tblEmployee] OFF
GO
SET IDENTITY_INSERT [dbo].[tblManufacturer] ON 

INSERT [dbo].[tblManufacturer] ([ManufacturerID], [Name]) VALUES (1, N'LG')
INSERT [dbo].[tblManufacturer] ([ManufacturerID], [Name]) VALUES (2, N'Samsung')
INSERT [dbo].[tblManufacturer] ([ManufacturerID], [Name]) VALUES (3, N'BlackBerry')
INSERT [dbo].[tblManufacturer] ([ManufacturerID], [Name]) VALUES (4, N'Intel')
INSERT [dbo].[tblManufacturer] ([ManufacturerID], [Name]) VALUES (5, N'Lenovo')
INSERT [dbo].[tblManufacturer] ([ManufacturerID], [Name]) VALUES (6, N'Acer')
SET IDENTITY_INSERT [dbo].[tblManufacturer] OFF
GO
SET IDENTITY_INSERT [dbo].[tblMonthlyBill] ON 

INSERT [dbo].[tblMonthlyBill] ([InvoiceID], [ClientID], [DateIssued], [Month], [Amount], [SubscriptionID]) VALUES (29, N'D00512137', CAST(N'2020-07-11' AS Date), N'July', 430.0000, 29)
INSERT [dbo].[tblMonthlyBill] ([InvoiceID], [ClientID], [DateIssued], [Month], [Amount], [SubscriptionID]) VALUES (32, N'D00512137', CAST(N'2020-07-12' AS Date), N'July', 89.0000, 32)
SET IDENTITY_INSERT [dbo].[tblMonthlyBill] OFF
GO
INSERT [dbo].[tblProduct] ([ProdID], [Name], [Description], [CostPerMonth], [LatestVersion], [VersionReleaseDate], [ManufacturerID]) VALUES (N'HCM', N'Home Convenience Management', N'task automation through control devices. a. Use schedule or external notification from resident to prepare house to resident’s requirements and mood. b. Perform household functions such as drawing curtains, playing selected music, running bath water, defrosting frozen food and cooking meals to be ready at the time the resident is expected home. c. Adjust schedules upon notification that resident is delayed, for example when stuck in traffic. d. Provide secure access to home functions for resident from any location globally.  ', 250.0000, N'HCM30', CAST(N'2018-03-13' AS Date), 1)
INSERT [dbo].[tblProduct] ([ProdID], [Name], [Description], [CostPerMonth], [LatestVersion], [VersionReleaseDate], [ManufacturerID]) VALUES (N'HEM', N'Home Energy Management', N'energy production (solar and oil-combustion) and energy consumption (scheduling of energy-intensive activities).  Integrates various hardware devices, controllers and sensors to provide interfaces/drivers with intelligent management software. a. Maintain temperature in geysers and central heating within defined ranges. b. Produce energy as required to avoid drawing on external supplies.  Input regarding predicted weather conditions may select between sources of production. c. Perform home functions at optimal times. d. Switch lights and other devices on and off automatically using movement sensors. ', 89.0000, N'HEM40', CAST(N'2020-01-20' AS Date), 2)
INSERT [dbo].[tblProduct] ([ProdID], [Name], [Description], [CostPerMonth], [LatestVersion], [VersionReleaseDate], [ManufacturerID]) VALUES (N'HSM', N'Home Safety Management', N'security systems, contact with external security providers, safety devices such as smoke detectors or other sensors, contact with emergency services, panic modes. a. Schedule modes by time of day, absence/presence of residents. b. Activate of alarms, escalation of warnings, bypass to external when empty. c. Deliver notifications and warnings via different channels and respond through activation of devices such as sprinkler systems. d. Define and customise different response plans. ', 200.0000, N'HSM87', CAST(N'2019-02-12' AS Date), 3)
GO
INSERT [dbo].[tblProductTerms] ([ProdID], [UpgradeConditions], [CorrectiveMaintenance], [PremeptiveMaintenance]) VALUES (N'HCM', N'Upgrade only when a new version is available', N'On request with valid reason provided', N'Maintanence performed yearly')
INSERT [dbo].[tblProductTerms] ([ProdID], [UpgradeConditions], [CorrectiveMaintenance], [PremeptiveMaintenance]) VALUES (N'HEM', N'Upgrade only when a new version is available', N'On request with valid reason provided', N'Maintenance performed quarterly')
INSERT [dbo].[tblProductTerms] ([ProdID], [UpgradeConditions], [CorrectiveMaintenance], [PremeptiveMaintenance]) VALUES (N'HSM', N'Upgrade only when a new version is available', N'On request with valid reason provided', N'Maintenance performed monthly')
GO
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Gauteng', N'Johannesburg')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Gauteng', N'Pretoria')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Gauteng', N'Centurion')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Gauteng', N'Sandton')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Gauteng', N'Midrand')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Western Cape', N'Cape Town')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Westerrn Cape', N'Stellenbosch')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Western Cape', N'Paarl')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Western Cape', N'Knysna')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Western Cape', N'Geroge')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Eastern Cape', N'Port Elizabeth')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Eastern Cape', N'East London')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Eastern Cape', N'Grahamstown')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Eastern Cape', N'Jeffrey''s Bay')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Eastern Cape', N'Bishp')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Free State', N'Bloemfontein')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Free State', N'Welkom')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Free State', N'Bethlehem')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Free State', N'Parys')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Free State', N'Sasolburg')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'KwaZulu Natal', N'Durban')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'KwaZulu Natal', N'Newcastle')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'KwaZulu Natal', N'Pinetown')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'KwaZulu Natal', N'Richards Bay')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'KwaZulu Natal', N'Ladysmith')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Limpopo', N'Polokwane')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Limpopo', N'Bela-Bela')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Limpopo', N'Mokopane')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Limpopo', N'Louis Trichard')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Mpumalanga', N'Nelspruit')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Mpumalanga', N'Secunda')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Mpumalanga', N'Middelburg')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'North West', N'Potchefstroom')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'North West', N'Brits')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'North West', N'Mahikeng')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'North West', N'Vryburg')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Northern Cape', N'Kimberly')
INSERT [dbo].[tblProvinces] ([Province], [City]) VALUES (N'Northern Cape', N'Upington')
GO
SET IDENTITY_INSERT [dbo].[tblSubscriptions] ON 

INSERT [dbo].[tblSubscriptions] ([SubscriptionID], [ClientID], [ProdID], [Version], [Date], [CostPerMonth], [SerialNumber]) VALUES (29, N'D00512137', N'HCM', N'HCM30', CAST(N'2020-07-11' AS Date), 430.0000, N'0506882163')
INSERT [dbo].[tblSubscriptions] ([SubscriptionID], [ClientID], [ProdID], [Version], [Date], [CostPerMonth], [SerialNumber]) VALUES (32, N'D00512137', N'HEM', N'HEM40', CAST(N'2020-07-12' AS Date), 89.0000, N'0471710139')
SET IDENTITY_INSERT [dbo].[tblSubscriptions] OFF
GO
ALTER TABLE [dbo].[tblAddOn]  WITH CHECK ADD  CONSTRAINT [FK_tblAddOn_tblManufacturer] FOREIGN KEY([ManufacturerID])
REFERENCES [dbo].[tblManufacturer] ([ManufacturerID])
GO
ALTER TABLE [dbo].[tblAddOn] CHECK CONSTRAINT [FK_tblAddOn_tblManufacturer]
GO
ALTER TABLE [dbo].[tblCallCentre]  WITH CHECK ADD  CONSTRAINT [FK_tblCallCentre_tblEmployee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[tblEmployee] ([ID])
GO
ALTER TABLE [dbo].[tblCallCentre] CHECK CONSTRAINT [FK_tblCallCentre_tblEmployee]
GO
ALTER TABLE [dbo].[tblClient]  WITH CHECK ADD  CONSTRAINT [FK_tblClient_tblClientImportance] FOREIGN KEY([Importance])
REFERENCES [dbo].[tblClientImportance] ([ID])
GO
ALTER TABLE [dbo].[tblClient] CHECK CONSTRAINT [FK_tblClient_tblClientImportance]
GO
ALTER TABLE [dbo].[tblClientAddOn]  WITH CHECK ADD  CONSTRAINT [FK_tblClientAddOn_tblAddOn] FOREIGN KEY([AddID])
REFERENCES [dbo].[tblAddOn] ([ID])
GO
ALTER TABLE [dbo].[tblClientAddOn] CHECK CONSTRAINT [FK_tblClientAddOn_tblAddOn]
GO
ALTER TABLE [dbo].[tblClientAddOn]  WITH CHECK ADD  CONSTRAINT [FK_tblClientAddOn_tblSubscriptions] FOREIGN KEY([SubscriptionID])
REFERENCES [dbo].[tblSubscriptions] ([SubscriptionID])
GO
ALTER TABLE [dbo].[tblClientAddOn] CHECK CONSTRAINT [FK_tblClientAddOn_tblSubscriptions]
GO
ALTER TABLE [dbo].[tblContract]  WITH CHECK ADD  CONSTRAINT [FK_tblContract_tblClient] FOREIGN KEY([ClientID])
REFERENCES [dbo].[tblClient] ([ID])
GO
ALTER TABLE [dbo].[tblContract] CHECK CONSTRAINT [FK_tblContract_tblClient]
GO
ALTER TABLE [dbo].[tblContract]  WITH CHECK ADD  CONSTRAINT [FK_tblContract_tblSubscriptions] FOREIGN KEY([SubscriptionID])
REFERENCES [dbo].[tblSubscriptions] ([SubscriptionID])
GO
ALTER TABLE [dbo].[tblContract] CHECK CONSTRAINT [FK_tblContract_tblSubscriptions]
GO
ALTER TABLE [dbo].[tblEmployee]  WITH CHECK ADD  CONSTRAINT [FK_tblEmployee_tblEmpLevel] FOREIGN KEY([EmpLevel])
REFERENCES [dbo].[tblEmpLevel] ([EmpLevel])
GO
ALTER TABLE [dbo].[tblEmployee] CHECK CONSTRAINT [FK_tblEmployee_tblEmpLevel]
GO
ALTER TABLE [dbo].[tblMonthlyBill]  WITH CHECK ADD  CONSTRAINT [FK_tblMonthlyBill_tblClient] FOREIGN KEY([ClientID])
REFERENCES [dbo].[tblClient] ([ID])
GO
ALTER TABLE [dbo].[tblMonthlyBill] CHECK CONSTRAINT [FK_tblMonthlyBill_tblClient]
GO
ALTER TABLE [dbo].[tblMonthlyBill]  WITH CHECK ADD  CONSTRAINT [FK_tblMonthlyBill_tblSubscriptions] FOREIGN KEY([SubscriptionID])
REFERENCES [dbo].[tblSubscriptions] ([SubscriptionID])
GO
ALTER TABLE [dbo].[tblMonthlyBill] CHECK CONSTRAINT [FK_tblMonthlyBill_tblSubscriptions]
GO
ALTER TABLE [dbo].[tblProduct]  WITH CHECK ADD  CONSTRAINT [FK_tblProduct_tblManufacturer] FOREIGN KEY([ManufacturerID])
REFERENCES [dbo].[tblManufacturer] ([ManufacturerID])
GO
ALTER TABLE [dbo].[tblProduct] CHECK CONSTRAINT [FK_tblProduct_tblManufacturer]
GO
ALTER TABLE [dbo].[tblProductTerms]  WITH CHECK ADD  CONSTRAINT [FK_tblProductTerms_tblProduct] FOREIGN KEY([ProdID])
REFERENCES [dbo].[tblProduct] ([ProdID])
GO
ALTER TABLE [dbo].[tblProductTerms] CHECK CONSTRAINT [FK_tblProductTerms_tblProduct]
GO
ALTER TABLE [dbo].[tblSubscriptions]  WITH CHECK ADD  CONSTRAINT [FK_tblSubscriptions_tblClient] FOREIGN KEY([ClientID])
REFERENCES [dbo].[tblClient] ([ID])
GO
ALTER TABLE [dbo].[tblSubscriptions] CHECK CONSTRAINT [FK_tblSubscriptions_tblClient]
GO
/****** Object:  StoredProcedure [dbo].[procAddAppointement]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procAddAppointement]
	@CID varchar(50),
	@EID INT,
	@DESC VARCHAR(50),
	@DATE DATETIME,
	@PRI int
AS
BEGIN
	INSERT INTO tblEmpBooking(EmployeeID, ClientID, Description, Date, Priority)
	VALUES(@EID, @CID, @DESC, @DATE, @PRI)
END
GO
/****** Object:  StoredProcedure [dbo].[procAddCall]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procAddCall]
	@EMP int,
	@DATE datetime,
	@DUR decimal
AS BEGIN
	INSERT INTO tblCallCentre(EmployeeID, Date, Duration)
	VALUES(@EMP, @DATE, @DUR)
END
GO
/****** Object:  StoredProcedure [dbo].[procAddContract]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procAddContract]
	@CON varchar(50),
	@CID varchar(50),
	@SUB int
AS BEGIN
	INSERT INTO tblContract(ContractID, ClientID, SubscriptionID)
	VALUES(@CON, @CID, @SUB)
END
GO
/****** Object:  StoredProcedure [dbo].[procAddEmployee]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procAddEmployee]
	@FIRST varchar(50),
	@LAST varchar(50),
	@PHN varchar(50),
	@EMAIL varchar(50),
	@EMPL int,
	@USER varchar(50),
	@PASS varchar(50)
AS
BEGIN
	INSERT INTO tblEmployee(FirstName,LastName, Phone, Email, EmpLevel, Username, Password)
	VALUES(@FIRST,@LAST, @PHN, @EMAIL,@EMPL, @USER, @PASS)
END
GO
/****** Object:  StoredProcedure [dbo].[procAllCalls]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procAllCalls]
AS BEGIN
SELECT tblCallCentre.CallID, tblEmployee.FirstName +' '+tblEmployee.LastName AS Employee, tblCallCentre.Date, tblCallCentre.Duration
FROM tblCallCentre
INNER JOIN tblEmployee
ON tblCallCentre.EmployeeID=tblEmployee.ID
END
GO
/****** Object:  StoredProcedure [dbo].[procAppDate]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[procAppDate]
	@DATE date
AS BEGIN
SELECT tblEmpBooking.BookingID, tblEmployee.FirstName+' '+ tblEmployee.LastName AS 'Employee', tblClient.FirstName +' '+ tblClient.LastName AS 'Client', tblEmpBooking.Description,tblEmpBooking.Date, tblEmpBooking.Priority
FROM tblEmpBooking
INNER JOIN tblClient
ON tblEmpBooking.ClientID=tblClient.ID
inner join tblEmployee
on tblEmpBooking.EmployeeID=tblEmployee.ID
WHERE tblEmpBooking.Date=@DATE
END
GO
/****** Object:  StoredProcedure [dbo].[procAppID]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[procAppID]
	@ID int
AS BEGIN
	SELECT tblEmpBooking.BookingID, tblEmployee.FirstName+' '+ tblEmployee.LastName AS 'Employee', tblClient.FirstName +' '+ tblClient.LastName AS 'Client', tblEmpBooking.Description,tblEmpBooking.Date, tblEmpBooking.Priority
from tblEmpBooking
inner join tblEmployee
on tblEmpBooking.EmployeeID=tblEmployee.ID
inner join tblClient
on tblEmpBooking.ClientID=tblClient.ID
where BookingID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[procClientApps]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procClientApps]
	@ID varchar(50)
AS BEGIN
	Select tblEmpBooking.BookingID, tblEmployee.FirstName+' '+ tblEmployee.LastName AS 'Employee',tblClient.FirstName +' '+ tblClient.LastName AS 'Client', tblEmpBooking.Description, tblEmpBooking.Date, tblEmpBooking.Priority
	from tblEmpBooking
	INNER JOIN tblClient
	ON tblEmpBooking.ClientID=tblClient.ID
	INNER JOIN tblEmployee
	ON tblEmpBooking.EmployeeID=tblEmployee.ID
	WHERE tblClient.IDNum=@ID
	ORDER BY tblEmpBooking.Date ASC
END
GO
/****** Object:  StoredProcedure [dbo].[procClientBill]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[procClientBill]
	@ID varchar(50)
AS BEGIN
	SELECT tblMonthlyBill.InvoiceID, tblMonthlyBill.Month, tblMonthlyBill.DateIssued, tblMonthlyBill.Amount
	FROM tblMonthlyBill
	INNER JOIN tblClient
	ON tblMonthlyBill.ClientID=tblClient.ID
	WHERE tblClient.IDNum=@ID;
END
GO
/****** Object:  StoredProcedure [dbo].[procClientSubs]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procClientSubs]
	@ID varchar(50)
AS BEGIN
	SELECT tblSubscriptions.SubscriptionID, tblSubscriptions.ClientID, tblClient.FirstName +' '+tblClient.LastName AS "Client Full Name", tblProduct.Name, tblSubscriptions.Version, tblSubscriptions.CostPerMonth, tblSubscriptions.Date, tblSubscriptions.SerialNumber
	FROM tblSubscriptions
	INNER JOIN tblClient
	ON tblSubscriptions.ClientID = tblClient.ID
	INNER JOIN tblProduct
	ON tblSubscriptions.ProdID=tblProduct.ProdID
	WHERE tblClient.IDNum=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[procDeleteAppointment]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procDeleteAppointment]
	@BID int
AS
BEGIN
	DELETE FROM tblEmpBooking
	WHERE BookingID=@BID
END
GO
/****** Object:  StoredProcedure [dbo].[procDeleteClient]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procDeleteClient]
	@IDNum varchar(50)
AS
BEGIN
	DELETE FROM tblClient
	WHERE IDNum=@IDNum
END
GO
/****** Object:  StoredProcedure [dbo].[procDeleteProduct]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procDeleteProduct]
	@ID varchar(50)
AS BEGIN
	DELETE FROM tblProduct WHERE ProdID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[procEmployeeSchedule]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procEmployeeSchedule]
	@EMPID int
AS BEGIN
	SELECT tblEmpBooking.BookingID, tblClient.FirstName +' '+ tblClient.LastName AS 'Client', tblEmpBooking.Description, tblEmpBooking.Date, tblClient.Location, tblEmpBooking.Priority
	FROM tblEmpBooking
	INNER JOIN tblClient
	ON tblEmpBooking.ClientID=tblClient.ID
	WHERE tblEmpBooking.EmployeeID=@EMPID
	ORDER BY tblEmpBooking.Date ASC
END
GO
/****** Object:  StoredProcedure [dbo].[procGenerateBill]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procGenerateBill]
	@CID varchar(50),
	@DATE datetime,
	@MONTH varchar(50),
	@AMNT money,
	@SID int
AS
BEGIN
	INSERT INTO tblMonthlyBill(ClientID, DateIssued, Month, Amount, SubscriptionID)
	VALUES(@CID, @DATE, @MONTH, @AMNT, @SID)
END
GO
/****** Object:  StoredProcedure [dbo].[procGetClientAddOns]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procGetClientAddOns]
	@SUB int
AS BEGIN
	SELECT * 
	FROM tblClientAddOn
	WHERE SubscriptionID=@SUB
END
GO
/****** Object:  StoredProcedure [dbo].[procGetSubs]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROC [dbo].[procGetSubs]
	AS Begin
	SELECT tblSubscriptions.ClientID, tblClient.FirstName +' '+tblClient.LastName AS "Client Full Name", tblProduct.Name, tblSubscriptions.Version, tblSubscriptions.CostPerMonth, tblSubscriptions.Date, tblSubscriptions.SerialNumber
	FROM tblSubscriptions
	INNER JOIN tblClient
	ON tblSubscriptions.ClientID = tblClient.ID
	INNER JOIN tblProduct
	ON tblSubscriptions.ProdID=tblProduct.ProdID
	end
GO
/****** Object:  StoredProcedure [dbo].[procInsertAddOn]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procInsertAddOn]
	@SID int,
	@AID int,
	@QUAN int
AS BEGIN
	INSERT INTO tblClientAddOn(AddID, SubscriptionID, Quantity)
	VALUES(@AID, @SID, @QUAN)
END
GO
/****** Object:  StoredProcedure [dbo].[procInsertClient]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procInsertClient]
	@ID varchar(50),
	@FirstName varchar(50),
	@LastName varchar(50),
	@IDNum varchar(50),
	@Phone varchar(50),
	@Email varchar(50),
	@Location varchar(50),
	@IMPORT varchar(50)
AS
BEGIN
	INSERT INTO tblClient(ID,FirstName, LastName, IDNum, Phone, Email, Location, Importance) 
	VALUES(@ID, @FirstName, @LastName, @IDNum, @Phone, @Email, @Location, @IMPORT)
END
GO
/****** Object:  StoredProcedure [dbo].[procInsertProduct]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procInsertProduct]
	@ID varchar(50), 
	@NAME varchar(50), 
	@DESC varchar(MAX), 
	@AMNT money, 
	@VERS varchar(50), 
	@DATE date,
	@MAN int
AS BEGIN
	INSERT INTO tblProduct(ProdID, Name, Description, CostPerMonth, LatestVersion, VersionReleaseDate, ManufacturerID) VALUES(@ID, @NAME, @DESC, @AMNT, @VERS, @DATE, @MAN)
END
GO
/****** Object:  StoredProcedure [dbo].[procRemoveBill]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procRemoveBill]
	@ID Varchar(50)
AS BEGIN
	DELETE FROM tblMonthlyBill
	WHERE ClientID=@ID 
END
GO
/****** Object:  StoredProcedure [dbo].[procRemoveSub]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procRemoveSub]
	@ID varchar(50)
AS BEGIN
	DELETE FROM tblContract WHERE ClientID=@ID;
	DELETE FROM tblSubscriptions WHERE ClientID=@ID;
END
GO
/****** Object:  StoredProcedure [dbo].[procRemoveSubscriptions]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procRemoveSubscriptions]
	@ID varchar(50),
	@SUB int,
	@PRODID varchar(50)
AS BEGIN
	DELETE FROM tblContract WHERE ClientID=@ID AND SubscriptionID=@SUB;
	DELETE FROM tblMonthlyBill WHERE ClientID=@ID AND SubscriptionID=@SUB;
	DELETE FROM tblClientAddOn WHERE SubscriptionID=@SUB;
	DELETE FROM tblSubscriptions WHERE ClientID=@ID AND SubscriptionID=@SUB AND ProdID=@PRODID;
	
END
GO
/****** Object:  StoredProcedure [dbo].[procSubscription]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procSubscription]
	@CID varchar(50),
	@DATE date,
	@COST money,
	@PID varchar(50),
	@VER varchar(50),
	@SER varchar(50)
AS BEGIN
	INSERT INTO tblSubscriptions(ClientID, ProdID, Version, Date, CostPerMonth, SerialNumber)
	VALUES(@CID, @PID, @VER, @DATE, @COST, @SER)
END
GO
/****** Object:  StoredProcedure [dbo].[procUpdateAppointment]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procUpdateAppointment]
	@DATE datetime,
	@DESC varchar(50),
	@EID int,
	@BID int,
	@PRI int
AS 
BEGIN
	UPDATE tblEmpBooking 
	SET Date=@DATE, Description=@DESC , EmployeeID=@EID, Priority=@PRI
	WHERE BookingID=@BID
END
GO
/****** Object:  StoredProcedure [dbo].[procUpdateClient]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procUpdateClient]
	@PHN varchar(50),
	@EM varchar(50),
	@LOC varchar(50),
	@IDN varchar(50),
	@IMPORT varchar(50)
AS BEGIN
	UPDATE tblClient SET Phone=@PHN, Email=@EM, Location=@LOC, Importance=@IMPORT WHERE IDNum=@IDN
END
GO
/****** Object:  StoredProcedure [dbo].[procUpdateProduct]    Script Date: 2020/07/12 2:24:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procUpdateProduct]
	@ID varchar(50),
	@DESC varchar(50),
	@COST money,
	@VERSION varchar(50),
	@DATE datetime,
	@MAN int
AS
BEGIN
	UPDATE tblProduct 
	SET Description=@DESC, CostPerMonth=@COST, LatestVersion=@VERSION, VersionReleaseDate=@DATE, ManufacturerID=@MAN
	WHERE ProdID=@ID
END
GO
USE [master]
GO
ALTER DATABASE [Kalan_Rashmika_SEN381_Project] SET  READ_WRITE 
GO
