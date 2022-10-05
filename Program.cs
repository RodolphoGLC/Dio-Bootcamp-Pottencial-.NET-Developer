// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DIO_Potenciall;

// ------------------------------------------------------------------------------------------------------------

using System.IO;
using System.Linq;
using System;
class Program {
    static void Main(string[] args) {
    
    int qt = int.Parse(Console.ReadLine());
    string[] v = new string[2];

        for (int i = 0; i < qt; ++i) {
            v = Console.ReadLine().Split(" ");
            string a = v[0];
            string b = v[1];

            if (b.Length > a.Length)
            {
            Console.WriteLine("nao encaixa");
            }
            else if (a.EndsWith(b))
            {
            Console.WriteLine("encaixa");
            }
            else
            {
            Console.WriteLine("nao encaixa");
            }
        }
    }
}

// ------------------------------------------------------------------------------------------------------------

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

//------------------------------------------------------------------------------------------------------------

//Menu interativo - C# usando while 

// string caso = "A";
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção");
//     Console.WriteLine("1- Cadastrar cliente");
//     Console.WriteLine("2- Buscar cliente");
//     Console.WriteLine("3- Apagar cliente");
//     Console.WriteLine("4- Encerrar");

// caso = Console.ReadLine();

//     switch(caso)
//     {
//         case "1":
//             Console.WriteLine("Cadastro do cliente");
//             break;
//         case "2":
//             Console.WriteLine("Buscar cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false; //Continua exibindo enquanto true, quando false não exibirá
//             //Environment.Exit(0); -> sair de vez
//             break;
            
//         default:
//             Console.WriteLine("Opção invalida");
//             break;
//     }

// }

// ------------------------------------------------------------------------------------------------------------

// Do While

// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Escrea um numero (zero para a soma)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// }while(numero != 0);
//     Console.WriteLine($"Soma dos números e igual a {soma}");

// ------------------------------------------------------------------------------------------------------------

//Break de While e For em alguma condição de trava.

// int numero = 5;
// int contador = 0;

// while(contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++; 

//     if(contador == 5)
//     {
//         break;
//     }
// }

// ------------------------------------------------------------------------------------------------------------

//While: Mais simples por so ter uma codição - (condição) {contador}

// int numero = 5;
// int contador = 0;

// while(contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++; 
// }

// ------------------------------------------------------------------------------------------------------------

//Usando o For para fazer um contador - For: (variavel;condição;contador)

// int numero = 5;


// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// ------------------------------------------------------------------------------------------------------------

//Incremento (++) e decremento (--).

// int numero = 10;
// Console.WriteLine("Incrementar em 10");
// numero++;
// Console.WriteLine($"{numero}");

// ------------------------------------------------------------------------------------------------------------

//Operadores Lógicos: || (Pipe) = Or; && (And) = E; Not = ?;

//Not - Inverte uma condição

// bool estaChovendo = false;
// bool estaTarde = false;

// if (!estaChovendo && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar.");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia.");
// }

//And - Se uma for falsa, o total será falso 

// bool presencaMinima = true;
// bool mediaMaiorQue7 = false;

// if (presencaMinima && mediaMaiorQue7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }

//Or - Se qualquer 1 for verdadeiro, tudo será verdadeiro.

// bool maiorDeIdade = true;
// bool possuiAltorizacao = true;

// if (maiorDeIdade || possuiAltorizacao)
// {
//     Console.WriteLine("Entrada Liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada Negada.");
// }

// ------------------------------------------------------------------------------------------------------------

//Switch case: usado para quando temos muitos else if => deixará o código mais legivel.

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("É uma vogal.");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal.");
//         break;
// }

// ------------------------------------------------------------------------------------------------------------

//Operadores condicionais: exemplo de mais de um if

// int quantidadeEmEstoque = 10;
// int quantidadeDeVenda = 0;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeDeVenda;
//  -> também e possível alterar a variavel Bool para:
//     --> bool possivelVenda = quantidadeDeVenda > 0 && quantidadeEmEstoque >= quantidadeDeVenda;
//         ---> Esse && diz que ambos tem que serem cumpridos um e outro.

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}.");
//  Console.WriteLine($"Quantidade de venda: {quantidadeDeVenda}.");
//  Console.WriteLine($"A venda é possivel de ser realizada? {quantidadeEmEstoque >= quantidadeDeVenda}");

// if (quantidadeDeVenda == 0) //No caso de alterar o bool, não precisará desse if
// {
//     Console.WriteLine("Venda inválida.");
// }
//  else if (possivelVenda)
//  {
//      Console.WriteLine("Venda realizada");
//  }
// else
// {
//      Console.WriteLine("Desculpe, nós não temos essa quantidade em estoque.");
// }

// ------------------------------------------------------------------------------------------------------------

//Operadores condicionais: Exemplo checagem de valores, de verdadeiro e falso e frase

// int quantidadeEmEstoque = 10;
// int quantidadeDeVenda = 25;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeDeVenda;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}.");
// Console.WriteLine($"Quantidade de venda: {quantidadeDeVenda}.");
// Console.WriteLine($"A venda é possivel de ser realizada? {quantidadeEmEstoque >= quantidadeDeVenda}");

// if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada");
// }
// else
// {
//     Console.WriteLine("Desculpe, porém não temos essa quantidade em estoque.");
// }

// ------------------------------------------------------------------------------------------------------------

//Operadores condicionais: exemplo vendas

// int quantidadeEmEstoque = 10;
// int quantidadeDeVenda = 25;

// if(quantidadeEmEstoque >= quantidadeDeVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else 
// {
//     Console.WriteLine("Desculpe, porém não temos essa quantidade em estoque.");
// }

// ------------------------------------------------------------------------------------------------------------

//Valor máximo e mínimo de uma variavel numérica 

//int a = int.MaxValue;
//int a = int.MinValue;

// Console.WriteLine(inteiro);

// ------------------------------------------------------------------------------------------------------------

//Converter qualquer uma para string, pq a string está presente em todas as variaveis

// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(inteiro);

// ------------------------------------------------------------------------------------------------------------

//Conversão de string para inteiro 2 jeitos 

//int a = Convert.ToInt32("5"); //para uma especifica, aplicavel para valores nulos (null) = Use esse  
//int a = Parse("5"); //para a que se pede antes, valores nulos (null) darão erros

//Console.WriteLine(a);

// ------------------------------------------------------------------------------------------------------------

//Exemplo de soma 
// int a = 25;
// int b = 40;
// int c = a + b;

// c = c + 5; //Vai alterar o valor final de c, o novo será (a+b)+5. Antigo valor de c + 5
// c += 5; faz a mesma função do acima
// Console.WriteLine(c);

// ------------------------------------------------------------------------------------------------------------

//Aprendendo sobre variaveis e classes - Ctrl + k + c + parte do codigo selecionada = Comentar tudo
// string apresentação = "Olá seja bem vindo.";
// int quantidade = 1;
// double valor = 1.80;
// decimal preço = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentação);
// Console.WriteLine("Valor da variavel quantidade: " + quantidade);
// Console.WriteLine("Valor da variavel valor: " + valor);
// Console.WriteLine("Valor da variavel preço: " + preço);
// Console.WriteLine("Valor da variavel condicao: " + condicao);

// ------------------------------------------------------------------------------------------------------------
