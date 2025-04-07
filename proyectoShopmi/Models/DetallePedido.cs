using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoShopmi.Models
{
    public class DetallePedido
    {
        [Key, Column(Order = 0)]
        [DisplayName("Código de Pedido")]
        public int codPedido { get; set; }

        [Key, Column(Order = 1)]
        [DisplayName("Código de Producto")]
        public int codProducto { get; set; }

        [DisplayName("Precio Unitario")]
        public decimal preUni { get; set; }

        [DisplayName("Cantidad")]
        public int cantidad { get; set; }

        [DisplayName("Estado")]
        public bool estPP { get; set; }

        // Relacion de Pedido y Producto 
        public Pedido? Pedido { get; set; }
        public Producto? Producto { get; set; }
    }
}
