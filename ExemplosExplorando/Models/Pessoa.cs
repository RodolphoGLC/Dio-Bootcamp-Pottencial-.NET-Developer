
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace ExemplosExplorando.Models
// {
//     public class Pessoa
//     {
//         public Pessoa()//Pode ter mais de um construtor para a mesma Classe
//         {
//             //Construtor vazio, adicionando separado depois
//         }
//         public Pessoa(string nome, string sobrenome) //Construtor - mesmo nome da Classe, sem retorno
//         {
//             //Construtor (Nome, Sobrenome)
//             Nome = nome;
//             Sobrenome = sobrenome;
//         }
//         public void Deconstruct(out string nome, out string sobrenome) //Desconstrutor - desconstroi algo que vc havia construido anteriormente
//         {
//             nome = Nome;
//             sobrenome = Sobrenome;
//         }
//         private string _nome; //retorno = string
//         private int _idade; 
//         public string Nome 
//         { 
//             get => _nome.ToUpper(); 
         
//             set 
//             {
//                 if(value == "") 
//                 {
//                     throw new ArgumentException("O nome não pode ser vazio");
//                 }
//                 _nome = value;
//             }  
//         }  
//         public string Sobrenome { get; set; }
//         public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

//         public int Idade 
//         { 
//             get => _idade;
            
//             set
//             {
//                 if(value < 0)
//                 {
//                     throw new ArgumentException("A idade não pode ser menor que zero");
//                 }
//                 _idade = value;
//             } 
            
//         }  
//         public void Apresentar()
//         {
//             Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
//         }
//    }
// }

// -----------------------------------------------------------------------------------------------------------

//Explicando Construtores 

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace ExemplosExplorando.Models
// {
//     public class Pessoa
//     {
//         public Pessoa(string nome, string sobrenome) //Construtor - mesmo nome da Classe, sem retorno
//         {
//             //Construtor (Nome, Sobrenome)
//             Nome = nome;
//             Sobrenome = sobrenome;
//         }
//         public Pessoa()//Pode ter mais de um construtor para a mesma Classe
//         {
//             //Construtor vazio, adicionando separado depois
//         }
//         private string _nome; //retorno = string
//         private int _idade; 
//         public string Nome 
//         { 
//             get => _nome.ToUpper(); 
         
//             set 
//             {
//                 if(value == "") 
//                 {
//                     throw new ArgumentException("O nome não pode ser vazio");
//                 }
//                 _nome = value;
//             }  
//         }  
//         public string Sobrenome { get; set; }
//         public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

//         public int Idade 
//         { 
//             get => _idade;
            
//             set
//             {
//                 if(value < 0)
//                 {
//                     throw new ArgumentException("A idade não pode ser menor que zero");
//                 }
//                 _idade = value;
//             } 
            
//         }  
//         public void Apresentar()
//         {
//             Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
//         }
//     }
// }

// ---------------------------------------------------------------------------------------------------

//Usado na Classe Curso.cs

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace ExemplosExplorando.Models
// {
//     public class Pessoa
//     {
//         private string _nome; 
//         private int _idade; 
//         public string Nome 
//         { 
//             get => _nome.ToUpper(); 
         
//             set 
//             {
//                 if(value == "") 
//                 {
//                     throw new ArgumentException("O nome não pode ser vazio");
//                 }
//                 _nome = value;
//             }  
//         }  
//         public string Sobrenome { get; set; }
//         public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

//         public int Idade 
//         { 
//             get => _idade;
            
//             set
//             {
//                 if(value < 0)
//                 {
//                     throw new ArgumentException("A idade não pode ser menor que zero");
//                 }
//                 _idade = value;
//             } 
            
//         }  
//         public void Apresentar()
//         {
//             Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
//         }
//     }
// }

// ----------------------------------------------------------------------------------------------------------------

//Codigo usado apenas para a Classe Pessoa.cs

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace ExemplosExplorando.Models
// {
//     public class Pessoa
//     {
//         private string _nome; //Campo onde será armazenado o Nome
//         private int _idade; //Campo onde será armazenado o Idade
//         public string Nome //Propriedade Nome
//         { 
//             get => _nome.ToUpper(); //Recebe o Nome(valor) e já faz com que fique maiusculo 
//             // { //Ao invez de usar esse codigo abaixo usasse => "BodyExpressions" para fascilitar o entendimento
//             //     return _nome.ToUpper(); //Coloca o nome como maiuscula 
//             // }
            
//             set //Atribue o Nome(valor)
//             {
//                 if(value == "") //Valor que se recebe na propriedade
//                 {
//                     throw new ArgumentException("O nome não pode ser vazio");
//                     //Exceção que para o código e esperar que alguem trate a excessão se não parará o programa
//                 }
//                 _nome = value;
//             }  
//         }  
//         public string Sobrenome { get; set; }
//         public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

//         public int Idade //Propriedade Idade
//         { 
//             get => _idade;
            
//             set
//             {
//                 if(value < 0)
//                 {
//                     throw new ArgumentException("A idade não pode ser menor que zero");
//                 }
//                 _idade = value;
//             } 
            
//         }  
//         public void Apresentar()
//         {
//             Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
//         }
//     }
// }