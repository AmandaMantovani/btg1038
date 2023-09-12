namespace ExercicioEmpresa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IEmpresaVenda> empresasVenda = new();

            IEmpresaVenda varejo = new Varejo("MercadoI", "Supermercado", "98765432100001", Tipo.EmpresaIndividual);
            IEmpresaVenda empreiteira = new Empreiteira("EmpreiteiraI", "Empreiteira Ltda", "12345678900001", Tipo.SociedadeLimitadaEmpresarial);
            IEmpresa mei = new MEI("Professor Autonomo", "Professor", "123488551123", Tipo.MicroempreendedorIndividual);

            empresasVenda.Add(varejo);
            empresasVenda.Add(empreiteira);

            List<IEmpresa> empresas = new();
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