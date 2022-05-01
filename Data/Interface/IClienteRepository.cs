
using Data.Entidade;
using System.Collections.Generic;

namespace Data.Interface
{
    public interface IClienteRepository
    {
        public IEnumerable<Cliente> InserirClienteRepository(Cliente cliente);
        public IEnumerable<Cliente> ObterTodosClientesRepository();

        public IEnumerable<Cliente> ObterClientePeloCpfENomeRepository(string filtroNomeOuCpf);
    }
}
