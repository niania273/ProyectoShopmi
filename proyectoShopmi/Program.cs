using Microsoft.AspNetCore.Identity;
using proyectoShopmi.Models;
using proyectoShopmi.Repositorio;
using proyectoShopmi.Repositorio.Interfaces;
using proyectoShopmi.Repositorio.Stores;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.FileProviders;


var builder = WebApplication.CreateBuilder(args);

//Agrega esta línea para definir la política CORS

var origenesPermitidos = builder.Configuration.GetValue<string>("OrigenesPermitidos")!.Split(",");

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(politica =>
        {
            politica.WithOrigins(origenesPermitidos).AllowAnyHeader().AllowAnyMethod();
        });
});

// Add services to the container.
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<IMarcaRepository, MarcaRepository>();
builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
builder.Services.AddScoped<IDistritoRepository, DistritoRepository>();
builder.Services.AddScoped<ISucursalRepository, SucursalRepository>();
builder.Services.AddScoped<IJwtTokenRepository, JwtTokenRepository>();

// Configuración de Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole<int>>()
    .AddUserStore<CustomUserStore>()
    .AddRoleStore<CustomRoleStore>() // Asegúrate de usar CustomRoleStore aquí
    .AddSignInManager<SignInManager<ApplicationUser>>()
    .AddDefaultTokenProviders();

builder.Services.AddControllers();
// Aprende más sobre Swagger/OpenAPI en https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

////Autenticación
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

var app = builder.Build();



// Configura la canalización de solicitudes HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//// Usa la política CORS
app.UseCors();
app.UseAuthentication();
app.UseAuthorization();

app.UseStaticFiles();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "imagenes", "productos")),
    RequestPath = "/imagenes/productos"
});

app.MapControllers();

app.Run();
