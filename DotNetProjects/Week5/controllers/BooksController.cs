using Microsoft.AspNetCore.Mvc;
using Week5.models;
using Week5.models.requests;

namespace Week5.controllers {

    [ApiController]
    [Route("[controller]")]

    public class BooksController: ControllerBase {
        private static List<Book> BOOKS = new List<Book> {
            new Book {BookId = "1", Title = "The Great Gatsby", Genre = "Fiction", AuthorId = "1"},
            new Book {BookId = "2", Title = "The Da Vinci Code", Genre = "Mystery", AuthorId = "2"},
            new Book {BookId = "3", Title = "To Kill a Mockingbird", Genre = "Fiction", AuthorId = "3"},
            new Book {BookId = "4", Title = "The Catcher in the Rye", Genre = "Fiction", AuthorId = "4"},
            new Book {BookId = "5", Title = "The Hobbit", Genre = "Fantasy", AuthorId = "5"},
            new Book {BookId = "6", Title = "The Hunger Games", Genre = "Science Fiction", AuthorId = "6"},
            new Book {BookId = "7", Title = "The Help", Genre = "Historical Fiction", AuthorId = "7"},

        };

        [HttpGet("", Name = "GetBooks")]
        public List<Book> GetBooks() {
            return BOOKS;
        }

        [HttpGet("{bookId}", Name = "GetBookById")]
        public Book? GetBookById(string bookId) {
            return BOOKS.Find(book => book.BookId == bookId);
        }

        [HttpPost("", Name = "PostBook")]
        public Book PostBook(BookCreateRequest request) {
            Book bookToSave = new Book {
                BookId = (BOOKS.Count + 1).ToString(),
                Title = request.Title,
                Genre = request.Genre,
                AuthorId = request.AuthorId
            };

            BOOKS.Add(bookToSave);
            return bookToSave;
        }



    }
}