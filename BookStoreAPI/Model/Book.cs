using System.ComponentModel.DataAnnotations;

namespace BookStorageAPI.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Le titre ne doit pas dépasser 100 caractères.")]
        public string? Title { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Le nom de l'auteur ne doit pas dépasser 100 caractères.")]
        public string? Author { get; set; }

        [StringLength(500, ErrorMessage = "La description ne doit pas dépasser 500 caractères.")]
        public string? Description { get; set; }

        [Required]
        public string? Genre { get; set; }
    }
}

