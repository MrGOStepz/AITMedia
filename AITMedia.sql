/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2014 (12.0.2000)
    Source Database Engine Edition : Microsoft SQL Server Standard Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [DB_9AB8B7_5612]    Script Date: 26/10/2017 12:48:34 AM ******/
CREATE DATABASE [DB_9AB8B7_5612]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_9AB8B7_5612_Data', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DB_9AB8B7_5612_DATA.mdf' , SIZE = 4096KB , MAXSIZE = 51200KB , FILEGROWTH = 10%)
 LOG ON 
( NAME = N'DB_9AB8B7_5612_Log', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DB_9AB8B7_5612_Log.LDF' , SIZE = 3072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DB_9AB8B7_5612] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_9AB8B7_5612].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_9AB8B7_5612] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET  MULTI_USER 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_9AB8B7_5612] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DB_9AB8B7_5612] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DB_9AB8B7_5612]
GO
/****** Object:  Table [dbo].[TabBorrow]    Script Date: 26/10/2017 12:48:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TabBorrow](
	[BID] [int] IDENTITY(1,1) NOT NULL,
	[UID] [int] NOT NULL,
	[MediaID] [int] NOT NULL,
	[BorrowDate] [date] NOT NULL,
	[ReturnDate] [date] NOT NULL,
	[ActualReturnDate] [date] NOT NULL,
	[LateFee] [decimal](5, 2) NOT NULL,
	[MediaTitle] [varchar](100) NULL,
 CONSTRAINT [pk_TabBorrow] PRIMARY KEY CLUSTERED 
(
	[BID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TabDirector]    Script Date: 26/10/2017 12:48:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TabDirector](
	[DID] [int] IDENTITY(1,1) NOT NULL,
	[DirectorName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TabDirector] PRIMARY KEY CLUSTERED 
(
	[DID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TabGenre]    Script Date: 26/10/2017 12:48:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TabGenre](
	[GID] [int] IDENTITY(1,1) NOT NULL,
	[GenreName] [varchar](50) NOT NULL,
 CONSTRAINT [pk_TabGenre] PRIMARY KEY CLUSTERED 
(
	[GID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TabLanguage]    Script Date: 26/10/2017 12:48:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TabLanguage](
	[LID] [int] IDENTITY(1,1) NOT NULL,
	[LanguageName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TabLanguage] PRIMARY KEY CLUSTERED 
(
	[LID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TabMedia]    Script Date: 26/10/2017 12:48:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TabMedia](
	[MediaID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](100) NOT NULL,
	[Genre] [int] NOT NULL,
	[Director] [int] NOT NULL,
	[Language] [int] NOT NULL,
	[PublishYear] [int] NOT NULL,
	[Budget] [decimal](6, 2) NOT NULL,
 CONSTRAINT [pk_TabMedia] PRIMARY KEY CLUSTERED 
(
	[MediaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TabReserved]    Script Date: 26/10/2017 12:48:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TabReserved](
	[RID] [int] IDENTITY(1,1) NOT NULL,
	[UID] [int] NOT NULL,
	[MediaID] [int] NOT NULL,
	[ReservedDate] [date] NOT NULL,
 CONSTRAINT [pk_TabReserved] PRIMARY KEY CLUSTERED 
(
	[RID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TabUser]    Script Date: 26/10/2017 12:48:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TabUser](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](8) NOT NULL,
	[Password] [varchar](30) NOT NULL,
	[UserLevel] [int] NOT NULL,
	[UserEmail] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TabUser] PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewMedia]    Script Date: 26/10/2017 12:48:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewMedia] AS 
SELECT	TabMedia.MediaID, TabMedia.Title, TabGenre.GenreName, TabDirector.DirectorName, TabLanguage.LanguageName, TabMedia.PublishYear, TabMedia.Budget,
	TabMedia.Genre, TabMedia.Director, TabMedia.Language
FROM	TabDirector INNER JOIN
	TabMedia ON TabMedia.Director = TabDirector.DID INNER JOIN
	TabGenre ON TabMedia.Genre = TabGenre.GID INNER JOIN
	TabLanguage ON TabMedia.Language = TabLanguage.LID;
GO
/****** Object:  View [dbo].[ViewMediaAvailable]    Script Date: 26/10/2017 12:48:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewMediaAvailable] AS 
SELECT	TabMedia.MediaID, TabMedia.Title, TabGenre.GenreName, TabDirector.DirectorName, TabLanguage.LanguageName, TabMedia.PublishYear, TabMedia.Budget,
	TabMedia.Genre, TabMedia.Director, TabMedia.Language
FROM	TabDirector INNER JOIN
	TabMedia ON TabMedia.Director = TabDirector.DID INNER JOIN
	TabGenre ON TabMedia.Genre = TabGenre.GID INNER JOIN
	TabLanguage ON TabMedia.Language = TabLanguage.LID LEFT OUTER JOIN
	TabBorrow ON TabMedia.MediaID = TabBorrow.MediaID
GROUP BY TabMedia.MediaID, TabMedia.Title, TabGenre.GenreName, TabDirector.DirectorName, TabLanguage.LanguageName, TabMedia.PublishYear, TabMedia.Budget,
	TabMedia.Genre, TabMedia.Director, TabMedia.Language
HAVING	(MIN(TabBorrow.ActualReturnDate) > CONVERT(DATETIME, '2001-01-01 00:00:00', 102)) OR
	(MIN(TabBorrow.ActualReturnDate) IS NULL);
GO
/****** Object:  View [dbo].[ViewMediaBorrowed]    Script Date: 26/10/2017 12:48:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewMediaBorrowed] AS 
SELECT	TabMedia.MediaID, TabMedia.Title, TabGenre.GenreName, TabDirector.DirectorName, TabLanguage.LanguageName, TabMedia.PublishYear, TabMedia.Budget,
	TabMedia.Genre, TabMedia.Director, TabMedia.Language
FROM	TabDirector INNER JOIN
	TabMedia ON TabMedia.Director = TabDirector.DID INNER JOIN
	TabGenre ON TabMedia.Genre = TabGenre.GID INNER JOIN
	TabLanguage ON TabMedia.Language = TabLanguage.LID LEFT OUTER JOIN
	TabBorrow ON TabMedia.MediaID = TabBorrow.MediaID
GROUP BY TabMedia.MediaID, TabMedia.Title, TabGenre.GenreName, TabDirector.DirectorName, TabLanguage.LanguageName, TabMedia.PublishYear, TabMedia.Budget,
	TabMedia.Genre, TabMedia.Director, TabMedia.Language
HAVING	(MIN(dbo.TabBorrow.ActualReturnDate) <= CONVERT(DATETIME, '2001-01-01 00:00:00', 102));
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [index_username]    Script Date: 26/10/2017 12:48:40 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [index_username] ON [dbo].[TabUser]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TabBorrow] ADD  DEFAULT ('2000-01-01') FOR [ActualReturnDate]
GO
ALTER TABLE [dbo].[TabBorrow] ADD  DEFAULT ((0.00)) FOR [LateFee]
GO
ALTER TABLE [dbo].[TabBorrow]  WITH CHECK ADD  CONSTRAINT [fk_TabBorrow_TabMedia] FOREIGN KEY([MediaID])
REFERENCES [dbo].[TabMedia] ([MediaID])
GO
ALTER TABLE [dbo].[TabBorrow] CHECK CONSTRAINT [fk_TabBorrow_TabMedia]
GO
ALTER TABLE [dbo].[TabBorrow]  WITH CHECK ADD  CONSTRAINT [fk_TabBorrow_TabUser] FOREIGN KEY([UID])
REFERENCES [dbo].[TabUser] ([UID])
GO
ALTER TABLE [dbo].[TabBorrow] CHECK CONSTRAINT [fk_TabBorrow_TabUser]
GO
ALTER TABLE [dbo].[TabMedia]  WITH CHECK ADD  CONSTRAINT [fk_TabMedia_TabDirector] FOREIGN KEY([Director])
REFERENCES [dbo].[TabDirector] ([DID])
GO
ALTER TABLE [dbo].[TabMedia] CHECK CONSTRAINT [fk_TabMedia_TabDirector]
GO
ALTER TABLE [dbo].[TabMedia]  WITH CHECK ADD  CONSTRAINT [fk_TabMedia_TabGenre] FOREIGN KEY([Genre])
REFERENCES [dbo].[TabGenre] ([GID])
GO
ALTER TABLE [dbo].[TabMedia] CHECK CONSTRAINT [fk_TabMedia_TabGenre]
GO
ALTER TABLE [dbo].[TabMedia]  WITH CHECK ADD  CONSTRAINT [fk_TabMedia_TabLanguage] FOREIGN KEY([Language])
REFERENCES [dbo].[TabLanguage] ([LID])
GO
ALTER TABLE [dbo].[TabMedia] CHECK CONSTRAINT [fk_TabMedia_TabLanguage]
GO
ALTER TABLE [dbo].[TabReserved]  WITH CHECK ADD  CONSTRAINT [fk_TabReserved_TabMedia] FOREIGN KEY([MediaID])
REFERENCES [dbo].[TabMedia] ([MediaID])
GO
ALTER TABLE [dbo].[TabReserved] CHECK CONSTRAINT [fk_TabReserved_TabMedia]
GO
ALTER TABLE [dbo].[TabReserved]  WITH CHECK ADD  CONSTRAINT [fk_TabReserved_TabUser] FOREIGN KEY([UID])
REFERENCES [dbo].[TabUser] ([UID])
GO
ALTER TABLE [dbo].[TabReserved] CHECK CONSTRAINT [fk_TabReserved_TabUser]
GO
USE [master]
GO
ALTER DATABASE [DB_9AB8B7_5612] SET  READ_WRITE 
GO
