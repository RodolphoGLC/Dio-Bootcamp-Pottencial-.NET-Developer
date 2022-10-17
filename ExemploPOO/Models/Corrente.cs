using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor) //Tem que ser implementado, metódo abstrato (Conta.cs)
        {
            saldo += valor; //altera o protected saldo, pois está sendo alterado na classe filha
        }
    }
}