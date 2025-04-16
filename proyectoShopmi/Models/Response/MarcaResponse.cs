using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace proyectoShopmi.Models.Response
{
    public class MarcaResponse
    {
        [Key]
        [DisplayName("C�digo")]
        public int codMarca { get; set; }
        [DisplayName("Nombre")]
        public string? nombremarca { get; set; }
        [DisplayName("Estado")]
        public bool estmarca { get; set; }
    }
} 


