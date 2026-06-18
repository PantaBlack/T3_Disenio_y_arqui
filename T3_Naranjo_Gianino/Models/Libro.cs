using System.ComponentModel.DataAnnotations;

namespace T3_Naranjo_Gianino.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "El tema es obligatorio")]
        public string Tema { get; set; }

        [Required(ErrorMessage = "La editorial es obligatoria")]
        public string Editorial { get; set; }

        [Required(ErrorMessage = "El año de publicación es obligatorio")]
        [Range(1900, 3000,
            ErrorMessage = "El año debe estar entre 1900 y 3000")]
        public int AnioPublicacion { get; set; }

        [Required(ErrorMessage = "La cantidad de páginas es obligatoria")]
        [Range(10, 1000,
            ErrorMessage = "Las páginas deben estar entre 10 y 1000")]
        public int Paginas { get; set; }

        [Required(ErrorMessage = "La categoría es obligatoria")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "El material es obligatorio")]
        public string Material { get; set; }

        [Required(ErrorMessage = "La cantidad de copias es obligatoria")]
        [Range(1, 20,
            ErrorMessage = "Las copias deben estar entre 1 y 20")]
        public int Copias { get; set; }
    }
}