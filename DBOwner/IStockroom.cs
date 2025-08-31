using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Stockroom.Models;

namespace Stockroom.DBOwner
{
    interface IStockroom
    {
        /// Добавляем продукты, категории, поставщиков
        void AddProduct(Product product);
        void AddCategory(Category category);
        void AddSupplier(Supplier supplier);

        ///Удаляем продукты
        void DeleteProduct(ulong id); //Пока используем нумератор

        ///Получаем список продуктов
        IEnumerable<Product> GetProducts();
        ///Получаем список категорий
        IEnumerable<Category> GetCategories();
        ///Получаем список поставщиков
        IEnumerable<Supplier> GetSuppliers();
    }
}
