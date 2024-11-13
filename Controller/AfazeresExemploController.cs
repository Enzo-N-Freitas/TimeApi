using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeApi.Models;
using TimeApi.Models.Enums;

namespace TimeApi.Controller
{
    [ApiController]
    [Route("[Controller]")]
    public class AfazeresExemploController : ControllerBase
    {
        private static List<Afazeres> afazeres = new List<Afazeres>()
        {
            new Afazeres() { Id = 1, NomeAfazer = "Limpar a Casa", Descricao = "Varrer o chão, lavar o banheiro e tirar pó das estantes", TipodeAfazer=TipodeAfazerEnum.Domestico },
            new Afazeres() { Id = 2, NomeAfazer = "Terminar Apresentação", Descricao = "Terminar a apresentação para a equipe da empresa", TipodeAfazer=TipodeAfazerEnum.Trabalho },
            new Afazeres() { Id = 3, NomeAfazer = "Terminar a API", Descricao = "Finalizar a API da aula de DS e entregar no prazo", TipodeAfazer=TipodeAfazerEnum.Estudo }
        };

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(afazeres.FirstOrDefault(af => af.Id == id));
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(afazeres);
        }

        [HttpPost("NovoAfazer")]
        public IActionResult AddAfazeres(Afazeres novoAfazeres)
        {
            afazeres.Add(novoAfazeres);
            return Ok(afazeres);
        }
    }
}