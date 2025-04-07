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
            cadena = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("Conexion") ?? "";
        }

        public async Task<Usuario> getUsuario(int codUsu)
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

        public Task<string> insertUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<string> updateUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
