using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using ClienteApi.Lib.Models;

namespace ClienteApi.Lib.Repository
{
    public class ClienteRepository : Repository
    {
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

        public List<Cliente> GetClientes()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Clientes";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);

                    while (dt.Read())
                        clientes.Add(new Cliente(dt.GetInt32(0), dt.GetString(1), dt.GetString(2),
                        dt.GetString(3), dt.GetString(4), dt.GetString(5), dt.GetString(6)));

                    return clientes;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Cliente GetCliente(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = $"SELECT * FROM Clientes Where Id = {Convert.ToInt32(id)}";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return new Cliente(0, "", "", "", "", "", "");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Add(Cliente cliente)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = $@"INSERT INTO Clientes(Nome, Documento, Cidade, Endereco, 
                        Complemento, Pais) values (@Nome, @Documento, 
                        @Cidade, @Endereco, @Complemento, @Pais)";
                    cmd.Parameters.AddWithValue("@Id", cliente.Id);
                    cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@Documento", cliente.Documento);
                    cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade);
                    cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                    cmd.Parameters.AddWithValue("@Complemento", cliente.Complemento);
                    cmd.Parameters.AddWithValue("@Pais", cliente.Pais);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(Cliente cliente)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    if (cliente.Id != null)
                    {
                        cmd.CommandText = $@"UPDATE Clientes SET Nome = @Nome, Documento = @Documento, 
                        Cidade = @Cidade, Endereco = @Endereco, Complemento = @Complemento, 
                        Pais = @Pais WHERE Id = @Id";
                        cmd.Parameters.AddWithValue("@Id", cliente.Id);
                        cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                        cmd.Parameters.AddWithValue("@Documento", cliente.Documento);
                        cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade);
                        cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                        cmd.Parameters.AddWithValue("@Complemento", cliente.Complemento);
                        cmd.Parameters.AddWithValue("@Pais", cliente.Pais);
                        cmd.ExecuteNonQuery();
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Delete(int Id)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Clientes Where Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", Id);
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