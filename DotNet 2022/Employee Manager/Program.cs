//ASP.NET Core MVC CRUD - .NET 6 MVC CRUD Operations Using Entity Framework Core and SQL Server
//https://www.youtube.com/watch?v=2Cp8Ti_f9Gk

using Employee_Manager.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MVCDbContext>(options =>
    options.UseSqlServer(builder.Configuration
    .GetConnectionString("MvcConnectionString")));

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

//Reaz: to the middlewear, I am giving the ControllerRoute. And it has given a default route, which goes to controller-name/action-name/id(optional).
//As a default-value, I am using the HomeController and the Index action in1 the HomeController
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
