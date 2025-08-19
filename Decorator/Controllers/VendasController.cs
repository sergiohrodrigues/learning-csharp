using Decorator.Entities;
using Decorator.Services.ImplaSemDecorator;
using Microsoft.AspNetCore.Mvc;

namespace Decorator.Controllers;

[ApiController]
[Route("api/[controller]")]
// Usando primary constrctor para injeção de dependências

public class VendasController(CalculadoraPrecoProdutoLegado calculadoraLegado): ControllerBase
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
}