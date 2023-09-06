namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dispositivo lampada = new Lampada();
            Dispositivo controleRemoto = new ControleRemotoTV();

            Botao botao = new(controleRemoto);

            botao.Apertar();
            botao.Apertar();
        }
    }
}