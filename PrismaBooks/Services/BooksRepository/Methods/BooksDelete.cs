using Microsoft.EntityFrameworkCore;
using PrismaBooks.Data;
using PrismaBooks.Models;
using PrismaBooks.Services.HttpMethods;

namespace PrismaBooks.Services.BooksRepository.Methods
{
  public class BooksDelete: IHttpDelete<Book>
  {
    private readonly BaseContext _context;
    public BooksDelete(BaseContext context){
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