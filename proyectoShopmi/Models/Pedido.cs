using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace proyectoShopmi.Models
{
    public class Pedido
    {
        [Key]
        [DisplayName("Código")]
        public int codpedido { get; set; }
        
        [DisplayName("Cliente")]
        public int codcliente { get; set; }
      
        [DisplayName("Empleado")]
        public int codempleado { get; set; }  
        
        [DisplayName("Fecha del Pedido")]
        public DateTime fecped { get; set; }
        
        [DisplayName("Precio Total")]
        public decimal preciototal { get; set; }

        [DisplayName("Cantidad")]
        public int cantidad { get; set; }

        [DisplayName("Estado")]
        public bool estped { get; set; }

        //Relación Empleado y Distrito
        public int codDis { get; set; }
        public Distrito? Distrito { get; set; }
    }
}
