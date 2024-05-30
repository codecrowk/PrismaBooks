using PrismaBooks.Models;

namespace PrismaBooks.Services.HttpMethods
{
  public interface IHttpGet<T>
  {
    IEnumerable<T> GetAll();
    T GetById(int id);
  }
}