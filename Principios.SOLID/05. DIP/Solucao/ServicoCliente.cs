
namespace Itau.DIP.Solucao
{
    public class ServicoCliente
    {
        private IRepositorioCliente _repositorio;

        public ServicoCliente(IRepositorioCliente repositorio)
        {
            _repositorio = repositorio;
        }

        public int Inserir(Cliente cliente)
        {
            return _repositorio.Inserir(cliente);
        }
    }
}
