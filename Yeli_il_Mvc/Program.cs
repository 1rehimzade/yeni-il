using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Yeli_il_Mvc.DAL;
using Yeli_il_Mvc.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt=>opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddScoped<LayoutService>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());


var app = builder.Build();
app.UseStaticFiles();
app.UseAuthorization();

app.MapControllerRoute(
    "Default",
    "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    "defalut",
    "{controller=home}/{action=index}/{id?}"


);

app.Run();
