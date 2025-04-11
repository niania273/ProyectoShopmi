using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace proyectoShopmi.Models
{
    public class Empleado
    {
        [Key]
        [DisplayName("Código")]
        public int codempleado { get; set; }
        
        [DisplayName("DNI")]
        public string? numerodocumento { get; set; }
        
        [DisplayName("Nombres")]
        public string? nombres { get; set; }
        
        [DisplayName("Apellidos")]
        public string? apellidos { get; set; }
        
        [DisplayName("Dirección")]
        public string? direccion { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Fecha de Nacimiento")]
        public DateTime fecnac { get; set; }

        [DisplayName("Sexo")]
        public string? sexo { get; set; }

        [DisplayName("Correo")]
        public string? correo { get; set; }

        [DisplayName("Estado")]
        public bool estempleado { get; set; }

        //Relación Empleado y Distrito
        [DisplayName("Distrito")]
        public int coddistrito { get; set; }
    }
}
