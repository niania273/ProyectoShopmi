using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace proyectoShopmi.Models
{
    public class Pedido
    {
        [Key]
        [DisplayName("Código")]
        public int codPedido { get; set; }

        [DisplayName("Fecha del Pedido")]
        public DateTime fecPed { get; set; }

        [DisplayName("Precio Total")]
        public decimal precioTotal { get; set; }

        [DisplayName("Cantidad")]
        public int cantidad { get; set; }

        [DisplayName("Acción del Pedido")]
        public string? actPed { get; set; }

        [DisplayName("Estado")]
        public bool estPed { get; set; }

        [DisplayName("Cliente")]
        public int codCliente { get; set; }

        [DisplayName("Empleado")]
        public int codEmpleado { get; set; }
    }
}
