using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models.Response;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Repositorio
{
    public class RolRepository : IRolRepository
    {
        private readonly IConfiguration _config;
        private readonly string _cadena;
        public RolRepository(IConfiguration config)
        {
            _config = config;
            _cadena = _config.GetConnectionString("Conexion") ?? "";
        }
        public async Task<IEnumerable<SelectResponse>> SelectRoles()
        {
            var sp = "USP_GET_ROL";
            try
            {
                using var conexion = new SqlConnection(_cadena);
                var listado = await conexion.QueryAsync<SelectResponse>(sp);
                return listado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
