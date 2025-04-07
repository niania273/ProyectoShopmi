namespace proyectoShopmi.Models
{
    public class Distrito
    {
        [Key]
        public int coddsitrito { get; set; }
        
        [DisplayName("Nombre del distrito")]
        public string nombredistrito { get; set; }
        
        public string codpostal { get; set; }
        
        public bool estdistrito { get; set; }
    }
}
