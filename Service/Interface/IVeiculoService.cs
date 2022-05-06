using Data.Entidade;
using Data.Output;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IVeiculoService
    {
        public IEnumerable<Veiculo> InserirVeiculoService(Veiculo veiculo);
        public IEnumerable<Veiculo> ObterVeiculoPelaPlacaService(string numeroPlaca);
        public IEnumerable<InfoVeiculo> ObterVeiculoPeloModeloOuMarcaService(string filtroModeloOuFabricante);
    }
}
