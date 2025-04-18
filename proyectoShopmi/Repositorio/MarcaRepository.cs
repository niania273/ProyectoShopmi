using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models.Response;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Repositorio
{
    public class MarcaRepository : IMarcaRepository
    {
        private readonly IConfiguration _config;
        private readonly string _cadena;
        public MarcaRepository(IConfiguration config)
        {
            _config = config;
            _cadena = _config.GetConnectionString("Conexion") ?? "";
        }

        public async Task<IEnumerable<MarcaResponse>> GetMarcas()
        {
            var sp = "USP_GET_MARCA";
            var parameters = new DynamicParameters();
            parameters.Add("ESTMARCA", false, DbType.Boolean, ParameterDirection.Input);
            try
            {
                using var conexion = new SqlConnection(_cadena);
                var listado = await conexion.QueryAsync<MarcaResponse>(sp, parameters);
                return listado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<SelectResponse>> SelectMarcas()
        {
            var sp = "USP_GET_MARCA";
            var parameters = new DynamicParameters();
            parameters.Add("ESTMARCA", true, DbType.Boolean, ParameterDirection.Input);
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

        public async Task<MarcaResponse> GetMarca(int codMarca)
        {
            var sp = "USP_GET_ID_MARCA";
            var parameters = new DynamicParameters();
            parameters.Add("CODMARCA", codMarca, DbType.Int32, ParameterDirection.Input);
            try
            {
                using var conexion = new SqlConnection(_cadena);
                var registro = await conexion.QueryFirstOrDefaultAsync<MarcaResponse>(sp, parameters, commandType: CommandType.StoredProcedure);
                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> MergeMarca(MarcaResponse marca, string accion)
        {
            var sp = "USP_MERGE_MARCA";
            var parameters = new DynamicParameters();

            parameters.Add("CODMARCA", marca.codMarca, DbType.Int32, ParameterDirection.Input);
            parameters.Add("NOMBREMARCA", marca.nombremarca, DbType.String, ParameterDirection.Input);
            parameters.Add("ESTMARCA", marca.estmarca, DbType.Boolean, ParameterDirection.Input);
            try
            {
                using var conexion = new SqlConnection(_cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                return $"Se ha realizado la {accion} de {respuesta} marca.";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> DeleteMarca(int codMarca)
        {
            var sp = "USP_DELETE_MARCA";
            var parameters = new DynamicParameters();
            parameters.Add("CODMARCA", codMarca, DbType.Int32, ParameterDirection.Input);
            try
            {
                using var conexion = new SqlConnection(_cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                return $"Se ha realizado la eliminación de {respuesta} marca.";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
