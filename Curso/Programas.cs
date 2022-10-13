using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Lista não precisa ter uma capacidade

//Usando .COUNT e .CAPACITY

// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("RJ");

// Console.WriteLine($"Itens da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC"); //Ela duplica a capacidade sozinha
// listaString.Add("MG");

// Console.WriteLine($"Itens da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MG");

// Console.WriteLine($"Itens da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// -----------------------------------------------------------------------------------------------------

//Usando FOR e FOREACH

// Console.WriteLine("Percorrendo o Array com FOR");
// for(int contador = 0; contador < listaString.Count; contador ++)
// {
//     Console.WriteLine($"Posição N° {contador} = {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo o Array com FOREACH");
// int contadorForeach = 0;
// foreach(string itens in listaString)
// {
//     Console.WriteLine($"Posição N° {contadorForeach} = {itens}");
//     contadorForeach++;
// }

// ------------------------------------------------------------------------------------------------------------

// Declarar um Array maior e copiar o antigo para ele

// int[] arrayInteiros = new int[3]; 
// arrayInteiros[0] = 72; 
// arrayInteiros[1] = 61; 
// arrayInteiros[2] = 50; 

// //Criando um novo Array e pegando os valores do Array anterior = Resize, porém um novo Array e criado
// int[] arrayDobrados = new int[arrayInteiros.Length*2];
// Array.Copy(arrayInteiros, arrayDobrados, arrayInteiros.Length);


// Console.WriteLine("Percorrendo o Array com FOR");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} = {arrayInteiros[contador]}");
// }

// ------------------------------------------------------------------------------------------------------------

//Array de inteiros, porém irei redimenciona-lo

// int[] arrayInteiros = new int[3]; //Declarou um array de 3 valores, sem adicionar valores
// arrayInteiros[0] = 72; //Declarando valores para o array - posição 0
// arrayInteiros[1] = 61; //Declarando valores para o array - posição 1
// arrayInteiros[2] = 50; //Declarando valores para o array - posição 2

// //Redimencionando o Array
// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// //Array passou de [3] para [6]
// arrayInteiros[3] = 43; //Declarando valores para o array - posição 3
// arrayInteiros[4] = 32; //Declarando valores para o array - posição 4
// arrayInteiros[5] = 27; //Declarando valores para o array - posição 5

// //Para percorres os valores do array usamos um laço de repetição
// //Condição tem o .Length -> com o intuito de travar o array no seu tamanho máximo

// // Percorrendo o Array com FOR - precisa declarar contador e o seu limite
// Console.WriteLine("Percorrendo o Array com FOR");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} = {arrayInteiros[contador]}");
// }

// ------------------------------------------------------------------------------------------------------------

// Array de inteiro => os arrays são montados no arquivo de Programa.cs (que criou usando o comando)

// int[] arrayInteiros = new int[3]; //Declarou um array de 3 valores, sem adicionar valores
// arrayInteiros[0] = 72; //Declarando valores para o array - posição 0
// arrayInteiros[1] = 61; //Declarando valores para o array - posição 1
// arrayInteiros[2] = 50; //Declarando valores para o array - posição 2

// //Para percorres os valores do array usamos um laço de repetição
// //Condição tem o .Length -> com o intuito de travar o array no seu tamanho máximo

// // Percorrendo o Array com FOR - precisa declarar contador e o seu limite
// Console.WriteLine("Percorrendo o Array com FOR");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} = {arrayInteiros[contador]}");
// }
 
// //Percorrendo o Array com FOREACH - desvantagens não terá a posição, pois não precisa do contador e nem condição
// Console.WriteLine("Percorrendo o Array com FOREACH");
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// }

// //Percorrendo o Array com FOREACH - tirando a desvantagens, criando um contador
// Console.WriteLine("Percorrendo o Array com FOREACH + Contador");
// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição N° {contadorForeach} = {valor}");
//     contadorForeach++;
// }

