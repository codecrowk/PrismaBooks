using PrismaBooks.Models;
using PrismaBooks.Services.HttpMethods;

namespace PrismaBooks.Services.AuthorsRepository
{
  public interface IAuthorsRepository: IHttpGet<Book>, IHttpPost<Book>, IHttpPut<Book>, IHttpDelete<Book>
  { }
}