// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace ExemplosExplorando.Models
// {
//     public class Curso
//     {
//         public string Nome { get; set; }
//         public List<Pessoa> Alunos { get; set; } //Lista de alunos 
//         public void AdicionarAluno(Pessoa aluno) //Metodo que a ação não precisa de retorno
//         {
//             Alunos.Add(aluno);
//         }
//         public int ObterQuantidadesDeAlunos() //Metodo de retorno = precisa retornar alguma informação, sem argumento
//         {
//             int quantidade = Alunos.Count;
//             return quantidade; //Todo metodo de retorno tem que ter "return"
//         }
//         public bool RemoverAluno(Pessoa aluno)
//         {
//             return Alunos.Remove(aluno);
            
//         }
//         public void ListarAluno()
//         {
//             Console.WriteLine($"Alunos do curso de {Nome}");

//             for(int count = 0; count < Alunos.Count; count++)
//             {
//                 //string texto = "N° " + count + " - " + Alunos[count].NomeCompleto; //Concatenação
//                 string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}"; //Interpolação
//                 Console.WriteLine(texto);
//             }
//         }
//     }
// }

// ----------------------------------------------------------------------------------------

//Usando no modulo Construtores e para o Curos.cs

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace ExemplosExplorando.Models
// {
//     public class Curso
//     {
//         public string Nome { get; set; }
//         public List<Pessoa> Alunos { get; set; } //Lista de alunos 
//         public void AdicionarAluno(Pessoa aluno) //Metodo que a ação não precisa de retorno
//         {
//             Alunos.Add(aluno);
//         }
//         public int ObterQuantidadesDeAlunos() //Metodo de retorno = precisa retornar alguma informação, sem argumento
//         {
//             int quantidade = Alunos.Count;
//             return quantidade; //Todo metodo de retorno tem que ter "return"
//         }
//         public bool RemoverAluno(Pessoa aluno)
//         {
//             return Alunos.Remove(aluno);
            
//         }
//         public void ListarAluno()
//         {
//             Console.WriteLine($"Alunos do curso de {Nome}");
//             foreach (Pessoa aluno in Alunos)
//             {
//                 Console.WriteLine(aluno.NomeCompleto);
//             }
//         }
//     }
// }