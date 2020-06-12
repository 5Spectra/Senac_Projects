-- drop table Aluno

--create table Aluno 
--(
--	matricula int,
--	RA char(8) primary key ,
--	nome varchar(150),
--	dataNacimento Varchar(10),
--	endereco varchar(200),
--	serie varchar(15),
--	responsavel varchar(150),
--	CEP char(7),
--	telefone char(13),
--	sexo char(1),		
--);

--insert Aluno (matricula,RA,nome,dataNacimento,endereco,serie,responsavel,CEP,telefone,sexo)
--values ( 1,'12345678','Matheus Atunes oliveira','1999/11/14','Rua Cinco, 20, Vila aleluia São caitano',
--	   'Primeiro Ano','raimundo Atunes','1234567','(19)36268024','M')
	   
insert into Aluno (matricula,RA,nome,dataNacimento,endereco,serie,responsavel,CEP,telefone,sexo)
values ( 6,'04567890','Matheus Atunes oliveira','1999/11/14','Rua Cinco, 20, Vila aleluia São caitano',
	   'Primeiro Ano','raimundo Atunes','1234567','(19)36268024','M')
	   	   
Update Aluno 
	set dataNacimento = '14/11/1999',
		nome = 'Guilherme numes fernandes'
	from Aluno
where matricula = 10
	
delete Aluno
  from Aluno 
where matricula = 6

select *
into #TAbAluno
  from Aluno
  order by Matricula
  
  
  drop table aluno
  
  
create table Aluno 
(
	matricula int,
	RA char(8) primary key ,
	nome varchar(150),
	dataNacimento Varchar(10),
	endereco varchar(200),
	serie varchar(15),
	responsavel varchar(150),
	CEP char(7),
	telefone char(13),
	sexo char(1),		
);
  
 insert into Aluno (matricula,RA,nome,dataNacimento,endereco,serie,responsavel,CEP,telefone,sexo)
 select *
   from #tabAluno

select * 
from Aluno  
  
  
  
  
  
  
