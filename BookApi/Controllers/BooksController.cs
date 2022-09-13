using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.JsonPatch; //for patch
using BookApi.Models;
using System;

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
    public async Task<ActionResult<Book>> Post(Book book)
    {
      _db.Books.Add(book);
      await _db.SaveChangesAsync();
      return CreatedAtAction("Post", new { id = book.BookId }, book);
      
    }

    // PATCH: api/Books/{id}
    [HttpPatch("{id}")]
    public async Task<IActionResult> Patch(int id, [FromBody] JsonPatchDocument<Book> patchBookToPatch)
    {
      var BookToPatch = _db.Books.FirstOrDefault(e => e.BookId == id);

      if (BookToPatch == null)
      {
        return NotFound();
      }

      patchBookToPatch.ApplyTo(BookToPatch, ModelState);
      
      _db.Entry(BookToPatch).State = EntityState.Modified;
      await _db.SaveChangesAsync();
    
      return Ok(BookToPatch);
    }


  }
}