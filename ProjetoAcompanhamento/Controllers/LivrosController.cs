using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoAcompanhamento.Controllers
{
    [Route("api/[controller]")] // api/livros
    [ApiController]
    public class LivrosController : ControllerBase
    {
        [HttpGet]

        public IActionResult GetLivros() 
        {
            var LivrosFalsos = new List<string> 
            {
              "O Senhor dos Aneis",
              "Varity",
              "Memorias de subsolo",
              "O manisfesto comunista"
            };

            return Ok(LivrosFalsos);
        }

        [HttpGet("Saudacao")]

        public IActionResult GetSaudacao() 
        {
            return Ok("Boas vindas ao sistema");
        }

    }
}
