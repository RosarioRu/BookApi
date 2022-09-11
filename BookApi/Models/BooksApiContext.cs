using Microsoft.EntityFrameworkCore;

namespace BookApi.Models
{
    public class BooksApiContext : DbContext
    {
        public BooksApiContext(DbContextOptions<BooksApiContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}