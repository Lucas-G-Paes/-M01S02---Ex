using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio7
{
    public static class Animação
    {
        public static void Animacao()
        {
            Console.WriteLine("Animação frozen");
        }

        public static void Animacao(string sobrecarga)
        {
            Console.WriteLine($"Animação {sobrecarga}");
        }
    }
}