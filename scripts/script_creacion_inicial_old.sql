use [GD2C2014]
GO

CREATE SCHEMA HEMINGWAY
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/*************************************************************************************
*                    TABLES                                                          *
**************************************************************************************/
create table [HEMINGWAY].[USUARIO]
(
	codigo INT identity(1,1) not null,
	username VARCHAR (255) not null,
	password VARCHAR (255) not null,
	apellido VARCHAR (255) not null,
	nombre VARCHAR (255) not null,
	identificacion INT,
	codigo_tipo_identificacion INT,
	direccion VARCHAR (255),
	telefono VARCHAR (255),
	mail VARCHAR (255),
	codigo_pais VARCHAR (255),
	fecha_nac date,
	habilitado CHAR DEFAULT 'S'
)
GO

create table [HEMINGWAY].[INTENTO_FALLIDO]
(
	codigo_usuario INT NOT NULL
)
GO


create table [HEMINGWAY].[USUARIO_HOTEL]
(
	codigo_usuario INT NOT NULL,
	codigo_hotel INT NOT NULL
)
GO


create table [HEMINGWAY].[ROL]
(
	codigo INT identity(1,1) not null,
	descripcion VARCHAR (255) not null,
	habilitado CHAR DEFAULT 'S'
)
GO

create table [HEMINGWAY].[USUARIO_ROL]
(
	codigo_usuario INT NOT NULL,
	codigo_rol INT NOT NULL
)
GO

create table [HEMINGWAY].[FUNCIONALIDAD]
(
	codigo VARCHAR (255) not null,
	descripcion VARCHAR (255) not null
)
GO

create table [HEMINGWAY].[ROL_FUNCIONALIDAD]
(
	codigo_rol INT not null,
	codigo_funcionalidad VARCHAR (255) not null
)
GO

CREATE TABLE [HEMINGWAY].[HOTEL]
(
	codigo INT identity(1,1) not null,
	nombre VARCHAR (255),
	mail VARCHAR (255),
	telefono VARCHAR (255),
	calle VARCHAR (255) ,
	numero_calle INT ,
	cantidad_estrellas INT ,
	recarga_estrella INT ,
	ciudad VARCHAR (255) ,
	pais VARCHAR (255),
	fecha_creacion date,
	habilitado [CHAR] DEFAULT 'S'
)
GO

CREATE TABLE [HEMINGWAY].[HOTEL_CERRADO]
(
	codigo_hotel INT not null,
	fecha_inicio date not null,
	fecha_fin date not null,
	motivo VARCHAR (255) not null,
)
GO

create table [HEMINGWAY].[REGIMEN]
(
	codigo INT identity(1,1) not null,
	descripcion VARCHAR (255) not null,
	precio  DECIMAL (18,2) not null
)
GO

CREATE TABLE [HEMINGWAY].[HOTEL_REGIMEN]
(
	codigo_hotel INT not null,
	codigo_regimen INT not null
)
GO

create table [HEMINGWAY].[HABITACION]
(
	codigo INT identity(1,1) not null,
	codigo_hotel INT not null,
	codigo_tipo_habitacion INT not null,
	numero INT not null,
	piso INT not null,
	frente CHAR not null,
	habilitado CHAR DEFAULT 'S'
)
GO

create table [HEMINGWAY].[TIPO_HABITACION]
(
	codigo INT not null,
	descripcion VARCHAR (255) not null,
	porcentual DECIMAL (18,2) not null	
)
GO

create table [HEMINGWAY].[CLIENTE]
(
	codigo INT identity(1,1) not null,
	apellido VARCHAR (255) not null,
	nombre VARCHAR (255) not null,
	identificacion INT ,
	codigo_tipo_identificacion VARCHAR (255),
	telefono VARCHAR (255),
	mail VARCHAR (255) NOT NULL, 
	codigo_nacionalidad VARCHAR (255) ,
	fecha_nac date,
	calle VARCHAR (255),
	numero_calle INT,
	piso INT,
	departamento VARCHAR (50),
	ciudad VARCHAR (255),
	habilitado CHAR DEFAULT 'S'
)
GO

create table [HEMINGWAY].[TIPO_IDENTIFICACION]
(
	codigo VARCHAR (255) not null,
	descripcion VARCHAR (255) not null
)
GO

create table [HEMINGWAY].[RESERVA]
(
	codigo INT not null,
	codigo_hotel INT,
	fecha_reserva date,
	fecha_inicio DATETIME,
	fecha_fin DATETIME,
	--cantidad_noches INT,
	codigo_regimen INT,
	codigo_cliente INT,
	codigo_estado VARCHAR (50)
)
GO

create table [HEMINGWAY].[RESERVA_ESTADO]
(
	codigo VARCHAR (50) not null,
	descripcion VARCHAR (255) not null
)
GO

create table [HEMINGWAY].[HABITACION_RESERVA]
(
	codigo_habitacion INT,
	codigo_reserva INT 
)
GO

create table [HEMINGWAY].[OPERACIONES_SOBRE_RESERVA]
(
	codigo_reserva INT,
	codigo_usuario INT,
	codigo_estado VARCHAR (50),
	fecha date
)
GO

create table [HEMINGWAY].[ESTADIA]
(
	codigo_reserva INT not null,
	fecha_inicio DATETIME,
	fecha_fin DATETIME,
	cantidad_noches INT
)
GO

create table [HEMINGWAY].[CLIENTE_ESTADIA]
(
	codigo_cliente INT not null,
	codigo_reserva INT not null
)
GO

create table [HEMINGWAY].[CONSUMIBLE]
(
	codigo INT not null,
	descripcion VARCHAR (255) not null,
	precio numeric(18,2) not null
)
GO

create table [HEMINGWAY].[ESTADIA_CONSUMIBLE]
(
	codigo_reserva INT not null,
	codigo_consumible INT not null,
	cantidad INT,
	habitacion INT
)
GO


create table [HEMINGWAY].[FACTURA]
(
	numero INT not null,
	codigo_reserva INT not null,
	fecha DATETIME not null,
	total_consumible DECIMAL (18,2),
	total_estadia DECIMAL (18,2),
	total_descuento DECIMAL (18,2)
)
GO

create table [HEMINGWAY].[ITEM_CONSUMIBLE]
(
	numero_factura INT not null,
	codigo_consumible INT,
	cantidad INT not null,
	monto DECIMAL (18,2) not null
)
GO

create table [HEMINGWAY].[ITEM_ESTADIA]
(
	numero_factura INT not null,
	usado CHAR not null,
	cantidad INT not null,
	monto DECIMAL (18,2) not null	
)
GO


CREATE TABLE [HEMINGWAY].[PAGO_FACTURA]
(
	numero_factura INT not null,
	codigo_forma_pago VARCHAR (50) not null
)
GO

CREATE TABLE [HEMINGWAY].[FORMA_DE_PAGO]
(
	codigo VARCHAR (50) not null,
	descripcion VARCHAR(255) not null
)
GO

CREATE TABLE [HEMINGWAY].[TARJETA_CREDITO_DATOS]
(
	numero_factura INT not null,
	numero_tarjeta BIGINT not null,
	fecha_caducidad DATE not null
)
GO

create table [HEMINGWAY].[PAISES_NACIONALIDADES]
(
	pais VARCHAR (255) not null, 
	nacionalidad VARCHAR(255) not null
)
GO

CREATE TABLE [HEMINGWAY].[MAIL_DUPLICADOS]
(
	mail varchar(255) not null
)
GO



/*************************************************************************************
*                    INDICES                                                         *
**************************************************************************************/
--ALTER TABLE HEMINGWAY.HOTEL ADD CONSTRAINT pk_hotel_cod PRIMARY KEY(codigo);
go
ALTER TABLE HEMINGWAY.RESERVA ADD CONSTRAINT pk_reserva_cod PRIMARY KEY(codigo);
go
ALTER TABLE HEMINGWAY.HABITACION ADD CONSTRAINT pk_habitacion_cod PRIMARY KEY(codigo);
go
ALTER TABLE HEMINGWAY.CLIENTE ADD CONSTRAINT pk_cliente_cod PRIMARY KEY(codigo);
go
ALTER TABLE HEMINGWAY.ESTADIA ADD CONSTRAINT pk_estadia_cod PRIMARY KEY(codigo_reserva);
go
ALTER TABLE HEMINGWAY.FACTURA ADD CONSTRAINT pk_factura_nro PRIMARY KEY(numero);
go


ALTER TABLE HEMINGWAY.ESTADIA ADD CONSTRAINT fk_estadia_cod_reserva FOREIGN KEY(codigo_reserva) REFERENCES HEMINGWAY.RESERVA(codigo);
go
ALTER TABLE HEMINGWAY.HABITACION_RESERVA ADD CONSTRAINT fk_habitacion_reserva_cod_reserva FOREIGN KEY(codigo_reserva) REFERENCES HEMINGWAY.RESERVA(codigo);
GO
ALTER TABLE HEMINGWAY.HABITACION_RESERVA ADD CONSTRAINT fk_habitacion_reserva_cod_habitacion FOREIGN KEY(codigo_habitacion) REFERENCES HEMINGWAY.HABITACION(codigo);
GO
ALTER TABLE HEMINGWAY.RESERVA ADD CONSTRAINT fk_reserva_cod_cliente FOREIGN KEY(codigo_cliente) REFERENCES HEMINGWAY.CLIENTE(codigo);
GO
ALTER TABLE HEMINGWAY.CLIENTE_ESTADIA ADD CONSTRAINT fk_cliente_estadia_cod_cliente FOREIGN KEY(codigo_cliente) REFERENCES HEMINGWAY.CLIENTE(codigo);
GO
ALTER TABLE HEMINGWAY.CLIENTE_ESTADIA ADD CONSTRAINT fk_cliente_estadia_cod_estadia FOREIGN KEY(codigo_reserva) REFERENCES HEMINGWAY.ESTADIA(codigo_reserva);
GO
ALTER TABLE HEMINGWAY.ESTADIA_CONSUMIBLE ADD CONSTRAINT fk_estadia_consumible_cod_estadia FOREIGN KEY(codigo_reserva) REFERENCES HEMINGWAY.ESTADIA(codigo_reserva);
GO
ALTER TABLE HEMINGWAY.FACTURA ADD CONSTRAINT fk_factura_cod_estadia FOREIGN KEY(codigo_reserva) REFERENCES HEMINGWAY.ESTADIA(codigo_reserva);
GO
ALTER TABLE HEMINGWAY.ITEM_CONSUMIBLE ADD CONSTRAINT fk_item_consumible_nro_factura FOREIGN KEY(numero_factura) REFERENCES HEMINGWAY.FACTURA(numero);
GO
ALTER TABLE HEMINGWAY.ITEM_ESTADIA ADD CONSTRAINT fk_item_estadia_nro_factura FOREIGN KEY(numero_factura) REFERENCES HEMINGWAY.FACTURA(numero);
GO
ALTER TABLE HEMINGWAY.OPERACIONES_SOBRE_RESERVA ADD CONSTRAINT fk_operaciones_sobre_reserva_cod_reserva FOREIGN KEY(codigo_reserva) REFERENCES HEMINGWAY.RESERVA(codigo);
GO
ALTER TABLE HEMINGWAY.ESTADIA_CONSUMIBLE ADD CONSTRAINT fk_estadia_consumible_cod_reserva FOREIGN KEY(codigo_reserva) REFERENCES HEMINGWAY.ESTADIA(codigo_reserva);
GO
ALTER TABLE HEMINGWAY.FACTURA ADD CONSTRAINT fk_factura_cod_reserva FOREIGN KEY(codigo_reserva) REFERENCES HEMINGWAY.RESERVA(codigo);
GO
ALTER TABLE HEMINGWAY.PAGO_FACTURA ADD CONSTRAINT fk_pago_factura_numero_factura FOREIGN KEY(numero_factura) REFERENCES HEMINGWAY.FACTURA(numero);
GO
/*
ALTER TABLE HEMINGWAY.USUARIO ADD CONSTRAINT pk_usuario_cod PRIMARY KEY(codigo);
ALTER TABLE HEMINGWAY.ROL ADD CONSTRAINT pk_rol_cod PRIMARY KEY(codigo);
ALTER TABLE HEMINGWAY.FUNCIONALIDAD ADD CONSTRAINT pk_funcionalidad_cod PRIMARY KEY(codigo);
ALTER TABLE HEMINGWAY.HOTEL ADD CONSTRAINT pk_hotel_cod PRIMARY KEY(codigo);
ALTER TABLE HEMINGWAY.REGIMEN ADD CONSTRAINT pk_regimen_cod PRIMARY KEY(codigo);
ALTER TABLE HEMINGWAY.TIPO_HABITACION ADD CONSTRAINT pk_tipo_habitacion_cod PRIMARY KEY(codigo);
ALTER TABLE HEMINGWAY.RESERVA ADD CONSTRAINT pk_reserva_cod PRIMARY KEY(codigo);
ALTER TABLE HEMINGWAY.HABITACION ADD CONSTRAINT pk_habitacion_cod PRIMARY KEY(codigo);
ALTER TABLE HEMINGWAY.CLIENTE ADD CONSTRAINT pk_cliente_cod PRIMARY KEY(codigo);
ALTER TABLE HEMINGWAY.ESTADIA ADD CONSTRAINT pk_estadia_cod PRIMARY KEY(codigo_reserva);
ALTER TABLE HEMINGWAY.CONSUMIBLE ADD CONSTRAINT pk_consumible_cod PRIMARY KEY(codigo);
ALTER TABLE HEMINGWAY.FACTURA ADD CONSTRAINT pk_factura_nro PRIMARY KEY(numero);
ALTER TABLE HEMINGWAY.RESERVA_ESTADO ADD CONSTRAINT pk_reserva_estado_cod PRIMARY KEY(codigo);
ALTER TABLE HEMINGWAY.TIPO_IDENTIFICACION ADD CONSTRAINT pk_tipo_identificacion_cod PRIMARY KEY(codigo);
ALTER TABLE HEMINGWAY.FORMA_DE_PAGO ADD CONSTRAINT pk_form_de_pago_cod PRIMARY KEY(codigo);
--ALTER TABLE HEMINGWAY.PAISES_NACIONALIDADES ADD CONSTRAINT pk_pais PRIMARY KEY(pais);
--ALTER TABLE HEMINGWAY.PAISES_NACIONALIDADES ADD CONSTRAINT pk_nacionalidad PRIMARY KEY(nacionalidad);


ALTER TABLE HEMINGWAY.USUARIO_HOTEL ADD CONSTRAINT fk_usuario_hotel_cod_usuario FOREIGN KEY(codigo_usuario) REFERENCES HEMINGWAY.USUARIO(codigo);
ALTER TABLE HEMINGWAY.USUARIO_HOTEL ADD CONSTRAINT fk_usuario_hotel_cod_hotel FOREIGN KEY(codigo_hotel) REFERENCES HEMINGWAY.HOTEL(codigo);
ALTER TABLE HEMINGWAY.USUARIO_ROL ADD CONSTRAINT fk_usuario_rol_cod_usuario FOREIGN KEY(codigo_usuario) REFERENCES HEMINGWAY.USUARIO(codigo);
ALTER TABLE HEMINGWAY.USUARIO_ROL ADD CONSTRAINT fk_usuario_rol_cod_rol FOREIGN KEY(codigo_rol) REFERENCES HEMINGWAY.ROL(codigo);
ALTER TABLE HEMINGWAY.ROL_FUNCIONALIDAD ADD CONSTRAINT fk_rol_funcionalidad_cod_rol FOREIGN KEY(codigo_rol) REFERENCES HEMINGWAY.ROL(codigo);
ALTER TABLE HEMINGWAY.ROL_FUNCIONALIDAD ADD CONSTRAINT fk_rol_funcionalidad_cod_funcionalidad FOREIGN KEY(codigo_funcionalidad) REFERENCES HEMINGWAY.FUNCIONALIDAD(codigo);

ALTER TABLE HEMINGWAY.HABITACION ADD CONSTRAINT fk_habitacion_cod_hotel FOREIGN KEY(codigo_hotel) REFERENCES HEMINGWAY.HOTEL(codigo);
ALTER TABLE HEMINGWAY.HABITACION ADD CONSTRAINT fk_habitacion_cod_tipo FOREIGN KEY(codigo_tipo_habitacion) REFERENCES HEMINGWAY.TIPO_HABITACION(codigo);
ALTER TABLE HEMINGWAY.HOTEL_REGIMEN ADD CONSTRAINT fk_regimen_hotel_cod_hotel FOREIGN KEY(codigo_hotel) REFERENCES HEMINGWAY.HOTEL(codigo);
ALTER TABLE HEMINGWAY.HOTEL_REGIMEN ADD CONSTRAINT fk_regimen_hotel_cod_regimen FOREIGN KEY(codigo_regimen) REFERENCES HEMINGWAY.REGIMEN(codigo);
ALTER TABLE HEMINGWAY.HABITACION_RESERVA ADD CONSTRAINT fk_habitacion_reserva_cod_reserva FOREIGN KEY(codigo_reserva) REFERENCES HEMINGWAY.RESERVA(codigo);
ALTER TABLE HEMINGWAY.HABITACION_RESERVA ADD CONSTRAINT fk_habitacion_reserva_cod_habitacion FOREIGN KEY(codigo_habitacion) REFERENCES HEMINGWAY.HABITACION(codigo);
ALTER TABLE HEMINGWAY.RESERVA ADD CONSTRAINT fk_reserva_cod_cliente FOREIGN KEY(codigo_cliente) REFERENCES HEMINGWAY.CLIENTE(codigo);
ALTER TABLE HEMINGWAY.RESERVA ADD CONSTRAINT fk_reserva_cod_estado FOREIGN KEY(codigo_estado) REFERENCES HEMINGWAY.RESERVA_ESTADO(codigo);
ALTER TABLE HEMINGWAY.ESTADIA ADD CONSTRAINT fk_estadia_cod_reserva FOREIGN KEY(codigo_reserva) REFERENCES HEMINGWAY.RESERVA(codigo);
ALTER TABLE HEMINGWAY.CLIENTE_ESTADIA ADD CONSTRAINT fk_cliente_estadia_cod_cliente FOREIGN KEY(codigo_cliente) REFERENCES HEMINGWAY.CLIENTE(codigo);
ALTER TABLE HEMINGWAY.CLIENTE_ESTADIA ADD CONSTRAINT fk_cliente_estadia_cod_reserva FOREIGN KEY(codigo_reserva) REFERENCES HEMINGWAY.ESTADIA(codigo_reserva);
ALTER TABLE HEMINGWAY.ESTADIA_CONSUMIBLE ADD CONSTRAINT fk_estadia_consumible_cod_estadia FOREIGN KEY(codigo_estadia) REFERENCES HEMINGWAY.ESTADIA(codigo_reserva);
ALTER TABLE HEMINGWAY.ESTADIA_CONSUMIBLE ADD CONSTRAINT fk_estadia_consumible_cod_consumible FOREIGN KEY(codigo_consumible) REFERENCES HEMINGWAY.CONSUMIBLE(codigo);
ALTER TABLE HEMINGWAY.FACTURA ADD CONSTRAINT fk_factura_cod_estadia FOREIGN KEY(codigo_estadia) REFERENCES HEMINGWAY.ESTADIA(codigo_reserva);
ALTER TABLE HEMINGWAY.RESERVA_OPERACIONES ADD CONSTRAINT fk_reserva_cancelada_cod_reserva FOREIGN KEY(codigo_reserva) REFERENCES HEMINGWAY.RESERVA(codigo);
ALTER TABLE HEMINGWAY.RESERVA_OPERACIONES ADD CONSTRAINT fk_reserva_cancelada_cod_usuario FOREIGN KEY(codigo_usuario) REFERENCES HEMINGWAY.USUARIO(codigo);
ALTER TABLE HEMINGWAY.HOTEL_CERRADO ADD CONSTRAINT fk_hotel_cerrado_cod_hotel FOREIGN KEY(codigo_hotel) REFERENCES HEMINGWAY.HOTEL(codigo);
ALTER TABLE HEMINGWAY.INTENTO_FALLIDO ADD CONSTRAINT fk_intento_fallido_cod_usuario FOREIGN KEY(codigo_usuario) REFERENCES HEMINGWAY.USUARIO(codigo);
ALTER TABLE HEMINGWAY.ITEM_CONSUMIBLE ADD CONSTRAINT fk_item_consumible_nro_factura FOREIGN KEY(numero_factura) REFERENCES HEMINGWAY.FACTURA(numero);
ALTER TABLE HEMINGWAY.ITEM_ESTADIA ADD CONSTRAINT fk_item_estadia_nro_factura FOREIGN KEY(numero_factura) REFERENCES HEMINGWAY.FACTURA(numero);
ALTER TABLE HEMINGWAY.HOTEL_CERRADO ADD CONSTRAINT fk_hotel_cerrado_cod_hotel FOREIGN KEY(codigo_hotel) REFERENCES HEMINGWAY.HOTEL(codigo);
ALTER TABLE HEMINGWAY.CLIENTE_ESTADIA ADD CONSTRAINT fk_cliente_estadia_cod_reserva FOREIGN KEY(codigo_reserva) REFERENCES HEMINGWAY.ESTADIA(codigo_reserva);
ALTER TABLE HEMINGWAY.INTENTO_FALLIDO ADD CONSTRAINT fk_intento_fallido_cod_usuario FOREIGN KEY(codigo_usuario) REFERENCES HEMINGWAY.USUARIO(codigo);
ALTER TABLE HEMINGWAY.OPERACIONES_SOBRE_RESERVA ADD CONSTRAINT fk_operaciones_sobre_reserva_cod_reserva FOREIGN KEY(codigo_reserva) REFERENCES HEMINGWAY.RESERVA(codigo);
ALTER TABLE HEMINGWAY.ESTADIA_CONSUMIBLE ADD CONSTRAINT fk_estadia_consumible_cod_reserva FOREIGN KEY(codigo_reserva) REFERENCES HEMINGWAY.ESTADIA(codigo_reserva);
ALTER TABLE HEMINGWAY.ESTADIA_CONSUMIBLE ADD CONSTRAINT fk_estadia_consumible_cod_consumible FOREIGN KEY(codigo_consumible) REFERENCES HEMINGWAY.CONSUMIBLE(codigo);
ALTER TABLE HEMINGWAY.FACTURA ADD CONSTRAINT fk_factura_cod_reserva FOREIGN KEY(codigo_reserva) REFERENCES HEMINGWAY.RESERVA(codigo);
ALTER TABLE HEMINGWAY.PAGO_FACTURA ADD CONSTRAINT fk_pago_factura_numero_factura FOREIGN KEY(numero_factura) REFERENCES HEMINGWAY.FACTURA(numero);
ALTER TABLE HEMINGWAY.PAGO_FACTURA ADD CONSTRAINT fk_pago_factura_cod_forma_de_pago FOREIGN KEY(codigo_forma_pago) REFERENCES HEMINGWAY.FORMA_DE_PAGO(codigo);
ALTER TABLE HEMINGWAY.ITEM_CONSUMIBLE ADD CONSTRAINT fk_item_consumible_nro_factura FOREIGN KEY(numero_factura) REFERENCES HEMINGWAY.FACTURA(numero);
ALTER TABLE HEMINGWAY.ITEM_ESTADIA ADD CONSTRAINT fk_item_estadia_nro_factura FOREIGN KEY(numero_factura) REFERENCES HEMINGWAY.FACTURA(numero);
ALTER TABLE HEMINGWAY.CLIENTE ADD CONSTRAINT fk_cliente_codigo_tipo_identificacion FOREIGN KEY(codigo_tipo_identificacion) REFERENCES HEMINGWAY.TIPO_IDENTIFICACION(codigo);

*/

	
/*************************************************************************************
*                    VISTAS                                                          *
**************************************************************************************/
	
CREATE VIEW HEMINGWAY.V_USUARIOS_ACTIVOS
AS
	SELECT
		U.codigo,
		U.apellido,
		U.nombre,
		U.fecha_nac,
		U.codigo_tipo_identificacion,
		U.identificacion,
		U.mail,
		U.direccion,
		U.telefono, 
		U.username,
		U.password
	FROM
		HEMINGWAY.USUARIO U
	WHERE 
		U.habilitado <> 'N'			
GO



CREATE VIEW HEMINGWAY.V_RESERVA_NO_CANCELADA
AS
	SELECT
		*
	FROM
		HEMINGWAY.RESERVA R
	WHERE 
		R.codigo_estado <> 'C'			
GO
		
CREATE VIEW	HEMINGWAY.V_HABITACIONES_ACTIVAS
AS
	SELECT
		H.codigo,
		H.numero,
		H.piso,
		H.codigo_tipo_habitacion,
		H.codigo_hotel,
		H.frente
	FROM 
		HEMINGWAY.HABITACION H
	WHERE
		H.habilitado = 'S'
GO

CREATE VIEW HEMINGWAY.V_RESERVAS_ACTIVAS
AS
	SELECT
		R.codigo,
		R.codigo_hotel,
		R.fecha_inicio,
		R.fecha_fin,
		R.codigo_regimen
	FROM 
		HEMINGWAY.RESERVA R
	WHERE
		R.codigo_estado NOT IN ('CANCEL', 'NO_SHOW')
GO

CREATE VIEW HEMINGWAY.V_RESERVAS_CANCELADAS
AS
	SELECT
		R.codigo,
		R.codigo_hotel,
		R.fecha_inicio,
		R.fecha_fin,
		R.codigo_regimen
	FROM 
		HEMINGWAY.RESERVA R
	WHERE
		R.codigo_estado IN ('CANCEL', 'NO_SHOW')
GO
	
/*************************************************************************************
*                    TRIGUERS                                                        *
**************************************************************************************/	
--



/*CREATE TRIGGER T_MAIL_DUPLICADO ON HEMINGWAY.CLIENTE
INSTEAD OF INSERT
AS 
	DECLARE @mail VARCHAR(255)	
	DECLARE @codigo INT
	
	
	SELECT 
		@mail = i.mail, 
		@codigo = i.codigo
	FROM 
		inserted i
		
	IF EXISTS (SELECT mail FROM HEMINGWAY.CLIENTE WHERE mail = @mail)
	BEGIN
		INSERT
			HEMINGWAY.CLIENTES_CON_MAIL_DUPLICADOS (mail)
		VALUES
			(@mail)
	END
GO*/


-- INTENTOS FALLIDOS DE LOGIN
CREATE TRIGGER T_INTENTO_FALLIDO ON HEMINGWAY.INTENTO_FALLIDO
FOR INSERT
AS 
	DECLARE @codigo int
	DECLARE @cant int
	
	SELECT 
		@codigo = i.codigo_usuario  
	FROM 
		inserted i
		
	SELECT
		@cant = COUNT(*)
	FROM
		HEMINGWAY.INTENTO_FALLIDO F
	WHERE	
		F.codigo_usuario = @codigo
	
	IF(@cant >= 3 ) BEGIN
		UPDATE 
			HEMINGWAY.USUARIO
		SET 
			habilitado = 'N'
		WHERE
			codigo = @codigo
			
		DELETE
			HEMINGWAY.INTENTO_FALLIDO 
		WHERE	
			codigo_usuario = @codigo	
	END	
GO

--LIBERA HABITACIONES DE RESERVA
/*CREATE TRIGGER T_RESERVA_UPDATE ON HEMINGWAY.RESERVA
FOR UPDATE
AS 
	DECLARE @codigo int
	DECLARE @codigo_estado char
	
	SELECT 
		@codigo = i.codigo,
		@codigo_estado = i.codigo_estado
	FROM
		inserted i

	IF(@codigo_estado IN ('UPDATE', 'CANCEL', 'NO_SHOW') ) BEGIN -- UPDATE, CANCEL, NO SHOW
		DELETE
			HEMINGWAY.HABITACION_RESERVA
		WHERE
			codigo_reserva = @codigo	
			
		IF(@codigo_estado = 'NO_SHOW') BEGIN
			INSERT INTO
				HEMINGWAY.OPERACIONES_SOBRE_RESERVA (codigo_estado, codigo_reserva)
			VALUES
				('NO_SHOW', @codigo)
		END
	END
GO*/

--LIMPIA FUNCIONALIDAD DE ROLES
CREATE TRIGGER T_ROL_UPDATE ON HEMINGWAY.ROL
FOR UPDATE
AS 
	DECLARE @codigo_rol int
	
	SELECT 
		@codigo_rol = i.codigo
	FROM
		inserted i

	DELETE
		HEMINGWAY.ROL_FUNCIONALIDAD
	WHERE
		codigo_rol = @codigo_rol	
GO

--LIMPIA ROLES DE USUARIO
CREATE TRIGGER T_USUARIO_UPDATE ON HEMINGWAY.USUARIO
FOR UPDATE
AS 
	IF (NOT UPDATE (password) AND NOT UPDATE (habilitado))
	BEGIN
		DECLARE @codigo_usuario int
		
		SELECT 
			@codigo_usuario = i.codigo
		FROM
			inserted i

		DELETE
			HEMINGWAY.USUARIO_ROL
		WHERE
			codigo_usuario = @codigo_usuario
			
		DELETE
			HEMINGWAY.USUARIO_HOTEL
		WHERE
			codigo_usuario = @codigo_usuario			
	END
GO

--LIMPIA REGIMENES DE HOTEL
CREATE TRIGGER T_HOTEL_UPDATE ON HEMINGWAY.HOTEL
FOR UPDATE
AS 
	DECLARE @codigo int
	
	SELECT 
		@codigo = i.codigo
	FROM
		inserted i

	DELETE
		HEMINGWAY.HOTEL_REGIMEN
	WHERE
		codigo_hotel = @codigo
GO

/*************************************************************************************
*                    FUNIONES Y STORE PROCEDURES                                     *
**************************************************************************************/	
-- FUNCIONES

CREATE FUNCTION HEMINGWAY.F_GET_ID_FUNCIONALIDAD (@descripcion varchar(255))
RETURNS int
AS BEGIN
	DECLARE @id int = (
	SELECT TOP 1
		F.codigo
	FROM
		HEMINGWAY.FUNCIONALIDAD F
	WHERE
		F.descripcion = @descripcion)
	RETURN @id;
END;
GO

CREATE FUNCTION HEMINGWAY.F_GET_ID_ROL (@descripcion varchar(255))
RETURNS int
AS BEGIN
	DECLARE @id int = (
	SELECT TOP 1
		R.codigo
	FROM
		HEMINGWAY.ROL R
	WHERE
		R.descripcion = @descripcion)
	RETURN @id;
END;
GO
	
CREATE FUNCTION HEMINGWAY.F_GET_ID_USUARIO (@username varchar(255))
RETURNS int
AS BEGIN
	DECLARE @id int = (
	SELECT TOP 1
		U.codigo
	FROM
		HEMINGWAY.USUARIO U
	WHERE
		U.username = @username)
	RETURN @id;
END;
GO

CREATE FUNCTION HEMINGWAY.F_MAX_CODIGO_RESERVA ()
RETURNS int
AS BEGIN
	DECLARE @value int = (
	SELECT 
		MAX (R.codigo)
	FROM
		HEMINGWAY.RESERVA R)
	IF @value is null
		SET @value = 1;
	RETURN @value;
END
GO


CREATE FUNCTION HEMINGWAY.F_MAX_NUMERO_FACTURA()
RETURNS int
AS BEGIN
	DECLARE @value int = (
	SELECT 
		MAX (F.numero)
	FROM
		HEMINGWAY.FACTURA F)
	IF @value is null
		SET @value = 1;
	RETURN @value;
END
GO	
	

------------------------------- FUNCIONALIDAD -----------------------------------
CREATE PROCEDURE HEMINGWAY.SP_FUNCIONALIDAD_GET_ALL

AS
BEGIN
	SELECT
		F.codigo,
		F.descripcion
	FROM
		HEMINGWAY.FUNCIONALIDAD F
END
GO


CREATE PROCEDURE HEMINGWAY.SP_GET_FUNCIONALIDAD
	@codigo_rol int = NULL
AS
BEGIN
	Declare @query nVARCHAR(255);
		set @query = ''
		set @query = @query +	'SELECT ' 
		set @query = @query +		'F.codigo, '
		set @query = @query +		'F.descripcion '
		set @query = @query +	'FROM '
		set @query = @query +		'HEMINGWAY.FUNCIONALIDAD F '		
	if(@codigo_rol is not null) BEGIN	
		set @query = @query +	'JOIN '
		set @query = @query +		'HEMINGWAY.ROL_FUNCIONALIDAD RF '
		set @query = @query +	'ON '
		set @query = @query +		'RF.codigo_funcionalidad = F.codigo '
		set @query = @query +	'WHERE '
		set @query = @query +		'RF.codigo_rol = ' + CAST(@codigo_rol AS VARCHAR)
	END
	PRINT @query
	exec (@query)
END
GO


------------------------------- ROL ---------------------------------------------------


CREATE PROCEDURE HEMINGWAY.SP_ROL_ADD
	@descripcion VARCHAR(255)
AS
BEGIN
	DECLARE @ID_RESULT NUMERIC(18,0);
	INSERT INTO HEMINGWAY.ROL (descripcion)
	VALUES 
		(@descripcion)
	SET @ID_RESULT = SCOPE_IDENTITY();
	RETURN @ID_RESULT
END
GO

CREATE PROCEDURE HEMINGWAY.SP_ROL_ADD_FUNCIONALIDAD
	@codigo_rol int, 
	@codigo_funcionalidad varchar(255)
AS
BEGIN
	INSERT INTO HEMINGWAY.ROL_FUNCIONALIDAD(codigo_rol, codigo_funcionalidad)
	VALUES 
		(@codigo_rol, @codigo_funcionalidad)
END
GO

CREATE PROCEDURE HEMINGWAY.SP_ROL_UPDATE
	@codigo int, 
	@descripcion varchar(255)
AS
BEGIN
	UPDATE HEMINGWAY.ROL
	SET
		descripcion = @descripcion
	WHERE
		codigo = @codigo
END
GO


CREATE PROCEDURE HEMINGWAY.SP_ROL_GET
	@codigo_usuario int = NULL,
	@codigo int = NULL
AS
BEGIN
	Declare @query nvarchar(255);
		set @query = ''
		set @query = @query +	'SELECT ' 
		set @query = @query +		'R.codigo, '
		set @query = @query +		'R.descripcion '
		set @query = @query +	'FROM '
		set @query = @query +		'HEMINGWAY.ROL R '		
	if(@codigo_usuario is not null) BEGIN	
		set @query = @query +	'JOIN '
		set @query = @query +		'HEMINGWAY.USUARIO_ROL UR '
		set @query = @query +	'ON '
		set @query = @query +		'R.codigo = UR.codigo_rol '
		set @query = @query +	'WHERE '
		set @query = @query +		'UR.codigo_usuario = ' + CAST(@codigo_usuario AS varchar)
	END
	if(@codigo is not null) BEGIN	
		set @query = @query +	'WHERE '
		set @query = @query +		'R.codigo = ' + CAST(@codigo AS varchar)
	END
	PRINT @query
	exec (@query)
END
GO

-------------------------------  USUARIO ---------------------------------------------------


CREATE PROCEDURE HEMINGWAY.SP_USUARIO_ADD
	@username VARCHAR(255), 
	@password VARCHAR(255), 
	@nombre VARCHAR(255), 
	@apellido VARCHAR(255),
	@fecha_nacimiento DATE,
	@telefono VARCHAR(255),
	@mail VARCHAR(255),
	@direccion VARCHAR(255)
AS
BEGIN
	DECLARE @ID_RESULT INT;
	SET @ID_RESULT = 1
	IF EXISTS (	SELECT * FROM HEMINGWAY.USUARIO U WHERE U.username = @username)
		BEGIN
			SET @ID_RESULT = -1
		END
	ELSE
		BEGIN
			INSERT INTO HEMINGWAY.USUARIO(username, password, nombre, apellido, fecha_nac, telefono, mail, direccion)
			VALUES 
				(@username, @password, @nombre, @apellido, @fecha_nacimiento, @telefono, @mail, @direccion)
			SET @ID_RESULT = SCOPE_IDENTITY();
		END
	return @ID_RESULT;
END
GO

CREATE PROCEDURE HEMINGWAY.SP_USUARIO_ADD_ROL (
	@codigo_usuario int, 
	@codigo_rol int
)
AS
BEGIN 
	INSERT INTO HEMINGWAY.USUARIO_ROL (codigo_usuario, codigo_rol)
	VALUES 
		(@codigo_usuario, @codigo_rol)
END
GO

CREATE PROCEDURE HEMINGWAY.SP_USUARIO_ADD_HOTEL (
	@codigo_usuario int, 
	@codigo_hotel int
)
AS
BEGIN 
	INSERT INTO HEMINGWAY.USUARIO_HOTEL (codigo_usuario, codigo_hotel)
	VALUES 
		(@codigo_usuario, @codigo_hotel)
END
GO


CREATE PROCEDURE HEMINGWAY.SP_USUARIO_UPDATE
	@codigo INT,
	--@username VARCHAR(255),
	@nombre VARCHAR(255), 
	@apellido VARCHAR(255),
	@fecha_nacimiento DATE,
	@telefono VARCHAR(255),
	@mail VARCHAR(255),
	@direccion VARCHAR(255)
AS
BEGIN
	UPDATE 
		HEMINGWAY.USUARIO
	SET 
		--username = @username,
		apellido = @apellido,
		nombre = @nombre,
		fecha_nac = @fecha_nacimiento,
		telefono = @telefono,
		mail = @mail,
		direccion = @direccion	
	WHERE
		codigo = @codigo	
END
GO

CREATE PROCEDURE HEMINGWAY.SP_USUARIO_BAJA
	@codigo_usuario INT
AS
BEGIN
	UPDATE 
		HEMINGWAY.USUARIO
	SET 
		habilitado = 'N'
	WHERE
		codigo = @codigo_usuario	
END
GO

CREATE PROCEDURE HEMINGWAY.SP_USUARIO_UPDATE_PASSWORD
	@codigo_usuario INT,
	@password VARCHAR(255)
AS
BEGIN
	UPDATE 
		HEMINGWAY.USUARIO
	SET 
		password = @password
	WHERE
		codigo = @codigo_usuario	
END
GO

CREATE PROCEDURE HEMINGWAY.SP_USUARIO_GET
	@username VARCHAR(255) = NULL,
	@password VARCHAR(255) = NULL,
	@codigo_hotel INT = NULL,
	@codigo_usuario INT = NULL
AS
BEGIN
	DECLARE @query NVARCHAR(255);
		set @query = ''
		set @query = @query +	'SELECT ' 
		set @query = @query +		'U.codigo, '
		set @query = @query +		'U.username, '
		set @query = @query +		'U.apellido, '
		set @query = @query +		'U.nombre, '
		set @query = @query +		'U.mail, '
		set @query = @query +		'U.telefono, '
		set @query = @query +		'U.direccion, '
		set @query = @query +		'U.fecha_nac '
		set @query = @query +	'FROM '
		set @query = @query +		'HEMINGWAY.V_USUARIOS_ACTIVOS U '			
	IF(@codigo_hotel IS NOT NULL) BEGIN
		set @query = @query +	'JOIN '
		set @query = @query +		'HEMINGWAY.USUARIO_HOTEL UH ON UH.codigo_usuario = U.codigo '
		set @query = @query +	'WHERE '
		set @query = @query +		'UH.codigo_hotel = ' + CAST(@codigo_hotel AS VARCHAR)
	END ELSE BEGIN
		set @query = @query +	'WHERE '
	IF(@password IS NOT NULL)	
		set @query = @query +		'U.password = ''' + @password + ''' AND '	
	IF(@username IS NOT NULL)
		set @query = @query +		'U.username = ''' + @username + ''' AND '
	IF(@codigo_usuario IS NOT NULL)
		set @query = @query +		'U.codigo = ' + CAST(@codigo_usuario AS VARCHAR) + ' AND '
		set @query = @query +	'1=1'
	END
	PRINT @query
	EXEC (@query)
END
GO


------------------------------------------- LOGIN ---------------------------------------------

CREATE PROCEDURE HEMINGWAY.SP_USUARIO_LOGIN
	@username VARCHAR(255) = NULL,
	@password VARCHAR(255) = NULL
AS
BEGIN
	DECLARE @result INT = -1
	DECLARE @codigo_usuario INT
	DECLARE @password_usuario VARCHAR(255)
	SELECT 
		@codigo_usuario = U.codigo,
		@password_usuario = U.password
	FROM 
		HEMINGWAY.V_USUARIOS_ACTIVOS U
	WHERE 
		username = @username
				
	IF (@password_usuario <> @password)
	BEGIN
		INSERT INTO HEMINGWAY.INTENTO_FALLIDO (codigo_usuario)
		VALUES (@codigo_usuario)
	END ELSE BEGIN	
		DELETE
			HEMINGWAY.INTENTO_FALLIDO 
		WHERE	
			codigo_usuario = @codigo_usuario
		SET @result = @codigo_usuario		
	END	
	RETURN @result 
END
GO


--------------------------------------- CLIENTE ---------------------------------------


CREATE PROCEDURE HEMINGWAY.SP_CLIENTE_ADD
	@nombre VARCHAR (255), 
	@apellido varchar(255), 
	@mail varchar(255), 
	@telefono varchar(255),
	@identificacion int,
	@codigo_tipo_identificacion varchar(255),
	@fecha_nac DATE,
	@codigo_nacionalidad VARCHAR (255),
	@calle VARCHAR (255),
	@numero_calle INT,
	@piso INT,
	@departamento VARCHAR (255),
	@ciudad VARCHAR (255)
AS
BEGIN
	IF EXISTS (	SELECT * FROM HEMINGWAY.CLIENTE C WHERE C.mail = @mail)
		RETURN -1		
	IF EXISTS (	SELECT * FROM HEMINGWAY.CLIENTE C 
				WHERE C.codigo_tipo_identificacion = @codigo_tipo_identificacion AND C.identificacion = @identificacion )
		RETURN -2		

	DECLARE @ID_RESULT INT		
	INSERT INTO 
		HEMINGWAY.CLIENTE(nombre, apellido, mail, telefono, identificacion, codigo_tipo_identificacion, 
		fecha_nac, codigo_nacionalidad, piso, calle, numero_calle, departamento, ciudad)
	VALUES 
		(@nombre, @apellido, @mail, @telefono, @identificacion, @codigo_tipo_identificacion, 
		@fecha_nac, @codigo_nacionalidad, @piso, @calle, @numero_calle, @departamento, @ciudad)
	SET @ID_RESULT = SCOPE_IDENTITY();
	RETURN @ID_RESULT
END
GO

CREATE PROCEDURE HEMINGWAY.SP_CLIENTE_UPDATE
	@codigo int,
	@nombre VARCHAR (255), 
	@apellido varchar(255), 
	@mail varchar(255), 
	@telefono varchar(255),
	@identificacion int,
	@codigo_tipo_identificacion varchar(255),
	@fecha_nac DATE,
	@codigo_nacionalidad VARCHAR (255),
	@calle VARCHAR (255),
	@numero_calle INT,
	@piso INT,
	@departamento VARCHAR (255),
	@ciudad VARCHAR (255)
AS
BEGIN
	IF EXISTS (	SELECT * FROM HEMINGWAY.CLIENTE C WHERE C.mail = @mail AND C.codigo <> @codigo)
		RETURN -1		
	IF EXISTS (	SELECT * FROM HEMINGWAY.CLIENTE C 
				WHERE C.codigo_tipo_identificacion = @codigo_tipo_identificacion AND C.identificacion = @identificacion AND C.codigo <> @codigo)
		RETURN -2	
		
	UPDATE 
		HEMINGWAY.CLIENTE
	SET 
		apellido = @apellido,
		nombre = @nombre,
		mail = @mail,
		telefono = @telefono,
		identificacion = @identificacion,
		codigo_tipo_identificacion = @codigo_tipo_identificacion,
		codigo_nacionalidad = @codigo_nacionalidad,
		calle = @calle,
		numero_calle = @numero_calle,
		piso = @piso,
		departamento = @departamento,
		ciudad = @ciudad,
		fecha_nac = @fecha_nac
	WHERE
		codigo = @codigo
END
GO

CREATE PROCEDURE HEMINGWAY.SP_CLIENTE_DESHABILITAR
	@codigo int
AS
BEGIN
	UPDATE 
		HEMINGWAY.CLIENTE
	SET 
		habilitado = 'N'
	WHERE
		codigo = @codigo
END
GO

CREATE PROCEDURE HEMINGWAY.SP_CLIENTE_HABILITAR
	@codigo int
AS
BEGIN
	UPDATE 
		HEMINGWAY.CLIENTE
	SET 
		habilitado = 'S'
	WHERE
		codigo = @codigo
END
GO


CREATE FUNCTION  HEMINGWAY.F_MAIL_DUPLICADO(@mail VARCHAR(255))
RETURNS CHAR
AS BEGIN
	DECLARE @RESULT CHAR = 'N'
	IF(EXISTS (SELECT * FROM HEMINGWAY.MAIL_DUPLICADOS WHERE mail = @mail))
		SET @RESULT = 'S'
	RETURN @RESULT
END
GO

CREATE PROCEDURE HEMINGWAY.SP_CLIENTE_GET
	@nombre varchar(255) = null, 
	@apellido varchar(255) = null, 
	@mail varchar(255) = null,
	@identificacion int = null,
	@codigo_tipo_identificacion varchar(255) = null,
	@codigo_cliente int = null
AS
BEGIN
	Declare @query nvarchar(500);	
		set @query = ''
		set @query = @query +	'SELECT '
		set @query = @query +		'C.codigo, '
		set @query = @query +		'C.apellido, '
		set @query = @query +		'C.nombre, '
		set @query = @query +		'C.mail, '
		set @query = @query +		'C.identificacion, '
		set @query = @query +		'C.codigo_tipo_identificacion, '
		set @query = @query +		'C.codigo_nacionalidad, '
		set @query = @query +		'C.calle, '
		set @query = @query +		'C.numero_calle, '
		set @query = @query +		'C.piso, '
		set @query = @query +		'C.departamento, '
		set @query = @query +		'C.ciudad, '
		set @query = @query +		'C.telefono, '
		set @query = @query +		'C.fecha_nac, '
		set @query = @query +		'C.habilitado, '
		set @query = @query +		'HEMINGWAY.F_MAIL_DUPLICADO(C.MAIL) AS mail_repetido '		
		set @query = @query +	'FROM '
		set @query = @query +		'HEMINGWAY.CLIENTE C '
		set @query = @query +	'WHERE '
	if(@codigo_cliente is not null)
		set @query = @query +		'C.codigo = ' + CAST(@codigo_cliente AS varchar)+ ' AND '		
	if(@apellido is not null)
		set @query = @query +		'C.apellido LIKE ''%' +@apellido + '%'' AND '
	if(@nombre is not null)
		set @query = @query +		'C.nombre LIKE ''%' +@nombre + '%'' AND '
	if(@mail is not null)
		set @query = @query +		'C.mail LIKE ''%' + @mail + '%'' AND '
	if(@codigo_tipo_identificacion is not null)
		set @query = @query +		'C.codigo_tipo_identificacion = ''' + @codigo_tipo_identificacion + ''' AND '
	if(@identificacion is not null)
		set @query = @query +		'C.identificacion LIKE ''%'+ CAST(@identificacion AS varchar) +'%'' AND '
	set @query = @query +			'1=1'
	PRINT @query
	exec (@query)
END
GO

---------------------------------------------- TIPO IDENTIFICACION-----------------------------------------------------



CREATE PROCEDURE HEMINGWAY.SP_TIPO_IDENTIFICACION_GET
AS
BEGIN
	SELECT
		TI.codigo,
		TI.descripcion
	FROM
		HEMINGWAY.TIPO_IDENTIFICACION TI
END
GO

---------------------------------------------- NACIONALIDAD PAICES-------------------------------------------------------


CREATE PROCEDURE HEMINGWAY.SP_NACIONALIDAD_GET
AS
BEGIN
	SELECT
		N.pais,
		N.nacionalidad
	FROM
		HEMINGWAY.PAISES_NACIONALIDADES N
	ORDER BY
		N.pais
END
GO

---------------------------------------------- HOTEL ---------------------------------------------------------------

CREATE PROCEDURE HEMINGWAY.SP_HOTEL_ADD
	@calle varchar(255), 
	@nombre varchar(255), 
	@numero_calle int, 
	@ciudad varchar(255), 
	@pais varchar(255), 
	@cantidad_estrellas int,
	@recarga_estrella int, 
	@mail varchar(255),
	@telefono varchar(255),
	@fecha_creacion date
AS
BEGIN
	DECLARE @ID NUMERIC(18,0);
	INSERT INTO 
		HEMINGWAY.HOTEL(nombre, calle, numero_calle, ciudad, pais, cantidad_estrellas, recarga_estrella, mail, telefono, fecha_creacion)
	VALUES 
		(@nombre, @calle, @numero_calle, @ciudad, @pais, @cantidad_estrellas, @recarga_estrella, @mail, @telefono, @fecha_creacion)
		SET @ID = SCOPE_IDENTITY();
	return @ID;
END
GO

CREATE PROCEDURE HEMINGWAY.SP_HOTEL_UPDATE
	@codigo int,
	@calle varchar(255), 
	@nombre varchar(255), 
	@numero_calle int, 
	@ciudad varchar(255), 
	@pais varchar(255), 
	@cantidad_estrellas int,
	@recarga_estrella int, 
	@mail varchar(255),
	@telefono varchar(255)
AS
BEGIN
	UPDATE 
		HEMINGWAY.HOTEL
	SET 
		nombre = @nombre,
		mail = @mail,
		telefono = @telefono,
		ciudad = @ciudad,
		pais = @pais,
		calle = @calle,
		numero_calle = @numero_calle,
		cantidad_estrellas = @cantidad_estrellas,
		recarga_estrella = @recarga_estrella		
	WHERE
		codigo = @codigo
END
GO

CREATE PROCEDURE HEMINGWAY.SP_HOTEL_ADD_REGIMEN
	@codigo_hotel int,
	@codigo_regimen int
AS
BEGIN
	INSERT INTO 
		HEMINGWAY.HOTEL_REGIMEN (codigo_hotel, codigo_regimen)
	VALUES
		(@codigo_hotel, @codigo_regimen)	
END
GO

CREATE PROCEDURE HEMINGWAY.SP_HOTEL_GET
	@codigo int = null,
	@nombre varchar(255) = null, 
	@cantidad_estrellas int = null, 
	@ciudad varchar(255) = null,
	@pais varchar(255) = null,
	@codigo_usuario int = null
AS
BEGIN
	Declare @query nvarchar(255);
			set @query = ''
			set @query = @query +		'SELECT '
			set @query = @query +			'H.codigo, '
			set @query = @query +			'H.nombre, '
			set @query = @query +			'H.cantidad_estrellas, '
			set @query = @query +			'H.ciudad, '
			set @query = @query +			'H.pais, '
			set @query = @query +			'H.calle, '
			set @query = @query +			'H.numero_calle, '
			set @query = @query +			'H.mail, '
			set @query = @query +			'H.telefono, '
			set @query = @query +			'H.recarga_estrella '
			set @query = @query +		'FROM ' 
			set @query = @query +			'HEMINGWAY.HOTEL H '
	if(@codigo_usuario is not null) BEGIN
			set @query = @query +		'JOIN '
			set @query = @query +			'HEMINGWAY.USUARIO_HOTEL UH ON UH.codigo_hotel = H.codigo '
			set @query = @query +		'WHERE '
			set @query = @query +			'UH.codigo_usuario = ' + CAST(@codigo_usuario AS varchar)
	END	
	ELSE BEGIN
			set @query = @query +		'WHERE '
		if(@codigo is not null)
			set @query = @query +			'H.codigo = ' + CAST(@codigo AS varchar) + ' AND '
		if(@nombre is not null)
			set @query = @query +			'H.nombre LIKE ''%' + @nombre + '%'' AND '
		if(@cantidad_estrellas is not null)
			set @query = @query +			'H.cantidad_estrellas LIKE ''%' + CAST(@cantidad_estrellas AS varchar) + '%'' AND '
		if(@ciudad is not null)
			set @query = @query +			'H.ciudad LIKE ''%' + @ciudad + '%'' AND '
		if(@pais is not null)
			set @query = @query +			'H.pais LIKE ''%' + @pais + '%'' AND '			
			set @query = @query +			'1=1'
	END		
	PRINT @query
	exec (@query)
END
GO


CREATE PROCEDURE HEMINGWAY.SP_HOTEL_DAR_DE_BAJA
	@codigo_hotel int,
	@fecha_inicio_baja date,
	@fecha_fin_baja date
AS
BEGIN
		IF EXISTS (
			SELECT
				*
			FROM
				HEMINGWAY.V_RESERVAS_ACTIVAS R
			WHERE
				R.codigo_hotel = @codigo_hotel AND
				( ( @fecha_inicio_baja BETWEEN R.fecha_inicio AND R.fecha_fin ) 	OR
				( @fecha_fin_baja BETWEEN R.fecha_inicio AND R.fecha_fin ) )					
		)
			RETURN -1

		INSERT INTO	
			HEMINGWAY.HOTEL_CERRADO (codigo_hotel, fecha_inicio, fecha_fin, motivo)
		VALUES
			(@codigo_hotel, @fecha_inicio_baja, @fecha_fin_baja, 'HOTEL DADO DE BAJA')	
		RETURN 1
END
GO

--------------------------------------------------- HABITACION ------------------------------------------------
CREATE PROCEDURE HEMINGWAY.SP_HABITACION_ADD
	@codigo_hotel int, 
	@piso int, 
	@numero int, 
	@codigo_tipo_habitacion int,
	@frente char
AS
BEGIN
	IF EXISTS (	SELECT * FROM HEMINGWAY.HABITACION H WHERE H.numero = @numero AND H.codigo_hotel = @codigo_hotel )
		RETURN -1		

	INSERT INTO 
		HEMINGWAY.HABITACION(piso, codigo_hotel, codigo_tipo_habitacion, numero, frente)
	VALUES 
		(@piso, @codigo_hotel, @codigo_tipo_habitacion, @numero, @frente)
END
GO

CREATE PROCEDURE HEMINGWAY.SP_HABITACION_UPDATE
	@codigo_habitacion int,
	@codigo_hotel int,
	@numero int,
	@piso int,
	@frente char
AS
BEGIN
	IF EXISTS (	SELECT * FROM HEMINGWAY.HABITACION H WHERE H.numero = @numero AND H.codigo_hotel = @codigo_hotel 
	AND H.codigo <> @codigo_habitacion )
		RETURN -1		

	UPDATE 
		HEMINGWAY.HABITACION
	SET 
		piso = @piso,
		numero = @numero,
		frente = @frente
	WHERE
		codigo = @codigo_habitacion		
END
GO


CREATE PROCEDURE HEMINGWAY.SP_HABITACION_GET
	@codigo_hotel INT = NULL,
	@codigo_habitacion INT = NULL,
	@codigo_tipo_habitacion INT = NULL,
	@cantidad INT = NULL
AS
BEGIN
	Declare @query NVARCHAR(255);
		set @query = ''
		set @query = @query +	'SELECT ' 
	if(@cantidad is not null)
		set @query = @query +		'TOP ' + CAST(@cantidad AS VARCHAR) + ' '
		set @query = @query +		'H.codigo, '
		set @query = @query +		'H.piso, '
		set @query = @query +		'H.codigo_tipo_habitacion, '
		set @query = @query +		'H.codigo_hotel, '
		set @query = @query +		'H.frente, '
		set @query = @query +		'H.numero, '
		set @query = @query +		'H.habilitado '
		set @query = @query +	'FROM '
		set @query = @query +		'HEMINGWAY.HABITACION H '
		set @query = @query +	'WHERE '
	if(@codigo_hotel is not null)
		set @query = @query +		'H.codigo_hotel = ' + CAST(@codigo_hotel AS VARCHAR) + ' AND '
	if(@codigo_tipo_habitacion is not null)
		set @query = @query +		'H.codigo_tipo_habitacion = ' + CAST(@codigo_tipo_habitacion AS VARCHAR) + ' AND '
	if(@codigo_habitacion is not null)
		set @query = @query +		'H.codigo_habitacion = ' + CAST(@codigo_habitacion AS VARCHAR) + ' AND '		
		set @query = @query +		'1=1'
	PRINT @query
	exec (@query)	
END
GO


CREATE PROCEDURE HEMINGWAY.SP_TIPO_HABITACION_GET
	@codigo INT = NULL
AS
BEGIN
	IF(@codigo IS NULL) BEGIN
		SELECT
			TH.codigo,
			TH.descripcion,
			TH.porcentual
		FROM
			HEMINGWAY.TIPO_HABITACION TH			
	END ELSE BEGIN
		SELECT
			TH.codigo,
			TH.descripcion,
			TH.porcentual
		FROM
			HEMINGWAY.TIPO_HABITACION TH
		WHERE
			TH.codigo = @codigo
	END
END
GO


CREATE PROCEDURE HEMINGWAY.SP_HABITACION_DESHABILITAR
	@codigo INT,
	@fecha_sistema DATE
AS
BEGIN
	DECLARE @RESULT INT
	SET @RESULT = 1
	IF EXISTS (
		SELECT
			*
		FROM
			V_RESERVAS_ACTIVAS R
		JOIN
			HEMINGWAY.HABITACION_RESERVA HR ON HR.codigo_reserva = R.codigo
		WHERE
			HR.codigo_habitacion = @codigo AND
			( @fecha_sistema BETWEEN R.fecha_inicio AND R.fecha_inicio ) OR ( @fecha_sistema < R.fecha_inicio ) 					
	)BEGIN
		SET @RESULT = -1	
	END	
	ELSE BEGIN
		UPDATE 
			HEMINGWAY.HABITACION
		SET 
			habilitado = 'N'
		WHERE
			codigo = @codigo
	END
	RETURN @RESULT
END
GO

CREATE PROCEDURE HEMINGWAY.SP_HABITACION_HABILITAR
	@codigo int
AS
BEGIN
	UPDATE 
		HEMINGWAY.HABITACION
	SET 
		habilitado = 'S'
	WHERE
		codigo = @codigo
END
GO

--------------------------------------- REGIMEN -------------------------------------------------

CREATE FUNCTION HEMINGWAY.F_REMOVIBLE(@fecha_sistema DATE, @codigo_hotel INT, @codigo_regimen INT)
RETURNS char
AS BEGIN
	DECLARE @RESULT CHAR
	SET @RESULT = 'S'
	
	IF (
		EXISTS (
			SELECT 
				*
			FROM
				HEMINGWAY.V_RESERVAS_ACTIVAS R
			WHERE
				R.codigo_hotel = @codigo_hotel AND
				R.codigo_regimen = @codigo_regimen AND
				(R.fecha_inicio > @fecha_sistema) OR ( @fecha_sistema BETWEEN R.fecha_inicio AND R.fecha_fin )
		)
	)
		SET @RESULT = 'N'
		
	RETURN @RESULT
END
GO

CREATE PROCEDURE HEMINGWAY.SP_REGIMEN_GET
	@codigo_hotel INT = NULL,
	@fecha_sistema DATE = NULL
AS
BEGIN
	IF(@codigo_hotel IS NULL)
	BEGIN
		SELECT
			R.codigo,
			R.descripcion,
			R.precio,
			'S' AS removible
		FROM
			HEMINGWAY.REGIMEN R
	END	
	ELSE 
	BEGIN
		SELECT
			R.codigo,
			R.descripcion,
			R.precio,
			HEMINGWAY.F_REMOVIBLE(@fecha_sistema, @codigo_hotel, R.codigo) AS removible
		FROM
			HEMINGWAY.REGIMEN R
		JOIN
			HEMINGWAY.HOTEL_REGIMEN HR ON HR.codigo_regimen = R.codigo
		WHERE 
			HR.codigo_hotel = @codigo_hotel
	END	
END
GO



------------------------------------------------------	RESERVA ----------------------------------------

/*CREATE PROCEDURE HEMINGWAY.SP_RESERVAS_CANCELADAS
	@codigo_hotel int = NULL
AS
BEGIN
	SELECT
		R.codigo
	FROM
		HEMINGWAY.HABITACION_RESERVA HR 
	JOIN 
		HEMINGWAY.RESERVA R
	ON
		R.codigo = HR.codigo_reserva 
	JOIN
		HEMINGWAY.HABITACION H 
	ON
		HR.codigo_habitacion = H.codigo
	WHERE
		H.codigo_hotel = @codigo_hotel 	AND
		(R.codigo_estado = 'C' OR r.codigo_estado = 'N')
END
GO*/


CREATE FUNCTION HEMINGWAY.F_HOTEL_CERRADO (@codigo_hotel INT, @fecha_inicio DATE, @fecha_fin DATE)
RETURNS TABLE
AS
RETURN
(
	SELECT 
		* 
	FROM 
		HEMINGWAY.HOTEL_CERRADO HC
	WHERE
		HC.codigo_hotel = @codigo_hotel AND 
		( ( @fecha_inicio BETWEEN HC.fecha_inicio AND HC.fecha_fin ) OR 
		( @fecha_fin BETWEEN HC.fecha_inicio AND HC.fecha_fin ) )	
);
GO

	
CREATE FUNCTION HEMINGWAY.F_HOTEL_HABITACIONES (@codigo INT)
RETURNS TABLE
AS
RETURN
(
	SELECT
		HA.codigo AS codigo_habitacion,
		HA.codigo_tipo_habitacion AS codigo_tipo_habitacion
	FROM 
		HEMINGWAY.V_HABITACIONES_ACTIVAS HA
	WHERE
		HA.codigo_hotel	= @codigo
);
GO

CREATE FUNCTION HEMINGWAY.F_HOTEL_HABITACIONES_RESERVADAS (@reserva_codigo_hotel INT, @reserva_fecha_inicio DATE, @reserva_fecha_fin DATE)
RETURNS TABLE
AS
RETURN
(
	SELECT
		HR.codigo_habitacion AS codigo_habitacion
	FROM 
		HEMINGWAY.HABITACION_RESERVA HR
	JOIN
		HEMINGWAY.V_RESERVAS_ACTIVAS R ON HR.codigo_reserva = R.codigo
	WHERE
		R.codigo_hotel = @reserva_codigo_hotel AND
		( ( @reserva_fecha_inicio BETWEEN R.fecha_inicio AND R.fecha_fin ) OR ( @reserva_fecha_fin BETWEEN R.fecha_inicio AND R.fecha_fin ) )				
);
GO

CREATE FUNCTION HEMINGWAY.F_HABITACIONES_RESERVA (@codigo_reserva INT)
RETURNS TABLE
AS
RETURN
(
	SELECT
		H.codigo_tipo_habitacion AS codigo_tipo_habitacion,
		HR.codigo_habitacion AS codigo_habitacion
	FROM
		HEMINGWAY.RESERVA R
	JOIN 
		HEMINGWAY.HABITACION_RESERVA HR ON R.codigo = HR.codigo_reserva
	JOIN
		HEMINGWAY.HABITACION H ON H.codigo = HR.codigo_habitacion
	WHERE
		R.codigo = @codigo_reserva
);
GO


CREATE FUNCTION HEMINGWAY.F_HABITACIONES_DISPONIBLES (
	@codigo_hotel int, 
	@fecha_inicio date, 
	@fecha_fin date)
RETURNS TABLE
AS
RETURN
(	
	SELECT
		H.codigo_tipo_habitacion AS codigo_tipo_habitacion,
		H.codigo_habitacion AS codigo_habitacion
	FROM
		HEMINGWAY.F_HOTEL_HABITACIONES (@codigo_hotel)	H
	LEFT JOIN
		HEMINGWAY.F_HOTEL_HABITACIONES_RESERVADAS (@codigo_hotel, @fecha_inicio , @fecha_fin) HR 
	ON 
		H.codigo_habitacion = HR.codigo_habitacion	
	WHERE
		HR.codigo_habitacion IS NULL				
);
GO


CREATE FUNCTION HEMINGWAY.F_HABITACIONES_DISPONIBLES_CON_RESERVA (
	@codigo_hotel int, 
	@fecha_inicio date, 
	@fecha_fin date,
	@codigo_reserva int)
RETURNS TABLE
AS
RETURN
(	
		SELECT
			HD.codigo_habitacion AS codigo_habitacion,
			HD.codigo_tipo_habitacion AS codigo_tipo_habitacion
		FROM
			HEMINGWAY.F_HABITACIONES_DISPONIBLES(@codigo_hotel, @fecha_inicio, @fecha_fin) HD					
	UNION ALL	
		SELECT  
			FHR.codigo_habitacion AS codigo_habitacion,
			FHR.codigo_tipo_habitacion AS codigo_tipo_habitacion			
		FROM 
			HEMINGWAY.F_HABITACIONES_RESERVA (@codigo_reserva) FHR				
);
GO

/*CREATE FUNCTION HEMINGWAY.F_CANCELAR_RESERVAS_NO_SHOW ()
RETURNS TABLE
AS
RETURN
(	
		SELECT
			HD.codigo_habitacion AS codigo_habitacion,
			HD.codigo_tipo_habitacion AS codigo_tipo_habitacion
		FROM
			HEMINGWAY.F_HABITACIONES_DISPONIBLES(@codigo_hotel, @fecha_inicio, @fecha_fin) HD					
	UNION ALL	
		SELECT  
			FHR.codigo_habitacion AS codigo_habitacion,
			FHR.codigo_tipo_habitacion AS codigo_tipo_habitacion			
		FROM 
			HEMINGWAY.F_HABITACIONES_RESERVA (@codigo_reserva) FHR				
);
GO*/

CREATE PROCEDURE HEMINGWAY.SP_RESERVA_UPDATE_ESTADOS
	@reserva_codigo_hotel int,
	@reserva_fecha_sistema date
AS
BEGIN
	BEGIN TRAN
		DECLARE @reservas_para_actualizar TABLE
		(
			codigo_reserva INT
		);
		
		INSERT INTO 
			@reservas_para_actualizar (codigo_reserva)
		SELECT
			r.codigo			
		FROM
			HEMINGWAY.RESERVA R
		WHERE			 
			(	R.codigo_estado = 'INSERT' OR R.codigo_estado = 'UPDATE' ) AND
			R.fecha_inicio < @reserva_fecha_sistema AND
			R.codigo_hotel = @reserva_codigo_hotel	
	
		UPDATE
			HEMINGWAY.RESERVA
		SET
			codigo_estado = 'NO_SHOW'
		WHERE			 
			codigo in (select codigo_reserva from @reservas_para_actualizar)
			
		INSERT INTO 
			HEMINGWAY.OPERACIONES_SOBRE_RESERVA (fecha, codigo_reserva, codigo_estado)	
		SELECT
			@reserva_fecha_sistema,
			R.codigo_reserva,
			'NO_SHOW'
		FROM 
			@reservas_para_actualizar R
		
	COMMIT TRAN
END
GO


CREATE PROCEDURE HEMINGWAY.SP_RESERVA_HABITACIONES_DISPONIBLES
	@codigo_hotel int,
	@fecha_inicio date,
	@fecha_fin date,
	@codigo_reserva int = null,
	@fecha_sistema date
AS
BEGIN	

	EXEC HEMINGWAY.SP_RESERVA_UPDATE_ESTADOS 
	@reserva_codigo_hotel = @codigo_hotel,
	@reserva_fecha_sistema = @fecha_sistema

	--crontrolar si el hotel no se encuentra dado de baja para esas fechas
	IF NOT EXISTS ( SELECT * FROM HEMINGWAY.F_HOTEL_CERRADO (@codigo_hotel, @fecha_inicio, @fecha_fin) )
	BEGIN
	--cancelar reservas por no show
		
		
	--ver disponibilidad de habitaicones
		IF (@codigo_reserva IS NULL) BEGIN
			SELECT
				H.codigo_tipo_habitacion AS codigo_tipo_habitacion,
				COUNT(H.codigo_habitacion) AS cantidad
			FROM
				HEMINGWAY.F_HABITACIONES_DISPONIBLES (@codigo_hotel, @fecha_inicio, @fecha_fin) H
			GROUP BY 
				H.codigo_tipo_habitacion
		END ELSE BEGIN			
			SELECT 
				H.codigo_tipo_habitacion AS codigo_tipo_habitacion,
				COUNT(H.codigo_habitacion) AS cantidad
			FROM
				HEMINGWAY.F_HABITACIONES_DISPONIBLES_CON_RESERVA(@codigo_hotel, @fecha_inicio, @fecha_fin, @codigo_reserva) H
			GROUP BY 
				H.codigo_tipo_habitacion
		END
	END
END	
GO	

CREATE PROCEDURE HEMINGWAY.SP_RESERVA_ADD_HABITACIONES
	@codigo_reserva int,
	@codigo_tipo_habitacion int,
	@cantidad int,
	@codigo_hotel int,
	@fecha_inicio date,
	@fecha_fin date
AS
BEGIN
	IF (@codigo_reserva IS NULL) BEGIN	
		INSERT INTO 
			HEMINGWAY.HABITACION_RESERVA (codigo_reserva, codigo_habitacion)			
		SELECT TOP (@cantidad)
			@codigo_reserva,
			HD.codigo_habitacion
		FROM
			HEMINGWAY.F_HABITACIONES_DISPONIBLES (@codigo_hotel, @fecha_inicio, @fecha_fin) HD
		WHERE
			HD.codigo_tipo_habitacion = @codigo_tipo_habitacion
	END ELSE BEGIN
		INSERT INTO 
			HEMINGWAY.HABITACION_RESERVA (codigo_reserva, codigo_habitacion)			
		SELECT TOP (@cantidad)
			@codigo_reserva,
			HD.codigo_habitacion
		FROM
			HEMINGWAY.F_HABITACIONES_DISPONIBLES_CON_RESERVA(@codigo_hotel, @fecha_inicio, @fecha_fin, @codigo_reserva) HD
		WHERE
			HD.codigo_tipo_habitacion = @codigo_tipo_habitacion
	END
END
GO

CREATE FUNCTION HEMINGWAY.F_ESTADO_RESERVA (@fecha_sistema datetime, @fecha_reserva_inicio datetime, @estado char)
RETURNS char
AS BEGIN
	
	DECLARE @estado_reserva char
	set @estado_reserva = @estado
	if(@fecha_sistema > @fecha_reserva_inicio)
		set @estado_reserva = 'N'
	RETURN @estado_reserva
END
GO


CREATE PROCEDURE HEMINGWAY.SP_RESERVA_GET
	@codigo int
AS
BEGIN
	SELECT
		R.codigo,
		R.codigo_cliente,
		R.codigo_hotel,
		R.codigo_regimen,
		REG.descripcion AS descripcion_regimen,
		R.fecha_inicio,
		R.fecha_fin,		
		R.fecha_reserva,
		R.codigo_estado,
		RE.descripcion AS descripcion_estado
	FROM
		HEMINGWAY.RESERVA R
	JOIN
		HEMINGWAY.RESERVA_ESTADO RE ON RE.codigo = R.codigo_estado
	JOIN
		HEMINGWAY.REGIMEN REG ON R.codigo_regimen = REG.codigo
	WHERE
		R.codigo = @codigo
END
GO

CREATE PROCEDURE HEMINGWAY.SP_RESERVA_GET_HABITACIONES
	@codigo_reserva int
AS
BEGIN
	SELECT  
		H.codigo_tipo_habitacion,
		COUNT(H.codigo_habitacion) AS cantidad				
	FROM 
		HEMINGWAY.F_HABITACIONES_RESERVA (@codigo_reserva) H	
	GROUP BY 
		H.codigo_tipo_habitacion
END
GO


CREATE PROCEDURE HEMINGWAY.SP_GET_RESERVA_ESTADO
AS
BEGIN
	SELECT
		R.codigo,
		R.descripcion
	FROM
		HEMINGWAY.RESERVA_ESTADO R
END
GO

CREATE PROCEDURE HEMINGWAY.SP_RESERVA_ADD
	--@codigo int,
	@codigo_hotel int,
	--@fecha_reserva datetime,
	@fecha_inicio date,
	@fecha_fin date,
	--@cantidad_noches int,
	@codigo_regimen int,
	@codigo_cliente int,
	
	@codigo_usuario int,
	@fecha datetime
AS
BEGIN
	BEGIN TRAN
		DECLARE @codigo_reserva int
		set @codigo_reserva = (select HEMINGWAY.F_MAX_CODIGO_RESERVA()) + 1
		
		INSERT INTO 
			HEMINGWAY.RESERVA (codigo, codigo_hotel, fecha_inicio, fecha_fin, codigo_regimen, codigo_cliente, codigo_estado, fecha_reserva)
		VALUES 
			(@codigo_reserva, @codigo_hotel, @fecha_inicio, @fecha_fin, @codigo_regimen, @codigo_cliente, 'INSERT', @fecha)
		
		INSERT INTO
			HEMINGWAY.OPERACIONES_SOBRE_RESERVA 
			(codigo_estado, codigo_reserva, codigo_usuario, fecha)
		VALUES
			('INSERT', @codigo_reserva, @codigo_usuario, @fecha)								
	COMMIT TRAN
	RETURN HEMINGWAY.F_MAX_CODIGO_RESERVA()
END
GO

CREATE PROCEDURE HEMINGWAY.SP_RESERVA_CANCELAR
	@codigo_reserva int,
	@codigo_usuario int,
	@fecha_cancelacion datetime
AS
BEGIN
	BEGIN TRAN
		UPDATE 
			HEMINGWAY.RESERVA
		SET
			codigo_estado = 'CANCEL'
		WHERE
			codigo = @codigo_reserva

		INSERT INTO
			HEMINGWAY.OPERACIONES_SOBRE_RESERVA 
			(codigo_estado, codigo_reserva, codigo_usuario, fecha)
		VALUES
			('CANCEL', @codigo_reserva, @codigo_usuario, @fecha_cancelacion)	
	
	COMMIT TRAN
END 
GO

CREATE PROCEDURE HEMINGWAY.SP_RESERVA_CANCELAR_NO_SHOW
	@codigo_reserva int,
	@codigo_usuario int,
	@fecha_cancelacion datetime
AS
BEGIN
	BEGIN TRAN
		UPDATE 
			HEMINGWAY.RESERVA
		SET
			codigo_estado = 'NO_SHOW'
		WHERE
			codigo = @codigo_reserva

		INSERT INTO
			HEMINGWAY.OPERACIONES_SOBRE_RESERVA 
			(codigo_estado, codigo_reserva, codigo_usuario, fecha)
		VALUES
			('NO_SHOW', @codigo_reserva, @codigo_usuario, @fecha_cancelacion)	
	
	COMMIT TRAN
END 
GO

CREATE PROCEDURE HEMINGWAY.SP_RESERVA_UPDATE
	@fecha_inicio date,
	@fecha_fin date,
	@codigo_regimen int,	
	@codigo_reserva int,
	@codigo_usuario int,
	@fecha datetime
AS
BEGIN
	BEGIN TRAN	
		UPDATE 
			HEMINGWAY.RESERVA
		SET
			fecha_inicio = @fecha_inicio,
			fecha_fin = @fecha_fin,
			codigo_regimen = @codigo_regimen,
			codigo_estado = 'UPDATE'
		WHERE
			codigo = @codigo_reserva


		INSERT INTO
			HEMINGWAY.OPERACIONES_SOBRE_RESERVA
			(codigo_estado, codigo_reserva, codigo_usuario, fecha)
		VALUES
			('UPDATE', @codigo_reserva, @codigo_usuario, @fecha)		
	COMMIT TRAN
END 
GO


---------------------------------------------------------------------- ESTADIA ------------------------------------------------------------

CREATE PROCEDURE HEMINGWAY.SP_ESTADIA_GET
	@codigo_reserva int
AS
BEGIN
		SELECT 
			E.fecha_inicio,
			E.fecha_fin
		FROM
			HEMINGWAY.ESTADIA E
		WHERE
			E.codigo_reserva = @codigo_reserva
END
GO

CREATE PROCEDURE HEMINGWAY.SP_ESTADIA_ADD
	@codigo_reserva int,
	@fecha_check_in datetime,
	@cantidad_noches int,
	@codigo_usuario int,
	@fecha_sistema datetime
AS
BEGIN
	BEGIN TRAN
		INSERT INTO 
			HEMINGWAY.ESTADIA (codigo_reserva, fecha_inicio, cantidad_noches)
		VALUES 
			(@codigo_reserva, @fecha_check_in, @cantidad_noches)
			
		UPDATE
			HEMINGWAY.RESERVA 
		SET
			codigo_estado = 'CHECK_IN'
		WHERE
			codigo = @codigo_reserva
			
		INSERT INTO
			HEMINGWAY.OPERACIONES_SOBRE_RESERVA 
			(codigo_estado, codigo_reserva, codigo_usuario, fecha)
		VALUES
			('CHECK_IN', @codigo_reserva, @codigo_usuario, @fecha_sistema)								
	COMMIT TRAN		
END

GO


CREATE PROCEDURE HEMINGWAY.SP_ESTADIA_ADD_CLIENTE
	@codigo_cliente int,
	@codigo_reserva int
AS
BEGIN
	INSERT INTO 
		HEMINGWAY.CLIENTE_ESTADIA(codigo_cliente, codigo_reserva)
	VALUES 
		(@codigo_cliente, @codigo_reserva)
END
GO


CREATE PROCEDURE HEMINGWAY.SP_CONSUMIBLE_GET
	@codigo int = null,
	@codigo_reserva int = null
AS
BEGIN
	Declare @query nVARCHAR(255);
		set @query = ''
		set @query = @query +	'SELECT ' 
		set @query = @query +		'C.codigo, '
		set @query = @query +		'C.descripcion, '
		set @query = @query +		'C.precio '
		set @query = @query +	'FROM '
		set @query = @query +		'HEMINGWAY.CONSUMIBLE C '
	if(@codigo_reserva is not null) BEGIN
		set @query = @query +	'JOIN '
		set @query = @query +		'HEMINGWAY.ESTADIA_CONSUMIBLE EC '
		set @query = @query +	'ON '
		set @query = @query +		'EC.codigo_consumible = C.codigo '		
		set @query = @query +	'WHERE '
		set @query = @query +		'EC.codigo_reserva = ' + CAST(@codigo_reserva AS VARCHAR)
	END
	if(@codigo is not null) BEGIN
		set @query = @query +	'WHERE '
		set @query = @query +		'C.codigo = ' + CAST(@codigo AS VARCHAR)
	END
	--PRINT @query
	exec (@query)	
END
GO

CREATE PROCEDURE HEMINGWAY.SP_ESTADIA_ADD_CONSUMIBLE
	@codigo_reserva int, 
	@codigo_consumible int 
AS
BEGIN
	INSERT INTO 
		HEMINGWAY.ESTADIA_CONSUMIBLE (codigo_reserva, codigo_consumible/*, habitacion*/)
	VALUES 
		(@codigo_reserva, @codigo_consumible)
END
GO

CREATE PROCEDURE HEMINGWAY.SP_ESTADIA_ADD_CONSUMIBLE2
	@codigo_reserva int, 
	@codigo_consumible int,
	@cantidad int 
AS
BEGIN
	
	IF EXISTS (SELECT * FROM HEMINGWAY.ESTADIA_CONSUMIBLE EC 
				WHERE EC.codigo_reserva = @codigo_reserva AND EC.codigo_consumible = @codigo_consumible)
		BEGIN
			UPDATE
				HEMINGWAY.ESTADIA_CONSUMIBLE 
			SET
				cantidad = cantidad + @cantidad 
			WHERE
				codigo_reserva = @codigo_reserva AND 
				codigo_consumible = @codigo_consumible
		END
	ELSE
		BEGIN
 			INSERT INTO 
				HEMINGWAY.ESTADIA_CONSUMIBLE (codigo_reserva, codigo_consumible, cantidad/*, habitacion*/)
			VALUES 
				(@codigo_reserva, @codigo_consumible, @cantidad)
		END
END
GO
-------------------------------------------------------------- FACTURACION -------------------------------------------------------

CREATE FUNCTION HEMINGWAY.F_ITEMS_CONSUMIBLES (@codigo_reserva INT)
RETURNS TABLE
AS
RETURN
(	
		SELECT
			C.codigo,
			C.descripcion,
			SUM(EC.cantidad) AS cantidad,
			SUM(C.precio) AS total
		FROM
			HEMINGWAY.ESTADIA E
		JOIN
			HEMINGWAY.ESTADIA_CONSUMIBLE EC ON E.codigo_reserva = EC.codigo_reserva
		JOIN
			HEMINGWAY.CONSUMIBLE C ON C.codigo = EC.codigo_consumible
		WHERE
			E.codigo_reserva = @codigo_reserva
		GROUP BY
			C.codigo, C.descripcion			
);
GO

CREATE PROCEDURE HEMINGWAY.SP_FACTURA_GET_ITEMS_CONSUMIBLES
	@codigo_reserva INT
AS
BEGIN
	SELECT
		IC.cantidad,
		IC.descripcion,
		IC.total
	FROM
		HEMINGWAY.F_ITEMS_CONSUMIBLES (@codigo_reserva) IC
END
GO


CREATE FUNCTION HEMINGWAY.F_TIPOS_HABITACIONES_DE_ESTADIA (@codigo_reserva INT)
RETURNS TABLE
AS
RETURN
(	
	SELECT
		R.codigo AS CODIGO_RESERVA,
		H.codigo_tipo_habitacion AS CODIGO_TIPO_HABITACION,
		TH.porcentual AS PORCENTUAL,
		COUNT(*) AS CANTIDAD
	FROM
		HEMINGWAY.RESERVA R
	JOIN
		HEMINGWAY.HABITACION_RESERVA HR ON HR.codigo_reserva = R.codigo
	JOIN
		HEMINGWAY.HABITACION H ON HR.codigo_habitacion = H.codigo
	JOIN
		HEMINGWAY.TIPO_HABITACION TH ON TH.codigo = H.codigo_tipo_habitacion
	WHERE
		R.codigo = @codigo_reserva
	GROUP BY
		R.codigo,
		H.codigo_tipo_habitacion,
		TH.porcentual 
);
GO

             
CREATE FUNCTION HEMINGWAY.F_MONTO_ESTADIA (@codigo_reserva INT)
RETURNS DECIMAL
AS
BEGIN
	DECLARE @monto_estadia DECIMAL = 
		(
			SELECT
				SUM( (RE.precio * TH.PORCENTUAL * TH.CANTIDAD) + (H.cantidad_estrellas * H.recarga_estrella) )
			FROM
				HEMINGWAY.RESERVA R
			JOIN
				HEMINGWAY.HOTEL H ON R.codigo_hotel = H.codigo			
			JOIN
				HEMINGWAY.REGIMEN RE ON R.codigo_regimen = RE.codigo
			JOIN
				HEMINGWAY.F_TIPOS_HABITACIONES_DE_ESTADIA (@codigo_reserva) TH ON TH.CODIGO_RESERVA = R.codigo
		)
	RETURN (@monto_estadia)	
END;
GO


CREATE PROCEDURE HEMINGWAY.SP_FACTURA_GET_ITEMS_ESTADIA
	@codigo_reserva int,
	@fecha_check_out datetime
AS
BEGIN
	DECLARE @monto_estadia DECIMAL = HEMINGWAY.F_MONTO_ESTADIA (@codigo_reserva)
	DECLARE @fecha_inicio datetime = ( SELECT R.fecha_inicio FROM HEMINGWAY.RESERVA R WHERE R.codigo = @codigo_reserva )
	DECLARE @fecha_fin datetime = ( SELECT R.fecha_fin FROM HEMINGWAY.RESERVA R WHERE R.codigo = @codigo_reserva )
	/*DECLARE @monto_estadia DECIMAL = 
		(
			SELECT
				SUM( (RE.precio * TH.PORCENTUAL * TH.CANTIDAD) + (H.cantidad_estrellas * H.recarga_estrella) )
			FROM
				HEMINGWAY.RESERVA R
			JOIN
				HEMINGWAY.HOTEL H ON R.codigo_hotel = H.codigo			
			JOIN
				HEMINGWAY.REGIMEN RE ON R.codigo_regimen = RE.codigo
			JOIN
				HEMINGWAY.F_TIPOS_HABITACIONES_DE_ESTADIA (@codigo_reserva) TH ON TH.CODIGO_RESERVA = R.codigo
		)*/
	
	DECLARE @ITEMS TABLE
	(
		cantidad int,
		monto decimal,
		usado char
	)
	
	--DIAS ALOJADOS
	DECLARE @dias_alojados INT
	SET @dias_alojados = DATEDIFF(DAY, @fecha_inicio, @fecha_check_out) + 1
			
	INSERT INTO
		@ITEMS(usado, cantidad, monto)
	VALUES
		('S', @dias_alojados, @monto_estadia)		

	--DIAS NO ALOJADOS
	DECLARE @dias_no_alojados INT
	SET @dias_no_alojados = DATEDIFF(DAY, @fecha_check_out, @fecha_fin)
				
	IF(@dias_no_alojados > 0)
	BEGIN
		INSERT INTO
			@ITEMS(usado, cantidad, monto )
		VALUES
			('N', @dias_no_alojados, @monto_estadia)
	END	
	
	--DECLARE @TOTAL_ESTADIA DECIMAL = @monto_estadia * DATEDIFF(DAY, @fecha_inicio, @fecha_fin)
	
	SELECT * FROM @ITEMS	
END
GO




CREATE PROCEDURE HEMINGWAY.SP_FACTURA_GET_DATA
	@codigo_reserva int,
	@fecha_check_out datetime

AS
BEGIN
	DECLARE @monto_estadia DECIMAL = HEMINGWAY.F_MONTO_ESTADIA (@codigo_reserva)
	DECLARE @fecha_inicio DATETIME = ( SELECT R.fecha_inicio FROM HEMINGWAY.RESERVA R WHERE R.codigo = @codigo_reserva )
	DECLARE @fecha_fin DATETIME = ( SELECT R.fecha_fin FROM HEMINGWAY.RESERVA R WHERE R.codigo = @codigo_reserva )

	DECLARE @total_estadia DECIMAL = @monto_estadia * ( DATEDIFF(DAY, @fecha_inicio, @fecha_fin) + 1 )

	DECLARE @total_consumibles DECIMAL = ( SELECT SUM(IC.total * IC.cantidad) FROM HEMINGWAY.F_ITEMS_CONSUMIBLES(@codigo_reserva) IC )
	
	DECLARE @descuento DECIMAL = 0
	
	IF EXISTS ( 
	SELECT * FROM 
		HEMINGWAY.RESERVA R 
	JOIN 
		HEMINGWAY.REGIMEN RE ON R.codigo_regimen = RE.codigo 
	WHERE 
		RE.descripcion = 'All inclusive' AND 
		R.codigo = @codigo_reserva
	)
		SET @descuento = @total_consumibles	
	
	DECLARE @total_factura DECIMAL = @total_estadia + @total_consumibles - @descuento
	
	DECLARE @FACTURA_TEMP TABLE 
	(
		total_consumible decimal (18,2),
		total_estadia decimal (18,2),
		total_descuento decimal (18,2),
		total_factura decimal (18,2)
	)
	
	INSERT INTO 
		@FACTURA_TEMP(total_consumible, total_estadia, total_descuento, total_factura)
	VALUES
		(@total_consumibles, @total_estadia, @descuento, @total_factura)
	
	SELECT * FROM @FACTURA_TEMP

END
GO

CREATE PROCEDURE HEMINGWAY.SP_FACTURA_ADD
	@factura_codigo_reserva int,
	@factura_fecha_check_out datetime,
	@codigo_usuario int,
	@forma_pago VARCHAR(50),
	@numero_tarjeta bigint = null,
	@fecha_caducidad_tarjeta date = null
AS
BEGIN
	BEGIN TRAN
		--numero factura
		DECLARE @numero_factura INT = (select HEMINGWAY.F_MAX_NUMERO_FACTURA()) + 1
		
		--check out
		UPDATE
			HEMINGWAY.ESTADIA
		SET
			fecha_fin = @factura_codigo_reserva
		WHERE
			codigo_reserva = @factura_codigo_reserva
	
		--facturacion
		DECLARE @FACTURA_TEMP TABLE
		(
			total_consumible decimal (18,2),
			total_estadia decimal (18,2),
			total_descuento decimal (18,2),
			total_factura decimal (18,2)
		)
		INSERT INTO
			@FACTURA_TEMP
		EXEC 
			HEMINGWAY.SP_FACTURA_GET_DATA 
				@codigo_reserva = @factura_codigo_reserva,
				@fecha_check_out = @factura_fecha_check_out
		
		-- FACTURA
		INSERT INTO	
			HEMINGWAY.FACTURA (numero, codigo_reserva, fecha, total_consumible, total_descuento, total_estadia)
		SELECT
			@numero_factura, @factura_codigo_reserva, @factura_fecha_check_out, F.total_consumible, F.total_descuento, F.total_estadia
		FROM	
			@FACTURA_TEMP F
		
		--ITEMS CONSUMIBLES
		INSERT INTO	
			HEMINGWAY.ITEM_CONSUMIBLE(numero_factura, codigo_consumible, cantidad, monto)
		SELECT
			@numero_factura, 
			C.codigo,
			C.cantidad,
			C.total 
		FROM
			HEMINGWAY.F_ITEMS_CONSUMIBLES (@factura_codigo_reserva) C

		
		--ITEMS ESTADIA
		DECLARE @ITEMS TABLE
		(
			cantidad int,
			monto decimal,
			usado char
		)
		INSERT INTO
			@ITEMS
		EXEC 
			HEMINGWAY.SP_FACTURA_GET_ITEMS_ESTADIA
				@codigo_reserva = @factura_codigo_reserva,
				@fecha_check_out = @factura_fecha_check_out

		INSERT INTO	
			HEMINGWAY.ITEM_ESTADIA (numero_factura, usado, cantidad, monto)
		SELECT
			@numero_factura, IE.usado, IE.cantidad, IE.monto
		FROM	
			@ITEMS IE	
			
			
		--PAGO FACTURA
		INSERT INTO 
			HEMINGWAY.PAGO_FACTURA(codigo_forma_pago, numero_factura)		
		VALUES
			(@forma_pago, @numero_factura)
		
		--PAGO CON TARJETA				
			
		IF (@forma_pago = 'CREDITO' AND @numero_tarjeta != null AND @fecha_caducidad_tarjeta != NULL) 
		BEGIN
			INSERT INTO 
				HEMINGWAY.TARJETA_CREDITO_DATOS(numero_factura, numero_tarjeta, fecha_caducidad)
			VALUES
				(@numero_factura, @numero_tarjeta, @fecha_caducidad_tarjeta)
		END
		

		
			
		--ACTUALIZAR ESTADO RESERVA
		UPDATE
			HEMINGWAY.RESERVA
		SET
			codigo_estado = 'CHECK_OUT'
		WHERE
			codigo = @factura_codigo_reserva
		
		INSERT INTO
			HEMINGWAY.OPERACIONES_SOBRE_RESERVA 
			(codigo_estado, codigo_reserva, codigo_usuario, fecha)
		VALUES
			('CHECK_OUT', @factura_codigo_reserva, @codigo_usuario, @factura_fecha_check_out)		
		/*	
		--LIBERAR HABITACIONES
		DELETE
			HEMINGWAY.HABITACION_RESERVA
		WHERE
			codigo_reserva = @factura_codigo_reserva
		*/	
	COMMIT TRAN	
END
GO


-------------------------------------------- FORMA PAGO ------------------------------------------

CREATE PROCEDURE HEMINGWAY.SP_FORMA_PAGO_GET
AS
BEGIN
	SELECT
		FP.codigo,
		FP.descripcion
	FROM
		HEMINGWAY.FORMA_DE_PAGO FP
END
GO


---------------------------------------------- LISTADOS -------------------------------------------

CREATE PROCEDURE HEMINGWAY.SP_LISTADO_HOTELES_MAYOR_CANTIDAD_RESERVAS_CANCELADAS
	@fecha_inicio date,
	@fecha_fin date
AS
BEGIN

	SELECT
		H.nombre AS 'Nombre',
		H.ciudad as 'Ciudad',
		H.calle as 'Calle',
		H.numero_calle as 'Nro Calle',
		HOTES_RESERVAS_CANCELADAS.reservas_canceladas as 'Reservas canceladas'		
	FROM 
		HEMINGWAY.HOTEL H
	JOIN
		(SELECT TOP 5
			R.codigo_hotel,
			COUNT(*) as reservas_canceladas
		FROM
			HEMINGWAY.V_RESERVAS_CANCELADAS R
		JOIN
			HEMINGWAY.OPERACIONES_SOBRE_RESERVA OSR ON OSR.codigo_reserva = R.codigo
		WHERE
			OSR.fecha BETWEEN @fecha_inicio AND @fecha_fin
		GROUP BY
			R.codigo_hotel
		ORDER BY
			COUNT(*) DESC) HOTES_RESERVAS_CANCELADAS
	ON
		HOTES_RESERVAS_CANCELADAS.codigo_hotel = H.codigo
END
GO	



CREATE PROCEDURE HEMINGWAY.SP_LISTADO_HOTELES_MAYOR_CANTIDAD_CONSUMIBLES_FACTURADOS
	@fecha_inicio date,
	@fecha_fin date
AS
BEGIN
	SELECT
		H.nombre AS 'Nombre',
		H.ciudad as 'Ciudad',
		H.calle as 'Calle',
		H.numero_calle as 'Nro Calle',
		HOTELES_CONSUMIBLES_FACTURADOS.consumible_cantidad as 'Cantidad consumibles'
				
	FROM 
		HEMINGWAY.HOTEL H
	JOIN
		(
		SELECT TOP 5
			R.codigo_hotel,
			SUM(IC.cantidad) AS consumible_cantidad
		FROM
			HEMINGWAY.FACTURA F
		JOIN
			HEMINGWAY.RESERVA R ON R.codigo = F.codigo_reserva
		JOIN
			HEMINGWAY.ITEM_CONSUMIBLE IC ON IC.numero_factura = F.numero		
		WHERE
			F.fecha BETWEEN @fecha_inicio AND @fecha_fin
		GROUP BY
			R.codigo_hotel			
		ORDER BY
			SUM(IC.cantidad) DESC			
		) HOTELES_CONSUMIBLES_FACTURADOS
	ON
		HOTELES_CONSUMIBLES_FACTURADOS.codigo_hotel = H.codigo
END
GO


CREATE PROCEDURE HEMINGWAY.SP_LISTADO_HOTELES_MAYOR_CANTIDAD_DIAS_FUERA_DE_SERVICIO
	@fecha_inicio date,
	@fecha_fin date
AS
BEGIN

	SELECT
		H.ciudad as 'Ciudad',
		H.calle as 'Calle',
		H.numero_calle as 'Nro Calle',
		--h.codigo,
		DIAS_CERRADOS_ACUMULADOS.cant_dias_cerrado AS 'Días cerrados en el período'
				
	FROM 
		HEMINGWAY.HOTEL H
	JOIN(
		
		SELECT
			DIAS_CERRADOS.codigo_hotel,
			SUM(DIAS_CERRADOS.dias_cerrados) AS cant_dias_cerrado
		FROM (	
				SELECT
					HC.codigo_hotel,
					DATEDIFF(DAY, HC.fecha_inicio, HC.fecha_fin) + 1 AS dias_cerrados
				FROM
					HEMINGWAY.HOTEL_CERRADO HC
				WHERE
					(HC.fecha_inicio between @fecha_inicio and @fecha_fin) and
					(hc.fecha_fin between @fecha_inicio and @fecha_fin) 
			UNION ALL
				SELECT
					HC.codigo_hotel,
					DATEDIFF(DAY, HC.fecha_inicio, @fecha_fin) + 1 AS dias_cerrados
				FROM
					HEMINGWAY.HOTEL_CERRADO HC
				WHERE
					(HC.fecha_inicio between @fecha_inicio and @fecha_fin) and
					(hc.fecha_fin not between @fecha_inicio and @fecha_fin) 
			UNION ALL
				SELECT
					HC.codigo_hotel,
					DATEDIFF(DAY, @fecha_inicio, HC.fecha_fin) + 1 AS dias_cerrados
				FROM
					HEMINGWAY.HOTEL_CERRADO HC
				WHERE
					(HC.fecha_inicio not between @fecha_inicio and @fecha_fin) and
					(hc.fecha_fin between @fecha_inicio and @fecha_fin) 
			UNION ALL
				SELECT
					HC.codigo_hotel,
					DATEDIFF(DAY, @fecha_inicio, @fecha_fin) + 1 AS dias_cerrados
				FROM
					HEMINGWAY.HOTEL_CERRADO HC
				WHERE
					(@fecha_inicio between HC.fecha_inicio and HC.fecha_fin) and
					(@fecha_fin between HC.fecha_inicio and HC.fecha_fin) 
				
			)DIAS_CERRADOS
		GROUP BY
			DIAS_CERRADOS.codigo_hotel
	)DIAS_CERRADOS_ACUMULADOS	
	ON
		DIAS_CERRADOS_ACUMULADOS.codigo_hotel = H.codigo
END
GO


CREATE PROCEDURE HEMINGWAY.SP_LISTADO_HABITACIONES_CON_MAYOR_CANTIDAD_DIAS_Y_VECES_OCUPADAS
	@fecha_inicio date,
	@fecha_fin date
AS
BEGIN
	SELECT TOP 5
		H.nombre AS 'Nombre Hotel',
		H.ciudad as 'Ciudad',
		H.calle as 'Calle',
		H.numero_calle as 'Nro Calle',
		HA.numero AS 'Numero habitación',
		DIAS_USADOS_SUMADOS.cant_dias_usados as 'Cantidad de dias ocupados'
	FROM
		HEMINGWAY.HOTEL H
	JOIN
		HEMINGWAY.HABITACION HA ON HA.codigo_hotel = H.codigo
	JOIN
		(
		SELECT
			DIAS_USADOS.codigo,
			SUM(DIAS_USADOS.dias_usados ) AS cant_dias_usados
		FROM (				
				SELECT
					H.codigo,
					DATEDIFF(DAY, R.fecha_inicio, R.fecha_fin) + 1 AS dias_usados
				FROM
					HEMINGWAY.HABITACION H
				JOIN
					HEMINGWAY.HABITACION_RESERVA HR ON HR.codigo_habitacion = H.codigo
				JOIN
					HEMINGWAY.V_RESERVA_NO_CANCELADA R ON R.codigo = HR.codigo_reserva
				WHERE
					(R.fecha_inicio between @fecha_inicio and @fecha_fin) and
					(R.fecha_fin between @fecha_inicio and @fecha_fin) 
			UNION ALL
				SELECT
					H.codigo,
					DATEDIFF(DAY, R.fecha_inicio, @fecha_fin) + 1 AS dias_cerrados
				FROM
					HEMINGWAY.HABITACION H
				JOIN
					HEMINGWAY.HABITACION_RESERVA HR ON HR.codigo_habitacion = H.codigo
				JOIN
					HEMINGWAY.V_RESERVA_NO_CANCELADA R ON R.codigo = HR.codigo_reserva
				WHERE
					(R.fecha_inicio between @fecha_inicio and @fecha_fin) and
					(R.fecha_fin not between @fecha_inicio and @fecha_fin) 
			UNION ALL
				SELECT
					H.codigo,
					DATEDIFF(DAY, @fecha_inicio, R.fecha_fin) + 1 AS dias_cerrados
				FROM
					HEMINGWAY.HABITACION H
				JOIN
					HEMINGWAY.HABITACION_RESERVA HR ON HR.codigo_habitacion = H.codigo
				JOIN
					HEMINGWAY.V_RESERVA_NO_CANCELADA R ON R.codigo = HR.codigo_reserva
				WHERE
					(R.fecha_inicio not between @fecha_inicio and @fecha_fin) and
					(R.fecha_fin between @fecha_inicio and @fecha_fin) 
			UNION ALL
				SELECT
					H.codigo,
					DATEDIFF(DAY, @fecha_inicio, @fecha_fin) + 1 AS dias_cerrados
				FROM
					HEMINGWAY.HABITACION H
				JOIN
					HEMINGWAY.HABITACION_RESERVA HR ON HR.codigo_habitacion = H.codigo
				JOIN
					HEMINGWAY.V_RESERVA_NO_CANCELADA R ON R.codigo = HR.codigo_reserva
				WHERE
					(@fecha_inicio between R.fecha_inicio and R.fecha_fin) and
					(@fecha_fin between R.fecha_inicio and R.fecha_fin) 
			)
			DIAS_USADOS
		GROUP BY
			DIAS_USADOS.codigo
		)DIAS_USADOS_SUMADOS
		ON
			DIAS_USADOS_SUMADOS.codigo = HA.codigo
		ORDER BY
			DIAS_USADOS_SUMADOS.cant_dias_usados DESC
END
GO


CREATE PROCEDURE HEMINGWAY.SP_LISTADO_CLIENTE_CON_MAYOR_CANTIDAD_DE_PUNTOS
	@fecha_inicio date,
	@fecha_fin date
AS
BEGIN		
	SELECT TOP 5
		C.apellido AS 'Apellido',
		C.nombre AS 'Nombre',
		C.mail AS 'Mail',
		TOTALES.TOTAL_ESTADIAS AS 'Total facturado en estadias',
		TOTALES.TOTAL_CONSUMIBLES AS 'Total facturado en consumibles',
		cast((TOTALES.TOTAL_PUNTOS) as int)  AS 'Total puntos'
	FROM
		(
		SELECT
			C.codigo AS CODIGO_CLIENTE,
			SUM(F.total_estadia) AS TOTAL_ESTADIAS,
			SUM(F.total_consumible) AS TOTAL_CONSUMIBLES,
			(SUM(F.total_estadia) / 10) + (SUM(F.total_consumible) / 5) AS TOTAL_PUNTOS
		FROM
			HEMINGWAY.FACTURA F
		JOIN
			HEMINGWAY.RESERVA R ON R.codigo = F.codigo_reserva
		JOIN
			HEMINGWAY.CLIENTE C ON R.codigo_cliente = C.codigo
		WHERE
			F.fecha BETWEEN @fecha_inicio AND @fecha_fin
		GROUP BY
			C.codigo
		) TOTALES	
	JOIN
		HEMINGWAY.CLIENTE C
	ON
		C.codigo = TOTALES.CODIGO_CLIENTE
	ORDER BY
		TOTALES.TOTAL_PUNTOS DESC
END		
GO	
	
	
/*************************************************************************************
*                    DATOS ADICIONALES                                               *
**************************************************************************************/



-- USUARIOS DEFAULT ( PASSWORD = USERNAME )

-- UN USARIO ADMINISTRADOR

exec HEMINGWAY.SP_USUARIO_ADD 
	@username = 'admin', 
	@password = '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918',
	@nombre = 'admin',
	@apellido = 'a',
	@fecha_nacimiento = '2015-01-10',
	@telefono = 'a',
	@mail = 'a',
	@direccion = 'a'
GO
/*
exec HEMINGWAY.SP_USUARIO_ADD 
	@username = 'admin', 
	@password = '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918',
	@nombre = 'admin',
	@apellido = 'admin',
	@fecha_nacimiento = '2015-01-10',
	@telefono = 'admin',
	@mail = 'admin',
	@direccion = 'admin'
*/
	
-- UN USUARIO GUEST 

exec HEMINGWAY.SP_USUARIO_ADD
	@username = 'guest', 
	@password = 'guest',
	@nombre = 'guest',
	@apellido = 'guest',
	@fecha_nacimiento = '2015-01-10',
	@telefono = 'guest',
	@mail = 'guest',
	@direccion = 'guest'
GO
-- UN USUARIO RECEPCIONISTA 
exec HEMINGWAY.SP_USUARIO_ADD
	@username = 'rec', 
	@password = 'cb41b38387d6fca01272be03380f63568fccbd724c299ae58e8d548d91b67a58',
	@nombre = 'rec',
	@apellido = 'rec',
	@fecha_nacimiento = '2015-01-10',
	@telefono = 'rec',
	@mail = 'rec',
	@direccion = 'rec'

-- ROLES

GO
INSERT INTO 
	HEMINGWAY.ROL(descripcion)
VALUES 
	('administrador'),
	('recepcionista'),
	('guest')


-- FUNCIONALIDADES
GO
INSERT INTO 
	HEMINGWAY.FUNCIONALIDAD(codigo, descripcion)
VALUES 
	('abm_rol', 'abm rol'), --administrador
	('abm_usuario', 'abm usuario'),--administrador	
	('abm_cliente', 'abm cliente'), --recepcionista	
	('abm_hotel', 'abm hotel'), --administrador
	('abm_regimen', 'abm regimen'), --administrador
	('abm_reserva', 'abm reserva'), --recepcionista y guest
	('registrar_estadia', 'registrar estadia'), --recepcionista
	('listados_estadisticos', 'listados estadísticos') --administrador
	
-- ASIGNACION DE FUNCIONALIDADES
GO
INSERT INTO 
	HEMINGWAY.ROL_FUNCIONALIDAD (codigo_rol, codigo_funcionalidad)
VALUES 
	( (select HEMINGWAY.F_GET_ID_ROL('administrador')), 'abm_rol' ),
	( (select HEMINGWAY.F_GET_ID_ROL('administrador')), 'abm_usuario' ),
	( (select HEMINGWAY.F_GET_ID_ROL('administrador')), 'abm_hotel' ),
	( (select HEMINGWAY.F_GET_ID_ROL('administrador')), 'abm_regimen' ),
	( (select HEMINGWAY.F_GET_ID_ROL('administrador')), 'abm_rol' ),
	( (select HEMINGWAY.F_GET_ID_ROL('recepcionista')), 'abm_cliente' ),
	( (select HEMINGWAY.F_GET_ID_ROL('recepcionista')), 'abm_reserva' ),
	( (select HEMINGWAY.F_GET_ID_ROL('recepcionista')), 'registrar_estadia' ),
	( (select HEMINGWAY.F_GET_ID_ROL('administrador')), 'listados_estadisticos' ),
	( (select HEMINGWAY.F_GET_ID_ROL('guest')), 'abm_reserva' )	
	
-- ASIGNACION DE ROLES
GO
INSERT INTO 
	HEMINGWAY.USUARIO_ROL(codigo_rol, codigo_usuario)
VALUES 
	( (select HEMINGWAY.F_GET_ID_ROL('administrador')), (select HEMINGWAY.F_GET_ID_USUARIO('admin')) ),
	( (select HEMINGWAY.F_GET_ID_ROL('recepcionista')), (select HEMINGWAY.F_GET_ID_USUARIO('rec')) ),
	( (select HEMINGWAY.F_GET_ID_ROL('guest')), (select HEMINGWAY.F_GET_ID_USUARIO('guest')) )

-- TIPO IDENTIFICACION
GO
INSERT INTO	
	HEMINGWAY.TIPO_IDENTIFICACION(codigo, descripcion)
VALUES
	('DOCUMENTO','Documento'),
	('PASAPORTE','Pasaporte')

-- ESTADOS RESERVA

GO
INSERT INTO	
	HEMINGWAY.RESERVA_ESTADO (descripcion, codigo)
VALUES
	('Reserva correcta. No efectivizada', 'INSERT'),
	('Reserva modificada. No efectivizada', 'UPDATE'),
	('Reserva cancelada', 'CANCEL'),
	('Reserva cancelada por no show', 'NO_SHOW'),
	('Reserva con ingreso', 'CHECK_IN'),
	('Reserva finalizada', 'CHECK_OUT')
	
	
-- FORMAS DE PAGO
GO
INSERT INTO	
	HEMINGWAY.FORMA_DE_PAGO(codigo, descripcion)
VALUES
	('EFECTIVO' , 'Pago en efectivo'),
	('CREDITO' , 'Pago con tarjeta de crédito')

	
-- NACIONALIDADES Y PAICES
GO
INSERT INTO	
	HEMINGWAY.PAISES_NACIONALIDADES (nacionalidad, pais)
VALUES
	('ALBANO',	'ALBANIA'),
	('ANDORRANO',	'ANDORRA'),
	('BELGA',	'BELGICA'),
	('BOSNIO',	'BOSNIA-HERZEGOVINA'),
	('BRITANICO',	'REINO UNIDO'),
	('BULGARO',	'BULGARIA'),
	('DANES',	'DINAMARCA'),
	('ALEMAN',	'ALEMANIA'),
	('ESTONIO',	'ESTONIA'),
	('FINES',	'FINLANDIA'),
	('FRANCES',	'FRANCIA'),
	('GRIEGO',	'GRECIA'),
	('IRLANDES',	'IRLANDA'),
	('ISLANDES',	'ISLANDIA'),
	('ITALIANO',	'ITALIA'),
	('CROATA',	'CROACIA'),
	('LETONIO',	'LETONIA'),
	('LIECHTENSTEINIANO',	'LIECHTENSTEIN'),
	('LITUANO',	'LITUANIA'),
	('LUXEMBURGES',	'LUXEMBURGO'),
	('MALTES',	'MALTA'),
	('MACEDONIO',	'MACEDONIA'),
	('MOLDAVO',	'MOLDAVIA'),
	('MONAQUES',	'MONACO'),
	('MONTENEGRINO',	'MONTENEGRO'),
	('HOLANDES',	'PAISES BAJOS'),
	('NORUEGO',	'NORUEGA'),
	('AUSTRIACO',	'AUSTRIA'),
	('POLACO',	'POLONIA'),
	('PORTUGUES',	'PORTUGAL'),
	('RUMANO',	'RUMANIA'),
	('RUSO',	'RUSIA'),
	('SANMARINENSE',	'SAN MARINO'),
	('SUECO',	'SUECIA'),
	('SUIZO',	'SUIZA'),
	('SERBIO',	'SERBIA'),
	('ESLOVACO',	'ESLOVAQUIA'),
	('ESLOVACO',	'ESLOVENIA'),
	('ESPAÑOL',	'ESPAÑA'),
	('CHECO',	'CHEQUIA'),
	('TURCO',	'TURQUIA'),
	('UCRANIANO',	'UCRANIA'),
	('HUNGARO',	'HUNGRIA'),
	('VATICANO',	'VATICANO'),
	('BIELORUSO',	'BIELORRUSIA'),
	('GRECO-CHIPRIOTA',	'CHIPRE (PARTE GRIEGA)'),
	('CHIPRIOTA',	'CHIPRE'),
	('AMERICANO',	'EEUU'),
	('ANTIGUANO',	'ANTIGUA Y BARBUDA'),
	('ARGENTINO',	'ARGENTINA'),
	('BAHAMEÑO',	'BAHAMAS'),
	('BARBADENSE',	'BARBADOS'),
	('BELICEÑO',	'BELICE'),
	('BOLIVIANO',	'BOLIVIA'),
	('BRASILEÑO',	'BRASIL'),
	('COSTARRICENSE',	'COSTA RICA'),
	('CHILENO',	'CHILE'),
	('DOMINIQUES',	'DOMINICA'),
	('DOMINICANO',	'REPUBLICA DOMINICANA'),
	('ECUATORIANO',	'ECUADOR'),
	('GRANADINO',	'GRANADA'),
	('GROENLANDES',	'GROENLANDIA'),
	('GUATEMALTECO',	'GUATEMALA'),
	('GUAÑANO',	'GUAYANA'),
	('HAITIANO',	'HAITI'),
	('HONDUREÑO',	'HONDURAS'),
	('JAMAICANO',	'JAMAICA'),
	('CANADIENSE',	'CANADA'),
	('COLOMBIANO',	'COLOMBIA'),
	('CUBANO',	'CUBA'),
	('MEXICANO',	'MEXICO,'),
	('NICARAGUENSE',	'NICARAGUA'),
	('PANAMEÑO',	'PANAMA'),
	('PARAGUAYO',	'PARAGUAY'),
	('PERUANO',	'PERU'),
	('SALVADOREÑO',	'EL SALVADOR'),
	('SURINAMES',	'SURINAM, SURINAME'),
	('URUGUAYO',	'URUGUAY'),
	('VENEZOLANO',	'VENEZUELA'),
	('SANVICENTINO',	'SAN VICENTE Y LAS GRANADINAS'),
	('EGIPCIO',	'EGIPTO'),
	('ARGELINO',	'ARGELIA'),
	('ANGOLANO',	'ANGOLA'),
	('ECUATOGUINEANO',	'GUINEA ECUATORIAL'),
	('ETIOPE',	'ETIOPIA'),
	('BENINES',	'BENIN'),
	('BOTSUANO',	'BOTSWANA'),
	('BURKINES',	'BURKINA FASO'),
	('BURUNDES',	'BURUNDI'),
	('ERITREO',	'ERITREA'),
	('GABONES',	'GABON'),
	('GAMBIANO',	'GAMBIA'),
	('GHANES',	'GHANA'),
	('GUINEANO',	'GUINEA-BISSAU'),
	('GUINEANO',	'GUINEA'),
	('MARFILEÑO',	'COSTA DE MARFIL'),
	('CAMERUNES',	'CAMERUN'),
	('CABOVERDIANO',	'ISLAS DE CABO VERDE'),
	('KENIATA',	'KENIA'),
	('COMORENSE',	'COMORES'),
	('CONGOLEÑO',	'CONGO'),
	('LAOSIANO',	'LAOS'),
	('LESOTENSE',	'LESOTO'),
	('LIBANES',	'LIBANO'),
	('LIBERIANO',	'LIBERIA'),
	('LIBIO',	'LIBIA'),
	('MALGACHE',	'MADAGASCAR'),
	('MALAUI',	'MALAUI'),
	('MALIENSE',	'MALI'),
	('MARROQUI',	'MARRUECOS'),
	('MAURITANO',	'MAURITANIA'),
	('MAURICIANO',	'MAURICIO'),
	('MOZAMBIQUEÑO',	'MOZAMBIQUE'),
	('NAMIBIO',	'NAMBIA'),
	('NIGERIANO',	'NIGER'),
	('RUANDES',	'RUANDA'),
	('ZAMBIANO',	'ZAMBIA'),
	('SENEGALES',	'SENEGAL'),
	('SEYCHELENSE',	'SEYCHELLES'),
	('SIERRALEONES',	'SIERRA LEONA'),
	('ZIMBABUENSE',	'ZIMBABUE'),
	('SOMALI',	'SOMALIA'),
	('SUDAFRICANO',	'SUDAFRICA'),
	('SUDANES',	'SUDAN'),
	('SUAZI',	'SUAZILANDIA'),
	('TANZANO',	'TANZANIA'),
	('TOGOLES',	'TOGO'),
	('CHADIANO',	'CHAD'),
	('TUNECINO',	'TUNEZ'),
	('UGANDES',	'UGANDA'),
	('CENTROAFRICANO',	'REPUBLICA CENTROAFRICANA'),
	('AFGANO',	'AFGANISTAN'),
	('ARMENIO',	'ARMENIA'),
	('AZERBAIYANO',	'AZERBAIYAN'),
	('BAREINI',	'BAHREIN'),
	('BANGLADESI',	'BANGLADESH'),
	('BRUNEANO',	'BRUNEI'),
	('CHINO',	'CHINA'),
	('GEORGIANO',	'GEORGIA'),
	('INDIO',	'INDIA'),
	('INDIONISIO',	'INDONESIA'),
	('IRAQUI',	'IRAK'),
	('IRANI',	'IRAN'),
	('ISRALI',	'ISRAEL'),
	('JAPONES',	'JAPON'),
	('JEMETI',	'YEMEN'),
	('JORDANO',	'JORDANIA'),
	('CAMBOYANO',	'CAMBOYA'),
	('KAZAJO',	'KAZAJSTAN'),
	('KATARI',	'QATAR'),
	('KIRGUIS',	'KIRGUISTAN'),
	('KUWAITI',	'KUWAIT'),
	('MALAYO',	'MALASIA'),
	('MALDIVO',	'MALDIVAS'),
	('MONGOL',	'MONGOLIA'),
	('BIRMANO',	'BIRMANIA, MYANMAR'),
	('NORCOREANO',	'COREA DEL NORTE'),
	('OMANES',	'OMAN'),
	('PAKISTANI',	'PAQUISTAN'),
	('FILIPINO',	'FILIPINAS'),
	('SAUDI',	'ARABIA SAUDI, ARABIA SAUDITA'),
	('SINGAPURENSE',	'SINGAPUR'),
	('CEILANDES',	'SRI LANKA'),
	('SURCOREANO',	'COREA DEL SUR'),
	('SIRIO',	'SIRIA'),
	('TAILANDES',	'TAILANDIA'),
	('TIMORENSE',	'TIMOR ORIENTAL'),
	('UZBECO',	'UZBEKISTAN'),
	('VIETNAMITA',	'VIETNAM'),
	('AUSTRALIANO',	'AUSTRALIA'),
	('KIRIBATIANO',	'KIRIBATI'),
	('MARSHALES',	'ISLAS MARSHALL'),
	('NAURUANO',	'NAURU'),
	('NEOZELANDES',	'NUEVA ZELANDA'),
	('NIUANO',	'NIUE'),
	('PAPU',	'PAPUA NUEVA GUINEA'),
	('SALOMONENSE',	'ISLAS SALOMON'),
	('SAMOANO',	'SAMOA'),
	('TONGANO',	'TONGA'),
	('TUVALUANO',	'TUVALU'),
	('VANUATUENSE',	'VANUATU')
GO		
	
	
	
/*************************************************************************************
*                    MIGRACION TABLA MAESTRA                                         *
**************************************************************************************/

-- CONSUMIBLE

INSERT INTO
	HEMINGWAY.CONSUMIBLE (codigo, descripcion, precio)
SELECT DISTINCT top 500
	M.Consumible_Codigo, M.Consumible_Descripcion, M.Consumible_Precio
FROM
	gd_esquema.Maestra M
WHERE
	M.Consumible_Codigo IS NOT NULL AND
	M.Consumible_Descripcion IS NOT NULL AND
	M.Consumible_Precio IS NOT NULL
GO	

-- REGIMEN

INSERT INTO
	HEMINGWAY.REGIMEN (descripcion, precio)
SELECT DISTINCT 
	M.Regimen_Descripcion, M.Regimen_Precio
FROM
	gd_esquema.Maestra M
GO
	
-- TIPO HABITACION

INSERT INTO
	HEMINGWAY.TIPO_HABITACION(codigo, descripcion, porcentual)
SELECT DISTINCT 
	M.Habitacion_Tipo_Codigo, M.Habitacion_Tipo_Descripcion, M.Habitacion_Tipo_Porcentual
FROM
	gd_esquema.Maestra M
GO

-- HOTEL

INSERT INTO
	HEMINGWAY.HOTEL (ciudad, calle, numero_calle, cantidad_estrellas, recarga_estrella, pais, nombre)
SELECT DISTINCT 
	RTRIM(M.Hotel_Ciudad), RTRIM(M.Hotel_Calle), M.Hotel_Nro_Calle, M.Hotel_CantEstrella, M.Hotel_Recarga_Estrella, 'ARGENTINA', RTRIM(M.Hotel_Ciudad) + ' - ' + RTRIM(M.Hotel_Calle) + ' ' + CAST(M.Hotel_Nro_Calle AS VARCHAR) 
FROM
	gd_esquema.Maestra M
WHERE
	M.Hotel_Ciudad IS NOT NULL AND
	M.Hotel_Calle IS NOT NULL AND
	M.Hotel_Nro_Calle IS NOT NULL AND
	M.Hotel_CantEstrella IS NOT NULL AND
	M.Hotel_Recarga_Estrella IS NOT NULL
GO

-- REGIMEN HOTEL

INSERT INTO
	HEMINGWAY.HOTEL_REGIMEN (codigo_hotel, codigo_regimen)
SELECT DISTINCT	
	H.codigo AS codigo_hotel,
	R.codigo AS codigo_regimen
FROM
	gd_esquema.Maestra M
JOIN
	HEMINGWAY.HOTEL H
ON
	M.Hotel_Ciudad = H.ciudad AND
	M.Hotel_Calle = H.calle AND
	M.Hotel_Nro_Calle = H.numero_calle --AND
	--M.Hotel_CantEstrella = H.cantidad_estrellas AND
	--M.Hotel_Recarga_Estrella = H.recarga_estrella
JOIN
	HEMINGWAY.REGIMEN R
ON
	M.Regimen_Descripcion = R.descripcion AND
	M.Regimen_Precio = R.precio																
GO


-- HABITACION HOTEL

INSERT INTO
	HEMINGWAY.HABITACION (codigo_hotel, numero, frente, piso, codigo_tipo_habitacion)
SELECT DISTINCT	
	H.codigo AS codigo_hotel,
	M.Habitacion_Numero, M.Habitacion_Frente, M.Habitacion_Piso, M.Habitacion_Tipo_Codigo														
FROM
	gd_esquema.Maestra M
JOIN
	HEMINGWAY.HOTEL H
ON
	M.Hotel_Ciudad = H.ciudad AND
	M.Hotel_Calle = H.calle AND
	M.Hotel_Nro_Calle = H.numero_calle --AND
	--M.Hotel_CantEstrella = H.cantidad_estrellas AND
	--M.Hotel_Recarga_Estrella = H.recarga_estrella

-- CLIENTE
INSERT INTO
	HEMINGWAY.CLIENTE (
		apellido, 
		nombre, 
		fecha_nac, 
		mail, 
		codigo_nacionalidad, 
		codigo_tipo_identificacion, 
		identificacion, 
		calle,
		numero_calle,
		piso,
		departamento)
SELECT DISTINCT
	M.Cliente_Apellido, 
	M.Cliente_Nombre, 
	M.Cliente_Fecha_Nac, 
	M.Cliente_Mail,
	M.Cliente_Nacionalidad,
	'PASAPORTE', -- CODIGO TIPO_IDENTIFICACION PASARTE
	M.Cliente_Pasaporte_Nro,
	M.Cliente_Dom_Calle,
	M.Cliente_Nro_Calle,
	M.Cliente_Piso,
	M.Cliente_Depto	
FROM
	gd_esquema.Maestra M
GO




-- RESERVA


INSERT INTO	
	HEMINGWAY.RESERVA(codigo, fecha_inicio, fecha_fin, codigo_cliente, codigo_hotel, codigo_regimen)
SELECT DISTINCT
	M.Reserva_Codigo,	
	M.Reserva_Fecha_Inicio,
	DATEADD(day, M.Reserva_Cant_Noches, M.Reserva_Fecha_Inicio) AS fecha_fin,
	C.codigo AS codigo_cliente,
	H.codigo AS codigo_hotel,
	R.codigo
FROM
	gd_esquema.Maestra M
JOIN
	HEMINGWAY.CLIENTE C
ON
	C.apellido = M.Cliente_Apellido AND
	c.nombre =  M.Cliente_Nombre AND
	C.fecha_nac = M.Cliente_Fecha_Nac AND
	C.mail = M.Cliente_Mail AND
	C.codigo_nacionalidad =  M.Cliente_Nacionalidad AND
	C.identificacion = Cliente_Pasaporte_Nro AND
	C.calle = M.Cliente_Dom_Calle AND
	C.numero_calle = M.Cliente_Nro_Calle AND
	C.piso = M.Cliente_Piso AND
	C.departamento = Cliente_Depto
JOIN
	HEMINGWAY.HOTEL H
ON
	M.Hotel_Ciudad = H.ciudad AND
	M.Hotel_Calle = H.calle AND
	M.Hotel_Nro_Calle = H.numero_calle AND
	M.Hotel_CantEstrella = H.cantidad_estrellas AND
	M.Hotel_Recarga_Estrella = H.recarga_estrella
JOIN
	HEMINGWAY.REGIMEN R
ON
	M.Regimen_Descripcion = R.descripcion AND
	M.Regimen_Precio = R.precio		
ORDER BY
	M.Reserva_Codigo
GO	



-- ESTADO CHECK IN -- RESERVAS CON ESTADIAS NO FINALIZADAS -- RESULTADO 0	

/*SELECT DISTINCT
	E.codigo_reserva,
	F.numero
FROM
	HEMINGWAY.ESTADIA E 
LEFT JOIN
	HEMINGWAY.FACTURA F ON F.codigo_reserva = E.codigo_reserva
WHERE
	F.numero IS NULL
GO*/
	
-- ESTADO CHECK OUT -- RESERVAS FINALIZADAS



	

-- HABITACION RESERVA
INSERT INTO	
	HEMINGWAY.HABITACION_RESERVA (codigo_reserva, codigo_habitacion)
SELECT DISTINCT 
	M.Reserva_Codigo AS codigo_reserva,	H.codigo AS codigo_habitacion
FROM
	gd_esquema.Maestra M
JOIN
	HEMINGWAY.RESERVA R
ON
	R.codigo = M.Reserva_Codigo
JOIN
	HEMINGWAY.HABITACION H
ON
	H.codigo_hotel = R.codigo_hotel AND
	H.numero = M.Habitacion_Numero
ORDER BY
	M.Reserva_Codigo
GO


-- ESTADIA
INSERT INTO	
	HEMINGWAY.ESTADIA (codigo_reserva, fecha_inicio, fecha_fin, cantidad_noches)
SELECT DISTINCT 
	M.Reserva_Codigo, M.Estadia_Fecha_Inicio, DATEADD(day, M.Estadia_Cant_Noches, M.Estadia_Fecha_Inicio) as fecha_fin, M.Estadia_Cant_Noches
FROM
	gd_esquema.Maestra M
WHERE
	M.Estadia_Fecha_Inicio IS NOT NULL AND
	M.Estadia_Cant_Noches IS NOT NULL
GO	

	
-- CLIENTE - ESTADIA 
INSERT INTO
	HEMINGWAY.CLIENTE_ESTADIA(codigo_reserva, codigo_cliente)
SELECT DISTINCT 
	M.Reserva_Codigo, C.codigo
FROM
	gd_esquema.Maestra M
JOIN
	HEMINGWAY.CLIENTE C
ON
	C.apellido = M.Cliente_Apellido AND
	c.nombre =  M.Cliente_Nombre AND
	C.fecha_nac = M.Cliente_Fecha_Nac AND
	C.mail = M.Cliente_Mail AND
	C.codigo_nacionalidad =  M.Cliente_Nacionalidad AND
	C.identificacion = Cliente_Pasaporte_Nro AND
	C.calle = M.Cliente_Dom_Calle AND
	C.numero_calle = M.Cliente_Nro_Calle AND
	C.piso = M.Cliente_Piso AND
	C.departamento = Cliente_Depto
JOIN
	HEMINGWAY.ESTADIA E ON M.Reserva_Codigo = E.codigo_reserva
GO




-- CONSUMIBLE - ESTADIA
INSERT INTO
	HEMINGWAY.ESTADIA_CONSUMIBLE(codigo_reserva, codigo_consumible)
SELECT DISTINCT 
	M.Reserva_Codigo,	
	M.Consumible_Codigo
FROM
	gd_esquema.Maestra M
WHERE
	M.Consumible_Codigo IS NOT NULL AND
	M.Consumible_Descripcion IS NOT NULL AND
	M.Consumible_Precio IS NOT NULL
ORDER BY
	M.Reserva_Codigo
GO	


-- ESTADOS RESERVA EN BASE A ESTADIAS

-- ESTADO INSERT -- RESERVAS SIN ESTADIAS


UPDATE
	HEMINGWAY.RESERVA
SET
	codigo_estado = 'CHECK_OUT'
WHERE
	codigo IN
	(SELECT DISTINCT
		R.codigo 
	FROM
		HEMINGWAY.RESERVA R
	JOIN
		HEMINGWAY.ESTADIA E ON R.codigo = E.codigo_reserva
	WHERE
		E.codigo_reserva IS NOT NULL)
GO	

UPDATE
	HEMINGWAY.RESERVA
SET
	codigo_estado = 'INSERT'
WHERE
	codigo IN
	(SELECT DISTINCT
		R.codigo
	FROM
		HEMINGWAY.RESERVA R
	LEFT JOIN
		HEMINGWAY.ESTADIA E ON R.codigo = E.codigo_reserva
	WHERE
		E.codigo_reserva IS NULL)
GO
		
-- FACTURA

-- FACTURAS SIN DESCUENTO

INSERT INTO	
	HEMINGWAY.FACTURA(codigo_reserva, numero, fecha, total_consumible, total_estadia, total_descuento)
SELECT 
	M.Reserva_Codigo,
	M.Factura_Nro,
	M.Factura_Fecha,
	M.Factura_Total AS total_consumible,
	m.Item_Factura_Monto * M.Estadia_Cant_Noches AS total_estadia,
	0 AS descuento
FROM
	gd_esquema.Maestra M
WHERE
	M.Factura_Nro IS NOT NULL AND
	M.Factura_Fecha IS NOT NULL AND
	M.Factura_Total IS NOT NULL AND
	M.Consumible_Codigo IS NULL AND
	M.Regimen_Descripcion <> 'All inclusive'
--ORDER BY 
--	M.Factura_Nro, m.Factura_Fecha
GO
	
-- FACTURAS CON DESCUENTO
INSERT INTO	
	HEMINGWAY.FACTURA(codigo_reserva, numero, fecha, total_consumible, total_estadia, total_descuento)
SELECT 
	M.Reserva_Codigo,
	M.Factura_Nro,
	M.Factura_Fecha,
	M.Factura_Total AS total_consumible,
	m.Item_Factura_Monto * M.Estadia_Cant_Noches AS total_estadia,
	m.Factura_Total AS descuento
FROM
	gd_esquema.Maestra M
WHERE
	M.Factura_Nro IS NOT NULL AND
	M.Factura_Fecha IS NOT NULL AND
	M.Factura_Total IS NOT NULL AND
	M.Consumible_Codigo IS NULL AND
	M.Regimen_Descripcion = 'All inclusive'
--ORDER BY 
--	M.Factura_Nro, m.Factura_Fecha
GO

-- ITEM ESTADIA USADAS

INSERT INTO	
	HEMINGWAY.ITEM_ESTADIA(numero_factura, usado, monto, cantidad)
SELECT 
	M.Factura_Nro,
	'S' AS usado,
	M.Item_Factura_Monto AS monto,
	M.Estadia_Cant_Noches AS cantidad
FROM
	gd_esquema.Maestra M
WHERE
	M.Factura_Nro IS NOT NULL AND
	M.Consumible_Codigo IS NULL
ORDER BY
	M.Factura_Nro		
GO	
	
-- ITEM ESTADIA NO USADAS (0 RESULTADO EN TABLA MAESTRA)	
INSERT INTO	
	HEMINGWAY.ITEM_ESTADIA(numero_factura, usado, monto, cantidad)
SELECT 
	M.Factura_Nro,
	'N' AS usado,
	M.Item_Factura_Monto AS monto,
	M.Reserva_Cant_Noches - M.Estadia_Cant_Noches AS cantidad
FROM
	gd_esquema.Maestra M
WHERE
	M.Factura_Nro IS NOT NULL AND
	M.Consumible_Codigo IS NULL AND
	M.Reserva_Cant_Noches <> M.Estadia_Cant_Noches	
ORDER BY
	M.Factura_Nro	
GO

-- ITEM COMSUMIBLE

INSERT INTO	
	HEMINGWAY.ITEM_CONSUMIBLE (numero_factura, codigo_consumible, monto, cantidad)
SELECT 
	M.Factura_Nro AS numero_factura,
	M.Consumible_Codigo AS codigo_consumible,
	M.Item_Factura_Monto As monto,
	SUM(M.Item_Factura_Cantidad) AS cantidad
FROM
	gd_esquema.Maestra M
WHERE
	M.Factura_Nro IS NOT NULL AND
	M.Consumible_Codigo IS NOT NULL
GROUP BY
	M.Factura_Nro, M.Consumible_Codigo, m.Consumible_Precio, M.Item_Factura_Monto
--ORDER BY
--	M.Factura_Nro	
GO



----------------------------------------- INCONSISTENCIAS --------------------------------------------
-- MAILS CON MAS DE UN PASAPORTE

INSERT INTO 
	HEMINGWAY.MAIL_DUPLICADOS (mail)
SELECT M.mail FROM 
	(SELECT DISTINCT C.mail, COUNT(C.identificacion) CANT FROM HEMINGWAY.CLIENTE C GROUP BY  C.mail) M
WHERE 
	M.CANT > 1
	