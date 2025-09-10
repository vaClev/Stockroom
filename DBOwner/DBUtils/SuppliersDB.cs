using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stockroom.DBUtils;
using Stockroom.Models;

namespace Stockroom.DBUtils
{
    internal class SuppliersDB
    {
        static private readonly string insertTemplate = @"INSERT into Suppliers (Name) values ('{0}')";
        static private readonly string selectAllTemplate = @"SELECT * FROM Suppliers";
        static private readonly string selectByIdTemplate = @"SELECT * FROM Suppliers WHERE SupplierId = {0}";

        private List<Supplier> tempParsedSuppliers = new List<Supplier>();

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
        
        public Supplier? GetSupplier(UInt64 id)
        {
            var preparedSqlSelectQuery = string.Format(selectByIdTemplate, id.ToString());
            DBHelper_old.GetDBHelper().SelectQuery(preparedSqlSelectQuery, ParseSuppliers);
            return tempParsedSuppliers.FirstOrDefault();
        }
        public IEnumerable<Supplier> GetSuppliers()
        {
            DBHelper_old.GetDBHelper().SelectQuery(selectAllTemplate, ParseSuppliers);
            return tempParsedSuppliers;
        }

        private void ParseSuppliers(SqlDataReader reader)
        {
            if(tempParsedSuppliers.Count() != 0)
                tempParsedSuppliers.Clear();
            while (reader.Read())
            {
                tempParsedSuppliers.Add(ParseSupplier(reader));
            }

        }

        private Supplier ParseSupplier(SqlDataReader reader)
        {
            UInt64 id = Convert.ToUInt64(reader[0]);
            string name = reader.GetString(1);

            return new Supplier(id, name);
        }

        
    }
}
