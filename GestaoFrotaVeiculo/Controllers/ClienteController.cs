using Data.Entidade;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace GestaoFrotaVeiculo.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClienteController : Controller
    {

        private readonly IClienteService _clienteServices;

        public ClienteController(IClienteService clienteServices)
        {
            _clienteServices = clienteServices;
        }

        [HttpPost]
        //conferir retornos atuais
        [ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult InserirCliente([FromBody] Cliente cliente)
        {          
            return Created(string.Empty, _clienteServices.InserirClienteService(cliente));
        }


        [HttpGet]
        //conferir retornos atuais
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<Cliente>> ObterTodosCliente()
        {
            var resposta = _clienteServices.ObterTodosClientesService();

            if (resposta == null)
            {
                return NoContent();
            }

            return Ok(_clienteServices.ObterTodosClientesService());
        }



        //conferir rota depois retorno certinho
        [HttpGet]
        [Route("/filtroCpfOuNome")]
        //conferir retornos atuais
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<Cliente>> ObterClientePeloCpf([FromQuery]string filtroCpfOuNome)
        {
            var resposta = _clienteServices.ObterClientePeloCpfENomeService(filtroCpfOuNome);

            if (resposta == null)
            {
                return NoContent();
            }
            return Ok(resposta);
        }

        //conferir rota depois retorno certinho
        [HttpPut]
        [Route("/atualizarEndereco")]
        //conferir retornos atuais
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult AtualizarEnderecoCliente([FromQuery] int cpf, string endereco)
        {
            return Ok(_clienteServices.AtualizarEnderecoClienteService(cpf, endereco));
        }

    }
}
