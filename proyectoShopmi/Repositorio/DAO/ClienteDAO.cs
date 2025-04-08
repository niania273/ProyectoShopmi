using Microsoft.Data.SqlClient;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.Interfaces;
using System.Data;
using Dapper;

namespace proyectoShopmi.Repositorio.DAO
{

    public class ClienteDAO : ICliente
    {
        private readonly string cadena;

        public ClienteDAO()
        {
            cadena = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("Conexion") ?? "";

        }
        public async Task<Cliente> getCliente(int codCliente)
        {
            var sp = "USP_GET_ID_CLIENTE";
            var parameters = new DynamicParameters();
            parameters.Add("CODCLIENTE", codCliente, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);

                var registro = await conexion.QueryFirstOrDefaultAsync<Cliente>(sp, parameters, commandType: CommandType.StoredProcedure);

                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Task<string> insertCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<string> updateCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }


    }
}
