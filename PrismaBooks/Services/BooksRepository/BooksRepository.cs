using PrismaBooks.Data;
using PrismaBooks.Models;
using PrismaBooks.Services.BooksRepository.Methods;

namespace PrismaBooks.Services.BooksRepository
{
  public class BooksRepository: IBooksRepository
  {
    private readonly BaseContext _context;

    public BooksRepository(BaseContext context)
    {
      _context = context;
    }

    public IEnumerable<Book> GetAll()
    {
      BooksGet booksGet = new BooksGet(_context);
      return booksGet.GetAll();
    }

    public Book GetById(int id)
    {
      BooksGet booksGet = new BooksGet(_context);
      return booksGet.GetById(id);
    }

    public Book Create(Book book)
    {
      BooksCreate booksCreate = new BooksCreate(_context);
      return booksCreate.Create(book);
    }

    public Book Update(Book book)
    {
      BooksUpdate booksUpdate  = new(_context);
      return booksUpdate.Update(book);
    }

    public int Delete(int book)
    {
      BooksDelete booksDelete = new(_context);
      return booksDelete.Delete(book);
    }
  }
}