using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// ------------------------------------------------------------------------------------------------------------

//

// ------------------------------------------------------------------------------------------------------------

//Menu interativo - C# usando while 

// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {

//     Console.Clear();
//     Console.WriteLine("Digite a sua opção");
//     Console.WriteLine("1- Cadastrar cliente");
//     Console.WriteLine("2- Buscar cliente");
//     Console.WriteLine("3- Apagar cliente");
//     Console.WriteLine("4- Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
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
