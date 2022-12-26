using FitnessWebProject.AplicationCore.Entities;
using FitnessWebProject.AplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FintessWebProject.Infrastructure.Services
{
    public class UsersRepository : IRepository<Users>
    {

        private static IList<Users> _users = new List<Users>
        {
            new Users {Id =1, PictureUrl = "images/users/Billy.jpeg", Name = "Billy", Height = 184, Weight = 103},
            new Users {Id =2, PictureUrl = "images/users/TheMachine.png", Name = "\"Ginger\"", Height = 186, Weight = 91},
            new Users {Id =3, PictureUrl = "images/users/Rayan.webp", Name = "Genadiy", Height = 189, Weight =91},
        };

        public UsersRepository()
        {
            
        }

        public void Create(Users entity)
        {
            if (_users.Any(x=>x.Id == entity.Id))
            {
                throw new Exception("This user is already created");
            }

            _users.Add(entity);
        }

        public void Delete(int id)
        {
            var existedUser = GetById(id);

            if (existedUser != null)
            {
                int index = _users.IndexOf(existedUser);
                _users.RemoveAt(index);
            }
        }

        public IEnumerable<Users> GetAll()
        {
            return _users;
        }

        public Users? GetById(int id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);
            return user;
        }

        public void Update(Users entity)
        {
            var existingItem = GetById(entity.Id);

           if (existingItem != null)
            {
                int index =  _users.IndexOf(existingItem);
                _users[index] = entity;
            }

        }
    }
}
