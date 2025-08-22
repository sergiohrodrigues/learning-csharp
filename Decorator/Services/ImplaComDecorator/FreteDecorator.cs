using Decorator.Data;
using Decorator.Services.Abstractions;

namespace Decorator.Services.ImplaComDecorator;

public class FreteDecorator(ICalculadoraPrecoProduto calculadora
    , ProdutoRepositorio repositorio
    , ILogger<FreteDecorator> logger) : CalculadoraPrecoBaseDecorator(calculadora)
{
    public override decimal Calcular(int produtoId)
    {
        var precoCalculado = base.Calcular(produtoId);

        // Buscar o produto original para chegar sua propriedade "PrecoBase".
        var produto = repositorio.ObterPorId(produtoId);

        if (produto != null && produto.PrecoBase < 200)
        {
            var precoFinal = precoCalculado + 15;
            logger.LogInformation("Após frete (R$15): {PrecoFinal}", precoFinal);
            return precoFinal;
        }

        return precoCalculado;
    }
}