using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente (int numeroConta, decimal saldoInicial) //Construtor
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        
        public int NumeroConta { get; set; }  
        private decimal saldo; //Encapsulou, usando o private: bloqueado para alterações externas
        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior do que o saldo disponivel");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine("Saldo disponivel para sacar é: " + saldo);
        }
    }
}