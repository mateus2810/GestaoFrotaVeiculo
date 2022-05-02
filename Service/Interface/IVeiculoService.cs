using Data.Entidade;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IVeiculoService
    {
        public IEnumerable<Veiculo> InserirVeiculoService(Veiculo veiculo);
        public IEnumerable<Veiculo> ObterVeiculoPelaPlacaService(string numeroPlaca);
    }
}
