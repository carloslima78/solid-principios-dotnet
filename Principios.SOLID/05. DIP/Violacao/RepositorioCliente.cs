using System;
using System.Data.SqlClient;

namespace Itau.DIP.Violacao
{
    public class RepositorioCliente
    {
        public int Inserir(Cliente cliente)
        {
            SqlCommand command = null;

            try
            {
                using (command = new SqlCommand())
                {
                    command.Connection = new SqlConnection("String de Conexao");
                    command.Connection.Open();
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "INSERT INTO TBCliente (Nome, CPF, Email) VALUES(@Nome, @CPF, @Email) SELECT @@IDENTITY";
                    command.Parameters.AddWithValue("@Nome", cliente.Nome);
                    command.Parameters.AddWithValue("@CPF", cliente.CPF);
                    command.Parameters.AddWithValue("@Email", cliente.Email);
                    cliente.IdCliente = (int)command.ExecuteScalar();
                    return cliente.IdCliente;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
