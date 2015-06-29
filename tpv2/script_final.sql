use [GD1C2015]
GO
--Creo el esquema.
--CREATE SCHEMA [NEW_SOLUTION];
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
--------------------
--	Crear tablas  --
--------------------

--Borro las tablas por si ya existen.
IF (OBJECT_ID('[NEW_SOLUTION].Login') is not null)					drop table [NEW_SOLUTION].Login
IF (OBJECT_ID('[NEW_SOLUTION].Login_incorrectos') is not null)		drop table [NEW_SOLUTION].Login_incorrectos
IF (OBJECT_ID('[NEW_SOLUTION].Usuarios') is not null)				drop table [NEW_SOLUTION].Usuarios
IF (OBJECT_ID('[NEW_SOLUTION].Usuarios_roles') is not null)			drop table [NEW_SOLUTION].Usuarios_roles
IF (OBJECT_ID('[NEW_SOLUTION].Roles') is not null)					drop table [NEW_SOLUTION].Roles
IF (OBJECT_ID('[NEW_SOLUTION].Estados') is not null)				drop table [NEW_SOLUTION].Estados
IF (OBJECT_ID('[NEW_SOLUTION].Documentos_tipo') is not null)		drop table [NEW_SOLUTION].Documentos_tipo
IF (OBJECT_ID('[NEW_SOLUTION].Rol_funcionalidades') is not null)	drop table [NEW_SOLUTION].Rol_funcionalidades
IF (OBJECT_ID('[NEW_SOLUTION].Funcionalidades') is not null)		drop table [NEW_SOLUTION].Funcionalidades
IF (OBJECT_ID('[NEW_SOLUTION].Monedas') is not null)				drop table [NEW_SOLUTION].Monedas
IF (OBJECT_ID('[NEW_SOLUTION].Tarjetas') is not null)				drop table [NEW_SOLUTION].Tarjetas
IF (OBJECT_ID('[NEW_SOLUTION].Tarjetas_emisores') is not null)		drop table [NEW_SOLUTION].Tarjetas_emisores
IF (OBJECT_ID('[NEW_SOLUTION].Depositos') is not null)				drop table [NEW_SOLUTION].Depositos
IF (OBJECT_ID('[NEW_SOLUTION].Cuentas') is not null)				drop table [NEW_SOLUTION].Cuentas
IF (OBJECT_ID('[NEW_SOLUTION].Cuentas_categ') is not null)			drop table [NEW_SOLUTION].Cuentas_categ
IF (OBJECT_ID('[NEW_SOLUTION].Retiros') is not null)				drop table [NEW_SOLUTION].Retiros
IF (OBJECT_ID('[NEW_SOLUTION].Bancos') is not null)					drop table [NEW_SOLUTION].Bancos
IF (OBJECT_ID('[NEW_SOLUTION].Cheques') is not null)				drop table [NEW_SOLUTION].Cheques
IF (OBJECT_ID('[NEW_SOLUTION].Transferencias') is not null)			drop table [NEW_SOLUTION].Transferencias
IF (OBJECT_ID('[NEW_SOLUTION].Clientes') is not null)				drop table [NEW_SOLUTION].Clientes
IF (OBJECT_ID('[NEW_SOLUTION].Paises') is not null)					drop table [NEW_SOLUTION].Paises
IF (OBJECT_ID('[NEW_SOLUTION].Facturas_costos') is not null)		drop table [NEW_SOLUTION].Facturas_costos
IF (OBJECT_ID('[NEW_SOLUTION].Facturas') is not null)				drop table [NEW_SOLUTION].Facturas
IF (OBJECT_ID('[NEW_SOLUTION].Facturas_conceptos') is not null)		drop table [NEW_SOLUTION].Facturas_conceptos
IF (OBJECT_ID('tempdb..#temp_maestra') is not null)					drop table #temp_maestra

--Tabla de Login.
create table NEW_SOLUTION.Login
(
	login_id		bigint identity(1,1),
	login_user		varchar(50),
	login_user_id	int,
	login_fecha		datetime,
	login_resultado	varchar(1),
	primary key(login_id)	
)

--Tabla de logins incorrectos.
create table NEW_SOLUTION.Login_incorrectos
(
	logfalla_id			bigint identity(1,1),
	logfalla_user		varchar(50),
	logfalla_user_id	int,
	logfalla_intento	int,
	primary key(logfalla_id)	
)

--Tabla de usuarios.
create table NEW_SOLUTION.Usuarios
(
	usu_id				int identity(1,1),
	usu_nombre			varchar(50),
	usu_password		varchar(255),
	usu_fecCreacion		datetime,
	usu_fecUltmodif	    datetime,
	usu_pregSecreta		varchar(200),
	usu_respSecreta		varchar(100),
	usu_estado			varchar(1) DEFAULT 's',
	usu_cli_id			bigint,
	primary key(usu_nombre)
)

--create index ix_usuarios_id on NEW_SOLUTION.Usuarios(usu_id);

--Tabla de roles.
create table NEW_SOLUTION.Usuarios_roles
(
	usu_id		bigint,
	rol_id		bigint,
	primary key(usu_id,rol_id)
)

--Tabla de roles.
create table NEW_SOLUTION.Roles
(
	rol_id		int,
	rol_nombre  varchar(100),
	rol_estado	varchar(1) DEFAULT 's'
)

--Tabla de relacion de roles con funcionalidades.
create table NEW_SOLUTION.Rol_funcionalidades
(
	rol_id	 int,
	func_id	 int,
	primary key(rol_id,func_id)	
)

--Tabla de funcionalidades.
create table NEW_SOLUTION.Funcionalidades
(
	func_id		int,
	func_nombre	varchar(200)
)

--Tabla de Monedas.
create table NEW_SOLUTION.Monedas
(
	moneda_id int,
	moneda_descrip varchar(100)
)

--Tabla de Tarjetas
create table NEW_SOLUTION.Tarjetas
(
	tarj_id				bigint identity(1,1),
	tarj_numero			varchar(16),
	tarj_fecemision		datetime,
	tarj_fecvencimiento datetime,
	tarj_codseguridad	varchar(3),
	tarj_emisor			int,
	tarj_estado			int,
	tarj_cli_id			bigint,
	primary key(tarj_id)
)

--Tabla de emisores de tarjetas
create table NEW_SOLUTION.Tarjetas_emisores
(
	tarjemis_id		bigint identity(1,1),
	tarjemis_nombre varchar(255),
	primary key(tarjemis_id)
)

--Tabla de depositos.
create table NEW_SOLUTION.Depositos
(
	depo_id			bigint identity(1,1),
	depo_cuenta		numeric(18,0),
	depo_moneda		int,
	depo_tarj_id	bigint,
	depo_fecha		datetime,
	depo_importe	numeric(18,2),
	primary key(depo_id)
)

--create index ix_1_depo_id  on NEW_SOLUTION.Depositos(depo_id)
--create index ix_2_depo_cta on NEW_SOLUTION.Depositos(depo_cuenta)

--Tabla de  estados
create table NEW_SOLUTION.Estados
(
	estado_codigo	int,
	estado_descrip	varchar(15)
)

--Tabla de Cuentas
create table NEW_SOLUTION.Cuentas
(
	cta_num				numeric(18,0),
	cta_cli_id			bigint,
	cta_pais_apertura	int,
	cta_moneda			int,
	cta_tipo			int,
	cta_fecha_cierre	datetime,	
	cta_estado			int,
	cta_saldo			numeric(18,2),
	cta_num_suscrip		int,
	primary key(cta_num)	
)

--Tabla de categorias de cuentas.
create table NEW_SOLUTION.Cuentas_categ
(
	ctacateg_id				int identity(1,1),
	ctacateg_descrip		varchar(100),
	ctacateg_costo			numeric(18,2),
	ctacateg_duracion_dias   int
)

--Tabla con los Retiros
create table NEW_SOLUTION.Retiros
(
	ret_id bigint identity(1,1),
	ret_fecha datetime,
	ret_cli_id bigint,	
	ret_num_cheque numeric(18,0),
	ret_cta_num numeric(18,0)
)

--Tabla con los Bancos.
create table NEW_SOLUTION.Bancos
(
	bco_cod			numeric(18,0),
	bco_nombre		varchar(255),
	bco_direccion	varchar(255),
	primary key(bco_cod)	
)

--Tabla con los cheques.
create table NEW_SOLUTION.Cheques
(
	chq_num			numeric(18,0),
	chq_importe		numeric(18,2),
	chq_cli_id		bigint,
	chq_cod_bco		numeric(18,0),
	chq_fecha	    datetime
	primary key(chq_num)
)

--Tabla de transferencias.
create table NEW_SOLUTION.Transferencias
(
	transf_id			bigint identity(1,1),
	transf_cta_origen	numeric(18,0),
	transf_cta_destino	numeric(18,0),
	transf_importe		numeric(18,2),
	transf_fecha		datetime,
	transf_cli_id		bigint,
	transf_costo		numeric(18,2),
	primary key(transf_id)	
)

--Tabla de clientes
Create table NEW_SOLUTION.Clientes
(
	cli_id				bigint identity(1,1),
	cli_nombre			varchar(255),
	cli_apellido		varchar(255),
	cli_tdoc			numeric(18,0),
	cli_ndoc			numeric(18,0),
	cli_pdoc			numeric(18,0),
	cli_mail			varchar(255),-- unique,
	cli_calle			varchar(255),
	cli_numero			varchar(50),
	cli_piso			numeric(18,0),
	cli_depto			varchar(10),
	cli_localidad		varchar(100),
	cli_nacionalidad	int,
	cli_fecnac			datetime,
	cli_estado			varchar(1) default 's',
	cli_inconsistencia  int--,
	--primary key(cli_id)
)

--create index ix_clientes_id on NEW_SOLUTION.Clientes(cli_id);

--Tabla de tipo de documentos
create table NEW_SOLUTION.Documentos_tipo
(
	tdoc_cod		numeric(18,0),
	tdoc_descrip	varchar(255)
)

--Tabla de paises
create table NEW_SOLUTION.Paises
(
	--pais_id		  int identity(1,1),
	pais_cod	  numeric(18,0),
	pais_descrip  varchar(255)
)

--Tabla de facturas costos
create table NEW_SOLUTION.Facturas_costos
(
	factcto_num_op	bigint,
	factcto_tipo_op int,
	factcto_cta_origen bigint,
	factcto_importe numeric(18,2),
	factcto_fecha datetime,
	factcto_costo numeric(18,2),
	faccto_fact_id bigint,
	factcto_estado int	
)

--Tabla de conceptos de facturas.
create table NEW_SOLUTION.Facturas_conceptos
(
	fact_comp_id int identity(1,1),
	fact_comp_descrip varchar(255)
)

--Tabla de facturas
create table NEW_SOLUTION.Facturas
(
	fact_id			bigint identity(1,1),
	fact_cta_num	numeric(18,8),
	fact_total		numeric(18,2),
	fact_cli_id		bigint,
	primary key(fact_id)
)

--create index ix_1_fact_cli_id on NEW_SOLUTION.Facturas(fact_cli_id)
--create index ix_1_fact_id     on NEW_SOLUTION.Facturas(fact_id)

------------------------------------
--	Carga de datos en las tablas  --
------------------------------------

--Cargar paises
insert into NEW_SOLUTION.paises(pais_cod,pais_descrip)
select a.codigo,
	   a.pais
from
(
	select  distinct
			cli_pais_codigo as codigo,
			cli_pais_desc	as pais
	FROM    gd_esquema.[Maestra]
	union all
	select  distinct
			Cuenta_Pais_Codigo	as codigo,	
			Cuenta_Pais_desc	as pais
	FROM    gd_esquema.[Maestra]
)as a

--Cargar documentos
insert into NEW_SOLUTION.Documentos_tipo
select distinct
	   cli_tipo_doc_cod,
	   cli_tipo_doc_desc
from gd_esquema.Maestra

--Cargar monedas
insert into NEW_SOLUTION.Monedas(moneda_id,moneda_descrip) values(1,'Dolares')

--Cargar tabla de bancos.
insert into NEW_SOLUTION.Bancos(bco_cod,bco_nombre,bco_direccion)
select  distinct
		Banco_Cogido,
		Banco_Nombre,
		Banco_Direccion
from	gd_esquema.Maestra
where  Banco_Cogido is not null
	
--Cargar funcionalidades.
insert into NEW_SOLUTION.Funcionalidades(func_id,func_nombre) 
values
	(1,'Rol'),
	(2,'Usuario'),
	(3,'Cliente'),
	(4,'Cuenta'),
	(10,'Listados')
--Completar con las que faltan.

--Cargar roles
insert into NEW_SOLUTION.Roles(rol_id,rol_nombre) 
values
	(1,'Administrador'),
	(2,'Cliente')

--Cargar la relaciones de roles con funcionalidades.
insert into NEW_SOLUTION.Rol_funcionalidades(rol_id,func_id) 
values
	(1,1),
	(1,2),
	(1,3),
	(1,10),
	(2,4)

--Cargar en tabla estados
insert into NEW_SOLUTION.Estados(estado_codigo,estado_descrip) values(1,'Cliente activo')
insert into NEW_SOLUTION.Estados(estado_codigo,estado_descrip) values(2,'Usuario activo')



--Cargar clientes, resta tener en cuenta tipos diferentes de emails e inconcistencias.
/*
Create table NEW_SOLUTION.Clientes
(
	cli_id				bigint,
	cli_nombre			varchar(255),
	cli_apellido		varchar(255),
	cli_tdoc			numeric(18,0),
	cli_ndoc			numeric(18,0),
	cli_pdoc			numeric(18,0),
	cli_mail			varchar(255),-- unique,
	cli_calle			varchar(255),
	cli_numero			varchar(50),
	cli_piso			numeric(18,0),
	cli_depto			varchar(10),
	cli_localidad		varchar(100),
	cli_nacionalidad	int,
	cli_fecnac			datetime,
	cli_estado			varchar(1) default 's',
	cli_inconsistencia  int--,
	--primary key(cli_id)
)
*/
insert into NEW_SOLUTION.Clientes
select distinct
	 /* (
		convert(varchar,a.Cli_Pais_codigo)+
		convert(varchar,a.Cli_Tipo_Doc_Cod)+
		convert(varchar,a.Cli_Nro_Doc)
	  ),*/
      a.[Cli_Nombre],
      a.[Cli_Apellido],
      a.[Cli_Tipo_Doc_Cod],      
      a.[Cli_Nro_Doc],
	 -- b.pais_cod, -- ver
	 null,
	  a.[Cli_Mail],
      a.[Cli_Dom_Calle],
      a.[Cli_Dom_Nro],
      a.[Cli_Dom_Piso],
      a.[Cli_Dom_Depto],
      null,
      b.pais_cod,
      a.[Cli_Fecha_Nac],
      's',
      null
FROM gd_esquema.[Maestra] as a
left join NEW_SOLUTION.Paises as b on b.pais_cod = a.Cli_Pais_codigo
go

--Crear tabla de Usuarios

--Cargar usuarios con rol administrador

create function NEW_SOLUTION.f_get_id(@username varchar(255))
RETURNS int
AS BEGIN
	declare @id_usuario int;
	select 
		@id_usuario = u.usu_id 
	from 
		NEW_SOLUTION.Usuarios u
	where 
		u.usu_nombre = @username;	
	RETURN @id_usuario;
END
go

insert into 
	NEW_SOLUTION.Usuarios(usu_nombre, usu_password)
values 
	('a', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),
	('b', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),
	('c', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),
	('d', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),
	('e', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),
	('f', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),
	('g', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),
	('h', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')

insert into 
	NEW_SOLUTION.Usuarios_roles (usu_id, rol_id)
values 
	(NEW_SOLUTION.f_get_id('a'), 1),
	(NEW_SOLUTION.f_get_id('b'), 1),
	(NEW_SOLUTION.f_get_id('c'), 1),
	(NEW_SOLUTION.f_get_id('d'), 1),
	(NEW_SOLUTION.f_get_id('e'), 1),
	(NEW_SOLUTION.f_get_id('f'), 1),
	(NEW_SOLUTION.f_get_id('g'), 1),
	(NEW_SOLUTION.f_get_id('h'), 1)

--	Usuario  : (1ra letra Nombre)+(1ra letra apellido)+Ndoc , Password : primeros 4 numeros del numero de documento.
insert into NEW_SOLUTION.Usuarios
(
	usu_nombre,
	usu_password,
	usu_fecUltmodif,
	usu_pregSecreta,
	usu_respSecreta,
	usu_estado,
	usu_cli_id
)
select	distinct
		substring((upper(SUBSTRING(cli_nombre,0,2)+SUBSTRING(cli_apellido,0,2))+''+convert(varchar,cli_ndoc)),0,50),
		substring(CONVERT(varchar,cli_ndoc),0,5),
		null,
		'',
		'',
		's',	
		cli_id
from NEW_SOLUTION.Clientes

--Cargar emisores de tarjetas de creditos.
insert  into NEW_SOLUTION.Tarjetas_emisores(tarjemis_nombre)
select  distinct
		Tarjeta_Emisor_Descripcion
from	gd_esquema.Maestra

--Cargar tarjetas de creditos.
insert into NEW_SOLUTION.Tarjetas(tarj_numero,tarj_fecemision,tarj_fecvencimiento,tarj_codseguridad,tarj_emisor,tarj_estado,tarj_cli_id)
select a.Tarjeta_Numero,
	   a.Tarjeta_Fecha_Emision,
	   a.Tarjeta_Fecha_Vencimiento,
	   a.Tarjeta_Codigo_Seg,
	   b.tarjemis_id,
	   0,
	  (convert(varchar,a.Cli_Pais_codigo)+convert(varchar,a.Cli_Tipo_Doc_Cod)+convert(varchar,a.Cli_Nro_Doc))	  
from gd_esquema.maestra as a
left join NEW_SOLUTION.Tarjetas_emisores as b on b.tarjemis_nombre=a.Tarjeta_Emisor_Descripcion
where  Tarjeta_Numero is not null

--Cargar depositos	  
insert into NEW_SOLUTION.depositos
(
	depo_cuenta,
	depo_moneda,
	depo_tarj_id,
	depo_fecha,
	depo_importe	
)
select distinct 
	   Deposito_Codigo,	   
	   1,
	   null,
	   Deposito_Fecha,
	   Deposito_Importe
from gd_esquema.Maestra
where Deposito_Codigo is not null

--Cargar tabla de categorias de cuentas.
insert into NEW_SOLUTION.Cuentas_categ(ctacateg_descrip,ctacateg_costo,ctacateg_duracion_dias) values('Oro',0,0)
insert into NEW_SOLUTION.Cuentas_categ(ctacateg_descrip,ctacateg_costo,ctacateg_duracion_dias) values('Plata',0,0)
insert into NEW_SOLUTION.Cuentas_categ(ctacateg_descrip,ctacateg_costo,ctacateg_duracion_dias) values('Bronce',0,0)
insert into NEW_SOLUTION.Cuentas_categ(ctacateg_descrip,ctacateg_costo,ctacateg_duracion_dias) values('Gratuitas',0,0)

--Cargar tabla de cuentas.
insert into NEW_SOLUTION.Cuentas
(
	cta_num,
	cta_pais_apertura--,
	--cta_moneda,
	--cta_tipo,
	--cta_fecha_cierre,
	--cta_estado
)
select  distinct
		a.Cuenta_Numero,
		b.pais_cod		
		--1,
		--1,
		--a.Cuenta_Fecha_Cierre,
		--1
from	  gd_esquema.Maestra  as a
left join NEW_SOLUTION.Paises as b on b.pais_cod=a.Cuenta_Pais_Codigo

--Cargar tabla de transferencias.
insert into NEW_SOLUTION.Transferencias
(
	transf_cta_origen,
	transf_cta_destino,
	transf_importe,
	transf_fecha,
	transf_cli_id,
	transf_costo
)
select  distinct
		a.Cuenta_Numero,
		a.Cuenta_Dest_Numero,
		a.Trans_Importe,
		a.Transf_Fecha,		
		(
			convert(varchar,a.Cli_Pais_codigo)+
			convert(varchar,a.Cli_Tipo_Doc_Cod)+
			convert(varchar,a.Cli_Nro_Doc)
		),
		0		
from	gd_esquema.Maestra  as a 

--Cargar retiros.
insert into NEW_SOLUTION.Retiros
(
	ret_fecha,
	ret_cli_id,
	ret_num_cheque,
	ret_cta_num
)
select  a.retiro_fecha,
		(
			convert(varchar,a.Cli_Pais_codigo)+
			convert(varchar,a.Cli_Tipo_Doc_Cod)+
			convert(varchar,a.Cli_Nro_Doc)
		),
		a.Cheque_Numero,
		a.Cuenta_Numero
from    gd_esquema.Maestra as a
where   a.Retiro_Fecha is not null

--Cargar cheques
insert into NEW_SOLUTION.Cheques
(
	chq_num,
	chq_importe,
	chq_cli_id,
	chq_fecha,
	chq_cod_bco
)
select  distinct
		a.cheque_numero,
		a.cheque_importe,
		(
			convert(varchar,a.Cli_Pais_codigo)+
			convert(varchar,a.Cli_Tipo_Doc_Cod)+
			convert(varchar,a.Cli_Nro_Doc)
		),		
		a.cheque_fecha,
		a.banco_cogido
from	gd_esquema.Maestra as a
where   a.cheque_numero is not null
go


/**************************************************************************
				VIEWS
**************************************************************************/
/*
create view NEW_SOLUTION.v_usuarios_activos
as
	select
		u.usu_id,
		u.usu_password,
		u.usu_nombre,
		u.usu_fecCreacion,
		u.usu_fecUltmodif,
		u.usu_pregSecreta,
		u.usu_respSecreta,
		u.usu_estado
	from
		NEW_SOLUTION.Usuarios u
	where 
		u.usu_estado <> 'n'			
go*/

create view NEW_SOLUTION.v_usuarios_inactivos
as
	select
		u.usu_id,
		u.usu_password,
		u.usu_nombre,
		u.usu_fecCreacion,
		u.usu_fecUltmodif,
		u.usu_pregSecreta,
		u.usu_respSecreta,
		u.usu_estado
	from
		NEW_SOLUTION.usuarios u
	where 
		u.usu_estado <> 's'			
go


/**************************************************************************
				TRIGGERS
**************************************************************************/


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



/**************************************************************************
				STORE PROCEDURES
**************************************************************************/


------------------------------------
--	FUNCIONALIDAD                 --
------------------------------------

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


------------------------------------
--	ROL                           --
------------------------------------

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

------------------------------------
--	USUARIO                       --
------------------------------------

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

-- obtiene un usuario, algunos o todos
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
	else if (@username is not null)
		select
			u.usu_id,
			u.usu_nombre,
			u.usu_estado,
			u.usu_cli_id
		from
			NEW_SOLUTION.Usuarios u
		where
			u.usu_nombre like @username+'%'
	else
		select
			u.usu_id,
			u.usu_nombre,
			u.usu_estado,
			u.usu_cli_id
		from
			NEW_SOLUTION.Usuarios u
			
end
go

-- actualiza password de un usuario
create procedure NEW_SOLUTION.sp_usuario_update
	@id_usuario int,
	@id_cliente bigint = null,
	@password varchar(255) = null
as
begin
	if(@id_cliente is not null)
	begin
		update 
			NEW_SOLUTION.Usuarios
		set 
			usu_cli_id = @id_cliente
		where
			usu_id = @id_usuario
	end
	else if (@password is not null)
	begin
		update 
			NEW_SOLUTION.Usuarios
		set 
			usu_password = @password
		where
			usu_id = @id_usuario 	
	end
end
go


------------------------------------
--	LOGIN                         --
------------------------------------

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
				set @resultado_login = @id_usuario
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

------------------------------------
--	TIPO DOCUMENTO                --
------------------------------------

create procedure NEW_SOLUTION.sp_tipo_identificacion_get
as
begin
	select 
		d.tdoc_cod,
		d.tdoc_descrip	
	from
		NEW_SOLUTION.Documentos_tipo d
end
go

------------------------------------
--	PAICES                        --
------------------------------------

create procedure NEW_SOLUTION.sp_pais_get
as
begin
	select 
		p.pais_cod,
		p.pais_descrip	
	from
		NEW_SOLUTION.Paises p
end
go
------------------------------------
--	CLIENTE                       --
------------------------------------


-- obtiene clientes con datos básicos por campos dinamicos 
-- o uno con todos sus datos en particular
create procedure NEW_SOLUTION.sp_cliente_get
	@nombre varchar(255) = null, 
	@apellido varchar(255) = null, 
	@mail varchar(255) = null,
	@identificacion int = null,
	@tipo_identificacion varchar(255) = null,
	@cliente_id bigint = null
as
begin
	if(@cliente_id is not null)
		select 
			c.cli_nombre,
			c.cli_apellido,
			c.cli_mail,
			c.cli_tdoc,
			c.cli_ndoc,
			c.cli_nacionalidad,
			c.cli_fecnac,
			c.cli_localidad,
			c.cli_calle,
			c.cli_numero,
			c.cli_depto,
			c.cli_estado,
			u.usu_id
		from 			
			NEW_SOLUTION.Clientes c
		join
			NEW_SOLUTION.Usuarios u on u.usu_cli_id = c.cli_id
		where 
			c.cli_id = @cliente_id
	else
		declare @query nvarchar(500);	
			set @query = ''
			set @query = @query +	'select '
			set @query = @query +		'cli_id, '
			set @query = @query +		'c.cli_apellido, '
			set @query = @query +		'c.cli_nombre, '
			set @query = @query +		'c.cli_mail, '
			set @query = @query +		'c.cli_tdoc, '
			set @query = @query +		'c.cli_ndoc, '
			set @query = @query +		'cli_estado '
			set @query = @query +	'from NEW_SOLUTION.Clientes c '			
			set @query = @query +	'where '
		if(@apellido is not null)			
			set @query = @query +		'c.cli_apellido like ''%' +@apellido + '%'' and '
		if(@nombre is not null)
			set @query = @query +		'c.cli_nombre like ''%' +@nombre + '%'' and '
		if(@mail is not null)
			set @query = @query +		'c.cli_mail like ''%' + @mail + '%'' and '
		if(@tipo_identificacion is not null)
			set @query = @query +		'c.cli_tdoc = ''' + @tipo_identificacion + ''' and '
		if(@identificacion is not null)
			set @query = @query +		'c.cli_ndoc like ''%'+ cast(@identificacion as varchar) +'%'' and '
		set @query = @query +			'1=1'
		print @query
		exec (@query)
end
go

/*
cli_id				bigint,
	cli_nombre			varchar(255),
	cli_apellido		varchar(255),
	cli_tdoc			numeric(18,0),
	cli_ndoc			numeric(18,0),
	cli_pdoc			numeric(18,0),
	cli_mail			varchar(255),-- unique,
	cli_calle			varchar(255),
	cli_numero			varchar(50),
	cli_piso			numeric(18,0),
	cli_depto			varchar(10),
	cli_localidad		varchar(100),
	cli_nacionalidad	int,
	cli_fecnac			datetime,
	cli_estado			varchar(1) default 's',
	cli_inconsistencia  int--,
	
	*/
create procedure NEW_SOLUTION.sp_cliente_add
	@nombre varchar(255),
    @apellido varchar(255),
    @mail varchar(255),
    @tipo_documento numeric(18,0),
    @documento numeric(18,0),
    @nacionalidad int
as
begin
	declare @id_result int;
	set @id_result = 1
	if exists (	select * from NEW_SOLUTION.Clientes c where c.cli_mail = @mail)
		begin
			set @id_result = -1
		end
	else
		begin
			insert into NEW_SOLUTION.Clientes(
				cli_apellido, 
				cli_nombre,
				cli_mail,
				cli_tdoc,
				cli_ndoc,
				cli_nacionalidad)
			values (
				@apellido,
				@nombre,
				@mail,
				@tipo_documento,
				@documento,
				@nacionalidad)
			set @id_result = scope_identity();
		end
	return @id_result;
end
go

create procedure NEW_SOLUTION.sp_cliente_update
	@id bigint,
	@nombre varchar(255),
    @apellido varchar(255),
    --@mail varchar(255),
    @tipo_documento numeric(18,0),
    @documento numeric(18,0),
    @nacionalidad int,
    @estado varchar(1)
as
begin
	declare @id_result int;
	set @id_result = 1
	/*
	if exists (	select * from NEW_SOLUTION.Clientes c where c.cli_mail = @mail)
		begin
			set @id_result = -1
		end
	else
		begin*/
			update NEW_SOLUTION.Clientes							
			set 
				cli_apellido = @apellido,
				cli_nombre = @nombre,
				--cli_mail = @mail,
				cli_tdoc = @tipo_documento,
				cli_ndoc = @documento,
				cli_nacionalidad = @nacionalidad,
				cli_estado = @estado
			where
				cli_id = @id;			
	--	end
	return @id_result;
end
go