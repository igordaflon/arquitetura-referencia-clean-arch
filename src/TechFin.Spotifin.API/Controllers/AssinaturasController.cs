using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TechFin.Spotifin.Aplicacao.Assinaturas.Comandos.CriarAssinatura;
using TechFin.Spotifin.Aplicacao.Assinaturas.Queries.ObterAssinatura;
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

    [HttpGet("{assinaturaId:guid}")]
    public async Task<IActionResult> ObterAssinaturaAsync(Guid assinaturaId)
    {
        var query = new ObterAssinaturaQuery(assinaturaId);

        var resultado = await _mediator.Send(query);

        return resultado.MatchFirst(
            assinatura => Ok(new AssinaturaResponse(assinatura.Id, Enum.Parse<TipoAssinaturaEnum>(assinatura.TipoAssinatura.Name))),
            erro => Problem()
        );
    }

    [HttpPost]
    public async Task<IActionResult> CriarAssinaturaAsync(CriarAssinaturaRequest request)
    {
        if (!Dominio.Assinaturas.TipoAssinatura.TryFromName(request.TipoAssinatura.ToString(), out var tipoAssinatura))
        {
            return Problem(
                statusCode: StatusCodes.Status400BadRequest,
                detail: "Tipo de assinatura inválido");
        }

        var comando = new CriarAssinaturaComando(tipoAssinatura, request.UsuarioId);

        var resultado = await _mediator.Send(comando);

        return resultado.MatchFirst(
            assinatura => Ok(new AssinaturaResponse(assinatura.Id, request.TipoAssinatura)),
            erro => Problem()
        );       
    }
}
