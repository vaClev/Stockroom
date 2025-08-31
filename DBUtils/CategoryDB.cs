using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Stockroom.Models;

namespace Stockroom.DBUtils
{
    class CategoryDB
    {
        static private readonly string insertTemplate = @"insert into Categories (Name, ParentId) values ('{0}', {1})"; //TODO: спрятать в ресурсы или конфиги. Но в учебном проекте пойдет
        public void AddCategory(Category category)
        {
            var preparedSqlInsertQuery = string.Format(insertTemplate, category.name.ToLower(), category.parentId == null ? "NULL" : category.parentId);
            Console.WriteLine(preparedSqlInsertQuery);
            DBHelper_old.GetDBHelper().InsertQuery(preparedSqlInsertQuery);
        }

        public void UpdateCategoryParams(Category category)
        {
            //TODO ::
        }
        public void DeleteCategory(UInt64 CategoryId)
        {
            //TODO ::
        }

    }
}
