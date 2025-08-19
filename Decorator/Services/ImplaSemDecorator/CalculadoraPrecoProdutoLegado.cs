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
        
        logger.LogInformation("\n Cálculo finalizado (versão legado) Preço final {PrecoFinal} ####\n", precoFinal);
        return precoFinal;
    }
}