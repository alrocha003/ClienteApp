using System;
using System.Data;
using System.Data.SQLite;

namespace ClienteApi.Lib.Repository
{
    public class Repository
    {
        public SQLiteDataAdapter _da { get; set; } = null;
        public DataTable _dt { get; set; } = new DataTable();

        public SQLiteConnection sqliteConnection;

        public Repository()
        {
            CreateDatabase();
        }
        public SQLiteConnection DbConnection()
        {
            try
            {
                sqliteConnection = new SQLiteConnection("Data Source=..\\Cliente.sqlite; Version=3;");
                sqliteConnection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error message: {ex}");
            }
            return sqliteConnection;
        }

        public void CreateDatabase()
        {
            try
            {
                SQLiteConnection.CreateFile(@"..\Cliente.sqlite");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error message: {ex}");
            }
        }
        public void CreateTable()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Clientes(id int, Nome Varchar(50), email VarChar(80))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}