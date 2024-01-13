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
        public void GetAsync()
        {

        }
        public async Task<IEnumerable<VeiculoCommand>> GetVeiculosDisponiveisAsync()
        {
            string queryBuscarVeiculosDisponiveis = @"select * from [AluguelVeiculos].[dbo].[Veiculo] where Alugado = 0";
            using (SqlConnection conn = new SqlConnection(Conexao))
            {
                return conn.QueryAsync<VeiculoCommand>(queryBuscarVeiculosDisponiveis).Result.ToList();
            }
        }
        public async Task<IEnumerable<VeiculoCommand>> GetVeiculosAlugadosAsync()
        {
            string queryBuscarVeiculosAlugados = @"select * from [AluguelVeiculos].[dbo].[Veiculo] where Alugado = 1";
            using (SqlConnection conn = new SqlConnection(Conexao))
            {
                return conn.QueryAsync<VeiculoCommand>(queryBuscarVeiculosAlugados).Result.ToList();
            }
        }
    }
}
