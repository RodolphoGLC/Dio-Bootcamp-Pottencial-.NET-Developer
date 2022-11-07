using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModuloAPI.Context;
using ModuloAPI.Entities;


namespace ModuloAPI.Controllers
{
    //Para criar o controller precisa por isso
    [ApiController]
    [Route("[controller]")]

    public class ContatoController : ControllerBase
    {
        //Gerador automatico de contexto
        private readonly AgendaContext _context;

        //Construtor para receber o context
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }
        
        //Endpoints que queremos na tabela
        [HttpPost] //Create
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            //return Ok(contato);
            //Retorna o caminho do ID que você criou
            return CreatedAtAction(nameof(ObterID), new {id = contato.ID}, contato);
        }

        [HttpGet("{id}")] //Read
        public IActionResult ObterID(int id)
        {
            //Achar um ID do BD na tabela contatos
            var contato = _context.Contatos.Find(id);

            //Validação para ver se o ID não é nulo
            if (contato == null)
                return NotFound();

            return Ok(contato);
        }

        [HttpGet("ObterPorNome")] //Read
        public IActionResult ObterPorNome(string nome)
        {
            //Achar um ID do BD na tabela contatos
            var contato = _context.Contatos.Where(x => x.Nome.Contains(nome));

            if (contato == null)
                return NotFound();
            return Ok(contato);
        }

        [HttpPut("{id}")] //Update-Replace
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(id);
            
            if (contato == null)
                return NotFound();

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();

            return Ok(contatoBanco);
        }

        //[HttpPatch] //Update-Modifica (pode ser parcilamente)

        [HttpDelete("{id}")] //Delete
        public IActionResult Delete(int id)
        {
            //Achar um ID do BD na tabela contatos
            var contatoBanco = _context.Contatos.Find(id);

            //Validação para ver se o ID não é nulo
            if (contatoBanco == null)
                return NotFound();

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();

            //Retorno sem conteudo
            return NoContent(); 
        }
    }
}