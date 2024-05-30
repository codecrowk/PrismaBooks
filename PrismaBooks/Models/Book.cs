namespace PrismaBooks.Models
{
  public class Book
  {
    public int Id {get; set;} 
    public string Title {get; set;}
    public int Pages {get; set;}
    public string Language {get; set;}
    public DateOnly PublicationDate {get; set;}
    public string Description {get; set;}
    public bool Status {get; set;}
    public int IdAuthor {get; set;}
    public int IdPublisher {get; set;}
  }
}