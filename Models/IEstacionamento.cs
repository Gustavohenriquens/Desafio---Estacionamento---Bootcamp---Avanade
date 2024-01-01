using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_estacionamento.Models
{
    public interface IEstacionamento
    {
        void AdicionarVeiculo();
        void RemoverVeiculo();
        void ListarVeiculos();
        void VerificarQuantosVeiculosTem(); 
    }
}