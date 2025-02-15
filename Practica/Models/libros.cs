using System.ComponentModel.DataAnnotations;

namespace Practica.Models
{
    public class libros
    {
        [Key]
        public int Id_libro { get; set; }
        public int Id_autor { get; set; }
        public string titulo { get; set; }
        public string resumen { get; set; }
        public int anioPublicacion { get; set; }
        public int Id_categoria { get; set; }
        
    }
}
