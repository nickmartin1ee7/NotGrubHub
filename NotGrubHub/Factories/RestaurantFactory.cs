using NotGrubHub.Models;

namespace NotGrubHub.Factories
{
    public static class RestaurantFactory
    {
        public static IRestaurant[] GetRestaurants() => new IRestaurant[] {
            new Restaurant(
            "McDonalds",
            new Burger[] {
                new Burger("K M Ma", "White", "Beef", "Lettuce, Tomato"),
                new Burger("K M Ma", "Rye", "Beef", "Lettuce, Tomato"),
                new Burger("Ma", "White", "Fish", "Lettuce"),
            }),

            new Restaurant(
            "Burger King",
            new Burger[] {
                new Burger("K M Ma", "White", "Beef", "Lettuce, Tomato"),
                new Burger("K M", "Rye", "Beef", "Lettuce, Tomato"),
                new Burger("Ma", "Wheat", "Chicken", "Lettuce"),
            }),

            new Restaurant(
                "Five Guys",
                new Burger[] {
                    new Burger("K M Ma", "White", "Beef", "Lettuce, Tomato"),
                    new Burger("M Ma", "Rye", "Beef", "Lettuce, Tomato"),
                    new Burger("None", "White", "Chicken", "Lettuce"),
                })
        };
    }
}
