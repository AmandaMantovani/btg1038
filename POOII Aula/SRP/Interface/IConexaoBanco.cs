using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Interface
{
    public interface IConexaoBanco
    {
        T Select<T>(string query) where T : new();
    }
}
