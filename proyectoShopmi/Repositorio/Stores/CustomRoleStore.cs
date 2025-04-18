using Dapper;
using System.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;

namespace proyectoShopmi.Repositorio.Stores
{
    public class CustomRoleStore : IRoleStore<IdentityRole<int>>
    {
        private readonly IConfiguration _config;
        private readonly string _cadena;
        public CustomRoleStore(IConfiguration config)
        {
            _config = config;
            _cadena = _config.GetConnectionString("Conexion") ?? "";
        }
        public async Task<IdentityResult> CreateAsync(IdentityRole role, CancellationToken cancellationToken)
        {
            var sp = "USP_INSERT_ROLE";
            var parameters = new DynamicParameters();
            parameters.Add("Name", role.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("Id", int.Parse(role.Id), DbType.Int32, ParameterDirection.Output);
            try
            {
                using var conexion = new SqlConnection(_cadena);
                var id = await conexion.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                role.Id = parameters.Get<int>("Id").ToString();
                return IdentityResult.Success;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<IdentityResult> CreateAsync(IdentityRole<int> role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> DeleteAsync(IdentityRole role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> DeleteAsync(IdentityRole<int> role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }

        public async Task<IdentityRole?> FindByIdAsync(string roleId, CancellationToken cancellationToken)
        {
            var sp = "USP_GET_ROLE";
            var parameters = new DynamicParameters();
            parameters.Add("Id", int.Parse(roleId), DbType.Int32, ParameterDirection.Input);
            try
            {
                using var conexion = new SqlConnection(_cadena);
                var result = await conexion.QueryFirstOrDefaultAsync<IdentityRole>(sp, parameters, commandType: CommandType.StoredProcedure);

                return new IdentityRole
                {
                    Id = result.Id.ToString(),
                    Name = result.Name,
                    NormalizedName = result.Name.ToUpper()
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<IdentityRole?> FindByNameAsync(string normalizedRoleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string?> GetNormalizedRoleNameAsync(IdentityRole role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string?> GetNormalizedRoleNameAsync(IdentityRole<int> role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetRoleIdAsync(IdentityRole role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetRoleIdAsync(IdentityRole<int> role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string?> GetRoleNameAsync(IdentityRole role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string?> GetRoleNameAsync(IdentityRole<int> role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetNormalizedRoleNameAsync(IdentityRole role, string? normalizedName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetNormalizedRoleNameAsync(IdentityRole<int> role, string? normalizedName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetRoleNameAsync(IdentityRole role, string? roleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetRoleNameAsync(IdentityRole<int> role, string? roleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(IdentityRole role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(IdentityRole<int> role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<IdentityRole<int>?> IRoleStore<IdentityRole<int>>.FindByIdAsync(string roleId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<IdentityRole<int>?> IRoleStore<IdentityRole<int>>.FindByNameAsync(string normalizedRoleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
