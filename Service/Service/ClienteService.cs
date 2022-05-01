using Data.Entidade;
using Data.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;

namespace Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> InserirClienteService(Cliente cliente)
        {
            return _clienteRepository.InserirClienteRepository(cliente);
        }

        public IEnumerable<Cliente> ObterTodosClientesService()
        {
            return _clienteRepository.ObterTodosClientesRepository();
        }
    }

}
