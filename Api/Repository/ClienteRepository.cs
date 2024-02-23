using Api.Domain.Interfaces;
using Api.Domain.Model;

namespace Api.Repository;

public class ClienteRepository : IClienteRepository
{
    public Task<int> CreateCustomer(Cliente saldoClientes, CancellationToken cancellation)
    {
        throw new NotImplementedException();
    }

    public Task<Cliente> GetBalanceByCustomerId(int customerId, CancellationToken cancellation = default)
    {
        throw new NotImplementedException();
    }

    public Task PostTransactions(CancellationToken cancellation = default)
    {
        throw new NotImplementedException();
    }
}