using Domain.Command;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class ClienteService
    {
        public class ClienteService : IClienteService
        {
            private readonly IClienteRepository _repository;
            public ClienteService(IClienteRepository repository)
            {
                _repository = repository;
            }
            public void PostAsync()
            {
                throw new NotImplementedException();
            }

            public void GetAsync()
            {
                throw new NotImplementedException();
            }
            public async Task<string> PostAsync(ClienteCommand command)
            {
                if (command == null)
                    return "Todos os Campos são Obrigatorios";

                int Idade = DateTime.Now.Year - command.DataNacimento.Year;

                if (Idade < 18)
                    return "E obrigatorio ter 18 anos";

                return await _repository.PostAsync(command);

            }
        }
    }
}