using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraOnline
{
    public class Elenco
    {
        private List<Pessoa> elenco;

        public Elenco()
        {
            elenco = new List<Pessoa>();
        }

        public void AdicionarMembro(Atriz atriz)
        {
            elenco.Add(atriz);
        }

        public void AdicionarMembro(Ator ator)
        {
            elenco.Add(ator);
        }

        public string ObterNome()
        {
            return elenco.Select(c => c.ToString()).Aggregate((x, y) => x + ", " + y);
        }      

        //private - Somente tem acesso á propriedade ou metódo
        //protected - Somente a classe e seus herdeiros podem ver ou alterar;
        //internal - Somente dentro do mesmo namespace;
        //public - aberto, todos podem ver
    }
}
