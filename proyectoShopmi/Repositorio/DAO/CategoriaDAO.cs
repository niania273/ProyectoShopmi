using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio.Interfaces;

namespace proyectoShopmi.Repositorio.DAO
{
    public class CategoriaDAO : ICategoria
    {
        private readonly string cadena;

        public CategoriaDAO()
        {
            cadena = new ConfigurationBuilder().AddJsonFile("appdettings.json").Build().GetConnectionString("Conexion") ?? "";
        }
        public async Task<Categoria> getCategoria(int codcategoria)
        {
            var sp = "USP_GET_ID_CATEGORIA";
            var parameters = new DynamicParameters();
            parameters.Add("CODCATEGORIA", codcategoria, System.Data.DbType.Int32,System.Data.ParameterDirection.Input);

            try
            {
                using var conexion = new SqlConnection(cadena);
                var registro = await conexion.QueryFirstOrDefaultAsync<Categoria>(sp, parameters, commandType: CommandType.StoredProcedure);
                return registro;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); 
            }
        }

        public Task<string> insertCategoria(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Task<string> updateCategoria(Categoria categoria)
        {
            throw new NotImplementedException();
        }
    }
}

