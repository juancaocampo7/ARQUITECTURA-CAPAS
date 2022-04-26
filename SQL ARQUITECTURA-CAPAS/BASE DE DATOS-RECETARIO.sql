create database RECETARIO 
use RECETARIO 

create table RECETAS_OBTENIDAS (
Idreceta_libro varchar (20),
nombre_libro varchar (20),
Idreceta_prensa varchar (20),
nombre_prensa varchar (20),
Idreceta_familiar varchar (20),
nombre_familiar varchar (20),
)

create table UBICACION_FISICA (
Id_estanteria varchar (10),
lugar_estanteria varchar (20),
Id_biblioteca varchar (20),
lugar_biblioteca varchar (20),
)

create table INGREDIENTES (
Id_ingredientes varchar (20),
nombre_ingredientes nvarchar (20),
)

create table UTENSILLOS (
Id_utensillos varchar (20),
tipo_utensillos varchar (20),
nombre_utensillos varchar (20),
)

create table TIPO_PLATO (
Id_plato nvarchar (20),
nombre_plato nvarchar (20),
ingrediente_ppal varchar (20),
primer_plato nvarchar (20),
segundo_plato nvarchar (20),
plato_postre nvarchar (20),
precio_plato int,
constraint pk_cc primary key (Id_plato))

create table CANTIDADES (
cant_cucharada nvarchar (20),
cant_pizca nvarchar (20),
cant_gramos nvarchar (20),
Id_plato1 nvarchar (20),
nombre_plato1 nvarchar(20),
constraint fk_pl foreign key (Id_plato1) references TIPO_PLATO (Id_plato),
constraint fk_np foreign key (nombre_plato1) references TIPO_PLATO (nombre_plato)
)


create table MENUS (
Id_menu varchar (20),
menu_verano nvarchar(20),
menu_festivo nvarchar (20),
menu_ligero nvarchar (20),
)



