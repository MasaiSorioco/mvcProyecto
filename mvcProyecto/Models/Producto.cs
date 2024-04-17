using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace mvcProyecto.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
