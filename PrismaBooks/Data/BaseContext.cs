using Microsoft.EntityFrameworkCore;
using PrismaBooks.Models;

namespace PrismaBooks.Data
{
  public class BaseContext: DbContext
  {
    public BaseContext(DbContextOptions<BaseContext> options): base(options)
    { }

    public DbSet<Book> Books {get; set;}
    public DbSet<Author> Authors {get; set;}
    public DbSet<Publisher> Publishers {get; set;}
  }
}