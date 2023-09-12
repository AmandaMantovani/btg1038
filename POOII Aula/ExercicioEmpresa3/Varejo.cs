namespace ExercicioEmpresa1
{
    public class Varejo : Empresa, IEmpresaVenda
    {
        public Varejo(string nomeFantasia, string razaoSocial, string cNPJ, Tipo tipo)
                     : base(nomeFantasia, razaoSocial, cNPJ, tipo)
        {
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Venda do produto realizada!");
        }
    }
}
