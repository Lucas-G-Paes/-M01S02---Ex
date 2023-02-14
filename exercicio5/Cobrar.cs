using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio5
{
    public class Cobrar
    {
        private decimal Valor { get; set;}
        private decimal Multa { get; set;}


        public Cobrar( decimal valor, decimal multa )
        {
            Valor = valor;
            Multa = multa;
             Console.WriteLine($"O valor é {Valor} com multa de 20 %, o valor total a pagar é {Valor + (Valor * Multa)}");
        }
    
    }

}