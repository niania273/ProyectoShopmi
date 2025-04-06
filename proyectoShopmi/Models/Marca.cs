using System.ComponentModel.DataAnnotations;

namespace proyectoShopmi.Models
{
    public class Marca
    {
        [Key]
        public int codMarca { get; set; }
        public string nombremarca { get; set; }
        public bool estmarca { get; set; }
    }
} 

