create table cliente
(
	ID int IDENTITY(1,1) primary key,
	Nome varchar(200),
	CPF int
);

create table produto
(
	COD int IDENTITY(1,1) primary key,
	Nome varchar(200),
	Valor decimal(6,2),
	QTDE int,
);
create table NF
(
	NF int IDENTITY(1,1) primary key,
	ID int,
	COD int,
	QTDE int
);

insert into cliente(Nome,CPF)
values ('Joãozinho La', 33445556)

insert into produto(Nome,Valor,QTDE)
values	('Berrinjela',2,5),
		('Abacaxi',1,10),
		('Melancia',5,2),
		('Uva',5,15)

select * from cliente
select * from produto

insert into NF(ID,COD,QTDE)
values (1,2,3),(1,1,1),(1,4,4),
	   (2,2,5),(2,1,3),(2,4,1)
	   
	   
select a.NF,a.QTDE,b.Nome,c.Nome,c.Valor as ValorUnidade,(c.Valor * a.QTDE) as ValorCompra
from NF a
  join cliente b on a.ID = b.ID
  join produto c on a.COD = c.COD

	   
	   
	   
		
