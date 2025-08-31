using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockroom.Models
{
    public class Supplier
    {
        /// Уникальный идентификатор
        public UInt64 id { get; set; }  //TODO: перейти на Guid 
        public string name { get; set; } /// Наименование поставщика



        //Конструктор для товаров перед добавлением их в базу данных. Id присвоит СУБД
        public Supplier(string name)
        {
            this.name = name;
        }
    }
}
//TODO :: расширить набор полей. После тестирования работы основных
// ИНН, форма ООО, ОАО и т.п
