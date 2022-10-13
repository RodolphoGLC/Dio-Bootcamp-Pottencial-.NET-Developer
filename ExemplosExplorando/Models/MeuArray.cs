// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace ExemplosExplorando.Models
// {
//     public class MeuArray<T> //O <T> diz ser uma classe genérica
//     {
//         private static int capacidade = 10;
//         private int contador = 0;
//         private T[] array = new T[capacidade];

//         public void AdicionarElementoArray(T elemento)
//         {
//             if(contador + 1 < 11)
//             {
//                 array[contador] = elemento;
//             }
//             contador++;
//         }   

//         public T this[int index] 
//         { 
//             get {return array[index];}
//             set {array[index] = value;} 
//         }
//     }
// }