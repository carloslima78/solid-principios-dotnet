using System;
using System.Net.Mail;

namespace Itau.SRP.Solucao
{ 
    public static class ServicoEmail
    {
        public static void Enviar(string assunto, string corpo, string de, string para)
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
