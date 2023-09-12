using ExercicioEmpresa1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEmpresa4
{
    public abstract class EmpresaVenda : Empresa
    {
        protected EmpresaVenda(string nomeFantasia, string razaoSocial, string cNPJ, Tipo tipo) : base(nomeFantasia, razaoSocial, cNPJ, tipo)
        {
        }

        public abstract void RealizarVenda();
    }
}
