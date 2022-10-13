using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// ------------------------------------------------------------------------------------------------------

//Desafios de Código Intermediário C# - Pottencial - 1 / 3 - Elemento Majoritário

//using System;
// using System.Text.RegularExpressions;

// public class Program
// {
//     public static void Main(String[] args)
//     {
//         int n = int.Parse(Console.ReadLine());
        
//         int[] num = new int[n];
    
// // TODO: Crie as outras condições necessárias para a resolução do desafio:
//         for (int i = 0; i < n; i++)
//         {
//             num[i] = int.Parse(Console.ReadLine());
//         }
//         Console.WriteLine(MajorityElement(num));
        
//     }
//     public static int MajorityElement(int[] nums)
//     {
//         int major = nums[0];
//         int count = 1;
//         for (int i = 0; i < nums.Length; i++)
//         {
//             if (major != nums[i])
//             {
//                 major = nums[i];
//                 count = 1;
//             }
//             else
//             {
//                 if (major == nums[i])
//                 {
//                     count++;
//                 }
//                 else
//                 {
//                     count--;
//                 }
//             }
//         }
//         return major;
//     }
// }

// ------------------------------------------------------------------------------------------------------

//Desafios de Código Intermediário C# - Pottencial - 2 / 3 - Aumento de Salário

// using System;  


// class minhaClasse { 


//   static void Main(string[] args) {  


//     double salario = 0.00; 
//     double reajuste = 0.00; 
//     double novoSalario = 0.00; 
//     double percentual = 0.00; 
  
//     salario = Convert.ToDouble(Console.ReadLine()); 
   
//     if( salario < 0.0 ) { 
//       return; 

//     } else if ( salario >= 0.0 && salario <= 400.00 ) { 
//       percentual = 15.0/100.00; 
//       reajuste = salario * percentual; 
//       novoSalario = reajuste + salario; 

//     } else if ( salario > 400.00  && salario <= 800.00) { 
//       percentual = 12.0/100.00; 
//       reajuste = salario * percentual;         
//       novoSalario = reajuste + salario; 

//     } else if ( salario > 800.00  && salario <= 1200.00) { 
//       percentual = 10.0/100.00; 
//       reajuste = salario * percentual; 
//       novoSalario = reajuste + salario; 

//     } else if (salario > 1200.00  && salario <= 2000.00) { 
//       percentual = 7.0/100.00; 
//       reajuste =  salario * percentual; 
//       novoSalario =  reajuste + salario; 

//     } else { 
//       percentual = 4.0/100.00; 
//       reajuste = salario * percentual ; 
//       novoSalario =reajuste + salario  ; 
//     } 
//     Console.WriteLine("Novo salario: {0:0.00}",  novoSalario); 
//     Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste); 
//     Console.WriteLine("Em percentual: {0} %", percentual*100.00); 
//   } 
// }

// ------------------------------------------------------------------------------------------------------

//Desafios de Código Intermediário C# - Pottencial - 3 / 3 - A Corrida de Tartarugas

// using System;

// class Desafio 
// {
//   public static void Main() 
//   {
//     int quantidadeEntradas = 3;
      
//     while (quantidadeEntradas > 0) 
//     {
//       var numeroQuantidade = Int32.Parse(Console.ReadLine());
        
//       if (numeroQuantidade >= 1 && numeroQuantidade <= 500) 
//       {
//         string[] tartarugas = Console.ReadLine().Split(" ");
//         var maiorVelocidade = Int32.Parse(tartarugas[0]);
          
// // TODO: Crie as outras condições necessárias para a resolução do desafio:
//         for (int i = 0; i < numeroQuantidade; i++) 
//         {
//           var tartaruga = Int32.Parse(tartarugas[i]);
            
//           if (tartaruga > maiorVelocidade) 
//           {
//             maiorVelocidade = tartaruga;
//           }
//         }

//         if(maiorVelocidade < 10) 
//         {
//           Console.WriteLine(1);
//         } 
//         else if (maiorVelocidade >= 10 && maiorVelocidade < 20) 
//         {
//           Console.WriteLine(2);
//         } 
//         else if (maiorVelocidade >= 20) 
//         {
//           Console.WriteLine(3);
//         }
//         quantidadeEntradas--;
//       } 
//       else 
//       {
//         Console.WriteLine("Insira um número entre 1 e 500");
//       }
//     }
//   }
// }