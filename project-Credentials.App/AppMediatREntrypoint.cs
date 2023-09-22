
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace project_Credentials.App;
public static class AppMediatREntrypoint
{
    public static void AddApplicationLayer(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());

    }
}
