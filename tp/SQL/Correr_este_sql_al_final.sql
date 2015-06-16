insert into NEW_SOLUTION.Usuarios(usu_nombre, usu_password)
values ('a', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),
	   ('b', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')

insert into NEW_SOLUTION.Usuarios_roles(usu_id,rol_id)
select usu_id,2 from NEW_SOLUTION.Usuarios
where usu_nombre='a' or usu_nombre='b'

