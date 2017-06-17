using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LocadoraOnline
{
    public class Program
    {
        public static void Main(string[] args)
        {


            try
            {
               Conteudo filme = new Filme("Velozes e furiosos", 2017);
                filme.Categoria = Categoria.Acao;

                Elenco elencoVelozes = new Elenco();

                var ator1 = new Ator();
                ator1.Nome = "Vin";
                ator1.Sobrenome = "Diesel";

                elencoVelozes.AdicionarMembro(ator1);

                var atriz1 = new Atriz();
                atriz1.Nome = "Michelle";
                atriz1.Sobrenome = "Rodriguez";

                elencoVelozes.AdicionarMembro(atriz1);


                //cast
                ((Filme)filme).Elenco = elencoVelozes;
                filme.Diretor = new Diretor { Nome = "F. Gary", Sobrenome = "Gray" };

                //cast
               // string nomesElenco = (filme as Filme).Elenco.ObterNome();
                //Console.WriteLine(nomesElenco);

                Filme filme3 = new Filme("Tropa de Elite", 2004);
                filme3.Categoria = Categoria.Acao;

                Elenco elenco2 = new Elenco();
                elenco2.AdicionarMembro(new Atriz { Nome = "Maria", Sobrenome = "Ribeiro" });
                elenco2.AdicionarMembro(new Ator { Nome = "Wagner", Sobrenome = "Moura" });
                //cast
                filme3.Elenco = elenco2;
                filme3.Diretor = new Diretor { Nome = "José", Sobrenome = "Padilha" };


                Filme filme1 = new Filme("A culpa é das Estrelas", 2014);
                filme1.Categoria = Categoria.Drama;
                Elenco elenco3 = new Elenco();
                elenco3.AdicionarMembro(new Atriz { Nome = "Shailene", Sobrenome = "Woodley" });
                elenco3.AdicionarMembro(new Ator { Nome = "Nat", Sobrenome = "Wolff" });
                //cast
                filme1.Elenco = elenco3;
                filme1.Diretor = new Diretor { Nome = "Josh", Sobrenome = "Boone" };


                Catalogo catalogo = new Catalogo();

                catalogo.AdicionarFilme((Filme)filme);
                catalogo.AdicionarFilme(filme3);
                catalogo.AdicionarFilme(filme1);

                catalogo.ListarFilmes();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }


            Console.ReadKey();
        }
    }
}
