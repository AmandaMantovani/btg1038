namespace ExercicioOCP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessarPagamento processarPagamento = new();

            processarPagamento.RealizarPagamento();
        }
    }
}