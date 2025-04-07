using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoShopmi.Models
{
    public class Producto
    {
        [Key]
        [DisplayName("Código de Producto")]
        public int codProducto { get; set; }


        [DisplayName("Imagen")]
        public string imgProducto { get; set; }

        [DisplayName("Nombre del Producto")]
        public string nomProducto { get; set; } 

        [DisplayName("Descripción")]
        public string descripcion { get; set; } 

        [DisplayName("Precio Unitario")]
        public decimal preUni { get; set; }


        [DisplayName("Stock")]
        public int stock { get; set; }

        [DisplayName("Estado")]
        public bool estProducto { get; set; }

        // Relaciones (asumiendo que tienes estas entidades)

        [DisplayName("Categoría")]
        public int codCategoria { get; set; }
        public Categoria? Categoria { get; set; }


        [DisplayName("Marca")]
        public int codMarca { get; set; }
        public Marca? Marca { get; set; }

        // Relación inversa (opcional)
        public ICollection<DetallePedido>? DetallePedidos { get; set; }
    }
}
