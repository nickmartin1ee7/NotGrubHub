using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotGrubHub.Models
{
    public class Restaurant : IRestaurant
    {
        public string Name { get; private set; }
        public IBurger[] Menu { get; private set; }

        public Restaurant(string name, IBurger[] menu)
        {
            Name = name;
            Menu = menu;
        }

        public bool Order(IBurger burger, out string receipt)
        {
            if (Menu.Contains(burger))
            {
                receipt = $"Order successfull for a {burger}. Please come again!";
                return true;
            }
            receipt = "That burger is not on the menu!";
            return false;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
