using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public Category Course { get; private set; }
        public Boolean IsNew { get; private set; }

        public MenuItem(double price, string name, Category course, Boolean isNew)
        {
            Name = name;
            Price = price;
            Course = course;
            IsNew = isNew;
        }
    }

    public enum Category
    {
        Appetizer,
        MainCourse,
        Dessert
    }
    
}
