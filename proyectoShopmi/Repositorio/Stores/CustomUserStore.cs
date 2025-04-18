using Dapper;
using System.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using proyectoShopmi.Models;

namespace proyectoShopmi.Repositorio.Stores
{
    public class CustomUserStore : IUserStore<ApplicationUser>, IUserPasswordStore<ApplicationUser>
    {
        private readonly IConfiguration _config;
        private readonly string _cadena;
        private readonly IPasswordHasher<ApplicationUser> _passwordHasher;
        public CustomUserStore(IConfiguration config, IPasswordHasher<ApplicationUser> passwordHasher)
        {
            _config = config;
            _cadena = _config.GetConnectionString("Conexion") ?? "";
            _passwordHasher = passwordHasher;
        }

        public async Task<IdentityResult> CreateAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            var passwordHash = _passwordHasher.HashPassword(user, user.Contrasenia);
            user.PasswordHash = passwordHash;

            var sp = "USP_INSERT_USER";
            var parameters = new DynamicParameters();
            parameters.Add("NumeroDocumento", user.NumeroDocumento, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("Apellido", user.Apellido, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("Nombre", user.Nombre, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("FechaNacimiento", user.FechaNacimiento, dbType: DbType.Date, direction: ParameterDirection.Input);
            parameters.Add("Sexo", user.Sexo, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("Telefono", user.Telefono, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("Correo", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("PasswordHash", user.PasswordHash, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("Estado", true, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            parameters.Add("RolId", 1, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("NuevoId", dbType: DbType.Int32, direction: ParameterDirection.Output);

            try
            {
                using var conexion = new SqlConnection(_cadena);
                var id = await conexion.ExecuteAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                user.Id = parameters.Get<int>("NuevoId");
                return IdentityResult.Success;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<string?> GetNormalizedUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Email.ToUpper());
        }

        public Task<string?> GetPasswordHashAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.PasswordHash);
        }

        public Task<string> GetUserIdAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Id.ToString());
        }

        public Task<string?> GetUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Email);
        }

        public Task<bool> HasPasswordAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(!string.IsNullOrEmpty(user.PasswordHash));
        }

        public Task SetNormalizedUserNameAsync(ApplicationUser user, string? normalizedName, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task SetPasswordHashAsync(ApplicationUser user, string? passwordHash, CancellationToken cancellationToken)
        {
            user.PasswordHash = passwordHash;
            return Task.CompletedTask;
        }

        public Task SetUserNameAsync(ApplicationUser user, string? userName, CancellationToken cancellationToken)
        {
            user.Email = userName;
            return Task.CompletedTask;
        }

        //Operaciones
        public Task<IdentityResult> UpdateAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> DeleteAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }

        public Task<ApplicationUser?> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<ApplicationUser?> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            var sp = "USP_GET_USER_CORREO";
            var parameters = new DynamicParameters();
            parameters.Add("Correo", normalizedUserName, dbType: DbType.String, direction: ParameterDirection.Input);
            try
            {
                using var conexion = new SqlConnection(_cadena);
                var reg = await conexion.QueryFirstOrDefaultAsync<ApplicationUser>(sp, parameters, commandType: CommandType.StoredProcedure);
                return reg;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
