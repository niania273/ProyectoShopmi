using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Repositorio.DAO
{
    public class RolDAO : IRol
    {
        private readonly string cadena;

        public RolDAO()
        {
            cadena = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json").Build().GetConnectionString("Conexion") ?? "";
        }
        public async Task<IEnumerable<Rol>> GetRoles()
        {
            var sp = "USP_GET_ROL";

            try
            {
                using var conexion = new SqlConnection(cadena);
                var listado = await conexion.QueryAsync<Rol>(sp);
                return listado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
