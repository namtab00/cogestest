using CogesTest.DataAccess.Seeding;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CogesTest.Blazor.Infrastructure;

public static class WebHostExtensions
{
    public static IHost SeedData(this IHost host)
    {
        using var scope = host.Services.CreateScope();
        var serviceProvider = scope.ServiceProvider;

        new QuizDefinitionSeeder(serviceProvider).Seed();

        return host;
    }
}
