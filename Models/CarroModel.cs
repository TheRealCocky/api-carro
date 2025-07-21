namespace Carro.Models;

public record CarroModel
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Marca { get; init; }
    public string Modelo { get; init; }
    public string Cor { get; init; }
    public string Placa { get; init; }
    public string Ano { get; init; }
    public string Km { get; init; }
    public string Combustivel { get; init; }
    public string Status { get; init; }
    public string Imagem { get; init; }
}

