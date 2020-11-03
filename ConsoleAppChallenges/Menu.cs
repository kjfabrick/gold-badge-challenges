using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChallenges
{
    public class Menu
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public double MealID { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        public Menu() { }
        public Menu(int mealNumber, string mealName, string description, double mealID, string ingredients, double price);
    }
}
