using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEmpresas
{
    internal class EnviarNotificacaoWhatsApp : IEnviarNotificacao
    {
        public void EnviarMensagem()
        {
            //integra com whatsapp, e envia mensagem
            Console.WriteLine("Estou enviando uma mensagem no WhatsApp do Cliente");
        }
    }
}
