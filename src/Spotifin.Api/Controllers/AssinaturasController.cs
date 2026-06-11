using Microsoft.AspNetCore.Mvc;

namespace Spotifin.Api.Controllers;

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
