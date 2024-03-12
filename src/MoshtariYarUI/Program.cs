using Contracts;
using Data;
using Databases;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddScoped<IRepository,EfRepository>();
builder.Services.AddDbContext<AppDbContext>(o=>o.UseSqlServer("server=(LocalDb)\\MSSQLLocalDB; Initial Catalog=MaktabSharif-104-MoshtariYar; Integrated Security=True;"));


var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
