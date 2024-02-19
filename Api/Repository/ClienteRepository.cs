using Api.Domain.Interfaces;
using Api.Domain.Model;

namespace Api.Repository;

public class ClienteRepository : IClienteRepository
{
    public Task<SaldoClientes> GetBalanceByIdCustomer(int customerId)
    {
        throw new NotImplementedException();
    }
}