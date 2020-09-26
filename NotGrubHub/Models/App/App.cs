using NotGrubHub.Factories;
using static System.Console;

namespace NotGrubHub.Models
{
    public class App : IApp
    {
        private ILogger _logger { get; set; }

        public App(ILogger logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            IRestaurant[] restaurants = RestaurantFactory.GetRestaurants();
            while (true)
            {
                Clear();

                PointOfSales(restaurants);

                WriteLine("Press any key to order again!");
                ReadKey();
            }
        }

        private void PointOfSales(IRestaurant[] restaurants)
        {
            IRestaurant reqRestaurant = UserRestaurant(restaurants);
            if (reqRestaurant != null)
            {
                string receipt = "No order";
                IBurger reqBurger = UserBurger(reqRestaurant);
                if (reqBurger != null && reqRestaurant.Order(reqBurger, out receipt))
                    _logger.Log($"Burger ordered @ {reqRestaurant} for {reqBurger}");
                else
                    _logger.Log($"Failed to order Burger @ {reqRestaurant}");
                WriteLine(receipt);
            }
            else WriteLine("Invalid restaurant selection!");
        }

        private IBurger UserBurger(IRestaurant restaurant)
        {
            WriteLine("Select a burger from the menu:");

            for (int i = 0; i < restaurant.Menu.Length; i++)
            {
                WriteLine($"{i + 1}: {restaurant.Menu[i]}");
            }

            Write("Menu Item> ");
            if (int.TryParse(ReadLine(), out int uBurger))
            {
                uBurger--;
                if (uBurger >= 0 && uBurger < restaurant.Menu.Length)
                {
                    return restaurant.Menu[uBurger];
                }
            }
            return null;
        }

        private IRestaurant UserRestaurant(IRestaurant[] restaurants)
        {
            WriteLine("Available restaurants:");
            for (int i = 0; i < restaurants.Length; i++)
            {
                WriteLine($"{i + 1}: {restaurants[i]}");
            }

            Write("Order From> ");
            if (int.TryParse(ReadLine(), out int uRestaurant))
            {
                uRestaurant--;
                if (uRestaurant >= 0 && uRestaurant < restaurants.Length)
                {
                    return restaurants[uRestaurant];
                }
            }
            return null;
        }
    }
}
