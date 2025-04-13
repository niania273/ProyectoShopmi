using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Repositorio.DAO
{
    public class CategoriaDAO : ICategoria
    {
        private readonly string cadena = "";

        public CategoriaDAO()
        {
            cadena = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json").Build().GetConnectionString("Conexion") ?? "";
        }

        public async Task<IEnumerable<Categoria>> GetCategorias()
        {
            var sp = "USP_GET_CATEGORIA";

            try
            {
                using var conexion = new SqlConnection(cadena);
                var listado = await conexion.QueryAsync<Categoria>(sp, commandType: CommandType.StoredProcedure);
                return listado;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Categoria> GetCategoria(int codcategoria)
        {
            var sp = "USP_GET_ID_CATEGORIA";
            var parameters = new DynamicParameters();
            parameters.Add("CODCATEGORIA", codcategoria, System.Data.DbType.Int32,System.Data.ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);
                var registro = await conexion.QueryFirstOrDefaultAsync<Categoria>(sp, parameters, commandType: CommandType.StoredProcedure);
                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); 
            }
        }

        public async Task<string> MergeCategoria(Categoria categoria)
        {
            var sp = "USP_MERGE_CATEGORIA";
            var mensaje = "";
            var parameters = new DynamicParameters();

            parameters.Add("CODCATEGORIA", categoria.codcategoria, DbType.Int32, ParameterDirection.Input);
            parameters.Add("IMGCATEGORIA", categoria.imgcategoria, DbType.String, ParameterDirection.Input);
            parameters.Add("NOMCATEGORIA", categoria.nomcategoria, DbType.String, ParameterDirection.Input);
            parameters.Add("ESTCATEGORIA", categoria.estcategoria, DbType.Boolean, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                mensaje = $"Se ha generado {respuesta} categoria.";
                return mensaje;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<string> DeleteCategoria(int codcategoria)
        {
            var sp = "USP_DELETE_CATEGORIA";
            var mensaje = "";
            var parameters = new DynamicParameters();
            parameters.Add("CODCATEGORIA", codcategoria, DbType.Int32, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                mensaje = $"Se ha eliminado {respuesta} categoria.";
                return mensaje;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}

