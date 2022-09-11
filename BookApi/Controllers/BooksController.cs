using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookApi.Models;

namespace BookApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BooksController : ControllerBase
  {
    private readonly BooksApiContext _db;

    public BooksController(BooksApiContext db)
    {
      _db = db;
    }

    // GET api/Books
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Book>>> Get()
    {
      return await _db.Books.ToListAsync();
    }

    // POST api/Books
    [HttpPost]
    public async Task<ActionResult<Book>> Post(Book Book)
    {
      _db.Books.Add(Book);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = Book.BookId }, Book);
    }
  }
}