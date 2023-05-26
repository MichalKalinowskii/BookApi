using BookAbstraction.Interfaces;
using BookModels.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Controllers
{
    [ApiController]
    [Route("bookapi")]
    public class BookController : Controller
    {
        private readonly IBookDbContext _context;


        public BookController(IBookDbContext context)
        {
            _context = context;
        }

        [HttpGet("books")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            var books = await _context.Set<Book>().ToListAsync();
            return Ok(books);
        }

        [HttpPost("book/create")]
        public async Task<ActionResult<Book>> AddBook(Book book)
        {
            _context.Set<Book>().Add(book);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("author/create")]
        public async Task<ActionResult<Book>> AddAuthor(Author author)
        {
            _context.Set<Author>().Add(author);
            return Ok();
        }

        [HttpPut("book/update")]
        public async Task<ActionResult<Book>> UpdateBook(Book book)
        {
            _context.Set<Book>().Update(book);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("book/delete")]
        public async Task<ActionResult<Book>> DeleteBook(Book book)
        {
            _context.Set<Book>().Remove(book);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
