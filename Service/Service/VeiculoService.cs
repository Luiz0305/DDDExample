using Domain.Command;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
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

        public Task PostAsync(VeiculoCommand command)
        {
            if (command == null)
                throw new ArgumentNullException();

            if (command.TipoVeiculo != Domain.Enums.ETipoVeiculo.Elétrico
                || command.TipoVeiculo != Domain.Enums.ETipoVeiculo.Clássicos
                || command.TipoVeiculo != Domain.Enums.ETipoVeiculo.JDM
                || command.TipoVeiculo != Domain.Enums.ETipoVeiculo.Picape
                || command.TipoVeiculo != Domain.Enums.ETipoVeiculo.muscle
                )
            {
                Console.WriteLine("Não cadastrou o veiculo");
                throw new NotImplementedException();
            }
            else
            {
                Console.WriteLine("Veiculo cadastrado");
            }
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
