Create Database AgendaDb
go
use AgendaDb
go
Create Table Personas(
PersonaId int identity primary key,
Nombres varchar(100),
Direccion varchar(200),
Sexo int,
EstadoCivil int
)
go

Create Table PersonasTelefonos(
Id int identity,
PersonaId int References Personas(PersonaId),
Telefono varchar(12))
