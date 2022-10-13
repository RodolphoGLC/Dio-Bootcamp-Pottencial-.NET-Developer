// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace ExemplosExplorando.Models
// {
//     public class ExemploExcecao
//     {
//         public void Metodo1()
//         {
//             Metodo2();
//         }

//         public void Metodo2()
//         {
//             try 
//             {
//                 Metodo3();
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine($"Exceção tratada. {ex.StackTrace}"); //StrackTrace, fornecerá todo o caminho em que a exceção percorreu
//             }
//         }

//         public void Metodo3()
//         {
//             Metodo4();
//         }

//         public void Metodo4()
//         {
//             throw new Exception("Ocorreu uma exceção."); //Joga para cima, para alguem tratar a exceção.
//         }
//     }
// }