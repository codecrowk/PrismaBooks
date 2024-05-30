using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PrismaBooks.Data;
using PrismaBooks.Models;
using PrismaBooks.Services.HttpMethods;

namespace PrismaBooks.Services.BooksRepository.Methods
{
  public class BooksUpdate: IHttpPut<Book>
  {
    private readonly BaseContext _context;
    public BooksUpdate(BaseContext context){
      _context = context;
    }

    public Book Update(Book book)
    {
      _context.Entry(book).State = EntityState.Modified;
      _context.SaveChanges();
      return book;
    }
  } 
}