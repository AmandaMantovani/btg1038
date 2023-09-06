using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Botao
    {
        private Dispositivo Dispositivo { get; set; }
        public Botao(Dispositivo dispositivo)
        {
            Dispositivo = dispositivo;
        }

        public void Apertar()
        {
            if (Dispositivo.EstaLigado())
            {
                Dispositivo.Desligar();
            }
            else
            {
                Dispositivo.Ligar();
            }
        }
    }
}
