using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraOnline
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public override string ToString()
        {
            return $"{Nome} {Sobrenome}";
        }
    }
}
