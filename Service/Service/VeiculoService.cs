using Domain.Command;
using Domain.Entidades;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class VeiculoService : IVeiculoService
    {
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(Veiculo command)
        {
            int AnoAtual = DateTime.Now.Year;

            if (command == null)
                return "Todos os Campos são Obrigatorios";

            int anoAtual = DateTime.Now.Year;
            if (anoAtual - command.AnoFabricacao > 5)
                return "O ano do veiculo é menor que o permitido";

            if (command.TipoVeiculo != Domain.Enums.ETipoVeiculo.Elétrico
                || command.TipoVeiculo != Domain.Enums.ETipoVeiculo.Clássicos
                || command.TipoVeiculo != Domain.Enums.ETipoVeiculo.JDM
                || command.TipoVeiculo != Domain.Enums.ETipoVeiculo.Picape
                || command.TipoVeiculo != Domain.Enums.ETipoVeiculo.muscle
                )
                
            return await _veiculoRepository.PostAsync(command);
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }

        public Task PostAsync(VeiculoCommand command)
        {
            throw new NotImplementedException();
        }

        Task IVeiculoService.PostAsync(VeiculoCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
