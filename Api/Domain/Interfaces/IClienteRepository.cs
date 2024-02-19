using Api.Domain.Model;

namespace Api.Domain.Interfaces;

public interface IClienteRepository
{   
    Task<SaldoClientes> GetBalanceByIdCustomer(int customerId);
}
