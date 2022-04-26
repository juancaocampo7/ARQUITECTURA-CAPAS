use HOSPITAL

create procedure ACTUALIZAR_CITA
@cod_cita varchar (10),
@fecha date,
@hora time,
@id_paciente nvarchar (10),
@id_medico nvarchar (10),
@valor int, 
@diagnostico nvarchar (max),
@nom_acompanante nvarchar (50),
@activo bit
as 
insert into cita(cod_cita,fecha,hora,Id_paciente,Id_medico,valor,diagnostico,Nom_acompañante,activo) values
(@cod_cita,@fecha,@hora,@id_paciente,@id_medico,@valor,@diagnostico,@nom_acompanante,@activo) 