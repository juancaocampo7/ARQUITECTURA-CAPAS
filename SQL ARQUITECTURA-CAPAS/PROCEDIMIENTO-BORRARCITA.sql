use HOSPITAL

create procedure BORRAR_CITA
@cod_cita varchar (10),
@id_paciente nvarchar (10)
as
delete from cita where cod_cita = @cod_cita and Id_paciente = @id_paciente