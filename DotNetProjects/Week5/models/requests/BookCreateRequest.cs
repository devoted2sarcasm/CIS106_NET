using System.ComponentModel.DataAnnotations;

namespace Week5.models.requests {

    public class BookCreateRequest {
        [Required(ErrorMessage = "Title is required")]
        [MinLength(1, ErrorMessage = "Title must be at least 1 characters long")]
        [MaxLength(100, ErrorMessage = "Title must be at most 100 characters long")]
        public string Title {get; set;}
        [Required(ErrorMessage = "Genre is required")]
        [MinLength(1, ErrorMessage = "Genre must be at least 1 characters long")]
        [MaxLength(100, ErrorMessage = "Genre must be at most 100 characters long")]
        public string Genre {get; set;} 
        [Required(ErrorMessage = "AuthorId is required")]
        public string AuthorId {get; set;}
    }


}