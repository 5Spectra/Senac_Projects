create database db_PER

use db_PER

create table Jogador(
	id int identity primary key,
	nome varchar(100) not null	)
	
	
select * from Jogador where nome = ''

insert into Jogador (nome) values ('')

delete Jogador
  from Jogador 
where nome = 'KK'

update Jogador
	set id = 1
	from Jogador
Where nome = 'KK'