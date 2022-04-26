use HOSPITAL

create procedure INSERTAR_CITA 
@cod_cita varchar (10),
@fecha date,
@hora time(7),
@Id_paciente varchar (10),
@Id_medico varchar (10),
@valor int, 
@diagnostico nvarchar (MAX),
@nom_acompanante nvarchar (50),
@activo bit
as 
insert into cita (cod_cita,fecha,hora,Id_paciente,Id_medico,valor,diagnostico,Nom_acompañante,activo) values
(@cod_cita,@fecha,@hora,@id_paciente,@id_medico,@valor,@diagnostico,@nom_acompanante,@activo)