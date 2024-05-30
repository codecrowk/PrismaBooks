namespace PrismaBooks.Services.HttpMethods
{
  public interface IHttpPut<T>
  {
    T Update(T model);
  }
}