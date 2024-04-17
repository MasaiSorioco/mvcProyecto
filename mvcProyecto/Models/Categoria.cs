using System.ComponentModel.DataAnnotations;

namespace mvcProyecto.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
