using Contexto;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Perfiles;
using Repositorios;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

using API;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ContextoPersonas>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:ConexionDatos"]);
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepositorioPersonas, IRepositorioPersonas>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
