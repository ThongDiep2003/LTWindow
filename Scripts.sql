USE [master]
GO
/****** Object:  Database [QLThietBi]    Script Date: 21/07/2023 4:26:37 CH ******/
CREATE DATABASE [QLThietBi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLThietBi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLThietBi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLThietBi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLThietBi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLThietBi] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLThietBi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLThietBi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLThietBi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLThietBi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLThietBi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLThietBi] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLThietBi] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLThietBi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLThietBi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLThietBi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLThietBi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLThietBi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLThietBi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLThietBi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLThietBi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLThietBi] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLThietBi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLThietBi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLThietBi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLThietBi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLThietBi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLThietBi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLThietBi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLThietBi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLThietBi] SET  MULTI_USER 
GO
ALTER DATABASE [QLThietBi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLThietBi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLThietBi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLThietBi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLThietBi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLThietBi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLThietBi] SET QUERY_STORE = OFF
GO
USE [QLThietBi]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 21/07/2023 4:26:37 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [nvarchar](10) NOT NULL,
	[TenPhong] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_Phong]    Script Date: 21/07/2023 4:26:37 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Phong](
	[MaPhong] [nvarchar](10) NOT NULL,
	[MaThietBi] [nvarchar](10) NOT NULL,
	[Ngay] [date] NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC,
	[MaThietBi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThietBi]    Script Date: 21/07/2023 4:26:37 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThietBi](
	[MaThietBi] [nvarchar](10) NOT NULL,
	[TenThietBi] [nvarchar](30) NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThietBi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Phong] ([MaPhong], [TenPhong]) VALUES (N'P001', N'Phong 1')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong]) VALUES (N'P002', N'Phong 2')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong]) VALUES (N'P003', N'Phong 3')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong]) VALUES (N'P004', N'Phong 4')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong]) VALUES (N'P005', N'Phong 5')
GO
INSERT [dbo].[TB_Phong] ([MaPhong], [MaThietBi], [Ngay], [SoLuong]) VALUES (N'P001', N'TB001', CAST(N'2023-07-18' AS Date), 1)
INSERT [dbo].[TB_Phong] ([MaPhong], [MaThietBi], [Ngay], [SoLuong]) VALUES (N'P001', N'TB002', CAST(N'2023-07-19' AS Date), 1)
INSERT [dbo].[TB_Phong] ([MaPhong], [MaThietBi], [Ngay], [SoLuong]) VALUES (N'P001', N'TB003', CAST(N'2023-07-19' AS Date), 2)
INSERT [dbo].[TB_Phong] ([MaPhong], [MaThietBi], [Ngay], [SoLuong]) VALUES (N'P002', N'TB002', CAST(N'2023-07-16' AS Date), 1)
INSERT [dbo].[TB_Phong] ([MaPhong], [MaThietBi], [Ngay], [SoLuong]) VALUES (N'P002', N'TB005', CAST(N'2023-07-18' AS Date), 20)
INSERT [dbo].[TB_Phong] ([MaPhong], [MaThietBi], [Ngay], [SoLuong]) VALUES (N'P003', N'TB001', CAST(N'2023-07-16' AS Date), 1)
INSERT [dbo].[TB_Phong] ([MaPhong], [MaThietBi], [Ngay], [SoLuong]) VALUES (N'P005', N'TB002', CAST(N'2023-07-19' AS Date), 1)
INSERT [dbo].[TB_Phong] ([MaPhong], [MaThietBi], [Ngay], [SoLuong]) VALUES (N'P005', N'TB003', CAST(N'2023-07-17' AS Date), 4)
INSERT [dbo].[TB_Phong] ([MaPhong], [MaThietBi], [Ngay], [SoLuong]) VALUES (N'P005', N'TB004', CAST(N'2023-07-20' AS Date), 1)
GO
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB001', N'TiVi', 10)
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB002', N'May lanh', 8)
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB003', N'May quat', 15)
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB004', N'May chieu', 10)
INSERT [dbo].[ThietBi] ([MaThietBi], [TenThietBi], [SoLuong]) VALUES (N'TB005', N'PC', 40)
GO
ALTER TABLE [dbo].[TB_Phong]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[TB_Phong]  WITH CHECK ADD FOREIGN KEY([MaThietBi])
REFERENCES [dbo].[ThietBi] ([MaThietBi])
GO
USE [master]
GO
ALTER DATABASE [QLThietBi] SET  READ_WRITE 
GO
