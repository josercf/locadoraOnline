using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraOnline.BancoCobranca
{
    public class Bradesco : ICobranca
    {
        public bool RealizarCobranca(int idCliente, decimal valor)
        {
            var saldo = 1000.00M;

            if (saldo >= valor)
            {
                saldo -= valor;
                return true;
            }

            return false;
        }
    }
}
