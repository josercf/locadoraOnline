using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraOnline
{
    public sealed class Filme : Conteudo
    {
        public Filme(string titulo, int anoLancamento)
            : base(titulo, anoLancamento)
        {

        }

        public Elenco Elenco { get; set; }


        public override void Reproduzir()
        {
            Console.WriteLine("Reproduzindo Filme");
        }

    }
}
