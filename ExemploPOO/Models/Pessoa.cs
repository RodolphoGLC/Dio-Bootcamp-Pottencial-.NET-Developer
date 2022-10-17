using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Pessoa //Criando a Abstração da pessoa em propriedades
    {
        // public Pessoa(string nome) //Construtor em pessoa, exige nas classes filhas um
        // {
        //     Nome = nome;
        // }
        public string Nome { get; set; }
        public int Idade { get; set; }

        //Virtual - Permite que as classes filhas sobreescrevam o metodo
        public virtual void Apresentar() //O virtual - E para que o polimorfismo ocorra 
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade}!");            
        }
    }
}