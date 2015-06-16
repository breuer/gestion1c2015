-- borra las funcionalidades de un rol
create trigger NEW_SOLUTION.t_rol_update on NEW_SOLUTION.Roles
for update
as 
	declare @rol_id int
	
	select 
		@rol_id = i.rol_id
	from
		inserted i
	delete
		NEW_SOLUTION.Rol_funcionalidades
	where
		rol_id = @rol_id	
go


-- crea un rol
create procedure NEW_SOLUTION.sp_rol_add
	@nombre varchar(255)
as
begin
	declare @id_result numeric(18,0);
	insert into NEW_SOLUTION.roles (rol_nombre)
	values 
		(@nombre)
	set @id_result = scope_identity();
	return @id_result
end
go

-- agrega funcionalidad a rol
create procedure NEW_SOLUTION.sp_rol_add_funcionalidad
	@rol_id int, 
	@funcionalidad_id int
as
begin
	insert into NEW_SOLUTION.rol_funcionalidades(rol_id, func_id)
	values 
		(@rol_id, @funcionalidad_id)
end
go

-- actualiza rol
create procedure NEW_SOLUTION.sp_rol_update
	@rol_id int, 
	@nombre varchar(255)
as
begin
	update NEW_SOLUTION.roles
	set
		rol_nombre = @nombre
	where
		rol_id = @rol_id
end
go

-- obtiene roles (uno, todos o los de un usuario) 
create procedure NEW_SOLUTION.sp_rol_get
	@id_usuario int = null,
	@id_rol int = null
as
begin

	if(@id_usuario is not null)
		select 
			r.rol_id, r.rol_nombre
		from   
			NEW_SOLUTION.roles r
		join 
			NEW_SOLUTION.Usuarios_roles ur on r.rol_id= ur.rol_id
		where  
			ur.usu_id = @id_usuario
	else if (@id_rol is not null)
		select 
			r.rol_id, r.rol_nombre
		from   
			NEW_SOLUTION.roles r
		where 
			r.rol_id = @id_rol
	else
		select 
			r.rol_id, r.rol_nombre
		from   
			NEW_SOLUTION.roles r	
end
go


