using ExercicioEmpresa4;

namespace ExercicioEmpresa1
{
    public class Varejo : EmpresaVenda
    {
        public Varejo(string nomeFantasia, string razaoSocial, string cNPJ, Tipo tipo)
                     : base(nomeFantasia, razaoSocial, cNPJ, tipo)
        {
        }

        public override void RealizarVenda()
        {
            Console.WriteLine("Venda do produto realizada!");
        }
    }
}
