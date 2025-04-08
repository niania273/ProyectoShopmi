using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace proyectoShopmi.Models
{
    public class Distrito
    {
        [Key]
        public int coddsitrito { get; set; }

        [DisplayName("Nombre del distrito")]

        public string nombredistrito { get; set; } = null!;

        public string codpostal { get; set; } = null!;

        public bool estdistrito { get; set; }
    }
}
