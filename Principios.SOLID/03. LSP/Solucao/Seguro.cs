using System;

namespace Itau.LSP.Solucao
{
    public class Seguro : Produto
    {
        public override string Pagar(decimal valor)
        {
            const decimal SALDO_CONTA_CORRENTE = 10000;
            const string DATA_VENCIMENTO = "10/05/2020";

            decimal saldoRestante;
            string mensagem;

            if (DateTime.Now > Convert.ToDateTime(DATA_VENCIMENTO))
            {
                mensagem = "Seguro vencido.";
            }
            else
            {
                if (valor >= SALDO_CONTA_CORRENTE)
                {
                    saldoRestante = SALDO_CONTA_CORRENTE - valor;
                    mensagem = $"Seguro pago com sucesso, seu saldo é de { saldoRestante }";
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
