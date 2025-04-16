using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models.Response;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Repositorio
{
    public class SucursalRepository : ISucursalRepository
    {
        private readonly IConfiguration _config;
        private readonly string _cadena;
        public SucursalRepository(IConfiguration config)
        {
            _config = config;
            _cadena = _config.GetConnectionString("Conexion") ?? "";
        }
        public async Task<IEnumerable<SelectResponse>> SelectSucursales()
        {
            var sp = "USP_GET_SUCURSAL";
            var parameters = new DynamicParameters();
            try
            {
                using var conexion = new SqlConnection(_cadena);
                var listado = await conexion.QueryAsync<SelectResponse>(sp, parameters);
                return listado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
