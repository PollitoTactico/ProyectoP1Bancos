using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProyectoP1Bancos.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProyectoP1BancosContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProyectoP1BancosContext") ?? throw new InvalidOperationException("Connection string 'ProyectoP1BancosContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
