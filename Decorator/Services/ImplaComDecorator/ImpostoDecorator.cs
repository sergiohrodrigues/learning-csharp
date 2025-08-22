using Decorator.Entities;
using Decorator.Services.Abstractions;

namespace Decorator.Services.ImplaComDecorator;

public class ImpostoDecorator(ICalculadoraPrecoProduto calculadora) : CalculadoraPrecoBaseDecorator(calculadora)
{
    public override decimal Calcular(int produtoId)
    {
        var precoAntesDoImposto = base.Calcular(produtoId);
        var precoComImposto = precoAntesDoImposto * 1.10m;
        return precoComImposto;
    }
}