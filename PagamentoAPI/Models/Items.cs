using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagamentoAPI.Models
{
    public class Items
    {
        public int ID {get; set;}
        public string Nome {get; set;}
        public int Quantidade {get; set;}
        public decimal Valor {get; set;}

        public int VendaID {get; set;}
    }
}