using Microsoft.Data.SqlClient;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.Interfaces;
using Dapper;

namespace proyectoShopmi.Repositorio.DAO
{

    public class ClienteDAO : ICliente
    {
        private readonly string cadena ="";

        public ClienteDAO()
        {
            cadena = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("Conexion") ?? "";

        }

        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            var sp = "USP_GET_CLIENTE";
            try
            {
                using var conexion = new SqlConnection(cadena);
                var listado = await conexion.QueryAsync<Cliente>(sp);
                return listado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Cliente> GetCliente(int codCliente)
        {
            var sp = "USP_GET_ID_CLIENTE";
            var parameters = new DynamicParameters();
            parameters.Add("CODCLIENTE", codCliente, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);

                var registro = await conexion.QueryFirstOrDefaultAsync<Cliente>(sp);

                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        

        public async Task<string> MergeCliente(Cliente cliente)
        {
            var sp = "USP_GET_MERGE_CLIENTE";
            var mensaje = "";
            var parameters = new DynamicParameters();

            parameters.Add("CODCLIENTE", cliente.codcliente, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameters.Add("NUMEROCOMDOCUMENTO", cliente.numerocomdocumento, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameters.Add("APELLIDOS", cliente.apellidos, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameters.Add("NOMBRES", cliente.nombres, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameters.Add("CODDISTRITO", cliente.coddistrito, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameters.Add("DIRECCION", cliente.direccion, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameters.Add("FECNAC", cliente.fecnac, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameters.Add("SEXO", cliente.sexo, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameters.Add("CORREO", cliente.correo, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameters.Add("TELEFONO", cliente.telefono, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameters.Add("ESTCLIENTE", cliente.estcliente, System.Data.DbType.String, System.Data.ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters);
                mensaje = $"Se ha realizado la {respuesta} de {respuesta} cliente.";
                return mensaje;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<string> DeleteCliente(int codcliente)
        {
            var sp = "USP_DELETE_CLIENTE";
            var mensaje = "";
            var parameters = new DynamicParameters();

            parameters.Add("CODCLIENTE", codcliente, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters);
                mensaje = $"Se ha eliminado {respuesta} cliente.";
                return mensaje;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
