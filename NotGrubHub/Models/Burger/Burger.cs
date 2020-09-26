using System;
using System.Collections.Generic;
using System.Text;

namespace NotGrubHub.Models
{
    public class Burger : IBurger
    {
        public string Condiments { get; set; }
        public string BreadType { get; set; }
        public string Meat { get; set; }
        public string Veggies { get; set; }

        public Burger(string condiments, string breadType, string meat, string veggies)
        {
            Condiments = condiments;
            BreadType = breadType;
            Meat = meat;
            Veggies = veggies;
        }

        public override string ToString()
        {
            return $"{Meat} Burger with {Veggies} on {BreadType} topped with {Condiments}";
        }
    }
}
