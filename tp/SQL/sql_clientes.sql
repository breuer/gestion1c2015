-- CORREGIR: DEVOLVER SOLO LOS CAMPOS DE LOS FILTROS SI SOLO BUSCO POR ID
-- VER TIPO NVARCHAR
-- obtiene clientes por campos dinamicos
create procedure NEW_SOLUTION.sp_cliente_get
	@nombre varchar(255) = null, 
	@apellido varchar(255) = null, 
	@mail varchar(255) = null,
	@identificacion int = null,
	@tipo_identificacion varchar(255) = null,
	@cliente_id int = null
as
begin
	declare @query nvarchar(500);	
		set @query = ''
		set @query = @query +	'select * from NEW_SOLUTION.Clientes c '
		set @query = @query +	'where '
	if(@cliente_id is not null)
		set @query = @query +		'c.cli_id = ' + cast(@cliente_id as varchar)+ ' and '		
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