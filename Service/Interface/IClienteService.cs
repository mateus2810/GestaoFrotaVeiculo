using Data.Entidade;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IClienteService
    {
        public IEnumerable<Cliente> InserirClienteService(Cliente cliente);
        public IEnumerable<Cliente> ObterTodosClientesService();

        public IEnumerable<Cliente> ObterClientePeloCpfENomeService(string filtroNomeOuCpf);
    }
}
