using Domain.Command;
using Domain.Interfaces;

namespace Service.Service
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepository _repository;
        public VeiculoService(IVeiculoRepository repository)
        {
            _repository = repository;
        }

        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public void GetVeiculosAlugados()
        {
            throw new NotImplementedException();
        }

        public void GetVeiculosDisponiveis()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(VeiculoCommand command)
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
                return "O tipo de veiculo não é permitido";

            return await _repository.PostAsync(command);
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
