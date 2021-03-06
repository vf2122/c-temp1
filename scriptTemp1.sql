USE [master]
GO
/****** Object:  Database [Drausio]    Script Date: 08/03/2017 00:51:02 ******/
CREATE DATABASE [Drausio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Drausio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Drausio.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Drausio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Drausio_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Drausio] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Drausio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Drausio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Drausio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Drausio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Drausio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Drausio] SET ARITHABORT OFF 
GO
ALTER DATABASE [Drausio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Drausio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Drausio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Drausio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Drausio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Drausio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Drausio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Drausio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Drausio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Drausio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Drausio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Drausio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Drausio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Drausio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Drausio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Drausio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Drausio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Drausio] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Drausio] SET  MULTI_USER 
GO
ALTER DATABASE [Drausio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Drausio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Drausio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Drausio] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Drausio] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Drausio]
GO
/****** Object:  Table [dbo].[tblCliente]    Script Date: 08/03/2017 00:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[DataNascimento] [datetime] NOT NULL,
	[Sexo] [bit] NOT NULL,
	[LimiteCompra] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblCliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[uspClienteAlterar]    Script Date: 08/03/2017 00:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspClienteAlterar]
	
	@IdCliente INT,
	@Nome varchar(100),
	@DataNascimento datetime,
	@Sexo bit,
	@LimiteCompra decimal(18,2)

AS
BEGIN

	UPDATE 
		tblCliente
	SET
		Nome = @Nome,
		DataNascimento = @DataNascimento,
		Sexo = @Sexo,
		LimiteCompra = @LimiteCompra
	Where
		IdCliente = @IdCliente

	SELECT @idCliente AS Retorno

END
GO
/****** Object:  StoredProcedure [dbo].[uspClienteConsultarPorId]    Script Date: 08/03/2017 00:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspClienteConsultarPorId]
	@IdCliente INT

AS
BEGIN

	SELECT 
		IdCliente,
		Nome,
		DataNascimento,
		Sexo,
		LimiteCompra 

	FROM 
		tblCliente
	
	WHERE
		IdCliente = @IdCliente


END
GO
/****** Object:  StoredProcedure [dbo].[uspClienteConsultarPorNome]    Script Date: 08/03/2017 00:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspClienteConsultarPorNome]
	@Nome varchar(100)
	
AS
BEGIN

	SELECT 
		IdCliente,
		Nome,
		DataNascimento,
		Sexo,
		LimiteCompra 

	FROM 
		tblCliente
	
	WHERE
		Nome LIKE '%' + @Nome + '%'


END
GO
/****** Object:  StoredProcedure [dbo].[uspClienteExcluir]    Script Date: 08/03/2017 00:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspClienteExcluir]
	@IdCliente INT

AS
BEGIN
	
	DELETE FROM 
		tblCliente
	WHERE
		IdCliente = @IdCliente

	SELECT @IdCliente AS Retorno

END
GO
/****** Object:  StoredProcedure [dbo].[uspClienteInserir]    Script Date: 08/03/2017 00:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspClienteInserir]
	@Nome varchar(100),
	@DataNascimento datetime,
	@Sexo bit,
	@LimiteCompra decimal(18,2)
AS
BEGIN
	
	INSERT INTO tblCliente
	(
		Nome,
		DataNascimento,
		Sexo,
		LimiteCompra
	)
	VALUES
	(
		@Nome,
		@DataNascimento,
		@Sexo,
		@LimiteCompra
	)

	SELECT @@IDENTITY AS Retorno

END
GO
USE [master]
GO
ALTER DATABASE [Drausio] SET  READ_WRITE 
GO
