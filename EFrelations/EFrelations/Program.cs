using EFrelations.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RelationsDbContext>(opt =>
{
    opt.UseSqlServer("Server=DESKTOP-VNR360D\\SQLEXPRESS; Database=EF_relations; Integrated Security=true");
});
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.UseStaticFiles();
app.UseRouting();

app.Run();
