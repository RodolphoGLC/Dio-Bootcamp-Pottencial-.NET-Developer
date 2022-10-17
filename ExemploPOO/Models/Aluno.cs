using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public sealed class Aluno : Pessoa //Aluno e classe final, ninguem pode herdar dela
    {                                                          //  : base(nome) = puxa o nome daquele construtor
        public Aluno (string nome, int idade, decimal nota) // : base(nome)
        {
            Nome = nome;
            Idade = idade;
            Nota = nota;
        }
        public decimal Nota { get; set; }
        
        //Override - sobreescreve o metodo apresentar
        public override void Apresentar() //Polimorfismo do Apresentar de Pessoa
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} e tirei {Nota}!");            

        }
    
    }
}