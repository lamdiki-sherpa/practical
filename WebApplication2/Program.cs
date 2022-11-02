using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//string connectionString = "Data Source=DESKTOP-GKJ3J6I;Initial Catalog=asmt;User ID=sa;Password=dotnet123";
//builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connectionString));
string connectionString = "Data Source=DESKTOP-GKJ3J6I;Initial Catalog=asmt;User ID=sa;Password=dotnet123";
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connectionString));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
