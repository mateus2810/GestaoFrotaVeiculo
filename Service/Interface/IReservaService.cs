using Data.Entidade;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IReservaService
    {
        public IEnumerable<ReservaCliente> ObterReservaClienteService(int cpf);

        //public IEnumerable<ReservaCliente> InserirReservaService(int cpf);
    }
}
