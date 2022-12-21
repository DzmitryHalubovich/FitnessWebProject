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
        public string Name { get; }
        public Gender Gender { get; }
        public DateTime BirthDate { get; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Age { get { return DateTime.Now.Year - BirthDate.Year; } }
    }
}
