-- criando banco de dados

CREATE DATABASE DBGAMES;

-- USANDO BANCO DE DADOS

USE DBGAMES;

-- CRIANDO AS TABELAS DO BD

CREATE TABLE tbPedido(
codPedido int primary key auto_increment,
tipoJogo varchar(50),
valorJogo varchar(50),
valorOpcionais varchar(50),
valorPagar varchar(50));

select * from tbPedido;

