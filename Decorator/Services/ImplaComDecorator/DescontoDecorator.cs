using Decorator.Data;
using Decorator.Services.Abstractions;

namespace Decorator.Services.ImplaComDecorator;

public class DescontoDecorator(ICalculadoraPrecoProduto calculadora,
    ProdutoRepositorio repositorio) : CalculadoraPrecoBaseDecorator(calculadora)
{
    public override decimal Calcular(int produtoId)
    {
        var precoCalculado = base.Calcular(produtoId);
        var produto = repositorio.ObterPorId(produtoId);

        if (produto != null && produto.PrecoBase > 1500)
        {
            var precoFinal = precoCalculado * 0.95m; // Aplica 
            return precoFinal;
        }

        return precoCalculado;
    }
}