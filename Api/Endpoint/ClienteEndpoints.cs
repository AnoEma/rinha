using Api.Domain.Interfaces;
using Api.Domain.ValueObject;
using Microsoft.AspNetCore.Mvc;

namespace Api.Endpoint;

public static class ClienteEndpoints
{
    public static void AddEndpoints(WebApplication app)
    {
        app.MapGet("api/clientes/heath", () =>
        {
            return "ok";
        });

        app.MapPost("/clientes/{id}/transacoes", async(
            [FromRoute] int id,
            [FromBody] Transacoes model,
            [FromServices] IClienteService _service,
            CancellationToken cancellation) =>
        {
            await _service.PostTransacoes(id, model, cancellation);

        });
    }
}