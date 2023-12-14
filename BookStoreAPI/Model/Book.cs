using System.ComponentModel.DataAnnotations;

namespace BookStorageAPI.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Author { get; set; }

        public string? Description { get; set; }

        [Required]
        public string? Genre { get; set; }
    }
}
