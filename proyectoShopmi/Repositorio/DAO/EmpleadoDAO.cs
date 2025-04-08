using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Repositorio.DAO
{
    public class EmpleadoDAO : IEmpleado
    {
        private static string cadena = "";

        public EmpleadoDAO()
        {
            cadena = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json").Build().GetConnectionString("Conexion") ?? "";
        }

        public async Task<IEnumerable<Empleado>> GetEmpleados()
        {
            var sp = "USP_GET_EMPLEADO";
            try
            {
                using var conexion = new SqlConnection(cadena);
                var listado = await conexion.QueryAsync<Empleado>(sp);
                return listado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Empleado> GetEmpleado(int codEmp)
        {
            var sp = "USP_GET_ID_EMPLEADO";
            var parameters = new DynamicParameters();

            parameters.Add("CODEMPLEADO", codEmp, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);
                var registro = await conexion.QueryFirstOrDefaultAsync<Empleado>(sp);
                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> MergeEmpleado(Empleado empleado)
        {
            var sp = "USP_MERGE_EMPLEADO";
            var mensaje = "";
            var parameters = new DynamicParameters();

            parameters.Add("CODEMPLEADO", empleado.codempleado, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameters.Add("NUMERODOCUMENTO", empleado.numerodocumento, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameters.Add("APELLIDOS", empleado.apellidos, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameters.Add("NOMBRES", empleado.nombres, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameters.Add("CODDISTRITO", empleado.coddistrito, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameters.Add("DIRECCION", empleado.direccion, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameters.Add("FECNAC", empleado.fecnac, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameters.Add("SEXO", empleado.sexo, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameters.Add("CORREO", empleado.correo, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameters.Add("ESTEMPLEADO", empleado.estempleado, System.Data.DbType.String, System.Data.ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters);
                mensaje = $"Se ha generado {respuesta} empleado.";
                return mensaje;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> DeleteEmpleado(int codEmp)
        {
            var sp = "USP_DELETE_EMPLEADO";
            var mensaje = "";
            var parameters = new DynamicParameters();

            parameters.Add("CODEMPLEADO", codEmp, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);
                var respuesta = await conexion.ExecuteAsync(sp, parameters);
                mensaje = $"Se ha eliminado {respuesta} empleado.";
                return mensaje;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
