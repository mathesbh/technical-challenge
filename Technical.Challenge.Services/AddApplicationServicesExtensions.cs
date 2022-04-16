using Microsoft.Extensions.DependencyInjection;
using Technical.Challenge.Domain.Interfaces;

namespace Technical.Challenge.Services
{
    public static class AddApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicatonServices(this IServiceCollection services)
        {
            services.AddTransient<IDivisorsServices, DivisorsService>();

            return services;
        }
    }
}
