using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.Interfaces;
using System.Data;

namespace proyectoShopmi.Repositorio
{
    public class DetallePedidoRepository : IDetallePedidoRepository
    {
        private readonly IConfiguration _config;
        private readonly string _cadena;
        public DetallePedidoRepository(IConfiguration config)
        {
            _config = config;
            _cadena = _config.GetConnectionString("Conexion") ?? "";
        }
        public async Task<DetallePedidoRequest> getDetallePedido(int codPedido, int codProducto)
        {
            var sp = "USP_GET_ID_DETALLEPEDIDO";
            var parameters = new DynamicParameters();
            parameters.Add("CODPEDIDO", codPedido, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CODPRODUCTO", codProducto, DbType.Int32, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(_cadena);

                var registro = await conexion.QueryFirstOrDefaultAsync<DetallePedidoRequest>(sp, parameters, commandType: CommandType.StoredProcedure);

                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<int> insertDetallePedido(DetallePedidoRequest detallePedido)
        {
            var sp = "USP_INSERT_DETALLEPEDIDO";
            var parameters = new DynamicParameters();
            parameters.Add("CODPEDIDO", detallePedido.codPedido, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CODPRODUCTO", detallePedido.codProducto, DbType.Int32, ParameterDirection.Input);
            parameters.Add("PREUNI", detallePedido.preUni, DbType.Decimal, ParameterDirection.Input);
            parameters.Add("CANTIDAD", detallePedido.cantidad, DbType.Int32, ParameterDirection.Input);
            parameters.Add("EST_PP", detallePedido.estPP, DbType.Boolean, ParameterDirection.Input);
            try
            {
                using var conexion = new SqlConnection(_cadena);
                var rsp = await conexion.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                return rsp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //public Task<int> updateDetallePedido(DetallePedidoRequest detallePedido)
        //{
        //    return ;
        //}
    }
}
