using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stockroom.DBUtils;
using Stockroom.Models;

namespace Stockroom.DBUtils.UnitTests
{
    class CategoriesTest
    {
        public static void RunTest()
        {
            Console.WriteLine("CategoriesTest start---------------------------------------------\n\n");
            Console.WriteLine("Random create two categories and add it to DB");
            CategoryDB categoryDb = new CategoryDB();
            Category category = new Category(Utils.GenerateString(6), 1);
            Category category2 = new Category(Utils.GenerateString(6));
            categoryDb.AddCategory(category);
            categoryDb.AddCategory(category2);

            Console.WriteLine("\nSelect All:");
            var categories = categoryDb.GetCategories();
            if (categories != null)
            {
                foreach (var cat in categories)
                {
                    Console.WriteLine($"{cat.id} {cat.name} {cat.parentId}");
                }
            }

            Console.WriteLine("\nOk. Get me Where id=2");
            var secondCategory = categoryDb.GetCategory(2);
            Console.WriteLine($"{secondCategory.id} {secondCategory.name} {secondCategory.parentId}");
            Console.WriteLine("CategoriesTest end----------------------------------------------\n\n");
        }

        public static CategoryDB GetCategoryDB()
        {
            return new CategoryDB();
        }

        public static void ConsoleCategories(IEnumerable<Category> categories)
        {
            foreach (var cat in categories)
            {
                Console.WriteLine($"{cat.id} {cat.name} {cat.parentId}");
            }
        }
    }
}
