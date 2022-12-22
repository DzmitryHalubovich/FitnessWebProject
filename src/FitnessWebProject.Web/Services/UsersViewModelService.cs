using FitnessWebProject.AplicationCore.Entities;
using FitnessWebProject.AplicationCore.Interfaces;
using FitnessWebProject.Web.Interfaces;
using FitnessWebProject.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessWebProject.Web.Services
{
    public sealed class UsersViewModelService : IUsersViewModelService
    {
        IRepository<Users> _usersRepository;

        public UsersViewModelService(IRepository<Users> usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public void CreateNewUser(UsersViewModel userViewModel)
        {
            var existingApartmentType = _usersRepository.GetAll().ToList();

            if (existingApartmentType.Any(x=>x.Id == userViewModel.Id))
            {
                var exeption = new Exception($"User {userViewModel.Id} : {userViewModel.Name} is already created");
                throw exeption;
            }

            int nextId = existingApartmentType.Max(x=>x.Id)+1;
            _usersRepository.Create(new Users() { Id = nextId, Name = userViewModel.Name, Height = userViewModel.Height,
                Weight = userViewModel.Weight, PictureUrl = userViewModel.PictureUrl});
        }

        public void DeleteUser(UsersViewModel userViewModel)
        {
            var existedUser = _usersRepository.GetById(userViewModel.Id);

            if (existedUser == null)
            {
                var exception = new Exception($"User {userViewModel.Id} : {userViewModel.Name} was not found");

                throw exception;
            }
            _usersRepository.Delete(userViewModel.Id);
        }

        public void UpdateUser(UsersViewModel userViewModel)
        {
            var extinctUser = _usersRepository.GetById(userViewModel.Id);

            if (extinctUser is null)
            {
                var exeption = new Exception($"User {userViewModel.Id} was not found");
                throw exeption;
            }

            Users.UsersDetails usersDetails = new Users.UsersDetails(userViewModel.Id ,userViewModel.Name, userViewModel.Weight,userViewModel.Height);
            extinctUser.UpdateDetails(usersDetails);
            _usersRepository.Update(extinctUser);
        }
    }
}
