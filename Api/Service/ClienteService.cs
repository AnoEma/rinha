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

    public async Task<Cliente> GetExtrato(int id, CancellationToken cancellation = default)
    {
        var getBalance = await _repository.GetBalanceByCustomerId(id, cancellation);
        return getBalance;
    }

    public async Task PostTransacoes(int id, Transacoes transacoes, CancellationToken cancellation = default)
    {
       var getBalance = await _repository.GetBalanceByCustomerId(id, cancellation);

        if(getBalance is null)
        {
            _logger.LogInformation($"Não existe saldo para esse id: {id}");
            await Task.FromCanceled(cancellation);
        }
    }   
}