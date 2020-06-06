create database FIEB

use FIEB

create table Pessoa(
Id int identity(1,1) primary key,
Nome varchar(255),
Email varchar(255),
DataCriacao datetime default (getdate()) not null,
DataAlteracao datetime
)


create table Evento(
Id int identity(1,1) primary key,
Nome varchar(255),
Descricao varchar(1000),
Foto varchar(500),
DataCriacao datetime default (getdate()) not null,
DataAlteracao datetime
)

