using Microsoft.EntityFrameworkCore;
using StudentApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add EF Core with SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=students.db"));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();
app.UseAuthorization();

app.MapControllerRoute( 
    name: "default",
    pattern: "{controller=Student}/{action=Index}/{id?}");

app.Run();
