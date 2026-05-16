using Microsoft.AspNetCore.Mvc;
using TechFin.Spotifin.Contratos.Assinaturas;

namespace TechFin.Spotifin.API.Controllers;

[ApiController]
[Route("[controller]")]
public class AssinaturasController : ControllerBase
{
    [HttpPost]
    public IActionResult CriarAssinatura(CriarAssinaturaRequest request)
    {
        return Ok(request);
    }
}
