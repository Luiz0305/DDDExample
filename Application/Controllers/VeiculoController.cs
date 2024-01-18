using Domain.Command;
using Domain.Enums;
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

        public async Task<IActionResult> GetAsync(int DiasSimulacaoAluguel, ETipoVeiculo tipoVeiculo)
        {
            return Ok(await _veiculoService.SimularVeiculoAluguel(DiasSimulacaoAluguel, tipoVeiculo));
        }

        [HttpPost]
        [Route("Alugar")]

        public IActionResult PostAsync(int id)
        {
            return Ok();
        }

        [HttpGet]
        [Route("VeiculosDisponiveis")]

        public async Task<IActionResult> GetVeiculosDisponiveisAsync()
        {
            return Ok(await _veiculoService.GetVeiculosDisponiveisAsync());
        }

        [HttpGet]
        [Route("VeiculosAlugados")]
        
        public async Task<IActionResult> GetVeiculosAlugadosAsync()
        {
            return Ok(await _veiculoService.GetVeiculosAlugadosAsync());
        }
    }
}
