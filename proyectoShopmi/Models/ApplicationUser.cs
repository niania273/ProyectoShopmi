using Microsoft.AspNetCore.Identity;

namespace proyectoShopmi.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        public int Id { get; set; }
        public string NumeroDocumento { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char Sexo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }
        public int RolId { get; set; }

    }
}
