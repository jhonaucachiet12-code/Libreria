using BibliotecaApi.Repositories;
using BibliotecaApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<IAutorRepository,AutorRepositeryMemoria>();
builder.Services.AddScoped<autorService>();


//le indicamos que cuando encuentre un variable de tipo ILibroRepository, use la clase LibroRepositoryMemoria
builder.Services.AddScoped<ILibroRepository, LibroRepositoryMemoria>();

builder.Services.AddScoped<LibroService>();

builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  //app.UseSwagger();
  //  app.UseSwaggerUI();
}

app.MapControllers();

app.Run();


//http://localhost:5051/api/Autores
