using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockroom.DBUtils.UnitTests
{
    class StockroomTest
    {
        public static void RunTest()
        {
            Console.WriteLine("StockroomTest start----------------------------------------------\n\n");
            DBUtils.Stockroom stock = new DBUtils.Stockroom();

            var categories = stock.GetCategories();
            CategoriesTest.ConsoleCategories(categories);

            var products = stock.GetProducts();
            ProductsTest.ConsoleProducts(products);
            Console.WriteLine("StockroomTest end------------------------------------------------\n\n");
        }
    }
}
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