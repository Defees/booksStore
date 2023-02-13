using booksStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace booksStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly GravityBooksContext _gravityBooksContext;
        public BooksController(GravityBooksContext gravityBooksContext)
        {
            _gravityBooksContext = gravityBooksContext;
        }
        [HttpGet]
        [Route("getAllBooks")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = _gravityBooksContext.Books.ToList();
            return Ok(books);
        }
    }
}
