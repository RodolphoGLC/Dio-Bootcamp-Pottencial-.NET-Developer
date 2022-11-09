using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrilhaApiDesafio.Context;
using PagamentoAPI.Models;

namespace PagamentoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly PagamentoContext _context;

        public VendaController(PagamentoContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult ObterVendaID (int id)
        {
            var vendas = _context.vendas.Find(id);

            if(vendas == null)
                return NotFound();
            
            var vendedor = _context.vendedor.Find(vendas.VendedorId);
            
            if (vendedor == null)
                return NotFound();

            var itens = _context.item.Where(i => i.VendaID == vendas.ID).ToList();

            Construtor.Geral.Response.Venda fVenda = new Construtor.Geral.Response.Venda()
            {
                VendaID = vendas.ID,
                Data = vendas.Data,
                Status = vendas.Status,
                vendedor = new Construtor.Geral.Vendedor()
                {
                    CPF = vendedor.CPF,
                    Nome = vendedor.Nome,
                    Telefone = vendedor.Telefone,
                    Email = vendedor.Email,
                }
            };
            foreach (Items item in itens)
            {
                fVenda.Items.Add(new Construtor.Geral.Items()
                {
                    Nome = item.Nome,
                    Quantidade = item.Quantidade,
                    Valor = item.Valor
                });
            }
            return Ok(fVenda);
        }
        [HttpPost]
    public IActionResult Criar(Construtor.Geral.Request.CriarVenda venda)
    {
      List<string> error = new List<string>();
      if (venda != null)
      {
        if (venda.vendedor != null && venda.vendedor.Nome.Length > 0 && venda.vendedor.CPF.Length > 0 && venda.vendedor.Telefone.Length > 0)
        {
          if (venda.items.Count == 0)
          {
            error.Add("Informe pelo meno um item vendido!");
          }
        }
        else
        {
          error.Add("Informe os dados do vendedor!!");
        }
      }
      else
      {
        error.Add("Os parâmetros não foram informados!!");
      }

      if (error.Count > 0)
      {
        return BadRequest(new { Erro = string.Join(", ", error) });
      }
      else
      {
        Venda vendaBanco = new Venda()
        {
          Data = venda.Data,
          Status = "Aguardando pagamento",

          vendedor = new Vendedor()
          {
            Nome = venda.vendedor.Nome,
            CPF = venda.vendedor.CPF.Replace(" ", "").Replace(".", "").Replace("-", ""),
            Email = venda.vendedor.Email,
            Telefone = venda.vendedor.Telefone
          }
        };

        _context.vendas.Add(vendaBanco);
        _context.SaveChanges();

        foreach (Construtor.Geral.Items item in venda.items)
        {
          _context.item.Add(new Items()
          {
            Nome = item.Nome,
            Quantidade = item.Quantidade,
            Valor = item.Valor,
            VendaID = vendaBanco.ID
          });
        }

        _context.SaveChanges();

        return Ok(vendaBanco.ID);
      }
    }

    [HttpPost("AlterarStatus")]
    public IActionResult AlterarStatus(Construtor.Geral.Request.AlterarStatus req)
    {
      var Venda = _context.vendas.Find(req.VendaID);
      if (Venda == null)
        return NotFound("O Id não foi encontrado");

      switch (req.Status)
      {
        case "Pagamento aprovado":
          if (!Venda.Status.Equals("Aguardando pagamento"))
          {
            return BadRequest(new { Erro = "Sua venda precisa estar no status [Aguardando pagamento] para poder ser alterada para este novo status" });
          }
          else
          {
            Venda.Status = req.Status;
          }
          break;

        case "Cancelada":
          if (!Venda.Status.Equals("Aguardando pagamento"))
          {
            return BadRequest(new { Erro = "Sua venda precisa estar no status [Aguardando pagamento] para poder ser alterada para este novo status" });
          }
          else if (!Venda.Status.Equals("Pagamento aprovado"))
          {
            return BadRequest(new { Erro = "Sua venda precisa estar no status [Pagamento aprovado] para poder ser alterada para este novo status" });
          }
          else 
          {
            Venda.Status = req.Status;
          }
          break;

        case "Enviando para a transportadora":
          if (!Venda.Status.Equals("Pagamento aprovado"))
          {
            return BadRequest(new { Erro = "Sua venda precisa estar no status [Pagamento aprovado] para poder ser alterada para este novo status" });
          }
          else
          {
            Venda.Status = req.Status;
          }
          break;

        case "Entregue":
          if (!Venda.Status.Equals("Enviado para a transportadora"))
          {
            return BadRequest(new { Erro = "Sua venda precisa estar no status [Enviado para a transportadora] para poder ser alterada para este novo status" });
          }
          else
          {
            Venda.Status = req.Status;
          }
          break;
        case "Finalizada":
          if (!Venda.Status.Equals("Entregue"))
          {
            return BadRequest(new { Erro = "Sua venda precisa estar no status [Entregue] para poder ser alterada para este novo status" });
          }
          else
          {
            Venda.Status = req.Status;
          }
          break;

        default:
          return BadRequest(new { Erro = "Informe um estatus válido: [Pagamento aprovado, Enviado para a transportadora, Entregue ou Cancelada]" });
      }

      _context.vendas.Update(Venda);
      _context.SaveChanges();

      return Ok(Venda);
    }

    }
}