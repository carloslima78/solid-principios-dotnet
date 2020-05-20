
using System.Text.RegularExpressions;

namespace Itau.ISP.Solucao
{
    public class ServicoCliente : IEmail, IDocumento
    {
        public bool ValidarDocumento(string documento)
        {
            bool resposta = true;

            if (documento.Length > 11 || documento.Length < 11)
                resposta = false;

            return resposta;
        }

        public bool ValidarEmail(string email)
        {
            string regexValidar =
                @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            Regex regex = new Regex(regexValidar);

            return regex.IsMatch(email);
        }
    }
}
