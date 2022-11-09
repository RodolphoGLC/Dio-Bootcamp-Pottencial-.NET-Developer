using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PagamentoAPI.Models;

namespace TrilhaApiDesafio.Context
{
    public class PagamentoContext : DbContext
    {
        public PagamentoContext(DbContextOptions<PagamentoContext> options) : base(options)
        {
            
        }

        public DbSet<Items> item { get; set; }
        public DbSet<Venda> vendas { get; set; }
        public DbSet<Vendedor> vendedor { get; set; }
    }
}