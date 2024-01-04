using Domain.Command;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        [HttpPost("CadastrarVeiculos")]
        public IActionResult PostAsync([FromBody] VeiculoCommand command)
        {
            return Ok();
        }

        public IActionResult SimularAluguel(int id)
        {
            return Ok();
        }

        public IActionResult Alugar(int id)
        {
            return Ok();
        }
    }
}
