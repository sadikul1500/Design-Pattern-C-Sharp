
namespace AbstractPattern.CapitalCityProduct;

public class Dhaka : ICapitalCity
{
    //In Million
    public int GetPopulation()
    {
        return 24;
    }

    public IList<string> GetTouristPlaces()
    {
        return new List<string> { "Curzon Hall", "HatirJheel", "Ahsan Manjil", "Bangladesh National Museum"};
    }
}
