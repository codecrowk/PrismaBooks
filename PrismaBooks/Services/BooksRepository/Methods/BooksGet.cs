using PrismaBooks.Data;
using PrismaBooks.Models;
using PrismaBooks.Services.HttpMethods;

namespace PrismaBooks.Services.BooksRepository.Methods
{
  public class BooksGet: IHttpGet<Book>
  {
    private readonly BaseContext _context;
    public BooksGet(BaseContext context){
      _context = context;
    }
        
    public IEnumerable<Book> GetAll()
    {
      return _context.Books.ToList();
    }

    public Book GetById(int id)
    {
      var book = _context.Books.Find(id);
      return book;
    }
  } 
}