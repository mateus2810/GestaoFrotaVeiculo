﻿using Data.Entidade;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using System.Collections.Generic;

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
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<Cliente>> InserirCliente([FromBody] Cliente cliente)
        {
            
            return Created(string.Empty,_clienteServices.InserirClienteService(cliente));
        }


        [HttpGet]
        //conferir retornos atuais
        [ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<Cliente>> ObterTodosCliente()
        {

            return Ok(_clienteServices.ObterTodosClientesService());
        }
    }
}