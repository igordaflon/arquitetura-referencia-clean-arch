using MediatR;
using Microsoft.AspNetCore.Mvc;
using Spotifin.Aplicacao.Assinaturas.Comandos.CriarAssinatura;
using Spotifin.Aplicacao.Assinaturas.Queries.ObterAssinatura;
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
        if(!Dominio.Assinaturas.TipoAssinaturaEnum.TryFromName(request.TipoAssinatura.ToString(), out var tipoAssinatura))
        {
            return Problem(
                detail: $"Tipo de assinatura '{request.TipoAssinatura}' não é válido.",
                statusCode: StatusCodes.Status400BadRequest);
        }

        var comando = new CriarAssinaturaComando(tipoAssinatura, request.UsuarioId);

        var criarAssinaturaResultado = await _mediator.Send(comando);

        return criarAssinaturaResultado.MatchFirst(
            assinatura => Ok(new AssinaturaResponse(assinatura.Id, request.TipoAssinatura)),
            erros => Problem());
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> ObterAssinaturaAsync(Guid id)
    {
        var query = new ObterAssinaturaQuery(id);

        var assinaturaResultado = await _mediator.Send(query);

        return assinaturaResultado.MatchFirst(
            assinatura => Ok(new AssinaturaResponse(assinatura.Id, Enum.Parse<TipoAssinaturaEnum>(assinatura.TipoAssinatura.Name))),
            erros => Problem());
    }
}
