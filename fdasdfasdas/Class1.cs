using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace fdasdfasdas
{
    namespace WindowsFormsApplication11
    {
        // В классе написать:

        class DbConnection
        {
            public static DataTable select(string sql)
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "cfif31.ru";
                builder.Port = 3306;
                builder.Database = "ISPr24-39_NurgaleevDA_Praktika";
                builder.UserID = "ISPr24-39_NurgaleevDA";
                builder.Password = "ISPr24-39_NurgaleevDA";
                MySqlConnection connect = new MySqlConnection(builder.ConnectionString);
                try
                {
                    connect.Open();
                    MySqlCommand command = new MySqlCommand(sql, connect);
                    MySqlDataReader reader = command.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    return table;

                }
                catch (Exception e)
                {
                    MessageBox.Show("При выполнении запроса произошла ошибка! " + e.Message);
                    return null;
                }
            }
        }
    }

}
