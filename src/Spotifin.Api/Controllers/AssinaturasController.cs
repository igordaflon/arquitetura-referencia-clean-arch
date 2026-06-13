using Microsoft.AspNetCore.Mvc;
using Spotifin.Aplicacao.Servicos;
using Spotifin.Contratos.Assinaturas;

namespace Spotifin.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AssinaturasController : ControllerBase
{
    private readonly IAssinaturasServico _assinaturaServico;

    public AssinaturasController(IAssinaturasServico assinaturaServico)
    {
        _assinaturaServico = assinaturaServico;
    }


    [HttpPost]
    public IActionResult CriarAssinatura(CriarAssinaturaRequest request)
    {
        var assinaturaId = _assinaturaServico.CriarAssinatura(request.TipoAssinatura.ToString(), request.UsuarioId);

        var retorno = new CriarAssinaturaResponse(assinaturaId, request.TipoAssinatura);

        return Ok(retorno);
    }
}
