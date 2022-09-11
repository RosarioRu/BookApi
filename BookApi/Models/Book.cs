using System.ComponentModel.DataAnnotations;

namespace BookApi.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Reviews { get; set; }
        
        [Required]
        public int Rating { get; set; }
    }
}