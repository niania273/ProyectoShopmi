using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace proyectoShopmi.Models
{
    public class Categoria
    {
        [Key]
        public int codcategoria { get; set; }
        public string? imgcategoria { get; set; } 
        [DisplayName("Nombre de la Categoria")]
        public string? nomcategoria { get; set; } 
        public bool estcategoria { get; set; }
    }
}

