Create Proc SP_List
As
Select * From Categories
Go
Create Proc SP_ListP
As
Select * From Products
Go
Create Proc SP_InsertP
	@Name Varchar(50),
	@Price Money,
	@CategoryId Int
As
	Insert Into Products Values (@Name,@Price,@CategoryId)
Go
Create Proc SP_DeleteP
	@Id int
As
	Delete From Products Where Id = @Id
Go
Create Proc SP_UpdateP
	@Id Int,
	@Name Varchar(50),
	@Price Money,
	@CategoryId Int
As
Update Products Set Name=@Name, Price=@Price,CategoryId =@CategoryId Where Id =@Id 
