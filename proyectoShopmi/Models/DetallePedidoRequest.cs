using System.ComponentModel;

namespace proyectoShopmi.Models
{
    public class DetallePedidoRequest
    {
        [DisplayName("Código de Pedido")]
        public int codPedido { get; set; }

        [DisplayName("Código de Producto")]
        public int codProducto { get; set; }

        [DisplayName("Precio Unitario")]
        public decimal preUni { get; set; }

        [DisplayName("Cantidad")]
        public int cantidad { get; set; }

        [DisplayName("Estado")]
        public bool estPP { get; set; }
    }
}
