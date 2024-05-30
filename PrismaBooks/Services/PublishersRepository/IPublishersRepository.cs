using PrismaBooks.Models;
using PrismaBooks.Services.HttpMethods;

namespace PrismaBooks.Services.PublishersRepository
{
  public interface IPublishersRepository: IHttpGet<Book>, IHttpPost<Book>, IHttpPut<Book>, IHttpDelete<Book>
  { }
}