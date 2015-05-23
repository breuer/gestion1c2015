use [GD1C2015]
GO

CREATE FUNCTION NEW_SOLUTION.F_ROL_ADD (@rol_nombre varchar(255))
RETURNS int
AS BEGIN
	exec NEW_SOLUTION.SP_ROL_ADD @nombre = @rol_nombre; 
	DECLARE @id int = (
	SELECT TOP 1
		R.idrol
	FROM
		NEW_SOLUTION.Roles R
	WHERE
		R.nombre = @rol_nombre)
	RETURN @id;
END;
GO

CREATE FUNCTION NEW_SOLUTION.F_ROL_ADD_FUNCIONALIDAD (@idrol int, @idfuncionalidad int)
RETURNS int
AS BEGIN
	exec NEW_SOLUTION.SP_ROL_ADD_F_ROL_ADD_FUNCIONALIDAD @idrol 
	DECLARE @id int = (
	SELECT TOP 1
		R.idrol
	FROM
		NEW_SOLUTION.Roles R
	WHERE
		R.nombre = @rol_nombre)
	RETURN @id;
END;
GO

CREATE FUNCTION NEW_SOLUTION.F_ROL_GET_ID (@nombre varchar(255))
RETURNS int
AS BEGIN
	DECLARE @id int = (
	SELECT TOP 1
		R.idrol
	FROM
		NEW_SOLUTION.Roles R
	WHERE
		R.nombre = @nombre)
	RETURN @id;
END;
GO
	
CREATE FUNCTION NEW_SOLUTION.F_USUARIO_GET_ID (@usuario varchar(255))
RETURNS int
AS BEGIN
	DECLARE @id int = (
	SELECT TOP 1
		U.idusuario
	FROM
		NEW_SOLUTION.Usuario U
	WHERE
		U.usuario = @usuario)
	RETURN @id;
END;
GO

/**************************************************************************/
-- FUNCIONALIDAD
/**************************************************************************/

CREATE PROCEDURE NEW_SOLUTION.SP_FUNCIONALIDAD_GET
	@idrol int = NULL
AS
BEGIN
	Declare @query nVARCHAR(255);
		set @query = ''
		set @query = @query +	'SELECT ' 
		set @query = @query +		'F.idfuncionalidad, '
		set @query = @query +		'F.nombre '
		set @query = @query +	'FROM '
		set @query = @query +		'NEW_SOLUTION.FUNCIONALIDADES F '		
	if(@idrol is not null) BEGIN	
		set @query = @query +	'JOIN '
		set @query = @query +		'NEW_SOLUTION.ROL_FUNCIONALIDAD RF '
		set @query = @query +	'ON '
		set @query = @query +		'RF.idfuncionalidad = F.idfuncionalidad '
		set @query = @query +	'WHERE '
		set @query = @query +		'RF.idrol = ' + CAST(@idrol AS VARCHAR)
	END
	PRINT @query
	exec (@query)
END
GO


/**************************************************************************/
-- ROL
/**************************************************************************/

CREATE PROCEDURE NEW_SOLUTION.SP_ROL_ADD
	@nombre VARCHAR(255)
AS
BEGIN
	DECLARE @ID_RESULT NUMERIC(18,0);
	INSERT INTO NEW_SOLUTION.Roles (nombre)
	VALUES 
		(@nombre)
	SET @ID_RESULT = SCOPE_IDENTITY();
	RETURN @ID_RESULT
END
GO

CREATE PROCEDURE NEW_SOLUTION.SP_ROL_ADD_FUNCIONALIDAD
	@idrol int, 
	@idfuncionalidad int
AS
BEGIN
	INSERT INTO NEW_SOLUTION.ROL_FUNCIONALIDAD(idrol, idfuncionalidad)
	VALUES 
		(@idrol, @idfuncionalidad)
END
GO

CREATE PROCEDURE NEW_SOLUTION.SP_ROL_UPDATE
	@idrol int, 
	@nombre varchar(255)
AS
BEGIN
	UPDATE NEW_SOLUTION.ROLES
	SET
		nombre = @nombre
	WHERE
		idrol = @idrol
END
GO

exec NEW_SOLUTION.SP_ROL_GET 1

ALTER PROCEDURE NEW_SOLUTION.SP_ROL_GET
	@idusuario int = NULL--,
	--@idrol int = NULL
AS
BEGIN

	--Cuando viene el usuario
	if(@idusuario is not null)
		select R.idrol,
			   R.nombre
		from   NEW_SOLUTION.Roles R
		inner join NEW_SOLUTION.Usuario_rol UR		on R.idrol=UR.idrol
		where  UR.idusuario = @idusuario
	else
		select R.idrol,
			   R.nombre
		from   NEW_SOLUTION.Roles R

		/*		
	Declare @query nvarchar(255);
		set @query = ''
		set @query = @query +	'SELECT ' 
		set @query = @query +		'R.idrol, '
		set @query = @query +		'R.nombre '
		set @query = @query +	'FROM '
		set @query = @query +		'NEW_SOLUTION.ROLES R '		
	if(@idusuario is not null) BEGIN	
		set @query = @query +	'JOIN '
		set @query = @query +		'NEW_SOLUTION.USUARIO_ROL UR '
		--set @query = @query +	'ON '
		--set @query = @query +		'R.idrol = UR.idrol '
		set @query = @query +	'WHERE '
		set @query = @query +		'UR.idusuario = ' + CAST(@idusuario AS varchar)
	END
	*/
	/*
	if(@idrol is not null) BEGIN	
		set @query = @query +	'WHERE '
		set @query = @query +		'R.idrol = ' + CAST(@idrol AS varchar)
	END
	
	PRINT @query
	exec (@query)
	*/
END
GO

/**************************************************************************/
-- USUARIO
/**************************************************************************/

CREATE PROCEDURE NEW_SOLUTION.SP_USUARIO_ADD
	@username VARCHAR(255), 
	@password VARCHAR(255), 
	@fecha_creacion DATE
AS
BEGIN
	DECLARE @ID_RESULT INT;
	SET @ID_RESULT = 1
	IF EXISTS (	SELECT * FROM NEW_SOLUTION.USUARIO U WHERE U.usuario = @username)
		BEGIN
			SET @ID_RESULT = -1
		END
	ELSE
		BEGIN
			INSERT INTO NEW_SOLUTION.USUARIO(usuario , password, fechaCreacion)
			VALUES 
				(@username, @password, @fecha_creacion)
			SET @ID_RESULT = SCOPE_IDENTITY();
		END
	return @ID_RESULT;
END
GO

CREATE PROCEDURE NEW_SOLUTION.SP_USUARIO_ADD_ROL (
	@id_usuario int, 
	@id_rol int
)
AS
BEGIN 
	INSERT INTO NEW_SOLUTION.USUARIO_ROL (idusuario, idrol)
	VALUES 
		(@id_usuario, @id_rol)
END
GO

CREATE PROCEDURE NEW_SOLUTION.SP_USUARIO_GET
	@id_usuario INT = NULL
AS
BEGIN
	DECLARE @query NVARCHAR(255);
		set @query = ''
		set @query = @query +	'SELECT ' 
		set @query = @query +		'U.fechaCreacion '
		set @query = @query +	'FROM '
		set @query = @query +		'NEW_SOLUTION.V_USUARIOS_ACTIVOS U '			
		set @query = @query +	'WHERE '
	IF(@id_usuario IS NOT NULL)
		set @query = @query +		'U.idusuario = ' + CAST(@id_usuario AS VARCHAR) + ' AND '
		set @query = @query +	'1=1'
	PRINT @query
	EXEC (@query)
END
GO

/**************************************************************************/
-- LOGIN
/**************************************************************************/

CREATE PROCEDURE NEW_SOLUTION.SP_USUARIO_LOGIN
	@username VARCHAR(255) = NULL,
	@password VARCHAR(255) = NULL
AS
BEGIN
	DECLARE @result INT = -1 -- login incorrecto
	DECLARE @id_usuario INT = NULL
	DECLARE @password_usuario VARCHAR(255)
		
	IF EXISTS (SELECT * FROM NEW_SOLUTION.Usuario U WHERE U.usuario = @username ) -- no existe usuario
	BEGIN
		IF EXISTS (SELECT * FROM NEW_SOLUTION.V_USUARIOS_INACTIVOS U WHERE U.usuario = @username )
		BEGIN
			set @result = -2; -- usuario dado de baja
		END ELSE 
		BEGIN
			SELECT 
				@id_usuario = U.idusuario,
				@password_usuario = U.password
			FROM 
				NEW_SOLUTION.V_USUARIOS_ACTIVOS U
			WHERE 
				U.usuario = @username  

			IF (@password_usuario <> @password) -- password incorrecto
			BEGIN
				IF EXISTS (SELECT * FROM NEW_SOLUTION.Login_incorrecto L WHERE L.idusuario = @id_usuario)			
				BEGIN
					-- incremento intento fallido
					UPDATE 			
						NEW_SOLUTION.Login_incorrecto
					SET
						intento = intento + 1
					WHERE 
						idusuario = @id_usuario
				END ELSE
				BEGIN
					-- primer intento fallido
					INSERT INTO 
						NEW_SOLUTION.Login_incorrecto (idusuario)
					VALUES 
						(@id_usuario)
				END
			END ELSE 
			BEGIN	
				-- login exitoso
				DELETE
					NEW_SOLUTION.Login_incorrecto
				WHERE	
					idusuario = @id_usuario
				SET @result = @id_usuario		
			END
		END	
	END	
	PRINT @result		
	RETURN @result 
END
GO