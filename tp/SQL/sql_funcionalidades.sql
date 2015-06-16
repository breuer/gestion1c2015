-- obtiene funcionalidades (todas o de un rol) 
create procedure NEW_SOLUTION.sp_funcionalidad_get
	@rol_id int = null
as
begin
	if (@rol_id is null)
		select 
			f.func_id, f.func_nombre 
		from 
			NEW_SOLUTION.funcionalidades f 
	else 
		select 
			f.func_id, f.func_nombre 
		from 
			NEW_SOLUTION.funcionalidades f 
		join 
			NEW_SOLUTION.Rol_funcionalidades rf 
		on 
			rf.func_id = f.func_id 
		where 
			rf.rol_id = @rol_id
end
go
