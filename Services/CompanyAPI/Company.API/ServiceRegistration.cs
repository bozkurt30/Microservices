using Company.API.Infrastructure;
using Company.API.Servicess;

namespace Company.API
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddScoped<ICompanyService, CompanyService>();
        }
    }
}
