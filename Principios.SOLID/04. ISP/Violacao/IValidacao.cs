
namespace Itau.ISP.Violacao
{
    public interface IValidacao
    {
        bool ValidarEmail(string email);

        bool ValidarDocumento(string documento);

        bool ValidarCodigoBarras(string codigoBarras);
    }
}
