
namespace Itau.SRP.Solucao
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        public void Inserir (Cliente cliente)
        {
            RepositorioCliente repositorio = new RepositorioCliente();
            cliente.IdCliente = repositorio.Inserir(cliente);

            if(cliente.IdCliente > 0)
            {
                ServicoEmail.Enviar("Saudações", "Saudações ao novo cliente", "ben@contoso", cliente.Email);
            }
        }
    }
}
