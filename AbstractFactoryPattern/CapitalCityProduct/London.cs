
namespace AbstractPattern.CapitalCityProduct;

public class London : ICapitalCity
{
    //In Million
    public int GetPopulation()
    {
        return 10;
    }

    public IList<string> GetTouristPlaces()
    {
        return new List<string> { "Tower Bridge", "Big Ben", "Buckingham Palace", "British Museum" };
    }
}
