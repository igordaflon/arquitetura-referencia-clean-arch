using MediatR;
using Microsoft.AspNetCore.Mvc;
using Spotifin.Aplicacao.Assinaturas.Comandos.CriarAssinatura;
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

        var criarAssinaturaResultado = await _mediator.Send(comando);

        return criarAssinaturaResultado.MatchFirst(
            assinatura => Ok(new CriarAssinaturaResponse(assinatura.Id, request.TipoAssinatura)),
            erros => Problem());
    }
}
