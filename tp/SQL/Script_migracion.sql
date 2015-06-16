--Creo el esquema.
CREATE SCHEMA [NEW_SOLUTION];

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
	logfalla_intento		int,
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
	usu_estado			int,
	usu_cli_id			bigint,
	primary key(usu_nombre)
)

create index ix_usuarios_id on NEW_SOLUTION.Usuarios(usu_id);

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
	rol_estado	int
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
	depo_id				bigint identity(1,1),
	depo_cuenta			numeric(18,0),
	depo_cuenta_pais	int,
	depo_moneda			int,
	depo_tarj_id		bigint,
	depo_fecha			datetime,
	depo_importe		numeric(18,2),
	primary key(depo_id)
)

create index ix_1_depo_id  on NEW_SOLUTION.Depositos(depo_id)
create index ix_2_depo_cta on NEW_SOLUTION.Depositos(depo_cuenta)

--Tabla de  estados
create table NEW_SOLUTION.Estados
(
	estado_codigo	int,
	estado_descrip	varchar(100)
)

--Tabla de Cuentas
create table NEW_SOLUTION.Cuentas
(
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

--Tabla de categorias de cuentas.
create table NEW_SOLUTION.Cuentas_categ
(
	ctacateg_id					int identity(1,1),
	ctacateg_descrip			varchar(100),
	ctacateg_costo				numeric(18,2),
	ctacateg_duracion_dias		int
)

--Tabla con los Retiros
create table NEW_SOLUTION.Retiros
(
	ret_id				bigint identity(1,1),
	ret_fecha			datetime,
	ret_cli_id			bigint,	
	ret_num_cheque		numeric(18,0),
	ret_cta_num			numeric(18,0),
	ret_cta_num_pais	int
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
	transf_id					bigint identity(1,1),
	transf_cta_origen			numeric(18,0),
	transf_cta_pais_origen		int,
	transf_cta_destino			numeric(18,0),
	transf_cta_pais_destino		int,	
	transf_importe				numeric(18,2),
	transf_fecha				datetime,
	transf_cli_id				bigint,
	transf_costo				numeric(18,2),
	primary key(transf_id)	
)

--Tabla de clientes
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
	cli_estado			int,
	cli_inconsistencia  int,
	--primary key(cli_id)
)

create index ix_clientes_id on NEW_SOLUTION.Clientes(cli_id);

--Tabla de tipo de documentos
create table NEW_SOLUTION.Documentos_tipo
(
	tdoc_cod		numeric(18,0),
	tdoc_descrip	varchar(255)
)

--Tabla de paises
create table NEW_SOLUTION.Paises
(
	pais_id		  int identity(1,1),
	pais_cod	  numeric(18,0),
	pais_descrip  varchar(255)
)

--Tabla de facturas costos
create table NEW_SOLUTION.Facturas_costos
(
	factcto_num_op			bigint,
	factcto_tipo_op			int,
	factcto_cta_origen		bigint,
	factcto_cta_origen_pais int,	
	factcto_importe			numeric(18,2),
	factcto_fecha			datetime,
	factcto_costo			numeric(18,2),
	faccto_fact_id			bigint,
	factcto_estado			int	
)

--Tabla de conceptos de facturas.
create table NEW_SOLUTION.Facturas_conceptos
(
	fact_comp_id		int identity(1,1),
	fact_comp_descrip	varchar(255)
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

create index ix_1_fact_cli_id on NEW_SOLUTION.Facturas(fact_cli_id)
create index ix_1_fact_id     on NEW_SOLUTION.Facturas(fact_id)

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

--Cargar costos de operaciones
insert into NEW_SOLUTION.Facturas_conceptos(fact_comp_descrip) values('Costo por transferencia')

--Cargar tabla de bancos.
insert into NEW_SOLUTION.Bancos(bco_cod,bco_nombre,bco_direccion)
select  distinct
		Banco_Cogido,
		Banco_Nombre,
		Banco_Direccion
from	gd_esquema.Maestra
where  Banco_Cogido is not null
	
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

--Cargar roles
insert into NEW_SOLUTION.Roles(rol_id,rol_nombre,rol_estado) values(1,'Administrador',1)
insert into NEW_SOLUTION.Roles(rol_id,rol_nombre,rol_estado) values(2,'Cliente',1)

--Cargar la relaciones de roles con funcionalidades.

--Para administradores
insert into NEW_SOLUTION.Rol_funcionalidades(rol_id,func_id)
select 1,func_id from NEW_SOLUTION.Funcionalidades
where func_id in(3,9,1,3,2,4,10,12)

--Para clientes
insert into NEW_SOLUTION.Rol_funcionalidades(rol_id,func_id)
select 2,func_id from NEW_SOLUTION.Funcionalidades
where func_id in(1,4,5,6,7,8,10,11)

--Cargar en tabla estados
insert into NEW_SOLUTION.Estados(estado_codigo,estado_descrip) values(1,'Rol Activo')
insert into NEW_SOLUTION.Estados(estado_codigo,estado_descrip) values(2,'Rol No Activo')
insert into NEW_SOLUTION.Estados(estado_codigo,estado_descrip) values(3,'Cliente Activo')
insert into NEW_SOLUTION.Estados(estado_codigo,estado_descrip) values(4,'Cliente Inhabilitado')
insert into NEW_SOLUTION.Estados(estado_codigo,estado_descrip) values(5,'Usuario activo')
insert into NEW_SOLUTION.Estados(estado_codigo,estado_descrip) values(6,'Usuario Inactivo')
insert into NEW_SOLUTION.Estados(estado_codigo,estado_descrip) values(7,'Cuenta Pendiente de Activacion')
insert into NEW_SOLUTION.Estados(estado_codigo,estado_descrip) values(8,'Cuenta Cerrada')
insert into NEW_SOLUTION.Estados(estado_codigo,estado_descrip) values(9,'Cuenta Inhabilitada')
insert into NEW_SOLUTION.Estados(estado_codigo,estado_descrip) values(10,'Cuenta Habilitada')
insert into NEW_SOLUTION.Estados(estado_codigo,estado_descrip) values(11,'Tarjeta Vinculada')
insert into NEW_SOLUTION.Estados(estado_codigo,estado_descrip) values(12,'Tarjeta Desvinculada')

--Cargar clientes, resta tener en cuenta tipos diferentes de emails e inconcistencias.
insert into NEW_SOLUTION.Clientes
select distinct
	  (
		convert(varchar,a.Cli_Pais_codigo)+
		convert(varchar,a.Cli_Tipo_Doc_Cod)+
		convert(varchar,a.Cli_Nro_Doc)
	  ),
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

--Crear tabla de Usuarios
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
		5,	
		cli_id
from NEW_SOLUTION.Clientes

--Agregar roles a los usuarios, por defecto todos van a ser clientes.
insert into NEW_SOLUTION.Usuarios_roles(usu_id,rol_id)
select usu_id,2 from NEW_SOLUTION.Usuarios

--Cargar emisores de tarjetas de creditos.
insert  into NEW_SOLUTION.Tarjetas_emisores(tarjemis_nombre)
select  distinct
		Tarjeta_Emisor_Descripcion
from	gd_esquema.Maestra

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

------------------------------------------
--		Vistas para la aplicacion		--
------------------------------------------

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
		u.usu_estado =5			
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
		u.usu_estado <> 5			
go
