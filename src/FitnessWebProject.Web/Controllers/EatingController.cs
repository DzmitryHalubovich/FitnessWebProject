using FitnessWebProject.AplicationCore.Entities;
using FitnessWebProject.AplicationCore.Interfaces;

namespace FitnessWebProject.Web.Controllers
{
    //"Управляет" едой
    public sealed class EatingController
    {

        private readonly IRepository<Users> _usersRepository;

        public EatingController (IRepository<Users> usersRepository)
        {
            _usersRepository = usersRepository;
        }
    }
}
