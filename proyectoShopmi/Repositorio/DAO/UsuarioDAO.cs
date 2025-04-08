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

        public async Task<string> MergeUsuario(Usuario usuario)
        {
            var sp = "USP_MERGE_USUARIO";
            var mensaje = "";
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
                mensaje = $"Se ha generado {respuesta} usuario.";
                return mensaje;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
