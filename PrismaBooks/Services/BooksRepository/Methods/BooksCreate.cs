using PrismaBooks.Data;
using PrismaBooks.Models;
using PrismaBooks.Services.HttpMethods;

namespace PrismaBooks.Services.BooksRepository.Methods
{
  public class BooksCreate: IHttpPost<Book>
  {
    private readonly BaseContext _context;
    public BooksCreate(BaseContext context){
      _context = context;
    }

    public Book Create(Book book)
    {
      _context.Books.Add(book);
      _context.SaveChanges();
      return book;
    }
  } 
}