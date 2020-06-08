using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MenuItem> temp = new List<MenuItem>();
            MenuItem lasagna = new MenuItem(25.99, "lasagna", "Dinner", false);
            MenuItem toast = new MenuItem(8.99, "toast", "Breakfast", false);
            MenuItem samich = new MenuItem(15.99, "samich", "Lunch", true); ;
            MenuItem chips = new MenuItem(6.99, "chips", "Appetizer", false);
            temp.Add(lasagna);
            temp.Add(toast);
            temp.Add(samich);
            temp.Add(chips);

            Menu cuisine = new Menu(temp, DateTime.Now);


            Console.WriteLine(cuisine);
            Console.WriteLine(cuisine.PrintMenuItem("lasagna"));
            cuisine.RemoveMeal(lasagna);
            Console.WriteLine(cuisine);
        }
    }
}
