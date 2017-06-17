using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraOnline
{
    public class Catalogo
    {
        public List<Filme> Filmes { get; private set; }
        public List<Serie> Series { get; private set; }

        public void AdicionarFilme(Filme filme)
        {
            if (Filmes == null)
                Filmes = new List<Filme>();

            Filmes.Add(filme);
        }

        public void AdicionarSerie(Serie serie)
        {
            if (Series == null)
                Series = new List<Serie>();

            Series.Add(serie);
        }

        public void ListarFilmes()
        {
            foreach (var item in Filmes)
            {
                //imprimir o nome do filme
                //imprimir o ano lancamento
                Console.WriteLine($"{item.Titulo} - {item.AnoLancamento}");

                string nomeCategoria = string.Empty;
                //imprimir a categoria
                switch (item.Categoria)
                {
                    case Categoria.Drama:
                        nomeCategoria = "Drama";
                        break;
                    case Categoria.Terror:
                        nomeCategoria = "Terror";
                        break;
                    case Categoria.Acao:
                        nomeCategoria = "Ação";
                        break;
                    default:
                        nomeCategoria = "Categoria não identificada";
                        break;
                }

                Console.WriteLine(nomeCategoria);

                //imprimir nome diretor
                Console.WriteLine(item.Diretor.Nome);

                //imprimir elenco
                Console.WriteLine(item.Elenco.ObterNome());
                Console.WriteLine();
            }
        }
    }
}
