using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.Interfaces;
using System.Data;

namespace proyectoShopmi.Repositorio.DAO
{
    public class DetallePedidoDAO : IDetallePedido
    {
        private readonly string cadena;

        public DetallePedidoDAO()
        {
            cadena = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("conexion") ??"";


        }
        public async Task<DetallePedido> getDetallePedido(int codPedido, int codProducto)
        {
            var sp = "USP_GET_ID_DETALLEPEDIDO";
            var parameters = new DynamicParameters();
            parameters.Add("CODPEDIDO", codPedido, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CODPRODUCTO", codProducto, DbType.Int32, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);

                var registro = await conexion.QueryFirstOrDefaultAsync<DetallePedido>(sp, parameters, commandType: CommandType.StoredProcedure);

                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Task<string> insertDetallePedido(DetallePedido detallePedido)
        {
            throw new NotImplementedException();
        }

        public Task<string> updateDetallePedido(DetallePedido detallePedido)
        {
            throw new NotImplementedException();
        }
    }
}
