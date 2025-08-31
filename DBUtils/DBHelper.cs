using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockroom.DBUtils
{
    public class DBHelper_old  //TODO: убрать public. Должен быть доступен только классу Stockroom.
    {
        private static DBHelper_old instance = null;
        SqlConnection connection = null;

        private DBHelper_old() 
        {
            connection = new SqlConnection();
            string cs = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection.ConnectionString = cs;
        }


        public static DBHelper_old GetDBHelper()
        {
            if (instance == null)
            {
                instance = new DBHelper_old();
            }
            return instance;
        }



        public void TestInsertQuery()
        {
            InsertQuery(@"insert into Categories (name, parentId) values ('TestCategory', NULL)");
        }

        public void InsertQuery(string insertString)
        { 
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(insertString, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
