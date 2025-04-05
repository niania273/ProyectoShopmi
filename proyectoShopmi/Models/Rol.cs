using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace proyectoShopmi.Models
{
    public class Rol
    {
        [Key]
        [DisplayName("Código")]
        public int codRol { get; set; }

        [DisplayName("Nombre")]
        public string? nomRol { get; set; }

        [DisplayName("Estado")]
        public bool estRol { get; set; }
    }
}
