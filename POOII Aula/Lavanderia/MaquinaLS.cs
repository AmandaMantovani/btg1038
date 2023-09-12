namespace Lavanderia
{
    public class MaquinaLS : ILavarSecar
    {
        public void Lavar()
        {
            Console.WriteLine("Lavando a roupa");
        }

        public void Secar()
        {
            Console.WriteLine("Secando a roupa");
        }
    }
}
