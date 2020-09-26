namespace NotGrubHub.Models
{
    public interface IRestaurant
    {
        IBurger[] Menu { get; }
        string Name { get; }

        bool Order(IBurger burger, out string receipt);
    }
}