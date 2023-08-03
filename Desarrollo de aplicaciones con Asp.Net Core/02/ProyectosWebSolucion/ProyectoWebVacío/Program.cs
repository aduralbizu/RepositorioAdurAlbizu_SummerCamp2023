var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hola mundo!"); //Expresion lambda | Así se generan las páginas web: app.MapGet(direccioón, accion);

app.Run();
