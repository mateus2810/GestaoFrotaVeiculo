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
            //validação de nome, não poder receber numero
            //criar validação cpf valido, se nulo inserir mensagem
            //criar validação cnh valido, se nulo inserir mensagem
            //nascimento aceitar apenas datas

            //validar nascimento maior que 18 anos

            return _clienteRepository.InserirClienteRepository(cliente);
        }

        public IEnumerable<Cliente> ObterTodosClientesService()
        {
            return _clienteRepository.ObterTodosClientesRepository();
        }

        public IEnumerable<Cliente> ObterClientePeloCpfENomeService(string filtroNomeOuCpf)
        {
            return _clienteRepository.ObterClientePeloCpfENomeRepository(filtroNomeOuCpf);
        }
    }

}
