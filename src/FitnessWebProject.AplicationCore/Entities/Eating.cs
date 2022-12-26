using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessWebProject.AplicationCore.Entities
{
    public sealed class Eating
    {
        public DateTime Moment { get; set; }

        public Dictionary<Food, double> Foods { get; set; }
        public Users Users { get; set; }

        public Eating(Users users) 
        {
            Users = users ?? throw new ArgumentNullException("User is can't be empty. ", nameof(users));
            Moment = DateTime.UtcNow; // для мультиязычного приложение надо UtcNow
            Foods= new Dictionary<Food, double>();
        }

        public void Add(Food food,double weight) //Обертка для удобства?
        {
            var product = Foods.Keys.FirstOrDefault(f => f.Name.Equals(food.Name));

            if (product == null)
            {
                Foods.Add(food,weight);
            }
            else
            {
                Foods[product] += weight;
            }
        }
    }
}
