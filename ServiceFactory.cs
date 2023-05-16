using Microsoft.Extensions.DependencyInjection;
using FluentValidation;

public static class ServiceFactory
{
    public static ServiceProvider GetServiceProvider()
    {
        var services = new ServiceCollection();
        services.AddValidatorsFromAssemblyContaining<UpdateX01GameCommandValidator>();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(UpdateX01GameCommand).Assembly));
        return services.BuildServiceProvider();
    }
}