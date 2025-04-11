using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Repositorio.DAO
{
    public class UsuarioDAO : IUsuario
    {
        private readonly string cadena;

        public UsuarioDAO()
        {
            cadena = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json").Build().GetConnectionString("Conexion") ?? "";
        }

        public async Task<IEnumerable<Usuario>> GetUsuarios()
        {
            var sp = "USP_GET_USUARIO";
            try
            {
                using var conexion = new SqlConnection(cadena);
                var listado = await conexion.QueryAsync<Usuario>(sp, commandType: CommandType.StoredProcedure);
                return listado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Usuario> GetUsuario(int codUsu)
        {
            var sp = "USP_GET_ID_USUARIO";
            var parameters = new DynamicParameters();
            parameters.Add("CODUSUARIO", codUsu, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);
                var registro = await conexion.QueryFirstOrDefaultAsync<Usuario>(sp, parameters, commandType: CommandType.StoredProcedure);
                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> MergeUsuario(Usuario usuario, string accion)
        {
            var sp = "USP_MERGE_USUARIO";
            var parameters = new DynamicParameters();

            parameters.Add("CODUSUARIO", usuario.codUsu, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameters.Add("APEUSUARIO", usuario.apeUsu, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameters.Add("NOMUSUARIO", usuario.nomUsu, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameters.Add("CORUSUARIO", usuario.corUsu, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameters.Add("CONUSUARIO", usuario.corUsu, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameters.Add("FECCRE", usuario.corUsu, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameters.Add("CODEMPLEADO", usuario.corUsu, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameters.Add("CODROL", usuario.corUsu, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            
            try
            {
                using var conexion = new SqlConnection(cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters);
                return $"Se ha realizado la {accion} de {respuesta} usuario.";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> DeleteUsuario(int codUsu){
            var sp = "USP_DELETE_USUARIO";
            var parameters = new DynamicParameters();

            parameters.Add("CODUSUARIO", codUsu, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            
            try
            {
                using var conexion = new SqlConnection(cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters);
                return $"Se ha realizar la eliminación de {respuesta} usuario.";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
