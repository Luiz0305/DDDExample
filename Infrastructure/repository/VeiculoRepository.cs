using Dapper;
using Domain.Command;
using Domain.Entidades;
using Domain.Interfaces;
using System.Data.SqlClient;

namespace Infrastructure.repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private string stringconnection = "";
        
        
                   
        public void GetAsync()
        {

        }

        string Conexao = @"Server=(localdb)\mssqllocaldb;Database=AluguelVeiculos;Trusted_Connection=True;MultipleActiveResultSets=True";

        public async Task<string> PostAsync(VeiculoCommand command)
        {

            string queryInsert = @"
            Veiculo(Placa, AnoFabricacao, TipoVeiculoId, Estado, MontadoraId)
            values(@Placa,@AnoFabricacao , @TipoVeiculoId, @Estado, @MontadoraId)";

            using (SqlConnection conn = new SqlConnection(stringconnection))
            {
                conn.Execute(queryInsert, new
                {
                    Placa = command.Placa,
                    AnoFabricacao = command.AnoFabricacao,
                    TipoVeiculoId = (int)command.TipoVeiculo,
                    Estado = command.Estado,
                    MontadoraId = (int)command.Montadora,
                });

                return "Veiculo cadastrado com sucesso";
            }
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }

    }
}
