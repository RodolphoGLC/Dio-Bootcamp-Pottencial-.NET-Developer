using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

//Faz a ligação com o banco de dados
namespace ModuloAPI.Context
{
    public class AgendaContext : DbContext
    {
        //Construtor que fará referência ao nosso banco de dados
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
        
        }

        //Representará uma tabela a partir do DbSet
        public DbSet<Contato> Contatos 
        { get; set; }
    }
}