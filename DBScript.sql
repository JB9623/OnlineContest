USE [master]
GO
/****** Object:  Database [JudgementAppNew]    Script Date: 9/2/2021 1:16:31 PM ******/
CREATE DATABASE [JudgementAppNew]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JudgementAppNew', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\JudgementAppNew.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'JudgementAppNew_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\JudgementAppNew_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [JudgementAppNew] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JudgementAppNew].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JudgementAppNew] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JudgementAppNew] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JudgementAppNew] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JudgementAppNew] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JudgementAppNew] SET ARITHABORT OFF 
GO
ALTER DATABASE [JudgementAppNew] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [JudgementAppNew] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JudgementAppNew] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JudgementAppNew] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JudgementAppNew] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JudgementAppNew] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JudgementAppNew] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JudgementAppNew] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JudgementAppNew] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JudgementAppNew] SET  DISABLE_BROKER 
GO
ALTER DATABASE [JudgementAppNew] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JudgementAppNew] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JudgementAppNew] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JudgementAppNew] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JudgementAppNew] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JudgementAppNew] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JudgementAppNew] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JudgementAppNew] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [JudgementAppNew] SET  MULTI_USER 
GO
ALTER DATABASE [JudgementAppNew] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JudgementAppNew] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JudgementAppNew] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JudgementAppNew] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [JudgementAppNew] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [JudgementAppNew] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'JudgementAppNew', N'ON'
GO
ALTER DATABASE [JudgementAppNew] SET QUERY_STORE = OFF
GO
USE [JudgementAppNew]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 9/2/2021 1:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[PriKey] [bigint] IDENTITY(1,1) NOT NULL,
	[PKCompany] [bigint] NOT NULL,
	[CompanyName] [nvarchar](2000) NULL,
	[Id] [varchar](2000) NULL,
	[EmailAddress] [varchar](200) NULL,
	[Password] [varchar](200) NULL,
	[Logo] [varchar](500) NULL,
	[BackgroundColor] [varchar](200) NULL,
	[CardBackgroundColor] [varchar](200) NULL,
	[HeadingColor] [varchar](200) NULL,
	[TableHeaderColor] [varchar](200) NULL,
	[TextColor] [varchar](200) NULL,
	[LinkColor] [varchar](200) NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ExpiryDate] [datetime] NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[PriKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CreateProblem]    Script Date: 9/2/2021 1:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreateProblem](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FKCompany] [bigint] NULL,
	[ProblemName] [varchar](500) NULL,
	[QuestionNo] [bigint] NULL,
	[P1] [varchar](50) NULL,
	[P2] [varchar](50) NULL,
	[P3] [varchar](50) NULL,
	[P4] [varchar](50) NULL,
	[IsPublish] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[IsExpired] [bit] NULL,
 CONSTRAINT [PK_CreateProblem] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CreateProblemArchive]    Script Date: 9/2/2021 1:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreateProblemArchive](
	[PKCreateProblemHistory] [bigint] IDENTITY(1,1) NOT NULL,
	[ID] [bigint] NOT NULL,
	[FKCompany] [bigint] NULL,
	[ProblemName] [varchar](500) NULL,
	[QuestionNo] [bigint] NULL,
	[P1] [varchar](50) NULL,
	[P2] [varchar](50) NULL,
	[P3] [varchar](50) NULL,
	[P4] [varchar](50) NULL,
 CONSTRAINT [PK_CreateProblemArchive] PRIMARY KEY CLUSTERED 
(
	[PKCreateProblemHistory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Judgement]    Script Date: 9/2/2021 1:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Judgement](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FKCompany] [bigint] NULL,
	[Name] [varchar](50) NULL,
	[UserEmail] [varchar](500) NULL,
	[ProblemName] [varchar](500) NULL,
	[ProblemNo] [int] NULL,
	[TotalCorrect] [int] NULL,
	[Date] [datetime] NULL,
	[Q1] [varchar](50) NULL,
	[T1] [int] NULL,
	[P1] [varchar](500) NULL,
	[R1] [bit] NULL,
	[Q2] [varchar](50) NULL,
	[T2] [int] NULL,
	[P2] [varchar](500) NULL,
	[R2] [bit] NULL,
	[Q3] [varchar](50) NULL,
	[T3] [int] NULL,
	[P3] [varchar](500) NULL,
	[R3] [bit] NULL,
	[Q4] [varchar](50) NULL,
	[T4] [int] NULL,
	[P4] [varchar](500) NULL,
	[R4] [bit] NULL,
	[Q5] [varchar](50) NULL,
	[T5] [int] NULL,
	[P5] [varchar](50) NULL,
	[R5] [bit] NULL,
 CONSTRAINT [PK_Judgement] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 9/2/2021 1:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[PKQuestion] [bigint] IDENTITY(1,1) NOT NULL,
	[Type] [int] NULL,
	[Title] [nvarchar](4000) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedDate] [datetime] NULL,
	[FKCompany] [bigint] NULL,
	[ProblemName] [varchar](500) NULL,
 CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED 
(
	[PKQuestion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Results]    Script Date: 9/2/2021 1:16:32 PM ******/
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
SET IDENTITY_INSERT [dbo].[Questions] ON 

INSERT [dbo].[Questions] ([PKQuestion], [Type], [Title], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [FKCompany], [ProblemName]) VALUES (1, 1, N'Will [Symbol] Hit [Price] by [Time]?', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Questions] ([PKQuestion], [Type], [Title], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [FKCompany], [ProblemName]) VALUES (2, 2, N'Will [Symbol] Close [Above/Below] [Price] by [Time]?', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Questions] ([PKQuestion], [Type], [Title], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [FKCompany], [ProblemName]) VALUES (3, 3, N'Will [Symbol] have a higher return in the AM or PM?', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Questions] ([PKQuestion], [Type], [Title], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [FKCompany], [ProblemName]) VALUES (4, 4, N'Will [Symbol] have a higher return before or after [Time]?', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Questions] ([PKQuestion], [Type], [Title], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [FKCompany], [ProblemName]) VALUES (5, 5, N'Will [Symbol1] outperform [Symbol2] [Time]?', NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Questions] OFF
GO
/****** Object:  StoredProcedure [dbo].[prc_AddJudgmentColumn]    Script Date: 9/2/2021 1:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- ============================================= prc_AddJudgmentColumn 5
CREATE PROCEDURE [dbo].[prc_AddJudgmentColumn]
	-- Add the parameters for the stored procedure here
	@QuestionID as varchar(200)

AS
BEGIN
	IF COL_LENGTH('dbo.Judgement', 'Q'+@QuestionID) IS  NULL
BEGIN
   declare @str as nvarchar(max)='ALTER TABLE [dbo].[Judgement] ADD [Q'+@QuestionID+'] varchar(500)'
  exec sp_executesql @str
  set  @str ='ALTER TABLE [dbo].[Judgement] ADD [P'+@QuestionID+'] varchar(500)'
    exec sp_executesql @str
	set  @str ='ALTER TABLE [dbo].[Judgement] ADD [T'+@QuestionID+'] int'
    exec sp_executesql @str
		set  @str ='ALTER TABLE [dbo].[Judgement] ADD [R'+@QuestionID+'] bit'
		exec sp_executesql @str
END
END
GO
/****** Object:  StoredProcedure [dbo].[prc_AddQuestion]    Script Date: 9/2/2021 1:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- ============================================= prc_AddQuestion 'abc',1  prc_AddJudgmentColumn 10014
CREATE PROCEDURE [dbo].[prc_AddQuestion]
	-- Add the parameters for the stored procedure here
	@Title as nvarchar(2000),
	@type as int,
	@FKCompany as bigint,
	@ProblemName as nvarchar(2000)
AS
BEGIN
if @Title is null or len(@title)<1
begin
set @Title=(select top 1 title from Questions where [Type]=@type)
end
	Insert into Questions(title,type,FKCompany,ProblemName) values(@Title,@type,@FKCompany,@ProblemName)
	declare @id as int=(select @@IDENTITY)
	INSERT INTO [dbo].[CreateProblem]
           ([QuestionNo]
           ,[P1]
           ,[P2]
           ,[P3]
           ,[P4]
		   ,FKCompany,ProblemName
		   )
   Select top 1 @id
           ,[P1]
           ,[P2]
           ,[P3]
           ,[P4],@FKCompany,@ProblemName from Questions as Q 
		   Left join  [dbo].[CreateProblem] C on C.QuestionNo=Q.PKQuestion and C.FKCompany=@FKCompany
		   where Q.[Type]=@type
	print cast(@id as varchar(50))
	exec prc_AddJudgmentColumn @id
END
GO
/****** Object:  StoredProcedure [dbo].[prc_GetCompany]    Script Date: 9/2/2021 1:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_GetCompany]
	@id as bigint
AS
BEGIN
declare @ProblemName as varchar(500)='';
Select @ProblemName=ProblemName from CreateProblem where FKCompany=@id 
Select *,@ProblemName as ProblemName from Company where IsActive=1 and PKCompany=@id
END
GO
/****** Object:  StoredProcedure [dbo].[prc_GetProblem]    Script Date: 9/2/2021 1:16:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prc_GetProblem]
	-- Add the parameters for the stored procedure here
	@FKCompany as bigint,
	@ProblemName as varchar(500)='-1'
AS
BEGIN

Declare @table as table(id int)

Insert into @table(id)
select 1
union
select 2
union
Select 3
union
Select 4
union
Select 5
if (len(ltrim(rtrim(@ProblemName)))<1 or @ProblemName='')
	begin
	set @ProblemName=null;
	Select @ProblemName=ProblemName from CreateProblem where FKCompany=@FKCompany and IsExpired<>'1'
	end

Select Id  into #temp from @table where  ID not in (Select QuestionNo from CreateProblemArchive as c where C.FKCompany=@FKCompany and C.ProblemName=@ProblemName )

	
	
	Select Q.Title,Q.[Type],ROW_NUMBER() OVER(ORDER BY [Type]) as Row_Num,C.ProblemName,  PKQuestion as ID
	,C.P1,C.P2,C.P3,C.P4,isnull(IsPublish,'0')as IsPublish,isnull(C.IsExpired,'0') as IsExpired
	from Questions as Q
	left Join CreateProblem as C on C.QuestionNo=Q.PKQuestion and C.FKCompany=@FKCompany and (@ProblemName is null or C.ProblemName=@ProblemName) 
	Where (C.FKCompany=@FKCompany or Q.PKQuestion in (Select ID from #temp)) and (C.IsExpired is null or C.IsExpired<>'1')
	
	Order By [Type],Row_Num

	Drop table #temp
END
GO
USE [master]
GO
ALTER DATABASE [JudgementAppNew] SET  READ_WRITE 
GO
