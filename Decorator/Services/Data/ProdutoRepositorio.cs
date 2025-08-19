using Decorator.Entities;

namespace Decorator.Data;

public class ProdutoRepositorio
{
    public static readonly List<Produto> _produtos = new List<Produto>
    {
        new Produto { Id = 1, Nome = "Notebook Xpert", PrecoBase = 4000m },
        new Produto { Id = 2, Nome = "Mouse Gamer", PrecoBase = 100m },
        new Produto { Id = 3, Nome = "Teclado Mecânico", PrecoBase = 150m },
        new Produto { Id = 4, Nome = "Monitor 27\"", PrecoBase = 2000m },
        new Produto { Id = 5, Nome = "Fone de Ouvido", PrecoBase = 80m },
    };

    public Produto? ObterPorId(int id) => _produtos.FirstOrDefault(p => p.Id == id);
}