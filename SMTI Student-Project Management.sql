USE [master]
GO
/****** Object:  Database [SMTIStudentProjectDB]    Script Date: 2022-10-17 11:24:05 PM ******/
CREATE DATABASE [SMTIStudentProjectDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SMTIStudentProjectDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\SMTIStudentProjectDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SMTIStudentProjectDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\SMTIStudentProjectDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SMTIStudentProjectDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SMTIStudentProjectDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SMTIStudentProjectDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET  MULTI_USER 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SMTIStudentProjectDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SMTIStudentProjectDB] SET QUERY_STORE = OFF
GO
USE [SMTIStudentProjectDB]
GO
/****** Object:  Table [dbo].[ProjectAssignments]    Script Date: 2022-10-17 11:24:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectAssignments](
	[StudentId] [int] NOT NULL,
	[ProjectCode] [nvarchar](50) NOT NULL,
	[AssignmentDate] [date] NOT NULL,
	[SubmissionDate] [date] NULL,
 CONSTRAINT [PK_ProjectAssignments_1] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC,
	[ProjectCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 2022-10-17 11:24:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[ProjectCode] [nvarchar](50) NOT NULL,
	[ProjectTitle] [nvarchar](50) NOT NULL,
	[DueDate] [date] NOT NULL,
 CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED 
(
	[ProjectCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 2022-10-17 11:24:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentId] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 2022-10-17 11:24:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[TeacherId] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ProjectAssignments] ([StudentId], [ProjectCode], [AssignmentDate], [SubmissionDate]) VALUES (1, N'PRJ101', CAST(N'2022-10-17' AS Date), CAST(N'2022-10-17' AS Date))
INSERT [dbo].[ProjectAssignments] ([StudentId], [ProjectCode], [AssignmentDate], [SubmissionDate]) VALUES (1, N'PRJ102', CAST(N'2022-10-17' AS Date), CAST(N'2022-10-17' AS Date))
INSERT [dbo].[ProjectAssignments] ([StudentId], [ProjectCode], [AssignmentDate], [SubmissionDate]) VALUES (1, N'PRJ103', CAST(N'2022-10-17' AS Date), CAST(N'2022-10-17' AS Date))
INSERT [dbo].[ProjectAssignments] ([StudentId], [ProjectCode], [AssignmentDate], [SubmissionDate]) VALUES (2, N'PRJ101', CAST(N'2022-10-18' AS Date), CAST(N'2022-10-28' AS Date))
INSERT [dbo].[ProjectAssignments] ([StudentId], [ProjectCode], [AssignmentDate], [SubmissionDate]) VALUES (2, N'PRJ105', CAST(N'2022-10-01' AS Date), CAST(N'2022-11-01' AS Date))
GO
INSERT [dbo].[Projects] ([ProjectCode], [ProjectTitle], [DueDate]) VALUES (N'PRJ101', N'Order Management in C#', CAST(N'2022-12-09' AS Date))
INSERT [dbo].[Projects] ([ProjectCode], [ProjectTitle], [DueDate]) VALUES (N'PRJ102', N'Shopping Cart in PHP', CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Projects] ([ProjectCode], [ProjectTitle], [DueDate]) VALUES (N'PRJ103', N'Library System in Java', CAST(N'2022-12-15' AS Date))
INSERT [dbo].[Projects] ([ProjectCode], [ProjectTitle], [DueDate]) VALUES (N'PRJ104', N'ATM Design and Implementation in C#', CAST(N'2022-12-15' AS Date))
INSERT [dbo].[Projects] ([ProjectCode], [ProjectTitle], [DueDate]) VALUES (N'PRJ105', N'Employee Management', CAST(N'2022-12-20' AS Date))
GO
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Password]) VALUES (1, N'Truong', N'Pham', N'123')
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Password]) VALUES (2, N'Thien', N'Nguyen', N'123')
GO
INSERT [dbo].[Teachers] ([TeacherId], [FirstName], [LastName], [Password]) VALUES (11111, N'Houmel', N'Green', N'123')
INSERT [dbo].[Teachers] ([TeacherId], [FirstName], [LastName], [Password]) VALUES (22222, N'Abbot', N'Blue', N'123')
GO
ALTER TABLE [dbo].[ProjectAssignments]  WITH CHECK ADD  CONSTRAINT [FK_ProjectAssignments_Projects1] FOREIGN KEY([ProjectCode])
REFERENCES [dbo].[Projects] ([ProjectCode])
GO
ALTER TABLE [dbo].[ProjectAssignments] CHECK CONSTRAINT [FK_ProjectAssignments_Projects1]
GO
ALTER TABLE [dbo].[ProjectAssignments]  WITH CHECK ADD  CONSTRAINT [FK_ProjectAssignments_Students1] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([StudentId])
GO
ALTER TABLE [dbo].[ProjectAssignments] CHECK CONSTRAINT [FK_ProjectAssignments_Students1]
GO
USE [master]
GO
ALTER DATABASE [SMTIStudentProjectDB] SET  READ_WRITE 
GO
