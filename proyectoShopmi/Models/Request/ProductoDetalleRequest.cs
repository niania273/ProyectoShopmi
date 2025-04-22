using System.ComponentModel;

namespace proyectoShopmi.Models.Request
{
    public class ProductoDetalleRequest
    {
        [DisplayName("Código de Producto")]
        public int codProducto { get; set; }

        [DisplayName("Precio Unitario")]
        public decimal preUni { get; set; }

        [DisplayName("Stock")]
        public int stock { get; set; }
    }
}
