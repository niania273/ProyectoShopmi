using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Repositorio.DAO
{
    public class marcaDAO : IMarca
    {
        private readonly string cadena;

        public marcaDAO()
        {
            cadena = new ConfigurationBuilder().AddJsonFile("appdettings.json").Build().GetConnectionString("Conexion") ?? "";
        }

        public async Task<Marca> GetMarca(int codMarca)
        {
            var sp = "USP_GET_ID_MARCA";
            var parameters = new DynamicParameters();
            parameters.Add("CODMARCCA", codMarca, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);

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

        public Task<string> insertMarca(Marca marca)
        {
            throw new NotImplementedException();
        }
        
        public Task<string> updateMarca(Marca marca)
        {
            throw new NotImplementedException();
        }
    }
}
