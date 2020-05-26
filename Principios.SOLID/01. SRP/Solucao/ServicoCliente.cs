
namespace Itau.SRP.Solucao
{
    public class ServicoCliente
    {
        public void Inserir(Cliente cliente)
        {
            RepositorioCliente repositorio = new RepositorioCliente();
            cliente.IdCliente = repositorio.Inserir(cliente);

            if (cliente.IdCliente > 0)
            {
                ServicoEmail.Enviar("Saudações", "Saudações ao novo cliente", "ben@contoso", cliente.Email);
            }
        }
    }
}
