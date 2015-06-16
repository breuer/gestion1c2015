
-- crea un usuario
create procedure NEW_SOLUTION.sp_usuario_add
	@username varchar(255), 
	@password varchar(255), 
	@fecha_creacion date
as
begin
	declare @id_result int;
	set @id_result = 1
	if exists (	select * from NEW_SOLUTION.Usuarios u where u.usu_nombre = @username)
		begin
			set @id_result = -1
		end
	else
		begin
			insert into NEW_SOLUTION.Usuarios(usu_nombre , usu_password, usu_fecCreacion	)
			values 
				(@username, @password, @fecha_creacion)
			set @id_result = scope_identity();
		end
	return @id_result;
end
go


-- agrega rol a usuario
create procedure NEW_SOLUTION.sp_usuario_add_rol (
	@id_usuario int, 
	@id_rol int
)
as
begin 
	insert into NEW_SOLUTION.Usuarios_roles (usu_id, rol_id)
	values 
		(@id_usuario, @id_rol)
end
go

-- obtiene un usuario
create procedure NEW_SOLUTION.sp_usuario_get
	@id_usuario int = null,
	@username varchar(255) = null
as
begin
	if(@id_usuario is not null)
		select
			u.usu_nombre,
			--u.usu_password,
			u.usu_fecCreacion,
			u.usu_fecUltmodif,
			u.usu_pregSecreta,
			u.usu_respSecreta,			
			u.usu_estado,
			u.usu_cli_id
		from
			NEW_SOLUTION.Usuarios u
		where
			u.usu_id = @id_usuario 
end
go

-- actualiza password de un usuario
create procedure NEW_SOLUTION.sp_usuario_update_password
	@id_usuario int,
	@password varchar(255)
as
begin
	update 
		NEW_SOLUTION.Usuarios
	set 
		usu_password = @password
	where
		usu_id = @id_usuario 	
end
go
