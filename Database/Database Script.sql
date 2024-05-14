USE [master]
GO
/****** Object:  Database [SupplierConnectDB]    Script Date: 2024/05/14 02:31:17 ******/
CREATE DATABASE [SupplierConnectDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SupplierConnectDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SupplierConnectDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SupplierConnectDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SupplierConnectDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SupplierConnectDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SupplierConnectDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SupplierConnectDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SupplierConnectDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SupplierConnectDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SupplierConnectDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SupplierConnectDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET RECOVERY FULL 
GO
ALTER DATABASE [SupplierConnectDB] SET  MULTI_USER 
GO
ALTER DATABASE [SupplierConnectDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SupplierConnectDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SupplierConnectDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SupplierConnectDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SupplierConnectDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SupplierConnectDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SupplierConnectDB', N'ON'
GO
ALTER DATABASE [SupplierConnectDB] SET QUERY_STORE = OFF
GO
USE [SupplierConnectDB]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 2024/05/14 02:31:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[Code] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[TelephoneNo] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK__Supplier__3214EC07DADA835A] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Suppliers] ON 
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (6, N'Tutuka Motor Holdings Pty Ltd t/a Tutuka Motor Lab', N'0117044324')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (34, N'GSM Electro', N'0128110069')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (45, N'L.A Auto Center CC t/a LA Body Works', N'0219488412')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (53, N'Brietta Trading (Pty) Ltd', N'0115526000')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (67, N'M.M Hydraulics CC', N'011425 6578')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (134, N'WP Exhaust Brake & Clutch t/a In Focus Fleet Services', N'0219055028')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (234, N'Eskom Holdings Limited', N'086 0037566')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (345, N'Picaro 115 CC t/a H2O CT Services', N'0216745710')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (392, N'C.N. Braam t/a CNB Electrical Services', N'0832835399')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (625, N'Creative Crew (Pty) Ltd', N'0120040218')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (667, N'L. J. Ross t/a Petite Cafe''', N'0117868101')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (876, N'Safic (Pty) Ltd', N'0114064000')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (935, N'The Fitment Zone CC', N'0118234181')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (939, N'Focus Rooms (Pty) Ltd', N'0820776910')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (1264, N'Jody and Herman Investments CC', N'0118864227')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (1351, N'LG Tow-In CC', N'0828044026')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (1352, N'LM Greyling t/aThe Electric Advertiser', N'0119545972')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (1437, N'M.H Cloete Enterprises (Pty) Ltd t/a Rola Motors', N'0218418300')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (1980, N'Phulo Human Capital (Pty) Ltd', N'0114755934')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (2279, N'Safetygrip CC', N'0117086660')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (2549, N'The Financial Planning Institute Of Southern Africa', N'0861000374')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (2693, N'Turnweld Engineering CC', N'0115468790')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (3277, N'WP Sekuriteit', N'0233421732')
GO
INSERT [dbo].[Suppliers] ([Code], [Name], [TelephoneNo]) VALUES (5667, N'Johan Le Roux Ingenieurswerke', N'0233423390')
GO
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
GO
USE [master]
GO
ALTER DATABASE [SupplierConnectDB] SET  READ_WRITE 
GO
