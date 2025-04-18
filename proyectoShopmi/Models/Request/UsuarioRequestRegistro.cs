namespace proyectoShopmi.Models.Request
{
    public class UsuarioRequestRegistro
    {
        public string NumeroDocumento { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char Sexo { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
    }
}
