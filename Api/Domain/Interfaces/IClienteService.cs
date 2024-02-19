using Api.Domain.Model;
using Api.Domain.ValueObject;

namespace Api.Domain.Interfaces;

public interface IClienteService
{
    Task PostTransacoes(int id, Transacoes transacoes, CancellationToken cancellation = default);
    Task<SaldoClientes> GetExtrato(int id);
}
