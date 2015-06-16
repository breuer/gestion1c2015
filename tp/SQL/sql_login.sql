-- registra login incorrectos
create trigger NEW_SOLUTION.t_login_insert on NEW_SOLUTION.Login
for insert
as 
	declare @user_id int
	declare @login_resultado varchar(1)
	
	select 
		@user_id = i.login_user_id,
		@login_resultado = i.login_resultado
	from
		inserted i
		
	if exists (select * from NEW_SOLUTION.Login_incorrectos l where l.logfalla_user_id = @user_id) begin
		if(@login_resultado = 'n') begin
			-- incremento intento fallido
			update 			
				NEW_SOLUTION.Login_incorrectos
			set
				logfalla_intento = logfalla_intento + 1
			where 
				logfalla_user_id = @user_id
		end else begin
			-- pongo a 0 intento fallido
			update 			
				NEW_SOLUTION.Login_incorrectos
			set
				logfalla_intento = 0
			where 
				logfalla_user_id = @user_id
		end
	end else begin		
		if(@login_resultado = 'n') begin
			-- primer intento fallido
			insert into 
				NEW_SOLUTION.Login_incorrectos (logfalla_user_id, logfalla_intento)
			values 
				(@user_id, 1)
		end	
	end
go

-- intentos fallidos de login
create trigger NEW_SOLUTION.t_intento_fallido on NEW_SOLUTION.Login_incorrectos
for update
as 
	declare @id int
	declare @cant int
	
	select 
		@id = i.logfalla_user_id ,
		@cant = i.logfalla_intento 
	from 
		inserted i
					
	if(@cant >= 3 ) begin
		update 
			NEW_SOLUTION.Usuarios
		set 
			usu_estado = 'n'
		where
			usu_id = @id
	end	
go

-- Proceso de login
create procedure NEW_SOLUTION.sp_usuario_login
	@username varchar(255) = null,
	@password varchar(255) = null,
	@fecha date = null
as
begin
	declare @resultado_login int = -1 -- login incorrecto
	declare @id_usuario int = null
	declare @password_usuario varchar(255)
		
	if exists (select * from NEW_SOLUTION.Usuarios u where u.usu_nombre = @username ) -- no existe usuario
	begin
		if exists (select * from NEW_SOLUTION.v_usuarios_inactivos u where u.usu_nombre = @username )
			set @resultado_login = -2; -- usuario dado de baja
		else begin
			select 
				@id_usuario = u.usu_id,
				@password_usuario = u.usu_password
			from 
				NEW_SOLUTION.Usuarios u
			where 
				u.usu_nombre = @username  

			declare @resultado varchar(1) = 'n'
			if (@password_usuario = @password) begin -- password correcto
				set @resultado = 's'
				set @resultado_login = 1
			end
						
			insert into 
				NEW_SOLUTION.Login (login_user_id, login_fecha, login_resultado)
			values 
				(@id_usuario, @fecha, @resultado)
		end	
	end	
	--print @result		
	return @resultado_login 
end
go