using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stockroom.Models;

namespace Stockroom.DBUtils
{
    class ProductsDB
    {
        static private readonly string insertTemplate =
            @"INSERT INTO Products (Name, Description, CategoryId, SupplierId) VALUES ('{0}', '{1}', {2}, {3})";
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
    }
}
