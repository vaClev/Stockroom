using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stockroom.DBUtils;
using Stockroom.Models;

namespace Stockroom.DBUtils.UnitTests
{
    class SuppliersTest
    {
        public static void RunTest()
        {
            Console.WriteLine("SuppliersTest start----------------------------------------------\n\n");
            Console.WriteLine("Random create two suppliers and add it to DB");
            SuppliersDB db = new SuppliersDB();
            Supplier supplier = new Supplier(Utils.GenerateString(6));
            Supplier supplier2 = new Supplier(Utils.GenerateString(6));
            db.AddSupplier(supplier);
            db.AddSupplier(supplier2);

            Console.WriteLine("\nSelect All:");
            var suppliers = db.GetSuppliers();
            if (suppliers != null)
            {
                foreach (var supp in suppliers)
                {
                    Console.WriteLine($"{supp.id} {supp.name}");
                }
            }

            Console.WriteLine("\n\nOk. Get me Where id=2");
            var selectedSupplier = db.GetSupplier(2);
            Console.WriteLine($"{selectedSupplier.id} {selectedSupplier.name}");

            Console.WriteLine("SuppliersTest end----------------------------------------------\n\n");
        }

        public static SuppliersDB GetSuppliersDB()
        {
            return new SuppliersDB();
        }
    }
}
