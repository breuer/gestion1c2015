USE [GD2C2014]
go

CREATE SCHEMA hotel AUTHORIZATION gd

GO

CREATE TABLE hotel.Tipo_Doc (
codigo numeric(18,0) NOT NULL IDENTITY (1,1) PRIMARY KEY,
descripcion nvarchar(50)
)

go

-- inserta tipos de doc --
insert into hotel.Tipo_Doc (descripcion) values ('Pasaporte')
insert into hotel.Tipo_Doc (descripcion) values ('DNI')
insert into hotel.Tipo_Doc (descripcion) values ('CI')
insert into hotel.Tipo_Doc (descripcion) values ('LE')
insert into hotel.Tipo_Doc (descripcion) values ('LC')

go


CREATE TABLE hotel.Persona (
codigo numeric(18,0) NOT NULL IDENTITY (1,1) PRIMARY KEY,
nombre nvarchar(255) NOT NULL,
apellido nvarchar(255) NOT NULL,
codigo_tipo_doc numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Tipo_Doc(codigo),
num_doc numeric(18,0) NOT NULL,
mail nvarchar(255) NOT NULL,
telefono numeric(18,0),
nom_calle nvarchar(255),
num_calle numeric(18,0),
localidad nvarchar(255),
ciudad nvarchar(255),
pais nvarchar(255),
nacionalidad nvarchar(255),
fecha_nacimiento datetime,
piso numeric(18,0),
depto nvarchar(50),
estado tinyint DEFAULT 1
)

go

create index index_numDoc on hotel.Persona(num_doc);

go
-- se inserta los clientes --
insert into hotel.Persona(apellido,depto,nom_calle,fecha_nacimiento,mail,nacionalidad,nombre,num_calle,num_doc,piso,codigo_tipo_doc,estado)

SELECT distinct m.Cliente_Apellido, m.Cliente_Depto, m.Cliente_Dom_Calle, m.Cliente_Fecha_Nac, m.Cliente_Mail, m.Cliente_Nacionalidad, m.Cliente_Nombre, m.Cliente_Nro_Calle,
m.Cliente_Pasaporte_Nro, m.Cliente_Piso, 1 tipoDoc, 1 estado
  FROM [GD2C2014].[gd_esquema].[Maestra] m


go

CREATE TABLE hotel.Usuario (
codigo numeric(18,0) NOT NULL IDENTITY (1,1) PRIMARY KEY,
user_nombre nvarchar(255) NOT NULL UNIQUE,
user_password nvarchar(256) NOT NULL,
logueado tinyint,
intentos_fallidos int,
cod_persona numeric(18,0) FOREIGN KEY REFERENCES hotel.Persona(codigo),
estado tinyint default 1
)

go

-- usuario default de guest encriptado / password = contraseñaDefault --
insert hotel.Usuario(estado,logueado,user_nombre,user_password,intentos_fallidos,cod_persona) values (1,1,'Guest','dceda6f81380be55bf9d737628b177e676ed954bdfaf4f0d46090e4bff02ec06',0,null)

-- usuario default de Admin pedido por la cátedra: admin / w23e
insert hotel.Usuario(estado,logueado,user_nombre,user_password,intentos_fallidos,cod_persona) values (1,1,'admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',0,null)

go

CREATE TABLE hotel.Rol (
codigo numeric(18,0) NOT NULL IDENTITY (1,1) PRIMARY KEY,
descripcion nvarchar(50) NOT NULL,
estado tinyint default 1
)

go

-- creacion de roles
insert hotel.Rol(descripcion,estado) values('Administrador',1)
insert hotel.Rol(descripcion,estado) values('Recepción',1)
insert hotel.Rol(descripcion,estado) values('Guest',1)

go

CREATE TABLE hotel.Funcion (
codigo numeric(18,0) NOT NULL IDENTITY (1,1) PRIMARY KEY,
descripcion nvarchar(50) not null,
)

go


-- creacion de funciones

insert hotel.Funcion(descripcion) values ('ABM Usuarios')
insert hotel.Funcion(descripcion) values ('ABM Clientes')
insert hotel.Funcion(descripcion) values ('ABM Hoteles')
insert hotel.Funcion(descripcion) values ('ABM Habitación')
insert hotel.Funcion(descripcion) values ('ABM Régimen de estadia')
insert hotel.Funcion(descripcion) values ('Generar o modificar Reservas')
insert hotel.Funcion(descripcion) values ('Cancelar Reserva')
insert hotel.Funcion(descripcion) values ('Registrar Estadia')
insert hotel.Funcion(descripcion) values ('Registrar Consumos')
insert hotel.Funcion(descripcion) values ('Facturar estadía')
insert hotel.Funcion(descripcion) values ('Listado Estadístico')
insert hotel.Funcion(descripcion) values ('ABM Rol')
-- insert hotel.Funcion(descripcion) values ('Login')

go


CREATE TABLE hotel.Rol_Funcion (
cod_rol numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Rol(codigo),
cod_funcion numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Funcion(codigo),
primary key(cod_rol,cod_funcion)
)

go
-- creacion de relaciones entre funciones y roles

insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(1,12)

insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(1,1)
insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(1,2)
insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(1,3)
insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(1,4)
insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(1,5)
insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(1,6)
insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(1,7)
insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(1,8)
insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(1,9)
insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(1,10)
insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(1,11)
--insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(1,13)

--insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(2,13)

insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(2,2)
insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(2,6)
insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(3,6)

insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(2,7)
insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(3,7)

insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(2,8)

insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(2,9)

insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(2,10)

insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(2,11)
insert hotel.Rol_Funcion(cod_rol,cod_funcion) values(3,11)

go


CREATE TABLE hotel.Rol_Usuario (
cod_usuario numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Usuario(codigo),
cod_rol numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Rol(codigo),
primary key(cod_usuario,cod_rol)
)
go

insert hotel.Rol_Usuario(cod_rol,cod_usuario) values (3,1)

go

insert hotel.Rol_Usuario(cod_rol,cod_usuario) values (1,2)

go

CREATE TABLE hotel.Hotel (
codigo numeric(18,0) NOT NULL IDENTITY (1,1) PRIMARY KEY,
nombre nvarchar(255),
mail nvarchar(255),
telefono numeric(18,0),
cant_estrellas numeric(18,0),
nom_calle nvarchar(255),
num_calle numeric(18,0),
pais nvarchar(255),
ciudad nvarchar(255),
fecha_creacion datetime,
administrador numeric(18,0) FOREIGN KEY REFERENCES hotel.Usuario(codigo),
recarga_estrella numeric(18,0),
)

go

-- inserta todos los hoteles --
insert into hotel.Hotel (ciudad,nom_calle,num_calle,cant_estrellas,fecha_creacion,recarga_estrella)
SELECT distinct m.Hotel_Ciudad, m.Hotel_Calle,m.Hotel_Nro_Calle,m.Hotel_CantEstrella,CONVERT(datetime,'01-02-2012',105) fechaCreacion,m.Hotel_Recarga_Estrella
  FROM [GD2C2014].[gd_esquema].[Maestra] m


go

CREATE TABLE hotel.Tipo_Habitacion (
codigo numeric(18,0) NOT NULL PRIMARY KEY,
descripcion nvarchar(50) not null,
porcentual numeric(18,2)
)

go

-- inserta todos los tipos de habitacion --
insert into hotel.Tipo_Habitacion(codigo,descripcion,porcentual)

SELECT distinct m.Habitacion_Tipo_Codigo, m.Habitacion_Tipo_Descripcion, m.Habitacion_Tipo_Porcentual
  FROM [GD2C2014].[gd_esquema].[Maestra] m

go


CREATE TABLE hotel.Habitacion (
codigo numeric(18,0) NOT NULL IDENTITY (1,1),
numero numeric(18,0) NOT NULL,
cod_hotel numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Hotel(codigo),
piso numeric(18,0) not null,
ubicacion_frente char(1),
cod_tipo_habitacion numeric(18,0) not null foreign key REFERENCES hotel.Tipo_Habitacion(codigo),
descripcion nvarchar(255),
estado tinyint not null default 1,
primary key(codigo)
)

go

-- inserta todas las habitaciones --
insert into hotel.Habitacion(cod_hotel,numero,piso,cod_tipo_habitacion,ubicacion_frente,estado)
SELECT distinct h.codigo, m.Habitacion_Numero, m.Habitacion_Piso,t.codigo, m.Habitacion_Frente,1 estado
  FROM [GD2C2014].[gd_esquema].[Maestra] m, hotel.Hotel h, hotel.Tipo_Habitacion t
  where m.Hotel_Nro_Calle = h.num_calle and m.Hotel_Ciudad = h.ciudad and t.codigo = m.Habitacion_Tipo_Codigo
  group by m.Hotel_Nro_Calle, m.Hotel_Ciudad, h.codigo, m.Habitacion_Numero, m.Habitacion_Piso,t.codigo, m.Habitacion_Frente
  
go

CREATE TABLE hotel.Regimen (
codigo numeric(18,0) NOT NULL IDENTITY (1,1) PRIMARY KEY,
descripcion nvarchar(255) not null
)


go

-- inserta los regimen de los hoteles
insert into hotel.Regimen(descripcion)
SELECT distinct m.Regimen_Descripcion
  FROM [GD2C2014].[gd_esquema].[Maestra] m


go 

CREATE TABLE hotel.Regimen_Hotel (
cod_regimen numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Regimen(codigo),
cod_hotel numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Hotel(codigo),
precio_base numeric(18,2) NOT NULL,
estado tinyint default 1,
primary key(cod_regimen,cod_hotel)
)

go

-- inserta los regimenes por hotel con sus precios
insert into hotel.Regimen_Hotel(cod_hotel,cod_regimen,estado,precio_base) 
SELECT distinct h.codigo, r.codigo,1, m.Regimen_Precio
  FROM [GD2C2014].[gd_esquema].[Maestra] m, hotel.Hotel h, hotel.Regimen r
  where m.Hotel_Nro_Calle = h.num_calle and m.Hotel_Ciudad = h.ciudad and r.descripcion = m.Regimen_Descripcion
group by m.Hotel_Nro_Calle, m.Hotel_Ciudad, m.Regimen_Descripcion, h.codigo, r.codigo, m.Regimen_Precio

go

CREATE TABLE hotel.Estado_Reserva(
codigo numeric(18,0) NOT NULL IDENTITY (1,1) PRIMARY KEY,
descripcion nvarchar(50) NOT NULL
)


go

-- carga de estados posibles de una reserva
insert hotel.Estado_Reserva(descripcion) values('Reserva correcta')
insert hotel.Estado_Reserva(descripcion) values('Reserva modificada')
insert hotel.Estado_Reserva(descripcion) values('Reserva cancelada por Recepción')
insert hotel.Estado_Reserva(descripcion) values('Reserva cancelada por Cliente')
insert hotel.Estado_Reserva(descripcion) values('Reserva cancelada por Not - Show')
insert hotel.Estado_Reserva(descripcion) values('Reserva ingresada')



CREATE TABLE hotel.Reserva (
codigo numeric(18,0) NOT NULL PRIMARY KEY,
cod_hotel numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Hotel(codigo),
fecha_desde datetime NOT NULL,
fecha_hasta datetime,
cant_huespedes numeric(18,0),
cod_tipo_regimen numeric(18,0) FOREIGN KEY REFERENCES hotel.Regimen(codigo),
cod_estado numeric(18,0) not null FOREIGN KEY REFERENCES hotel.Estado_Reserva(codigo),
cod_usuario_carga numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Usuario(codigo),
cant_noches numeric(18,0),
cod_persona numeric(18,0) not null  FOREIGN KEY REFERENCES hotel.Persona(codigo),
fecha_creacion datetime,
)


go

insert into hotel.Reserva(codigo,cod_hotel,fecha_desde,fecha_hasta,fecha_creacion,cant_huespedes,cod_tipo_regimen,cod_estado,cod_usuario_carga,cant_noches,cod_persona) 
SELECT distinct m.Reserva_Codigo,h.codigo, m.Reserva_Fecha_Inicio, DATEADD(DAY,m.Reserva_Cant_Noches, m.Reserva_Fecha_Inicio), m.Reserva_Fecha_Inicio,null, r.codigo,1,1,m.Reserva_Cant_Noches, p.codigo
  FROM [GD2C2014].[gd_esquema].[Maestra] m, hotel.Hotel h, hotel.Regimen r, hotel.Persona p
where m.Hotel_Nro_Calle = h.num_calle and m.Hotel_Ciudad = h.ciudad and m.Regimen_Descripcion = r.descripcion and p.mail = m.Cliente_Mail and
m.Cliente_Pasaporte_Nro = p.num_doc and m.Cliente_Apellido = p.apellido and m.Cliente_Nombre = p.nombre
group by m.Hotel_Nro_Calle, m.Hotel_Ciudad, m.Regimen_Descripcion, m.Cliente_Mail, m.Cliente_Pasaporte_Nro, m.Cliente_Apellido, m.Cliente_Nombre,
m.Reserva_Codigo, h.codigo, m.Reserva_Fecha_Inicio, m.Reserva_Fecha_Inicio, r.codigo, m.Reserva_Cant_Noches, p.codigo


go

CREATE TABLE hotel.Auditoria_Reserva(
cod_reserva numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Reserva(codigo),
motivo nvarchar(255),
fecha datetime NOT NULL,
cod_persona numeric(18,0) FOREIGN KEY REFERENCES hotel.Persona(codigo),
cod_usuario numeric(18,0) not null FOREIGN KEY REFERENCES hotel.Usuario(codigo)
)

go

-- creaciones de las reservas para auditoria

insert into hotel.Auditoria_Reserva(cod_persona,cod_reserva,cod_usuario,fecha,motivo) 
SELECT distinct p.codigo,m.Reserva_Codigo, 1,m.Reserva_Fecha_Inicio,'Creacion'
  FROM [GD2C2014].[gd_esquema].[Maestra] m, hotel.Persona p
where p.mail = m.Cliente_Mail and m.Cliente_Pasaporte_Nro = p.num_doc and m.Cliente_Apellido = p.apellido and m.Cliente_Nombre = p.nombre
group by m.Cliente_Mail, m.Cliente_Pasaporte_Nro, m.Cliente_Apellido, m.Cliente_Nombre, p.codigo, m.Reserva_Codigo, m.Reserva_Fecha_Inicio


go

CREATE TABLE hotel.Usuario_hotel (
cod_usuario numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Usuario(codigo),
cod_hotel numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Hotel(codigo),
primary key(cod_usuario,cod_hotel)
)

go

insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (2,1)
insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (2,2)
insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (2,3)
insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (2,4)
insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (2,5)
insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (2,6)
insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (2,7)
insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (2,8)
insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (2,9)
insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (2,10)
insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (2,11)
insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (2,12)
insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (2,13)
insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (2,14)
insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (2,15)
insert hotel.Usuario_hotel (cod_usuario,cod_hotel) values (2,16)

go

CREATE TABLE hotel.Cancelacion_Hotel (
codigo numeric(18,0) NOT NULL IDENTITY (1,1) PRIMARY KEY,
cod_hotel numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Hotel(codigo),
fecha_desde datetime not null,
fecha_hasta datetime,
motivo text
)

go

CREATE TABLE hotel.Reserva_Habitacion (
cod_reserva numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Reserva(codigo),
cod_habitacion numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Habitacion(codigo),
primary key(cod_reserva,cod_habitacion)
)

go

-- inserta la relacion entre habitaciones y reserva
insert into hotel.Reserva_Habitacion(cod_habitacion,cod_reserva)
SELECT distinct hab.codigo, m.Reserva_Codigo
  FROM [GD2C2014].[gd_esquema].[Maestra] m, hotel.Habitacion hab
where m.Habitacion_Tipo_Codigo = hab.cod_tipo_habitacion and m.Habitacion_Numero = hab.numero and m.Habitacion_Piso = hab.piso
group by m.Hotel_Nro_Calle, m.Hotel_Ciudad, m.Habitacion_Tipo_Codigo, m.Habitacion_Numero, hab.codigo, m.Reserva_Codigo

go

CREATE TABLE hotel.Check_In_Out (
codigo numeric(18,0) NOT NULL IDENTITY (1,1) PRIMARY KEY,
cod_reserva numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Reserva(codigo),
fecha_hora_in datetime not null,
fecha_hora_out datetime,
cod_usuario_carga_in numeric(18,0) FOREIGN KEY  REFERENCES hotel.Usuario(codigo),
cod_usuario_carga_out numeric(18,0) FOREIGN KEY REFERENCES hotel.Usuario(codigo),
cant_noches_estadia numeric(18,0)
)

go


-- inserta las estadias

insert into hotel.Check_In_Out(fecha_hora_in,fecha_hora_out,cod_reserva,cod_usuario_carga_out,cod_usuario_carga_in,cant_noches_estadia)
SELECT distinct m.Estadia_Fecha_Inicio,DATEADD(day,m.Estadia_Cant_Noches,m.Estadia_Fecha_Inicio),m.Reserva_Codigo,1,1,m.Estadia_Cant_Noches
  FROM [GD2C2014].[gd_esquema].[Maestra] m
 where m.Estadia_Fecha_Inicio is not null
  
-- actualiza el estado de las reservas que ya estan ingresadas, tienen check

UPDATE r SET r.cod_estado = 6 FROM hotel.Reserva r, hotel.Check_In_Out c WHERE r.codigo = c.cod_reserva
  
go


CREATE TABLE hotel.Consumo (
codigo numeric(18,0) NOT NULL PRIMARY KEY,
descripcion nvarchar(255) NOT NULL,
precio numeric(18,2) NOT NULL
)

go

-- inserta los consumos existentes
insert into hotel.Consumo(codigo,descripcion,precio)
SELECT distinct m.Consumible_Codigo, m.Consumible_Descripcion, m.Consumible_Precio
  FROM [GD2C2014].[gd_esquema].[Maestra] m
 where m.Consumible_Codigo is not null

go

CREATE TABLE hotel.Cabezera_Factura (
codigo numeric(18,0) NOT NULL PRIMARY KEY,
reserva numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Reserva(codigo),
fecha datetime,
metodo_pago tinyint default 0,
total numeric(18,2),
estado tinyint default 1
)

go

-- guarda todas las cabezas de facturas

insert into hotel.Cabezera_Factura(fecha,codigo,reserva,total,metodo_pago,estado) 
SELECT distinct m.Factura_Fecha,m.Factura_Nro,m.Reserva_Codigo, m.Factura_Total, 0,1
  FROM [GD2C2014].[gd_esquema].[Maestra] m
 where m.Factura_Nro is not null

go

CREATE TABLE hotel.Tarjeta (
codigo_Reserva numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Reserva(codigo),
num_tarjeta numeric(18,0) NOT NULL,
fecha_vence datetime NOT NULL,
fecha_emision datetime NOT NULL
)

go

CREATE TABLE hotel.Item_Factura (
codigo numeric(18,0) NOT NULL IDENTITY (1,1) PRIMARY KEY,
cod_consumo numeric(18,0) FOREIGN KEY REFERENCES hotel.Consumo(codigo),
cod_cabezera_factura numeric(18,0) NOT NULL FOREIGN KEY REFERENCES hotel.Cabezera_Factura(codigo),
cod_habitacion numeric(18,0) FOREIGN KEY REFERENCES hotel.Habitacion(codigo),
cantidad numeric(18,0) not null,
monto numeric(18,2)
)

go

-- inserta todos los items de las facturas correspondientes segun la habitacion

insert into hotel.Item_Factura(cod_cabezera_factura,cantidad,cod_consumo,monto,cod_habitacion)
SELECT m.Factura_Nro, m.Item_Factura_Cantidad, c.codigo, m.Item_Factura_Monto, hab.codigo
  FROM [GD2C2014].[gd_esquema].[Maestra] m left join hotel.Consumo c on m.Consumible_Codigo = c.codigo, hotel.habitacion hab, hotel.hotel
 where m.Factura_Nro is not null and m.Item_Factura_Monto is not null
and m.Habitacion_Numero = hab.numero and m.Habitacion_Tipo_Codigo = hab.cod_tipo_habitacion
and m.Habitacion_Piso = hab.piso and hotel.[nom_calle] = m.Hotel_Calle and hotel.[num_calle] = m.Hotel_Nro_Calle
and hotel.codigo = hab.[cod_hotel]


go

-- creacion de procedimientos almacenados para agilizar la app --

create procedure hotel.SP_GETROLES
as begin
	select * from hotel.Rol r where r.estado = 1
end

go
create procedure [hotel].[SP_GETFUNCIONESporROL] (@CodRol numeric(18,0))
as begin
Select f.codigo, f.descripcion from hotel.Funcion f, hotel.Rol_Funcion rFun, hotel.Rol r where rFun.cod_rol = r.codigo and r.estado = 1 and f.codigo = rFun.cod_funcion and rFun.cod_rol = @CodRol
end


go

create procedure [hotel].SP_GETUSUARIOS
as begin
	select * from hotel.Usuario r
end


go


create procedure [hotel].SP_GETUSUARIOSACTIVOS
as begin
	select * from hotel.Usuario r where r.estado = 1
end

go

create procedure hotel.SP_GETHOTELESDEUSUARIO (@CodUsuario NUMERIC(18,0))
AS BEGIN

SELECT h.codigo, h.nombre, h.mail, h.telefono, h.cant_estrellas, h.nom_calle, h.num_calle, h.pais, h.ciudad, h.fecha_creacion, h.administrador, h.recarga_estrella
  FROM hotel.Hotel h, hotel.Usuario_hotel u
  where h.codigo = u.cod_hotel and u.cod_usuario = @CodUsuario
  
  END

GO

create procedure hotel.SP_GETPERSONAUsuario(@codUsuario numeric(18,0)) as begin
select p.codigo, p.nombre, p.apellido, p.codigo_tipo_doc, p.num_doc, p.mail, p.telefono, p.nom_calle, p.num_calle, 
p.localidad, p.ciudad, p.pais, p.nacionalidad, p.fecha_nacimiento, p.piso, p.depto,p.estado 
from hotel.Persona p, hotel.Usuario u where p.codigo = u.cod_persona and u.codigo = @codUsuario
end

go

create procedure [hotel].[SP_UPDPERSONA]

(
@codigo decimal(18,0),
@nombre nvarchar(255),
@apellido nvarchar(255),
@codigo_tipo_doc decimal(18,0),
@num_doc decimal(18,0),
@mail nvarchar(255),
@telefono decimal(18,0), 
@nom_calle nvarchar(255),
@num_calle decimal(18,0),
@localidad nvarchar(255),
@ciudad nvarchar(255),
@pais nvarchar(255),
@nacionalidad nvarchar(255),
@fecha_nacimiento datetime,
@piso decimal(18,0),
@depto nvarchar(50),
@estado tinyint

)as begin

	update hotel.Persona
	set
	nom_calle = @nom_calle,
	nombre = @nombre,
	apellido = @apellido,
	codigo_tipo_doc = @codigo_tipo_doc,
	num_doc = @num_doc,
	mail = @mail,
	telefono = @telefono,
	num_calle = @num_calle,
	localidad = @localidad,
	ciudad = @ciudad,
	pais = @pais,
	nacionalidad = @nacionalidad,
	fecha_nacimiento = @fecha_nacimiento,
	piso = @piso,
	depto = @depto,
	estado = @estado
	where codigo = @codigo
end


 go

create procedure [hotel].SP_UPDUSER

(
@codigo decimal(18,0),
@user_nombre nvarchar(255),
@user_password nvarchar(255),
@logueado tinyint,
@intentos_fallidos int,
@cod_persona decimal(18,0), 
@estado tinyint

)as begin

	update hotel.Usuario
	set
	user_nombre = @user_nombre,
	user_password = @user_password,
	logueado = @logueado,
	intentos_fallidos = @intentos_fallidos,
	cod_persona = @cod_persona,
	estado = @estado
	where codigo = @codigo
end
	

go

create procedure [hotel].SP_UPDROL

(
@codigo decimal(18,0),
@descripcion nvarchar(255),
@estado tinyint

)as begin

	update hotel.Rol
	set
	descripcion = @descripcion,
	estado = @estado
	where codigo = @codigo
end

go

CREATE TRIGGER hotel.TR_AutoIncrementarReserva
   ON  hotel.Reserva
   instead of inSERT
AS 
BEGIN
    SET NOCOUNT ON;
	declare @Codigo decimal(18,0);
	set @Codigo = (select MAX(r.codigo) from hotel.Reserva r);
	set @Codigo = @Codigo + 1;
	insert hotel.Reserva (cant_huespedes,cant_noches,cod_estado,cod_hotel,cod_persona,cod_tipo_regimen,cod_usuario_carga,codigo,fecha_creacion,fecha_desde,fecha_hasta)
	select i.cant_huespedes, i.cant_noches,i.cod_estado,i.cod_hotel,i.cod_persona,i.cod_tipo_regimen,i.cod_usuario_carga,@Codigo,i.fecha_creacion,i.fecha_desde, i.fecha_hasta from inserted i

END

go

create procedure [hotel].SP_GETHOTELESACTIVOS (@CodUser int, @FechaHoy datetime)
as begin

   select u.codigo, u.mail,u.telefono,u.cant_estrellas,u.nom_calle,u.num_calle,u.pais,
  u.ciudad,u.nombre,u.fecha_creacion 
  from hotel.Hotel u, hotel.Cancelacion_Hotel c
  where ( u.codigo = c.cod_hotel and  (c.fecha_hasta) < @fechaHOY or c.fecha_desde > @fechaHOY) 
  or (u.codigo not in (select can.cod_hotel from hotel.cancelacion_hotel can))
  and u.codigo in(SELECT h.codigo
  FROM hotel.Hotel h, hotel.Usuario_hotel u
  where h.codigo = u.cod_hotel and u.cod_usuario = @CodUser)
   group by u.codigo, u.mail,u.telefono,u.cant_estrellas,u.nom_calle,
 u.num_calle,u.pais,u.ciudad,u.nombre,u.fecha_creacion
 
end

go

create procedure [hotel].SP_GETHOTELESACTIVOSBusqueda (@FechaHoy datetime)
as begin

     select u.codigo, u.mail,u.telefono,u.cant_estrellas,u.nom_calle,u.num_calle,u.pais,
  u.ciudad,u.nombre,u.fecha_creacion 
  from hotel.Hotel u
  where u.codigo not in 
  (select c.cod_hotel from hotel.cancelacion_hotel c
  where c.fecha_hasta < @FechaHoy or c.fecha_desde > @FechaHoy) 
 
end

go

--REGISTRAR CONSUMOS
insert into hotel.Consumo (codigo, descripcion, precio) values (9999, 'descuento por regimen de estadia', 0);

CREATE TABLE [hotel].[consumo_reserva](
	[cod_consumo] [numeric](18, 0) NOT NULL,
	[cod_reserva] [numeric](18, 0) NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [numeric](18, 2) NULL,
	[descripcion] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [hotel].[consumo_reserva]  WITH CHECK ADD  CONSTRAINT [FK_consumo_reserva_consumo] FOREIGN KEY([cod_consumo])
REFERENCES [hotel].[Consumo] ([codigo])
GO

ALTER TABLE [hotel].[consumo_reserva] CHECK CONSTRAINT [FK_consumo_reserva_consumo]
GO

ALTER TABLE [hotel].[consumo_reserva]  WITH CHECK ADD  CONSTRAINT [FK_consumo_reserva_reserva] FOREIGN KEY([cod_reserva])
REFERENCES [hotel].[Reserva] ([codigo])
GO

ALTER TABLE [hotel].[consumo_reserva] CHECK CONSTRAINT [FK_consumo_reserva_reserva]
GO


-----------------------------------------------------------------------------------------------

Create function [hotel].[getNextNumeroFactura]()
returns numeric(18,0)
as
begin
	declare @maxNumber numeric(18,0);
	select @maxNumber = (MAX(codigo) + 1) from hotel.Cabezera_Factura;
	return @maxNumber;
end;

go

-----------------------------------------------------------------------------------------------

CREATE FUNCTION [hotel].[isAllInclusive] (@codigoReserva decimal)
RETURNS bit 
AS
BEGIN
	declare @resultado bit;
		
	SELECT @resultado = CASE WHEN reg.codigo = 4 THEN 1 ELSE 0 END 
		FROM hotel.Regimen reg, hotel.Reserva r
		WHERE reg.codigo = r.cod_tipo_regimen
		AND r.codigo = @codigoReserva;
	
	return @resultado;
END;

go

-----------------------------------------------------------------------------------------------

CREATE PROCEDURE [hotel].[sp_consumos_reserva] @Codigo_Reserva numeric(18,0)
AS
BEGIN
SELECT c.codigo,
CASE WHEN cr.descripcion is not null THEN cr.descripcion ELSE c.descripcion END as descripcion,
cr.cantidad,
CASE WHEN cr.precio is not null THEN cr.precio ELSE c.precio END as precio
 from hotel.consumo_reserva cr, hotel.Consumo c 
 where cr.cod_consumo = c.codigo
 and cr.cod_reserva = @Codigo_Reserva

UNION

SELECT i.cod_consumo as codigo,
c.descripcion as descripcion,
i.cantidad as cantidad,
i.monto as precio
from hotel.Item_Factura i, hotel.Consumo c, hotel.Cabezera_Factura cf
where i.cod_consumo = c.codigo
and i.cod_consumo is not null
and cf.codigo = i.cod_cabezera_factura
and cf.estado = 1
and cf.reserva = @Codigo_Reserva;
END;

GO

-----------------------------------------------------------------------------------------------
 
CREATE PROCEDURE [hotel].[SP_RegistrarAllInclusive] @Codigo_Reserva numeric(18,0), @Precio numeric(18,2)
AS
BEGIN
INSERT INTO hotel.consumo_reserva (cod_consumo, cod_reserva, cantidad, precio) values
	(9999, @Codigo_Reserva, 1, @Precio)
END;
go

-----------------------------------------------------------------------------------------------

CREATE PROCEDURE [hotel].[SP_RegistrarConsumible] @Codigo_Reserva numeric(18,0), @Codigo_Producto numeric(18,0),
 @Cantidad int, @Precio numeric(18,2)
AS
BEGIN
INSERT INTO hotel.consumo_reserva (cod_consumo, cod_reserva, cantidad, precio) values
	(@Codigo_Producto, @Codigo_Reserva, @Cantidad, @Precio)

END;
--FACTURAR
go

CREATE procedure [hotel].[sp_getItemsFactura] @Codigo_Reserva numeric(18,0)
as begin

select reg.descripcion,
DATEDIFF(DAY, cio.fecha_hora_in, cio.fecha_hora_out) as cantidad,
rh.precio_base as monto

from hotel.Reserva r, hotel.Regimen_Hotel rh, hotel.Regimen reg, hotel.Check_In_Out cio

where r.cod_tipo_regimen = rh.cod_regimen
and r.cod_hotel = rh.cod_hotel
and reg.codigo = r.cod_tipo_regimen
and r.codigo = cio.cod_reserva
and r.codigo = @Codigo_Reserva

end
go

CREATE PROCEDURE [hotel].[sp_registrar_item]
	@Numero_Factura numeric(18,0), @Numero_Reserva numeric(18,0),
	@Cantidad numeric(18,0), @Precio numeric(18,2), @Codigo_Consumo numeric(18,0) 
AS

BEGIN
declare @Codigo_Habitacion numeric(18,0);

select @Codigo_Habitacion = r.cod_hotel from hotel.Reserva r
	where r.codigo = @Numero_Reserva;
	
insert into hotel.Item_Factura (cod_consumo, cod_cabezera_factura, 
	cod_habitacion, cantidad, monto)
	values (@Codigo_Consumo, @Numero_Factura, @Codigo_Habitacion, @Cantidad, @Precio);

END;
go 

CREATE PROCEDURE [hotel].[sp_registrar_cabecera_factura] 
	@Numero_Factura numeric(18,0), @Fecha datetime, @Numero_Reserva numeric(18,0),
	@metodoPago tinyint, @Total numeric(18,0)
AS
BEGIN
insert into hotel.Cabezera_Factura (codigo, reserva, fecha, metodo_pago, total, estado)
	values (@Numero_Factura, @Numero_Reserva, @Fecha, @metodoPago, @Total, 0);
END;
go

--metodo de pago
CREATE TABLE [hotel].[metodo_pago](
	[codigo] [tinyint] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_metodo_pago] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

insert into hotel.metodo_pago (codigo, descripcion) values (0, 'Sin informacion')
insert into hotel.metodo_pago (codigo, descripcion) values (1, 'Efectivo')
insert into hotel.metodo_pago (codigo, descripcion) values (2, 'Tarjeta de credito')

go

--Tarjeta
CREATE PROCEDURE hotel.sp_registrar_tarjeta 
@codigoReserva numeric(18,0), @numeroTarjeta numeric(18,0),
@emision datetime, @vencimiento datetime
AS
BEGIN
INSERT INTO hotel.Tarjeta (codigo_Reserva, num_tarjeta, fecha_vence, fecha_emision) values
	(@codigoReserva, @numeroTarjeta, @emision, @vencimiento);
END;


go
-----------------------------------------------------------------
CREATE PROCEDURE hotel.SP_GETREGIMENporHOTEL
	@hotel numeric
AS
BEGIN
	select re.codigo, re.descripcion from hotel.Regimen_Hotel r
	join hotel.Regimen re ON r.cod_regimen = re.codigo AND @hotel = r.cod_hotel
	order by 2
END
GO

CREATE PROCEDURE hotel.SP_GETTIPOHABITACIONporHOTEL
	@hotel numeric
AS
BEGIN
	select ha.cod_tipo_habitacion as codigo, ta.descripcion from hotel.Habitacion ha
	join hotel.Hotel ho ON ho.codigo = @hotel AND ha.cod_hotel = @hotel AND ha.estado = 1
	join hotel.Tipo_Habitacion ta ON ha.cod_tipo_habitacion = ta.codigo
	group by ha.cod_tipo_habitacion, ta.descripcion
	order by 2
END
GO

CREATE PROCEDURE hotel.SP_GETREGIMENporHOTELyHabilitado
	@hotel numeric
AS
BEGIN
	select re.codigo, re.descripcion from hotel.Regimen_Hotel r
	join hotel.Regimen re ON r.cod_regimen = re.codigo AND @hotel = r.cod_hotel AND r.estado = 1
	order by 2
END
GO

CREATE PROCEDURE hotel.SP_GETHAB_DISPporHotel
	@hotel varchar(10), @desde varchar(10), @hasta varchar(10)
AS
BEGIN
	select cod_habitacion, tha.descripcion
	from hotel.Reserva r
	join hotel.Reserva_Habitacion rh ON rh.cod_reserva = r.codigo 
		AND (r.cod_estado = 1 or r.cod_estado = 2) 
		AND (CONVERT(char(10), r.fecha_hasta,126) < CONVERT(varchar(20), CAST(@desde as DATE),126)
		OR CONVERT(char(10), r.fecha_desde,126) >CONVERT(varchar(20), CAST(@hasta as DATE),126))
	join hotel.Habitacion ha ON ha.codigo = rh.cod_habitacion AND ha.cod_hotel = @hotel AND ha.estado = 1
	join hotel.Tipo_Habitacion tha ON ha.cod_tipo_habitacion = tha.codigo
	group by cod_habitacion, tha.descripcion
	order by 2
END
GO

CREATE FUNCTION hotel.FN_GET_PRECIO_BASE(@habitacion integer, @hotel integer, @regimen integer)
RETURNS integer
AS
BEGIN
RETURN ISNULL((SELECT ho.precio_base
		FROM hotel.Habitacion ha
		JOIN hotel.Hotel h ON h.codigo = @hotel AND ha.codigo = @habitacion
		JOIN hotel.Regimen_Hotel ho ON ho.cod_hotel = @hotel 
			AND ho.cod_regimen = @regimen AND ho.estado = 1),0)
END
GO

CREATE PROCEDURE hotel.SP_GETHAB_BY_RESERVA
	@hotel varchar(10), @reserva varchar(20)
AS
BEGIN
	select cod_habitacion, tha.descripcion
	from hotel.Reserva_Habitacion rh 
	join hotel.Habitacion ha ON ha.codigo = rh.cod_habitacion 
		AND ha.cod_hotel = @hotel 
		AND rh.cod_reserva = @reserva 
	join hotel.Tipo_Habitacion tha ON ha.cod_tipo_habitacion = tha.codigo
	group by cod_habitacion, tha.descripcion
	order by 2
END
GO


CREATE PROCEDURE hotel.SP_UPDRESERVA
(
@codigo numeric,
@cod_hotel numeric,
@fecha_desde datetime,
@fecha_hasta datetime,
@cant_huespedes numeric,
@cod_tipo_regimen numeric,
@cod_estado numeric,
@cod_usuario_carga numeric,
@cant_noches numeric,
@cod_persona numeric,
@fecha_creacion datetime

)AS 
BEGIN
	update hotel.Reserva
	set
		cod_hotel = @cod_hotel,
		fecha_desde = @fecha_desde,
		fecha_hasta = @fecha_hasta,
		cant_huespedes = @cant_huespedes,
		cod_tipo_regimen = @cod_tipo_regimen,
		cod_estado = @cod_estado,
		cod_usuario_carga = @cod_usuario_carga,
		cant_noches = @cant_noches,
		cod_persona = @cod_persona,
		fecha_creacion = @fecha_creacion
	WHERE codigo = @codigo
END
GO

CREATE PROCEDURE hotel.SP_UPDESTADIA
(
@codigo numeric,
@fecha_out datetime,
@cod_user_out numeric
)AS 
BEGIN
	update hotel.Check_In_Out
	set
		fecha_hora_out = @fecha_out,
		cod_usuario_carga_out = @cod_user_out,
		cant_noches_estadia = DATEDIFF(day, fecha_hora_in, @fecha_out)
	WHERE codigo = @codigo
END
GO
-----------------------------------------------------------------------------------
  
 create procedure hotel.GETHabitacionesHotel(@CodHotel decimal)
 as begin
  select h.codigo, h.numero,h.piso,h.ubicacion_frente,t.descripcion TipoHab,h.descripcion,h.estado
  from hotel.Habitacion h, hotel.Tipo_Habitacion t
  where t.codigo = h.cod_tipo_habitacion
  and h.cod_hotel = @CodHotel
  end
 
 go
  -------------------------

-- Listado estadistico


create procedure hotel.SP_EstadisticaTopHotelReservaCancelada (@trimestre nvarchar(15), @año int)
as begin
	declare @mesIni int
	declare @mesFin int
	
	if(@trimestre = 'Primero')
	begin
		set @mesIni = 1
		set @mesFin = 3
	end
	
	if(@trimestre = 'Segundo')
	begin
		set @mesIni = 4
		set @mesFin = 6
	end
	
	if(@trimestre = 'Tercero')
	begin
		set @mesIni = 7
		set @mesFin = 9
	end
	
	if(@trimestre = 'Cuarto')
	begin
		set @mesIni = 10
		set @mesFin = 12
	end
	
	 select top 5 h.ciudad,h.nom_calle,h.num_calle,h.pais,h.nombre, COUNT(ca.cod_reserva) cantReservaCanceladas
	from hotel.Hotel h, hotel.Auditoria_Reserva ca, hotel.Reserva re
	where ca.motivo like 'Baja %' and re.cod_hotel = h.codigo and ca.cod_reserva = re.codigo
	and month(ca.fecha) > = @mesIni and MONTH(ca.fecha) <= @mesFin and YEAR(ca.fecha) = @año
	group by h.ciudad,h.nom_calle,h.num_calle,h.pais,h.nombre
	order by 6 desc

end

go

create procedure hotel.SP_EstadisticaTopHotelConsumibleFacturado (@trimestre nvarchar(15), @año int)
as begin
	declare @mesIni int
	declare @mesFin int
	
	if(@trimestre = 'Primero')
	begin
		set @mesIni = 1
		set @mesFin = 3
	end
	
	if(@trimestre = 'Segundo')
	begin
		set @mesIni = 4
		set @mesFin = 6
	end
	
	if(@trimestre = 'Tercero')
	begin
		set @mesIni = 7
		set @mesFin = 9
	end
	
	if(@trimestre = 'Cuarto')
	begin
		set @mesIni = 10
		set @mesFin = 12
	end
	
	 select top 5 h.ciudad,h.nom_calle,h.num_calle,h.pais,h.nombre, sum(it.cantidad) cantConsumiblesRegitrados
	from hotel.Hotel h, hotel.Item_Factura it, hotel.Cabezera_Factura ca, hotel.Reserva reserv
	where ca.codigo = it.cod_cabezera_factura and h.codigo = reserv.cod_hotel and ca.reserva = reserv.codigo
	and month(ca.fecha) > = @mesIni and MONTH(ca.fecha) <= @mesFin and YEAR(ca.fecha) = @año
	group by h.ciudad,h.nom_calle,h.num_calle,h.pais,h.nombre
	order by 6 desc

end

go

create procedure hotel.SP_EstadisticaTopHotelDiasOut (@trimestre nvarchar(15), @año int)
as begin
	declare @mesIni int
	declare @mesFin int
	
	if(@trimestre = 'Primero')
	begin
		set @mesIni = 1
		set @mesFin = 3
	end
	
	if(@trimestre = 'Segundo')
	begin
		set @mesIni = 4
		set @mesFin = 6
	end
	
	if(@trimestre = 'Tercero')
	begin
		set @mesIni = 7
		set @mesFin = 9
	end
	
	if(@trimestre = 'Cuarto')
	begin
		set @mesIni = 10
		set @mesFin = 12
	end
	
	 select top 5 h.ciudad,h.nom_calle,h.num_calle,h.pais,h.nombre, SUM(datediff(day,ca.fecha_desde,ca.fecha_hasta)) cantDiasOut
	from hotel.Hotel h, hotel.Cancelacion_Hotel ca
	where ca.cod_hotel = h.codigo
	and month(ca.fecha_desde) > = @mesIni and MONTH(ca.fecha_hasta) <= @mesFin and YEAR(ca.fecha_desde) = @año and YEAR(ca.fecha_hasta) = @año
	group by h.ciudad,h.nom_calle,h.num_calle,h.pais,h.nombre
	order by 6 desc

end

go

create procedure hotel.SP_EstadisticaTopHabitacionVecesOcupadas (@trimestre nvarchar(15), @año int)
as begin
	declare @mesIni int
	declare @mesFin int
	
	if(@trimestre = 'Primero')
	begin
		set @mesIni = 1
		set @mesFin = 3
	end
	
	if(@trimestre = 'Segundo')
	begin
		set @mesIni = 4
		set @mesFin = 6
	end
	
	if(@trimestre = 'Tercero')
	begin
		set @mesIni = 7
		set @mesFin = 9
	end
	
	if(@trimestre = 'Cuarto')
	begin
		set @mesIni = 10
		set @mesFin = 12
	end
	
	select top 5 h.numero,h.piso,h.ubicacion_frente,ho.nom_calle CalleHotel, ho.num_calle NumCalleHotel, count(ck.codigo) cantVecesOcupadas
	from hotel.Habitacion h, hotel.hotel ho, hotel.Check_In_Out ck, hotel.Reserva res
	where h.cod_hotel = ho.codigo and res.cod_hotel = ho.codigo and ck.cod_reserva = res.codigo
	and month(ck.fecha_hora_in) > = @mesIni and MONTH(ck.fecha_hora_out) <= @mesFin and YEAR(ck.fecha_hora_in) = @año and YEAR(ck.fecha_hora_out) = @año
	group by h.numero,h.piso,h.ubicacion_frente,ho.nom_calle, ho.num_calle
	order by 6 desc

end

go

create procedure hotel.SP_EstadisticaTopClientes (@trimestre nvarchar(15), @año int)
as begin
	declare @mesIni int
	declare @mesFin int
		
	if(@trimestre = 'Primero')
	begin
		set @mesIni = 1
		set @mesFin = 3
	end
	
	if(@trimestre = 'Segundo')
	begin
		set @mesIni = 4
		set @mesFin = 6
	end
	
	if(@trimestre = 'Tercero')
	begin
		set @mesIni = 7
		set @mesFin = 9
	end
	
	if(@trimestre = 'Cuarto')
	begin
		set @mesIni = 10
		set @mesFin = 12
	end
	
	select top 5
	sum( ( case when it.cod_consumo is null then (it.monto / 10) else 0 end) +
			(CASE WHEN it.cod_consumo is not null THEN ((it.monto * it.cantidad)/5) ELSE 0 END 
			)) Puntos, p.apellido,p.nombre,p.nacionalidad,p.num_doc
	from 
		hotel.Reserva r,
		hotel.Persona p,
		hotel.Item_Factura it,
		hotel.Cabezera_Factura cf
		
	where it.cod_cabezera_factura = cf.codigo
	and cf.reserva = r.codigo
	and r.cod_persona = p.codigo
	
	and month(cf.fecha) > = @mesIni and MONTH(cf.fecha) <= @mesFin 
	and year(cf.fecha) = @año
	
	group by p.apellido,p.nombre,p.nacionalidad,p.num_doc
	order by 1 desc
	
end
go

--- fin


