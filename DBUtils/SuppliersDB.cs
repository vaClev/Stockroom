using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stockroom.DBUtils;
using Stockroom.Models;

namespace Stockroom.DBUtils
{
    class SuppliersDB
    {
        static private readonly string insertTemplate = @"INSERT into Suppliers (Name) values ('{0}')";
        public void AddSupplier(Supplier supplier)
        {
            var preparedSqlInsertQuery = string.Format(insertTemplate, supplier.name.ToLower());
            Console.WriteLine(preparedSqlInsertQuery);
            DBHelper_old.GetDBHelper().InsertQuery(preparedSqlInsertQuery);
        }

        public void UpdateSupplierParams(Supplier supplier)
        {
            //TODO ::
        }
        public void DeleteSupplier(UInt64 supplierId)
        {
            //TODO ::
        }
    }
}
