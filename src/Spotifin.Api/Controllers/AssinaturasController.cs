using MediatR;
using Microsoft.AspNetCore.Mvc;
using Spotifin.Aplicacao.Assinaturas.Comandos;
using Spotifin.Contratos.Assinaturas;

namespace Spotifin.Api.Controllers;

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

        var assinaturaId = await _mediator.Send(comando);

        var retorno = new CriarAssinaturaResponse(assinaturaId, request.TipoAssinatura);

        return Ok(retorno);
    }
}
