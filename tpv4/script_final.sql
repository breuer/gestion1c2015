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
IF (OBJECT_ID('[NEW_SOLUTION].Login') is not null)								drop table [NEW_SOLUTION].Login
IF (OBJECT_ID('[NEW_SOLUTION].Login_incorrectos') is not null)					drop table [NEW_SOLUTION].Login_incorrectos
IF (OBJECT_ID('[NEW_SOLUTION].Usuarios') is not null)							drop table [NEW_SOLUTION].Usuarios
IF (OBJECT_ID('[NEW_SOLUTION].Usuarios_roles') is not null)						drop table [NEW_SOLUTION].Usuarios_roles
IF (OBJECT_ID('[NEW_SOLUTION].Roles') is not null)								drop table [NEW_SOLUTION].Roles
IF (OBJECT_ID('[NEW_SOLUTION].Estados') is not null)							drop table [NEW_SOLUTION].Estados
IF (OBJECT_ID('[NEW_SOLUTION].Documentos_tipo') is not null)					drop table [NEW_SOLUTION].Documentos_tipo
IF (OBJECT_ID('[NEW_SOLUTION].Rol_funcionalidades') is not null)				drop table [NEW_SOLUTION].Rol_funcionalidades
IF (OBJECT_ID('[NEW_SOLUTION].Funcionalidades') is not null)					drop table [NEW_SOLUTION].Funcionalidades
IF (OBJECT_ID('[NEW_SOLUTION].Monedas') is not null)							drop table [NEW_SOLUTION].Monedas
IF (OBJECT_ID('[NEW_SOLUTION].Tarjetas') is not null)							drop table [NEW_SOLUTION].Tarjetas
IF (OBJECT_ID('[NEW_SOLUTION].Tarjetas_emisores') is not null)					drop table [NEW_SOLUTION].Tarjetas_emisores
IF (OBJECT_ID('[NEW_SOLUTION].Depositos') is not null)							drop table [NEW_SOLUTION].Depositos
IF (OBJECT_ID('[NEW_SOLUTION].Cuentas') is not null)							drop table [NEW_SOLUTION].Cuentas
IF (OBJECT_ID('[NEW_SOLUTION].Cuentas_categ') is not null)						drop table [NEW_SOLUTION].Cuentas_categ
IF (OBJECT_ID('[NEW_SOLUTION].Retiros') is not null)							drop table [NEW_SOLUTION].Retiros
IF (OBJECT_ID('[NEW_SOLUTION].Bancos') is not null)								drop table [NEW_SOLUTION].Bancos
IF (OBJECT_ID('[NEW_SOLUTION].Cheques') is not null)							drop table [NEW_SOLUTION].Cheques
IF (OBJECT_ID('[NEW_SOLUTION].Transferencias') is not null)						drop table [NEW_SOLUTION].Transferencias
IF (OBJECT_ID('[NEW_SOLUTION].Clientes') is not null)							drop table [NEW_SOLUTION].Clientes
IF (OBJECT_ID('[NEW_SOLUTION].Paises') is not null)								drop table [NEW_SOLUTION].Paises
IF (OBJECT_ID('[NEW_SOLUTION].Facturas_costos') is not null)					drop table [NEW_SOLUTION].Facturas_costos
IF (OBJECT_ID('[NEW_SOLUTION].Facturas') is not null)							drop table [NEW_SOLUTION].Facturas
IF (OBJECT_ID('[NEW_SOLUTION].Facturas_conceptos') is not null)					drop table [NEW_SOLUTION].Facturas_conceptos
IF (OBJECT_ID('[NEW_SOLUTION].Roles_estado') is not null)						drop table [NEW_SOLUTION].Roles_estado
IF (OBJECT_ID('[NEW_SOLUTION].Clientes_estado') is not null)					drop table [NEW_SOLUTION].Clientes_estado
IF (OBJECT_ID('[NEW_SOLUTION].Usuarios_estado') is not null)					drop table [NEW_SOLUTION].Usuarios_estado
IF (OBJECT_ID('[NEW_SOLUTION].Cuentas_estado') is not null)						drop table [NEW_SOLUTION].Cuentas_estado
IF (OBJECT_ID('[NEW_SOLUTION].Tarjetas_estado') is not null)					drop table [NEW_SOLUTION].Tarjetas_estado
IF (OBJECT_ID('[NEW_SOLUTION].ctas_movimientos') is not null)					drop table [NEW_SOLUTION].ctas_movimientos
IF (OBJECT_ID('[NEW_SOLUTION].cuentas_historico_bloqueo') is not null)			drop table [NEW_SOLUTION].cuentas_historico_bloqueo
go

--Borrar vistas
IF object_id('NEW_SOLUTION.v_usuarios_activos') is not null 					drop view NEW_SOLUTION.v_usuarios_activos
IF object_id('NEW_SOLUTION.v_usuarios_inactivos') is not null 					drop view NEW_SOLUTION.v_usuarios_inactivos
go

--Borro los sp. para volver a crearlos.
IF object_id('NEW_SOLUTION.consultar_saldo_cta_id') is not null  				drop procedure NEW_SOLUTION.consultar_saldo_cta_id
IF object_id('NEW_SOLUTION.cuenta_depositar') is not null  						drop procedure NEW_SOLUTION.cuenta_depositar
IF object_id('NEW_SOLUTION.existe_tarj_num_emisor_cliente') is not null  		drop procedure NEW_SOLUTION.existe_tarj_num_emisor_cliente
IF object_id('NEW_SOLUTION.sp_actualizar_tarjeta') is not null  				drop procedure NEW_SOLUTION.sp_actualizar_tarjeta
IF object_id('NEW_SOLUTION.sp_buscar_clientes') is not null  					drop procedure NEW_SOLUTION.sp_buscar_clientes
IF object_id('NEW_SOLUTION.sp_buscar_cta_idcli') is not null  					drop procedure NEW_SOLUTION.sp_buscar_cta_idcli
IF object_id('NEW_SOLUTION.sp_buscar_cta_idcli_disponibles') is not null 		drop procedure NEW_SOLUTION.sp_buscar_cta_idcli_disponibles
IF object_id('NEW_SOLUTION.sp_buscar_cta_num') is not null  					drop procedure NEW_SOLUTION.sp_buscar_cta_num
IF object_id('NEW_SOLUTION.sp_cliente_add') is not null  						drop procedure NEW_SOLUTION.sp_cliente_add
IF object_id('NEW_SOLUTION.sp_cliente_get') is not null  						drop procedure NEW_SOLUTION.sp_cliente_get
IF object_id('NEW_SOLUTION.sp_cliente_update') is not null  					drop procedure NEW_SOLUTION.sp_cliente_update
IF object_id('NEW_SOLUTION.sp_cta_movimientos') is not null  					drop procedure NEW_SOLUTION.sp_cta_movimientos
IF object_id('NEW_SOLUTION.sp_cuenta_hacer_transferencia') is not null  		drop procedure NEW_SOLUTION.sp_cuenta_hacer_transferencia
IF object_id('NEW_SOLUTION.sp_cuenta_retirar') is not null  					drop procedure NEW_SOLUTION.sp_cuenta_retirar
IF object_id('NEW_SOLUTION.sp_desvincular_tarjeta') is not null  				drop procedure NEW_SOLUTION.sp_desvincular_tarjeta
IF object_id('NEW_SOLUTION.sp_emisores_tarjetas_listar') is not null  			drop procedure NEW_SOLUTION.sp_emisores_tarjetas_listar
IF object_id('NEW_SOLUTION.sp_facturar_costos') is not null  					drop procedure NEW_SOLUTION.sp_facturar_costos
IF object_id('NEW_SOLUTION.sp_facturar_costos_cliente_admin') is not null 		drop procedure NEW_SOLUTION.sp_facturar_costos_cliente_admin
IF object_id('NEW_SOLUTION.sp_funcionalidad_get') is not null  					drop procedure NEW_SOLUTION.sp_funcionalidad_get
IF object_id('NEW_SOLUTION.sp_pais_get') is not null  							drop procedure NEW_SOLUTION.sp_pais_get
IF object_id('NEW_SOLUTION.sp_rol_add') is not null  							drop procedure NEW_SOLUTION.sp_rol_add
IF object_id('NEW_SOLUTION.sp_rol_add_funcionalidad') is not null  				drop procedure NEW_SOLUTION.sp_rol_add_funcionalidad
IF object_id('NEW_SOLUTION.sp_rol_get') is not null  							drop procedure NEW_SOLUTION.sp_rol_get
IF object_id('NEW_SOLUTION.sp_rol_update') is not null  						drop procedure NEW_SOLUTION.sp_rol_update
IF object_id('NEW_SOLUTION.sp_stats_1') is not null  							drop procedure NEW_SOLUTION.sp_stats_1
IF object_id('NEW_SOLUTION.sp_stats_2') is not null  							drop procedure NEW_SOLUTION.sp_stats_2
IF object_id('NEW_SOLUTION.sp_stats_3') is not null  							drop procedure NEW_SOLUTION.sp_stats_3							
IF object_id('NEW_SOLUTION.sp_stats_4') is not null  							drop procedure NEW_SOLUTION.sp_stats_4
IF object_id('NEW_SOLUTION.sp_stats_5') is not null  							drop procedure NEW_SOLUTION.sp_stats_5
IF object_id('NEW_SOLUTION.sp_tipo_identificacion_get') is not null  			drop procedure NEW_SOLUTION.sp_tipo_identificacion_get
IF object_id('NEW_SOLUTION.sp_traer_bancos') is not null  						drop procedure NEW_SOLUTION.sp_traer_bancos
IF object_id('NEW_SOLUTION.sp_traer_detalle_factura') is not null  				drop procedure NEW_SOLUTION.sp_traer_detalle_factura
IF object_id('NEW_SOLUTION.sp_traer_factura_id') is not null  					drop procedure NEW_SOLUTION.sp_traer_factura_id
IF object_id('NEW_SOLUTION.sp_traer_tarjeta_id') is not null  					drop procedure NEW_SOLUTION.sp_traer_tarjeta_id
IF object_id('NEW_SOLUTION.sp_traer_tarjetas_user_id') is not null 				drop procedure NEW_SOLUTION.sp_traer_tarjetas_user_id
IF object_id('NEW_SOLUTION.sp_traer_tarjetas_vinculadas_userid') is not null  	drop procedure NEW_SOLUTION.sp_traer_tarjetas_vinculadas_userid
IF object_id('NEW_SOLUTION.sp_traer_tipos_doc') is not null  					drop procedure NEW_SOLUTION.sp_traer_tipos_doc
IF object_id('NEW_SOLUTION.sp_usuario_add') is not null  						drop procedure NEW_SOLUTION.sp_usuario_add
IF object_id('NEW_SOLUTION.sp_usuario_add_rol') is not null  					drop procedure NEW_SOLUTION.sp_usuario_add_rol
IF object_id('NEW_SOLUTION.sp_usuario_get') is not null  						drop procedure NEW_SOLUTION.sp_usuario_get
IF object_id('NEW_SOLUTION.sp_usuario_login') is not null  						drop procedure NEW_SOLUTION.sp_usuario_login
IF object_id('NEW_SOLUTION.sp_usuario_update') is not null 						drop procedure NEW_SOLUTION.sp_usuario_update
IF object_id('NEW_SOLUTION.sp_vincular_tarjeta') is not null  					drop procedure NEW_SOLUTION.sp_vincular_tarjeta
IF object_id('NEW_SOLUTION.traer_facturas_cliente') is not null  				drop procedure NEW_SOLUTION.traer_facturas_cliente
IF object_id('NEW_SOLUTION.traer_facturas_usuario') is not null  				drop procedure NEW_SOLUTION.traer_facturas_usuario
IF object_id('NEW_SOLUTION.sp_moneda_get') is not null  						drop procedure NEW_SOLUTION.sp_moneda_get
IF object_id('NEW_SOLUTION.sp_tipo_cuenta_get') is not null  					drop procedure NEW_SOLUTION.sp_tipo_cuenta_get
IF object_id('NEW_SOLUTION.sp_cuenta_get') is not null  						drop procedure NEW_SOLUTION.sp_cuenta_get
IF object_id('NEW_SOLUTION.sp_cuenta_get_nuevo_numero_cuenta') is not null  	drop procedure NEW_SOLUTION.sp_cuenta_get_nuevo_numero_cuenta
IF object_id('NEW_SOLUTION.sp_cuenta_get_estados') is not null  				drop procedure NEW_SOLUTION.sp_cuenta_get_estados
IF object_id('NEW_SOLUTION.sp_cuenta_add') is not null  						drop procedure NEW_SOLUTION.sp_cuenta_add
IF object_id('NEW_SOLUTION.sp_cuenta_update') is not null  						drop procedure NEW_SOLUTION.sp_cuenta_update
IF object_id('NEW_SOLUTION.sp_cuenta_actualizar_estados') is not null  			drop procedure NEW_SOLUTION.sp_cuenta_actualizar_estados
IF object_id('NEW_SOLUTION.sp_bloquear_ctas_vencimiento') is not null  			drop procedure NEW_SOLUTION.sp_bloquear_ctas_vencimiento
IF object_id('NEW_SOLUTION.sp_facturar_costos_cliente') is not null  			drop procedure NEW_SOLUTION.sp_facturar_costos_cliente
IF object_id('NEW_SOLUTION.sp_reactivar_vencidas_inabilitadas') is not null  	drop procedure NEW_SOLUTION.sp_reactivar_vencidas_inabilitadas
IF object_id('NEW_SOLUTION.sp_buscar_cta_cli_activa') is not null  				drop procedure NEW_SOLUTION.sp_buscar_cta_cli_activa
IF object_id('NEW_SOLUTION.sp_valida_id_dni') is not null  						drop procedure NEW_SOLUTION.sp_valida_id_dni
IF object_id('NEW_SOLUTION.sp_cuenta_cerrar') is not null  						drop procedure NEW_SOLUTION.sp_cuenta_cerrar
go

--Borrar funciones
IF object_id('NEW_SOLUTION.cuenta_mismo_cliente') is not null					drop function NEW_SOLUTION.cuenta_mismo_cliente
IF object_id('NEW_SOLUTION.cuenta_pertenece_cliente') is not null				drop function NEW_SOLUTION.cuenta_pertenece_cliente
IF object_id('NEW_SOLUTION.f_get_cli_user_id') is not null						drop function NEW_SOLUTION.f_get_cli_user_id
IF object_id('NEW_SOLUTION.f_get_id') is not null								drop function NEW_SOLUTION.f_get_id
IF object_id('NEW_SOLUTION.tarjeta_cliente_valida') is not null					drop function NEW_SOLUTION.tarjeta_cliente_valida
IF object_id('NEW_SOLUTION.cuenta_vencida') is not null  						drop function NEW_SOLUTION.cuenta_vencida
IF object_id('NEW_SOLUTION.cuenta_activa') is not null  						drop function NEW_SOLUTION.cuenta_activa
IF object_id('NEW_SOLUTION.f_dias_tipo_cuenta') is not null  					drop function NEW_SOLUTION.f_dias_tipo_cuenta
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
	usu_estado			int default 1,
	usu_cli_id			bigint

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
	tarj_codseguridad	varchar(100),
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
	cta_id					bigint identity(1,1),
	cta_num					numeric(18,0),
	cta_cli_id				bigint,
	cta_pais_apertura		int,
	cta_moneda				int,
	cta_tipo				int,
	cta_fecha_apertura  	datetime,
	cta_fecha_cierre		datetime,	
	cta_estado				int,
	cta_saldo				numeric(18,2) default 0,
	cta_num_suscrip			int,
	cta_fecha_vencimiento 	datetime,
	cta_fecha_bloqueo      	datetime,
	primary key(cta_num,cta_pais_apertura)	
)
go

--Tabla con los movimientos de las cuentas.
create table new_solution.ctas_movimientos
(
	ctamov_id       bigint identity(1,1),
	ctamov_cta_id	bigint,
	ctamov_importe	numeric(18,2),
	ctamov_fecha	datetime,
	ctamov_cod      varchar(2)
)
go

--Tabla de categorias de cuentas.
create table NEW_SOLUTION.Cuentas_categ
(
	ctacateg_id				int,
	ctacateg_descrip		varchar(100),
	ctacateg_costo			numeric(18,2),
	ctacateg_duracion_dias  int,
	ctacateg_estado_inicial int,
	ctacateg_costo_transf	numeric(18,2)
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
	cli_id				bigint,
	cli_nombre			varchar(255),
	cli_apellido		varchar(255),
	cli_tdoc			numeric(18,0),
	cli_ndoc			numeric(18,0),
	cli_mail			varchar(255),-- unique,
	cli_calle			varchar(255),
	cli_numero			varchar(50),
	cli_piso			numeric(18,0),
	cli_depto			varchar(10),
	cli_localidad		varchar(100),
	cli_nacionalidad	int,
	cli_fecnac			datetime,
	cli_estado			int default 1,
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
	faccto_fact_id 			bigint

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
	fact_id				bigint,
	fact_total			numeric(18,2),
	fact_total_moneda   int,
	fact_cli_id			bigint,
	fact_fecha			datetime,
	fact_user_gen		bigint,
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
	rol_estado_id			int,
	rol_estado_descrip		varchar(200)
)
go

create table NEW_SOLUTION.Clientes_estado
(
	cli_estado_id		int,
	cli_estado_descrip	varchar(200)
)
go

create table NEW_SOLUTION.Usuarios_estado
(
	usu_estado_id		int,
	usu_estado_descrip	varchar(200)
)
go

create table NEW_SOLUTION.Cuentas_estado
(
	cta_estado_id		int,
	cta_estado_descrip	varchar(200)
)
go

create table NEW_SOLUTION.Tarjetas_estado
(
	tarj_estado_id		int,
	tarj_estado_descrip	varchar(200)
)
go

create table new_solution.cuentas_historico_bloqueo
(
	ctabloqueo_id		 bigint,
	ctabloqueo_fecha	 datetime,
	ctabloqueo_cta_id    bigint	
)
go

------------------------------------
--	Carga de datos en las tablas  --
------------------------------------

--Cargar paises
insert into NEW_SOLUTION.paises(pais_cod,pais_descrip)
select distinct
	   a.codigo,
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
insert into NEW_SOLUTION.Facturas_conceptos(fact_comp_descrip) 
select  distinct top 1
	m.Item_Factura_Descr 
from gd_esquema.Maestra m
where m.Item_Factura_Descr is not null

insert into NEW_SOLUTION.Facturas_conceptos(fact_comp_descrip) values('Comisión por subscripcion.')
insert into NEW_SOLUTION.Facturas_conceptos(fact_comp_descrip) values('Comisión  por cambio de categoria.')
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
insert into NEW_SOLUTION.Funcionalidades(func_id,func_nombre) values(15,'Cuentas admin')

go

--Cargar roles
insert into NEW_SOLUTION.Roles(rol_id,rol_nombre,rol_estado) values(1,'Administrador',1)
insert into NEW_SOLUTION.Roles(rol_id,rol_nombre,rol_estado) values(2,'Cliente',1)
go

--Cargar la relaciones de roles con funcionalidades.

--Para administradores
insert into NEW_SOLUTION.Rol_funcionalidades(rol_id,func_id)
select 1,func_id from NEW_SOLUTION.Funcionalidades
where func_id in(1,2,9,10,12,13,14,15)
go

--Para clientes
insert into NEW_SOLUTION.Rol_funcionalidades(rol_id,func_id)
select 2,func_id from NEW_SOLUTION.Funcionalidades
where func_id in(1,4,5,6,7,8,10,11)
go

--Cargar en tabla estados
insert into NEW_SOLUTION.Roles_estado(rol_estado_id, rol_estado_descrip)     	values(1,'Rol Activo')
insert into NEW_SOLUTION.Roles_estado(rol_estado_id, rol_estado_descrip)     	values(0,'Rol No Activo')
insert into NEW_SOLUTION.Clientes_estado(cli_estado_id, cli_estado_descrip)  	values(1,'Cliente Activo')
insert into NEW_SOLUTION.Clientes_estado(cli_estado_id, cli_estado_descrip)  	values(0,'Cliente Inhabilitado')
insert into NEW_SOLUTION.Usuarios_estado(usu_estado_id, usu_estado_descrip)  	values(1,'Usuario activo')
insert into NEW_SOLUTION.Usuarios_estado(usu_estado_id, usu_estado_descrip)  	values(0,'Usuario Inactivo')
insert into NEW_SOLUTION.Cuentas_estado(cta_estado_id, cta_estado_descrip)  	values(1,'Cuenta Activa')
insert into NEW_SOLUTION.Cuentas_estado(cta_estado_id, cta_estado_descrip)  	values(0,'Cuenta Inhabilitada')
insert into NEW_SOLUTION.Cuentas_estado(cta_estado_id, cta_estado_descrip)  	values(2,'Cuenta Pendiente de Activacion')
insert into NEW_SOLUTION.Cuentas_estado(cta_estado_id, cta_estado_descrip)  	values(3,'Cuenta Cerrada')
insert into NEW_SOLUTION.Cuentas_estado(cta_estado_id, cta_estado_descrip)  	values(4,'Cuenta vencida')
insert into NEW_SOLUTION.Tarjetas_estado(tarj_estado_id, tarj_estado_descrip)   values(1,'Tarjeta Vinculada')
insert into NEW_SOLUTION.Tarjetas_estado(tarj_estado_id, tarj_estado_descrip) 	values(0,'Tarjeta Desvinculada')
go


--Cargar clientes, resta tener en cuenta tipos diferentes de emails e inconcistencias.
insert into NEW_SOLUTION.Clientes
(
	cli_id,
	cli_nombre,
	cli_apellido,
	cli_tdoc,
	cli_ndoc,
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
	  (convert(varchar,a.Cli_Pais_codigo)+convert(varchar,a.Cli_Tipo_Doc_Cod)+convert(varchar,a.Cli_Nro_Doc)),      
	  a.[Cli_Nombre],
      a.[Cli_Apellido],
      a.[Cli_Tipo_Doc_Cod],      
      a.[Cli_Nro_Doc],
	  a.[Cli_Mail],
      a.[Cli_Dom_Calle],
      a.[Cli_Dom_Nro],
      a.[Cli_Dom_Piso],
      a.[Cli_Dom_Depto],
      null,
      b.pais_cod,
      a.[Cli_Fecha_Nac],
      1,
      null
FROM gd_esquema.[Maestra] as a
left join NEW_SOLUTION.Paises as b on b.pais_cod = a.Cli_Pais_codigo
go

--Crear tabla de Usuarios
insert into NEW_SOLUTION.Usuarios
(
	usu_nombre,
	usu_cli_id
)
select	distinct
		substring((upper(SUBSTRING(cli_nombre,0,2)+SUBSTRING(cli_apellido,0,2))+''+convert(varchar,cli_ndoc)),0,50),
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
where	Tarjeta_Emisor_Descripcion is not null
go

--Cargar tarjetas de creditos.
insert into NEW_SOLUTION.Tarjetas
(
	tarj_numero,
	tarj_fecemision,
	tarj_fecvencimiento,
	tarj_codseguridad,
	tarj_emisor,
	tarj_estado,
	tarj_cli_id
)
select distinct
	   a.Tarjeta_Numero,
	   a.Tarjeta_Fecha_Emision,
	   a.Tarjeta_Fecha_Vencimiento,
	   hashbytes('SHA1',a.Tarjeta_Codigo_Seg),
	   b.tarjemis_id,
	   1,
	  (convert(varchar,a.Cli_Pais_codigo)+convert(varchar,a.Cli_Tipo_Doc_Cod)+convert(varchar,a.Cli_Nro_Doc))	  
from 	  gd_esquema.maestra as a
left join NEW_SOLUTION.Tarjetas_emisores as b on b.tarjemis_nombre=a.Tarjeta_Emisor_Descripcion
where  	  Tarjeta_Numero is not null
go




-----------------------------------------------------------------------------------------------------
-- cuentas, cálculo de saldo
-----------------------------------------------------------------------------------------------------

--Registrar dinero al depositar dinero.
create trigger new_solution.t_depositos_insert
on new_solution.depositos for insert
as
begin	
	--Registrar movimiento
	insert into NEW_SOLUTION.ctas_movimientos(ctamov_cta_id,ctamov_importe,ctamov_fecha,ctamov_cod)
	select d.depo_cta_id,
		   d.depo_importe,
		   d.depo_fecha,
		   'D'
	from   inserted as d 	
	
	--Actualizo el valor de la cuenta
	update a
	set a.cta_saldo=isnull(cta_saldo,0)+i.depo_importe
	from   NEW_SOLUTION.Cuentas  as a 
	inner join inserted as i on i.depo_cta_id=a.cta_id	
end
go

--Registrar movimientos al retirar dinero
create trigger new_solution.t_retiros_insert
on new_solution.retiros for insert
as
begin

	--Registro el movimiento
	insert into NEW_SOLUTION.ctas_movimientos(ctamov_cta_id,ctamov_importe,ctamov_fecha,ctamov_cod)	
	select r.ret_cta_id,
		   ch.chq_importe,
		   r.ret_fecha,
		   'R'
	from   inserted as r
	inner join NEW_SOLUTION.Cheques as ch on ch.chq_num=r.ret_num_cheque	
		
	--Actualizo el saldo
	update a
	set    a.cta_saldo = isnull(a.cta_saldo,0)-c.chq_importe
	from   NEW_SOLUTION.Cuentas as a
	inner join inserted as i on i.ret_cta_id=a.cta_id
	inner join NEW_SOLUTION.Cheques as c on c.chq_num=i.ret_num_cheque
	
end
go

--Un trigger que se ejecuta cada vez que se realiza una transferencia, se usa para registrar los costos.
create TRIGGER NEW_SOLUTION.t_transferencias_insert
ON NEW_SOLUTION.Transferencias FOR INSERT
as
	--Registrar en movimientos, la salida de dinero.
	insert into NEW_SOLUTION.ctas_movimientos(ctamov_cta_id,ctamov_importe,ctamov_fecha,ctamov_cod)
	select t.transf_cta_origen_id,
		   t.transf_importe,
		   t.transf_fecha,
		   'TO'
	from   inserted as t

	--Registrar en movimientos, la entrada de dinero.
	insert into NEW_SOLUTION.ctas_movimientos(ctamov_cta_id,ctamov_importe,ctamov_fecha,ctamov_cod)
	select t.transf_cta_destino_id,
		   t.transf_importe,
		   t.transf_fecha,
		   'TD'
	from   inserted as t
		
	--Registrar transferencias.
	insert into NEW_SOLUTION.Facturas_costos
	(
		factcto_num_op,
		factcto_tipo_op,
		factcto_cta_origen,
		factcto_fecha,
		factcto_costo,
		faccto_fact_id,
		factcto_costo_moneda
	)
	select	a.transf_id,
			1,
			a.transf_cta_origen_id,
			a.transf_fecha,
			a.transf_costo,
			null,
			1
	from    inserted as a
	where   a.transf_costo>0
	
	--Descontar saldo a cta origen.
	update a
	set    a.cta_saldo=isnull(a.cta_saldo,0)-i.transf_importe
	from NEW_SOLUTION.Cuentas as a
	inner join inserted as i on i.transf_cta_origen_id=a.cta_id
	
	
	--Aumentar salgo a la cta destino.
	update a
	set    a.cta_saldo=isnull(a.cta_saldo,0)+i.transf_importe
	from NEW_SOLUTION.Cuentas as a
	inner join inserted as i on i.transf_cta_destino_id=a.cta_id	
go


--Cargar tabla de categorias de cuentas.
insert into NEW_SOLUTION.Cuentas_categ
(
	ctacateg_id,
	ctacateg_descrip,
	ctacateg_costo,
	ctacateg_duracion_dias,
	ctacateg_estado_inicial,
	ctacateg_costo_transf
) 
values
	(0,'Oro',30,4,2,10),
	(1,'Plata',20,3,2,20),
	(2,'Bronce',10,2,2,30),
	(3,'Gratuitas',0,1,1,40)
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
	cta_estado,
	cta_saldo
)
select		distinct
			a.Cuenta_Numero,
			(convert(varchar,a.Cli_Pais_codigo)+convert(varchar,a.Cli_Tipo_Doc_Cod)+convert(varchar,a.Cli_Nro_Doc)),
			a.Cuenta_Pais_Codigo,
			1,
			99,--tipo cuenta migracion
			a.Cuenta_Fecha_Creacion,
			a.cuenta_fecha_cierre,
			1,
			0
from		gd_esquema.Maestra  as a
inner join	NEW_SOLUTION.Paises as b on b.pais_cod=a.Cuenta_Pais_Codigo
go

--Cargar depositos	  
insert into NEW_SOLUTION.depositos
(
	depo_cta_id,
	depo_cli_id,
	depo_moneda,
	depo_tarj_id,
	depo_fecha,
	depo_importe	
)
select 	   distinct 
		   c.cta_id,
		   c.cta_cli_id,
		   1,
		   t.tarj_id ,
		   a.Deposito_Fecha,
		   a.Deposito_Importe
from 	   gd_esquema.Maestra 			  as a
inner join NEW_SOLUTION.Cuentas           as c  on  c.cta_num          = a.cuenta_numero
inner join NEW_SOLUTION.Tarjetas_emisores as te on  te.tarjemis_nombre = a.Tarjeta_Emisor_Descripcion
inner join NEW_SOLUTION.Tarjetas		  as t  on  t.tarj_numero      = a.Tarjeta_Numero
												and t.tarj_emisor      = te.tarjemis_id
where a.Deposito_Codigo is not null
and   a.Tarjeta_Numero  is not null
and   a.Tarjeta_Emisor_Descripcion is not null
and	  a.Tarjeta_Emisor_Descripcion <>''
go

--Cargar los retiros.
insert into NEW_SOLUTION.Retiros
(
	ret_fecha,
	ret_cli_id,
	ret_num_cheque,	
	ret_cta_id
)
select  a.retiro_fecha,
		(
			convert(varchar,a.Cli_Pais_codigo)+
			convert(varchar,a.Cli_Tipo_Doc_Cod)+
			convert(varchar,a.Cli_Nro_Doc)
		),
		a.Cheque_Numero,
		c.cta_id
from       gd_esquema.Maestra   as a
inner join NEW_SOLUTION.Cuentas as c on  c.cta_num=a.Cuenta_Numero
where   a.Retiro_fecha   is not null
and     a.Cheque_Numero  is not null
and     c.cta_id is not null
go

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



------------------------------------------------------------------------
-- facturas
------------------------------------------------------------------------

create function NEW_SOLUTION.get_id_tipo_operacion (@descripcion varchar(255))
returns int
as
begin
	declare @id int
	select @id = fc.fact_comp_id from NEW_SOLUTION.Facturas_conceptos fc
	where fc.fact_comp_descrip = @descripcion
	return @id
end
go

create function NEW_SOLUTION.get_id_cliente (
@Cli_Pais_codigo numeric(18,0), 
@Cli_Tipo_Doc_Cod numeric(18,0),
@Cli_Nro_Doc numeric(18,0))
returns bigint
as
begin
	return	convert(varchar,@Cli_Pais_codigo)+
			convert(varchar,@Cli_Tipo_Doc_Cod)+
			convert(varchar,@Cli_Nro_Doc)
end
go

--Cargar item facturas
insert into NEW_SOLUTION.Facturas_costos
(
	faccto_fact_id,
	factcto_costo,
	factcto_cta_origen,
	factcto_costo_moneda,
	factcto_fecha,
	factcto_tipo_op	
)
select  distinct
		a.Factura_Numero,
		a.Item_Factura_Importe,
		a.Cuenta_Numero,
		1 /*dolares*/,
		a.Factura_Fecha,
		NEW_SOLUTION.get_id_tipo_operacion(a.Item_Factura_Descr)
from	gd_esquema.Maestra as a
where 
	a.Factura_Numero is not null and
	a.Item_Factura_Importe is not null and
	a.Cuenta_Numero is not null and
	a.Factura_Fecha is not null
go



--Cargar facturas
insert into NEW_SOLUTION.Facturas
(
	fact_cli_id,
	fact_id,
	fact_fecha,
	fact_total,
	fact_total_moneda
)
select  distinct
		NEW_SOLUTION.get_id_cliente(a.Cli_Pais_codigo,a.Cli_Tipo_Doc_Cod,a.Cli_Nro_Doc) cliente_id,		
		a.Factura_Numero,
		a.Factura_Fecha,
		sum(a.Item_Factura_Importe) costo_total,
		1 cod_moneda
from	gd_esquema.Maestra as a
join NEW_SOLUTION.Facturas_costos fc on fc.faccto_fact_id = a.Factura_Numero
group by 
	NEW_SOLUTION.get_id_cliente(a.Cli_Pais_codigo,a.Cli_Tipo_Doc_Cod,a.Cli_Nro_Doc),
	a.Factura_Numero, 
	a.Factura_Fecha
order by 
	NEW_SOLUTION.get_id_cliente(a.Cli_Pais_codigo,a.Cli_Tipo_Doc_Cod,a.Cli_Nro_Doc),
	a.Factura_Numero,
	a.Factura_Fecha
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

--Dice si una cuenta esta vencida, comparando con la fecha del sistema
create function new_solution.cuenta_vencida(@ctaid bigint,@fechaSYS datetime)
returns int
as
begin

	--Traigo la fecha de vencimiento de la cuenta	
	declare @fecvenc datetime
	select  @fecvenc = cta_fecha_vencimiento from   NEW_SOLUTION.Cuentas	where  cta_id=@ctaid
	
	--Si coincide la fecha de vencimiento con la fecha del sistema.
	if convert(varchar(8),@fecvenc,112)=convert(varchar(8),@fechaSYS,112)
		return 1
	else
		return 0
	
	return -1
end
go

--Dice si una cuenta esta activa en base a su ID.
create function NEW_SOLUTION.cuenta_activa(@ctaID bigint)
returns int
as
begin
	if exists(
	select c.cta_id from NEW_SOLUTION.Cuentas as c
	where c.cta_id=@ctaID
	and   c.cta_estado=1
	)
	return 1
	else
	return 0
	
	return null
end
go

--------------
-- TRIGGERS --
--------------


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

--Costos por tipo de cuenta.
create trigger [NEW_SOLUTION].[t_cuenta_insert] on [NEW_SOLUTION].[Cuentas]
for insert
as 
	declare @cta_origen bigint
	declare @cta_tipo int
	declare @cta_fecha datetime
	declare @tipo_cuenta_costo numeric(18,2)
	declare @tipo_moneda_cod int
	
	select 	@cta_origen        = i.cta_id,
			@cta_tipo          = i.cta_tipo,
			@cta_fecha         = i.cta_fecha_apertura,
			@tipo_cuenta_costo = cc.ctacateg_costo,
			@tipo_moneda_cod   = i.cta_moneda
	from	inserted i
	join	NEW_SOLUTION.Cuentas_categ cc on cc.ctacateg_id = i.cta_tipo
	
	if(@cta_tipo <> 3)
	begin 
		--igual a gratuita no genero costo
		insert into NEW_SOLUTION.Facturas_costos
		(
			factcto_cta_origen,
			factcto_tipo_op,
			factcto_fecha,
			factcto_costo,
			factcto_costo_moneda
		)
		values(@cta_origen, 2, @cta_fecha, @tipo_cuenta_costo, @tipo_moneda_cod)
	end					
go

--Registra en la tabla de cuenta historicas bloqueo, la fecha y cuenta en que se bloqueo una tabla.
create trigger new_Solution.t_cuenta_update on new_solution.cuentas
for update as
begin

	insert into NEW_SOLUTION.cuentas_historico_bloqueo(ctabloqueo_fecha,ctabloqueo_cta_id)
	select	   i.cta_fecha_bloqueo,
			   i.cta_id
	from	   inserted as i
	inner join deleted  as d on d.cta_id=i.cta_id
	where	   i.cta_fecha_bloqueo  is not null
	and        d.cta_fecha_bloqueo  is null

end
go

--Bloquea las cuentas que tienen mas de 5 transacciones sin haber sido facturadas.
create trigger NEW_SOLUTION.tr_fact_costo on new_solution.Facturas_costos for insert
as
begin
	--Fecha actual, la traigo de las transacciones
	declare @fecha datetime
	select  @fecha = max(factcto_Fecha) from inserted
	
	--Bloquear cuentas con más de 5 transacciones
	create table #tmp_ctas(ctaID bigint)

	--Detectar agrupaciones de 5 transacciones en cuentas sin bloquear.
	insert into #tmp_ctas
	select   factcto_cta_origen
	from	 NEW_SOLUTION.Facturas_costos
	where    faccto_fact_id is null
	group by factcto_cta_origen
	having COUNT(*)>=5

	--Inabilito la cuenta, pongo la fecha del sistema
	update a
	set    a.cta_estado		   = 0,
		   a.cta_fecha_bloqueo = @fecha
	from       NEW_SOLUTION.Cuentas as a
	inner join #tmp_ctas            as b on b.ctaID=a.cta_id

	drop table #tmp_ctas
end
go

----------------------------------------------------------------------------
--						STORE PROCEDURES								  --
----------------------------------------------------------------------------

--Valida el usuario con su ndoc.			
create procedure NEW_SOLUTION.sp_valida_id_dni(@usu_id bigint,@ndoc numeric(18,0))
as
begin
	if exists(
				select	   u.usu_id
				from	   NEW_SOLUTION.Usuarios as u
				inner join NEW_SOLUTION.Clientes as c on c.cli_id=u.usu_cli_id
				where u.usu_id=@usu_id
				and  c.cli_ndoc=@ndoc
			)
		return 1
	else
		return 0
end		
go

--Bloquea cuentas ques vencen en esta fecha.
create procedure new_solution.sp_bloquear_ctas_vencimiento(@fechaSYS datetime)
as
	update NEW_SOLUTION.Cuentas
	set    cta_estado=4
	where convert(varchar(6),cta_fecha_vencimiento,112)=convert(varchar(6),@fechaSYS,112)
	and   cta_estado<>4
go	

--Buscar clientes.
create procedure NEW_SOLUTION.sp_buscar_clientes(@tdoc numeric(18,0),@ndoc numeric(18,0))
as
	if (@ndoc <>-1)
	begin
		select  c.cli_id,
				c.cli_nombre,
				c.cli_apellido,
				c.cli_nacionalidad,
				p.pais_descrip,
				c.cli_mail
		from   		NEW_SOLUTION.Clientes 	as c
		left join 	NEW_SOLUTION.Paises 	as p on p.pais_cod=cli_nacionalidad
		where 	c.cli_tdoc=@tdoc
		and    	c.cli_ndoc=@ndoc	
	end
	else
	begin
		select 	c.cli_id,
				c.cli_nombre,
				c.cli_apellido,
				c.cli_nacionalidad,
				p.pais_descrip,
				c.cli_mail
		from   		NEW_SOLUTION.Clientes 	as c
		left join 	NEW_SOLUTION.Paises 	as p on p.pais_cod=cli_nacionalidad
		where  	c.cli_tdoc=@tdoc
	end
go

--Obtengo el listado de documentos.
create procedure NEW_SOLUTION.sp_traer_tipos_doc
as
	select tdoc_cod,tdoc_descrip from NEW_SOLUTION.Documentos_tipo
go

--Reactivar cuentas vencidas e inabilitadas.
create procedure new_solution.sp_reactivar_vencidas_inabilitadas(@cliID bigint,@fechaSYS datetime)
as
		--Reactivar cuentas vencidas de la factura.
		update a
		set    a.cta_estado = 1,
			   a.cta_fecha_vencimiento=DATEADD(dd,a.cta_num_suscrip*ct.ctacateg_duracion_dias,@fechaSYS)--multiplicar por cantidad dee suscripciones
		from   NEW_SOLUTION.Cuentas as a
		inner join NEW_SOLUTION.Facturas_costos as fc on  fc.factcto_cta_origen = a.cta_id
													  and fc.factcto_tipo_op    = 2
													  and fc.faccto_fact_id is null
		inner join NEW_SOLUTION.Cuentas_categ as ct on ct.ctacateg_id=a.cta_tipo										      
		where a.cta_estado=4
		and   a.cta_cli_id=@cliID
				
		--Desbloquear cuentas inabilitadas.
		update a
		set    a.cta_estado = 1,
			   a.cta_fecha_vencimiento=DATEADD(dd,a.cta_num_suscrip*ct.ctacateg_duracion_dias,@fechaSYS),
			   a.cta_fecha_bloqueo=null
		from   NEW_SOLUTION.Cuentas as a
		inner join NEW_SOLUTION.Facturas_costos as fc on  fc.factcto_cta_origen = a.cta_id
													  and fc.factcto_tipo_op    = 2
													  and fc.faccto_fact_id is null
		inner join NEW_SOLUTION.Cuentas_categ as ct on ct.ctacateg_id=a.cta_tipo										      
		where a.cta_estado=0
		and   a.cta_cli_id=@cliID		
		
		--Reactivar cuentas en "Estado Pendiente", son las cuentas no vencidas que se dan de alta.
		update     a
		set        a.cta_estado=1,
				   a.cta_fecha_vencimiento=DATEADD(dd,a.cta_num_suscrip*ct.ctacateg_duracion_dias,@fechaSYS)		
		from       NEW_SOLUTION.Cuentas         as a
		inner join NEW_SOLUTION.Cuentas_categ   as ct on ct.ctacateg_id=a.cta_tipo										      			   
		inner join NEW_SOLUTION.Facturas_costos as fc on  fc.factcto_cta_origen=a.cta_id
													  and fc.faccto_fact_id is null
													  and fc.factcto_tipo_op=2
		where  a.cta_estado=2
		--and    a.cta_fecha_vencimiento is null
		
		--Actualizar cambios de estados.
		update a
		set    a.cta_estado=1,
			   a.cta_fecha_vencimiento=DATEADD(dd,a.cta_num_suscrip*ct.ctacateg_duracion_dias,@fechaSYS)
		from   NEW_SOLUTION.Cuentas as a
		inner join NEW_SOLUTION.Facturas_costos as fc on  fc.factcto_cta_origen=a.cta_id
													  and fc.faccto_fact_id is null
													  and fc.factcto_tipo_op=3
		inner join NEW_SOLUTION.Cuentas_categ   as ct on  ct.ctacateg_id=a.cta_tipo												  
		where  a.cta_estado=2
		and	   a.cta_fecha_vencimiento is not null
go

--Realizo la facturación, obtengo el nuevo idfactura generado, exclusivo para el administrador.
create procedure new_solution.sp_facturar_costos_cliente(@cliID bigint,@fechaSYS datetime)
as
begin
	--Busco si hay elementos que facturar
	if exists(
				select fc.factcto_id
				from  NEW_SOLUTION.facturas_costos as fc
				inner join NEW_SOLUTION.Cuentas as cta on cta.cta_id=fc.factcto_cta_origen		
				where fc.faccto_fact_id is null
				and cta.cta_cli_id=@cliID
			)
	begin

		--Calculo el total a pagar.
		declare @total numeric(18,2)
		
		select @total = SUM(fc.factcto_costo)
		from  NEW_SOLUTION.facturas_costos as fc
		inner join NEW_SOLUTION.Cuentas    as cta on cta.cta_id=fc.factcto_cta_origen
		where fc.faccto_fact_id is null
		and cta.cta_cli_id=@cliID
		
		--Obtengo el id cliente.	
		insert into NEW_SOLUTION.Facturas(fact_total,fact_total_moneda,fact_cli_id,fact_fecha,fact_user_gen)
		values(@total,1,@cliID,@fechaSYS,-1)
		
		--Reactivar vencidas e inabilitadas-
		exec new_solution.sp_reactivar_vencidas_inabilitadas @cliID,@fechaSYS
		
		--Actualizo en la tabla conceptos el idfactura.	
		update fc
		set fc.faccto_fact_id=@@IDENTITY
		from NEW_SOLUTION.facturas_costos as fc
		inner join NEW_SOLUTION.Cuentas    as cta on cta.cta_id=fc.factcto_cta_origen
		where fc.faccto_fact_id is null
		and cta.cta_cli_id=@cliID
		
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
			f.faccto_fact_id
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
	select fc.fact_id,fc.fact_fecha,fc.fact_total,fc.fact_user_gen
	from   NEW_SOLUTION.Facturas as fc				
	inner join NEW_SOLUTION.Clientes as cli on cli.cli_id=fc.fact_cli_id
	inner join NEW_SOLUTION.Usuarios as usu on usu.usu_cli_id=cli.cli_id
	where usu.usu_id=@userID
	order by fc.fact_id desc
go


--Traigo todas las facturas de un cliente.
create procedure NEW_SOLUTION.traer_facturas_cliente(@cliID bigint)
as
	select fc.fact_id,fc.fact_fecha,fc.fact_total,m.moneda_descrip,fc.fact_user_gen
	from   NEW_SOLUTION.Facturas as fc
	left join NEW_SOLUTION.Monedas as m on m.moneda_id=fc.fact_total_moneda
	where fc.fact_cli_id=@cliID
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
create procedure NEW_SOLUTION.sp_actualizar_tarjeta(@tarjID bigint,@tarjNum varchar(16),@tarjFecEmis datetime,@tarjVenc datetime,@tarjSeg  varchar(100),@tarjEmis int)
as
	update  NEW_SOLUTION.Tarjetas
	set	    tarj_numero=@tarjNum,
			tarj_fecemision=@tarjFecEmis,
			tarj_fecvencimiento=@tarjVenc,
			tarj_codseguridad=hashbytes('SHA1',@tarjSeg),
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
create procedure NEW_SOLUTION.sp_vincular_tarjeta(@tarjNum varchar(16),@tarjFecEmis datetime,@tarjVenc datetime,@tarjSeg  varchar(100),@tarjEmis int,@usuId bigint)
as
	declare @cliID bigint
	select top 1 @cliID = usu_cli_id from NEW_SOLUTION.Usuarios where usu_id=@usuId
	
	insert into NEW_SOLUTION.Tarjetas(tarj_numero,tarj_fecemision,tarj_fecvencimiento,tarj_codseguridad,tarj_emisor,tarj_estado,tarj_cli_id)
	values(@tarjNum,@tarjFecEmis,@tarjVenc,hashbytes('SHA1',@tarjSeg),@tarjEmis,1,@cliID)
go

--Traer tarjetas vinculadas, sin tener en cuenta fecha de vencimiento.
create procedure NEW_SOLUTION.sp_traer_tarjetas_vinculadas_userid(@usuId bigint,@fechaSYS datetime)
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
		   u.usu_id,
		   case when a.tarj_fecvencimiento>@fechaSYS then 'Vencida' else 'Activa' end estado
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
	if (@cuentaNum<>'')
	begin
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
	end
	else
	begin
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
	end
go

--Busca las cuentas en base a un id cliente.
create procedure NEW_SOLUTION.sp_buscar_cta_idcli(@cli_id bigint)
as
	select 	   distinct
			   a.cta_id,
			   a.cta_num,
		       a.cta_cli_id,
			   b.pais_descrip
	from 	   NEW_SOLUTION.Cuentas  as a
	inner join NEW_SOLUTION.Paises   as b on b.pais_cod   = a.cta_pais_apertura
	inner join NEW_SOLUTION.Clientes as c on c.cli_id     = a.cta_cli_id	
	inner join NEW_SOLUTION.Usuarios as d on d.usu_cli_id = c.cli_id		
	where d.usu_id 	   = @cli_id 
	and   a.cta_estado = 1
go

--Obtiene el saldo actual de la cuenta.
create procedure NEW_SOLUTION.consultar_saldo_cta_id(@ctaID bigint)
as
begin
	declare @saldo numeric(18,2)
	select top 1 @saldo = cta_saldo from NEW_SOLUTION.Cuentas where cta_id=@ctaID
	
	select isnull(@saldo,0) as saldo
end
go

--Consulta ultimos movimientos.
create procedure NEW_SOLUTION.sp_cta_movimientos(@ctaID bigint)
as
begin

	select top 5 
		  mov.ctamov_id,
		  case when mov.ctamov_cod ='D'  then 'Deposito'
				when mov.ctamov_cod='R'  then 'Retiro'
				when mov.ctamov_cod='TO' then 'Transf. Saliente'
				when mov.ctamov_cod='TD' then 'Transf. Entrante'
		   end as tipo,
		   case when mov.ctamov_cod='D'  then '+ '+cast(mov.ctamov_importe as varchar)
				when mov.ctamov_cod='R'  then '- '+cast(mov.ctamov_importe as varchar)
				when mov.ctamov_cod='TO' then '- '+cast(mov.ctamov_importe as varchar)
				when mov.ctamov_cod='TD' then '+ '+cast(mov.ctamov_importe as varchar)
		   end as importe,
		   mov.ctamov_fecha as fecha
	from   NEW_SOLUTION.ctas_movimientos as mov
	where  mov.ctamov_cta_id=@ctaID
	order by mov.ctamov_id desc
end
go

--Estadisticas PUNTO 5
create procedure NEW_SOLUTION.sp_stats_5(@inicio datetime,@fin datetime)
as
begin
		select  top 5
				ctag.ctacateg_descrip,
			    SUM(fc.factcto_costo)
		from	NEW_SOLUTION.Facturas_costos  as fc
		inner join NEW_SOLUTION.Cuentas       as cta  on cta.cta_id        = fc.factcto_cta_origen
		inner join NEW_SOLUTION.Cuentas_categ as ctag on ctag.ctacateg_id  = cta.cta_tipo
		inner join NEW_SOLUTION.Facturas      as fac  on fac.fact_id       = fc.faccto_fact_id
		where fac.fact_fecha  >= @inicio
		and   fac.fact_fecha  <= @fin
		group by ctag.ctacateg_descrip
		order by SUM(fc.factcto_costo) desc
end
go

--Estadisticas PUNTO 4
create procedure NEW_SOLUTION.sp_stats_4(@inicio datetime,@fin datetime)
as
begin
	--Realizo la consulta	
	select 	   top 5
			   p.pais_descrip,
			   (COUNT(depo.depo_id)+COUNT(ret.ret_id)) as movimientos
	from 		NEW_SOLUTION.Paises 	as p
	inner join 	NEW_SOLUTION.Cuentas 	as cta  on cta.cta_pais_apertura = p.pais_cod
	left join 	NEW_SOLUTION.Depositos 	as depo on depo.depo_cta_id      = cta.cta_id
	left join 	NEW_SOLUTION.Retiros 	as ret 	on ret.ret_cta_id		 = cta.cta_id
	where  		(depo.depo_fecha>=@inicio 	 and depo.depo_fecha<=@fin)
	or     		(ret.ret_fecha  >=@inicio    and ret.ret_fecha  <=@fin)
	group by p.pais_descrip
	having   (COUNT(depo.depo_id)+COUNT(ret.ret_id))>0
	order by (COUNT(depo.depo_id)+COUNT(ret.ret_id)) desc	
end
go

--Estadisticas PUNTO 3
create procedure NEW_SOLUTION.sp_stats_3(@inicio datetime,@fin datetime)
as
begin
	create table #tmp
	(
		cli_id bigint,
		total  bigint
	)
	
	insert into #tmp(cli_id,total)
	--Transferencias
	select  c1.cta_cli_id,
			COUNT(tf.transf_id)
	from	NEW_SOLUTION.Transferencias as tf
	inner join NEW_SOLUTION.Cuentas as c1 on c1.cta_id=tf.transf_cta_origen_id
	inner join NEW_SOLUTION.Cuentas as c2 on c2.cta_id=tf.transf_cta_destino_id
	where c1.cta_cli_id=c2.cta_cli_id
	and   tf.transf_fecha>=@inicio
	and   tf.transf_fecha<=@fin
	group by c1.cta_cli_id
	union all
	--Retiros
	select   r.ret_cli_id,
			 COUNT(r.ret_id)
	from     NEW_SOLUTION.Retiros as r
	where    r.ret_fecha>=@inicio
	and		 r.ret_fecha<=@fin
	group by r.ret_cli_id
	union all
	--Depositos
	select  d.depo_cli_id,
			COUNT(d.depo_id)
	from	NEW_SOLUTION.Depositos as d
	where   d.depo_fecha>=@inicio
	and     d.depo_fecha<=@fin
	group by d.depo_cli_id
	
	--Listar
	select   top 5
			 a.cli_id,
			 c.cli_apellido,
			 c.cli_nombre,
			 c.cli_ndoc,
			 sum(a.total)
	from	   #tmp as a
	inner join NEW_SOLUTION.Clientes as c on c.cli_id=a.cli_id
	group by a.cli_id,
			 c.cli_apellido,
			 c.cli_nombre,
			 c.cli_ndoc	
	order by SUM(a.total) desc
	
	drop table #tmp
end
go	

--ESTADISTICAS PUNTO 2
create procedure NEW_SOLUTION.sp_stats_2(@inicio datetime,@fin datetime)
as
begin
	select  top 5
			cli.cli_apellido,
			cli.cli_nombre,
			cli.cli_ndoc,
			sum(fc.factcto_costo)
	from	   NEW_SOLUTION.Facturas_costos as fc
	inner join  NEW_SOLUTION.Cuentas      as c on c.cta_id=fc.factcto_cta_origen
	inner join  NEW_SOLUTION.Clientes     as cli on cli.cli_id=c.cta_cli_id
	inner join  NEW_SOLUTION.Facturas     as fac on fac.fact_id=fc.faccto_fact_id
	where   fac.fact_fecha>=@inicio
	and     fac.fact_fecha<=@fin
	group by	cli.cli_apellido,
				cli.cli_nombre,
				cli.cli_ndoc
	order by  sum(fc.factcto_costo) desc
end	
go

--ESTADISTICAS PUNTO 1
create procedure NEW_SOLUTION.sp_stats_1(@inicio datetime,@fin datetime)
as
begin
	select	   top 5
			   cli.cli_apellido,
			   cli.cli_nombre,
			   cli.cli_ndoc,		
			   COUNT(cb.ctabloqueo_id)
	from	   NEW_SOLUTION.cuentas_historico_bloqueo as cb
	inner join NEW_SOLUTION.Cuentas					  as cta on cta.cta_id = cb.ctabloqueo_cta_id
	inner join NEW_SOLUTION.Clientes				  as cli on cli.cli_id = cta.cta_cli_id
	where	   cb.ctabloqueo_fecha>=@inicio
	and		   cb.ctabloqueo_fecha<=@fin	
	group by   cli.cli_apellido,
			   cli.cli_nombre,
			   cli.cli_ndoc
	order by   COUNT(cb.ctabloqueo_id) desc
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
	inner join NEW_SOLUTION.Paises   as b on b.pais_cod   = a.cta_pais_apertura
	inner join NEW_SOLUTION.Clientes as c on c.cli_id     = a.cta_cli_id	
	inner join NEW_SOLUTION.Usuarios as d on d.usu_cli_id = c.cli_id		
	where d.usu_id =@cli_id 
	and   a.cta_estado = 1
	and   a.cta_saldo>0
go

--Busca las cuentas en base a un id cliente, PERO que el saldo sea mayor a CERO.
create procedure NEW_SOLUTION.sp_buscar_cta_cli_activa(@cli_id bigint)
as
	select distinct
		   a.cta_id,
		   a.cta_num,
		   a.cta_cli_id,
		   b.pais_descrip
	from NEW_SOLUTION.Cuentas as a
	inner join NEW_SOLUTION.Paises   as b on b.pais_cod   = a.cta_pais_apertura
	inner join NEW_SOLUTION.Clientes as c on c.cli_id     = a.cta_cli_id	
	inner join NEW_SOLUTION.Usuarios as d on d.usu_cli_id = c.cli_id		
	where d.usu_id =@cli_id 
	and   a.cta_estado = 1
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
	and    a.tarj_fecvencimiento < @fechaSYS
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
(
	@nombre varchar(255)
)
as
begin
	declare @id_result numeric(18,0);
	declare @rol_id    int
	
	select @rol_id = max(r.rol_id) + 1  from NEW_SOLUTION.Roles r
	
	--set @rol_id = @rol_id + 1;
	insert into NEW_SOLUTION.roles (rol_id, rol_nombre)
	values (@rol_id, @nombre)
	--set @id_result = scope_identity();
	return @rol_id
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
	@id_cliente bigint = null,
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
	else if (@id_cliente is not null)
		select
			u.usu_id,
			u.usu_nombre,
			u.usu_estado,
			u.usu_cli_id
		from
			NEW_SOLUTION.Usuarios u
		where
			u.usu_cli_id = @id_cliente
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
	@password varchar(255) = null,
	@fecha_sistema datetime = null
	
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
			usu_password = @password,
			usu_fecUltmodif = @fecha_sistema
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
--	PAISES                        --
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
--	MONEDAS                       --
------------------------------------

create procedure NEW_SOLUTION.sp_moneda_get
as
begin
	select 
		m.moneda_id,
		m.moneda_descrip	
	from
		NEW_SOLUTION.Monedas m
end
go

------------------------------------
--	TIPO CUENTA                   --
------------------------------------

create procedure NEW_SOLUTION.sp_tipo_cuenta_get
as
begin
	select 	c.ctacateg_id,
			c.ctacateg_descrip,
			c.ctacateg_costo,
			c.ctacateg_duracion_dias,
			c.ctacateg_estado_inicial,
			c.ctacateg_descrip+' - '+cast(c.ctacateg_duracion_dias as varchar)+' Dias' as descrip_completa
	from	NEW_SOLUTION.Cuentas_categ c
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
			c.cli_piso,
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
			set @query = @query +		'c.cli_id, '
			set @query = @query +		'c.cli_apellido, '
			set @query = @query +		'c.cli_nombre, '
			set @query = @query +		'c.cli_mail, '
			set @query = @query +		'c.cli_tdoc, '
			set @query = @query +		'c.cli_ndoc, '
			set @query = @query +		'c.cli_estado, '
			set @query = @query +		'c.cli_nacionalidad,'
			set @query = @query +		'c.cli_fecnac,'
			set @query = @query +		'c.cli_localidad,'
			set @query = @query +		'c.cli_calle,'
			set @query = @query +		'c.cli_piso,'			
			set @query = @query +		'c.cli_numero,'		
			set @query = @query +		'c.cli_depto '
			set @query = @query +	'from NEW_SOLUTION.Clientes c '			
			set @query = @query +	'where '
		if(@apellido is not null)			
			set @query = @query +		'c.cli_apellido like ''%' +@apellido + '%'' and '
		if(@nombre is not null)
			set @query = @query +		'c.cli_nombre like ''%' +@nombre + '%'' and '
		if(@mail is not null)
			set @query = @query +		'c.cli_mail like ''%' + @mail + '%'' and '
		if(@tipo_identificacion is not null)
			set @query = @query +		'cast(c.cli_tdoc as varchar) = ''' + @tipo_identificacion + ''' and '
		if(@identificacion is not null)
			set @query = @query +		'cast(c.cli_ndoc as varchar)like ''%'+ cast(@identificacion as varchar) +'%'' and '
		set @query = @query +			'1=1'
		print @query
		exec (@query)
end
go

create procedure NEW_SOLUTION.sp_cliente_add
	@nombre				varchar(255),
    @apellido			varchar(255),
    @mail				varchar(255),
    @tipo_documento		numeric(18,0),
    @documento			numeric(18,0),
    @nacionalidad		int,
    @id_usuario			int,
	@calle				varchar(255),
	@numero				varchar(50),
	@piso				numeric(18,0),
	@depto				varchar(10),
	@localidad			varchar(100),
	@fecnac				varchar(20)    
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
			declare @id bigint = (convert(varchar,@nacionalidad)+convert(varchar,@tipo_documento)+convert(varchar,@documento));
			
			update NEW_SOLUTION.Usuarios
			set usu_cli_id = @id
			where usu_id = @id_usuario
			
			insert into NEW_SOLUTION.Clientes
			(
				cli_id,
				cli_apellido, 
				cli_nombre,
				cli_mail,
				cli_tdoc,
				cli_ndoc,
				cli_nacionalidad,				
				cli_calle,
				cli_numero,
				cli_piso,
				cli_depto,
				cli_localidad,
				cli_fecnac
			)
			values
			(
				@id,
				@apellido,
				@nombre,
				@mail,
				@tipo_documento,
				@documento,
				@nacionalidad,
				@calle,
				@numero,
				@piso,
				@depto,
				@localidad,
				@fecnac
			)
			
			if (exists(select cli_id from new_solution.clientes where cli_id=@id))
				return 1;
			else
				return 0;
			
		end
	return @id_result;
end
go

create procedure NEW_SOLUTION.sp_cliente_update
	@id bigint,
	@nombre varchar(255),
    @apellido varchar(255),
    @mail varchar(255),
    @tipo_documento numeric(18,0),
    @documento numeric(18,0),
    @nacionalidad int,
    @estado varchar(1),
	@calle varchar(255),
	@numero varchar(50),
	@piso numeric(18,0),
	@depto varchar(10),
	@localidad varchar(100),
	@fecnac    datetime
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
				cli_apellido 		= @apellido,
				cli_nombre 			= @nombre,
				cli_mail 			= @mail,
				cli_tdoc 			= @tipo_documento,
				cli_ndoc 			= @documento,
				cli_nacionalidad 	= @nacionalidad,
				cli_estado 			= @estado,
				cli_calle			= @calle,
				cli_numero  		= @numero,
				cli_piso			= @piso,					
				cli_depto			= @depto,
				cli_localidad		= @localidad,
				cli_fecnac			= @fecnac
			where
				cli_id = @id;			
	--	end
	return @id_result;
end
go

--------------------------
--		  CUENTAS		--
--------------------------
create procedure NEW_SOLUTION.sp_cuenta_get(
	@cliente_id bigint = null,
	@cuenta_id bigint = null)
as
begin
	if(@cliente_id is not null)
		select 
			c.cta_id,
			c.cta_num,
			c.cta_pais_apertura,
			c.cta_moneda,
			c.cta_tipo,
			c.cta_estado,
			c.cta_fecha_apertura,
			c.cta_fecha_vencimiento,
			c.cta_num_suscrip,
			c.cta_saldo
		from 			
			NEW_SOLUTION.Cuentas c
		where 
			c.cta_cli_id = @cliente_id
	else if(@cuenta_id is not null)
		select 
			c.cta_cli_id,
			c.cta_num,
			c.cta_pais_apertura,
			c.cta_moneda,
			c.cta_tipo,
			c.cta_estado,
			c.cta_fecha_apertura,
			c.cta_fecha_vencimiento,
			c.cta_num_suscrip,
			c.cta_saldo			
		from 			
			NEW_SOLUTION.Cuentas c
		where 
			c.cta_id = @cuenta_id
end
go

create procedure NEW_SOLUTION.sp_cuenta_get_nuevo_numero_cuenta
as
begin
	select max(c.cta_num) + 1  as numero_cuenta from NEW_SOLUTION.Cuentas c
end
go

create procedure NEW_SOLUTION.sp_cuenta_get_estados
as
begin
	select 
		c.cta_estado_id,
		c.cta_estado_descrip
	from NEW_SOLUTION.Cuentas_estado c
end
go

create procedure NEW_SOLUTION.sp_cuenta_add
(
	@cliente_id			 bigint,
	@cuenta_nro 		 bigint,
    @pais_cod 			 int,
    @moneda_cod 		 int,
    @tipo_cuenta_cod	 int,
    @fecha_apertura 	 datetime,
    @cant_subscripciones int
)	
as
begin
	declare @estado int
	declare @dias   int
	declare @fecha_vencimiento datetime = null
	
	select 	@estado = cc.ctacateg_estado_inicial,
			@dias   = cc.ctacateg_duracion_dias
	from    NEW_SOLUTION.Cuentas_categ cc
	where cc.ctacateg_id = @tipo_cuenta_cod
	
	--si es gratuita calculo fecha vencimiento
	if(@tipo_cuenta_cod = 3)	
		set @fecha_vencimiento = DATEADD(DAY, @cant_subscripciones * @dias, @fecha_apertura) 
	
	insert into NEW_SOLUTION.Cuentas
	(
		cta_cli_id,		
		cta_fecha_apertura,
		cta_moneda,
		cta_num,
		cta_pais_apertura,
		cta_tipo,
		cta_estado,
		cta_num_suscrip,
		cta_fecha_vencimiento,
		cta_saldo
	)
	values
	(
		@cliente_id,
		convert(datetime,@fecha_apertura,121),
		@moneda_cod,
		@cuenta_nro,
		@pais_cod,
		@tipo_cuenta_cod,
		@estado,
		@cant_subscripciones,
		@fecha_vencimiento,
		0
	)
end
go

create procedure NEW_SOLUTION.sp_cuenta_update
	@cuenta_nro bigint,
    @tipo_cuenta_cod int,
    @fecha_operacion datetime,
    @tipo_moneda_cod int,
    @estado_cuenta_cod int,
    @cant_subscripciones int
as
begin

	declare @nuevo_estado 		int
	declare @tipo_operacion 	int
	declare @costo 				numeric(18,2)
	declare @fecha_vencimiento  datetime
	declare @dias 				int
	declare @idcta				bigint
	
	select  @idcta = cta_id from new_solution.cuentas where cta_num=@cuenta_nro
	
	select  @nuevo_estado  = cc.ctacateg_estado_inicial,
			@costo 		   = cc.ctacateg_costo,
			@dias 		   = cc.ctacateg_duracion_dias
	from 	NEW_SOLUTION.Cuentas_categ cc
	where   cc.ctacateg_id = @tipo_cuenta_cod

	if(@tipo_cuenta_cod = 3)	
		set @fecha_vencimiento = DATEADD(DAY, @cant_subscripciones * @dias, @fecha_operacion) 
		
	--Gratuita: cambio cat o reactivacion -> no genero costo
	if(@tipo_cuenta_cod = 3)
	begin
		update  NEW_SOLUTION.Cuentas
		set 	cta_tipo 		      = @tipo_cuenta_cod,
				cta_estado 		      = @nuevo_estado,
				cta_fecha_apertura    = @fecha_operacion,
				cta_fecha_vencimiento = @fecha_vencimiento,
				cta_num_suscrip 	  = @cant_subscripciones
		where   cta_num 			  = @cuenta_nro
	--no gratuita: cuenta activa -> cambio categoria -> cambio estado -> genero costo
	end
	else
		if(@estado_cuenta_cod = 1)
		begin  
		
			update NEW_SOLUTION.Cuentas
			set cta_tipo 	 	= @tipo_cuenta_cod,
				cta_estado 	    = @nuevo_estado,
				cta_num_suscrip = @cant_subscripciones
			where cta_num 	    = @cuenta_nro
			
			--costo por cambio de categoria
			insert into NEW_SOLUTION.Facturas_costos(factcto_cta_origen, factcto_tipo_op, factcto_fecha, factcto_costo, factcto_costo_moneda)
			values(@idcta, 3/*por cambio categoria*/, @fecha_operacion, @costo, @tipo_moneda_cod)
				
		--No gratuita: cuenta vencida -> reactivación de cuenta	-> cambio estado	-> genero costo
		end
	else
		if(@estado_cuenta_cod = 4)
		begin
		
			update NEW_SOLUTION.Cuentas
			set    cta_tipo        = @tipo_cuenta_cod,
				   cta_estado      = @nuevo_estado,
				   cta_num_suscrip = @cant_subscripciones
			where  cta_num         = @cuenta_nro
			
			--costo por reactivacion
			insert into NEW_SOLUTION.Facturas_costos(factcto_cta_origen, factcto_tipo_op, factcto_fecha, factcto_costo, factcto_costo_moneda)
			values (@idcta, 2/*por nueva subscripcion*/, @fecha_operacion, @costo, @tipo_moneda_cod)
				
		--se cierra cuenta -> cambio estado -> no genero costo
		end
		else
			if(@estado_cuenta_cod = 3)
			begin
			
				update NEW_SOLUTION.Cuentas
				set    cta_estado 		= @estado_cuenta_cod,
					   cta_fecha_cierre = @fecha_operacion
				where  cta_num 			= @cuenta_nro
				
			end		
	end
go

create procedure NEW_SOLUTION.sp_cuenta_cerrar
	@cuenta_nro bigint,
    @fecha_operacion datetime,
    @estado_cuenta_cod int
as
begin
	--se cierra cuenta -> cambio estado -> no genero costo
	update NEW_SOLUTION.Cuentas
	set 
		cta_estado = @estado_cuenta_cod,
		cta_fecha_cierre = @fecha_operacion
	where cta_num = @cuenta_nro	
end
go

create function NEW_SOLUTION.f_dias_tipo_cuenta(@tipo int)
returns int
as
begin
	declare @dias int;
	select 
		@dias = cc.ctacateg_duracion_dias 
	from NEW_SOLUTION.Cuentas_categ cc
	where 
		cc.ctacateg_id = @tipo
	return @dias;
end
go

create procedure NEW_SOLUTION.sp_cuenta_actualizar_estados
	@fecha_sistema datetime
as
begin
	update NEW_SOLUTION.Cuentas
		set cta_estado = 4 --cuenta vencida
	where
		DATEDIFF(DAY, cta_fecha_vencimiento, @fecha_sistema) > 0
		and cta_estado <> 2
end
go

create function NEW_SOLUTION.f_dias_cta_cat(@cta_cat int)
returns int
as
begin
	declare @dias int
	select @dias = ctacateg_duracion_dias
	from NEW_SOLUTION.Cuentas_categ
	where ctacateg_id = @cta_cat		
	return @dias
end
go

create procedure NEW_SOLUTION.sp_cuenta_actualizar_fechas_vto
	@fecha_sistema datetime,
	@tipo_cuenta int
as
begin	
	if(exists (select * from NEW_SOLUTION.Cuentas where cta_tipo = 99))
	begin		
		declare @dias int
		select @dias = ctacateg_duracion_dias
		from NEW_SOLUTION.Cuentas_categ
		where ctacateg_id = @tipo_cuenta		

		update NEW_SOLUTION.Cuentas
		set 
			cta_fecha_vencimiento = DATEADD(DAY, @dias, @fecha_sistema),
			cta_tipo = @tipo_cuenta 
		where
			cta_tipo = 99
	end
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
go	

insert into NEW_SOLUTION.Usuarios_roles (usu_id, rol_id)
values 	(NEW_SOLUTION.f_get_id('a'), 1),--admin
		(NEW_SOLUTION.f_get_id('a'), 2),--cliente
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