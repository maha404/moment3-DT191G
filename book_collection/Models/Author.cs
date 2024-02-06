using System.ComponentModel.DataAnnotations;

namespace book_collection.Model
{
        public class Author 
        {
        // properties
        
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

    }
}

