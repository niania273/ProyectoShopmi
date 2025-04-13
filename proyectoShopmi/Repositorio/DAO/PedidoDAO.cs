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

        public async Task<IEnumerable<Pedido>> GetPedidos()
        {
            var sp = "USP_GET_PEDIDO";
            try
            {
                using var conexion = new SqlConnection(cadena);
                var listado = await conexion.QueryAsync<Pedido>(sp, commandType: CommandType.StoredProcedure);
                return listado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Pedido> GetPedido(int codPedido)
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
        public async Task<string> MergePedido(Pedido pedido, string accion)
        {
            var sp = "USP_MERGE_PEDIDO";
            var parameters = new DynamicParameters();

            parameters.Add("CODPEDIDO", pedido.codPedido, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CODCLIENTE", pedido.codCliente, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CODEMPLEADO", pedido.codEmpleado, DbType.Int32, ParameterDirection.Input);
            parameters.Add("FECPED", pedido.fecPed, DbType.Date, ParameterDirection.Input);
            parameters.Add("PRECIOTOTAL", pedido.precioTotal, DbType.Decimal, ParameterDirection.Input);
            parameters.Add("ACTPED", pedido.actPed, DbType.String, ParameterDirection.Input);
            parameters.Add("ESTPED", pedido.estPed, DbType.Boolean, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);
                var resultado = await conexion.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                return $"Se ha realizado la {accion} de {(resultado > 0 ? "1" : "ningún")} pedido.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar MergePedido: " + ex.Message);
            }
        }

        public async Task<string> DeletePedido(int codPedido)
        {
            var sp = "USP_DELETE_PEDIDO";
            var parameters = new DynamicParameters();

            parameters.Add("CODPEDIDO", codPedido, DbType.Int32, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);
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
