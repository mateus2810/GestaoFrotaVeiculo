using Data.Entidade;
using System.Collections.Generic;

namespace Data.Interfaces
{
    public interface IVeiculoRepository
    {
        public IEnumerable<Ator> Teste();

        public IEnumerable<Veiculo> InserirVeiculoRepository(Veiculo veiculo);

        public IEnumerable<Veiculo> ObterVeiculoPelaPlacaRepository(string numeroPlaca);
        public IEnumerable<Veiculo> ObterVeiculoPeloModeloOuMarcaRepository(string filtroModeloOuFabricante);
    }
}
