using MediatR;
using Microsoft.AspNetCore.Mvc;
using TechFin.Spotifin.Aplicacao.Assinaturas.Comandos.CriarAssinatura;
using TechFin.Spotifin.Contratos.Assinaturas;

namespace TechFin.Spotifin.API.Controllers;

[ApiController]
[Route("[controller]")]
public class AssinaturasController : ControllerBase
{
    private readonly ISender _mediator;

    public AssinaturasController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CriarAssinaturaAsync(CriarAssinaturaRequest request)
    {
        var comando = new CriarAssinaturaComando(request.TipoAssinatura.ToString(), request.UsuarioId);
        
        var resultado = await _mediator.Send(comando);

        return resultado.MatchFirst(
            assinatura => Ok(new AssinaturaResponse(assinatura.Id, request.TipoAssinatura)),
            erro => Problem()
        );       
    }
}
