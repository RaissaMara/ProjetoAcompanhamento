using Microsoft.EntityFrameworkCore;
using ProjetoAcompanhamento.Models;

namespace ProjetoAcompanhamento.Data
{
    public class AppDbContext : DbContext
    {
        // Construtor para receber as configuraçõesdo banco dados

        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) { }
        
        //informaao EF para criar uma tabela chamada "Livros" baseada na classe Livros
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

    }
}
