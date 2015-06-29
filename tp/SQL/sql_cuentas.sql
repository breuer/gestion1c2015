-- Inserta una cuenta nueva y devuelve el número de cuenta creado
create procedure NEW_SOLUTION.SP_CUENTA_ADD (@clienteId int,@paisApertura varchar,@moneda varchar, @categoria varchar, @estado varchar)
as
begin
	declare @maxNumCta int,
			@paisAperturaId int,
			@monedaId int,
			@categoriaId int,
			@estadoId int;
		
	declare @numero int;
	
	select @maxNumCta = MAX(cta_num) from NEW_SOLUTION.Cuentas;
	select @paisAperturaId = pais_cod from NEW_SOLUTION.Paises where pais_descrip = @paisApertura;
	select @monedaId = moneda_id from NEW_SOLUTION.Monedas where moneda_descrip = @moneda;
	select @categoriaId = @categoriaId from NEW_SOLUTION.Cuentas_categ where ctacateg_descrip = @categoria;
	select @estadoId = cta_estado_id from NEW_SOLUTION.Cuentas_Estado where cta_estado_descrip = 'Cuenta Pendiente de Activacion';
	
	set @numero = @maxNumCta + 1;

	insert into NEW_SOLUTION.Cuentas(cta_num,cta_cli_id,cta_pais_apertura,cta_moneda,cta_tipo,cta_fecha_apertura,cta_estado)
	values (@numero,@clienteId,@paisAperturaId,@monedaId,@categoriaId,GETDATE(),@estadoId)
	
	return @numero;
end

-- Obtiene todas las cuenta de acuerdo a los filtros
--drop procedure NEW_SOLUTION.sp_cuenta_get

create procedure NEW_SOLUTION.sp_cuenta_get
	(@numero int = null, 
	@clienteId int = null, 
	@paisApertura varchar(255) = null,
	@moneda varchar(255) = null,
	@categoria varchar(255) = null,
	@estado varchar(255) = null)
as
begin
	declare @paisAperturaId int,
			@monedaId int,
			@categoriaId int,
			@estadoId int;
			
	select @paisAperturaId = pais_cod from NEW_SOLUTION.Paises where pais_descrip = @paisApertura;
	select @monedaId = moneda_id from NEW_SOLUTION.Monedas where moneda_descrip = @moneda;
	select @categoriaId = @categoriaId from NEW_SOLUTION.Cuentas_categ where ctacateg_descrip = @categoria;
	select @estadoId = cta_estado_id from NEW_SOLUTION.Cuentas_Estado where cta_estado_descrip = @estado;


	declare @query nvarchar(500);	
		set @query = ''
		set @query = @query +	'select c.cta_num,c.cta_cli_id,c.cta_pais_apertura,c.cta_moneda,c.cta_tipo,c.cta_estado from NEW_SOLUTION.Cuentas c '
		set @query = @query +	'where '
	if(@numero is not null)
		set @query = @query +		'c.cta_num = ' + cast(@numero as varchar)+ ' and '		
	if(@clienteId is not null)
		set @query = @query +		'c.cta_cli_id = ' +@clienteId + ' and '
	if(@paisApertura is not null)
		set @query = @query +		'c.cta_pais_apertura like ''%' +@paisAperturaId + '%'' and '
	if(@moneda is not null)
		set @query = @query +		'c.cta_moneda like ''%' + @monedaId + '%'' and '
	if(@categoria is not null)
		set @query = @query +		'c.cta_tipo = ''' + @categoriaId + ''' and '
	if(@estado is not null)
		set @query = @query +		'c.cta_estado like ''%'+ cast(@estadoId as varchar) +'%'' and '
	set @query = @query +			'1=1'
	print @query
	exec (@query)
end

-- Actualiza la categoría de la cuenta
--drop procedure NEW_SOLUTION.SP_CUENTA_UPD
create procedure NEW_SOLUTION.SP_CUENTA_UPD (@numero int,@clienteId int,@paisApertura varchar,@moneda varchar,@cateAnt varchar,@cateNva varchar)
as
begin
	declare @paisAperturaId int,
			@monedaId int,
			@cateAntId int,
			@estado varchar;
			
	select @paisAperturaID = pais_cod from NEW_SOLUTION.Paises where pais_descrip = @paisApertura;
	select @monedaId = moneda_id from NEW_SOLUTION.Monedas where moneda_descrip = @moneda;
	select @cateAntId = ctacateg_id from NEW_SOLUTION.Cuentas_categ where ctacateg_descrip = @cateAnt;
	
	select @estado = cta_estado_descrip
	from NEW_SOLUTION.Cuentas 
	join NEW_SOLUTION.cuentas_estado on cta_estado = cta_estado_id
	where cta_num = @numero and cta_cli_id = @clienteId and cta_pais_apertura = @paisAperturaId and cta_moneda = @monedaId and cta_tipo = @cateAntId;
	
	if (@estado <> 'Cuenta Cerrada')
	begin
		update NEW_SOLUTION.Cuentas
		set cta_tipo = ctacateg_id
		from NEW_SOLUTION.Cuentas_categ
		where ctacateg_descrip = @cateNva
		and cta_num = @numero
		and cta_pais_apertura = @paisAperturaId
		and cta_moneda = @monedaId
		and cta_tipo = @cateAntId
		
		return 1
	end
	else
		return -1
end

-- Eliminar cuenta: Modificar estado a Cerrada si no tiene costos pendientes de pago
--drop procedure NEW_SOLUTION.SP_CUENTA_DEL
create procedure NEW_SOLUTION.SP_CUENTA_DEL (@numero int,@clienteId int,@paisApertura varchar,@moneda varchar,@categoria varchar)
as
begin
	declare @paisAperturaId int,
			@monedaId int,
			@cateAntId int;
			
	select @paisAperturaID = pais_cod from NEW_SOLUTION.Paises where pais_descrip = @paisApertura;
	select @monedaId = moneda_id from NEW_SOLUTION.Monedas where moneda_descrip = @moneda;
	select @cateAntId = ctacateg_id from NEW_SOLUTION.Cuentas_categ where ctacateg_descrip = @categoria;

	update NEW_SOLUTION.Cuentas
	set cta_estado = cta_estado_id
	from NEW_SOLUTION.Cuentas_estado
	where cta_estado_descrip = 'Cuenta Cerrada'
	and cta_num = @numero and cta_cli_id = @clienteId and cta_pais_apertura = @paisAperturaId and cta_moneda = @monedaId and cta_tipo = @cateAntId;
	
	return 1;

end


select * from NEW_SOLUTION.Cuentas
