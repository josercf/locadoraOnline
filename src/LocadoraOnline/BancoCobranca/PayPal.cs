using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraOnline.BancoCobranca
{
    public class PayPal : ICobranca
    {
        public bool RealizarCobranca(int idCliente, decimal valor)
        {
            var cartoes = new List<string>
            {
                "Visa", "MasterCard", "Amex"
            };

            if (cartoes.Contains("Elo") && cartoes.Count > 2)
                return true;

            return false;
        }
    }
}
