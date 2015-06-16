--Dice si una cuenta esta activa.
create function NEW_SOLUTION.cuenta_activa(@ctaNum numeric(18,0),@idpais int)
returns int
as
begin
	if exists(select * from NEW_SOLUTION.Cuentas where cta_num=@ctaNum and cta_estado=1 and cta_pais_apertura = @idpais)
		return 1
	else 
		return 0
		
	return null
end

--Retirar dinero
create procedure NEW_SOLUTION.cuenta_retirar(@ctaNum numeric(18,0),@idpais int,@importe numeric(18,2),@codBco numeric(18,0),@cliId bigint,@fechaSys datetime)
as
	--Revisar que la cuenta se encuentra activa.
	if (NEW_SOLUTION.cuenta_activa(@ctaNum,@idpais)=1)
	begin
		--Obtengo el importe
		declare      @saldoCta numeric(18,2)		
		select top 1 @saldoCta = cta_saldo from NEW_SOLUTION.Cuentas where cta_num=@ctaNum and cta_pais_apertura = @idpais
		
		--Si tengo saldo.
		if (@saldoCta>0)
		begin
			--Si el dinero alcanza.
			if (@saldoCta-@importe>0)
			begin
				--Realizo la extraccion.
				update NEW_SOLUTION.Cuentas set cta_saldo = cta_saldo-@importe
				where cta_num			= @ctaNum
				and   cta_pais_apertura = @idpais
				
				--Obtengo el prox. num de cheque.
				declare @chqNum numeric(18,0)
				select  @chqNum = MAX(chq_num)+1 from NEW_SOLUTION.Cheques

				--Registro el cheque
				insert into NEW_SOLUTION.Cheques(chq_num,chq_importe,chq_cli_id,chq_cod_bco,chq_fecha)
				values(@chqNum,@importe,@cliId,@codBco,@fechaSys)
				
				--Registro la extraccion.
				insert into NEW_SOLUTION.Retiros(ret_fecha,ret_cli_id,ret_num_cheque,ret_cta_num,ret_cta_num_pais)
				values(@fechaSys,@cliId,@chqNum,@ctaNum,@idpais)
				
				select 1
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
