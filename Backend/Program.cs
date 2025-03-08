using Microsoft.EntityFrameworkCore;
using OpenHandsTests.Backend.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection") ?? "Data Source=mydb.db"));
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
         builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
var app = builder.Build();
app.UseCors("AllowAll");
app.MapControllers();
app.Run();
