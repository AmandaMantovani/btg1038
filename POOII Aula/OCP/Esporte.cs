using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal static class Esporte
    {
        //public static string DescreveObjetivo(TipoEsporte tipoEsporte)
        //{
        //    if (tipoEsporte == TipoEsporte.Futebol)
        //    {
        //        return "O objetivo é fazer gol";
        //    }
        //    else if (tipoEsporte == TipoEsporte.Basquete)
        //    {
        //        return "O objetivo é fazer cestas!";
        //    }
        //    else if (tipoEsporte == TipoEsporte.Volei)
        //    {
        //        return "O objetivo é fazer pontos!";
        //    }
            
        //    return "Esporte não identificado!";
        //}

        public static string DescreveObjetivoFutebol()
        {
            return "O objetivo é fazer gol";
        }

        public static string DescreveObjetivoBasquete()
        {
            return "O objetivo é fazer cestas!";
        }

        public static string DescreveObjetivoVolei()
        {
            return "O objetivo é fazer pontos!";
        }

        public static string DescreveObjetivoCorrida()
        {
            return "O objetivo é chegar primeiro";
        }
    }
}
