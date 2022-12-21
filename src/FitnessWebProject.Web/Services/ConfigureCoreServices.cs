using FitnessWebProject.AplicationCore.Entities;
using FitnessWebProject.AplicationCore.Interfaces;
using FitnessWebProject.Web.Models;

namespace FitnessWebProject.Web.Services
{
    public static class ConfigureCoreServices
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<Users>), typeof(UsersViewModel));
            return services;
        }  
    }
}
