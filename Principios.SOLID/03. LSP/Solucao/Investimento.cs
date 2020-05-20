using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.LSP.Solucao
{
    public abstract class Investimento : Produto
    {
        public abstract string Render(decimal taxa);
    }
}
