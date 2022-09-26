using Dio_Bootcamp_Pottencial_.NET_Developer.Models;

// ------------------------------------------------------------------------------------------------------------

//Amanhã comece aqui, mantenha o padrão.

// ------------------------------------------------------------------------------------------------------------

//Operadore condicionais: Exxemplo checagem de valores, de verdadeiro e falso e frase

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

//Valor maximo e minimo de uma variavel numérica 

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

//Parte do codigo usada para completar o PessoaFisica.cs
//using Dio_Bootcamp_Pottencial_.NET_Developer.Models;

//PessoaFisica p1 = new PessoaFisica();

//p1.Nome = "Rodolpho";
//p1.Idade = 20;
//p1.Apresentar();

// ------------------------------------------------------------------------------------------------------------
