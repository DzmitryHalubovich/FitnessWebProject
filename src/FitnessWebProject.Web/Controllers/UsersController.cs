using FitnessWebProject.AplicationCore.Entities;
using FitnessWebProject.AplicationCore.Interfaces;
using FitnessWebProject.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;

namespace FitnessWebProject.Web.Controllers
{
    public class UsersController : Controller
    {
        private static List<Users> _usersList = new List<Users>
            {
                new Users { Id=1, Name = "Volodya", Height = 179, Weight = 70, PictureUrl = "images/users/Billy.jpeg"},
                new Users { Id=2, Name = "Max", Height = 183, Weight = 84, PictureUrl = "images/users/Jony.webp"},
                new Users { Id=3, Name = "Genadiy", Height = 189, Weight =91, PictureUrl = "images/users/Rayan.jpeg"},
            };

        public IActionResult Index()
        {
            var apartmentsViewModel = _usersList.Select(item => new UsersViewModel()
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
            var item = _usersList.FirstOrDefault(x => x.Id.Equals(id));

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
    }
}
