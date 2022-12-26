using FitnessWebProject.AplicationCore.Entities;

namespace FitnessWebProject.Web.Models
{
    public sealed class UsersViewModel
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public Gender? Gender { get; set; }
        //public DateTime BirthDate { get; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string? PictureUrl { get; set; }
        //public int Age { get { return DateTime.Now.Year - BirthDate.Year; } }
    }
}
