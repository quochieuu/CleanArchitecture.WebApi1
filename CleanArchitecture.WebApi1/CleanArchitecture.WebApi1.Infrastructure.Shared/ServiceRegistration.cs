using CleanArchitecture.WebApi1.Application.Interfaces;
using CleanArchitecture.WebApi1.Domain.Settings;
using CleanArchitecture.WebApi1.Infrastructure.Shared.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.WebApi1.Infrastructure.Shared
{
    public static class ServiceRegistration
    {
        public static void AddSharedInfrastructure(this IServiceCollection services, IConfiguration _config)
        {
            services.Configure<MailSettings>(_config.GetSection("MailSettings"));
            services.AddTransient<IDateTimeService, DateTimeService>();
            services.AddTransient<IEmailService, EmailService>();
        }
    }
}
