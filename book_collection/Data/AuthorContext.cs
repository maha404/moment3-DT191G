using Microsoft.EntityFrameworkCore;
using book_collection.Model;

namespace book_collection.Data 
{
    public class AuthorContext : DbContext
    {
        public AuthorContext(DbContextOptions<AuthorContext> options) : base(options) 
        {

        }

        public DbSet<Author> Author {get; set;}
        
    }
}

