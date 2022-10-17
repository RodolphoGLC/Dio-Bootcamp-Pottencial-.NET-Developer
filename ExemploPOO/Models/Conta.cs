using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Foi herdada na Classe Corrente.cs

namespace ExemploPOO.Models
{
    public abstract class Conta //Classe abstrata que não pode ser usada diretamente, precisa ser herdada
    {
        protected decimal saldo; //protected = protegido contra mudança externa, exceto pelas classes filhas

        public abstract void Creditar(decimal valor); //Metodo abstrato = Terá que ser implementado na filha

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é: {saldo}");
        }
    }
}