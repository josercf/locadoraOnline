using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraOnline
{
    public class Serie  : Conteudo
    {
        public Serie(string titulo, int anoLancamento)
            :base(titulo, anoLancamento)
        {                    
        }
        public override void Reproduzir()
        {
            Console.WriteLine("Reproduzindo Serie");
        }
    }
}
