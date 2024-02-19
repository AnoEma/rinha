using Api.Endpoint;

namespace Api;

public static class EndpointConfig
{
    public static void AddEndpoints(this WebApplication app)
    {
        ClienteEndpoints.AddEndpoints(app);
    }
}
