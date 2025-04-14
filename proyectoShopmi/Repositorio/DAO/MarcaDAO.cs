using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Repositorio.DAO
{
    public class MarcaDAO : IMarca
    {
        private readonly string cadena = "";

        public MarcaDAO()
        {
            cadena = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json").Build().GetConnectionString("Conexion") ?? "";
        }

        public async Task<IEnumerable<Marca>> GetMarcas()
        {
            var sp = "USP_GET_MARCA";

            try
            {
                using var conexion = new SqlConnection(cadena);
                var listado = await conexion.QueryAsync<Marca>(sp);
                return listado;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public async Task<Marca> GetMarca(int codMarca)
        {
            var sp = "USP_GET_ID_MARCA";
            var parameters = new DynamicParameters();
            parameters.Add("CODMARCA", codMarca, DbType.Int32, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);
                var registro = await conexion.QueryFirstOrDefaultAsync<Marca>(sp, parameters, commandType: CommandType.StoredProcedure);
                return registro;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<string> MergeMarca(Marca marca)
        {
            var sp = "USP_MERGE_MARCA";
            var mensaje = "";
            var parameters = new DynamicParameters();

            parameters.Add("CODMARCA", marca.codMarca, DbType.Int32, ParameterDirection.Input);
            parameters.Add("NOMBREMARCA", marca.nombremarca, DbType.String, ParameterDirection.Input);
            parameters.Add("ESTMARCA", marca.estmarca, DbType.Boolean, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                mensaje = $"Se ha generado {respuesta} marca.";
                return mensaje;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<string> DeleteMarca(int codMarca)
        {
            var sp = "USP_DELETE_MARCA";
            var mensaje = "";
            var parameters = new DynamicParameters();
            parameters.Add("CODMARCA", codMarca, DbType.Int32, ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                mensaje = $"Se ha eliminado {respuesta} marca.";
                return mensaje;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
