USE [master]
GO
/****** Object:  Database [Kalan_Rashmika_SEN381_Project]    Script Date: 2020/05/19 3:50:02 PM ******/
CREATE DATABASE [Kalan_Rashmika_SEN381_Project]

GO
USE [Kalan_Rashmika_SEN381_Project]
GO
/****** Object:  Table [dbo].[tblAddOn]    Script Date: 2020/05/19 3:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAddOn](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[Cost] [money] NOT NULL,
 CONSTRAINT [PK_tblAddOn] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCallCentre]    Script Date: 2020/05/19 3:50:03 PM ******/
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
/****** Object:  Table [dbo].[tblClient]    Script Date: 2020/05/19 3:50:03 PM ******/
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
 CONSTRAINT [PK_tblClient] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmpBooking]    Script Date: 2020/05/19 3:50:03 PM ******/
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
	[Priority] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblEmpBooking] PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmpLevel]    Script Date: 2020/05/19 3:50:03 PM ******/
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
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 2020/05/19 3:50:03 PM ******/
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
/****** Object:  Table [dbo].[tblMonthlyBill]    Script Date: 2020/05/19 3:50:03 PM ******/
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
 CONSTRAINT [PK_tblMonthlyBill] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProduct]    Script Date: 2020/05/19 3:50:03 PM ******/
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
 CONSTRAINT [PK_tblProduct] PRIMARY KEY CLUSTERED 
(
	[ProdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProvinces]    Script Date: 2020/05/19 3:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProvinces](
	[Province] [varchar](max) NOT NULL,
	[City] [varchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSubscriptions]    Script Date: 2020/05/19 3:50:03 PM ******/
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
 CONSTRAINT [PK_tblSuscriptions] PRIMARY KEY CLUSTERED 
(
	[SubscriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblAddOn] ON 

INSERT [dbo].[tblAddOn] ([ID], [Name], [Description], [Cost]) VALUES (3, N'Sensor', N' may be passive, simply relaying observations continuously, or active, reporting only changes in values or measurements outside specified ranges', 90.0000)
INSERT [dbo].[tblAddOn] ([ID], [Name], [Description], [Cost]) VALUES (4, N'Actors', N'effect changes in the environment, within continuous ranges such as mechanical movement or discrete states such as toggling switches.  ', 150.0000)
INSERT [dbo].[tblAddOn] ([ID], [Name], [Description], [Cost]) VALUES (5, N'Controllers', N' perform logical operations, make decisions and manage environmental factors within defined ranges through negative feedback loops. 
Each ', 160.0000)
SET IDENTITY_INSERT [dbo].[tblAddOn] OFF
SET IDENTITY_INSERT [dbo].[tblCallCentre] ON 

INSERT [dbo].[tblCallCentre] ([CallID], [EmployeeID], [Date], [Duration]) VALUES (1, 4, CAST(N'2020-05-05T00:00:00.000' AS DateTime), CAST(120.00 AS Decimal(34, 2)))
INSERT [dbo].[tblCallCentre] ([CallID], [EmployeeID], [Date], [Duration]) VALUES (3, 20, CAST(N'2020-05-16T19:00:03.767' AS DateTime), CAST(1.00 AS Decimal(34, 2)))
SET IDENTITY_INSERT [dbo].[tblCallCentre] OFF
INSERT [dbo].[tblClient] ([ID], [FirstName], [LastName], [IDNum], [Phone], [Email], [Location]) VALUES (N'A00000001', N'PROV', N'PROV', N'9908150125252', N'0845887895', N'PROV@EM', N'45 THERE, Johannesburg, Gauteng')
INSERT [dbo].[tblClient] ([ID], [FirstName], [LastName], [IDNum], [Phone], [Email], [Location]) VALUES (N'A00000002', N'Chandler', N'Bing', N'9705120125268', N'0845213698', N'cb@gmail.com', N'21 New York Avenue')
INSERT [dbo].[tblClient] ([ID], [FirstName], [LastName], [IDNum], [Phone], [Email], [Location]) VALUES (N'A00000003', N'Monica', N'Geller', N'9908154522369', N'0541223578', N'mg@yahoo.com', N'32 Friends Street')
INSERT [dbo].[tblClient] ([ID], [FirstName], [LastName], [IDNum], [Phone], [Email], [Location]) VALUES (N'A00000004', N'Ross', N'Geller', N'7501125885622', N'0215487896', N'rg@dinosaurs.com', N'90 Break Avenue')
INSERT [dbo].[tblClient] ([ID], [FirstName], [LastName], [IDNum], [Phone], [Email], [Location]) VALUES (N'B00000002', N'Rashmika', N'Kalan', N'9908160182080', N'0848102707', N'kalan@gmail.com', N'234 Here, Centurion, Gauteng')
INSERT [dbo].[tblClient] ([ID], [FirstName], [LastName], [IDNum], [Phone], [Email], [Location]) VALUES (N'C00000001', N'Khaleesi', N'Dragon', N'9512054789568', N'0845789546', N'khaleesi@dragon.com', N'12 Game Road, Winterfell')
INSERT [dbo].[tblClient] ([ID], [FirstName], [LastName], [IDNum], [Phone], [Email], [Location]) VALUES (N'D00000002', N'Test', N'Test', N'9908160182050', N'0845874856', N'test@yahoo.com', N'1 Test Street, New York')
SET IDENTITY_INSERT [dbo].[tblEmpBooking] ON 

INSERT [dbo].[tblEmpBooking] ([BookingID], [EmployeeID], [ClientID], [Description], [Date], [Priority]) VALUES (1, 5, N'A00000002', N'Upgrade', CAST(N'2020-05-26T00:00:00.000' AS DateTime), N'High')
INSERT [dbo].[tblEmpBooking] ([BookingID], [EmployeeID], [ClientID], [Description], [Date], [Priority]) VALUES (7, 5, N'A00000003', N'Upgrade', CAST(N'2020-05-28T08:20:00.000' AS DateTime), N'Medium')
INSERT [dbo].[tblEmpBooking] ([BookingID], [EmployeeID], [ClientID], [Description], [Date], [Priority]) VALUES (9, 5, N'B00000002', N'Maintanance', CAST(N'2020-05-14T17:47:58.000' AS DateTime), N'High')
INSERT [dbo].[tblEmpBooking] ([BookingID], [EmployeeID], [ClientID], [Description], [Date], [Priority]) VALUES (12, 5, N'B00000002', N'Maintanance', CAST(N'2020-05-13T17:48:40.000' AS DateTime), N'High')
SET IDENTITY_INSERT [dbo].[tblEmpBooking] OFF
SET IDENTITY_INSERT [dbo].[tblEmpLevel] ON 

INSERT [dbo].[tblEmpLevel] ([EmpLevel], [Role]) VALUES (1, N'CEO')
INSERT [dbo].[tblEmpLevel] ([EmpLevel], [Role]) VALUES (2, N'Product')
INSERT [dbo].[tblEmpLevel] ([EmpLevel], [Role]) VALUES (3, N'Client')
INSERT [dbo].[tblEmpLevel] ([EmpLevel], [Role]) VALUES (4, N'Technical')
INSERT [dbo].[tblEmpLevel] ([EmpLevel], [Role]) VALUES (5, N'Maintanance')
INSERT [dbo].[tblEmpLevel] ([EmpLevel], [Role]) VALUES (6, N'Employee')
SET IDENTITY_INSERT [dbo].[tblEmpLevel] OFF
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
SET IDENTITY_INSERT [dbo].[tblEmployee] OFF
SET IDENTITY_INSERT [dbo].[tblMonthlyBill] ON 

INSERT [dbo].[tblMonthlyBill] ([InvoiceID], [ClientID], [DateIssued], [Month], [Amount]) VALUES (1, N'A00000002', CAST(N'2020-04-01' AS Date), N'April', 89.0000)
INSERT [dbo].[tblMonthlyBill] ([InvoiceID], [ClientID], [DateIssued], [Month], [Amount]) VALUES (4, N'A00000002', CAST(N'2020-05-25' AS Date), N'May', 698.0000)
INSERT [dbo].[tblMonthlyBill] ([InvoiceID], [ClientID], [DateIssued], [Month], [Amount]) VALUES (5, N'B00000002', CAST(N'2020-05-10' AS Date), N'May', 400.0000)
INSERT [dbo].[tblMonthlyBill] ([InvoiceID], [ClientID], [DateIssued], [Month], [Amount]) VALUES (6, N'B00000002', CAST(N'2020-05-10' AS Date), N'May', 89.0000)
INSERT [dbo].[tblMonthlyBill] ([InvoiceID], [ClientID], [DateIssued], [Month], [Amount]) VALUES (7, N'B00000002', CAST(N'2020-05-10' AS Date), N'May', 430.0000)
INSERT [dbo].[tblMonthlyBill] ([InvoiceID], [ClientID], [DateIssued], [Month], [Amount]) VALUES (12, N'B00000002', CAST(N'2020-05-18' AS Date), N'May', 250.0000)
SET IDENTITY_INSERT [dbo].[tblMonthlyBill] OFF
INSERT [dbo].[tblProduct] ([ProdID], [Name], [Description], [CostPerMonth], [LatestVersion], [VersionReleaseDate]) VALUES (N'HCM', N'Home Convenience Management', N'task automation through control devices. a. Use schedule or external notification from resident to prepare house to resident’s requirements and mood. b. Perform household functions such as drawing curtains, playing selected music, running bath water, defrosting frozen food and cooking meals to be ready at the time the resident is expected home. c. Adjust schedules upon notification that resident is delayed, for example when stuck in traffic. d. Provide secure access to home functions for resident from any location globally.  ', 250.0000, N'3', CAST(N'2018-03-13' AS Date))
INSERT [dbo].[tblProduct] ([ProdID], [Name], [Description], [CostPerMonth], [LatestVersion], [VersionReleaseDate]) VALUES (N'HEM', N'Home Energy Management', N'energy production (solar and oil-combustion) and energy consumption (scheduling of energy-intensive activities).  Integrates various hardware devices, controllers and sensors to provide interfaces/drivers with intelligent management software. a. Maintain temperature in geysers and central heating within defined ranges. b. Produce energy as required to avoid drawing on external supplies.  Input regarding predicted weather conditions may select between sources of production. c. Perform home functions at optimal times. d. Switch lights and other devices on and off automatically using movement sensors. ', 89.0000, N'2', CAST(N'2020-01-20' AS Date))
INSERT [dbo].[tblProduct] ([ProdID], [Name], [Description], [CostPerMonth], [LatestVersion], [VersionReleaseDate]) VALUES (N'HSM', N'Home Safety Management', N'security systems, contact with external security providers, safety devices such as smoke detectors or other sensors, contact with emergency services, panic modes. a. Schedule modes by time of day, absence/presence of residents. b. Activate of alarms, escalation of warnings, bypass to external when empty. c. Deliver notifications and warnings via different channels and respond through activation of devices such as sprinkler systems. d. Define and customise different response plans. ', 200.0000, N'3', CAST(N'2019-02-12' AS Date))
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
SET IDENTITY_INSERT [dbo].[tblSubscriptions] ON 

INSERT [dbo].[tblSubscriptions] ([SubscriptionID], [ClientID], [ProdID], [Version], [Date], [CostPerMonth]) VALUES (1, N'A00000002', N'HEM', N'2', CAST(N'2020-05-10' AS Date), 490.0000)
INSERT [dbo].[tblSubscriptions] ([SubscriptionID], [ClientID], [ProdID], [Version], [Date], [CostPerMonth]) VALUES (5, N'A00000003', N'HCM', N'3', CAST(N'2020-05-10' AS Date), 340.0000)
SET IDENTITY_INSERT [dbo].[tblSubscriptions] OFF
ALTER TABLE [dbo].[tblCallCentre]  WITH CHECK ADD  CONSTRAINT [FK_tblCallCentre_tblEmployee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[tblEmployee] ([ID])
GO
ALTER TABLE [dbo].[tblCallCentre] CHECK CONSTRAINT [FK_tblCallCentre_tblEmployee]
GO
ALTER TABLE [dbo].[tblEmpBooking]  WITH CHECK ADD  CONSTRAINT [FK_tblEmpBooking_tblClient] FOREIGN KEY([ClientID])
REFERENCES [dbo].[tblClient] ([ID])
GO
ALTER TABLE [dbo].[tblEmpBooking] CHECK CONSTRAINT [FK_tblEmpBooking_tblClient]
GO
ALTER TABLE [dbo].[tblEmpBooking]  WITH CHECK ADD  CONSTRAINT [FK_tblEmpBooking_tblEmployee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[tblEmployee] ([ID])
GO
ALTER TABLE [dbo].[tblEmpBooking] CHECK CONSTRAINT [FK_tblEmpBooking_tblEmployee]
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
ALTER TABLE [dbo].[tblSubscriptions]  WITH CHECK ADD  CONSTRAINT [FK_tblSubscriptions_tblClient] FOREIGN KEY([ClientID])
REFERENCES [dbo].[tblClient] ([ID])
GO
ALTER TABLE [dbo].[tblSubscriptions] CHECK CONSTRAINT [FK_tblSubscriptions_tblClient]
GO
/****** Object:  StoredProcedure [dbo].[procAddAppointement]    Script Date: 2020/05/19 3:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procAddAppointement]
	@CID varchar(50),
	@EID INT,
	@DESC VARCHAR(50),
	@DATE DATETIME,
	@PRI Varchar(50)
AS
BEGIN
	INSERT INTO tblEmpBooking(EmployeeID, ClientID, Description, Date, Priority)
	VALUES(@EID, @CID, @DESC, @DATE, @PRI)
END
GO
/****** Object:  StoredProcedure [dbo].[procAddCall]    Script Date: 2020/05/19 3:50:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[procAddEmployee]    Script Date: 2020/05/19 3:50:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[procAllCalls]    Script Date: 2020/05/19 3:50:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[procAppDate]    Script Date: 2020/05/19 3:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[procAppDate]
	@DATE date
AS BEGIN
SELECT tblEmpBooking.BookingID, tblEmployee.FirstName+' '+ tblEmployee.LastName AS 'Employee', tblClient.FirstName +' '+ tblClient.LastName, tblEmpBooking.Description, tblEmpBooking.Priority
FROM tblEmpBooking
INNER JOIN tblClient
ON tblEmpBooking.ClientID=tblClient.ID
inner join tblEmployee
on tblEmpBooking.EmployeeID=tblEmployee.ID
WHERE tblEmpBooking.Date=@DATE
END
GO
/****** Object:  StoredProcedure [dbo].[procAppID]    Script Date: 2020/05/19 3:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[procAppID]
	@ID int
AS BEGIN
	select tblClient.FirstName+' '+tblClient.LastName AS 'Client', tblEmployee.FirstName+' '+ tblEmployee.LastName AS 'Employee', tblEmpBooking.Description, tblEmpBooking.Date, tblEmpBooking.Priority
from tblEmpBooking
inner join tblEmployee
on tblEmpBooking.EmployeeID=tblEmployee.ID
inner join tblClient
on tblEmpBooking.ClientID=tblClient.ID
where BookingID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[procClientApps]    Script Date: 2020/05/19 3:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procClientApps]
	@ID varchar(50)
AS BEGIN
	Select tblEmpBooking.BookingID, tblEmployee.FirstName, tblEmployee.LastName, tblEmpBooking.Description, tblEmpBooking.Date, tblEmpBooking.Priority
	from tblEmpBooking
	INNER JOIN tblClient
	ON tblEmpBooking.ClientID=tblClient.ID
	INNER JOIN tblEmployee
	ON tblEmpBooking.EmployeeID=tblEmployee.ID
	WHERE tblClient.IDNum=@ID
	ORDER BY tblEmpBooking.Date ASC
END
GO
/****** Object:  StoredProcedure [dbo].[procClientBill]    Script Date: 2020/05/19 3:50:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[procClientSubs]    Script Date: 2020/05/19 3:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procClientSubs]
	@ID varchar(50)
AS BEGIN
	SELECT tblSubscriptions.ClientID, tblClient.FirstName +' '+tblClient.LastName AS "Client Full Name", tblProduct.Name, tblSubscriptions.Version, tblSubscriptions.CostPerMonth
	FROM tblSubscriptions
	INNER JOIN tblClient
	ON tblSubscriptions.ClientID = tblClient.ID
	INNER JOIN tblProduct
	ON tblSubscriptions.ProdID=tblProduct.ProdID
	WHERE tblClient.IDNum=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[procDeleteAppointment]    Script Date: 2020/05/19 3:50:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[procDeleteClient]    Script Date: 2020/05/19 3:50:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[procEmployeeSchedule]    Script Date: 2020/05/19 3:50:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[procGenerateBill]    Script Date: 2020/05/19 3:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procGenerateBill]
	@CID varchar(50),
	@DATE datetime,
	@MONTH varchar(50),
	@AMNT money
AS
BEGIN
	INSERT INTO tblMonthlyBill(ClientID, DateIssued, Month, Amount)
	VALUES(@CID, @DATE, @MONTH, @AMNT)
END
GO
/****** Object:  StoredProcedure [dbo].[procGetSubs]    Script Date: 2020/05/19 3:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROC [dbo].[procGetSubs]
	AS Begin
	SELECT tblSubscriptions.ClientID, tblClient.FirstName +' '+tblClient.LastName AS "Client Full Name", tblProduct.Name, tblSubscriptions.Version, tblSubscriptions.CostPerMonth
	FROM tblSubscriptions
	INNER JOIN tblClient
	ON tblSubscriptions.ClientID = tblClient.ID
	INNER JOIN tblProduct
	ON tblSubscriptions.ProdID=tblProduct.ProdID
	end
GO
/****** Object:  StoredProcedure [dbo].[procInsertClient]    Script Date: 2020/05/19 3:50:03 PM ******/
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
	@Location varchar(50)
AS
BEGIN
	INSERT INTO tblClient(ID,FirstName, LastName, IDNum, Phone, Email, Location) 
	VALUES(@ID, @FirstName, @LastName, @IDNum, @Phone, @Email, @Location)
END
GO
/****** Object:  StoredProcedure [dbo].[procRemoveBill]    Script Date: 2020/05/19 3:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procRemoveBill]
	@ID Varchar(50)
AS BEGIN
	Delete from tblMonthlyBill
	WHERE ClientID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[procRemoveSub]    Script Date: 2020/05/19 3:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procRemoveSub]
	@ID Varchar(50),
	@PRODID varchar(50)
AS BEGIN
	DELETE FROM tblSubscriptions
	WHERE ClientID=@ID AND ProdID=@PRODID
END
GO
/****** Object:  StoredProcedure [dbo].[procSubscription]    Script Date: 2020/05/19 3:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[procSubscription]
	@CID varchar(50),
	@DATE date,
	@COST money,
	@PID varchar(50),
	@VER varchar(50)
AS BEGIN
	INSERT INTO tblSubscriptions(ClientID, ProdID, Version, Date, CostPerMonth)
	VALUES(@CID, @PID, @VER, @DATE, @COST)
END
GO
/****** Object:  StoredProcedure [dbo].[procUpdateAppointment]    Script Date: 2020/05/19 3:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procUpdateAppointment]
	@DATE datetime,
	@DESC varchar(50),
	@EID int,
	@BID int,
	@PRI varchar(50)
AS 
BEGIN
	UPDATE tblEmpBooking 
	SET Date=@DATE, Description=@DESC , EmployeeID=@EID, Priority=@PRI
	WHERE BookingID=@BID
END
GO
/****** Object:  StoredProcedure [dbo].[procUpdateProduct]    Script Date: 2020/05/19 3:50:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[procUpdateProduct]
	@ID varchar(50),
	@DESC varchar(50),
	@COST money,
	@VERSION varchar(50),
	@DATE datetime
AS
BEGIN
	UPDATE tblProduct 
	SET Description=@DESC, CostPerMonth=@COST, LatestVersion=@VERSION, VersionReleaseDate=@DATE
	WHERE ProdID=@ID
END
GO
USE [master]
GO
ALTER DATABASE [Kalan_Rashmika_SEN381_Project] SET  READ_WRITE 
GO
