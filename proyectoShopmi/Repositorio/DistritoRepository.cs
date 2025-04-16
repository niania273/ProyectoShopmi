using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models.Response;
using proyectoShopmi.Repositorio.Interfaces;
using System.Data;

namespace proyectoShopmi.Repositorio
{
    public class DistritoRepository : IDistritoRepository
    {

        private readonly IConfiguration _config;
        private readonly string _cadena;
        public DistritoRepository(IConfiguration config)
        {
            _config = config;
            _cadena = _config.GetConnectionString("Default") ?? "";
        }

        public async Task<IEnumerable<SelectResponse>> SelectDistritos()
        {
            var sp = "USP_GET_DISTRITO";
            var parameters = new DynamicParameters();
            try
            {
                using var conexion = new SqlConnection(_cadena);
                var listado = await conexion.QueryAsync<SelectResponse>(sp, parameters, commandType: CommandType.StoredProcedure);
                return listado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
