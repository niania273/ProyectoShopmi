using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models.Response;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Repositorio
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly IConfiguration _config;
        private readonly string _cadena;
        public CategoriaRepository(IConfiguration config)
        {
            _config = config;
            _cadena = _config.GetConnectionString("Conexion") ?? "";
        }

        public async Task<IEnumerable<CategoriaResponse>> GetCategorias()
        {
            var sp = "USP_GET_CATEGORIA";
            try
            {
                using var conexion = new SqlConnection(_cadena);
                var listado = await conexion.QueryAsync<CategoriaResponse>(sp);
                return listado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<SelectResponse>> SelectCategorias()
        {
            var sp = "USP_GET_CATEGORIA";
            var parameters = new DynamicParameters();
            parameters.Add("EST", 1, DbType.Boolean, ParameterDirection.Input);
            try
            {
                using var conexion = new SqlConnection(_cadena);
                var listado = await conexion.QueryAsync<SelectResponse>(sp, parameters);
                return listado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<CategoriaResponse> GetCategoria(int codcategoria)
        {
            var sp = "USP_GET_ID_CATEGORIA";
            var parameters = new DynamicParameters();
            parameters.Add("CODCATEGORIA", codcategoria, DbType.Int32,ParameterDirection.Input);
            try
            {
                using var conexion = new SqlConnection(_cadena);
                var registro = await conexion.QueryFirstOrDefaultAsync<CategoriaResponse>(sp, parameters, commandType: CommandType.StoredProcedure);
                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); 
            }
        }

        public async Task<string> MergeCategoria(CategoriaResponse categoria, string accion)
        {
            var sp = "USP_MERGE_CATEGORIA";
            var parameters = new DynamicParameters();

            parameters.Add("CODCATEGORIA", categoria.codcategoria, DbType.Int32, ParameterDirection.Input);
            parameters.Add("IMGCATEGORIA", categoria.imgcategoria, DbType.String, ParameterDirection.Input);
            parameters.Add("NOMCATEGORIA", categoria.nomcategoria, DbType.String, ParameterDirection.Input);
            parameters.Add("ESTCATEGORIA", categoria.estcategoria, DbType.Boolean, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(_cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                return $"Se ha realizado la {accion} de {respuesta} categoría.";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<string> DeleteCategoria(int codcategoria)
        {
            var sp = "USP_DELETE_CATEGORIA";
            var parameters = new DynamicParameters();
            parameters.Add("CODCATEGORIA", codcategoria, DbType.Int32, ParameterDirection.Input);
            try
            {
                using var conexion = new SqlConnection(_cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                return $"Se realizado la eliminación de {respuesta} categoria.";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

