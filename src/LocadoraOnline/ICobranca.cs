using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraOnline
{
    interface ICobranca
    {
        bool RealizarCobranca(int idCliente, decimal valor);
    }
}
