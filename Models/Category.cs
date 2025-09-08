using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockroom.Models
{
    public class Category
    {
        //TODO: перейти на Guid 
        public UInt64 id { get; set; }       /// Уникальный идентификатор категории 
        public string name { get; set; }     /// Наименование категории
        public UInt64? parentId { get; set; } /// Уникальный идентификатор родительской категории



        //Конструктор для объектов перед добавлением их в базу данных. Id присвоит СУБД
        public Category(string name, UInt64? parentId = null)
        {
            this.name = name;
            if (parentId != null && parentId != 0)
            {
                this.parentId = parentId;
            } else {
                this.parentId = null;
            }
        }

        //Конструктор для объектов извлеченных из БД
        public Category(UInt64 id, string name, UInt64? parentId)
        {
            this.id = id;
            this.name = name;
            this.parentId = parentId;
        }
    }
}

