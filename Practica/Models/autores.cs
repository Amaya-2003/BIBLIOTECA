using System.ComponentModel.DataAnnotations;
namespace Practica.Models
{
    public class autores
    {
        [Key]
        public int Id_autor { get; set; }
        public string nombre { get; set; }
        public string origen { get; set; }
    }
}

