USE [master]
GO
/****** Object:  Database [PPDBYumitGyuler]    Script Date: 2021-03-01 16:52:45 ******/
CREATE DATABASE [PPDBYumitGyuler]
GO
USE [PPDBYumitGyuler]
GO
/****** Object:  Table [dbo].[ParkingSpot]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParkingSpot](
	[ParkingSpotId] [int] IDENTITY(1,1) NOT NULL,
	[SpotNumber] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ParkingSpotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parking]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parking](
	[ParkingId] [int] IDENTITY(1,1) NOT NULL,
	[LicensePlate] [nvarchar](10) NOT NULL,
	[VehicleTypeId] [int] NOT NULL,
	[ParkingSpotId] [int] NOT NULL,
	[ArrivalDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ParkingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vwEmptySpots]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwEmptySpots]
AS
SELECT SpotNumber FROM ParkingSpot
WHERE ParkingSpotId NOT IN (SELECT ParkingSpotId FROM Parking)
GO
/****** Object:  Table [dbo].[VehicleType]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleType](
	[VehicleTypeId] [int] IDENTITY(1,1) NOT NULL,
	[VehicleName] [nvarchar](20) NOT NULL,
	[CostByHour] [money] NOT NULL,
	[VehicleSize] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[VehicleTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vwGetAllSingeMcId]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwGetAllSingeMcId]
AS
SELECT ps.ParkingSpotID 
FROM ParkingSpot ps
JOIN Parking p ON ps.ParkingSpotID = p.ParkingSpotID
JOIN VehicleType vt ON vt.VehicleTypeID = p.VehicleTypeID
GROUP BY ps.ParkingSpotID
HAVING SUM(vt.VehicleSize) = 1;
GO
/****** Object:  View [dbo].[vwSingelMc]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwSingelMc]
AS
SELECT *
FROM Parking p
WHERE p.ParkingSpotId IN (SELECT * FROM vwGetAllSingeMcId)
GO
/****** Object:  Table [dbo].[History]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History](
	[HistoryId] [int] IDENTITY(1,1) NOT NULL,
	[LicensePlate] [nvarchar](10) NOT NULL,
	[VehicleType] [int] NOT NULL,
	[ArrivalDate] [datetime] NOT NULL,
	[DepartureDate] [datetime] NOT NULL,
	[Cost] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HistoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vwHistory]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwHistory]
AS
SELECT *
FROM History
GO
SET IDENTITY_INSERT [dbo].[History] ON 
GO
INSERT [dbo].[History] ([HistoryId], [LicensePlate], [VehicleType], [ArrivalDate], [DepartureDate], [Cost]) VALUES (1, N'MCL226', 2, CAST(N'2021-01-31T06:29:00.000' AS DateTime), CAST(N'2021-02-02T11:30:00.000' AS DateTime), 63620.0000)
GO
INSERT [dbo].[History] ([HistoryId], [LicensePlate], [VehicleType], [ArrivalDate], [DepartureDate], [Cost]) VALUES (2, N'CAR226', 1, CAST(N'2021-01-31T06:29:00.000' AS DateTime), CAST(N'2021-02-04T10:30:00.000' AS DateTime), 60010.0000)
GO
INSERT [dbo].[History] ([HistoryId], [LicensePlate], [VehicleType], [ArrivalDate], [DepartureDate], [Cost]) VALUES (3, N'MCL225', 2, CAST(N'2021-02-02T04:29:00.000' AS DateTime), CAST(N'2021-02-02T09:30:00.000' AS DateTime), 6020.0000)
GO
INSERT [dbo].[History] ([HistoryId], [LicensePlate], [VehicleType], [ArrivalDate], [DepartureDate], [Cost]) VALUES (4, N'CAR225', 1, CAST(N'2021-02-02T04:29:00.000' AS DateTime), CAST(N'2021-02-02T06:30:00.000' AS DateTime), 1210.0000)
GO
INSERT [dbo].[History] ([HistoryId], [LicensePlate], [VehicleType], [ArrivalDate], [DepartureDate], [Cost]) VALUES (5, N'CAR127', 1, CAST(N'2021-02-02T05:39:00.000' AS DateTime), CAST(N'2021-02-05T21:30:00.000' AS DateTime), 52710.0000)
GO
INSERT [dbo].[History] ([HistoryId], [LicensePlate], [VehicleType], [ArrivalDate], [DepartureDate], [Cost]) VALUES (6, N'MCL227', 2, CAST(N'2021-02-02T05:39:00.000' AS DateTime), CAST(N'2021-02-03T22:30:00.000' AS DateTime), 49020.0000)
GO
INSERT [dbo].[History] ([HistoryId], [LicensePlate], [VehicleType], [ArrivalDate], [DepartureDate], [Cost]) VALUES (7, N'CAR224', 1, CAST(N'2021-02-02T06:19:00.000' AS DateTime), CAST(N'2021-02-02T15:30:00.000' AS DateTime), 5510.0000)
GO
INSERT [dbo].[History] ([HistoryId], [LicensePlate], [VehicleType], [ArrivalDate], [DepartureDate], [Cost]) VALUES (8, N'MCL124', 2, CAST(N'2021-02-02T06:19:00.000' AS DateTime), CAST(N'2021-02-02T13:30:00.000' AS DateTime), 8620.0000)
GO
INSERT [dbo].[History] ([HistoryId], [LicensePlate], [VehicleType], [ArrivalDate], [DepartureDate], [Cost]) VALUES (9, N'CAR123', 1, CAST(N'2021-02-02T06:29:00.000' AS DateTime), CAST(N'2021-02-03T04:30:00.000' AS DateTime), 13210.0000)
GO
INSERT [dbo].[History] ([HistoryId], [LicensePlate], [VehicleType], [ArrivalDate], [DepartureDate], [Cost]) VALUES (10, N'MCL123', 2, CAST(N'2021-02-02T06:29:00.000' AS DateTime), CAST(N'2021-02-03T05:30:00.000' AS DateTime), 27620.0000)
GO
INSERT [dbo].[History] ([HistoryId], [LicensePlate], [VehicleType], [ArrivalDate], [DepartureDate], [Cost]) VALUES (11, N'CAR123', 1, CAST(N'2021-02-02T06:29:00.000' AS DateTime), CAST(N'2021-02-06T00:20:56.870' AS DateTime), 1780.0000)
GO
INSERT [dbo].[History] ([HistoryId], [LicensePlate], [VehicleType], [ArrivalDate], [DepartureDate], [Cost]) VALUES (12, N'CAR124', 1, CAST(N'2021-02-02T06:19:00.000' AS DateTime), CAST(N'2021-02-06T00:21:55.557' AS DateTime), 1780.0000)
GO
INSERT [dbo].[History] ([HistoryId], [LicensePlate], [VehicleType], [ArrivalDate], [DepartureDate], [Cost]) VALUES (13, N'MCL123', 2, CAST(N'2021-02-02T06:29:00.000' AS DateTime), CAST(N'2021-02-06T00:22:14.737' AS DateTime), 0.0000)
GO
SET IDENTITY_INSERT [dbo].[History] OFF
GO
SET IDENTITY_INSERT [dbo].[Parking] ON 
GO
INSERT [dbo].[Parking] ([ParkingId], [LicensePlate], [VehicleTypeId], [ParkingSpotId], [ArrivalDate]) VALUES (1, N'MCL126', 2, 60, CAST(N'2021-01-31T06:29:00.000' AS DateTime))
GO
INSERT [dbo].[Parking] ([ParkingId], [LicensePlate], [VehicleTypeId], [ParkingSpotId], [ArrivalDate]) VALUES (2, N'CAR126', 1, 45, CAST(N'2021-01-31T06:29:00.000' AS DateTime))
GO
INSERT [dbo].[Parking] ([ParkingId], [LicensePlate], [VehicleTypeId], [ParkingSpotId], [ArrivalDate]) VALUES (3, N'MCL125', 2, 60, CAST(N'2021-02-02T04:29:00.000' AS DateTime))
GO
INSERT [dbo].[Parking] ([ParkingId], [LicensePlate], [VehicleTypeId], [ParkingSpotId], [ArrivalDate]) VALUES (4, N'CAR125', 1, 25, CAST(N'2021-02-02T04:29:00.000' AS DateTime))
GO
INSERT [dbo].[Parking] ([ParkingId], [LicensePlate], [VehicleTypeId], [ParkingSpotId], [ArrivalDate]) VALUES (5, N'CAR127', 1, 78, CAST(N'2021-02-02T05:39:00.000' AS DateTime))
GO
INSERT [dbo].[Parking] ([ParkingId], [LicensePlate], [VehicleTypeId], [ParkingSpotId], [ArrivalDate]) VALUES (6, N'MCL127', 2, 93, CAST(N'2021-02-02T05:39:00.000' AS DateTime))
GO
INSERT [dbo].[Parking] ([ParkingId], [LicensePlate], [VehicleTypeId], [ParkingSpotId], [ArrivalDate]) VALUES (8, N'MCL124', 2, 54, CAST(N'2021-02-02T06:19:00.000' AS DateTime))
GO
INSERT [dbo].[Parking] ([ParkingId], [LicensePlate], [VehicleTypeId], [ParkingSpotId], [ArrivalDate]) VALUES (11, N'TEST123', 1, 1, CAST(N'2021-02-06T00:20:40.443' AS DateTime))
GO
INSERT [dbo].[Parking] ([ParkingId], [LicensePlate], [VehicleTypeId], [ParkingSpotId], [ArrivalDate]) VALUES (12, N'HJS404', 1, 2, CAST(N'2021-03-01T16:50:24.110' AS DateTime))
GO
INSERT [dbo].[Parking] ([ParkingId], [LicensePlate], [VehicleTypeId], [ParkingSpotId], [ArrivalDate]) VALUES (13, N'HJS402', 2, 54, CAST(N'2021-03-01T16:51:13.923' AS DateTime))
GO
INSERT [dbo].[Parking] ([ParkingId], [LicensePlate], [VehicleTypeId], [ParkingSpotId], [ArrivalDate]) VALUES (14, N'HJS303', 1, 3, CAST(N'2021-03-01T16:51:28.737' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Parking] OFF
GO
SET IDENTITY_INSERT [dbo].[ParkingSpot] ON 
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (1, 1)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (2, 2)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (3, 3)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (4, 4)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (5, 5)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (6, 6)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (7, 7)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (8, 8)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (9, 9)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (10, 10)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (11, 11)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (12, 12)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (13, 13)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (14, 14)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (15, 15)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (16, 16)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (17, 17)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (18, 18)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (19, 19)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (20, 20)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (21, 21)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (22, 22)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (23, 23)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (24, 24)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (25, 25)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (26, 26)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (27, 27)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (28, 28)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (29, 29)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (30, 30)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (31, 31)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (32, 32)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (33, 33)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (34, 34)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (35, 35)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (36, 36)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (37, 37)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (38, 38)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (39, 39)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (40, 40)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (41, 41)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (42, 42)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (43, 43)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (44, 44)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (45, 45)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (46, 46)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (47, 47)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (48, 48)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (49, 49)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (50, 50)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (51, 51)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (52, 52)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (53, 53)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (54, 54)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (55, 55)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (56, 56)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (57, 57)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (58, 58)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (59, 59)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (60, 60)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (61, 61)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (62, 62)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (63, 63)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (64, 64)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (65, 65)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (66, 66)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (67, 67)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (68, 68)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (69, 69)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (70, 70)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (71, 71)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (72, 72)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (73, 73)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (74, 74)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (75, 75)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (76, 76)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (77, 77)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (78, 78)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (79, 79)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (80, 80)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (81, 81)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (82, 82)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (83, 83)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (84, 84)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (85, 85)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (86, 86)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (87, 87)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (88, 88)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (89, 89)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (90, 90)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (91, 91)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (92, 92)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (93, 93)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (94, 94)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (95, 95)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (96, 96)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (97, 97)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (98, 98)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (99, 99)
GO
INSERT [dbo].[ParkingSpot] ([ParkingSpotId], [SpotNumber]) VALUES (100, 100)
GO
SET IDENTITY_INSERT [dbo].[ParkingSpot] OFF
GO
SET IDENTITY_INSERT [dbo].[VehicleType] ON 
GO
INSERT [dbo].[VehicleType] ([VehicleTypeId], [VehicleName], [CostByHour], [VehicleSize]) VALUES (1, N'Car', 20.0000, 2)
GO
INSERT [dbo].[VehicleType] ([VehicleTypeId], [VehicleName], [CostByHour], [VehicleSize]) VALUES (2, N'Motorcycle', 10.0000, 1)
GO
SET IDENTITY_INSERT [dbo].[VehicleType] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Parking__026BC15CE54A7FF5]    Script Date: 2021-03-01 16:52:45 ******/
ALTER TABLE [dbo].[Parking] ADD UNIQUE NONCLUSTERED 
(
	[LicensePlate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__ParkingS__0FD4FFA1B3FC0298]    Script Date: 2021-03-01 16:52:45 ******/
ALTER TABLE [dbo].[ParkingSpot] ADD UNIQUE NONCLUSTERED 
(
	[SpotNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Parking]  WITH CHECK ADD FOREIGN KEY([ParkingSpotId])
REFERENCES [dbo].[ParkingSpot] ([ParkingSpotId])
GO
ALTER TABLE [dbo].[Parking]  WITH CHECK ADD FOREIGN KEY([VehicleTypeId])
REFERENCES [dbo].[VehicleType] ([VehicleTypeId])
GO
ALTER TABLE [dbo].[Parking]  WITH CHECK ADD  CONSTRAINT [CK_Length] CHECK  ((len([LicensePlate])>=(3) AND len([LicensePlate])<=(10)))
GO
ALTER TABLE [dbo].[Parking] CHECK CONSTRAINT [CK_Length]
GO
/****** Object:  StoredProcedure [dbo].[spAddVehicle]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAddVehicle]
		@LicensePlate nvarchar(10),
		@VehicleTypeId int
AS
BEGIN
--Check if vehicle allready parked.
IF((SELECT LicensePlate FROM Parking WHERE LicensePlate = @LicensePlate) IS NOT NULL)
THROW 50002, 'This vehicle is still parked. You cannot add the same license plate.', 1;
DECLARE @EmptySpot int
--Get back the appropriate place by "@VehicleTypeId"
EXEC spFindEmptySpot @VehicleTypeId, @EmptySpot OUTPUT
	BEGIN TRANSACTION
	BEGIN TRY
		INSERT INTO Parking (LicensePlate,VehicleTypeId,ArrivalDate,ParkingSpotId)
		VALUES (@LicensePlate,@VehicleTypeId,GETDATE(),@EmptySpot)
	COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
	ROLLBACK TRANSACTION
	;THROW 50003, 'For some reason the vehicle could not be added. Please try again', 1;
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[spAverage]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAverage]
 @StartDate DATE, @EndDate DATE, @Average MONEY OUTPUT
AS 
SELECT SUM(Cost) AS TotalCost
INTO #tempGroupDateTable
FROM History
WHERE CONVERT(DATE, DepartureDate) BETWEEN @StartDate AND @EndDate
GROUP BY CONVERT(DATE, DepartureDate)

SET @Average = (SELECT AVG(TotalCost) FROM #tempGroupDateTable)
DROP TABLE #tempGroupDateTable;
GO
/****** Object:  StoredProcedure [dbo].[spCalculatePrice]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCalculatePrice]
		@LicensePlate nvarchar(10),
		@Cost money OUTPUT
AS
DECLARE @CostByHour money = (SELECT vt.CostByHour FROM VehicleType vt INNER JOIN Parking p ON p.VehicleTypeId = vt.VehicleTypeId WHERE p.LicensePlate = @LicensePlate)
DECLARE @TimeDiff int= (SELECT DATEDIFF(minute,ArrivalDate,GETDATE()) FROM Parking WHERE LicensePlate = @LicensePlate)
BEGIN
IF(@TimeDiff <5)
SET @Cost = 0
IF(@TimeDiff < 125)
SET @Cost = @CostByHour*2
ELSE
SET @Cost = CEILING((@TimeDiff-5)/60)*@CostByHour
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteVehicle]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeleteVehicle]
		@LicensePlate nvarchar(10),
		@Cost money
AS
DECLARE @ParkingSpotId int = (SELECT p.ParkingSpotId FROM Parking p WHERE p.LicensePlate = @LicensePlate)
IF(@ParkingSpotId is null) THROW 50001, 'Vehicle could not be found. Please try again', 1;
ELSE
IF(@Cost = -1 ) SET @Cost = 0
ELSE EXECUTE spCalculatePrice @LicensePlate,@Cost OUTPUT
BEGIN
BEGIN TRANSACTION
BEGIN TRY
INSERT INTO History (ArrivalDate,Cost,DepartureDate,LicensePlate,VehicleType)
SELECT p.ArrivalDate,@Cost,GETDATE(),p.LicensePlate,p.VehicleTypeId FROM Parking p WHERE p.LicensePlate = @LicensePlate
DELETE FROM Parking
WHERE ParkingSpotId = @ParkingSpotId
COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
;THROW 50004, 'For some reason the vehicle could not be deleted. Please try again', 1;
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[spFindEmptySpot]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spFindEmptySpot]
		@VehicleType int,
		@EmptySpot int OUTPUT
AS
--If vehicle type is MC
	IF (@VehicleType = 2)
		BEGIN
			SET @EmptySpot = (SELECT TOP(1)SpotNumber
			FROM ParkingSpot ps
				INNER JOIN Parking p ON p.ParkingSpotId = ps.ParkingSpotId
				INNER JOIN VehicleType v ON p.VehicleTypeId = v.VehicleTypeId
			GROUP BY SpotNumber
			HAVING sum(v.VehicleSize) = 1
			ORDER BY SpotNumber)
		END
--If vehicle type is Car or did not find any place for MC
	IF(@EmptySpot is null)
		BEGIN
			SET @EmptySpot =(SELECT TOP(1)SpotNumber
			FROM ParkingSpot ps
			WHERE ps.ParkingSpotId NOT IN (SELECT ParkingSpotId FROM Parking))	
		END
	IF(@EmptySpot is null)
	THROW 50004, 'Could not find a suitable place', 1;
GO
/****** Object:  StoredProcedure [dbo].[spGetDeletedVehicle]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetDeletedVehicle]
		@LicensePlate nvarchar(10)
AS
BEGIN
Select TOP(1)* FROM History WHERE LicensePlate = @LicensePlate ORDER BY DepartureDate DESC
END
GO
/****** Object:  StoredProcedure [dbo].[spGetList]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetList]
AS
BEGIN
SELECT * FROM Parking
ORDER BY ParkingSpotId
END
GO
/****** Object:  StoredProcedure [dbo].[spGetVehicleByLicensePlate]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetVehicleByLicensePlate]
		@LicensePlate nvarchar(10)
AS
BEGIN
IF((SELECT p.ParkingId FROM Parking p WHERE LicensePlate = @LicensePlate) is null)
BEGIN
;THROW 50002, 'Vehicle could not be found. Please try again', 1;
END
SELECT *,GETDATE() as ServerTime
FROM Parking p
INNER JOIN VehicleType v ON p.VehicleTypeId = v.VehicleTypeId
WHERE LicensePlate = @LicensePlate
END
GO
/****** Object:  StoredProcedure [dbo].[spMoveVehicle]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spMoveVehicle]
		@LicensePlate nvarchar(10),
		@NewSpotId int
AS
	DECLARE @OldSpotId int
	DECLARE @VehicleTypeId int
	--Get old spot number and vehicle type
	SELECT @OldSpotId = p.ParkingSpotId ,@VehicleTypeId = p.VehicleTypeId FROM Parking p WHERE p.LicensePlate=@LicensePlate
	--Change spot number to spot ID
	SET @NewSpotId = (SELECT ps.ParkingSpotId FROM ParkingSpot ps WHERE ps.SpotNumber = @NewSpotId)
	---Get current size on new spot 
	DECLARE @SpotSize int = 0
	SET @SpotSize = (SELECT sum(v.VehicleSize) FROM Parking p INNER JOIN VehicleType v ON v.VehicleTypeId = p.VehicleTypeId WHERE p.ParkingSpotId = @NewSpotId)
	--Get Vehicle size
	DECLARE @VehicleSize int = (SELECT VehicleSize FROM VehicleType WHERE VehicleTypeId = @VehicleTypeId)
		--If there is no car with @LicensePlate
		IF(@OldSpotId IS NULL)
			THROW 50005, 'Could not find any parked vehicle', 1;
		ELSE
		BEGIN
			IF (@SpotSize = 1 and @VehicleSize = 2 ) or @SpotSize=2
			THROW 50006, 'The vehicle has not relocated', 1;
			ELSE
			BEGIN
				BEGIN TRANSACTION
				BEGIN TRY
					UPDATE Parking
					SET ParkingSpotId = @NewSpotId
					WHERE LicensePlate = @LicensePlate
				COMMIT TRANSACTION
				END TRY
				BEGIN CATCH
				ROLLBACK TRANSACTION
				END CATCH
			END
		END
GO
/****** Object:  StoredProcedure [dbo].[spOptimizeMc]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spOptimizeMc]
AS
BEGIN
DECLARE @LastSpot int 
DECLARE @FirstSpot int 
DECLARE @ParkingId int 
SET @LastSpot = (SELECT TOP(1)ParkingSpotId FROM vwSingelMc ORDER BY ParkingSpotId DESC)
SET @ParkingId = (SELECT TOP(1)ParkingId FROM vwSingelMc ORDER BY ParkingSpotId DESC)
SET @FirstSpot = (SELECT TOP(1)ParkingSpotId FROM vwSingelMc ORDER BY ParkingSpotId ASC)
BEGIN TRANSACTION
BEGIN TRY
UPDATE Parking
SET ParkingSpotId = @FirstSpot
WHERE ParkingSpotId = @LastSpot
SELECT *,@LastSpot AS OldPlace
FROM Parking
WHERE ParkingId = @ParkingId
COMMIT TRANSACTION 
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[spRevenueInterval]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRevenueInterval]
@StartDate DATE, @EndDate DATE
AS
SELECT dateadd(DAY,0, datediff(day,0, DepartureDate)) AS TotalDate, SUM(Cost) AS TotalCost
FROM History
WHERE Convert(date, DepartureDate) BETWEEN @StartDate AND @EndDate
GROUP BY dateadd(DAY,0, datediff(day,0, DepartureDate))
ORDER BY TotalDate
GO
/****** Object:  StoredProcedure [dbo].[spRevenuePerDay]    Script Date: 2021-03-01 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRevenuePerDay]
AS
SELECT dateadd(DAY,0, datediff(day,0, DepartureDate)) AS TotalDate, SUM(Cost) AS TotalCost
FROM History
GROUP BY dateadd(DAY,0, datediff(day,0, DepartureDate))
ORDER BY TotalDate
GO
USE [master]
GO
ALTER DATABASE [PPDBYumitGyuler] SET  READ_WRITE 
GO
