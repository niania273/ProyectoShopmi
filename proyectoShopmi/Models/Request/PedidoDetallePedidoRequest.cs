using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace proyectoShopmi.Models.Request
{
    public class PedidoDetallePedidoRequest
    {
        [Key]
        [DisplayName("Código")]
        public int codPedido { get; set; }

        [DisplayName("Usuario")]
        public int codUsuario { get; set; }

        [DisplayName("Precio Total")]
        public decimal precioTotal { get; set; }

        public List<ProductoDetalleRequest> productos { get; set; }
        public int[] cantidades { get; set; }
    }
}
