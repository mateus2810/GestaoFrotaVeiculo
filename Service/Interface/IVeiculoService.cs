using Data.Entidade;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IVeiculoService
    {
        public IEnumerable<Veiculo> InserirVeiculo(Veiculo veiculo);
    }
}
