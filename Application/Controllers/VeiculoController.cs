using Domain.Command;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoService _veiculoService;
        public VeiculoController(IVeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }
        [HttpPost]
        [Route("CadastrarVeiculos")]
        public async Task<IActionResult> PostAsync([FromBody] VeiculoCommand command)
        {
            await _veiculoService.PostAsync(command);
            return Ok();
        }

        [HttpGet]
        [Route("SimularAluguel")]

        public IActionResult GetAsync(int id)
        {
            return Ok();
        }

        [HttpPost]
        [Route("Alugar")]

        public IActionResult PostAsync(int id)
        {
            return Ok();
        }
    }
}
