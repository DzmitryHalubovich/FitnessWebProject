using FitnessWebProject.AplicationCore.Entities;
using FitnessWebProject.AplicationCore.Interfaces;
using FitnessWebProject.Web.Interfaces;
using FintessWebProject.Infrastructure.Services;

namespace FitnessWebProject.Web.Services
{
    public static class ConfigureCoreService
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<Users>), typeof(UsersRepository));
            services.AddScoped(typeof(IUsersViewModelService), typeof(UsersViewModelService));
            return services;
        }  
    }
}
