namespace Decorator.Services.Abstractions;

public class CalculadoraPrecoBaseDecorator(ICalculadoraPrecoProduto calculadora) : ICalculadoraPrecoProduto
{
    public virtual decimal Calcular(int produtoId)
    {
        return calculadora.Calcular(produtoId);
    }
}