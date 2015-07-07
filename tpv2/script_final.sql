--Creo el esquema.
CREATE SCHEMA [NEW_SOLUTION];
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
go
IF (OBJECT_ID('[NEW_SOLUTION].Login_incorrectos') is not null)		drop table [NEW_SOLUTION].Login_incorrectos
go
IF (OBJECT_ID('[NEW_SOLUTION].Usuarios') is not null)				drop table [NEW_SOLUTION].Usuarios
go
IF (OBJECT_ID('[NEW_SOLUTION].Usuarios_roles') is not null)			drop table [NEW_SOLUTION].Usuarios_roles
go
IF (OBJECT_ID('[NEW_SOLUTION].Roles') is not null)					drop table [NEW_SOLUTION].Roles
go
IF (OBJECT_ID('[NEW_SOLUTION].Estados') is not null)				drop table [NEW_SOLUTION].Estados
go
IF (OBJECT_ID('[NEW_SOLUTION].Documentos_tipo') is not null)		drop table [NEW_SOLUTION].Documentos_tipo
go
IF (OBJECT_ID('[NEW_SOLUTION].Rol_funcionalidades') is not null)	drop table [NEW_SOLUTION].Rol_funcionalidades
go
IF (OBJECT_ID('[NEW_SOLUTION].Funcionalidades') is not null)		drop table [NEW_SOLUTION].Funcionalidades
go
IF (OBJECT_ID('[NEW_SOLUTION].Monedas') is not null)				drop table [NEW_SOLUTION].Monedas
go
IF (OBJECT_ID('[NEW_SOLUTION].Tarjetas') is not null)				drop table [NEW_SOLUTION].Tarjetas
go
IF (OBJECT_ID('[NEW_SOLUTION].Tarjetas_emisores') is not null)		drop table [NEW_SOLUTION].Tarjetas_emisores
go
IF (OBJECT_ID('[NEW_SOLUTION].Depositos') is not null)				drop table [NEW_SOLUTION].Depositos
go
IF (OBJECT_ID('[NEW_SOLUTION].Cuentas') is not null)				drop table [NEW_SOLUTION].Cuentas
go
IF (OBJECT_ID('[NEW_SOLUTION].Cuentas_categ') is not null)			drop table [NEW_SOLUTION].Cuentas_categ
go
IF (OBJECT_ID('[NEW_SOLUTION].Retiros') is not null)				drop table [NEW_SOLUTION].Retiros
go
IF (OBJECT_ID('[NEW_SOLUTION].Bancos') is not null)					drop table [NEW_SOLUTION].Bancos
go
IF (OBJECT_ID('[NEW_SOLUTION].Cheques') is not null)				drop table [NEW_SOLUTION].Cheques
go
IF (OBJECT_ID('[NEW_SOLUTION].Transferencias') is not null)			drop table [NEW_SOLUTION].Transferencias
go
IF (OBJECT_ID('[NEW_SOLUTION].Clientes') is not null)				drop table [NEW_SOLUTION].Clientes
go
IF (OBJECT_ID('[NEW_SOLUTION].Paises') is not null)					drop table [NEW_SOLUTION].Paises
go
IF (OBJECT_ID('[NEW_SOLUTION].Facturas_costos') is not null)		drop table [NEW_SOLUTION].Facturas_costos
go
IF (OBJECT_ID('[NEW_SOLUTION].Facturas') is not null)				drop table [NEW_SOLUTION].Facturas
go
IF (OBJECT_ID('[NEW_SOLUTION].Facturas_conceptos') is not null)		drop table [NEW_SOLUTION].Facturas_conceptos
go
IF (OBJECT_ID('[NEW_SOLUTION].Roles_estado') is not null)			drop table [NEW_SOLUTION].Roles_estado
go
IF (OBJECT_ID('[NEW_SOLUTION].Clientes_estado') is not null)		drop table [NEW_SOLUTION].Clientes_estado
go
IF (OBJECT_ID('[NEW_SOLUTION].Usuarios_estado') is not null)		drop table [NEW_SOLUTION].Usuarios_estado
go
IF (OBJECT_ID('[NEW_SOLUTION].Cuentas_estado') is not null)			drop table [NEW_SOLUTION].Cuentas_estado
go
IF (OBJECT_ID('[NEW_SOLUTION].Tarjetas_estado') is not null)		drop table [NEW_SOLUTION].Tarjetas_estado
go

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
go

--Tabla de logins incorrectos.
create table NEW_SOLUTION.Login_incorrectos
(
	logfalla_id			bigint identity(1,1),
	logfalla_user		varchar(50),
	logfalla_user_id	int,
	logfalla_intento	int,
	primary key(logfalla_id)	
)
go

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
	usu_estado			int,
	usu_cli_id			bigint--,
	--primary key(usu_nombre)
)
go

create index ix_usuarios_id on NEW_SOLUTION.Usuarios(usu_id);
go

--Tabla de roles.
create table NEW_SOLUTION.Usuarios_roles
(
	usu_id		bigint,
	rol_id		bigint,
	primary key(usu_id,rol_id)
)
go

--Tabla de roles.
create table NEW_SOLUTION.Roles
(
	rol_id		int,
	rol_nombre  varchar(100),
	rol_estado	int
)
go

--Tabla de relacion de roles con funcionalidades.
create table NEW_SOLUTION.Rol_funcionalidades
(
	rol_id	 int,
	func_id	 int,
	primary key(rol_id,func_id)	
)
go

--Tabla de funcionalidades.
create table NEW_SOLUTION.Funcionalidades
(
	func_id		int,
	func_nombre	varchar(200)
)
go

--Tabla de Monedas.
create table NEW_SOLUTION.Monedas
(
	moneda_id int,
	moneda_descrip varchar(100)
)
go

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
go

--Tabla de emisores de tarjetas
create table NEW_SOLUTION.Tarjetas_emisores
(
	tarjemis_id		bigint identity(1,1),
	tarjemis_nombre varchar(255),
	primary key(tarjemis_id)
)
go

--Tabla de depositos.
create table NEW_SOLUTION.Depositos
(
	depo_id				bigint identity(1,1),
	depo_cta_id			bigint,
	depo_cli_id			bigint,
	depo_moneda			int,
	depo_tarj_id		bigint,
	depo_fecha			datetime,
	depo_importe		numeric(18,2),
	primary key(depo_id)
)
go

create index ix_1_depo_id  on NEW_SOLUTION.Depositos(depo_id)
go

create index ix_2_depo_cta on NEW_SOLUTION.Depositos(depo_cta_id)
go

--Tabla de  estados
create table NEW_SOLUTION.Estados
(
	estado_codigo	int,
	estado_descrip	varchar(15)
)
go

--Tabla de Cuentas
create table NEW_SOLUTION.Cuentas
(
	cta_id				bigint identity(1,1),
	cta_num				numeric(18,0),
	cta_cli_id			bigint,
	cta_pais_apertura	int,
	cta_moneda			int,
	cta_tipo			int,
	cta_fecha_apertura  datetime,
	cta_fecha_cierre	datetime,	
	cta_estado			int,
	cta_saldo			numeric(18,2),
	cta_num_suscrip		int,
	primary key(cta_num,cta_pais_apertura)	
)
go

--Tabla de categorias de cuentas.
create table NEW_SOLUTION.Cuentas_categ
(
	ctacateg_id				int identity(1,1),
	ctacateg_descrip		varchar(100),
	ctacateg_costo			numeric(18,2),
	ctacateg_duracion_dias  int
)
go

--Tabla con los Retiros
create table NEW_SOLUTION.Retiros
(
	ret_id				bigint identity(1,1),
	ret_fecha			datetime,
	ret_cli_id			bigint,	
	ret_num_cheque		numeric(18,0),
	ret_cta_id			bigint
)
go

--Tabla con los Bancos.
create table NEW_SOLUTION.Bancos
(
	bco_cod			numeric(18,0),
	bco_nombre		varchar(255),
	bco_direccion	varchar(255),
	primary key(bco_cod)	
)
go

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
go

--Tabla de transferencias.
create table NEW_SOLUTION.Transferencias
(
	transf_id					bigint identity(1,1),
	transf_cta_origen_id		bigint,
	transf_cta_destino_id		bigint,	
	transf_importe				numeric(18,2),
	transf_moneda				int,
	transf_fecha				datetime,
	transf_cli_id				bigint,
	transf_costo				numeric(18,2),
	primary key(transf_id)	
)
go

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
	cli_estado			int,
	cli_inconsistencia  int
)
go

create index ix_clientes_id on NEW_SOLUTION.Clientes(cli_id);
go

--Tabla de tipo de documentos
create table NEW_SOLUTION.Documentos_tipo
(
	tdoc_cod		numeric(18,0),
	tdoc_descrip	varchar(255)
)
go

--Tabla de paises
create table NEW_SOLUTION.Paises
(
	pais_id		  int identity(1,1),
	pais_cod	  numeric(18,0),
	pais_descrip  varchar(255)
)
go

--Tabla de facturas costos
create table NEW_SOLUTION.Facturas_costos
(
	factcto_id				bigint identity(1,1),
	factcto_num_op			bigint,
	factcto_tipo_op 		int,
	factcto_cta_origen		bigint,
	factcto_fecha 			datetime,
	factcto_costo 			numeric(18,2),
	factcto_costo_moneda    int,
	faccto_fact_id 			bigint,
	factcto_estado 			int	
)
go

--Tabla de conceptos de facturas.
create table NEW_SOLUTION.Facturas_conceptos
(
	fact_comp_id      int identity(1,1),
	fact_comp_descrip varchar(255)
)
go

--Tabla de facturas
create table NEW_SOLUTION.Facturas
(
	fact_id				bigint identity(1,1),
	fact_total			numeric(18,2),
	fact_total_moneda   int,
	fact_cli_id			bigint,
	fact_fecha			datetime,
	primary key(fact_id)
)
go

create index ix_1_fact_cli_id on NEW_SOLUTION.Facturas(fact_cli_id)
go

create index ix_1_fact_id     on NEW_SOLUTION.Facturas(fact_id)
go

--Tablas de estados.
create table NEW_SOLUTION.Roles_estado
(
	rol_estado_id			int identity(1,1),
	rol_estado_descrip		varchar(200)
)
go

create table NEW_SOLUTION.Clientes_estado
(
	cli_estado_id		int identity(1,1),
	cli_estado_descrip	varchar(200)
)
go

create table NEW_SOLUTION.Usuarios_estado
(
	usu_estado_id		int identity(1,1),
	usu_estado_descrip	varchar(200)
)
go

create table NEW_SOLUTION.Cuentas_estado
(
	cta_estado_id		int identity(1,1),
	cta_estado_descrip	varchar(200)
)
go

create table NEW_SOLUTION.Tarjetas_estado
(
	tarj_estado_id		int identity(1,1),
	tarj_estado_descrip	varchar(200)
)
go

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
go

--Cargar documentos
insert into NEW_SOLUTION.Documentos_tipo
select distinct
	   cli_tipo_doc_cod,
	   cli_tipo_doc_desc
from   gd_esquema.Maestra
go

--Cargar monedas
insert into NEW_SOLUTION.Monedas(moneda_id,moneda_descrip) values(1,'Dolares')
go

--Cargar costos de operaciones
insert into NEW_SOLUTION.Facturas_conceptos(fact_comp_descrip) values('Costo por transferencia')
go

--Cargar tabla de bancos.
insert into NEW_SOLUTION.Bancos(bco_cod,bco_nombre,bco_direccion)
select  distinct
		Banco_Cogido,
		Banco_Nombre,
		Banco_Direccion
from	gd_esquema.Maestra
where  Banco_Cogido is not null
go

--Cargar funcionalidades.
insert into NEW_SOLUTION.Funcionalidades(func_id,func_nombre) values(1,'Login')
insert into NEW_SOLUTION.Funcionalidades(func_id,func_nombre) values(2,'Clientes')
insert into NEW_SOLUTION.Funcionalidades(func_id,func_nombre) values(3,'Usuarios')
insert into NEW_SOLUTION.Funcionalidades(func_id,func_nombre) values(4,'Cuentas')
insert into NEW_SOLUTION.Funcionalidades(func_id,func_nombre) values(5,'Transferencias')
insert into NEW_SOLUTION.Funcionalidades(func_id,func_nombre) values(6,'Depositos')
insert into NEW_SOLUTION.Funcionalidades(func_id,func_nombre) values(7,'Retiros')
insert into NEW_SOLUTION.Funcionalidades(func_id,func_nombre) values(8,'Tarjetas')
insert into NEW_SOLUTION.Funcionalidades(func_id,func_nombre) values(9,'Roles')
insert into NEW_SOLUTION.Funcionalidades(func_id,func_nombre) values(10,'Facturacion')
insert into NEW_SOLUTION.Funcionalidades(func_id,func_nombre) values(11,'Saldo')
insert into NEW_SOLUTION.Funcionalidades(func_id,func_nombre) values(12,'Estadisticas')
insert into NEW_SOLUTION.Funcionalidades(func_id,func_nombre) values(13,'Saldo admin')
insert into NEW_SOLUTION.Funcionalidades(func_id,func_nombre) values(14,'Facturacion admin')
go

--Cargar roles
insert into NEW_SOLUTION.Roles(rol_id,rol_nombre,rol_estado) values(1,'Administrador',1)
insert into NEW_SOLUTION.Roles(rol_id,rol_nombre,rol_estado) values(2,'Cliente',1)
go

--Cargar la relaciones de roles con funcionalidades.

--Para administradores
insert into NEW_SOLUTION.Rol_funcionalidades(rol_id,func_id)
select 1,func_id from NEW_SOLUTION.Funcionalidades
where func_id in(3,9,1,3,2,4,10,12,13,14)
go

--Para clientes
insert into NEW_SOLUTION.Rol_funcionalidades(rol_id,func_id)
select 2,func_id from NEW_SOLUTION.Funcionalidades
where func_id in(1,4,5,6,7,8,10,11)
go

--Cargar en tabla estados
insert into NEW_SOLUTION.Roles_estado(rol_estado_descrip)     	values('Rol Activo')
insert into NEW_SOLUTION.Roles_estado(rol_estado_descrip)     	values('Rol No Activo')
insert into NEW_SOLUTION.Clientes_estado(cli_estado_descrip)  	values('Cliente Activo')
insert into NEW_SOLUTION.Clientes_estado(cli_estado_descrip)  	values('Cliente Inhabilitado')
insert into NEW_SOLUTION.Usuarios_estado(usu_estado_descrip)  	values('Usuario activo')
insert into NEW_SOLUTION.Usuarios_estado(usu_estado_descrip)  	values('Usuario Inactivo')
insert into NEW_SOLUTION.Cuentas_estado(cta_estado_descrip)  	values('Cuenta Activa')
insert into NEW_SOLUTION.Cuentas_estado(cta_estado_descrip)  	values('Cuenta Pendiente de Activacion')
insert into NEW_SOLUTION.Cuentas_estado(cta_estado_descrip)  	values('Cuenta Cerrada')
insert into NEW_SOLUTION.Cuentas_estado(cta_estado_descrip)  	values('Cuenta Inhabilitada')
insert into NEW_SOLUTION.Tarjetas_estado(tarj_estado_descrip)   values('Tarjeta Vinculada')
insert into NEW_SOLUTION.Tarjetas_estado(tarj_estado_descrip) 	values('Tarjeta Desvinculada')
go


--Cargar clientes, resta tener en cuenta tipos diferentes de emails e inconcistencias.
insert into NEW_SOLUTION.Clientes
(
	cli_nombre,
	cli_apellido,
	cli_tdoc,
	cli_ndoc,
	cli_pdoc,
	cli_mail,
	cli_calle,
	cli_numero,
	cli_piso,
	cli_depto,
	cli_localidad,
	cli_nacionalidad,
	cli_fecnac,
	cli_estado,
	cli_inconsistencia
)
select distinct
      a.[Cli_Nombre],
      a.[Cli_Apellido],
      a.[Cli_Tipo_Doc_Cod],      
      a.[Cli_Nro_Doc],
	  b.pais_id,
	  a.[Cli_Mail],
      a.[Cli_Dom_Calle],
      a.[Cli_Dom_Nro],
      a.[Cli_Dom_Piso],
      a.[Cli_Dom_Depto],
      null,
      null,
      a.[Cli_Fecha_Nac],
      3,
      null
FROM gd_esquema.[Maestra] as a
left join NEW_SOLUTION.Paises as b on b.pais_cod = a.Cli_Pais_codigo
go

--Crear tabla de Usuarios
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
		5,	
		cli_id
from NEW_SOLUTION.Clientes
go

--Agregar roles a los usuarios, por defecto todos van a ser clientes.
insert into NEW_SOLUTION.Usuarios_roles(usu_id,rol_id)
select usu_id,2 from NEW_SOLUTION.Usuarios
go

--Cargar emisores de tarjetas de creditos.
insert  into NEW_SOLUTION.Tarjetas_emisores(tarjemis_nombre)
select  distinct
		Tarjeta_Emisor_Descripcion
from	gd_esquema.Maestra
go

--Cargar tarjetas de creditos.
insert into NEW_SOLUTION.Tarjetas(tarj_numero,tarj_fecemision,tarj_fecvencimiento,tarj_codseguridad,tarj_emisor,tarj_estado,tarj_cli_id)
select distinct
	   a.Tarjeta_Numero,
	   a.Tarjeta_Fecha_Emision,
	   a.Tarjeta_Fecha_Vencimiento,
	   a.Tarjeta_Codigo_Seg,
	   b.tarjemis_id,
	   11,
	  (convert(varchar,a.Cli_Pais_codigo)+convert(varchar,a.Cli_Tipo_Doc_Cod)+convert(varchar,a.Cli_Nro_Doc))	  
from 	  gd_esquema.maestra as a
left join NEW_SOLUTION.Tarjetas_emisores as b on b.tarjemis_nombre=a.Tarjeta_Emisor_Descripcion
where  	  Tarjeta_Numero is not null
go

--Cargar depositos	  
/*
--resta corregir
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
go
*/

--Cargar tabla de categorias de cuentas.
insert into NEW_SOLUTION.Cuentas_categ(ctacateg_descrip,ctacateg_costo,ctacateg_duracion_dias) values('Oro',0,0)
insert into NEW_SOLUTION.Cuentas_categ(ctacateg_descrip,ctacateg_costo,ctacateg_duracion_dias) values('Plata',0,0)
insert into NEW_SOLUTION.Cuentas_categ(ctacateg_descrip,ctacateg_costo,ctacateg_duracion_dias) values('Bronce',0,0)
insert into NEW_SOLUTION.Cuentas_categ(ctacateg_descrip,ctacateg_costo,ctacateg_duracion_dias) values('Gratuitas',0,0)
go

--Cargar tabla de cuentas.
insert into NEW_SOLUTION.Cuentas
(
	cta_num,
	cta_cli_id,
	cta_pais_apertura,
	cta_moneda,
	cta_tipo,
	cta_fecha_apertura,
	cta_fecha_cierre,
	cta_estado
)
select		distinct
			a.Cuenta_Numero,
			(convert(varchar,a.Cli_Pais_codigo)+convert(varchar,a.Cli_Tipo_Doc_Cod)+convert(varchar,a.Cli_Nro_Doc)),
			b.pais_id,
			1,
			4,
			a.Cuenta_Fecha_Creacion,
			a.cuenta_fecha_cierre,
			10
from		gd_esquema.Maestra  as a
left join	NEW_SOLUTION.Paises as b on b.pais_cod=a.Cuenta_Pais_Codigo
group by	a.Cuenta_Numero,
			(convert(varchar,a.Cli_Pais_codigo)+convert(varchar,a.Cli_Tipo_Doc_Cod)+convert(varchar,a.Cli_Nro_Doc)),
			b.pais_id,
			a.Cuenta_Fecha_Creacion,
			a.cuenta_fecha_cierre
go

--Cargar tabla de transferencias.
insert into NEW_SOLUTION.Transferencias
(
	transf_cta_origen_id,
	transf_cta_destino_id,
	transf_importe,
	transf_fecha,
	transf_cli_id,
	transf_costo
)
select  distinct
		c1.cta_id,
		c2.cta_id,
		a.Trans_Importe,
		a.Transf_Fecha,		
		(
			convert(varchar,a.Cli_Pais_codigo)+
			convert(varchar,a.Cli_Tipo_Doc_Cod)+
			convert(varchar,a.Cli_Nro_Doc)
		),
		0		
from	gd_esquema.Maestra     as a 
left join NEW_SOLUTION.Cuentas as c1 on  c1.cta_num=a.Cuenta_Numero
									 and c1.cta_pais_apertura=a.Cuenta_Pais_Codigo
left join NEW_SOLUTION.Cuentas as c2 on  c2.cta_num=a.Cuenta_Dest_Numero
									 and c2.cta_pais_apertura=a.Cuenta_Dest_Pais_Codigo
where c1.cta_id is not null
and	  c2.cta_id is not null 
go

/*
--Corregir
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
go
*/

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

--Devuelve el listado de los usuarios activos.
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
		u.usu_estado =1			
go

--Devuelve el listado de los usuarios inactivos.
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
		u.usu_estado <> 1			
go


/**************************************************************************
				SP / FUNCIONES / TRIGGERS
**************************************************************************/

-----------------
--	FUNCIONES  --
-----------------

--Dice si la cuenta pertenece a ese cliente.
create function NEW_SOLUTION.cuenta_pertenece_cliente(@ctaNum numeric(18,0),@idpais int,@cliId bigint)
returns int
as
begin
	if exists(select a.* from  NEW_SOLUTION.Cuentas as a where a.cta_cli_id = @cliId and a.cta_num = @ctaNum and a.cta_pais_apertura=@idpais)
		return 1
	else 
		return 0
		
	return -1
end
go

--Dice si la tarjeta es del cliente.
create function NEW_SOLUTION.tarjeta_cliente_valida(@tarjId bigint,@cliId bigint)
returns int
as
begin
	if exists(
				select	    a.tarj_id
				from        NEW_SOLUTION.Tarjetas as a
				inner join  NEW_SOLUTION.Clientes as c on c.cli_id=a.tarj_cli_id
				where  a.tarj_estado=1
			)
		return 1
	else 
		return 0
		
	return -1
end
go

--Devuelve el idcliente de un userid.
create function NEW_SOLUTION.f_get_cli_user_id(@usuID bigint)
RETURNS bigint
AS BEGIN
	declare @cli_id bigint
	select @cli_id=usu_cli_id from NEW_SOLUTION.Usuarios where usu_id=@usuID
	return @cli_id
END
go	


--Trae el id de usuario en base a su nombre.
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

--Dice si ambas cuentas tiene el mismo cliente.
create function [NEW_SOLUTION].[cuenta_mismo_cliente](@cta1ID bigint,@cta2ID bigint)
returns int
as
begin
	declare @cli_1 bigint
	declare @cli_2 bigint
		    
	set @cli_1=0
	set @cli_2=0
	
	select @cli_1 = cta_cli_id from NEW_SOLUTION.Cuentas where cta_id = @cta1ID
	select @cli_2 = cta_cli_id from NEW_SOLUTION.Cuentas where cta_id = @cta2ID
	
	if (@cli_1=@cli_2)
		return 1
	else
		return 0
		
	return -1
end
go

--------------
-- TRIGGERS --
--------------

--Un trigger que se ejecuta cada vez que se realiza una transferencia, se usa para registrar los costos.
create TRIGGER NEW_SOLUTION.registrar_costo_transferencia
ON NEW_SOLUTION.Transferencias FOR INSERT
as
	insert into NEW_SOLUTION.Facturas_costos
	(
		factcto_num_op,
		factcto_tipo_op,
		factcto_cta_origen,
		factcto_cta_origen_pais,
		factcto_importe,
		factcto_fecha,
		factcto_costo,
		faccto_fact_id,
		factcto_estado
	)
	select	a.transf_id,
			1,
			a.transf_cta_origen,
			a.transf_cta_pais_origen,
			a.transf_importe,
			a.transf_fecha,
			a.transf_costo,
			null,
			null	
	from    inserted as a
	where   a.transf_costo>0
go


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

----------------------------------------------------------------------------
--						STORE PROCEDURES								  --
----------------------------------------------------------------------------

--Realizo la facturación, obtengo el nuevo idfactura generado.
create procedure new_solution.sp_facturar_costos(@userID bigint,@fechaSYS datetime)
as
begin
	--Busco si hay elementos que facturar
	if exists(
				select fc.factcto_id
				from  NEW_SOLUTION.facturas_costos as fc
				inner join NEW_SOLUTION.Cuentas as cta on cta.cta_id=fc.factcto_cta_origen
				inner join NEW_SOLUTION.Clientes as cli on cli.cli_id=cta.cta_cli_id
				inner join NEW_SOLUTION.Usuarios as usu on usu.usu_cli_id=cli.cli_id
				where fc.faccto_fact_id is null
				and usu.usu_id=@userID
			)
	begin

		--Calculo el total a pagar.
		declare @total numeric(18,2)
		
		select @total = SUM(fc.factcto_costo)
		from  NEW_SOLUTION.facturas_costos as fc
		inner join NEW_SOLUTION.Cuentas    as cta on cta.cta_id=fc.factcto_cta_origen
		inner join NEW_SOLUTION.Clientes   as cli on cli.cli_id=cta.cta_cli_id
		inner join NEW_SOLUTION.Usuarios   as usu on usu.usu_cli_id=cli.cli_id
		where fc.faccto_fact_id is null
		and usu.usu_id=@userID
		
		--Obtengo el id cliente.	
		insert into NEW_SOLUTION.Facturas(fact_total,fact_total_moneda,fact_cli_id,fact_fecha)
		values(@total,1,NEW_SOLUTION.f_get_cli_user_id(294),@fechaSYS)
		
		--Actualizo en la tabla conceptos el idfactura.	
		update fc
		set fc.faccto_fact_id=@@IDENTITY
		from NEW_SOLUTION.facturas_costos as fc
		inner join NEW_SOLUTION.Cuentas    as cta on cta.cta_id=fc.factcto_cta_origen
		inner join NEW_SOLUTION.Clientes   as cli on cli.cli_id=cta.cta_cli_id
		inner join NEW_SOLUTION.Usuarios   as usu on usu.usu_cli_id=cli.cli_id
		where fc.faccto_fact_id is null
		and usu.usu_id=@userID
		
		return @@IDENTITY
			
	end
	else
		return -1 --No hay elementos que facturar
end
go

--Trae el detalle de una factura
create procedure new_solution.sp_traer_detalle_factura(@factID bigint)
as
	select  f.factcto_id,
			f.factcto_num_op,
			f.factcto_tipo_op,
			fc.fact_comp_descrip,
			f.factcto_cta_origen,
			f.factcto_fecha,
			f.factcto_costo,
			f.factcto_costo_moneda,
			m.moneda_descrip,
			f.faccto_fact_id,
			f.factcto_estado
	from    NEW_SOLUTION.Facturas_costos as f
	left join NEW_SOLUTION.Facturas_conceptos as fc on fc.fact_comp_id=f.factcto_tipo_op
	left join NEW_SOLUTION.monedas as m on m.moneda_id=f.factcto_costo_moneda
	where f.faccto_fact_id=@factID
go

--Trae una factura en base a su id.
create procedure NEW_SOLUTION.sp_traer_factura_id(@factID bigint)
as
	select top 1 fc.fact_id,fc.fact_total,fc.fact_total_moneda,m.moneda_descrip,fc.fact_cli_id,fc.fact_fecha,cli.cli_apellido,cli.cli_nombre
	from NEW_SOLUTION.Facturas as fc
	left join NEW_SOLUTION.Monedas as m on m.moneda_id=fc.fact_total_moneda
	left join NEW_SOLUTION.Clientes as cli on cli.cli_id=fc.fact_cli_id
	where fact_id=@factID
go
	
--Traigo todas las facturas de un usuario.
create procedure NEW_SOLUTION.traer_facturas_usuario(@userID bigint)
as
	select fc.fact_id,fc.fact_fecha
	from   NEW_SOLUTION.Facturas as fc				
	inner join NEW_SOLUTION.Clientes as cli on cli.cli_id=fc.fact_cli_id
	inner join NEW_SOLUTION.Usuarios as usu on usu.usu_cli_id=cli.cli_id
	where usu.usu_id=@userID
	order by fc.fact_id desc
go
	
--Dice si existe una tarjeta cargada con un numero y un emisor, para un mismo UsuarioID
create procedure NEW_SOLUTION.existe_tarj_num_emisor_cliente(@num varchar(16),@emisor int,@userID bigint) as
begin
	if exists(
	select * from NEW_SOLUTION.Tarjetas as t 
	inner join NEW_SOLUTION.Clientes    as c on c.cli_id= t.tarj_cli_id
	inner join NEW_SOLUTION.Usuarios    as u on u.usu_cli_id=c.cli_id
	where t.tarj_numero=@num
	and   t.tarj_emisor=@emisor
	and   u.usu_id=@userID)
	return 1
	else
	return 0
	
	return null
end
go

--Desvincular tarjeta.
create procedure NEW_SOLUTION.sp_desvincular_tarjeta(@tarjID bigint)
as
	update  NEW_SOLUTION.Tarjetas
	set	    tarj_estado=2
	where   tarj_id=@tarjID
go

--Actualiza una tarjeta.
create procedure NEW_SOLUTION.sp_actualizar_tarjeta(@tarjID bigint,@tarjNum varchar(16),@tarjFecEmis datetime,@tarjVenc datetime,@tarjSeg  varchar(3),@tarjEmis int)
as
	update  NEW_SOLUTION.Tarjetas
	set	    tarj_numero=@tarjNum,
			tarj_fecemision=@tarjFecEmis,
			tarj_fecvencimiento=@tarjVenc,
			tarj_codseguridad=@tarjSeg,
			tarj_emisor=@tarjEmis			
	where   tarj_id=@tarjID
go

--Trae una tarjeta en base a su id.
create procedure NEW_SOLUTION.sp_traer_tarjeta_id(@tarjID bigint)
as
	select t.tarj_id,t.tarj_numero,t.tarj_fecemision,t.tarj_fecvencimiento,t.tarj_codseguridad,t.tarj_emisor,t.tarj_estado,t.tarj_cli_id,te.tarjemis_nombre
	from new_solution.tarjetas as t
	inner join NEW_SOLUTION.Tarjetas_emisores as te on te.tarjemis_id=t.tarj_emisor
	where t.tarj_id=@tarjID
go

--Vincula una tarjeta con un usuario y su cliente.
create procedure NEW_SOLUTION.sp_vincular_tarjeta(@tarjNum varchar(16),@tarjFecEmis datetime,@tarjVenc datetime,@tarjSeg  varchar(3),@tarjEmis int,@usuId bigint)
as
	declare @cliID bigint
	select top 1 @cliID = usu_cli_id from NEW_SOLUTION.Usuarios where usu_id=@usuId
	
	insert into NEW_SOLUTION.Tarjetas(tarj_numero,tarj_fecemision,tarj_fecvencimiento,tarj_codseguridad,tarj_emisor,tarj_estado,tarj_cli_id)
	values(@tarjNum,@tarjFecEmis,@tarjVenc,@tarjSeg,@tarjEmis,1,@cliID)
go

--Traer tarjetas vinculadas, sin tener en cuenta fecha de vencimiento.
create procedure NEW_SOLUTION.sp_traer_tarjetas_vinculadas_userid(@usuId bigint)
as
	select a.tarj_id,
		   a.tarj_numero,
		   a.tarj_fecemision,
		   a.tarj_fecvencimiento,
		   a.tarj_codseguridad,
		   a.tarj_emisor,
		   te.tarjemis_nombre,
		   a.tarj_estado,
		   a.tarj_cli_id,
		   u.usu_id
	from      NEW_SOLUTION.Tarjetas          as a
	left join NEW_SOLUTION.Tarjetas_emisores as te on te.tarjemis_id=a.tarj_emisor
	inner join NEW_SOLUTION.Clientes         as c on c.cli_id= a.tarj_cli_id
	inner join NEW_SOLUTION.Usuarios         as u on u.usu_cli_id=c.cli_id
	where     a.tarj_estado=1
	and       u.usu_id=@usuId
go

--Trae los emisores de tarjetas
create procedure NEW_SOLUTION.sp_emisores_tarjetas_listar
as
	select tarjemis_id,tarjemis_nombre from NEW_SOLUTION.Tarjetas_emisores
go

--Buscar el numero de cuenta en base a su numero.
create procedure NEW_SOLUTION.sp_buscar_cta_num(@cuentaNum bigint)
as
	select distinct
		   a.cta_id,
		   a.cta_num,
		   a.cta_cli_id,
		   b.cli_apellido,
		   b.cli_nombre,
		   a.cta_pais_apertura,
		   p.pais_descrip
	from NEW_SOLUTION.Cuentas as a
	left join NEW_SOLUTION.Clientes as b on b.cli_id = a.cta_cli_id	
	left join NEW_SOLUTION.Paises   as p on p.pais_cod   = a.cta_pais_apertura
	where a.cta_num   = @cuentaNum
	and   a.cta_estado=1
go

--Busca las cuentas en base a un id cliente.
create procedure NEW_SOLUTION.sp_buscar_cta_idcli(@cli_id bigint)
as
	select distinct
		   a.cta_id,
		   a.cta_num,
		   a.cta_cli_id,
		   b.pais_descrip
	from NEW_SOLUTION.Cuentas as a
	inner join NEW_SOLUTION.Paises   as b on b.pais_cod=a.cta_pais_apertura
	inner join NEW_SOLUTION.Clientes as c on c.cli_id     = a.cta_cli_id	
	inner join NEW_SOLUTION.Usuarios as d on d.usu_cli_id = c.cli_id		
	where d.usu_id =@cli_id 
	and   a.cta_estado = 1
go

--Obtiene el saldo actual de la cuenta.
create procedure NEW_SOLUTION.consultar_saldo_cta_id(@ctaID bigint)
as
begin
	declare @saldo numeric(18,2)
	select top 1 @saldo = cta_saldo from NEW_SOLUTION.Cuentas where cta_id=@ctaID
	
	select @saldo as saldo
end
go


--Consulta ultimos movimientos.
create procedure NEW_SOLUTION.sp_cta_movimientos(@ctaID bigint)
as
begin
	create table #tmp
	(
		tipo    varchar(100),
		importe numeric(18,2),
		fecha	datetime
	)
	
	insert into #tmp
	select  top 5
			'Transferencia',
			t.transf_importe,
			t.transf_fecha
	from    NEW_SOLUTION.Transferencias as t
	where t.transf_cta_destino_id=@ctaID
	order by t.transf_id desc
	
	insert into #tmp
	select  top 5
		   'Deposito',
			d.depo_importe,
			d.depo_fecha
	from	NEW_SOLUTION.Depositos  as d
	where   d.depo_cta_id=@ctaID
	order by d.depo_id desc
	
	insert into #tmp
	select  top 5
			'Retiro',
			chq.chq_importe,
			chq.chq_fecha
	from       NEW_SOLUTION.Retiros as r
	inner join NEW_SOLUTION.Cheques as chq on chq.chq_num= r.ret_num_cheque
	where	   r.ret_cta_id=@ctaID
	order by   r.ret_id desc;
	
	select tipo,importe,fecha
	from   #tmp
	
	drop table #tmp
end
go

--Busca las cuentas en base a un id cliente, PERO que el saldo sea mayor a CERO.
create procedure NEW_SOLUTION.sp_buscar_cta_idcli_disponibles(@cli_id bigint)
as
	select distinct
		   a.cta_id,
		   a.cta_num,
		   a.cta_cli_id,
		   b.pais_descrip
	from NEW_SOLUTION.Cuentas as a
	inner join NEW_SOLUTION.Paises   as b on b.pais_cod=a.cta_pais_apertura
	inner join NEW_SOLUTION.Clientes as c on c.cli_id     = a.cta_cli_id	
	inner join NEW_SOLUTION.Usuarios as d on d.usu_cli_id = c.cli_id		
	where d.usu_id =@cli_id 
	and   a.cta_estado = 1
	and   a.cta_saldo>0
go

--Devuelve las tarjetas que estan asociadas a un cliente.
create procedure NEW_SOLUTION.sp_traer_tarjetas_user_id(@userID bigint,@fechaSYS datetime)
as
	select a.tarj_id,
		   a.tarj_numero,
		   a.tarj_fecemision,
		   a.tarj_fecvencimiento,
		   a.tarj_codseguridad,
		   a.tarj_emisor,
		   t.tarjemis_nombre,
		   a.tarj_estado,
		   a.tarj_cli_id
	from        NEW_SOLUTION.Tarjetas as a
	inner join  NEW_SOLUTION.Tarjetas_emisores as t on t.tarjemis_id=a.tarj_emisor
	inner join  NEW_SOLUTION.Clientes as c on c.cli_id=a.tarj_cli_id
	inner join  NEW_SOLUTION.Usuarios as u on u.usu_cli_id=c.cli_id
	where  u.usu_id=@userID
	and    a.tarj_estado=1
	and    a.tarj_fecvencimiento > @fechaSYS
go


--Realizar deposito en una cuenta.
create procedure NEW_SOLUTION.cuenta_depositar(@ctaID bigint,@importe numeric(18,2),@moneda int,@tarjId bigint,@fechaSys datetime)
as
	--Si el importe es aceptado
	if (@importe>1)
	begin
		declare @cliID bigint
		select top 1 @cliID = cta_cli_id from NEW_SOLUTION.Cuentas where cta_id=@ctaID
	
		--Revisar si la tarjeta es valida
		if (NEW_SOLUTION.tarjeta_cliente_valida(@tarjId,@cliID)=1)
		begin
			--Registro el deposito.
			insert into NEW_SOLUTION.Depositos(depo_cta_id,depo_cli_id,depo_moneda,depo_tarj_id,depo_fecha,depo_importe)
			values(@ctaID,@cliID,@moneda,@tarjId,@fechaSYS,@importe)
			
			--Actualizo el valor de la cuenta
			update NEW_SOLUTION.Cuentas set cta_saldo=cta_saldo+@importe
			where cta_id = @ctaID
			
			--Muestro el ok
			return 1
		end
		else
			--Tarjeta invalida
			return -2
	end
	else
		--Valor no permitido
		return -1
go


--Listar los bancos
create procedure NEW_SOLUTION.sp_traer_bancos
as
	select bco_cod,bco_nombre,bco_direccion from NEW_SOLUTION.Bancos
go


--Retirar dinero
create procedure NEW_SOLUTION.sp_cuenta_retirar(@ctaID bigint,@importe numeric(18,2),@codBco numeric(18,0),@fechaSys datetime)
as
	--Revisar que la cuenta se encuentra activa.
	if (NEW_SOLUTION.cuenta_activa(@ctaID)=1)
	begin
		--Obtengo el importe
		declare      @saldoCta numeric(18,2)		
		select top 1 @saldoCta = cta_saldo from NEW_SOLUTION.Cuentas where cta_id=@ctaID
		
		--Si tengo saldo.
		if (@saldoCta>0)
		begin
			--Si el dinero alcanza.
			if (@saldoCta-@importe>0)
			begin
				--Realizo la extraccion.
				update NEW_SOLUTION.Cuentas set cta_saldo = cta_saldo-@importe
				where cta_id = @ctaID
				
				--Obtengo el prox. num de cheque.
				declare @chqNum numeric(18,0)
				select  @chqNum = MAX(chq_num)+1 from NEW_SOLUTION.Cheques

				--Obtengo el cli Id.
				declare @cliId bigint
				select  top 1 @cliId = cta_cli_id from NEW_SOLUTION.Cuentas where cta_id=@ctaID

				--Registro el cheque
				insert into NEW_SOLUTION.Cheques(chq_num,chq_importe,chq_cli_id,chq_cod_bco,chq_fecha)
				values(@chqNum,@importe,@cliId,@codBco,@fechaSys)
				
				--Registro la extraccion.
				insert into NEW_SOLUTION.Retiros(ret_fecha,ret_cli_id,ret_num_cheque,ret_cta_id)
				values(@fechaSys,@cliId,@chqNum,@ctaID)

				return 1
			end	
			else
				--No alcanza el dinero para hacer la extraccion.
				return -3	
		end
		else
			--No hay saldo
			return -2
	end
	else
		--La cuenta no esta activa
		return -1
go

--Hacer transferencia entre cuentas.
create procedure [NEW_SOLUTION].[sp_cuenta_hacer_transferencia](@ctaOrigenId bigint,@ctaDestinoId bigint,@importe numeric(18,2),@idmoneda int,@fechaSys datetime)
as
	--Revisar que la cuenta destino este activa.
	declare @activDestino int
	set		@activDestino = null
	
	--Cargo el estado de la cuenta destino.
	select top 1 @activDestino = a.cta_estado from NEW_SOLUTION.Cuentas as a where a.cta_id=@ctaOrigenId
	
	--Si es nulo o el estado no es 1 que es activo, devuelvo -1, cta invalida.
	if (@activDestino is not null)or(@activDestino <>1)
	begin	
		--Si el importe a transferir es mayor que cero.
		if (@importe>0)	
		begin
			--Revisar si el dinero de la cuenta origen alcanza para hacer la transferencia.
			declare @montoOrigen numeric(18,2)
			select  top 1 @montoOrigen = cta_saldo from NEW_SOLUTION.Cuentas where cta_id = @ctaOrigenId
			
			if (@montoOrigen-@importe>=0)
			begin
					--Obtengo el id cliente.
					declare @cliId bigint
					select top 1 @cliId= cta_cli_id from NEW_SOLUTION.Cuentas where cta_id = @ctaOrigenId
			
					--Si el cliente es el mismo.
					if (NEW_SOLUTION.cuenta_mismo_cliente(@ctaOrigenId,@ctaDestinoId)=1)
					begin
						--Grabar transferencia.
						insert into NEW_SOLUTION.Transferencias(transf_cta_origen_id,transf_cta_destino_id,transf_importe,transf_moneda,transf_fecha,transf_cli_id,transf_costo)
						values(@ctaOrigenId,@ctaDestinoId,@importe,@idmoneda,@fechaSys,@cliId,0)
											
						return 1						
					end
					else
					begin
					
						--Grabar transferencia.
						insert into NEW_SOLUTION.Transferencias(transf_cta_origen_id,transf_cta_destino_id,transf_importe,transf_moneda,transf_fecha,transf_cli_id,transf_costo)
						values
						(
							@ctaOrigenId,
							@ctaDestinoId,
							@importe,
							@idmoneda,						
							@fechaSys,
							@cliId,
							(select   top 1
									  isnull(b.ctacateg_costo,0)
							from	  NEW_SOLUTION.Cuentas       as a
							left join NEW_SOLUTION.Cuentas_categ as b on b.ctacateg_id = a.cta_tipo
							where	  a.cta_id=@ctaOrigenId)
						)		
						
						return 1
					end				
			end			
			else
				--No hay dinero suficiente para hacer la transferencia.
				return -3
		end
		else	
			--Deber ser un importe mayor que cero.	
			return -2
	end
	else
	begin
		--Cuenta invalida
		return -1
	end
go

--Estadisticas PUNTO 5
create procedure NEW_SOLUTION.sp_stats_5(@inicio datetime,@fin datetime)
as
begin
	--Realizo la consulta
	select a.ctacateg_id,
		   a.ctacateg_descrip,
		   sum(f.fact_total)
	from       NEW_SOLUTION.Cuentas_categ as a
	inner join NEW_SOLUTION.Cuentas as cta on cta.cta_tipo=a.ctacateg_id
	inner join NEW_SOLUTION.Facturas as f on f.fact_cta_id=cta.cta_id
	where f.fact_fecha  >= @inicio
	and   f.fact_fecha   <= @fin
	group by a.ctacateg_id,a.ctacateg_descrip	
end
go

--Estadisticas PUNTO 4
create procedure NEW_SOLUTION.sp_stats_4(@inicio datetime,@fin datetime)
as
begin
	--Realizo la consulta	
	select p.pais_descrip,
		  (COUNT(depo.depo_id)+COUNT(ret.ret_id)) as movimientos
	from NEW_SOLUTION.Paises as p
	inner join NEW_SOLUTION.Cuentas as cta on cta.cta_pais_apertura =p.pais_id
	left join NEW_SOLUTION.Depositos as depo on depo.depo_cta_id = cta.cta_id
	left join NEW_SOLUTION.Retiros as ret on ret.ret_cta_id=cta.cta_id
	where  (depo.depo_fecha>=@inicio and depo.depo_fecha<=@fin)
	or     (ret.ret_fecha>=@inicio   and ret.ret_fecha<=@fin)
	group by p.pais_descrip
	having (COUNT(depo.depo_id)+COUNT(ret.ret_id))>0
	order by (COUNT(depo.depo_id)+COUNT(ret.ret_id)) desc	
end
go

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
		else
		begin
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

--------------------------
--		  PRUEBAS		--
--------------------------
--Cargar usuarios para pruebas, el password para todos es w23e
insert into NEW_SOLUTION.Usuarios(usu_nombre, usu_password)
values 	('a', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),
		('b', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),
		('c', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),
		('d', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),
		('e', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),
		('f', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),
		('g', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),
		('h', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),
		('i', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),
		('j', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')		

insert into NEW_SOLUTION.Usuarios_roles (usu_id, rol_id)
values 	(NEW_SOLUTION.f_get_id('a'), 1),--admin
		(NEW_SOLUTION.f_get_id('b'), 1),--admin
		(NEW_SOLUTION.f_get_id('c'), 1),--admin
		(NEW_SOLUTION.f_get_id('d'), 1),--admin
		(NEW_SOLUTION.f_get_id('e'), 1),--admin
		(NEW_SOLUTION.f_get_id('f'), 1),--adimin
		(NEW_SOLUTION.f_get_id('f'), 2),--cliente		
		(NEW_SOLUTION.f_get_id('g'), 1),--admin
		(NEW_SOLUTION.f_get_id('g'), 2),--cliente		
		(NEW_SOLUTION.f_get_id('h'), 1),--admin
		(NEW_SOLUTION.f_get_id('h'), 2),--cliente
		(NEW_SOLUTION.f_get_id('i'), 2),--cliente
		(NEW_SOLUTION.f_get_id('j'), 2) --cliente