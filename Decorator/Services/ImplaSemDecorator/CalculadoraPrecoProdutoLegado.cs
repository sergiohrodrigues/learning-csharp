using Decorator.Data;

namespace Decorator.Services.ImplaSemDecorator;

public class CalculadoraPrecoProdutoLegado(ProdutoRepositorio repositorio, ILogger<CalculadoraPrecoProdutoLegado> logger)
{
    
    public decimal Calcular(int produtoId)
    {
        logger.LogInformation("\n #### Iniciando cálculo de preõ (versão legado) ###\n ...");
        
        var produto = repositorio.ObterPorId(produtoId);

        if (produto is null)
        {
            logger.LogError("Produto com ID {ProdutoId} não encontrado", produtoId);
            throw new Exception("Produto não encontrado");
        }

        decimal precoFinal = produto.PrecoBase;
        logger.LogInformation("Preço base: {PrecoBase}", precoFinal);
        
        // Regra 1: Adicionar imposto (10%)
        decimal imposto = precoFinal * 0.10m;
        precoFinal += imposto;
        logger.LogInformation("Após imposto (10%): {PrecoFinal}", precoFinal);
        
        // NOVA REGRA 1: Desconto Vip para produtos caros
        if (produto.PrecoBase > 1500)
        {
            decimal desconto = precoFinal * 0.05m;
            precoFinal -= desconto;
            logger.LogInformation("Após deconto Vip (10%): {PrecoFinal}", precoFinal);
        }
        
        // NOVA REGRA: Adicionar Frete para produtos abaixo de 200
        if (produto.PrecoBase < 200)
        {
            precoFinal += 15;
            logger.LogInformation("Após frete (R$15): {PrecoFinal})", precoFinal);
        }
        
        logger.LogInformation("\n Cálculo finalizado (versão legado) Preço final {PrecoFinal} ####\n", precoFinal);
        return precoFinal;
    }
}