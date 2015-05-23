USE GD1C2015
select top 100 * from GD1C2015.gd_esquema.Maestra;

select distinct top 100 
	m.Cli_Pais_Codigo, 
	m.Cli_Pais_Desc,
	m.Cli_Tipo_Doc_Cod,
	m.Cli_Tipo_Doc_Desc 
from 
	GD1C2015.gd_esquema.Maestra m;

GO

DELETE NEW_SOLUTION.Usuario_rol;
DELETE NEW_SOLUTION.Usuario;
DELETE NEW_SOLUTION.Rol_funcionalidad;
DELETE NEW_SOLUTION.Roles;
DELETE NEW_SOLUTION.Funcionalidades;

declare @idrol INT;
EXEC NEW_SOLUTION.SP_ROL_ADD @nombre = 'administrador';
set  select @idrol = g.idrol from NEW_SOLUTION.Roles G where G.nombre = 'administrador'
exec NEW_SOLUTION.SP_ROL_ADD_FUNCIONALIDAD @idrol = ( select G.idrol from NEW_SOLUTION.Roles G where G.nombre = 'administrador')



SELECT * FROM NEW_SOLUTION.Roles



 exec NEW_SOLUTION.sp_funcionalidad_get;

declare @idrol int; 
set @idrol = select ( 
exec NEW_SOLUTION.SP_ROL_ADD @nombre = 'administrador';
set @idrol = select * from NEW_SOLUTION.Roles G where G.

select * from NEW_SOLUTION.usuario
select * from NEW_SOLUTION.V_USUARIOS_INACTIVOS
exec NEW_SOLUTION.sp_usuario_login @username = 'admin', @password = '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918' 
exec NEW_SOLUTION.sp_usuario_login @username = 'admin', @password = '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab4' 
select * from NEW_SOLUTION.Usuario_rol
select * from NEW_SOLUTION.Roles
select * from NEW_SOLUTION.Funcionalidades


select distinct top 100 
	m.Cli_Nombre, 
	m.Cli_Apellido,
	m.Cli_Pais_Codigo,
	m.Cli_Pais_Desc,
	m.Cli_Tipo_Doc_Cod,
	m.Cli_Tipo_Doc_Desc,
	m.Cli_Dom_Calle,
	m.Cli_Dom_Depto,
	m.Cli_Dom_Nro,
	m.Cli_Dom_Piso,
	m.Cli_Fecha_Nac,
	m.Cli_Mail
from gd_esquema.Maestra m