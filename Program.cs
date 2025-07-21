using Carro.Data;
using Carro.Routes;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Swagger e serviços
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configura o DbContext com PostgreSQL
builder.Services.AddDbContext<CarroConext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
       

var app = builder.Build();

// Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// HTTPS redirection
app.UseHttpsRedirection();


 // <-- ESSENCIAL
 app.CarroRoutes(); // ✅ Agora funciona como extensão

// Start da aplicação
app.Run();

