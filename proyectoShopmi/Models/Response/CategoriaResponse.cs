using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace proyectoShopmi.Models.Response
{
    public class CategoriaResponse
    {
        [Key]
        [DisplayName("C�digo")]
        public int codcategoria { get; set; }
        [DisplayName("Imagen")]
        public string? imgcategoria { get; set; } 
        [DisplayName("Nombre")]
        public string? nomcategoria { get; set; }
        [DisplayName("Estado")]
        public bool estcategoria { get; set; }
    }
}

