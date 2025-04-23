using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace proyectoShopmi.Models.Request
{
    public class ProductoFormRequest
    {
        [Key]
        [DisplayName("Código de Producto")]
        public int codProducto { get; set; }

        [DisplayName("Imagen")]
        public IFormFile? imgProducto { get; set; }

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
        public int codCategoria { get; set; }

        [DisplayName("Marca")]
        public int codMarca { get; set; }

        public string? imgActual { get; set; }
    }
}
