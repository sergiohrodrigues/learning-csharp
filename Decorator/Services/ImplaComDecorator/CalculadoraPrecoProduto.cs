using Decorator.Data;
using Decorator.Services.Abstractions;

namespace Decorator.Services.ImplaComDecorator;

public class CalculadoraPrecoProduto(ProdutoRepositorio repositorio) : ICalculadoraPrecoProduto
{
    public decimal Calcular(int produtoId)
    {
        var produto = repositorio.ObterPorId(produtoId)
            ?? throw new Exception("Produto no encontrado");

        return produto.PrecoBase;
    }
}