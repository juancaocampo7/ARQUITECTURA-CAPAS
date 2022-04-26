create database HOSPITAL
use HOSPITAL
create table cita(
cod_cita varchar (10),
fecha date,
hora time(7),
Id_paciente varchar (10),
Id_medico varchar (10),
valor int, 
diagnostico nvarchar (MAX),
Nom_acompañante nvarchar (50),
activo bit
)

create table medico (
Id_medico nvarchar (10),
nom_medico nvarchar (50),
especialidad nvarchar (30),
tel_medico nvarchar (10),
activo bit 
)

create table paciente (
Id_paciente nvarchar (10),
Tip_doc nvarchar (20),
nom_paciente nvarchar (50),
dir_paciente nvarchar (50),
tel_paciente nvarchar (10),
cel_paciente nvarchar (10),
activo bit
)