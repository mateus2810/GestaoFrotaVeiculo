using Data.Entidade;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
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


        //[HttpPost]
        //[Route("reserva")]
        //public ActionResult InserirReserva(Reserva reserva)
        //{

        //    var resposta = _reservaService.InserirReservaService(reserva);

        //    if (resposta == null)
        //    {
        //        return NoContent();
        //    }

        //    return Ok(resposta);
        //}
    }
}
