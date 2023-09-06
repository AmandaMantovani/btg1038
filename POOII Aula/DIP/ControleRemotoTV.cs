using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class ControleRemotoTV : Dispositivo
    {
        private bool Ligado { get; set; }
        public override void Desligar()
        {
            Console.WriteLine("Desligando a TV");
            Ligado = false;
        }

        public override bool EstaLigado()
        {
            return Ligado;
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando a TV");
            Ligado = true;
        }
    }
}
