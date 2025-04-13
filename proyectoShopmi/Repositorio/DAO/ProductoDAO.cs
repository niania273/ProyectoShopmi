using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Repositorio.DAO
{
    public class ProductoDAO : IProducto
    {
        private readonly string cadena = "";

        public ProductoDAO()
        {
            cadena = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json").Build().GetConnectionString("Conexion") ?? "";
        }

        public async Task<IEnumerable<Producto>> GetProductos()
        {
            var sp = "USP_GET_PRODUCTO";

            try
            {
                using var conexion = new SqlConnection(cadena);
                var listado = await conexion.QueryAsync<Producto>(sp);
                return listado;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Producto> GetProducto(int codProducto)
        {
            var sp = "USP_GET_ID_PRODUCTO";
            var parameters = new DynamicParameters();
            parameters.Add("CODPRODUCTO", codProducto, DbType.Int32, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);
                var registro = await conexion.QueryFirstOrDefaultAsync<Producto>(sp, parameters, commandType: CommandType.StoredProcedure);
                return registro;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<string> MergeProducto(Producto producto)
        {
            var sp = "USP_MERGE_PRODUCTO";
            var mensaje = "";
            var parameters = new DynamicParameters();

            parameters.Add("CODPRODCUTO", producto.codProducto, DbType.Int32, ParameterDirection.Input);
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
                using var conexion = new SqlConnection(cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters);
                mensaje = $"Se ha generado {respuesta} producto.";
                return mensaje;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public async Task<string> DeleteProducto(int codProducto)
        {
            var sp = "USP_DELETE_PRODUCTO";
            var mensaje = "";
            var parameters = new DynamicParameters();
            parameters.Add("CODPRODUCTO", codProducto, DbType.Int32, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters);
                mensaje = $"Se ha eliminado {respuesta} empleado.";
                return mensaje;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
