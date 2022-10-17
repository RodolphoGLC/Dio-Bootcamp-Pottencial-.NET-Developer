using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa 
    {                                                          //  : base(nome) = puxa o nome daquele construtor
        public Professor (string nome, int idade, decimal salario) //: base(nome)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }
        public decimal Salario { get; set; }
    
    //Override - sobreescreve o metodo apresentar
    //Sealed - selado p/ classes filhas
        public sealed override void Apresentar() //Polimorfismo do Apresentar de Pessoa
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} e ganho {Salario}!");            
        }
    }
}