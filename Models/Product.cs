using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Stockroom.DBUtils;

namespace Stockroom.Models
{
    public class Product
    {

        /// Уникальный идентификатор продукта
        public UInt64 id { get; set; }  //TODO: перейти на Guid 

        /// Наименование продукта
        public string name { get; set; }

        /// Описание продукта
        public string description { get; set; }

        /// Категория продукта
        public UInt64 categoryId { get; set; }

        /// Поставщик продукта
        public UInt64 supplierId { get; set; }


        //Конструктор для товаров перед добавлением их в базу данных. Id присвоит СУБД
        public Product(string name, string descriptoon, UInt64 categoryId, UInt64 supplierId)  
            : this(0, name, descriptoon, categoryId, supplierId )
        {
        }

        public Product(UInt64 id, string name, string description, ulong categoryId, ulong supplierId)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.categoryId = categoryId;
            this.supplierId = supplierId;
        }
    }
}

//TODO: Расширить класс продукта новыми полями. После тестирования работы основных полей.
/*
 * 
        /// Цена за единицу продукта
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Количество на складе
        /// </summary>
        public int QuantityInStock { get; set; }

        /// <summary>
        /// Единица измерения (шт, кг, м и т.д.)
        /// </summary>
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// Минимальный остаток на складе
        /// </summary>
        public int MinimumStockLevel { get; set; }

        /// <summary>
        /// Вес единицы продукта (в кг)
        /// </summary>
        public decimal? Weight { get; set; }

        /// <summary>
        /// Габариты продукта (ДxШxВ в см)
        /// </summary>
        public string Dimensions { get; set; }

        /// <summary>
        /// Дата поступления на склад
        /// </summary>
        public DateTime? ArrivalDate { get; set; }

        /// <summary>
        /// Срок годности (если применимо)
        /// </summary>
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Статус продукта (в наличии, отсутствует, заказан и т.д.)
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Путь к изображению продукта
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Штрих-код продукта
        /// </summary>
        public string Barcode { get; set; }

        /// <summary>
        /// Признак активности продукта
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Дата создания записи
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Дата последнего обновления записи
        /// </summary>
        public DateTime UpdatedAt { get; set; }
*/