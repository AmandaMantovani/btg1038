namespace ExercicioEmpresa1
{
    public class Empreiteira : Empresa, IEmpresaVenda
    {
        public Empreiteira(string nomeFantasia, string razaoSocial, string cNPJ, Tipo tipo)
                     : base(nomeFantasia, razaoSocial, cNPJ, tipo) { }

        public void RealizarVenda()
        {
            Console.WriteLine("Venda de serviço realizada!");
        }
    }
}
