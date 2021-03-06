create database PizzaBd;

create table Pizza
(id int identity(1,1),
nome varchar(50),
descricao varchar(250),
preco float,
primary key(id));

create table Bebida
(id int identity(1,1),
nome varchar(50),
tamanho varchar(50),
preco float,
primary key(id));

create table Cliente
(	id int IDENTITY(1,1),
	nome varchar(50),
	telefone varchar(50),
	rua varchar(50),
	numero int,
	bairro varchar(50),
	complemento varchar(50),
	cidade varchar(50),
	estado varchar(50),
	primary key(id));

	create table Pedido
	(id int identity(1,1),
	descricao varchar(300),
	total float,
	data varchar(50),
	cli_nome varchar(50),
	cli_tel varchar(50),
	status varchar(50),
	primary key(id));

	create table Usuario
	(id int identity(1,1),
	username varchar(50),
	pwd varchar(50),
	tipo varchar(50),
	primary key(id));
