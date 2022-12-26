using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessWebProject.AplicationCore.Entities
{
    public sealed class Food
    {
        public string Name { get; set; }

        public double Proteins { get; set; }

        //Жиры
        public double Fats { get; set; }

        //Углеводы
        public double Carbohydrates { get; set; }

        //Калории за 10 грамм продукта
        public double Calories { get; set; }

        private double CalloriesOneGramm { get { return Calories/100.0; } }

        private double ProteinsOneGramm { get { return Proteins/100.0; } }
        private double FatsOneGramm { get { return Fats/100.0; } }

        private double CarbohydratesOneGramm { get { return Carbohydrates/100.0; } }
    }
}
