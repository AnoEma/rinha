using Api.Domain.Model;
using Api.Domain.ValueObject;

namespace Api.Domain.Interfaces;

public interface IClienteService
{
    Task PostTransacoes(int id, Transacoes transacoes, CancellationToken cancellation = default);
    Task<Cliente> GetExtrato(int id, CancellationToken cancellation = default);
}