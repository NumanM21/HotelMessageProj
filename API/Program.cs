using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Services we want to use in our application are added here
builder.Services.AddDbContext<DataContext>(options => 
{ 
  options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")); // DefaultConnection is the name of the connection string in appsettings.json
});


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
