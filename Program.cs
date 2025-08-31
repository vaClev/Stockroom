
using System.Data.SqlTypes;
using Stockroom.DBUtils;
using Stockroom.Models;

Console.WriteLine("Hello, World!");


//var helper = DBHelper_old.GetDBHelper();
//helper.TestInsertQuery();



CategoryDB categoryDb = new CategoryDB();
Category category = new Category("Продукты", 0);
Category category2 = new Category("Milks", 1);
Category category3 = new Category("Meat", 1);
categoryDb.AddCategory(category3);
/*

//где-то внутри класса Application
Stockroom.DBOwner.Stockroom stockroom = new Stockroom.DBOwner.Stockroom();
////
///
Product milk = new Product("Молоко городецкое", "3.2% жирности", 1, 25); //TODO эти строки и цифры условно ввел пользователь.
stockroom.AddProduct(milk);



////
Category category = new Category("Продукты", 0);
stockroom.AddCategory(category);


////
Supplier suppl = new Supplier("молокозавод №1");
stockroom.AddSupplier(suppl);
*/