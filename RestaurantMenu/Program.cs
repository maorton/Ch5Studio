using System;
using System.Linq;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            var Menu = new Menu();

            Console.WriteLine($"Welcome to My Menu! It was last updated {Menu.LastUpdated}.\n");

            foreach( var item in Menu.MenuItems)
            {
                Console.WriteLine($"Item: {item.Name}");
                Console.WriteLine($"Course: {item.Course}");
                Console.WriteLine($"Is New: {item.IsNew}");
                Console.WriteLine($"Price: {item.Price}");
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("Daily Special: " + Menu.MenuItems.ElementAt(0).Name);
            Console.WriteLine("-----------------------");

            Menu.MenuItems.RemoveAt(1);

            foreach (var item in Menu.MenuItems)
            {
                Console.WriteLine($"Item: {item.Name}");
                Console.WriteLine($"Course: {item.Course}");
                Console.WriteLine($"Is New: {item.IsNew}");
                Console.WriteLine($"Price: {item.Price}");
                Console.WriteLine("-----------------------");
            }

        }
    }
}
