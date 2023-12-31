/****** Object:  Database [studentsdetails]    Script Date: 28-08-2023 10:59:42 ******/
CREATE DATABASE [studentsdetails] ON  PRIMARY 
( NAME = N'studentsdetails', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\studentsdetails.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'studentsdetails_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\studentsdetails_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [studentsdetails].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [studentsdetails] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [studentsdetails] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [studentsdetails] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [studentsdetails] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [studentsdetails] SET ARITHABORT OFF 
GO
ALTER DATABASE [studentsdetails] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [studentsdetails] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [studentsdetails] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [studentsdetails] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [studentsdetails] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [studentsdetails] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [studentsdetails] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [studentsdetails] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [studentsdetails] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [studentsdetails] SET  ENABLE_BROKER 
GO
ALTER DATABASE [studentsdetails] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [studentsdetails] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [studentsdetails] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [studentsdetails] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [studentsdetails] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [studentsdetails] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [studentsdetails] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [studentsdetails] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [studentsdetails] SET  MULTI_USER 
GO
ALTER DATABASE [studentsdetails] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [studentsdetails] SET DB_CHAINING OFF 
GO
/****** Object:  Table [dbo].[StudBasicDetails]    Script Date: 28-08-2023 10:59:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudBasicDetails](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[Age] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[StudBasicDetails] ([Id], [Name], [Gender], [Age]) VALUES (1, N'anwar', N'Male', 24)
INSERT [dbo].[StudBasicDetails] ([Id], [Name], [Gender], [Age]) VALUES (2, N'Tom', N'Male', 25)
INSERT [dbo].[StudBasicDetails] ([Id], [Name], [Gender], [Age]) VALUES (3, N'riya', N'female', 25)
INSERT [dbo].[StudBasicDetails] ([Id], [Name], [Gender], [Age]) VALUES (4, N'vinith', N'Male', 34)
INSERT [dbo].[StudBasicDetails] ([Id], [Name], [Gender], [Age]) VALUES (5, N'albert', N'male', 38)
INSERT [dbo].[StudBasicDetails] ([Id], [Name], [Gender], [Age]) VALUES (6, N'simon', N'male', 54)
GO
ALTER DATABASE [studentsdetails] SET  READ_WRITE 
GO
