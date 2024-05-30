using PrismaBooks.Models;
using PrismaBooks.Services.HttpMethods;

namespace PrismaBooks.Services.BooksRepository
{
  public interface IBooksRepository: IHttpGet<Book>, IHttpPost<Book>, IHttpPut<Book>, IHttpDelete<Book>
  { }
}