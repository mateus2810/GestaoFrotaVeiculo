﻿using Data.Entidade;
using System.Collections.Generic;

namespace Data.Interfaces
{
    public interface IVeiculoRepository
    {
        public IEnumerable<Ator> Teste();

        public IEnumerable<Veiculo> InserirVeiculo(Veiculo veiculo);
    }
}
