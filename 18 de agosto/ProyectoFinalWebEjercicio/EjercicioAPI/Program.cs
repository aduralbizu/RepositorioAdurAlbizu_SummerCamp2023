using Contexto;
using freecurrencyapi;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using Repositorios;
using Utilidades;

var builder = WebApplication.CreateBuilder(args);

//1-Add services as container

builder.Services.AddControllers();

//Documento de la appi:

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ContextoConversor>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:ConexionDatos"]);
});

builder.Services.AddScoped<IRepositorioMonedas, RepositorioMonedas>();
builder.Services.AddScoped<IDataCollector, DataCollector>();
builder.Services.AddScoped<Freecurrencyapi>();


var app = builder.Build();

//2-cONFIGURE THE HTTP REQUEST PIPELINE



if (app.Environment.IsDevelopment())                      
{
    app.UseSwagger(); //PREPARA LA DOCUMENTACION
    app.UseSwaggerUI(); //LA GENERA     
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints => //los mapea
{
    endpoints.MapControllers();
});

app.Run();
