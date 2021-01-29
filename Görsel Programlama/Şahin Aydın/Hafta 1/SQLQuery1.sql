Create Database ADODB
Go
Use ADODB
Go
Create Table Products
(
	Id Int Identity Primary Key,
	Name Varchar(50),
	Price Money
)
Go
Create Proc SP_Insert
	@Name  Varchar(50),
	@Price Money
As
	Insert Into Products Values(@Name,@Price)
Go
Create Proc SP_Update
	@Id Int,
	@Name  Varchar(50),
	@Price Money
As
	Update Products Set Name=@Name, Price=@Price
	Where Id=@Id
Go
Create Proc SP_Delete
	@Id Int
As
	Delete From Products Where Id = @Id
Go
Create Proc SP_Select
As
	Select * From Products
Go
Exec SP_Insert 'Masaüstü Bilgisayar',2550
Go
Exec SP_Insert 'iPhone 7',4565
Go
Exec SP_Insert 'Samsung Note 6',3250
Go
Create Proc SP_GetProductById
	@Id Int
As
	Select * From Products Where Id=@Id