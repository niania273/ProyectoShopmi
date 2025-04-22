using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace proyectoShopmi.Models
{
    public class PedidoRequest
    {
        [Key]
        [DisplayName("Código")]
        public int codPedido { get; set; }

        [DisplayName("Usuario")]
        public int codUsuario { get; set; }

        [DisplayName("Fecha del Pedido")]
        public DateTime fecPed { get; set; }

        [DisplayName("Precio Total")]
        public decimal precioTotal { get; set; }
    }
}
