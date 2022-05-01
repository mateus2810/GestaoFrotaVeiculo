using Data.Entidade;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using System.Collections.Generic;

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
            var retorno = Created(string.Empty, _veiculoService.InserirVeiculo(veiculo));

            //colocar msg de erro para quando njao tiver cliente existente

            return retorno;
        }

    }
}
