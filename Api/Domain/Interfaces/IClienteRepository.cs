using Api.Domain.Model;

namespace Api.Domain.Interfaces;

public interface IClienteRepository
{   
    Task<Cliente> GetBalanceByCustomerId(int customerId, CancellationToken cancellation = default);
    Task PostTransactions(CancellationToken cancellation = default);
}