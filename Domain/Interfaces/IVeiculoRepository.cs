using Domain.Command;
using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IVeiculoRepository
    {
        Task<string> PostAsync(VeiculoCommand command);

        void PostAsync();

        void GetAsync();

        Task<IEnumerable<VeiculoCommand>> GetVeiculosDisponiveisAsync();
        Task<IEnumerable<VeiculoCommand>> GetVeiculosAlugadosAsync();

    }
}
