using ProjetoAcompanhamento.Data;
using ProjetoAcompanhamento.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoAcompanhamento.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        //Variavel banco de dados
        private readonly AppDbContext _context;

        public LivroRepository(AppDbContext context)
        {
            _context = context;
        }
        
        //Retornar todos os livros do banco com onome da categoria ao inves do ID
        public async Task<IEnumerable<Livro>> ListarTodos()
        {
            return await _context.Livros
                .Include(l => l.Categoria)
                .ToListAsync();
        }
        //Salvar no banco
        public async Task Adicionar(Livro livro)
        {
            await _context.Livros.AddAsync(livro);
            await _context.SaveChangesAsync();
        }
    }
}
