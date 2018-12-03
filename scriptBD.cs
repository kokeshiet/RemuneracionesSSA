﻿USE [master]
GO
/****** Object:  Database [PRUEBA]    Script Date: 12/03/2018 00:27:02 ******/
CREATE DATABASE[PRUEBA] ON PRIMARY
(NAME = N'PRUEBA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\PRUEBA.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON
(NAME = N'PRUEBA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\PRUEBA_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10 %)
GO
ALTER DATABASE[PRUEBA] SET COMPATIBILITY_LEVEL = 100
GO
IF(1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC[PRUEBA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE[PRUEBA] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE[PRUEBA] SET ANSI_NULLS OFF
GO
ALTER DATABASE[PRUEBA] SET ANSI_PADDING OFF
GO
ALTER DATABASE[PRUEBA] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE[PRUEBA] SET ARITHABORT OFF
GO
ALTER DATABASE[PRUEBA] SET AUTO_CLOSE OFF
GO
ALTER DATABASE[PRUEBA] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE[PRUEBA] SET AUTO_SHRINK OFF
GO
ALTER DATABASE[PRUEBA] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE[PRUEBA] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE[PRUEBA] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE[PRUEBA] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE[PRUEBA] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE[PRUEBA] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE[PRUEBA] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE[PRUEBA] SET ENABLE_BROKER
GO
ALTER DATABASE[PRUEBA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE[PRUEBA] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE[PRUEBA] SET TRUSTWORTHY OFF
GO
ALTER DATABASE[PRUEBA] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE[PRUEBA] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE[PRUEBA] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE[PRUEBA] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE[PRUEBA] SET  READ_WRITE
GO
ALTER DATABASE[PRUEBA] SET RECOVERY FULL
GO
ALTER DATABASE[PRUEBA] SET MULTI_USER
GO
ALTER DATABASE[PRUEBA] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE[PRUEBA] SET DB_CHAINING OFF
GO
USE[PRUEBA]
GO
/****** Object:  Table [dbo].[obraasignada]    Script Date: 12/03/2018 00:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE[dbo].[obraasignada]
(

   [id][int] IDENTITY(1,1) NOT NULL,

  [idtrabajador] [int]
NOT NULL,

  [idobra] [int]
NOT NULL,

  [fechainicio] [datetime]
NOT NULL,

  [valordia] [int]
NOT NULL,

  [fechafin] [datetime] NULL
) ON[PRIMARY]
GO
/****** Object:  Table [dbo].[obra]    Script Date: 12/03/2018 00:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE[dbo].[obra]
(

   [id_obra][int] IDENTITY(1,1) NOT NULL,

  [nombre] [varchar] (50) NOT NULL,

   [detalle] [varchar] (50) NOT NULL,
 CONSTRAINT[PK_obra] PRIMARY KEY CLUSTERED
(
   [id_obra] ASC
)WITH(PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON[PRIMARY]
) ON[PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 12/03/2018 00:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE[dbo].[usuario]
(

   [id_usuario][int] IDENTITY(1,1) NOT NULL,

  [login] [varchar] (50) NOT NULL,

   [password] [varchar] (100) NOT NULL,

    [nombre] [varchar] (50) NOT NULL,
 
     [apellido] [varchar] (50) NOT NULL,
  
      [id_rol] [int]
NOT NULL,
  
      [estado] [bit]
NOT NULL,
   CONSTRAINT[PK_usuario] PRIMARY KEY CLUSTERED
 (
     [id_usuario] ASC
 )WITH(PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON[PRIMARY]
) ON[PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[trabajador]    Script Date: 12/03/2018 00:27:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE[dbo].[trabajador]
(

   [id_trabajador][int] IDENTITY(1,1) NOT NULL,

  [nombre] [varchar] (50) NOT NULL,

   [apaterno] [nchar] (10) NOT NULL,

    [amaterno] [varchar] (50) NOT NULL,
 
     [rut] [int]
NOT NULL,
 
     [dv] [varchar] (1) NOT NULL,
   CONSTRAINT[PK_trabajador] PRIMARY KEY CLUSTERED
 (
     [id_trabajador] ASC
 )WITH(PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON[PRIMARY]
) ON[PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SVC_UPD_ACTUALIZAR_OBRA_ASIGNADA]    Script Date: 12/03/2018 00:27:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SVC_UPD_ACTUALIZAR_OBRA_ASIGNADA]
(@ID INT,
@FECHAFIN DATE)
AS

    BEGIN
        UPDATE OBRAASIGNADA SET FECHAFIN = @FECHAFIN
        WHERE ID = @ID
    END
GO
/****** Object:  StoredProcedure [dbo].[SVC_UPD_ACTUALIZAR_OBRA]    Script Date: 12/03/2018 00:27:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SVC_UPD_ACTUALIZAR_OBRA]
--EXEC SVC_UPD_ACTUALIZAR_EMPLEADO 1,'JUAN','PEREZ','PEREZ',12345678,'K','23/10/2013'
(@ID_OBRA INT,
@NOMBRE VARCHAR(50),
@DETALLE VARCHAR(50))

AS
    BEGIN

        UPDATE obra SET NOMBRE = @NOMBRE,
                            DETALLE = @DETALLE


        WHERE id_obra = @ID_OBRA

    END
GO
/****** Object:  StoredProcedure [dbo].[SVC_UPD_ACTUALIZAR_EMPLEADO]    Script Date: 12/03/2018 00:27:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SVC_UPD_ACTUALIZAR_EMPLEADO]
--EXEC SVC_UPD_ACTUALIZAR_EMPLEADO 1,'JUAN','PEREZ','PEREZ',12345678,'K','23/10/2013'
(@ID_TRABAJADOR INT,
@NOMBRE VARCHAR(50),
@APATERNO VARCHAR(50),
@AMATERNO VARCHAR(50),
@RUT INT,
@DV VARCHAR(1))

AS
    BEGIN

        UPDATE trabajador SET NOMBRE = @NOMBRE,
                            APATERNO = @APATERNO,
                            AMATERNO = @AMATERNO,
                            RUT = @RUT,
                            DV = @DV


        WHERE id_trabajador = @ID_TRABAJADOR

    END
GO
/****** Object:  StoredProcedure [dbo].[SVC_QRY_CONSULTALOGIN]    Script Date: 12/03/2018 00:27:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SVC_QRY_CONSULTALOGIN]
(@login VARCHAR(50),
@password VARCHAR(50))
AS
    BEGIN

        SELECT u.nombre, u.apellido, u.id_usuario
        FROM usuario u

        WHERE u.login = @login and u.password = @password;
END
GO
/****** Object:  StoredProcedure [dbo].[SVC_INS_INSERTAR_OBRA]    Script Date: 12/03/2018 00:27:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SVC_INS_INSERTAR_OBRA]
--EXEC SVC_INS_INSERTAR_EMPLEADO 'JUAN','PEREZ','PEREZ',12345678,'K','23/10/2013'
(@NOMBRE VARCHAR(50),
@DETALLE VARCHAR(50)
)
AS
    BEGIN

        INSERT INTO obra(NOMBRE, DETALLE)

        VALUES(@NOMBRE, @DETALLE)

    END
GO
/****** Object:  StoredProcedure [dbo].[SVC_INS_INSERTAR_EMPLEADO]    Script Date: 12/03/2018 00:27:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SVC_INS_INSERTAR_EMPLEADO]
--EXEC SVC_INS_INSERTAR_EMPLEADO 'JUAN','PEREZ','PEREZ',12345678,'K','23/10/2013'
(@NOMBRE VARCHAR(50),
@APATERNO VARCHAR(50),
@AMATERNO VARCHAR(50),
@RUT INT,
@DV VARCHAR(1))

AS
    BEGIN

        INSERT INTO trabajador(NOMBRE, APATERNO, AMATERNO, RUT, DV)

        VALUES(@NOMBRE, @APATERNO, @AMATERNO, @RUT, @DV)

    END
GO
/****** Object:  StoredProcedure [dbo].[SVC_INS_ELIMINAR_OBRA]    Script Date: 12/03/2018 00:27:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SVC_INS_ELIMINAR_OBRA]
--EXEC SVC_INS_ELIMINAR_EMPLEADO 1
(@ID_OBRA INT)
AS

    BEGIN
        DELETE FROM obra

        WHERE id_obra = @ID_OBRA

    END
GO
/****** Object:  StoredProcedure [dbo].[SVC_INS_ELIMINAR_EMPLEADO]    Script Date: 12/03/2018 00:27:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SVC_INS_ELIMINAR_EMPLEADO]
--EXEC SVC_INS_ELIMINAR_EMPLEADO 1
(@ID_TRABAJADOR INT)
AS

    BEGIN
        DELETE FROM trabajador

        WHERE id_trabajador = @ID_TRABAJADOR

    END
GO
/****** Object:  StoredProcedure [dbo].[SVC_INS_ASIGNAROBRA]    Script Date: 12/03/2018 00:27:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SVC_INS_ASIGNAROBRA]
(@RUT INT,
@IDOBRA INT,
@FECHAINICIO DATE,
@VALORDIA INT)
AS

    BEGIN
        DECLARE @IDTRABAJADOR INT

        SET @IDTRABAJADOR = (SELECT ID_TRABAJADOR FROM TRABAJADOR WHERE RUT = @RUT)
		
		INSERT INTO OBRAASIGNADA(IDTRABAJADOR, IDOBRA, FECHAINICIO, VALORDIA)

        VALUES(@IDTRABAJADOR, @IDOBRA, @FECHAINICIO, @VALORDIA)

    END
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTAR_POR_RUT]    Script Date: 12/03/2018 00:27:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_LISTAR_POR_RUT]
--EXEC SVC_QRY_LISTAR_EMPLEADOS_POR_ID 1
(@RUT INT)
AS

    BEGIN
        SELECT NOMBRE, APATERNO,AMATERNO
        FROM TRABAJADOR
        WHERE RUT = @RUT;
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTAR_OBRAS_ASIGNADAS]    Script Date: 12/03/2018 00:27:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_LISTAR_OBRAS_ASIGNADAS]
(@RUT INT)
AS

    BEGIN
        DECLARE @ID INT

        SET @ID = (SELECT ID_TRABAJADOR FROM TRABAJADOR WHERE RUT = @RUT)
		
		SELECT OA.ID, TR.ID_TRABAJADOR, TR.NOMBRE, TR.APATERNO, TR.AMATERNO, OB.ID_OBRA, OB.NOMBRE, OA.FECHAINICIO, OA.VALORDIA
        FROM OBRAASIGNADA OA

        INNER JOIN TRABAJADOR TR ON OA.IDTRABAJADOR = TR.ID_TRABAJADOR

        INNER JOIN OBRA OB ON OA.IDOBRA = OB.ID_OBRA

        WHERE OA.IDTRABAJADOR = @ID

    END
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTAR_OBRA]    Script Date: 12/03/2018 00:27:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_LISTAR_OBRA]
as
select* from obra

exec sp_listar_obra
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTAR]    Script Date: 12/03/2018 00:27:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_LISTAR]
as
select* from TRABAJADOR

exec sp_listar
GO