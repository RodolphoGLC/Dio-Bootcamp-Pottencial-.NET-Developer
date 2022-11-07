//Controller - Disponibilizará os end-points 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Aceita o : ControllerBase
using Microsoft.AspNetCore.Mvc;

namespace ModuloAPI.Controllers
{
    //Para criar o controller precisa por isso
    [ApiController]
    [Route("[controller]")]

    public class UsuarioController : ControllerBase
    {
        //Como chamar no program
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            //Objeto anônimo 
            var obj = new 
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToLongTimeString(),
            };

            //Retorno do objeto anônimo
            return Ok(obj);
        }

        [HttpGet("Apresentar/{nome}")] //Como colocou o /{nome}, fará com que o nome passe a ser obrigatório e terá de ser preenchido
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá {nome}, sejá bem vindo.";
            return Ok(mensagem);
        }
    } 
}