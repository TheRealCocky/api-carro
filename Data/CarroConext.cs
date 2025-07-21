using Carro.Models;
using Microsoft.EntityFrameworkCore;

namespace Carro.Data;

public class CarroConext : DbContext
{
    public CarroConext(DbContextOptions<CarroConext> options) : base(options) {}
   public DbSet<CarroModel> Carros { get; set; }
}