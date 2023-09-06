using SRP.Interface;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConexaoBanco conexaoSql = new ConexaoBancoMySql();
            NotaFiscalRepository repository = new NotaFiscalRepository(conexaoSql);

            repository.Consultar("123");
        }
    }
}