// using ExemplosExplorando.Models; - usa-se em todos
// using Newtonsoft.Json; - usa-se em todos

// -----------------------------------------------------------------------------------------------

//Metodo de extenção - Usasse Class IntExtencao.cs

// using ExemplosExplorando.Models;

// int n1 = 20;
// bool par = false;

// par = n1.EhPar();
// string mensagem = "O número " + n1 + " " + "é" + (par ? "par" : "impar");
// Console.WriteLine(mensagem);

// -----------------------------------------------------------------------------------------------

//Classe Generica - Não presisa passar o Tipo na Classe - Usasse a Classe "MeuArray.cs"

// using ExemplosExplorando.Models; 
// using Newtonsoft.Json; 

// MeuArray<int> arrayInt = new MeuArray<int>(); //Classe MeuArray - adicionando o tipo INT
// arrayInt.AdicionarElementoArray(30);
// Console.WriteLine(arrayInt[0]);

// MeuArray<string> arrayString = new MeuArray<string>(); //Classe MeuArray - adicionando o tipo STRING
// arrayString.AdicionarElementoArray("Teste");
// Console.WriteLine(arrayString[0]);

// ------------------------------------------------------------------------------------------------

//Variavel tipo Dinamica - Assume o tipo baseado no valor que ela recebe

// dynamic variavelDinamica = 4; //Assume o tipo INT
// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";//Assume o tipo STRING
// Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// -------------------------------------------------------------------------------------------------

//Tipo Anonimo em coleção - Para criar uma coleção com itens selecionados de uma coleção base

// using ExemplosExplorando.Models;
// using Newtonsoft.Json;

// string conteudoArquivo = File.ReadAllText("Arquivo/vendasD.json"); 

// List<VendaDescentralização> listaVenda = JsonConvert.DeserializeObject<List<VendaDescentralização>>(conteudoArquivo);

// //Lista somente com as propriedades Selecionadas
// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach(var vendas in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {vendas.Produto} e Preço: {vendas.Preco}");
// }

// -------------------------------------------------------------------------------------------------

//Tipo Anonimo - ? 

// //  Variavel      new { Propriedade = Valor };
// var tipoAnonimo = new {Nome = "Rodolpho", Sobrenome = "Coutinho", Altura = 1.80M};

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobreome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);

// -------------------------------------------------------------------------------------------------

//Tipo Null em Arquivos - Usado na Classe "VendaNull.cs"

// using ExemplosExplorando.Models;
// using Newtonsoft.Json;

// string conteudoArquivo = File.ReadAllText("Arquivo/vendasNull.json"); //Cria uma string p/ armazenar o arquivo

// //Cria uma Lista para Deserializar o arquivo e o armazenar na lista
// List<VendaDescentralização> listaVenda = JsonConvert.DeserializeObject<List<VendaDescentralização>>(conteudoArquivo);

// //Escreve a Lista - escrevendo manualmente no Console.WriteLine
// foreach(VendaDescentralização venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.ID}, Produto: {venda.Produto}, " + 
//     $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")} " +
//     $" {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
// }

// -------------------------------------------------------------------------------------------------

//Tipo NULL - O valor não e nem verdadeiro e nem falso, mas sim quer deixou em branco

// bool? desejaReceberEmail = null; //Variável que aceita o valor null -?-

// //IF - tem que ter o HasValue, o Value é para ver se e verdadeiro
// if(desejaReceberEmail.HasValue && desejaReceberEmail.Value) //Ver se a variável terá um valor (não ser nula)
// {
//     Console.WriteLine("O usuário optou por receber e-mail");
// }
// else //Se não tiver valor (ser nula)
// {
//     Console.WriteLine("O usuário não recebeu ou optou por não receber e-mail");
// }

// -------------------------------------------------------------------------------------------------

//Deserializando um objeto - Usado na Classe "VendaDescentralização.cs"

// using ExemplosExplorando.Models;
// using Newtonsoft.Json;

// string conteudoArquivo = File.ReadAllText("Arquivo/vendasD.json"); //Cria uma string p/ armazenar o arquivo

// //Cria uma Lista para Deserializar o arquivo e o armazenar na lista
// List<VendaDescentralização> listaVenda = JsonConvert.DeserializeObject<List<VendaDescentralização>>(conteudoArquivo);

// //Escreve a Lista - escrevendo manualmente no Console.WriteLine
// foreach(VendaDescentralização venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.ID}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
// }

// -------------------------------------------------------------------------------------------------

//Serialização na prática - usado na Classe "Vendas" - Simples

// using ExemplosExplorando.Models;
// using Newtonsoft.Json;

// DateTime dataAtual = DateTime.Now; //Cria a variavel da data atual

// List<Vendas> listaVendas = new List<Vendas>(); //Criando uma lista para armazenar as vendas

// Vendas v1 = new Vendas(1, "Material de escritório", 25.0M, dataAtual); //Criando uma venda
// Vendas v2 = new Vendas(2, "Material de laboratório", 40.0M, dataAtual); //Criando uma venda

// listaVendas.Add(v1); //Adicionando a venda a lista
// listaVendas.Add(v2); //Adicionando a venda a lista


// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented); //Transformando para Json em 1 linha {ID,Produto,Preço}
// //string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented); //Terá quebra de linha entre as variáveis

// File.WriteAllText("Arquivo/vendas.json", serializado); //Armazenou os dados no arquivo .json

// Console.WriteLine(serializado); //Escreverá o serializado

// --------------------------------------------------------------------------------------------------

//If ternario - precisa retornar 2 resultados, baseados em uma condição

// int n1 = 15;
// bool ehpar = false;

// ehpar = n1 % 2 == 0;
// Console.WriteLine($"O número {n1} é " + (ehpar ? "par" : "impar"));
//                                              //IF Ternário

//IF normal

// int n1 = 20;
// if (n1 % 2 == 0)
// {
//     Console.WriteLine($"O número: {n1} é par");
// }
// else
// {
//     Console.WriteLine($"O número: {n1} é impar");
// }

// ----------------------------------------------------------------------------------------------------

/*Tuplas em metodos - No metodo normalmente so se retorna 1 tipo de dado, com as 
tuplas vc pode retornar mais de um tipo - Usa-se na Classe LeituraArquivos.cs*/

//Usando todas as variáveis

// using ExemplosExplorando.Models;

// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhas, quantidadeLinhas) = arquivo.LerArquivo("Arquivo/arquivoLeitura.txt");

// if(sucesso)
// {
//     Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeLinhas);
//     foreach(string itens in linhas)
//     {
//         Console.WriteLine(itens);
//     }
    
// }
// else
// {
//     Console.WriteLine("Não e possível ler o arquivo");
// }

//Caso não usar todas as variáveis vc irá descartar a não usada ("_")

// using ExemplosExplorando.Models;

// LeituraArquivo arquivo = new LeituraArquivo(); //Não usará o int "quantidadeLinhas", logo coloco "_" no lugar

// var (sucesso, linhas, _ /*Descartado*/) = arquivo.LerArquivo("Arquivo/arquivoLeitura.txt");

// if(sucesso)
// {
//     //Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeLinhas);
//     foreach(string itens in linhas)
//     {
//         Console.WriteLine(itens);
//     }
    
// }
// else
// {
//     Console.WriteLine("Não e possível ler o arquivo");
// }

// ----------------------------------------------------------------------------------------------------

//Tuplas - Armazena valores (tipos diferentes), seguindo o arranjo inicial - usa-se ao inves de se criar uma classe

//Formas de se criar uma tupla
// ValueTuple<int,string,string> tupla2 = (1, "Rodolpho", "Coutinho"); //Precisa falar o tipo da variável
// var tupla3 = Tuple.Create(1, "Rodolpho", "Coutinho"); //Não precisa falar o tipo da variável

// (int ID, string Nome, string Sobrenome) tupla = (1, "Rodolpho", "Coutinho"); //Precisa falar o tipo da variável e nomea-la

// Console.WriteLine($"ID: {tupla.ID}"); //Exibirá o int = ID - 1
// Console.WriteLine($"Nome: {tupla.Nome}"); //Exibirá a string = Nome - "Rodolpho"
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}"); //Exibirá a string = Sobrenome - "Coutinho"

// ----------------------------------------------------------------------------------------------------

//Dictionary - Uma coleção onde armazenamos um valor em uma chave - não se pode repetir chaves, já valores você pode

// Dictionary<string, string> estados = new Dictionary<string, string>(); //Cria um dictionary

// estados.Add("SP", "São Paulo"); //Adiciona valores no dictionary - Chave, valor
// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("BA", "Bahia");
// estados.Add("AM", "Amazonas");

// foreach(var itens in estados) //Em vez do "var", pode-se usar "KeyValuePair<string, string>"
// {
//     Console.WriteLine(itens); //Escreve a [Chave, Valor]

//     // Console.WriteLine($"Chave: {itens.Key}"); //Escreve só a chave

//     // Console.WriteLine($"Valor: {itens.Value}"); //Escreve só o valor
// }

// Console.WriteLine("..........");

// Console.WriteLine(estados["RJ"]); //Acessa apenas um Valor

// Console.WriteLine("..........");

// estados.Add("BR", "Rio de Janeiro"); //Pode adicionar o mesmo valor para uma chave diferente

// foreach(var itens in estados) 
// {
//     Console.WriteLine($"Chave: {itens.Key}; Valor: {itens.Value}"); 
// }

// Console.WriteLine("..........");

// estados.Remove("SP"); //Removendo uma chave 

// foreach(var itens in estados) 
// {
//     Console.WriteLine($"Chave: {itens.Key}; Valor: {itens.Value}"); //Escreve só a chave
// }

// Console.WriteLine("..........");

// estados["BR"] = "São Paulo - valor alterado"; //Altera uma chave para um novo Valor

// foreach(var itens in estados) 
// {
//     Console.WriteLine($"Chave: {itens.Key}; Valor: {itens.Value}"); 
// }

// Console.WriteLine("..........");

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Elemento existe: {chave}");
// }else
// {
//     Console.WriteLine($"Elemento não existe, logo é seguro adicionar a chave: {chave}");
// }


// ----------------------------------------------------------------------------------------------------

//Stack - Pilha (1° chegar - último a sair)

// Stack<int> pilha = new Stack<int>(); //Cria uma pilha (de Inteiros)

// pilha.Push(2); //Coloca um objeto no topo da pilha
// pilha.Push(4);
// pilha.Push(8);
// pilha.Push(16);

// foreach(int numero in pilha)
// {
//     Console.WriteLine(numero);
// }

// Console.WriteLine(".........."); //Só para separar, fascilita o entendimento

// pilha.Pop(); //Remove o objeto do topo da pilha

// foreach(int numero2 in pilha)
// {
//     Console.WriteLine(numero2);
// }

// Console.WriteLine(".........."); //Só para separar, fascilita o entendimento

// Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");
// Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");

// foreach(int numero3 in pilha)
// {
//     Console.WriteLine(numero3);
// }

// Console.WriteLine(".........."); //Só para separar, fascilita o entendimento

// pilha.Push(3);
// pilha.Push(6);
// pilha.Push(9);

// foreach(int numero4 in pilha)
// {
//     Console.WriteLine(numero4);
// }

// ----------------------------------------------------------------------------------------------------

//Queue - Fila (1° chegar - 1° sair)

// Queue<int> fila = new Queue<int>(); //Cria uma fila (nesse caso de inteiros)

// fila.Enqueue(2); //Adiciona um valor ao final fila
// fila.Enqueue(4);
// fila.Enqueue(8);
// fila.Enqueue(16);

// foreach(int numero1 in fila)
// {
//     Console.WriteLine(numero1);
// }

// Console.WriteLine(".........."); //Só para separar, fascilita o entendimento

// fila.Dequeue(); //Remove o Primeiro elemento da fila

// foreach(int numero2 in fila)
// {
//     Console.WriteLine(numero2);
// }

// Console.WriteLine(".........."); //Só para separar, fascilita o entendimento

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); //Remove e escreve o elemento retirado.
// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// Console.WriteLine(".........."); //Só para separar, fascilita o entendimento

// foreach(int numero3 in fila)
// {
//     Console.WriteLine(numero3);
// }

// ----------------------------------------------------------------------------------------------------

//Throw - Joga para alguem pegar no catch e tratar a exceção -> usado na Classe ExemploExcecao.cs

// using ExemplosExplorando.Models;

// new ExemploExcecao().Metodo1();

// ---------------------------------------------------------------------------------------------------

// Try Catch Finally - irá informar caso acha uma exceção e gerará uma mensagema

// try //Irá tentar rodar o programa
// {
//     string[] linhas = File.ReadAllLines("Arquivo/arquivoLeitura.txt"); //Se quiser que o Arquivo esteja errado coloque um "_" nele.

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex) //Irá tentar pegar uma exceção do arquivo não encontrado
// {
//     Console.WriteLine($"Ocorreu uma exceção especifica, arquivo não encontrado. {ex.Message}."); //Escreverá uma mensagem especifica
// }
// catch (Exception ex) //Irá tentar pegar uma exceção no programa executado, mas não sabe qual
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}."); //Escreverá uma mensagem genérica
// }
// finally //Irá executar uma ação, independente se houver ou não uma exceção.
// {
//     Console.WriteLine("Chegou até aqui");
// }

// ----------------------------------------------------------------------------------------------------

// Realizando a leitura dos aqruivos

// string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

// foreach(string linha in linhas)
// {
//     Console.WriteLine(linha);
// }

// -----------------------------------------------------------------------------------------------------

//DataTime com TryParse

// using System.Globalization;

// string dataString = "22/13/2022 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }

// ----------------------------------------------------------------------------------------------------

//DataTime

// using System.Globalization;

// DateTime data = DateTime.Now; //Data e hora de agora

// Console.WriteLine(data); //Data e hora de agora ("dd/MM/yyyy HH:mm:ss") //HH formato 24 horas - hh formato 12 horas

// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); //Data normal e Hora sem os segundos

// ---------------------------------------------------------------------------------------------------

//Personalização que se podem usar

// using System.Globalization;

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); 
// decimal valorMonetario = 82.40M; 

// Console.WriteLine(valorMonetario.ToString("N2")); //N2 = duas casas decimais 

// double porcentagem = .3406;

// Console.WriteLine(porcentagem.ToString("P")); //P = porcentagem

// int data = 09102022;

// Console.WriteLine(data.ToString("##/##/####")); //# - e o numero, ##/##/#### - formatação data

// -------------------------------------------------------------------------------------------------

//Outra moeda, mas a cultura do sistema sendo outra

// using System.Globalization;

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); //Alteran a localização do sistema para os EUA

// decimal valorMonetario = 82.40M; //O decimal tem  que ter o M apos o valor

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); 
//Alterou o sistema para o Americano, mas voltou para o Brasileiro

// -------------------------------------------------------------------------------------------------

//Outras moedas

// using System.Globalization;

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); //Alteran a localização do sistema para os EUA

// decimal valorMonetario = 82.40M; //O decimal tem  que ter o M apos o valor

// Console.WriteLine($"{valorMonetario:C}"); //:C => formata para a moeda, Aqui será em dolar

//-----------------------------------------------------------------------------------------------------

//Moeda local

// decimal valorMonetario = 82.40M; //O decimal tem  que ter o M apos o valor

// Console.WriteLine($"{valorMonetario:C}"); //:C => formata para a moeda, de acordo com o sistema

//------------------------------------------------------------------------------------------------------

//Exemplo concatenação e interpolação com seus resultados

// Console.WriteLine("Junção de strings");

// string ns1 = "10";
// string ns2 = "20";

// string rs = ns1 + ns2; //r = 1020

// Console.WriteLine(rs);

// Console.WriteLine("Junção de ints");

// int ni1 = 10;
// int ni2 = 20;

// int ri = ni1 + ni2; //r = 30

// Console.WriteLine(ri);

// Console.WriteLine("Junção de strings");

// string nsi1 = "10";
// int nsi2 = 20;

// string rsi = nsi1 + nsi2; //r = 1020

// Console.WriteLine(rsi);

// -------------------------------------------------------------------------------------------------

//Sei lá

// Pessoa p1 = new Pessoa(nome: "Rodolpho", sobrenome: "Coutinho"); //Modificado devido ao Construtor
// // p1.Nome = "Rodolpho";  //2° Construtor
// // p1.Sobrenome = "Coutinho"; //2° Construtor

// Pessoa p2 = new Pessoa(nome: "Ramilo", sobrenome: "Neves"); //Modificado devido ao Construtor
// // p2.Nome = "Ramilo"; //2° Construtor
// // p2.Sobrenome = "Neves"; //2° Construtor

// Curso cursoDeIngles = new Curso(); //Como criamos new Curso
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>(); //precisamos de uma nova lista

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);

// cursoDeIngles.ListarAluno();

//---------------------------------------------------------------------------------------------------

//Usado no modulo Construtores

// using ExemplosExplorando.Models;

// Pessoa p1 = new Pessoa(nome: "Rodolpho", sobrenome: "Coutinho"); //Modificado devido ao Construtor
// // p1.Nome = "Rodolpho";  //2° Construtor
// // p1.Sobrenome = "Coutinho"; //2° Construtor

// Pessoa p2 = new Pessoa(nome: "Ramilo", sobrenome: "Neves"); //Modificado devido ao Construtor
// // p2.Nome = "Ramilo"; //2° Construtor
// // p2.Sobrenome = "Neves"; //2° Construtor

// Curso cursoDeIngles = new Curso(); //Como criamos new Curso
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>(); //precisamos de uma nova lista

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);

// cursoDeIngles.ListarAluno();


// -----------------------------------------------------------------------------------------------
// Usado na Classe "Curso.cs

// using ExemplosExplorando.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Rodolpho"; 
// p1.Sobrenome = "Coutinho";

// Pessoa p2 = new Pessoa();
// p2.Nome = "Ramilo"; 
// p2.Sobrenome = "Neves";

// Curso cursoDeIngles = new Curso(); //Como criamos new Curso
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>(); //precisamos de uma nova lista

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);

// cursoDeIngles.ListarAluno();


// ----------------------------------------------------------------------------------------------------------

//Codigo usado para a Classe Pessoa.cs

// using ExemplosExplorando.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Rodolpho"; //Se vazio, dará uma excessão
// p1.Idade = 20; //Se menor que 0, dará uma excessão
// p1.Sobrenome = "Coutinho";

// p1.Apresentar();

//Parte do desconstrutor - descontruir o que construiu anteriormente 

// Pessoa p1 = new Pessoa ("Rodolpho", "Coutinho"); //Construtor

// (string nome, string sobrenome) = p1; //Desconstrutor

// Console.WriteLine($"{nome} {sobrenome}");