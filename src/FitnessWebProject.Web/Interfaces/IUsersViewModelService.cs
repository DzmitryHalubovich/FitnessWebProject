using FitnessWebProject.Web.Models;

namespace FitnessWebProject.Web.Interfaces
{
    public interface IUsersViewModelService
    {
        void UpdateUser(UsersViewModel userViewModel);
        void CreateNewUser(UsersViewModel userViewModel);
        void DeleteUser(UsersViewModel userViewModel);
    }
}
