using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> Meals { get; set; }
        public DateTime LastUpdated { get; set; }

        public Menu(List<MenuItem> meals, DateTime lastUpdated)
        {
            Meals = meals;
            LastUpdated = lastUpdated;
        }

        public bool AddMeal( MenuItem meal)
        {
            MenuItem test = new MenuItem();

            if (meal.GetType() != test.GetType())
            {
                return false;
            }

            Meals.Add(meal);
            return true;
        }

        public List<MenuItem> RemoveMeal(MenuItem meal)
        {

            if (Meals.Contains(meal))
            {
                Meals.Remove(meal);

            }
            return Meals;

        }

        public bool IsNew(MenuItem meal)
        {
            bool removed = false;
            int index = Meals.IndexOf(meal);
            if (index >= 0)
            {
                
                removed = Meals[index].IsNew;
            }
            return removed;
        }

        public string PrintMenuItem( string description)
        {
            string answer = "";
            
            foreach ( MenuItem m in Meals)
            {
                if (m.Description == description)
                {
                    answer += m.ToString() + "\n";
                }
            }


            return answer;
        }

        public override string ToString()
        {
            string output = "";

            foreach ( MenuItem m in Meals)
            {
                output += m.ToString() + "\n";
            }

            return output;
        }
    }
}
