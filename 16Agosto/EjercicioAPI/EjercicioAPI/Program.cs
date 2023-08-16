using Microsoft.AspNetCore.StaticFiles;

var builder = WebApplication.CreateBuilder(args);

//1-Add services as container

builder.Services.AddControllers();

//Documento de la appi:

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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
