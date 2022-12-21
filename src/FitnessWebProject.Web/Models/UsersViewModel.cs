using FitnessWebProject.AplicationCore.Entities;

namespace FitnessWebProject.Web.Models
{
    public sealed class UsersViewModel
    {
        public string Name { get; }
        public Gender Gender { get; }
        public DateTime BirthDate { get; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Age { get { return DateTime.Now.Year - BirthDate.Year; } }
    }
}
