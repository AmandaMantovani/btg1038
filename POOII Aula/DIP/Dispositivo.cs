using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public abstract class Dispositivo
    {
        public abstract void Ligar();
        public abstract void Desligar();
        public abstract bool EstaLigado();
    }
}
