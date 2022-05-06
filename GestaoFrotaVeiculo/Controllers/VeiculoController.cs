using Data.Entidade;
using Data.Output;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace GestaoFrotaVeiculo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculoController : Controller
    {

        private readonly IVeiculoService _veiculoService;

        public VeiculoController(IVeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }

        [HttpPost]
        public ActionResult<IEnumerable<Veiculo>> InserirVeiculo([FromBody] Veiculo veiculo)
        {
            
            var retorno = Created(string.Empty, _veiculoService.InserirVeiculoService(veiculo));

            //colocar msg de erro para quando njao tiver cliente existente

            return retorno;
        }

        [HttpGet]
        [Route("/listarPelaPlaca")]
        public ActionResult<IEnumerable<Veiculo>> ObterVeiculoPelaPlaca([FromQuery] string numero_placa)//ajustar todas as variaves case
        {
            var resposta = _veiculoService.ObterVeiculoPelaPlacaService(numero_placa);

            if (resposta.Count() == 0)
            {
                return NoContent();
            }

            //colocar msg de erro para quando njao tiver cliente existente

            return Ok(resposta);
        }

        [HttpGet]
        [Route("/listarPeloModeloOuMarca")]
        public ActionResult<IEnumerable<InfoVeiculo>> ObterVeiculoPeloModeloOuMarca([FromQuery] string filtroModeloOuFabricante)
        {
            var resposta = _veiculoService.ObterVeiculoPeloModeloOuMarcaService(filtroModeloOuFabricante);

            if (resposta.Count() == 0)
            {
                return NoContent();
            }
            //colocar msg de erro para quando njao tiver cliente existente

            return Ok(resposta);
        }
    }
}
