using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models.Request;
using proyectoShopmi.Models.Response;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Repositorio
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly IConfiguration _config;
        private readonly string _cadena;
        public ProductoRepository(IConfiguration config)
        {
            _config = config;
            _cadena = _config.GetConnectionString("Conexion") ?? "";
        }

        public async Task<IEnumerable<ProductoResponse>> GetProductos()
        {
            var sp = "USP_GET_PRODUCTO";
            try
            {
                using var conexion = new SqlConnection(_cadena);
                var listado = await conexion.QueryAsync<ProductoResponse>(sp);
                return listado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ProductoResponse> GetProducto(int codProducto)
        {
            var sp = "USP_GET_ID_PRODUCTO";
            var parameters = new DynamicParameters();
            parameters.Add("CODPRODUCTO", codProducto, DbType.Int32, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(_cadena);
                var registro = await conexion.QueryFirstOrDefaultAsync<ProductoResponse>(sp, parameters, commandType: CommandType.StoredProcedure);
                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> MergeProducto(ProductoRequest producto, string accion)
        {
            var sp = "USP_MERGE_PRODUCTO";
            var parameters = new DynamicParameters();

            parameters.Add("CODPRODUCTO", producto.codProducto, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CODCATEGORIA", producto.codCategoria, DbType.Int32, ParameterDirection.Input);
            parameters.Add("IMGPRODUCTO", producto.imgProducto, DbType.String, ParameterDirection.Input);
            parameters.Add("NOMPRODUCTO", producto.nomProducto, DbType.String, ParameterDirection.Input);
            parameters.Add("DESCRIPCION", producto.descripcion, DbType.String, ParameterDirection.Input);
            parameters.Add("PREUNI", producto.preUni, DbType.Decimal, ParameterDirection.Input);
            parameters.Add("CODMARCA", producto.codMarca, DbType.Int32, ParameterDirection.Input);
            parameters.Add("STOCK", producto.stock, DbType.Int32, ParameterDirection.Input);
            parameters.Add("ESTPRODUCTO", producto.estProducto, DbType.Boolean, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(_cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                return $"Se ha realizadó la {accion} de {respuesta} producto.";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public async Task<string> DeleteProducto(int codProducto)
        {
            var sp = "USP_DELETE_PRODUCTO";
            var parameters = new DynamicParameters();
            parameters.Add("CODPRODUCTO", codProducto, DbType.Int32, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(_cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                return $"Se ha eliminado {respuesta} producto.";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
