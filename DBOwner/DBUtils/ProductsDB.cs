using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stockroom.Models;

namespace Stockroom.DBUtils
{
    internal class ProductsDB
    {
        static private readonly string insertTemplate =
            @"INSERT INTO Products (Name, Description, CategoryId, SupplierId) VALUES ('{0}', '{1}', {2}, {3})";

        static private readonly string selectAllTemplate = @"SELECT * FROM Products";
        private IEnumerable<Product> tempParsedProducts;

        public void AddProduct(Product product)
        {
            var preparedSqlInsertQuery = string.Format(insertTemplate,
                                                        product.name.ToLower(),
                                                        product.description,
                                                        product.categoryId,
                                                        product.supplierId
                                                        );
            Console.WriteLine(preparedSqlInsertQuery);
            DBHelper_old.GetDBHelper().InsertQuery(preparedSqlInsertQuery);
        }

        public void UpdateProductParams(Product product)
        {
            //TODO ::
        }
        public void DeleteProduct(UInt64 supplierId)
        {
            //TODO ::
        }

        public IEnumerable<Product> GetProducts()
        {
            DBHelper_old.GetDBHelper().SelectQuery(selectAllTemplate, ParseProducts);
            return tempParsedProducts;
        }


        //Работает с reader но не владеет им
        private void ParseProducts(SqlDataReader reader)
        {
            var parsedCategories = new List<Product>();
            while (reader.Read())
            {
                parsedCategories.Add(ParseProduct(reader));
            }
            tempParsedProducts = parsedCategories;
        }


        //Работает с reader но не владеет им
        private Product ParseProduct(SqlDataReader reader)
        {
            UInt64 id = Convert.ToUInt64(reader[0]);
            string name = (string)reader[1];
            string description = (string)reader[2];
            UInt64 categoryId = Convert.ToUInt64(reader[3]);
            UInt64 supplierId = Convert.ToUInt64(reader[4]);

            return new Product(id, name, description, categoryId, supplierId);
        }
    }
}
