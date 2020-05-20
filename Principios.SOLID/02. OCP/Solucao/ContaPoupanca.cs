
namespace Itau.OCP.Solucao
{
    public class ContaPoupanca : Conta
    {
        public override string Debitar(string conta, string agencia, decimal valor)
        {
            const decimal SALDO_CONTA_POUPANCA = 20000;
            const string CONTA_POUPANCA = "33334444";
            const string AGENCIA = "333";

            decimal saldoRestante = 0;
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
