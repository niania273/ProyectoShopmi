using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace proyectoShopmi.Models
{
    public class Categoria
    {
        [Key]
        public int codcategoria { get; set; }
        public string imgcategoria { get; set; } = null!;
        [DisplayName("Nombre de la Categoria")]
        public string nomcategoria { get; set; } = null!;
        public bool estcategoria { get; set; }
    }
}

