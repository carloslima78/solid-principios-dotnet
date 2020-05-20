using System;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Itau.SRP.Violacao
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string CPF  { get; set; }
        public string Email { get; set; }

        public void Inserir(Cliente cliente)
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

                    if(IdCliente > 0)
                    {
                        EnviarEmail("Saudações", "Saudações ao novo cliente", "ben@contoso", cliente.Email);
                    }
                } 
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public void EnviarEmail(string assunto, string corpo, string de, string para)
        {
            try
            {
                MailMessage message = new MailMessage(de, para);
                message.Subject = assunto;
                message.Body = corpo;
                SmtpClient client = new SmtpClient("Server");
                client.UseDefaultCredentials = true;
                client.Send(message);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
