--Dice si ambas cuentas tiene el mismo cliente.
alter function NEW_SOLUTION.cuenta_mismo_cliente(@cta1 numeric(18,0),@pais1 int,@cta2 numeric(18,0),@pais2 int)
returns int
as
begin
	declare @cli_1 bigint
	declare @cli_2 bigint
		    
	set @cli_1=0
	set @cli_2=0
	
	select @cli_1 = cta_cli_id from NEW_SOLUTION.Cuentas where cta_num=@cta1 and cta_pais_apertura = @pais1
	select @cli_2 = cta_cli_id from NEW_SOLUTION.Cuentas where cta_num=@cta2 and cta_pais_apertura = @pais2
	
	if (@cli_1=@cli_2)
		return 1
	else
		return 0
		
	return -1
end

--Hacer transferencia entre cuentas.
alter procedure NEW_SOLUTION.cuenta_hacer_transferencia(@ctaOrigen numeric(18,0),@paisOrigen int,@ctaDestino numeric(18,0),@paisDestino int,@importe numeric(18,2),@fechaSys datetime,@cliId bigint)
as
	--Revisar que la cuenta destino este activa.
	declare @activDestino int
	set		@activDestino = null
	
	--Cargo el estado de la cuenta destino.
	select top 1 @activDestino = a.cta_estado from NEW_SOLUTION.Cuentas as a where a.cta_num=@ctaDestino and cta_pais_apertura = @paisDestino
	
	--Si es nulo o el estado no es 1 que es activo, devuelvo -1, cta invalida.
	if (@activDestino is not null)or(@activDestino <>1)
	begin	
		--Si el importe a transferir es mayor que cero.
		if (@importe>0)	
		begin
			--Revisar si el dinero de la cuenta origen alcanza para hacer la transferencia.
			declare @montoOrigen numeric(18,2)
			select  top 1 @montoOrigen = cta_saldo from NEW_SOLUTION.Cuentas where cta_num = @ctaOrigen and cta_pais_apertura = @paisOrigen
			
			if (@montoOrigen-@importe>=0)
			begin
					--Si el cliente es el mismo.
					if (NEW_SOLUTION.cuenta_mismo_cliente(@ctaOrigen,@paisOrigen,@ctaDestino,@paisDestino)=1)
					begin
						--select 'no hay costo de transferencia'

						--Grabar transferencia.
						insert into NEW_SOLUTION.Transferencias(transf_cta_origen,transf_cta_pais_origen,transf_cta_destino,transf_cta_pais_destino,transf_importe,transf_fecha,transf_cli_id,transf_costo)
						values(@ctaOrigen,@paisOrigen,@ctaDestino,@paisDestino,@importe,@fechaSys,@cliId,0)
											
						select 1						
					end
					else
					begin
						--select 'se va cobrar impuesto'					
						
						--Grabar transferencia.
						insert into NEW_SOLUTION.Transferencias(transf_cta_origen,transf_cta_pais_origen,transf_cta_destino,transf_cta_pais_destino,transf_importe,transf_fecha,transf_cli_id,transf_costo)
						values
						(
							@ctaOrigen,
							@paisOrigen,
							@ctaDestino,							
							@paisDestino,
							@importe,
							@fechaSys,
							@cliId,
							(select   top 1
									  isnull(b.ctacateg_costo,0)
							from	  NEW_SOLUTION.Cuentas       as a
							left join NEW_SOLUTION.Cuentas_categ as b on b.ctacateg_id = a.cta_tipo
							where	  a.cta_num=@ctaOrigen)
						)		
						
						select 1
					end				
			end			
			else
				--No hay dinero suficiente para hacer la transferencia.
				select -3
		end
		else	
			--Deber ser un importe mayor que cero.	
			select -2
	end
	else
	begin
		--Cuenta invalida
		select -1
	end
	
--Un trigger que se ejecuta cada vez que se realiza una transferencia, se usa para registrar los costos.
alter TRIGGER NEW_SOLUTION.registrar_costo_transferencia
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