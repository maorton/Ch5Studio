using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RestaurantMenu
{
    public class Menu
    {
        public DateTime LastUpdated { get; private set; }
        public List<MenuItem> MenuItems { get; private set; }

        public Menu()
        {
            LastUpdated = DateTime.Now;
            MenuItems = new List<MenuItem>
            {
                new MenuItem(10.00, "pizza", Category.MainCourse, false),
                new MenuItem(8.00, "cheesecake", Category.Dessert, true),
                new MenuItem(4.00, "fries", Category.Appetizer, false),
                new MenuItem(2.00, "shake", Category.Dessert, true)
            };
        }
        public Menu(DateTime lastUpdated, List<MenuItem> menuItems)
        {
            LastUpdated = lastUpdated;
            MenuItems = menuItems;
        }

        public string GetName()
        {
            return "";
        }
    }
}
