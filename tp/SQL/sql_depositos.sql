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

--Dice si la tarjeta es del cliente.
create function NEW_SOLUTION.tarjeta_cliente_valida(@tarjId bigint,@cliId bigint)
returns int
as
begin
	if exists(select a.* from  NEW_SOLUTION.Tarjetas as a where a.tarj_numero = @tarjId and a.tarj_cli_id = @cliId and a.tarj_estado=1)
		return 1
	else 
		return 0
		
	return -1
end

--Realizar deposito en una cuenta.
create procedure NEW_SOLUTION.cuenta_depositar(@ctaNum numeric(18,0),@idpais int,@importe numeric(18,2),@moneda int,@cliID bigint,@tarjId bigint,@fechaSys datetime)
as
	--Si el importe es aceptado
	if (@importe>1)
	begin
		
			--Dice si la cta pertenece al cliente
			if (NEW_SOLUTION.cuenta_pertenece_cliente(@ctaNum,@idpais,@cliID)=1)
			begin
				--Revisar si la tarjeta es valida
				if (NEW_SOLUTION.tarjeta_cliente_valida(@tarjId,@cliID)=1)
				begin
					--Registro el deposito.
					insert into NEW_SOLUTION.Depositos(depo_cuenta,depo_cuenta_pais,depo_moneda,depo_tarj_id,depo_fecha,depo_importe)
					values(@ctaNum,@idpais,@moneda,@tarjId,@fechaSys,@importe)
					
					--Actualizo el valor de la cuenta
					update NEW_SOLUTION.Cuentas set cta_saldo=cta_saldo+@importe
					where cta_cli_id=@cliID
					and   cta_num   =@ctaNum
					and   cta_pais_apertura =@idpais
					
					--Muestro el ok
					select 1
				end
				else
					select -3
			end
			else
				--La cuenta no pertenece al cliente.
				select -2
	end
	else
		--Valor no permitido
		select -1
