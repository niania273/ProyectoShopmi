using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace proyectoShopmi.Models
{
    public class Empleado
    {
        [Key]
        [DisplayName("Código")]
        public int codEmp { get; set; }
        
        [DisplayName("DNI")]
        public string? numDoc { get; set; }
        
        [DisplayName("Nombres")]
        public string? nomEmp { get; set; }
        
        [DisplayName("Apellidos")]
        public string? apeEmp { get; set; }
        
        [DisplayName("Dirección")]
        public string? dirEmp { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Fecha de Nacimiento")]
        public DateTime fechaNac { get; set; }

        [DisplayName("Sexo")]
        public string? sexEmp { get; set; }

        [DisplayName("Correo")]
        public string? corEmp { get; set; }

        [DisplayName("Estado")]
        public bool estEmp { get; set; }

        //Relación Empleado y Distrito
        [DisplayName("Distrito")]
        public int codDis { get; set; }
        public virtual Distrito Distrito { get; set; }
    }
}
