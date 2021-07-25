/****** Object:  Database [JudgementApp]    Script Date: 22-07-21 5:56:53 PM ******/
CREATE DATABASE [JudgementApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JudgementApp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\JudgementApp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'JudgementApp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\JudgementApp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [JudgementApp] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JudgementApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JudgementApp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JudgementApp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JudgementApp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JudgementApp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JudgementApp] SET ARITHABORT OFF 
GO
ALTER DATABASE [JudgementApp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [JudgementApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JudgementApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JudgementApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JudgementApp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JudgementApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JudgementApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JudgementApp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JudgementApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JudgementApp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [JudgementApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JudgementApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JudgementApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JudgementApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JudgementApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JudgementApp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JudgementApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JudgementApp] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [JudgementApp] SET  MULTI_USER 
GO
ALTER DATABASE [JudgementApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JudgementApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JudgementApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JudgementApp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [JudgementApp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [JudgementApp] SET QUERY_STORE = OFF
GO
/****** Object:  Table [dbo].[CreateProblem]    Script Date: 22-07-21 5:56:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreateProblem](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[QuestionNo] [int] NULL,
	[P1] [varchar](50) NULL,
	[P2] [varchar](50) NULL,
	[P3] [varchar](50) NULL,
	[P4] [varchar](50) NULL,
 CONSTRAINT [PK_CreateProblem] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Judgement]    Script Date: 22-07-21 5:56:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Judgement](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Q1] [varchar](50) NULL,
	[Q2] [varchar](50) NULL,
	[Q3] [varchar](50) NULL,
	[Q4] [varchar](50) NULL,
	[TotalCorrect] [int] NULL,
	[Date] [date] NULL,
 CONSTRAINT [PK_Judgement] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Results]    Script Date: 22-07-21 5:56:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Results](
	[Id] [int] NULL,
	[QuestionNo] [int] NULL,
	[Result] [varchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CreateProblem] ON 

INSERT [dbo].[CreateProblem] ([ID], [QuestionNo], [P1], [P2], [P3], [P4]) VALUES (1, 1, N'A', N'123', N'12:00 noon', NULL)
INSERT [dbo].[CreateProblem] ([ID], [QuestionNo], [P1], [P2], [P3], [P4]) VALUES (2, 2, N'A', N'above', N'123', N'today')
INSERT [dbo].[CreateProblem] ([ID], [QuestionNo], [P1], [P2], [P3], [P4]) VALUES (3, 3, N'A', NULL, NULL, NULL)
INSERT [dbo].[CreateProblem] ([ID], [QuestionNo], [P1], [P2], [P3], [P4]) VALUES (4, 4, N'A', N'12:00 noon', NULL, NULL)
SET IDENTITY_INSERT [dbo].[CreateProblem] OFF
SET IDENTITY_INSERT [dbo].[Judgement] ON 

INSERT [dbo].[Judgement] ([Id], [Name], [Q1], [Q2], [Q3], [Q4], [TotalCorrect], [Date]) VALUES (1, N'Abdul', N'Fact', N'Fact', N'PM', N'Before', 3, CAST(N'2021-07-19' AS Date))
INSERT [dbo].[Judgement] ([Id], [Name], [Q1], [Q2], [Q3], [Q4], [TotalCorrect], [Date]) VALUES (2, N'John', N'Fact', N'Fact', N'AM', N'Before', 2, CAST(N'2021-07-19' AS Date))
INSERT [dbo].[Judgement] ([Id], [Name], [Q1], [Q2], [Q3], [Q4], [TotalCorrect], [Date]) VALUES (3, N'Mike', N'Fact', N'Fiction', N'PM', N'After', 1, CAST(N'2021-07-19' AS Date))
INSERT [dbo].[Judgement] ([Id], [Name], [Q1], [Q2], [Q3], [Q4], [TotalCorrect], [Date]) VALUES (4, N'Bruce', N'', N'', N'', N'', 0, CAST(N'2021-07-19' AS Date))
INSERT [dbo].[Judgement] ([Id], [Name], [Q1], [Q2], [Q3], [Q4], [TotalCorrect], [Date]) VALUES (5, N'Duck', N'Fact', N'Fiction', N'PM', N'Before', 2, CAST(N'2021-07-19' AS Date))
INSERT [dbo].[Judgement] ([Id], [Name], [Q1], [Q2], [Q3], [Q4], [TotalCorrect], [Date]) VALUES (1020, N'123', N'Fiction', N'Fact', N'AM', N'Before', 3, CAST(N'2021-07-19' AS Date))
INSERT [dbo].[Judgement] ([Id], [Name], [Q1], [Q2], [Q3], [Q4], [TotalCorrect], [Date]) VALUES (1023, N'Abdul Moiz', N'Fact', N'Fact', N'AM', N'Before', NULL, CAST(N'2021-07-20' AS Date))
INSERT [dbo].[Judgement] ([Id], [Name], [Q1], [Q2], [Q3], [Q4], [TotalCorrect], [Date]) VALUES (1024, N'123', N'Fiction', N'Fact', N'AM', N'Before', NULL, CAST(N'2021-07-20' AS Date))
INSERT [dbo].[Judgement] ([Id], [Name], [Q1], [Q2], [Q3], [Q4], [TotalCorrect], [Date]) VALUES (1025, N'Abdul', N'Fiction', N'Fiction', N'PM', N'After', NULL, CAST(N'2021-07-20' AS Date))
SET IDENTITY_INSERT [dbo].[Judgement] OFF
ALTER DATABASE [JudgementApp] SET  READ_WRITE 
GO
