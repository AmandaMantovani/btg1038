using ExercicioEmpresa4;

namespace ExercicioEmpresa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<EmpresaVenda> empresasVenda = new List<EmpresaVenda>();

            EmpresaVenda varejo = new Varejo("MercadoI", "Supermercado", "98765432100001", Tipo.EmpresaIndividual);
            EmpresaVenda empreiteira = new Empreiteira("EmpreiteiraI", "Empreiteira Ltda", "12345678900001", Tipo.SociedadeLimitadaEmpresarial);
            Empresa mei = new MEI("Professor Autonomo", "Professor", "123488551123", Tipo.MicroempreendedorIndividual);

            empresasVenda.Add(varejo);
            empresasVenda.Add(empreiteira);

            List<Empresa> empresas = new();
            empresas.Add(mei);

            foreach (var empresa in empresasVenda)
            {
                empresa.InformacoesEmpresa();
                empresa.RealizarVenda();
                Console.WriteLine();
            }

            foreach (var empresa in empresas)
            {
                empresa.InformacoesEmpresa();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}