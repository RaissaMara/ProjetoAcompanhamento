using ProjetoAcompanhamento.Models;

namespace ProjetoAcompanhamento.Repositories
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> ListarTodos();//Promete devolver uma lista de objetos tipo:livros

        Task Adicionar(Livro livro); // Regra para criar novos registros de livros
    }
}
