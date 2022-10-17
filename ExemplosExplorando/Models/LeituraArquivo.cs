// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace ExemplosExplorando.Models
// {
//     public class LeituraArquivo
//     {                                                               //Ler um arquivo que possui um caminho
//         public (bool sucesso, string[] linhas, int quantidadeLinhas) LerArquivo(string caminho) //Tupla como retorno
//         {
//             try 
//             {
//                 string[] linha = File.ReadAllLines(caminho);
//                 return (true, linha, linha.Count());
//             } 
//             catch (Exception)
//             {
//                 return (false, new string[0], 0);
//             }
//         }
//     }
// }