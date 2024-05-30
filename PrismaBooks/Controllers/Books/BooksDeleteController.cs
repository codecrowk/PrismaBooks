using Microsoft.AspNetCore.Mvc;
using PrismaBooks.Models;
using PrismaBooks.Services.BooksRepository;

namespace PrismaBooks.Controllers
{
  [Route("api/books")]
  [ApiController]
  public class BooksDeleteController: ControllerBase
  {
    private readonly IBooksRepository _bookRepository;
    public BooksDeleteController(IBooksRepository bookRepository)
    {
      _bookRepository = bookRepository;
    }

    [HttpDelete("{Id}")]
    public int Delete(int Id)
    {
      return _bookRepository.Delete(Id);
    }
  }
}