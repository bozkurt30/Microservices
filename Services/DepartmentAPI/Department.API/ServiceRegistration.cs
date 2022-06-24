using Department.API.Infrastructure;
using Department.API.Services;

namespace Department.API
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddScoped<IDepartmentService, DepartmentService>();
        }
    }
}
