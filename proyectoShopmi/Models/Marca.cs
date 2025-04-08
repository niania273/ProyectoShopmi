using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace proyectoShopmi.Models
{
    public class Marca
    {
        [Key]
        public int codMarca { get; set; }
        [DisplayName("Nombre de la Marca")]
        public string nombremarca { get; set; } = null!;
        public bool estmarca { get; set; }
    }
} 

