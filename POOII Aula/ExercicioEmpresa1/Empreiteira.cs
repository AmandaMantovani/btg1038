using ExercicioEmpresa4;

namespace ExercicioEmpresa1
{
    public class Empreiteira : EmpresaVenda
    {
        public Empreiteira(string nomeFantasia, string razaoSocial, string cNPJ, Tipo tipo)
                     : base(nomeFantasia, razaoSocial, cNPJ, tipo) { }

        public override void RealizarVenda()
        {
            Console.WriteLine("Venda de serviço realizada!");
        }
    }
}
