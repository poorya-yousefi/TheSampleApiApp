using TheSampleApi.Endpoints;

namespace TheSampleApi.Startup;

public static class ApiEndpointsConfig
{
    public static void AddApiEndpoints(this WebApplication app)
    {
        app.AddRootEndpoints();
        app.AddPersonEndpoints();
    }
}