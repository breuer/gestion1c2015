use [GD1C2015]
GO

CREATE SCHEMA NEW_SOLUTION
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--CREAR TABLAS FISICAS
create table [NEW_SOLUTION].Login
(
	idlogin		bigint identity(1,1),
	idusuario	int,
	feclogin	datetime,
	resultado	varchar(1)
)

create table [NEW_SOLUTION].Login_incorrecto
(
	idfalla		bigint identity(1,1),
	idusuario	int,
	intento		int  DEFAULT 0
)

create table [NEW_SOLUTION].Usuario
(
	idusuario		int identity(1,1),
	usuario			varchar(50),
	password		varchar(255),
	fechaCreacion	datetime,
	fechaUltModif   datetime,
	pregSecreta		varchar(200),
	respSecreta		varchar(100),
	estado			varchar(1) DEFAULT 'S',
	idcliente		bigint
)

create table [NEW_SOLUTION].Usuario_rol
(
	idusuario		int,
	idrol			int
)

create table [NEW_SOLUTION].Roles
(
	idrol  int identity(1,1),
	nombre  varchar(100),
	estado	varchar(1) DEFAULT 'S'
)

create table [NEW_SOLUTION].Rol_funcionalidad
(
	idrol		    int,
	idfuncionalidad int
)

create table [NEW_SOLUTION].Funcionalidades
(
	idfuncionalidad int,
	nombre			varchar(200)
)
GO

-----------------------------------------------------


create table NEW_SOLUTION.Clientes
(
       cli_id                                bigint,
       cli_nombre                        varchar(255),
       cli_apellido                varchar(255),
       cli_tdoc                        numeric(18,0),
       cli_ndoc                        numeric(18,0),
       cli_pdoc                        numeric(18,0),
       cli_mail                        varchar(255) unique,
       cli_calle                        varchar(255),
       cli_numero                        varchar(50),
       cli_piso                        numeric(18,0),
       cli_depto                        varchar(10),
       cli_localidad                varchar(100),
       cli_nacionalidad        numeric(18,0),
       cli_fecnac                        datetime,
       cli_estado                        varchar(1),
       cli_inconsistencia  int,
       primary key(cli_id)
);


-- VISTAS
CREATE VIEW NEW_SOLUTION.V_USUARIOS_ACTIVOS
AS
	SELECT
		U.idusuario,
		U.password,
		U.usuario,
		U.fechaCreacion,
		U.fechaUltModif,
		U.pregSecreta,
		U.respSecreta
	FROM
		NEW_SOLUTION.USUARIO U
	WHERE 
		U.estado <> 'N'			
GO

CREATE VIEW NEW_SOLUTION.V_USUARIOS_INACTIVOS
AS
	SELECT
		U.idusuario,
		U.password,
		U.usuario,
		U.fechaCreacion,
		U.fechaUltModif,
		U.pregSecreta,
		U.respSecreta
	FROM
		NEW_SOLUTION.USUARIO U
	WHERE 
		U.estado <> 'S'			
GO


-- FUNCIONALIDADES
GO
INSERT INTO 
	NEW_SOLUTION.Funcionalidades (idfuncionalidad, nombre)
VALUES 
	(1, 'abm rol'), --administrador
	(2, 'abm usuario'),--administrador	
	(3, 'abm cliente'), --	
	(4, 'abm cuenta') --administrador
--	(, 'listados estadísticos') --administrador
GO



-- ROLES

DECLARE @ID_ROL INT;

exec NEW_SOLUTION.SP_ROL_ADD @nombre = 'administrador'; 
set @ID_ROL = ( select NEW_SOLUTION.F_ROL_GET_ID ('administrador') );
exec NEW_SOLUTION.SP_ROL_ADD_FUNCIONALIDAD @idrol=  @ID_ROL , @idfuncionalidad = 1;
exec NEW_SOLUTION.SP_ROL_ADD_FUNCIONALIDAD @idrol=  @ID_ROL, @idfuncionalidad = 2;
exec NEW_SOLUTION.SP_ROL_ADD_FUNCIONALIDAD @idrol=  @ID_ROL, @idfuncionalidad = 3;
exec NEW_SOLUTION.SP_ROL_ADD_FUNCIONALIDAD @idrol=  @ID_ROL, @idfuncionalidad = 4;

exec NEW_SOLUTION.SP_ROL_ADD @nombre = 'cliente'; 
set @ID_ROL = ( select NEW_SOLUTION.F_ROL_GET_ID ('cliente') );
exec NEW_SOLUTION.SP_ROL_ADD_FUNCIONALIDAD @idrol=  @ID_ROL, @idfuncionalidad = 4;
	

-- USUARIOS
DECLARE @ID_ROL INT;
DECLARE @ID_USUARIO INT;

exec NEW_SOLUTION.SP_USUARIO_ADD 
	@username = 'admin', 
	@password = '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918',
	@fecha_creacion = '2015-01-01'
SET @ID_USUARIO = ( SELECT NEW_SOLUTION.F_USUARIO_GET_ID ('admin') );

SET @ID_ROL = ( select NEW_SOLUTION.F_ROL_GET_ID ('administrador') );
exec NEW_SOLUTION.SP_USUARIO_ADD_ROL @id_usuario = @ID_USUARIO, @id_rol = @ID_ROL 

SET @ID_ROL = ( select NEW_SOLUTION.F_ROL_GET_ID ('cliente') );
exec NEW_SOLUTION.SP_USUARIO_ADD_ROL @id_usuario = @ID_USUARIO, @id_rol = @ID_ROL 