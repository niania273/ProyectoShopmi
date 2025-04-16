using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace proyectoShopmi.Models.Response
{
    public class ProductoResponse
    {
        [Key]
        [DisplayName("Código de Producto")]
        public int codProducto { get; set; }

        [DisplayName("Imagen")]
        public string? imgProducto { get; set; }

        [DisplayName("Nombre del Producto")]
        public string? nomProducto { get; set; } 

        [DisplayName("Descripción")]
        public string? descripcion { get; set; } 

        [DisplayName("Precio Unitario")]
        public decimal preUni { get; set; }

        [DisplayName("Stock")]
        public int stock { get; set; }

        [DisplayName("Estado")]
        public bool estProducto { get; set; }

        [DisplayName("Categoría")]
        public string? nomCategoria { get; set; }

        [DisplayName("Marca")]
        public string? nombreMarca { get; set; }
    }
}

