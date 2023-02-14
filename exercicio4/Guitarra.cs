using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio4
{
    public class Guitarra
    {
        private static string Afinacao{ get; set;}

        static Guitarra()
        {
            Afinacao = "Sol";
            
        }

        private static void TomAfinado()
        {
            Console.WriteLine($"A guitarra está com afinação em {Afinacao}.");
        }

        public void TocarSom()
        {
            TomAfinado();
        }

         public void TocarSom(string AtualAfinaçao)
        {
            Afinacao = AtualAfinaçao;
            TomAfinado();
        }

    }
}