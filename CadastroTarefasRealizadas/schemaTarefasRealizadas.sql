USE [master]
GO
/****** Object:  Database [TarefasRealizadas]    Script Date: 09/07/2018 22:23:32 ******/
CREATE DATABASE [TarefasRealizadas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TarefasRealizadas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\TarefasRealizadas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TarefasRealizadas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\TarefasRealizadas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TarefasRealizadas] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TarefasRealizadas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TarefasRealizadas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET ARITHABORT OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TarefasRealizadas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TarefasRealizadas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TarefasRealizadas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TarefasRealizadas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TarefasRealizadas] SET  MULTI_USER 
GO
ALTER DATABASE [TarefasRealizadas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TarefasRealizadas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TarefasRealizadas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TarefasRealizadas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TarefasRealizadas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TarefasRealizadas] SET QUERY_STORE = OFF
GO
USE [TarefasRealizadas]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [TarefasRealizadas]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 09/07/2018 22:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[id_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[categoria] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarefa]    Script Date: 09/07/2018 22:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarefa](
	[id_Tarefa] [int] IDENTITY(1,1) NOT NULL,
	[categoria_tarefa] [varchar](100) NOT NULL,
	[descricao_tarefa] [varchar](500) NOT NULL,
	[foto] [image] NULL,
	[data_cadastro] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[ApagarRegistro]    Script Date: 09/07/2018 22:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ApagarRegistro]
	@id int
AS
BEGIN
	DELETE FROM Tarefa
	WHERE id_Tarefa = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[GravarTarefaRealizada]    Script Date: 09/07/2018 22:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GravarTarefaRealizada] 
-- Add the parameters for the stored procedure here
	@categoria varchar(100),
	@descricao varchar(500),
	@foto image = null,
	@data_cadastro datetime
AS
BEGIN
	INSERT INTO Tarefa(categoria_tarefa, descricao_tarefa, foto, data_cadastro)
	VALUES(@categoria, @descricao, @foto, @data_cadastro);
END

GO
/****** Object:  StoredProcedure [dbo].[LerCategorias]    Script Date: 09/07/2018 22:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author: Fabio Pereira
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[LerCategorias]
AS
BEGIN
	SELECT categoria FROM Categoria;
END
GO
/****** Object:  StoredProcedure [dbo].[LerFoto]    Script Date: 09/07/2018 22:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LerFoto] 
	@id int
AS
BEGIN
	SELECT foto
	FROM Tarefa
	WHERE id_Tarefa = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[LerTarefasRealizadas]    Script Date: 09/07/2018 22:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LerTarefasRealizadas] 
AS
BEGIN
	SELECT id_Tarefa, categoria_tarefa, descricao_tarefa, data_cadastro
	FROM Tarefa;
END
GO
USE [master]
GO
ALTER DATABASE [TarefasRealizadas] SET  READ_WRITE 
GO
