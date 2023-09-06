using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEmpresas
{
    public class EnviarNotificacaoTelegram : IEnviarNotificacao
    {
        public void EnviarMensagem()
        {
            //implementa integração Telegram
            Console.WriteLine("Estou enviando uma mensagem no Telegram!");
        }
    }
}
