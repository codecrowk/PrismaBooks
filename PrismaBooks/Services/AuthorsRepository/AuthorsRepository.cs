using PrismaAuthors.Data;
using PrismaAuthors.Services.AuthorsRepository;
using PrismaBooks.Models;

namespace PrismaAuthor.Services.AuthorsRepository
{
  public class AuthorsRepository: IAuthorsRepository
  {
    private readonly BaseContext _context;

    public AuthorsRepository(BaseContext context)
    {
      _context = context;
    }

    public IEnumerable<Author> GetAll()
    {
      AuthorGet authorsGet = new AuthorGet(_context);
      return authorsGet.GetAll();
    }

    public Author GetById(int id)
    {
      AuthorGet authorsGet = new AuthorGet(_context);
      return AuthorsGet.GetById(id);
    }

    public Author Create(Author Author)
    {
      AuthorCreate authorsCreate = new AuthorCreate(_context);
      return authorsCreate.Create(Author);
    }

    public Author Update(Author Author)
    {
      AuthorUpdate authorsUpdate  = new(_context);
      return authorsUpdate.Update(Author);
    }

    public int Delete(int Author)
    {
      AuthorDelete authorsDelete = new(_context);
      return authorsDelete.Delete(Author);
    }
  }
}