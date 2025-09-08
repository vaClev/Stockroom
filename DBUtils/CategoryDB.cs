using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        static private readonly string selectAllTemplate = @"select * from Categories";
        static private readonly string selectByIdTemplate = @"select * from Categories where CategoryId = {0}";

        IEnumerable<Category> tempParsedCategories = null;

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

        public IEnumerable<Category> GetCategories()
        {
            DBHelper_old.GetDBHelper().SelectQuery(selectAllTemplate, ParseCategies);
            return tempParsedCategories;
        }

        public Category GetCategory(UInt64 id)
        {
            var preparedSqlSelectQuery = string.Format(selectByIdTemplate, id.ToString());
            DBHelper_old.GetDBHelper().SelectQuery(preparedSqlSelectQuery, ParseCategies);
            return tempParsedCategories.First();
        }

        //Работает с reader но не владеет им
        private void ParseCategies(SqlDataReader reader)
        {
            var parsedCategories = new List<Category>();
            while (reader.Read())
            {
                parsedCategories.Add(ParseCategory(reader));
            }
            tempParsedCategories = parsedCategories;
        }

        //Работает с reader но не владеет им
        private Category ParseCategory(SqlDataReader reader)
        {
            UInt64 id = Convert.ToUInt64(reader[0]);
            string name = (string)reader[1];

            var DBTypeParentId = reader[2];
            UInt64? parentId = null;
            if (!DBNull.Value.Equals(DBTypeParentId))
            {
                parentId = Convert.ToUInt64(DBTypeParentId);
            }

            return new Category(id, name, parentId);
        }
    }
}
