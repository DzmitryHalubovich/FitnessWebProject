using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FitnessWebProject.AplicationCore.Entities
{
    public sealed class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public Gender Gender { get; set; }
        //public DateTime BirthDate { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public string PictureUrl { get; set; }
        //public int Age { get { return DateTime.Now.Year - BirthDate.Year; } }
    }
}
