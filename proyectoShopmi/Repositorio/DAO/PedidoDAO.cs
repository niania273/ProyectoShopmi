using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.Interfaces;
using System.Data;

namespace proyectoShopmi.Repositorio.DAO
{
    public class PedidoDAO : IPedido
    {
        private readonly string cadena;

        public PedidoDAO()
        {
            cadena = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("conexion") ?? "";

        }
        public async Task<Pedido> getPedido(int codPedido)
        {
            var sp = "USP_GET_ID_PEDIDO";
            var parameters = new DynamicParameters();
            parameters.Add("CODPEDIDO", codPedido, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);

                var registro = await conexion.QueryFirstOrDefaultAsync<Pedido>(sp, parameters, commandType: CommandType.StoredProcedure);

                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Task<string> insertPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public Task<string> updatePedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

    }
}
