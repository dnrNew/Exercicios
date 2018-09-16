create database bd_Vendas;

use bd_Vendas;

create table cliente(
id int unsigned auto_increment primary key,
nome varchar(60) not null,
endereco varchar(45) not null,
cidade varchar(45) not null,
estado char(2) not null,
telefone int8(11) not null
); 

create table empresa(
id int unsigned auto_increment primary key,
nome varchar(60) not null,
endereco varchar(45) not null,
cidade varchar(45) not null,
email varchar(60) not null,
telefone char(11) not null,
site varchar(60) not null
);

create table produto(
id int unsigned auto_increment primary key,
descricao varchar(60) not null,
quantidade int not null,
valor double(9,2) not null,
empresa_id int not null,
foreign key(empresa_id) references empresa(id)
);

select * from produto;

create table funcionario(
cpf char(14) primary key,
nome varchar(60) not null,
endereco varchar(45) not null,
cidade varchar(45) not null,
estado char(2) not null,
telefone char(11) not null,
dt_Nascimento date not null,
email varchar(60) not null,
usuario varchar(15) not null,
senha char(6) not null
);


select * from funcionario;

create table vendas(
id int unsigned auto_increment primary key,
descricao varchar(60) not null,
data_venda date,
total double(9,2) not null,
observacao varchar(80),
cliente_id int not null,
funcionario_cpf char(14) not null,
foreign key(cliente_id) references cliente(id),
foreign key(funcionario_cpf) references funcionario(cpf)
);

create table itens_vendas(
id int unsigned auto_increment primary key,
valor_unit double(9,2) not null,
quantidade int not null,
total double(9,2) not null,
vendas_id int not null,
produto_id char(14) not null,
foreign key(vendas_id) references vendas(id),
foreign key(produto_id) references produto(cpf)
);

insert into itens_vendas values(null, '4','1','4','7','3');

commit;

