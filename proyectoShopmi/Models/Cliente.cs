using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace proyectoShopmi.Models
{
    public class Cliente
    {
        [Key]
        [DisplayName("Codigo")]
        public int codcliente { get; set; }

        [DisplayName("Numjero de Documento")]
        public string? numerocomdocumento { get; set; }

        [DisplayName("Apellido")]
        public string? apellidos { get; set; }

        [DisplayName("Nombre")]
        public string? nombres { get; set; }

        [DisplayName("Direccion")]
        public string? direccion { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Fecha de Nacimiento")]
        public string? fecnac { get; set; }

        [DisplayName("Sexo")]
        public string? sexo { get; set; }

        [DisplayName("Correo")]
        public string? correo { get; set; }

        [DisplayName("Telefono")]
        public bool telefono { get; set; }

        [DisplayName("Estado")]
        public bool estcliente { get; set; }

        [DisplayName("Distrito")]
        public int coddistrito { get; set; }
        public Distrito? Distrito { get; set; }
    }
}
