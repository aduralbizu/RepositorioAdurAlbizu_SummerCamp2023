using EjemploAutenticacionWeb.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//+ 1- Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection"); ///Obtener cadena de conexion
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString)); //captura contexto de base de datos
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>(); //Servicio de identidades. Cuenta debe estar confirmada. Identity utiliza entity framework para guarar usuarios
builder.Services.AddControllersWithViews();

var app = builder.Build();

//+ 2- Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) //entorno para usar migracion
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
