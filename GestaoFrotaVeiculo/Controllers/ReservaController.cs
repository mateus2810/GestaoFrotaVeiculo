using Data.Entidade;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using System;
using System.Collections.Generic;

namespace GestaoFrotaVeiculo.Controllers
{
    [ApiController]
    [Route("reserva")]
    public class ReservaController : Controller
    {
        private readonly IReservaService _reservaService;

        public ReservaController(IReservaService reservaService)
        {
            _reservaService = reservaService;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<ReservaCliente>> ObterReservaCliente(int cpf)
        {
       
            var resposta = _reservaService.ObterReservaClienteService(cpf);

            if (resposta == null)
            {
                return NoContent();
            }

            return Ok(resposta);
        }


        [HttpPost]
        [Route("InserirReserva")]
        public ActionResult InserirReserva(int id_cliente, int id_veiculo, DateTime data_prev_devolucao)
        {

            var resposta = _reservaService.InserirReservaService(id_cliente, id_veiculo, data_prev_devolucao);

            if (resposta == null)
            {
                return NoContent();
            }

            return Created(string.Empty, resposta);
        }

        //rota devolver veiculo
    }
}
