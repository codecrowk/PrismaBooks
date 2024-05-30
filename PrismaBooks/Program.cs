using Microsoft.EntityFrameworkCore;
using PrismaBooks.Data;
using PrismaBooks.Services.BooksRepository;

var builder = WebApplication.CreateBuilder(args);

//---- Add services to the container. ----//

// Support for minimal APIs
builder.Services.AddEndpointsApiExplorer();

// We are using controllers
builder.Services.AddControllers();

//----- PERSONAL SERVICES -----//
// Database configuration
builder.Services.AddDbContext<BaseContext> ( options => 
  options.UseMySql
  (
    // builder.Configuration.GetConnectionString("MySqlConnection"),
    builder.Configuration.GetConnectionString("MySqlConnection"),
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql")
  )
);

// Inyection of repository in Controller
builder.Services.AddScoped<IBooksRepository, BooksRepository>();

//----- END PERSONAL SERVICES -----//

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
