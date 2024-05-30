using Microsoft.AspNetCore.Mvc;
using PrismaBooks.Models;
using PrismaBooks.Services.BooksRepository;

namespace PrismaBooks.Controllers
{
  [Route("api/books")]
  [ApiController]
  public class BooksCreateController: ControllerBase
  {
    private readonly IBooksRepository _bookRepository;
    public BooksCreateController(IBooksRepository bookRepository)
    {
      _bookRepository = bookRepository;
    }

    [HttpPost]
    public Book Create([FromBody] Book book)
    {
      return _bookRepository.Create(book);
    }
  }
}