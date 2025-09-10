using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stockroom.DBUtils;
using Stockroom.Models;

namespace Stockroom.DBUtils.UnitTests
{
    class ProductsTest
    {
        public static void RunTest()
        {
            Console.WriteLine("ProductsTests start----------------------------------------------\n\n");
            var productsDb = new ProductsDB();

            Console.WriteLine("Select All:");
            var products = productsDb.GetProducts();
            ConsoleProducts(products);
            Console.WriteLine("ProductsTest end----------------------------------------------\n\n");
        }

        internal static void ConsoleProducts(IEnumerable<Product> products)
        {
            foreach (var prod in products)
            {
                Console.WriteLine($"{prod.id}, {prod.name}, {prod.description}, " +
                    $"categoryName: {CategoriesTest.GetCategoryDB().GetCategory(prod.categoryId).name}, " +
                    $"{prod.supplierId}");
            }
        }
    }
}
