using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stockroom.Models;

namespace Stockroom.DBOwner
{
    public class Stockroom : IStockroom
    {
        public void AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void AddSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(ulong id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetCategories()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            throw new NotImplementedException();
        }
      
    }
}
