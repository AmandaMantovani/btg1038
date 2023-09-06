using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDIP
{
    public class RealizarVenda
    {
        public ProcessarPagamento ProcessarPagamento { get; set; }
        public RealizarVenda(ProcessarPagamento processarPagamento)
        {
            ProcessarPagamento = processarPagamento;
        }

        public void ConcluirVenda()
        {
            ProcessarPagamento.ProcessarPagamentoCartaoCredito();
        }
    }
}
