create table nome
alter table nome 
drop table nome
varchar(X)
char(X)
int
date
time
datetime
decimal(X,X)

insert into values ( 1,'Z','Z','Z','Z')
select * from nome
update nome set nome-campo = novo-valor from nome where isso = isto
delete nome from nome where isso = isto
delete nome

Select
nome-valor as "nome que voce quer vizualizar"
from nome

Select *
 from nome x
 where: x.nome-valor >=5
	and	x.nome-valor <10
	
Select *
 from nome x
 where x like "%a%" %a termina com A |a% começa com A | %a% tem A 
	
IDENTITY(1,2) 1 numero inicial 2 numero da soma

select a.NF,a.QTDE,b.Nome,c.Nome,c.Valor as ValorUnidade,(c.Valor * a.QTDE) as ValorCompra
from NF a
  join cliente b on a.ID = b.ID
  join produto c on a.COD = c.COD
