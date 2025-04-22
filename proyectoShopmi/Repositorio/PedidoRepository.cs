using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.Interfaces;
using System.Data;

namespace proyectoShopmi.Repositorio
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly IConfiguration _config;
        private readonly string _cadena;
        public PedidoRepository(IConfiguration config)
        {
            _config = config;
            _cadena = _config.GetConnectionString("Conexion") ?? "";
        }

        public async Task<IEnumerable<PedidoRequest>> GetPedidos()
        {
            var sp = "USP_GET_PEDIDO";
            try
            {
                using var conexion = new SqlConnection(_cadena);
                var listado = await conexion.QueryAsync<PedidoRequest>(sp, commandType: CommandType.StoredProcedure);
                return listado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<PedidoRequest> GetPedido(int codPedido)
        {
            var sp = "USP_GET_ID_PEDIDO";
            var parameters = new DynamicParameters();
            parameters.Add("CODPEDIDO", codPedido, DbType.Int32, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(_cadena);

                var registro = await conexion.QueryFirstOrDefaultAsync<PedidoRequest>(sp, parameters, commandType: CommandType.StoredProcedure);

                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<int> InsertPedido(PedidoRequest pedido)
        {
            var sp = "USP_INSERT_PEDIDO";
            var parameters = new DynamicParameters();

            parameters.Add("CODPEDIDO", pedido.codPedido, DbType.Int32, ParameterDirection.Output);
            parameters.Add("CODUSUARIO", pedido.codUsuario, DbType.Int32, ParameterDirection.Input);
            parameters.Add("FECPED", pedido.fecPed, DbType.Date, ParameterDirection.Input);
            parameters.Add("PRECIOTOTAL", pedido.precioTotal, DbType.Decimal, ParameterDirection.Input);
            parameters.Add("ACTPED", "Pendiente", DbType.String, ParameterDirection.Input);
            parameters.Add("ESTPED", true, DbType.Boolean, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(_cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                var idGenerado = parameters.Get<int>("CODPEDIDO");

                if (respuesta!= 0 && idGenerado != 0)
                {
                    return idGenerado;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar InsertPedido: " + ex.Message);
            }
        }

        public async Task<int> UpdatePedidoPrecio(PedidoRequest pedido)
        {
            var sp = "USP_UPDATE_PEDIDO_PRECIO";
            var parameters = new DynamicParameters();

            parameters.Add("CODPEDIDO", pedido.codPedido, DbType.Int32, ParameterDirection.Input);
            parameters.Add("PRECIOTOTAL", pedido.precioTotal, DbType.Decimal, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(_cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                return respuesta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> DeletePedido(int codPedido)
        {
            var sp = "USP_DELETE_PEDIDO";
            var parameters = new DynamicParameters();

            parameters.Add("CODPEDIDO", codPedido, DbType.Int32, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(_cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                return $"Se ha realizado la eliminación de {(respuesta > 0 ? "1" : "ningún")} pedido.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el pedido: " + ex.Message);
            }
        }
    }
}
