using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptymalizacjaDwieZmienne.Database
{
    class SqliteConfiguration : IDatabaseConfiguration
    {
        private SQLiteConnection connection;
        public void connect()
        {
            if (!System.IO.File.Exists("MyDatabase.sqlite"))
            {
                SQLiteConnection.CreateFile("MyDatabase.sqlite");
            }
            connection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
        }

        public void read()
        {
            throw new NotImplementedException();
        }

        public void safe(string nameFunction,double x, double y, double fitness)
        {
            string sql = "insert into Dane(NameFunction,X,Y,Fitness) Values(" + "\""+nameFunction + "\"" + "," + "\"" + x + "\"" + "," +"\""+y+ "\""+"," + "\""+fitness+"\"" + ")";
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        
    }
}
