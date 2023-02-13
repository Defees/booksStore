using booksStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace booksStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly GravityBooksContext _gravityBooksContext;
        public AuthorController(GravityBooksContext gravityBooksContext)
        {
            _gravityBooksContext = gravityBooksContext;
        }

        [HttpGet]
        [Route("getAllAuthors")]
        public async Task<IActionResult> GetAllAuthors()
        {
            var authors = _gravityBooksContext.Authors.Where(x => x.AuthorName.StartsWith("A")).ToList();
            return Ok(authors);
        }
    }
}
