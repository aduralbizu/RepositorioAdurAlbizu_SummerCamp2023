var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hola mundo!"); //Expresion lambda | As� se generan las p�ginas web: app.MapGet(direccio�n, accion);

app.Run();
