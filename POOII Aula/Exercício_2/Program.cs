namespace ExercicioEmpresas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IEmpresa> empresas = new List<IEmpresa>();

            // flexibilidade = Open Closed
            IEnviarNotificacao notificacao = new EnviarNotificacaoWhatsApp();

            IEnviarNotificacao notificacaoT = new EnviarNotificacaoTelegram();

            //Dependencia da interface = Dependency Inversion
            IEmpresa varejo = new Varejo("MercadoI", "Supermercado", "98765432100001", Tipo.EmpresaIndividual, notificacaoT);
            IEmpresa empreiteira = new Empreiteira("EmpreiteiraI", "Empreiteira Ltda", "12345678900001", Tipo.SociedadeLimitadaEmpresarial);

            empresas.Add(varejo);
            empresas.Add(empreiteira);

            foreach (var empresa in empresas)
            {
                empresa.InformacoesEmpresa();
                empresa.RealizarVenda();
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}