create database glovo2
go

USE glovo2
GO


CREATE TABLE Cliente(
	IDCliente int IDENTITY PRIMARY KEY NOT NULL,
	NombreCliente varchar(50) NULL,
	Correo varchar(50) NULL,
	Contraseña varchar(50) NULL,
	Direccion varchar(50) NULL,
	Telefono int NULL
)
GO


CREATE TABLE Categoria(
IDcategoria int IDENTITY PRIMARY KEY  NOT NULL,
TipoCategoria varchar(50) NULL,
)
GO

CREATE TABLE SubCategoria(
IDsubCategoria int IDENTITY PRIMARY KEY NOT NULL,
NombreSubCategoria varchar(50) NULL,
IDcategoria int NULL,
Foreign key(IDcategoria) references Categoria(IDcategoria)
)
GO


CREATE TABLE Producto(
IDproducto int IDENTITY  PRIMARY KEY NOT NULL,
NombreProducto varchar(50) NULL,
Stock int NULL,
Precio numeric(9, 2) NULL,
IDCategoria int NULL,
Foreign key(IDcategoria) references Categoria(IDcategoria)
)
GO


CREATE TABLE Establecimiento(
IDestablecimiento int IDENTITY PRIMARY KEY  NOT NULL,
NombreEstablecimiento varchar(50) NULL,
email varchar(50) NULL,
telefono char(9) NULL,
IDcategoria int NULL,
ciudad varchar(50) NULL
)
GO



INSERT Categoria values ('Restaurante')
INSERT Categoria values ('Farmacia')
INSERT Categoria values ('Tienda')
INSERT Categoria values ('Supermercado')
INSERT Categoria values ('Otros')
GO

INSERT Establecimiento values ('Patty Wong','pattywong@gmail.com','98564587',1,'Peru')
INSERT Establecimiento values ('Francis Morales','fmorales@hotmail.com','95634578',2,'Peru')
INSERT Establecimiento values ('Josue Gonzales','gonzalesj@gmail.com','94588957',3,'Peru')
INSERT Establecimiento values ('Mariela Lujan','marielalujan@hotmail.com','94578615',4,'Peru')
GO

INSERT Producto values ('Arroz Chaufa',30, 30.00,1)
INSERT Producto values ('Pollo a la brsa',60, 50.00,1)
INSERT Producto values ('Pañales',100, 80.00,2)
INSERT Producto values ('Paracetamol',100, 2.00,2)
INSERT Producto values ('Gaseosa 1L',150, 7.00,3)
INSERT Producto values ('Papel higienico',100, 25.00,3)
INSERT Producto values ('Juego de Platos',200, 65.00,4)
INSERT Producto values ('Televisor ',50, 1800,4)
go


insert into Cliente values('Juan Alvarez Castillo','juan-12@gmail.com','123456','Lima',987234123)
insert into Cliente values('Carlos Herman Sotomayor','carlos-herman@gmail.com','123456','Chorrillos',923214678)
insert into Cliente values('Ximena Fernandez Vernan','xime1999-XFV@gmail.com','123456','San Juan de Miraflores',977231903)

select * from Cliente
select * from Producto
select * from categoria
select * from Establecimiento
