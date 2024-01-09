using Dapper;
using Domain.Entidades;
using Domain.Enums;
using Domain.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private string stringconnection = "";
        
        
        public void PostAsync()
        {

        }
            
        public void GetAsync()
        {

        }

        public async Task <string>IVeiculoRepository.PostAsync(Veiculo command)
        {

            string queryInsert = @"
            Veiculo(Placa, AnoFabricacao, TipoVeiculoId, Estado, MontadoraId)
            values(@Placa,@AnoFabricacao , @TipoVeiculoId, @Estado, @MontadoraId)";

            using (var conn = new SqlConnection())
            {
                conn.Execute(queryInsert, new
                {
                    Placa = command.Placa,
                    AnoFabricacao = command.AnoFabricacao,
                    TipoVeiculoId = command.TipoVeiculo,
                    Estado = command.Estado,
                    MontadoraId = command.Montadora,
                });

                return "Veiculo cadastrado com sucesso";
            }
        }

        public Task PostAsync(Veiculo command)
        {
            throw new NotImplementedException();
        }
    }
}
