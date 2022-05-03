
using Data.Entidade;
using System.Collections.Generic;

namespace Data.Interface
{
    public interface IReservaRepository
    {
        public IEnumerable<ReservaCliente> ObterReservaClienteRepository(int cpf);
    }
}
