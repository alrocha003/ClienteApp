using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using ClienteApi.Lib.Models;

namespace ClienteApi.Lib.Repository
{
    public class LocalizacaoRepository : Repository
    {
        public List<Localizacao> GetLocations()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            List<Localizacao> localizacoes = new List<Localizacao>();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Localizacoes";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);

                    while (dt.Read())
                        localizacoes.Add(new Localizacao(dt.GetString(0), dt.GetString(1), dt.GetString(2)));

                    return localizacoes;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}