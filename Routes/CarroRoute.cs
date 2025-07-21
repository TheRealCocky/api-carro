using Carro.Data;
using Carro.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Carro.Routes;

public static class CarroRoute
{
    public static void CarroRoutes(this WebApplication app)
    {
        var routes = app.MapGroup("/carro");

        // Rota POST para criar um novo carro
        routes.MapPost("", async (CarroConext db, CarroDto dto) =>
        {
            var carro = new CarroModel
            {
                Marca = dto.Marca,
                Modelo = dto.Modelo,
                Cor = dto.Cor,
                Placa = dto.Placa,
                Ano = dto.Ano,
                Km = dto.Km,
                Combustivel = dto.Combustivel,
                Status = dto.Status,
                Imagem = dto.Imagem
            };

            db.Carros.Add(carro);
            await db.SaveChangesAsync();

            return Results.Created($"/carro/{carro.Id}", carro);
        });
        
        routes.MapGet("", async (CarroConext db) =>
        {
            var carros = await db.Carros.ToListAsync();
            return Results.Ok(carros);
        });

        routes.MapPut("{id}", async (Guid id, CarroConext db, CarroDto dto) =>
        {
            var carroExistente = await db.Carros.FirstOrDefaultAsync(x => x.Id == id);
            if (carroExistente is null) return Results.NotFound();

            var carroAtualizado = carroExistente with
            {
                Marca = dto.Marca,
                Modelo = dto.Modelo,
                Cor = dto.Cor,
                Placa = dto.Placa,
                Ano = dto.Ano,
                Km = dto.Km,
                Combustivel = dto.Combustivel,
                Status = dto.Status,
                Imagem = dto.Imagem
            };

            db.Entry(carroExistente).CurrentValues.SetValues(carroAtualizado);
            await db.SaveChangesAsync();

            return Results.Ok(carroAtualizado);
        });

        routes.MapDelete("{id}",
            async (Guid id, CarroConext db) =>
        {
            var carroExistente = await db.Carros.FirstOrDefaultAsync(x => x.Id == id);
            if (carroExistente is null) return Results.NotFound();
           db.Carros.Remove(carroExistente);
           await db.SaveChangesAsync();
            return Results.Ok(carroExistente);
        });

    }
}