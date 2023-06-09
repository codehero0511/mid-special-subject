USE [master]
GO
/****** Object:  Database [breakfast]    Script Date: 2023/2/20 下午 04:27:53 ******/
CREATE DATABASE [breakfast]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'breakfast', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\breakfast.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'breakfast_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\breakfast_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [breakfast] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [breakfast].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [breakfast] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [breakfast] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [breakfast] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [breakfast] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [breakfast] SET ARITHABORT OFF 
GO
ALTER DATABASE [breakfast] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [breakfast] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [breakfast] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [breakfast] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [breakfast] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [breakfast] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [breakfast] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [breakfast] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [breakfast] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [breakfast] SET  DISABLE_BROKER 
GO
ALTER DATABASE [breakfast] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [breakfast] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [breakfast] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [breakfast] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [breakfast] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [breakfast] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [breakfast] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [breakfast] SET RECOVERY FULL 
GO
ALTER DATABASE [breakfast] SET  MULTI_USER 
GO
ALTER DATABASE [breakfast] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [breakfast] SET DB_CHAINING OFF 
GO
ALTER DATABASE [breakfast] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [breakfast] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [breakfast] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [breakfast] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'breakfast', N'ON'
GO
ALTER DATABASE [breakfast] SET QUERY_STORE = OFF
GO
USE [breakfast]
GO
/****** Object:  Table [dbo].[commodity]    Script Date: 2023/2/20 下午 04:27:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[commodity](
	[商品id] [int] IDENTITY(1,1) NOT NULL,
	[商品名稱] [nvarchar](50) NULL,
	[商品價格] [int] NULL,
 CONSTRAINT [PK_commodity] PRIMARY KEY CLUSTERED 
(
	[商品id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 2023/2/20 下午 04:27:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[會員id] [int] IDENTITY(1,1) NOT NULL,
	[會員姓名] [nvarchar](50) NULL,
	[會員電話] [nvarchar](50) NULL,
	[會員點數] [int] NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[會員id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 2023/2/20 下午 04:27:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[員工id] [int] IDENTITY(1,1) NOT NULL,
	[員工姓名] [nvarchar](50) NULL,
	[員工電話] [nvarchar](50) NULL,
	[員工薪資] [int] NULL,
	[權限] [int] NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[員工id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2023/2/20 下午 04:27:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[commodity] ON 

INSERT [dbo].[commodity] ([商品id], [商品名稱], [商品價格]) VALUES (1, N'卡拉雞腿堡', 70)
INSERT [dbo].[commodity] ([商品id], [商品名稱], [商品價格]) VALUES (2, N'美味蟹堡', 50)
INSERT [dbo].[commodity] ([商品id], [商品名稱], [商品價格]) VALUES (3, N'香脆脆油喳喳', 15)
INSERT [dbo].[commodity] ([商品id], [商品名稱], [商品價格]) VALUES (4, N'照燒丹麥', 55)
INSERT [dbo].[commodity] ([商品id], [商品名稱], [商品價格]) VALUES (6, N'紅茶豆漿', 25)
INSERT [dbo].[commodity] ([商品id], [商品名稱], [商品價格]) VALUES (7, N'咖啡牛奶', 30)
INSERT [dbo].[commodity] ([商品id], [商品名稱], [商品價格]) VALUES (8, N'鮮奶茶', 35)
INSERT [dbo].[commodity] ([商品id], [商品名稱], [商品價格]) VALUES (9, N'原翠綠茶', 20)
INSERT [dbo].[commodity] ([商品id], [商品名稱], [商品價格]) VALUES (10, N'錫蘭紅茶', 20)
INSERT [dbo].[commodity] ([商品id], [商品名稱], [商品價格]) VALUES (11, N'大冰奶', 30)
INSERT [dbo].[commodity] ([商品id], [商品名稱], [商品價格]) VALUES (12, N'奶茶', 10)
INSERT [dbo].[commodity] ([商品id], [商品名稱], [商品價格]) VALUES (15, N'藍莓貝果', 45)
SET IDENTITY_INSERT [dbo].[commodity] OFF
GO
SET IDENTITY_INSERT [dbo].[Members] ON 

INSERT [dbo].[Members] ([會員id], [會員姓名], [會員電話], [會員點數]) VALUES (1, N'派大星', N'0921158278', 20)
INSERT [dbo].[Members] ([會員id], [會員姓名], [會員電話], [會員點數]) VALUES (2, N'珊迪', N'0915754931', 3000)
INSERT [dbo].[Members] ([會員id], [會員姓名], [會員電話], [會員點數]) VALUES (3, N'蝦霸', N'0923564734', 45)
INSERT [dbo].[Members] ([會員id], [會員姓名], [會員電話], [會員點數]) VALUES (4, N'珍珍', N'0975234466', 4900)
INSERT [dbo].[Members] ([會員id], [會員姓名], [會員電話], [會員點數]) VALUES (7, N'泡芙阿姨', N'0912345678', 2000)
SET IDENTITY_INSERT [dbo].[Members] OFF
GO
SET IDENTITY_INSERT [dbo].[Persons] ON 

INSERT [dbo].[Persons] ([員工id], [員工姓名], [員工電話], [員工薪資], [權限]) VALUES (1, N'蟹老闆', N'0919616798', 300000, 100)
INSERT [dbo].[Persons] ([員工id], [員工姓名], [員工電話], [員工薪資], [權限]) VALUES (2, N'章魚哥', N'0975456421', 20000, 1000)
INSERT [dbo].[Persons] ([員工id], [員工姓名], [員工電話], [員工薪資], [權限]) VALUES (3, N'海綿寶寶', N'0975121477', 19000, 1000)
INSERT [dbo].[Persons] ([員工id], [員工姓名], [員工電話], [員工薪資], [權限]) VALUES (4, N'Sys', NULL, NULL, 10)
SET IDENTITY_INSERT [dbo].[Persons] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [Username], [Password]) VALUES (1, N'admin', N'123')
INSERT [dbo].[Users] ([UserID], [Username], [Password]) VALUES (2, N'abc', N'123')
INSERT [dbo].[Users] ([UserID], [Username], [Password]) VALUES (3, N'123', N'456')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
USE [master]
GO
ALTER DATABASE [breakfast] SET  READ_WRITE 
GO
