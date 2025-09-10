using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stockroom.DBUtils;
using Stockroom.Models;

namespace Stockroom.DBUtils
{
    public class Stockroom : IStockroom
    {
        private CategoryDB categoryDB = new CategoryDB();
        private SuppliersDB suppliersDB = new SuppliersDB();
        private ProductsDB productsDB = new ProductsDB();

        public void AddCategory(Category category)
        {
            categoryDB.AddCategory(category);
        }

        public void AddProduct(Product product)
        {
            productsDB.AddProduct(product);
        }

        public void AddSupplier(Supplier supplier)
        {
            suppliersDB.AddSupplier(supplier);
        }

        public void DeleteProduct(ulong id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetCategories()
        {
            return categoryDB.GetCategories();
        }

        public IEnumerable<Product> GetProducts()
        {
            return productsDB.GetProducts();
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            return suppliersDB.GetSuppliers();
        }
      
    }
}
