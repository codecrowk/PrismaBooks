using PrismaBooks.Data;
using PrismaBooks.Models;
using PrismaBooks.Services.HttpMethods;

// namespace PrismaBooks.Services.BooksRepository.Methods
namespace PrismaBooks.Services.AuthorsRepository.Methods
{
  public class AuthorsDelete: IHttpDelete<Author>
  {
    private readonly BaseContext _context;
    public AuthorsDelete(BaseContext context){
      _context = context;
    }

    public int Delete(int id)
    {
      var book = _context.Books.Find(id);
      _context.Books.Remove(book);
      _context.SaveChanges();
      return book.Id;
    }
  } 
}