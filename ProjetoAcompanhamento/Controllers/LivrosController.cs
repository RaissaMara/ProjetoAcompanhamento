using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoAcompanhamento.Repositories;

namespace ProjetoAcompanhamento.Controllers
{
    [Route("api/[controller]")] // api/livros
    [ApiController]
    public class LivrosController : ControllerBase
    {
        //Variavel para acessar ao banco de dados
        private readonly ILivroRepository _repository;

        //Construtor para injetar a dependencia do repositorio
        public LivrosController(ILivroRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _repository.ListarTodos());

        [HttpGet("falsos")]
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
