-------------------------------------------------- Creates Tables --------------------------------------------------

CREATE TABLE usuario(
	id_usuario	SERIAL PRIMARY KEY,
	usuario		VARCHAR,
	senha		VARCHAR,
	nivel		INT
);
CREATE TABLE funcionario(
	id_func		SERIAL PRIMARY KEY,
	nome		VARCHAR,
	cargo		VARCHAR,
	endereco	VARCHAR,
	telefone	VARCHAR,
	data_nasc	VARCHAR
);
CREATE TABLE marca(
	id_marca	SERIAL PRIMARY KEY,
	nome		VARCHAR,
	cnpj		VARCHAR,
	telefone	VARCHAR,
	endereco	VARCHAR
);
CREATE TABLE produto(
	id_prod		PRIMARY KEY,
	descricao	VARCHAR,
	peso		NUMERIC(10,2),
	quantidade	INT,
	val_custo	NUMERIC(10,2),
	val_venda	NUMERIC(10,2),
	id_m		int references marca(id_marca)	
);

-------------------------------------------------- Inserts Funcionário --------------------------------------------------

INSERT INTO funcionario (nome, cargo, endereco, telefone, data_nasc) VALUES ('Pedro Alcantara','Arquiteto','Rua marajás','777777797','25/04/2001');
INSERT INTO funcionario (nome, cargo, endereco, telefone, data_nasc) VALUES ('Maikon Takeshi Tsujiguchi','Gerente','Rua Brasil','888888888','28/06/1991');
INSERT INTO funcionario (nome, cargo, endereco, telefone, data_nasc) VALUES ('Roberto Dias','Desenvolvedor Senior','Rua Ipanema','999999999','05/11/1998');
INSERT INTO funcionario (nome, cargo, endereco, telefone, data_nasc) VALUES ('Diego Souza Mendes','Analista de Teste','Rua Nami Jaffet Bourbon','999999999','04/01/1997');
INSERT INTO funcionario (nome, cargo, endereco, telefone, data_nasc) VALUES ('Leandro de Almeida Rodrigues','Desenvolvedor Junior','Rua Joao Goulart','555555555','30/02/1996');
INSERT INTO funcionario (nome, cargo, endereco, telefone, data_nasc) VALUES ('Barbara Silveira','Desenvolvedor Pleno','Rua Cardoso Siqueira','544443215','22/03/1985');
INSERT INTO funcionario (nome, cargo, endereco, telefone, data_nasc) VALUES ('Juliana Mello de Souza','Engenheiro de Software','Rua Joao XXIII','654987351','16/05/1973');	

-------------------------------------------------- Inserts Marca --------------------------------------------------

INSERT INTO marca (nome, cnpj, endereco, telefone) VALUES ('Marilon','12345678911234','Rua Chocolate','1143568795');
INSERT INTO marca (nome, cnpj, endereco, telefone) VALUES ('Nestlar','98765432115684','Rua Amendoim','1169873215');
INSERT INTO marca (nome, cnpj, endereco, telefone) VALUES ('Tostane','12345689898741','Rua Abacate','1132115954');
INSERT INTO marca (nome, cnpj, endereco, telefone) VALUES ('Quiero','12568547985641','Rua Laranja','1175386945');
INSERT INTO marca (nome, cnpj, endereco, telefone) VALUES ('Lecta','12356874569852','Rua Limão','1115926354');
INSERT INTO marca (nome, cnpj, endereco, telefone) VALUES ('Ponca','32198765474159','Rua Melância','1168357241');
INSERT INTO marca (nome, cnpj, endereco, telefone) VALUES ('Barillan','65498714725896','Rua Abacaxi','1115264859');

-------------------------------------------------- Selects --------------------------------------------------

SELECT * FROM funcionario;
SELECT * FROM Funcionario_cargo;
SELECT * FROM funcionario WHERE nome LIKE '%e%' OR cargo LIKE '%e%' ORDER BY nome ASC;
SELECT * FROM marca;

-------------------------------------------------- Drops --------------------------------------------------

--DROP TABLE marca CASCADE;
--DROP TABLE funcionario CASCADE;
--DROP VIEW Funcionario_cargo;

-------------------------------------------------- Views --------------------------------------------------

CREATE VIEW Funcionario_cargo AS
SELECT nome, cargo FROM funcionario
ORDER BY nome ASC
