use HOSPITAL

create procedure CONSULTAR_CITA
@cod_cita varchar (10)
as 
select * from cita where cod_cita = @cod_cita