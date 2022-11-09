using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagamentoAPI.Construtor
{
    public class Geral
    {
        public class Request
        {
            public class CriarVenda
            {
                public Vendedor vendedor {get; set;}
                public DateTime Data {get; set;}
                public List<Items> items {get; set;}
            }

            public class AlterarStatus
            {
                public int VendaID {get; set;}
                public string Status {get; set;}
            }
        }

        public class Response
        {
            public class Venda
            {
                public int VendaID {get; set;}
                public DateTime Data {get; set;}
                public string Status {get; set;}
                public Vendedor vendedor {get; set;} = new Vendedor();
                public List<Items> Items {get; set;} = new List<Items>();
            }
        }

        public class Items
        {
            public string Nome {get; set;}
            public int Quantidade {get; set;}
            public decimal Valor {get; set;}
        }

        public class Vendedor
        {
            public string CPF {get; set;}
            public string Nome {get; set;}
            public string Telefone {get; set;}
            public string Email {get; set;}
        }
    }
}