--Limpiar caches.
DBCC FREEPROCCACHE
DBCC DROPCLEANBUFFERS

--Logeo inicio
select 'Inicio',GETDATE()

--BORRAR TABLAS
--Se hace para evitar errores de tablas ya creadas
IF (OBJECT_ID('[gd_esquema].Login') is not null)				 drop table [gd_esquema].Login
IF (OBJECT_ID('[gd_esquema].Login_incorrecto') is not null)		 drop table [gd_esquema].Login_incorrecto
IF (OBJECT_ID('[gd_esquema].Usuario') is not null)				 drop table [gd_esquema].Usuario
IF (OBJECT_ID('[gd_esquema].Roles') is not null)				 drop table [gd_esquema].Roles
IF (OBJECT_ID('[gd_esquema].Usuario_rol') is not null)			 drop table [gd_esquema].Usuario_rol
IF (OBJECT_ID('[gd_esquema].Rol_funcionalidad') is not null )	 drop table [gd_esquema].Rol_funcionalidad
IF (OBJECT_ID('[gd_esquema].Funcionalidades') is not null)		 drop table [gd_esquema].Funcionalidades
IF (OBJECT_ID('[gd_esquema].Clientes') is not null)				 drop table [gd_esquema].Clientes
IF (OBJECT_ID('[gd_esquema].Documentos') is not null)			 drop table [gd_esquema].Documentos
IF (OBJECT_ID('[gd_esquema].Pais') is not null)					 drop table [gd_esquema].Pais
IF (OBJECT_ID('tempdb..#temp_maestra') is not null)				 drop table #temp_maestra

--CREAR TABLAS FISICAS
create table [gd_esquema].Login
(
	idlogin		bigint identity(1,1),
	usuario		varchar(50),
	feclogin	datetime,
	resultado	varchar(1)
)

create table [gd_esquema].Login_incorrecto
(
	idfalla		bigint identity(1,1),
	usuario		varchar(50),
	intento		int
)

create table [gd_esquema].Usuario
(
	usuario			varchar(50),
	password		varchar(4),
	fechaUltmodif   datetime,
	pregSecreta		varchar(200),
	respSecreta		varchar(100),
	estado			varchar(1),
	codRol			varchar(10),
	idcliente		bigint
)

create table [gd_esquema].Usuario_rol
(
	usuario			varchar(50),
	codRol			varchar(10)
)

create table [gd_esquema].Roles
(
	codRol  varchar(10),
	nombre  varchar(100),
	estado	varchar(1)
)

create table [gd_esquema].Rol_funcionalidad
(
	codRol		    varchar(10),
	idfuncionalidad int
)

create table [gd_esquema].Funcionalidades
(
	idfuncionalidad int identity(1,1),
	nombre			varchar(200)
)

create table [gd_esquema].Clientes
(
	idcliente		bigint,
	nombre			varchar(255),
	apellido		varchar(255),
	tdoc			numeric(18,0),
	ndoc			numeric(18,0),
	pais			int,
	domicilio		varchar(255),
	piso			numeric(18,0),
	depto			varchar(10),
	localidad		varchar(100),
	nacionalidad	int,
	fecnac			datetime,
	activo			varchar(1)
)

create table [gd_esquema].Documentos
(
	codDoc	numeric(18,0),
	descrip	varchar(255)
)

create table [gd_esquema].Pais
(
	codPais numeric(18,0),
	nombre  varchar(255)
)

CREATE TABLE [gd_esquema].#temp_maestra(
	[Cli_Pais_Codigo] [numeric](18, 0) NULL,
	[Cli_Pais_Desc] [varchar](250) NULL,
	[Cli_Nombre] [varchar](255) NULL,
	[Cli_Apellido] [varchar](255) NULL,
	[Cli_Tipo_Doc_Cod] [numeric](18, 0) NULL,
	[Cli_Nro_Doc] [numeric](18, 0) NULL,
	[Cli_Tipo_Doc_Desc] [varchar](255) NULL,
	[Cli_Dom_Calle] [varchar](255) NULL,
	[Cli_Dom_Nro] [numeric](18, 0) NULL,
	[Cli_Dom_Piso] [numeric](18, 0) NULL,
	[Cli_Dom_Depto] [varchar](10) NULL,
	[Cli_Fecha_Nac] [datetime] NULL,
	[Cli_Mail] [varchar](255) NULL,
	[Cuenta_Numero] [numeric](18, 0) NULL,
	[Cuenta_Fecha_Creacion] [datetime] NULL,
	[Cuenta_Estado] [varchar](255) NULL,
	[Cuenta_Pais_Codigo] [numeric](18, 0) NULL,
	[Cuenta_Pais_Desc] [varchar](250) NULL,
	[Cuenta_Fecha_Cierre] [datetime] NULL,
	[Deposito_Codigo] [numeric](18, 0) NULL,
	[Deposito_Fecha] [datetime] NULL,
	[Deposito_Importe] [numeric](18, 2) NULL,
	[Tarjeta_Numero] [varchar](16) NULL,
	[Tarjeta_Fecha_Emision] [datetime] NULL,
	[Tarjeta_Fecha_Vencimiento] [datetime] NULL,
	[Tarjeta_Codigo_Seg] [varchar](3) NULL,
	[Tarjeta_Emisor_Descripcion] [varchar](255) NULL,
	[Cuenta_Dest_Numero] [numeric](18, 0) NULL,
	[Cuenta_Dest_Fecha_Creacion] [datetime] NULL,
	[Cuenta_Dest_Estado] [varchar](255) NULL,
	[Cuenta_Dest_Pais_Codigo] [numeric](18, 0) NULL,
	[Cuenta_Dest_Pais_Desc] [varchar](250) NULL,
	[Cuenta_Dest_Fecha_Cierre] [datetime] NULL,
	[Transf_Fecha] [datetime] NULL,
	[Trans_Importe] [numeric](18, 2) NULL,
	[Trans_Costo_Trans] [numeric](18, 2) NULL,
	[Retiro_Fecha] [datetime] NULL,
	[Retiro_Codigo] [numeric](18, 0) NULL,
	[Retiro_Importe] [numeric](18, 2) NULL,
	[Cheque_Numero] [numeric](18, 0) NULL,
	[Cheque_Fecha] [datetime] NULL,
	[Cheque_Importe] [numeric](18, 2) NULL,
	[Banco_Cogido] [numeric](18, 0) NULL,
	[Banco_Nombre] [varchar](255) NULL,
	[Banco_Direccion] [varchar](255) NULL,
	[Item_Factura_Descr] [varchar](255) NULL,
	[Item_Factura_Importe] [numeric](18, 2) NULL,
	[Factura_Numero] [numeric](18, 0) NULL,
	[Factura_Fecha] [datetime] NULL
) ON [PRIMARY]

--CARGAR TABLAS
--Vuelco toda la tabla en la memoria, es mas veloz leer de memoria que de disco.
insert into #temp_maestra
(
	Cli_Pais_Codigo,
	Cli_Pais_Desc,
	Cli_Nombre,
	Cli_Apellido,
	Cli_Tipo_Doc_Cod,
	Cli_Nro_Doc,
	Cli_Tipo_Doc_Desc,
	Cli_Dom_Calle,
	Cli_Dom_Nro,
	Cli_Dom_Piso,
	Cli_Dom_Depto,
	Cli_Fecha_Nac,
	Cli_Mail,
	Cuenta_Numero,
	Cuenta_Fecha_Creacion,
	Cuenta_Estado,
	Cuenta_Pais_Codigo,
	Cuenta_Pais_Desc,
	Cuenta_Fecha_Cierre,
	Deposito_Codigo,
	Deposito_Fecha,
	Deposito_Importe,
	Tarjeta_Numero,
	Tarjeta_Fecha_Emision,
	Tarjeta_Fecha_Vencimiento,
	Tarjeta_Codigo_Seg,
	Tarjeta_Emisor_Descripcion,
	Cuenta_Dest_Numero,
	Cuenta_Dest_Fecha_Creacion,
	Cuenta_Dest_Estado,
	Cuenta_Dest_Pais_Codigo,
	Cuenta_Dest_Pais_Desc,
	Cuenta_Dest_Fecha_Cierre,
	Transf_Fecha,
	Trans_Importe,
	Trans_Costo_Trans,
	Retiro_Fecha,
	Retiro_Codigo,
	Retiro_Importe,
	Cheque_Numero,
	Cheque_Fecha,
	Cheque_Importe,
	Banco_Cogido,
	Banco_Nombre,
	Banco_Direccion,
	Item_Factura_Descr,
	Item_Factura_Importe,
	Factura_Numero,
	Factura_Fecha	
)
select	Cli_Pais_Codigo,
		Cli_Pais_Desc,
		Cli_Nombre,
		Cli_Apellido,
		Cli_Tipo_Doc_Cod,
		Cli_Nro_Doc,
		Cli_Tipo_Doc_Desc,
		Cli_Dom_Calle,
		Cli_Dom_Nro,
		Cli_Dom_Piso,
		Cli_Dom_Depto,
		Cli_Fecha_Nac,
		Cli_Mail,
		Cuenta_Numero,
		Cuenta_Fecha_Creacion,
		Cuenta_Estado,
		Cuenta_Pais_Codigo,
		Cuenta_Pais_Desc,
		Cuenta_Fecha_Cierre,
		Deposito_Codigo,
		Deposito_Fecha,
		Deposito_Importe,
		Tarjeta_Numero,
		Tarjeta_Fecha_Emision,
		Tarjeta_Fecha_Vencimiento,
		Tarjeta_Codigo_Seg,
		Tarjeta_Emisor_Descripcion,
		Cuenta_Dest_Numero,
		Cuenta_Dest_Fecha_Creacion,
		Cuenta_Dest_Estado,
		Cuenta_Dest_Pais_Codigo,
		Cuenta_Dest_Pais_Desc,
		Cuenta_Dest_Fecha_Cierre,
		Transf_Fecha,
		Trans_Importe,
		Trans_Costo_Trans,
		Retiro_Fecha,
		Retiro_Codigo,
		Retiro_Importe,
		Cheque_Numero,
		Cheque_Fecha,
		Cheque_Importe,
		Banco_Cogido,
		Banco_Nombre,
		Banco_Direccion,
		Item_Factura_Descr,
		Item_Factura_Importe,
		Factura_Numero,
		Factura_Fecha
from gd_esquema.Maestra

--Cargar tabla DOCUMENTOS.
insert into [gd_esquema].Documentos(codDoc,descrip)
select distinct
	   Cli_Tipo_Doc_Cod,
	   Cli_tipo_Doc_desc
from   #temp_maestra

--Cargar tabla PAIS.
insert into [gd_esquema].Pais(codPais,nombre)
select distinct
	   Cli_Pais_Codigo,
	   Cli_Pais_Desc
from   #temp_maestra

--Cargar tabla de ROLES
insert into [gd_esquema].Roles(codRol,nombre,estado) values('Admin','Administrador','s')
insert into [gd_esquema].Roles(codRol,nombre,estado) values('Cli','Cliente','s')

--Cargar tabla de FUNCIONALIDADES.
insert into [gd_esquema].Funcionalidades(nombre) values('Login');
insert into [gd_esquema].Funcionalidades(nombre) values('Alta');
insert into [gd_esquema].Funcionalidades(nombre) values('Consulta');

--Cargar tabla de ROLES - FUNCIONES
insert into [gd_esquema].Rol_funcionalidad(codRol,idfuncionalidad) values('Cli',1);
insert into [gd_esquema].Rol_funcionalidad(codRol,idfuncionalidad) values('Cli',2);
insert into [gd_esquema].Rol_funcionalidad(codRol,idfuncionalidad) values('Cli',3);

--Cargar tabla de CLIENTES
insert into [gd_esquema].Clientes
(
	idcliente,
	nombre,
	apellido,
	tdoc,
	ndoc,
	pais,
	domicilio,
	piso,
	depto,
	localidad,
	nacionalidad,
	fecnac,
	activo
)
select distinct
	   (convert(varchar,a.Cli_Tipo_Doc_Cod)+convert(varchar,a.Cli_Nro_Doc)+convert(varchar,a.Cli_Pais_codigo)),
	   a.Cli_Nombre,
	   a.Cli_Apellido,
	   a.Cli_Tipo_Doc_Cod,
	   a.Cli_Nro_Doc,
	   a.Cli_Pais_Codigo,
	   a.Cli_Dom_Calle,
	   a.Cli_Dom_Piso,
	   a.Cli_Dom_Depto,
	   '' as localidad,
	   a.Cli_Pais_Codigo,
	   a.Cli_Fecha_Nac,
	   'A'
from   [gd_esquema].#temp_maestra as a

--Crear tabla de Usuarios
--	Usuario  : (1ra letra Nombre)+(1ra letra apellido)+Ndoc
--	Password : primeros 4 numeros del numero de documento.
insert into [gd_esquema].Usuario
(
	usuario,
	password,
	fechaUltmodif,
	pregSecreta,
	respSecreta,
	estado,
	codRol,
	idcliente
)
select	substring((upper(SUBSTRING(nombre,0,2)+SUBSTRING(apellido,0,2))+''+convert(varchar,ndoc)),0,50),
		substring(CONVERT(varchar,ndoc),0,5),
		null,
		'',
		'',
		'A',
		'Cli',
		idcliente
from [gd_esquema].Clientes

--Logeo fin
select 'Fin',GETDATE()
