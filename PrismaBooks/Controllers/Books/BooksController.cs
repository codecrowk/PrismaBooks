using Microsoft.AspNetCore.Mvc;
using PrismaBooks.Models;
using PrismaBooks.Services.BooksRepository;

namespace PrismaBooks.Controllers
{
  [Route("api/books")]
  [ApiController]
  public class BooksController: ControllerBase
  {
    private readonly IBooksRepository _bookRepository;
    public BooksController(IBooksRepository bookRepository)
    {
      _bookRepository = bookRepository;
    }

    [HttpGet]
    public IEnumerable<Book> GetAll()
    {
      return _bookRepository.GetAll();
    }

    [HttpGet("{Id}")]
    public Book GetById(int Id)
    {
      return _bookRepository.GetById(Id);
    }
  }
}