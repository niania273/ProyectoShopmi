using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.Interfaces;
using System.Data;

namespace proyectoShopmi.Repositorio.DAO
{
    public class DistritoDAO : IDistrito
    {

        private readonly string cadena;

        public DistritoDAO()
        {
            cadena = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("Conexion") ?? "";
        }

        public async Task<IEnumerable<Distrito>> getDistrito()
        {
            var sp = "USP_GET_DISTRITO";

            try
            {
                using var conexion = new SqlConnection(cadena);
                var listado = await conexion.QueryAsync<Distrito>(sp, commandType: CommandType.StoredProcedure);
                return listado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
