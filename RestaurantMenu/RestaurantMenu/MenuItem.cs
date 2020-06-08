using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }


        public MenuItem(double price, string description, string category, bool isNew)
        {
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }

        public MenuItem()
        {
            
        }

        public override string ToString()
        {
           return Description + " will cost " + Price + " and is a " + Category;
        }

        public override bool Equals(object toBeCompared)
        {

            if (toBeCompared == this)
            {
                return true;
            }

            if (toBeCompared == null)
            {
                return false;
            }

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            MenuItem s = toBeCompared as MenuItem;

            //&& s.Description == Description && s.Category == Category && s.IsNew == IsNew
            return s.Price == Price;
        }
    }
}
