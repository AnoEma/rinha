using Api.Domain.Interfaces;
using Api.Domain.Model;
using Api.Domain.ValueObject;

namespace Api.Service;

public class ClienteService : IClienteService
{
    private readonly IClienteRepository _repository;
    private readonly ILogger<ClienteService> _logger;

    public ClienteService(
        IClienteRepository repository, 
        ILogger<ClienteService> logger
    )
    {
        _repository = repository;
        _logger = logger;
    }

    public Task<SaldoClientes> GetExtrato(int id)
    {
        throw new NotImplementedException();
    }

    public Task PostTransacoes(int id, Transacoes transacoes, CancellationToken cancellation = default)
    {
       var getBalance = _repository.GetBalanceByIdCustomer(id);

        if(getBalance is null)
        {
            _logger.LogInformation($"Não existe saldo para esse id: {id}");
            return Task.FromCanceled(cancellation);
        }

        return Task.FromResult(getBalance);
    }
}