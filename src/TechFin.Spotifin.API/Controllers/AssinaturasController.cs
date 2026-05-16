using Microsoft.AspNetCore.Mvc;
using TechFin.Spotifin.Aplicacao.Servicos;
using TechFin.Spotifin.Contratos.Assinaturas;

namespace TechFin.Spotifin.API.Controllers;

[ApiController]
[Route("[controller]")]
public class AssinaturasController : ControllerBase
{
    private readonly IAssinaturasServico _assinaturasServico;

    public AssinaturasController(IAssinaturasServico assinaturasServico)
    {
        _assinaturasServico = assinaturasServico;
    }

    [HttpPost]
    public IActionResult CriarAssinatura(CriarAssinaturaRequest request)
    {
        var assinaturaId = _assinaturasServico.CriarAssinatura(request.TipoAssinatura.ToString(), request.UsuarioId);

        var resultado = new AssinaturaResponse(assinaturaId, request.TipoAssinatura);

        return Ok(resultado);
    }
}
