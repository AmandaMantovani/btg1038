using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEmpresas
{
    internal class Varejo : Empresa, IEmpresa
    {
        public IEnviarNotificacao EnviarNotificacao { get; private set; }
        public Varejo(string nomeFantasia, string razaoSocial, string cNPJ, Tipo tipo, IEnviarNotificacao notificacao)
                     : base(nomeFantasia, razaoSocial, cNPJ, tipo) 
        {
            EnviarNotificacao = notificacao;
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Venda do produto realizada!");
            EnviarNotificacao.EnviarMensagem();
        }
    }
}
