using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class EsporteFutebol
    {
        private TipoEsporte TipoEsporte { get; set; }
        public int QuantidadeJogadores { get; set; }
        public EsporteFutebol()
        {
            TipoEsporte = TipoEsporte.Futebol;
        }

        public string DescreveRegras()
        {
            StringBuilder sb = new();
            sb.AppendLine(Esporte.DescreveObjetivoFutebol());
            sb.AppendLine($"E isso é feito com {QuantidadeJogadores} jogadores");

            return sb.ToString();
        }
    }
}
