using Microsoft.AspNetCore.Mvc;
using PrismaBooks.Models;
using PrismaBooks.Services.BooksRepository;

namespace PrismaBooks.Controllers
{
  [Route("api/books")]
  [ApiController]
  public class BooksUpdateController: ControllerBase
  {
    private readonly IBooksRepository _bookRepository;
    public BooksUpdateController(IBooksRepository bookRepository)
    {
      _bookRepository = bookRepository;
    }

    [HttpPut]
    public Book Update(Book book)
    {
      return _bookRepository.Update(book);
    }
  }
}