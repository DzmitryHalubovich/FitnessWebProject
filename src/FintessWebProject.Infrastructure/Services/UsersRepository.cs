using FitnessWebProject.AplicationCore.Entities;
using FitnessWebProject.AplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FintessWebProject.Infrastructure.Services
{
    internal class UsersRepository : IRepository<Users>
    {

        private static IList<Users> _users = new List<Users>
        {
            new Users { Name = "Volodya", Height = 179, Weight = 70},
            new Users { Name = "Max", Height = 183, Weight = 84},
            new Users { Name = "Genadiy", Height = 189, Weight =91},
        };

        public void Create(Users entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users> GetAll()
        {
            return _users;
        }

        public Users GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Users entity)
        {
            throw new NotImplementedException();
        }
    }
}
