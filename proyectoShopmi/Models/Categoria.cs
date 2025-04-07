using System.ComponentModel.DataAnnotations;

namespace proyectoShopmi.Models
{
    public class Categoria
    {
        [Key]
        public int codcategoria { get; set; }
        [DisplayName("Nombre de la Marca")]
        public string nombremarca { get; set; }
        public bool estmarca { get; set; }
    }
}

