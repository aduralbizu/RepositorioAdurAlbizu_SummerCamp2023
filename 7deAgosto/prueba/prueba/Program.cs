using EjemploMvcConversor.Servicios;
using prueba.Controllers.servicios;

//ejercicio1: En lugar de monedas normales trabajar con criptomonedas sin tocar homecontrol
//Ejercicio2: Crear un servicio que manda correos cuando te metes a privacidad. Hace falta crear 
//pasos:
// 1-Crear interfaz email
// 2- Crear dos clases mailDesarrollo y mail produccion
// 3- Configurar servicio
// 4 - agregar interfaz en el constructor
// 5 - Enviar un correo en el momento en el que va a la pagina privacy

var builder = WebApplication.CreateBuilder(args);

//++ 1- Add services to the container.
builder.Services.AddControllersWithViews(); //MVC=>Modelo vista controlador. Aunque se comente, programa eexiste porque index está
builder.Services.AddScoped<IServicioMonedas,ServicioMonedas>(); //siempre que pongas la interfaz, instanciara la clase de forma automatica

//builder.Services.AddScoped<IServicioMonedas,ServicioCriptoMonedas>(); Para qye trabaje con criptomonedas. Ejercicio resuleto


 
//Cada vez que yo pida iser.., se instanciará ServicioMonedas
var app = builder.Build();

//++2- Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{

}

//el middleware sirve para las imagenes, el css
//app.UseHttpsRedirection(); //puedes quitarlo para no entrar por puerto seguro
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
