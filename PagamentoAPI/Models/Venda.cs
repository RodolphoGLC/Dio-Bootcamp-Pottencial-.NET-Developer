using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagamentoAPI.Models
{
    public class Venda
    {
        public int ID {get; set;}
        public DateTime Data {get; set;}
        public string Status {get; set;}
        public int VendedorId {get; set;}

        public Vendedor vendedor {get; set;}
        public List<Items> items {get; set;}
    }
}