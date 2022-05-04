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
        [Route("inserir_reserva")]
        public ActionResult InserirReserva(int id_cliente, int id_veiculo, DateTime data_prev_devolucao)
        {
            var resposta = _reservaService.InserirReservaService(id_cliente, id_veiculo, data_prev_devolucao);

            if (resposta == null)
            {
                return NoContent();
            }

            return Created(string.Empty, resposta);
        }

        [HttpPut]
        [Route("data_retirada")]
        public ActionResult AtualizarDataRetirada(DateTime data_retirada, int id_veiculo)
        {

            var resposta = _reservaService.AtualizarDataRetiradaService(data_retirada, id_veiculo);

            if (resposta == null)
            {
                return NoContent();
            }

            return Created(string.Empty, resposta);
        }

        [HttpPut]
        [Route("data_prev_devolucao")]
        public ActionResult AtualizarDataPrevisaDevolucao(DateTime data_prev_devolucao, int id_veiculo)
        {

            var resposta = _reservaService.AtualizarDataPrevisaDevolucaoService(data_prev_devolucao, id_veiculo);

            if (resposta == null)
            {
                return NoContent();
            }

            return Created(string.Empty, resposta);
        }

        [HttpGet]
        [Route("veiculos_retirados")]
        public ActionResult ObterVeiculosRetirados(DateTime data_inicio, DateTime data_fim)
        {

            var resposta = _reservaService.ObterVeiculoRetiradoService(data_inicio, data_fim);

            if (resposta == null)
            {
                return NoContent();
            }

            return Created(string.Empty, resposta);
        }

        //rota devolver veiculo
    }
}
