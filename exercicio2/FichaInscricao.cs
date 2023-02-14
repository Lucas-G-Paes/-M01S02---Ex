using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio2
{
    public class FichaInscricao
    {
        public int Id { get; set; } 
        public string Nome { get; set; } 
        public DateTime DataNascimento { get; set; } 
        public int MenorIdade { get; set; } 
    
        
        public FichaInscricao(int id, string nome, DateTime dataNascimento, int menorIdade)
            {
                Id = id;
                Nome = nome;
                DataNascimento = dataNascimento;
                MenorIdade = menorIdade;
                Console.WriteLine($"Código: {Id}, Nome: {Nome}, Data de nascimento: {DataNascimento}");
            }
            
    }

}
