

namespace Itau.LSP.Solucao
{
    public class Previdencia : Investimento
    {
        public override string Pagar(decimal valor)
        {
            const decimal SALDO_CONTA_CORRENTE = 10000;

            decimal saldoRestante;
            string mensagem;

            if (valor >= SALDO_CONTA_CORRENTE)
            {
                saldoRestante = SALDO_CONTA_CORRENTE - valor;
                mensagem = $"Título de previdência pago com sucesso, seu saldo é de { saldoRestante }";
            }
            else
            {
                mensagem = "Saldo insuficiente.";
            }

            return mensagem;
        }

        public override string Render(decimal taxa)
        {
            const decimal SALDO_CONTA_PREVIDENCIA = 50000;

            decimal rendimento = ((taxa * SALDO_CONTA_PREVIDENCIA) / 100) / 100;
            decimal saldoAtualizado = rendimento + SALDO_CONTA_PREVIDENCIA;

            return $"Seu rendimento foi de { rendimento }, seu saldo é de { saldoAtualizado }";
        }
    }
}
