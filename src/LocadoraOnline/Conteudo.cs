using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraOnline
{
    public abstract class Conteudo
    {
        public Conteudo(string titulo, int anoLancamento)
        {

            if (titulo == "")
                throw new ArgumentException("Titulo precisa ser preenchido", titulo);

            if (anoLancamento <=  0)
                throw new ArgumentException("Ano de lançaenmto não pode ser negativo");

            Titulo = titulo;
            AnoLancamento = anoLancamento;
        }

        public string Titulo { get; private set; }
        public int AnoLancamento { get; private set; }
        public Categoria Categoria { get; set; }

        public Diretor Diretor { get; set; }

        public virtual void Reproduzir()
        {
            Console.WriteLine("Reproduzindo Conteudo");
        }

        public void Reproduzir(int minuto)
        {
            Console.WriteLine($"Reproduzindo Conteudo a partir de {minuto}");
        }
    }
}
