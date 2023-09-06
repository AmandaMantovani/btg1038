using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Lampada : Dispositivo
    {
        private bool Ligada { get; set; }

        public override void Ligar()
        {
            Console.WriteLine("Ligando a lampada");
            Ligada = true;
        }

        public override void Desligar()
        {
            Console.WriteLine("Desligando a lampada");
            Ligada = false;
        }

        public override bool EstaLigado()
        {
            return Ligada;
        }
    }
}
