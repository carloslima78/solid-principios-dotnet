
namespace Itau.OCP.Violacao
{
    public class Conta
    {       
        public string DebitarContaCorrente(string conta, string agencia, decimal valor)
        {
            const decimal SALDO_CONTA_CORRENTE = 10000;
            const decimal SALDO_LIMITE = 2000 + SALDO_CONTA_CORRENTE;
            const string CONTA_CORRENTE = "11112222";
            const string AGENCIA = "333";
            
            decimal saldoRestante;
            string mensagem = "";

            if (conta == CONTA_CORRENTE && agencia == AGENCIA)
            {
                if (valor >= SALDO_CONTA_CORRENTE)
                {
                    saldoRestante = SALDO_CONTA_CORRENTE - valor;
                    mensagem = $"Débito realizado, seu saldo é de { saldoRestante }";
                }
                else if (valor >= SALDO_LIMITE)
                {
                    saldoRestante = SALDO_LIMITE - valor;
                    mensagem = $"Débito realizado, porém, utilizando o limite, seu saldo é de { saldoRestante }.";
                }
                else
                {
                    mensagem = "Saldo insuficiente.";
                }
            }

            return mensagem;
        }

        public string DebitarContaPoupanca(string conta, string agencia, decimal valor)
        {
            const decimal SALDO_CONTA_POUPANCA = 20000;
            const string CONTA_POUPANCA = "33334444";
            const string AGENCIA = "333";

            decimal saldoRestante;
            string mensagem = "";

            if (conta == CONTA_POUPANCA && agencia == AGENCIA)
            {
                if (valor >= SALDO_CONTA_POUPANCA)
                {
                    saldoRestante = SALDO_CONTA_POUPANCA - valor;
                    mensagem = $"Débito realizado, seu saldo é de { saldoRestante }";
                }
                else
                {
                    mensagem = "Saldo insuficiente.";
                }
            }

            return mensagem;
        }
    }
}
