using Decorator.Entities;
using Decorator.Services.Abstractions;
using Decorator.Services.ImplaSemDecorator;
using Microsoft.AspNetCore.Mvc;

namespace Decorator.Controllers;

[ApiController]
[Route("api/[controller]")]
// Usando primary constrctor para injeção de dependências

public class VendasController(CalculadoraPrecoProdutoLegado calculadoraLegado
, ICalculadoraPrecoProduto calculadoraComDecorator): ControllerBase
{
    [HttpPost("sem-decorator")]
    public IActionResult CalculadoraSemDecorator([FromBody] VendaRequest requisicao)
    {
        try
        {
            var precoFinal = calculadoraLegado.Calcular(requisicao.ProdutoId);
            return Ok(new { resultado = $"Preço final (sem decorator): { precoFinal:C}" });
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPost("com-decorator")]
    public IActionResult CalcularComDecorator([FromBody] VendaRequest requisicao)
    {
        try
        {
            var precoFinal = calculadoraComDecorator.Calcular(requisicao.ProdutoId);
            return Ok(new { resultado = $"Preço final (com decorator): { precoFinal:C}" });
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    
}