using Api.Domain.Model;

namespace Api.Domain.ValueObject;

public record Transacoes
{
    public required int valor { get; init; }
    public required Tipos tipo { get; init; }
    public required string descricao { get; init; }
}