namespace PrismaBooks.Services.HttpMethods
{
  public interface IHttpDelete<T>
  {
    int Delete(int id); 
  }
}