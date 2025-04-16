using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Repositorio
{
    public class UsuarioRepository : IUsuario
    {
        private readonly string cadena;

        public UsuarioRepository()
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
            parameters.Add("CODUSUARIO", codUsu, DbType.Int32, ParameterDirection.Input);

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

            parameters.Add("CODUSUARIO", usuario.codUsu, DbType.Int32, ParameterDirection.Input);
            parameters.Add("APEUSUARIO", usuario.apeUsu, DbType.Int32, ParameterDirection.Input);
            parameters.Add("NOMUSUARIO", usuario.nomUsu, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CORUSUARIO", usuario.corUsu, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CONUSUARIO", usuario.corUsu, DbType.Int32, ParameterDirection.Input);
            parameters.Add("FECCRE", usuario.corUsu, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CODEMPLEADO", usuario.corUsu, DbType.Int32, ParameterDirection.Input);
            parameters.Add("CODROL", usuario.corUsu, DbType.Int32, ParameterDirection.Input);
            
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

            parameters.Add("CODUSUARIO", codUsu, DbType.Int32, ParameterDirection.Input);
            
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
