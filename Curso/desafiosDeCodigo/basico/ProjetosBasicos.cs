using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// ------------------------------------------------------------------------------------------------------------

//Desafios de Código Básico C# - Pottencial -1 / 3 - Subtraindo o produto e a soma de um número inteiro

// class DIO {
//         static void Main(string[] args){
//         int n = int.Parse(Console.ReadLine());
//         int p = 1, s = 0;
//         while (n > 0){
//              int l = n % 10;
//             p *= l;
//              s += n % 10;
//              n /= 10;
//            }
//         Console.WriteLine(p-s);
//         }
//     }

// ------------------------------------------------------------------------------------------------------------

//Desafios de Código Básico C# - Pottencial - 2 / 3 - Encaixa ou Não?

// using System.IO;

// class Projeto_2 {
//     static void Main(string[] args) {
    
//     int qt = int.Parse(Console.ReadLine());
//     string[] v = new string[2];

//         for (int i = 0; i < qt; ++i) {
//             v = Console.ReadLine().Split(" ");
//             string a = v[0];
//             string b = v[1];

//             if (b.Length > a.Length)
//             {
//             Console.WriteLine("nao encaixa");
//             }
//             else if (a.EndsWith(b))
//             {
//             Console.WriteLine("encaixa");
//             }
//             else
//             {
//             Console.WriteLine("nao encaixa");
//             }
//         }
//     }
// }

// ------------------------------------------------------------------------------------------------------------

//Desafios de Código Básico C# - Pottencial - 3 / 3 - Três Divisores

// class Solution {
//     public static void Main(string[] args) {
//         int n = int.Parse(Console.ReadLine());
//         int count = 0;
 
//         for (int i = 1; i <= n; i++) {
// // TODO: Crie as outras condições necessárias para a resolução do desafio:
//             if (n % i == 0) {
//                 count++;
//             }
//             if (count > 3) {
//                 Console.WriteLine(false);
//             }
//         }
//          Console.WriteLine(count == 3);
//     }
// }