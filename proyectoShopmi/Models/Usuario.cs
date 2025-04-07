using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace proyectoShopmi.Models
{
    public class Usuario
    {
        [Key]
        [DisplayName("Código")]
        public int codUsu { get; set; }

        [DisplayName("Nombres")]
        public string? nomUsu { get; set; }
        
        [DisplayName("Apellidos")]
        public string? apeUsu { get; set; }

        [DisplayName("Correo")]
        public string? corUsu { get; set; }

        [DisplayName("Contraseña")]
        public string? conUsu { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Fecha de Creación")]
        public string? fecCre { get; set; }

        [DisplayName("Estado")]
        public string? estUsu { get; set; }

        //Relación Usuario y Empleado
        [DisplayName("Referencia Empleado")]
        public int codEmp { get; set; }
        public virtual Empleado Empleado { get; set; }

        //Relación Usuario y Rol
        [DisplayName("Referencia Rol")]
        public int codRol { get; set; }
        public virtual Rol Rol { get; set; }

    }
}
