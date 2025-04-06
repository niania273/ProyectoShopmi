using System.ComponentModel.DataAnnotations;

namespace proyectoShopmi.Models
{
    public class Categoria
    {
        [Key]
        public int codcategoria { get; set; }
        public string nombremarca { get; set; }
        public bool estmarca { get; set; }
    }
}

