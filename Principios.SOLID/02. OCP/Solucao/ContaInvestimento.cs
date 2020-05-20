
using System;

namespace Itau.OCP.Solucao
{
    public class ContaInvestimento : Conta
    {
        public override string Debitar(string conta, string agencia, decimal valor)
        {
            const decimal SALDO_CONTA_INVESTIMENTO = 20000;
            const string CONTA_INVESTIMENTO = "33334444";
            const string AGENCIA = "333";
            const int MES_ANIVERSARIO = 5;
            const int MESES_CARENCIA = 6;

            decimal saldoRestante;
            string mensagem = "";

            if (conta == CONTA_INVESTIMENTO && agencia == AGENCIA)
            {
                if ((DateTime.Now.Month - MES_ANIVERSARIO) < MESES_CARENCIA)
                {
                    mensagem = "Ainda no período de carância";
                }
                else
                {
                    if (valor >= SALDO_CONTA_INVESTIMENTO)
                    {
                        saldoRestante = SALDO_CONTA_INVESTIMENTO - valor;
                        mensagem = $"Débito realizado, seu saldo é de { saldoRestante }";
                    }
                    else
                    {
                        mensagem = "Saldo insuficiente.";
                    }
                }
            }

            return mensagem;
        }
    }
}
