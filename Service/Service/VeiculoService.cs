using Data.Entidade;
using Data.Interfaces;
using Service.Interface;
using System;
using System.Collections.Generic;

namespace Service.Service
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;              
        }
        public IEnumerable<Veiculo> InserirVeiculo(Veiculo veiculo)
        {

            //regra para não inserir a mesma placa no veiculo


            if(veiculo.id_cliente == 20)
            {
                throw new Exception("esse cliente é invalido");
            }
            
            
            return _veiculoRepository.InserirVeiculo(veiculo);
        }
    }
}
