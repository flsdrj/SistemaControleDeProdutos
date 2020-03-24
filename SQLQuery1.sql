Create table Estoque(
IdEstoque	integer			identity(1,1),
Nome		nvarchar(150)	not null,
Descricao	nvarchar(MAX)	not null,
primary key(IdEstoque))

Create table Produto(
IdProduto	integer			identity(1,1),
Nome		nvarchar(150)	not null,
Preco		decimal(18,2)	not null,
Quantidade	integer			not null,
IdEstoque	integer			not null,
primary key(IdProduto),
foreign Key(IdEstoque)
	references Estoque(IdEstoque))