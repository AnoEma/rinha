namespace Api.Endpoint;

public static class ClienteEndpoints
{
    public static void AddEndpoints(WebApplication app)
    {
        app.MapGet("api/clientes/heath-check", () =>
        {
            return "ok";
        });

    }
}