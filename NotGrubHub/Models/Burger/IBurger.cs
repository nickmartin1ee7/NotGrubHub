namespace NotGrubHub.Models
{
    public interface IBurger
    {
        string BreadType { get; set; }
        string Condiments { get; set; }
        string Meat { get; set; }
        string Veggies { get; set; }

        string ToString();
    }
}