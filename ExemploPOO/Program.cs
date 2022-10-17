









//Classe Abstrata = usasse Classes "Calculadora.cs e ICalculadora.cs"

using ExemploPOO.Models;
using ExemploPOO.Interfaces;

ICalculadora calc = new Calculadora(); //Interface que cria uma nova calculadora
//Pq a interface ICalculadora implementa a Calculadora

Console.WriteLine(calc.Somar(2, 1));
Console.WriteLine(calc.Subtrair(6, 3));
Console.WriteLine(calc.Multiplicar(3, 1));
Console.WriteLine(calc.Dividir(9, 3));


// ---------------------------------------------------------------------------------------------

//Classe Abstrata = usasse Classes "Conta.cs e Corrente.cs"

// using ExemploPOO.Models;

// Corrente c = new Corrente();
// c.Creditar(500);
// c.ExibirSaldo();

// ---------------------------------------------------------------------------------------------

// Polimporfismo - explicações na classe "Aluno.cs, Professor.cs"

// using ExemploPOO.Models;

// Aluno a1 = new Aluno("Rodolpho", 20, 8);
// Professor p1 = new Professor("Renata", 48, 6000M);

// a1.Apresentar();
// p1.Apresentar();

// ---------------------------------------------------------------------------------------------

//Herança - usa-se as classes "Pessoa.cs, Aluno.cs, Professor.cs"

// using ExemploPOO.Models;

// Aluno a1 = new Aluno("Rodolpho", 20, 8);
// Professor p1 = new Professor("Renata", 48, 6000M);

// a1.Apresentar();
// p1.Apresentar();

// ---------------------------------------------------------------------------------------------

//Encapsulomento - usasse a classe "ContaCorrente.cs"

// using ExemploPOO.Models;

// ContaCorrente c1 = new ContaCorrente(2020, 508);

// c1.ExibirSaldo();
// c1.Sacar(500);
// c1.ExibirSaldo();

// ---------------------------------------------------------------------------------------------

//Abstração - usasse a classe Pessoa.cs

// using ExemploPOO.Models;

// //Abstraindo a Pessoa, falando as suas caracteristicas
// Pessoa p1 = new Pessoa();
// p1.Nome = "Rodolpho Coutinho";
// p1.Idade = 20;

// p1.Apresentar();
