using FitnessWebProject.AplicationCore.Entities;
using FitnessWebProject.AplicationCore.Interfaces;
using FitnessWebProject.Web.Interfaces;
using FitnessWebProject.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessWebProject.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersViewModelService _usersViewModelService;
        private readonly IRepository<Users> _usersRepository;

        public UsersController(IRepository<Users> usersRepository,
            IUsersViewModelService usersViewModelService)
        {
            _usersRepository = usersRepository;
            _usersViewModelService = usersViewModelService;
        }

        public IActionResult Index()
        {
            var apartmentsViewModel = _usersRepository.GetAll().Select(item => new UsersViewModel()
            {
                Id = item.Id,
                Name = item.Name,
                //Gender= item.Gender,
                Height= item.Height,
                Weight = item.Weight,
                PictureUrl = item.PictureUrl,
            }).ToList();

            return View(apartmentsViewModel);
        }

        public IActionResult Details(int id)
        {
            //var item = _catalogItems.FirstOrDefault(x => x.Id == id);
            var item = _usersRepository.GetAll().FirstOrDefault(x => x.Id.Equals(id));

            if (item == null) return RedirectToAction("Index");

            var result = new UsersViewModel()
            {
                Id = item.Id,
                Name = item.Name,
                Height = item.Height,
                Weight = item.Weight,
                PictureUrl = item.PictureUrl
            };
            return View(result);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var users = _usersRepository.GetById(id);
            if (users is null)
            {
                return RedirectToAction("Index");
            }

            var result = new UsersViewModel()
            {
                Id = users.Id,
                Name = users.Name,
                Height = users.Height,
                Weight = users.Weight,
                PictureUrl = users.PictureUrl
            };

            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(UsersViewModel usersViewModel)
        {
            try
            {
                _usersViewModelService.UpdateUser(usersViewModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        
        [HttpGet]
        public IActionResult Delete(int id)
        {
             var extinctUser = _usersRepository.GetById(id);

            if (extinctUser is null)
            {
                RedirectToAction("Index");
            }

            var result = new UsersViewModel()
            {
                Id = extinctUser.Id,
                Name = extinctUser.Name,
                Height = extinctUser.Height,
                Weight = extinctUser.Weight,
                PictureUrl = extinctUser.PictureUrl
            };

            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(UsersViewModel userViewModel)
        {
            try
            {
                _usersViewModelService.DeleteUser(userViewModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
