using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio6
{
    public class Filme
    {
        public string NomeFilme {get; set;}
        public string Categoria {get; set;}

        public Filme(string nomeFilme, string categoria)
        {
            NomeFilme = nomeFilme;
            Categoria = categoria;
            Console.WriteLine($"O filme {NomeFilme} tem como Gênero principal {Categoria}.");
        }

    }

}